using System;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;

namespace ICCS_HW_CFG
{
    public partial class Form1 : Form
    {
        private string FilePath = @"C:\\Users\\F6CAF02\\Documents\\TEST_GUI_APP\\HWCfg_ICCS_eX.xls";
        private string settingsFilePath = Path.Combine(Application.StartupPath, "lastpath.txt");
        private HSSFWorkbook workbook;
        private ISheet sheet;

        public Form1()
        {
            InitializeComponent();

            // Apply dark theme on startup
            ApplyDarkTheme();

            if (File.Exists(settingsFilePath))
            {
                FilePath = File.ReadAllText(settingsFilePath);
            }

            textBoxFilePath.Text = FilePath;
            LoadExcelData();
        }

        private void ApplyDarkTheme()
        {
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.ForeColor = System.Drawing.Color.White;

            foreach (Control control in this.Controls)
            {
                SetDarkTheme(control);
            }
        }

        private void SetDarkTheme(Control control)
        {
            if (control is GroupBox groupBox)
            {
                groupBox.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
                groupBox.ForeColor = System.Drawing.Color.White;
                foreach (Control inner in groupBox.Controls)
                {
                    SetDarkTheme(inner);
                }
            }
            else if (control is Button button)
            {
                button.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
                button.ForeColor = System.Drawing.Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            }
            else if (control is ComboBox comboBox)
            {
                comboBox.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
                comboBox.ForeColor = System.Drawing.Color.White;
                comboBox.FlatStyle = FlatStyle.Flat;
            }
            else if (control is TextBox textBox)
            {
                textBox.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
                textBox.ForeColor = System.Drawing.Color.White;
                textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            }
            else if (control is Label label)
            {
                label.ForeColor = System.Drawing.Color.White;
            }
        }

        private void LoadExcelData()
        {
            try
            {
                FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
                workbook = new HSSFWorkbook(fs);
                sheet = workbook.GetSheet("HWCfg");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Excel file: " + ex.Message);
            }
        }

        private void btnCheckStatus_Click(object sender, EventArgs e)
        {
            if (sheet == null) return;
            var traceabilityCell = sheet.GetRow(13).GetCell(1);
            lblCurrentStatus.Text = $"Current Status: {traceabilityCell.ToString()}";
        }

        private void btnSetStatus_Click(object sender, EventArgs e)
        {
            if (sheet == null) return;
            var traceabilityCell = sheet.GetRow(13).GetCell(1);
            traceabilityCell.SetCellValue(comboBoxSetStatus.SelectedIndex == 0 ? 0 : 1);
            SaveExcelFile();
        }

        private void btnSetPOS_Click(object sender, EventArgs e)
        {
            if (sheet == null) return;
            sheet.GetRow(41).GetCell(1).SetCellValue(comboBoxPOS1.SelectedIndex == 0 ? 0 : 1);
            sheet.GetRow(42).GetCell(1).SetCellValue(comboBoxPOS2.SelectedIndex == 0 ? 0 : 1);
            sheet.GetRow(43).GetCell(1).SetCellValue(comboBoxPOS3.SelectedIndex == 0 ? 0 : 1);
            sheet.GetRow(44).GetCell(1).SetCellValue(comboBoxPOS4.SelectedIndex == 0 ? 0 : 1);
            SaveExcelFile();
        }

        private void SaveExcelFile()
        {
            using (FileStream fs = new FileStream(FilePath, FileMode.Create, FileAccess.Write))
            {
                workbook.Write(fs);
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists(textBoxFilePath.Text))
            {
                MessageBox.Show("Invalid file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FilePath = textBoxFilePath.Text;
            File.WriteAllText(settingsFilePath, FilePath);
            LoadExcelData();
            MessageBox.Show("Excel file loaded successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
