﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace ICCS_HW_CFG
{
    public partial class Form3 : Form
    {
        private string settingsFilePath = Path.Combine(Application.StartupPath, "iccs_users.json");

        public Form3()
        {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            List<string> roles = new List<string>();

            if (checkBoxEngineering.Checked) roles.Add("Engineering");
            if (checkBoxMaintenance.Checked) roles.Add("Maintenance");

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || roles.Count == 0)
            {
                MessageBox.Show("Please fill all fields.", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<User> users = File.Exists(settingsFilePath)
                ? JsonSerializer.Deserialize<List<User>>(File.ReadAllText(settingsFilePath))
                : new List<User>();

            users.Add(new User { Username = username, Password = password, LoginType = roles });
            File.WriteAllText(settingsFilePath, JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true }));

            MessageBox.Show("Account created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
