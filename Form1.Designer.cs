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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxTraceability = new System.Windows.Forms.GroupBox();
            this.groupBoxPOS = new System.Windows.Forms.GroupBox();

            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.comboBoxSetStatus = new System.Windows.Forms.ComboBox();
            this.btnCheckStatus = new System.Windows.Forms.Button();
            this.btnSetStatus = new System.Windows.Forms.Button();

            this.lblPOS1 = new System.Windows.Forms.Label();
            this.lblPOS2 = new System.Windows.Forms.Label();
            this.lblPOS3 = new System.Windows.Forms.Label();
            this.lblPOS4 = new System.Windows.Forms.Label();
            this.comboBoxPOS1 = new System.Windows.Forms.ComboBox();
            this.comboBoxPOS2 = new System.Windows.Forms.ComboBox();
            this.comboBoxPOS3 = new System.Windows.Forms.ComboBox();
            this.comboBoxPOS4 = new System.Windows.Forms.ComboBox();
            this.btnSetPOS = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // groupBoxTraceability
            this.groupBoxTraceability.Text = "Traceability Settings";
            this.groupBoxTraceability.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxTraceability.Location = new System.Drawing.Point(20, 20);
            this.groupBoxTraceability.Size = new System.Drawing.Size(400, 140);
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
            this.groupBoxPOS.Location = new System.Drawing.Point(20, 180);
            this.groupBoxPOS.Size = new System.Drawing.Size(400, 220);
            this.groupBoxPOS.Controls.Add(this.lblPOS1);
            this.groupBoxPOS.Controls.Add(this.lblPOS2);
            this.groupBoxPOS.Controls.Add(this.lblPOS3);
            this.groupBoxPOS.Controls.Add(this.lblPOS4);
            this.groupBoxPOS.Controls.Add(this.comboBoxPOS1);
            this.groupBoxPOS.Controls.Add(this.comboBoxPOS2);
            this.groupBoxPOS.Controls.Add(this.comboBoxPOS3);
            this.groupBoxPOS.Controls.Add(this.comboBoxPOS4);
            this.groupBoxPOS.Controls.Add(this.btnSetPOS);

            // lblPOS1
            this.lblPOS1.Location = new System.Drawing.Point(20, 30);
            this.lblPOS1.Size = new System.Drawing.Size(150, 20);
            this.lblPOS1.Text = "POS 1:";

            // lblPOS2
            this.lblPOS2.Location = new System.Drawing.Point(20, 65);
            this.lblPOS2.Size = new System.Drawing.Size(150, 20);
            this.lblPOS2.Text = "POS 2:";

            // lblPOS3
            this.lblPOS3.Location = new System.Drawing.Point(20, 100);
            this.lblPOS3.Size = new System.Drawing.Size(150, 20);
            this.lblPOS3.Text = "POS 3:";

            // lblPOS4
            this.lblPOS4.Location = new System.Drawing.Point(20, 135);
            this.lblPOS4.Size = new System.Drawing.Size(150, 20);
            this.lblPOS4.Text = "POS 4:";

            // comboBoxPOS1
            this.comboBoxPOS1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxPOS1.Items.AddRange(new string[] { "Deactivate", "Activate" });
            this.comboBoxPOS1.Location = new System.Drawing.Point(170, 30);
            this.comboBoxPOS1.Size = new System.Drawing.Size(190, 25);

            // comboBoxPOS2
            this.comboBoxPOS2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxPOS2.Items.AddRange(new string[] { "Deactivate", "Activate" });
            this.comboBoxPOS2.Location = new System.Drawing.Point(170, 65);
            this.comboBoxPOS2.Size = new System.Drawing.Size(190, 25);

            // comboBoxPOS3
            this.comboBoxPOS3.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxPOS3.Items.AddRange(new string[] { "Deactivat", "Activate" });
            this.comboBoxPOS3.Location = new System.Drawing.Point(170, 100);
            this.comboBoxPOS3.Size = new System.Drawing.Size(190, 25);

            // comboBoxPOS4
            this.comboBoxPOS4.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxPOS4.Items.AddRange(new string[] { "Deactivate", "Activate" });
            this.comboBoxPOS4.Location = new System.Drawing.Point(170, 135);
            this.comboBoxPOS4.Size = new System.Drawing.Size(190, 25);

            // btnSetPOS
            this.btnSetPOS.Text = "Update POS States";
            this.btnSetPOS.Location = new System.Drawing.Point(20, 175);
            this.btnSetPOS.Size = new System.Drawing.Size(340, 30);
            this.btnSetPOS.Click += new System.EventHandler(this.btnSetPOS_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(450, 430);
            this.Controls.Add(this.groupBoxTraceability);
            this.Controls.Add(this.groupBoxPOS);
            this.Text = "ICCS Hardware Config";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            this.ResumeLayout(false);
        }
    }
}
