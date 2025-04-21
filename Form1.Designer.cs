namespace ICCS_HW_CFG
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxTraceability;
        private System.Windows.Forms.GroupBox groupBoxPOS;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.ComboBox comboBoxSetStatus;
        private System.Windows.Forms.Button btnCheckStatus;
        private System.Windows.Forms.Button btnSetStatus;

        private System.Windows.Forms.Label lblPOS1;
        private System.Windows.Forms.Label lblPOS2;
        private System.Windows.Forms.Label lblPOS3;
        private System.Windows.Forms.Label lblPOS4;
        private System.Windows.Forms.ComboBox comboBoxPOS1;
        private System.Windows.Forms.ComboBox comboBoxPOS2;
        private System.Windows.Forms.ComboBox comboBoxPOS3;
        private System.Windows.Forms.ComboBox comboBoxPOS4;
        private System.Windows.Forms.Button btnSetPOS;

        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button btnLoadFile;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBoxTraceability = new System.Windows.Forms.GroupBox();
            this.groupBoxPOS = new System.Windows.Forms.GroupBox();

            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.comboBoxSetStatus = new System.Windows.Forms.ComboBox();
            this.btnSetStatus = new System.Windows.Forms.Button();
            this.btnCheckStatus = new System.Windows.Forms.Button();

            this.lblPOS1 = new System.Windows.Forms.Label();
            this.lblPOS2 = new System.Windows.Forms.Label();
            this.lblPOS3 = new System.Windows.Forms.Label();
            this.lblPOS4 = new System.Windows.Forms.Label();
            this.comboBoxPOS1 = new System.Windows.Forms.ComboBox();
            this.comboBoxPOS2 = new System.Windows.Forms.ComboBox();
            this.comboBoxPOS3 = new System.Windows.Forms.ComboBox();
            this.comboBoxPOS4 = new System.Windows.Forms.ComboBox();
            this.btnSetPOS = new System.Windows.Forms.Button();

            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // textBoxFilePath
            this.textBoxFilePath.Location = new System.Drawing.Point(20, 10);
            this.textBoxFilePath.Size = new System.Drawing.Size(320, 23);

            // btnLoadFile
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.Location = new System.Drawing.Point(350, 10);
            this.btnLoadFile.Size = new System.Drawing.Size(90, 23);
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);

            // groupBoxTraceability
            this.groupBoxTraceability.Text = "Traceability Settings";
            this.groupBoxTraceability.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxTraceability.Location = new System.Drawing.Point(20, 50);
            this.groupBoxTraceability.Size = new System.Drawing.Size(420, 140);
            this.groupBoxTraceability.Controls.Add(this.lblCurrentStatus);
            this.groupBoxTraceability.Controls.Add(this.comboBoxSetStatus);
            this.groupBoxTraceability.Controls.Add(this.btnSetStatus);
            this.groupBoxTraceability.Controls.Add(this.btnCheckStatus);

            // lblCurrentStatus
            this.lblCurrentStatus.Location = new System.Drawing.Point(20, 30);
            this.lblCurrentStatus.Size = new System.Drawing.Size(350, 20);
            this.lblCurrentStatus.Text = "Current Status: Unknown";

            // comboBoxSetStatus
            this.comboBoxSetStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxSetStatus.Items.AddRange(new object[] { "Deactivate", "Activate" });
            this.comboBoxSetStatus.Location = new System.Drawing.Point(20, 60);
            this.comboBoxSetStatus.Size = new System.Drawing.Size(160, 25);

            // btnSetStatus
            this.btnSetStatus.Text = "Update Traceability";
            this.btnSetStatus.Location = new System.Drawing.Point(200, 60);
            this.btnSetStatus.Size = new System.Drawing.Size(160, 25);
            this.btnSetStatus.Click += new System.EventHandler(this.btnSetStatus_Click);

            // btnCheckStatus
            this.btnCheckStatus.Text = "Check Status";
            this.btnCheckStatus.Location = new System.Drawing.Point(20, 95);
            this.btnCheckStatus.Size = new System.Drawing.Size(340, 25);
            this.btnCheckStatus.Click += new System.EventHandler(this.btnCheckStatus_Click);

            // groupBoxPOS
            this.groupBoxPOS.Text = "POS Configuration";
            this.groupBoxPOS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxPOS.Location = new System.Drawing.Point(20, 200);
            this.groupBoxPOS.Size = new System.Drawing.Size(420, 220);
            this.groupBoxPOS.Controls.Add(this.lblPOS1);
            this.groupBoxPOS.Controls.Add(this.lblPOS2);
            this.groupBoxPOS.Controls.Add(this.lblPOS3);
            this.groupBoxPOS.Controls.Add(this.lblPOS4);
            this.groupBoxPOS.Controls.Add(this.comboBoxPOS1);
            this.groupBoxPOS.Controls.Add(this.comboBoxPOS2);
            this.groupBoxPOS.Controls.Add(this.comboBoxPOS3);
            this.groupBoxPOS.Controls.Add(this.comboBoxPOS4);
            this.groupBoxPOS.Controls.Add(this.btnSetPOS);

            // POS Labels and ComboBoxes
            string[] labels = { "POS 1:", "POS 2:", "POS 3:", "POS 4:" };
            Label[] lblPOS = { this.lblPOS1, this.lblPOS2, this.lblPOS3, this.lblPOS4 };
            ComboBox[] comboBoxes = { this.comboBoxPOS1, this.comboBoxPOS2, this.comboBoxPOS3, this.comboBoxPOS4 };

            for (int i = 0; i < 4; i++)
            {
                lblPOS[i].Location = new System.Drawing.Point(20, 30 + i * 35);
                lblPOS[i].Size = new System.Drawing.Size(150, 20);
                lblPOS[i].Text = labels[i];

                comboBoxes[i].DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxes[i].Items.AddRange(new string[] { "Deactivate", "Activate" });
                comboBoxes[i].Location = new System.Drawing.Point(170, 30 + i * 35);
                comboBoxes[i].Size = new System.Drawing.Size(190, 25);
            }

            // btnSetPOS
            this.btnSetPOS.Text = "Update POS States";
            this.btnSetPOS.Location = new System.Drawing.Point(20, 175);
            this.btnSetPOS.Size = new System.Drawing.Size(340, 30);
            this.btnSetPOS.Click += new System.EventHandler(this.btnSetPOS_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.groupBoxTraceability);
            this.Controls.Add(this.groupBoxPOS);
            this.Text = "ICCS Hardware Config";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
