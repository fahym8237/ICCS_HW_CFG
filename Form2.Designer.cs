namespace ICCS_HW_CFG
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonLogin;
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
            this.buttonLogin = new Button();
            this.labelUsername = new Label();
            this.labelPassword = new Label();

            this.SuspendLayout();

            // textBoxUsername
            this.textBoxUsername.Location = new System.Drawing.Point(150, 50);
            this.textBoxUsername.Size = new System.Drawing.Size(200, 23);

            // textBoxPassword
            this.textBoxPassword.Location = new System.Drawing.Point(150, 100);
            this.textBoxPassword.Size = new System.Drawing.Size(200, 23);
            this.textBoxPassword.UseSystemPasswordChar = true;

            // buttonLogin
            this.buttonLogin.Location = new System.Drawing.Point(175, 150);
            this.buttonLogin.Size = new System.Drawing.Size(100, 30);
            this.buttonLogin.Text = "Login";
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);

            // labelUsername
            this.labelUsername.Location = new System.Drawing.Point(50, 50);
            this.labelUsername.Text = "Username:";
            this.labelUsername.AutoSize = true;

            // labelPassword
            this.labelPassword.Location = new System.Drawing.Point(50, 100);
            this.labelPassword.Text = "Password:";
            this.labelPassword.AutoSize = true;

            // Form2
            this.ClientSize = new System.Drawing.Size(400, 220);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelPassword);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Login";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
