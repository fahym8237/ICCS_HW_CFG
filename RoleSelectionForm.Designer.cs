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

            // labelWelcome
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelWelcome.Location = new System.Drawing.Point(30, 20);
            this.labelWelcome.Size = new System.Drawing.Size(300, 21);

            // buttonEngineering
            this.buttonEngineering.Text = "Engineering";
            this.buttonEngineering.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonEngineering.Location = new System.Drawing.Point(30, 60);
            this.buttonEngineering.Size = new System.Drawing.Size(120, 40);
            this.buttonEngineering.Click += new System.EventHandler(this.buttonEngineering_Click);

            // buttonMaintenance
            this.buttonMaintenance.Text = "Maintenance";
            this.buttonMaintenance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonMaintenance.Location = new System.Drawing.Point(160, 60);
            this.buttonMaintenance.Size = new System.Drawing.Size(120, 40);
            this.buttonMaintenance.Click += new System.EventHandler(this.buttonMaintenance_Click);

            // RoleSelectionForm
            this.ClientSize = new System.Drawing.Size(320, 130);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonEngineering);
            this.Controls.Add(this.buttonMaintenance);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Select Role";
        }
    }
}
