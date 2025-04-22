using System;
using System.Windows.Forms;

namespace ICCS_HW_CFG
{
    public partial class RoleSelectionForm : Form
    {
        private User _user;

        public RoleSelectionForm(User user)
        {
            InitializeComponent();
            _user = user;
            labelWelcome.Text = $"{user.Username}! Choose your role:";
        }

        private void buttonEngineering_Click(object sender, EventArgs e)
        {
            new Form3().Show(); // Signup window
            this.Hide();
        }

        private void buttonMaintenance_Click(object sender, EventArgs e)
        {
            new Form1().Show(); // Dashboard
            this.Hide();
        }
    }
}
