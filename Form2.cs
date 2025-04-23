using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace ICCS_HW_CFG
{
    public partial class Form2 : Form
    {
        private string settingsFilePath = Path.Combine(Application.StartupPath, "iccs_users.json");

        public Form2()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (!File.Exists(settingsFilePath))
            {
                MessageBox.Show("Data file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var jsonData = File.ReadAllText(settingsFilePath);
            var users = JsonSerializer.Deserialize<List<User>>(jsonData);

            var matchedUser = users.Find(u => u.Username == username && u.Password == password);

            if (matchedUser == null)
            {
                MessageBox.Show("Invalid credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matchedUser.LoginType.Contains("Engineering") && matchedUser.LoginType.Contains("Maintenance"))
            {
                new RoleSelectionForm(matchedUser).Show();
            }
            else if (matchedUser.LoginType.Contains("Engineering"))
            {
                new Form3().Show();
            }
            else if (matchedUser.LoginType.Contains("Maintenance"))
            {
                new Form1(matchedUser).Show();

            }
        }
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<string> LoginType { get; set; }
    }
}
