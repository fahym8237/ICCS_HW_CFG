namespace ICCS_HW_CFG
{
    partial class RoleSelectionForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelWelcome;
        private Button buttonEngineering;
        private Button buttonMaintenance;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelWelcome = new Label();
            this.buttonEngineering = new Button();
            this.buttonMaintenance = new Button();

            // Form Styling
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.ClientSize = new System.Drawing.Size(400, 160);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Select Role";
            this.MaximizeBox = false;

            // LabelWelcome
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Text = "Choose your role:";
            this.labelWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new Point(100, 20);

            // ButtonEngineering
            this.buttonEngineering.Text = "Engineering";
            this.buttonEngineering.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.buttonEngineering.Size = new Size(120, 40);
            this.buttonEngineering.Location = new Point(60, 80);
            this.buttonEngineering.BackColor = System.Drawing.Color.FromArgb(50, 150, 250);
            this.buttonEngineering.ForeColor = System.Drawing.Color.White;
            this.buttonEngineering.FlatStyle = FlatStyle.Flat;
            this.buttonEngineering.FlatAppearance.BorderSize = 0;
            this.buttonEngineering.Cursor = Cursors.Hand;
            this.buttonEngineering.Click += new EventHandler(this.buttonEngineering_Click);

            // ButtonMaintenance
            this.buttonMaintenance.Text = "Maintenance";
            this.buttonMaintenance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.buttonMaintenance.Size = new Size(120, 40);
            this.buttonMaintenance.Location = new Point(230, 80);
            this.buttonMaintenance.BackColor = System.Drawing.Color.FromArgb(60, 200, 140);
            this.buttonMaintenance.ForeColor = System.Drawing.Color.White;
            this.buttonMaintenance.FlatStyle = FlatStyle.Flat;
            this.buttonMaintenance.FlatAppearance.BorderSize = 0;
            this.buttonMaintenance.Cursor = Cursors.Hand;
            this.buttonMaintenance.Click += new EventHandler(this.buttonMaintenance_Click);

            // Add Controls
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonEngineering);
            this.Controls.Add(this.buttonMaintenance);
        }

    }
}
