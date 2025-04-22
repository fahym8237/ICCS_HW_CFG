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
        private Label labelTitle;
        private CheckBox checkBoxShowPassword;
        private Panel panelContainer;

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
            this.labelTitle = new Label();
            this.checkBoxShowPassword = new CheckBox();
            this.panelContainer = new Panel();

            this.SuspendLayout();

            // Panel Container
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.panelContainer.Dock = DockStyle.Fill;
            this.panelContainer.Padding = new Padding(20);
            this.panelContainer.Controls.Add(this.labelTitle);
            this.panelContainer.Controls.Add(this.labelUsername);
            this.panelContainer.Controls.Add(this.textBoxUsername);
            this.panelContainer.Controls.Add(this.labelPassword);
            this.panelContainer.Controls.Add(this.textBoxPassword);
            this.panelContainer.Controls.Add(this.checkBoxShowPassword);
            this.panelContainer.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.panelContainer);

            // Title Label
            this.labelTitle.Text = "ICCS Login";
            this.labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            this.labelTitle.ForeColor = Color.White;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new Point(135, 20);

            // Username Label
            this.labelUsername.Text = "Username:";
            this.labelUsername.Font = new Font("Segoe UI", 10F);
            this.labelUsername.ForeColor = Color.White;
            this.labelUsername.Location = new Point(50, 80);
            this.labelUsername.AutoSize = true;

            // Username TextBox
            this.textBoxUsername.Location = new Point(150, 75);
            this.textBoxUsername.Size = new Size(200, 25);
            this.textBoxUsername.Font = new Font("Segoe UI", 10F);

            // Password Label
            this.labelPassword.Text = "Password:";
            this.labelPassword.Font = new Font("Segoe UI", 10F);
            this.labelPassword.ForeColor = Color.White;
            this.labelPassword.Location = new Point(50, 130);
            this.labelPassword.AutoSize = true;

            // Password TextBox
            this.textBoxPassword.Location = new Point(150, 125);
            this.textBoxPassword.Size = new Size(200, 25);
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.Font = new Font("Segoe UI", 10F);

            // Show Password Checkbox
            this.checkBoxShowPassword.Text = "Show Password";
            this.checkBoxShowPassword.ForeColor = Color.White;
            this.checkBoxShowPassword.Location = new Point(150, 160);
            this.checkBoxShowPassword.CheckedChanged += (s, e) =>
            {
                this.textBoxPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
            };

            // Login Button
            this.buttonLogin.Text = "Login";
            this.buttonLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.buttonLogin.Size = new Size(100, 35);
            this.buttonLogin.Location = new Point(150, 200);
            this.buttonLogin.BackColor = Color.FromArgb(50, 150, 250);
            this.buttonLogin.ForeColor = Color.White;
            this.buttonLogin.FlatStyle = FlatStyle.Flat;
            this.buttonLogin.Click += new EventHandler(this.buttonLogin_Click);

            // Form2
            this.BackColor = Color.FromArgb(20, 20, 20);
            this.ClientSize = new Size(400, 280);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Login";

            this.ResumeLayout(false);
        }
    }
}
