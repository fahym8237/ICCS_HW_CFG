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

            // textBoxUsername
            this.textBoxUsername.Location = new System.Drawing.Point(150, 30);
            this.textBoxUsername.Size = new System.Drawing.Size(200, 23);

            // textBoxPassword
            this.textBoxPassword.Location = new System.Drawing.Point(150, 70);
            this.textBoxPassword.Size = new System.Drawing.Size(200, 23);
            this.textBoxPassword.UseSystemPasswordChar = true;

            // checkBoxEngineering
            this.checkBoxEngineering.Location = new System.Drawing.Point(150, 110);
            this.checkBoxEngineering.Text = "Engineering";

            // checkBoxMaintenance
            this.checkBoxMaintenance.Location = new System.Drawing.Point(150, 140);
            this.checkBoxMaintenance.Text = "Maintenance";

            // buttonSignUp
            this.buttonSignUp.Location = new System.Drawing.Point(175, 180);
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.Click += new EventHandler(this.buttonSignUp_Click);

            // labelUsername
            this.labelUsername.Location = new System.Drawing.Point(50, 30);
            this.labelUsername.Text = "Username:";
            this.labelUsername.AutoSize = true;

            // labelPassword
            this.labelPassword.Location = new System.Drawing.Point(50, 70);
            this.labelPassword.Text = "Password:";
            this.labelPassword.AutoSize = true;

            // Form3
            this.ClientSize = new System.Drawing.Size(400, 240);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.checkBoxEngineering);
            this.Controls.Add(this.checkBoxMaintenance);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelPassword);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Sign Up";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
