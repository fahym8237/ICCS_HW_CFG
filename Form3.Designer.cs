namespace ICCS_HW_CFG
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private CheckBox checkBoxEngineering;
        private CheckBox checkBoxMaintenance;
        private Button buttonSignUp;
        private Label labelUsername;
        private Label labelPassword;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxUsername = new TextBox();
            this.textBoxPassword = new TextBox();
            this.checkBoxEngineering = new CheckBox();
            this.checkBoxMaintenance = new CheckBox();
            this.buttonSignUp = new Button();
            this.labelUsername = new Label();
            this.labelPassword = new Label();

            this.SuspendLayout();

            // Form3 Styling
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.ClientSize = new System.Drawing.Size(400, 260);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Sign Up";

            // textBoxUsername
            this.textBoxUsername.Location = new System.Drawing.Point(150, 30);
            this.textBoxUsername.Size = new System.Drawing.Size(200, 25);
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.textBoxUsername.ForeColor = System.Drawing.Color.White;
            this.textBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxUsername.Font = new Font("Segoe UI", 10F);

            // textBoxPassword
            this.textBoxPassword.Location = new System.Drawing.Point(150, 70);
            this.textBoxPassword.Size = new System.Drawing.Size(200, 25);
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.textBoxPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new Font("Segoe UI", 10F);

            // checkBoxEngineering
            this.checkBoxEngineering.Location = new System.Drawing.Point(150, 110);
            this.checkBoxEngineering.Text = "Engineering";
            this.checkBoxEngineering.ForeColor = System.Drawing.Color.White;
            this.checkBoxEngineering.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEngineering.Font = new Font("Segoe UI", 10F);

            // checkBoxMaintenance
            this.checkBoxMaintenance.Location = new System.Drawing.Point(150, 140);
            this.checkBoxMaintenance.Text = "Maintenance";
            this.checkBoxMaintenance.ForeColor = System.Drawing.Color.White;
            this.checkBoxMaintenance.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxMaintenance.Font = new Font("Segoe UI", 10F);

            // buttonSignUp
            this.buttonSignUp.Location = new System.Drawing.Point(150, 180);
            this.buttonSignUp.Size = new System.Drawing.Size(100, 35);
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.buttonSignUp.BackColor = System.Drawing.Color.FromArgb(70, 130, 250);
            this.buttonSignUp.ForeColor = System.Drawing.Color.White;
            this.buttonSignUp.FlatStyle = FlatStyle.Flat;
            this.buttonSignUp.FlatAppearance.BorderSize = 0;
            this.buttonSignUp.Cursor = Cursors.Hand;
            this.buttonSignUp.Click += new EventHandler(this.buttonSignUp_Click);

            // labelUsername
            this.labelUsername.Location = new System.Drawing.Point(50, 30);
            this.labelUsername.Text = "Username:";
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new Font("Segoe UI", 10F);

            // labelPassword
            this.labelPassword.Location = new System.Drawing.Point(50, 70);
            this.labelPassword.Text = "Password:";
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new Font("Segoe UI", 10F);

            // Add Controls
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.checkBoxEngineering);
            this.Controls.Add(this.checkBoxMaintenance);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelPassword);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

    }
}
