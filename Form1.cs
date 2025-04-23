using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace ICCS_HW_CFG
{
    public partial class Form1 : Form
    {
        private string FilePath = @"C:\\Users\\F6CAF02\\Documents\\TEST_GUI_APP\\HWCfg_ICCS_eX.xls";
        private string settingsFilePath = Path.Combine(Application.StartupPath, "lastpath.txt");
        private HSSFWorkbook workbook;
        private ISheet sheet;
        private User CurrentUser;

        public Form1(User user)
        {
            InitializeComponent();
            CurrentUser = user;
            ApplyDarkTheme();

            if (File.Exists(settingsFilePath))
            {
                string[] lines = File.ReadAllLines(settingsFilePath);
                if (lines.Length > 0)
                    FilePath = lines[0];
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
                using (FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read))
                {
                    workbook = new HSSFWorkbook(fs);
                    sheet = workbook.GetSheet("HWCfg");
                }
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
            int currentValue = (int)traceabilityCell.NumericCellValue;
            int newValue = comboBoxSetStatus.SelectedIndex == 0 ? 0 : 1;

            if (currentValue != newValue)
            {
                traceabilityCell.SetCellValue(newValue);
                SaveExcelFile();
                LogChange("Traceability", currentValue, newValue);
            }
            else
            {
                MessageBox.Show("No changes detected in traceability.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSetPOS_Click(object sender, EventArgs e)
        {
            if (sheet == null) return;

            bool hasChange = false;
            hasChange |= UpdatePOSIfChanged(41, 1, comboBoxPOS1, 3, "POS1");
            hasChange |= UpdatePOSIfChanged(42, 1, comboBoxPOS2, 4, "POS2");
            hasChange |= UpdatePOSIfChanged(43, 1, comboBoxPOS3, 5, "POS3");
            hasChange |= UpdatePOSIfChanged(44, 1, comboBoxPOS4, 6, "POS4");

            if (hasChange)
            {
                SaveExcelFile();
            }
            else
            {
                MessageBox.Show("No changes detected.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool UpdatePOSIfChanged(int rowIndex, int colIndex, ComboBox comboBox, int counterLineIndex, string posName)
        {
            var cell = sheet.GetRow(rowIndex).GetCell(colIndex);
            int currentValue = (int)cell.NumericCellValue;

            if (comboBox.SelectedIndex == -1)
                return false;

            int newValue = comboBox.SelectedIndex == 0 ? 0 : 1;

            if (currentValue != newValue)
            {
                cell.SetCellValue(newValue);

                //  Only reset counter if the new value is 1 (Activated/Used)
                if (newValue == 1)
                {
                    ResetPOSCounter(counterLineIndex);
                }

                LogChange(posName, currentValue, newValue);
                return true;
            }

            return false;
        }


        private void SaveExcelFile()
        {
            using (FileStream fs = new FileStream(FilePath, FileMode.Create, FileAccess.Write))
            {
                workbook.Write(fs);
            }

            uint crc32 = CRC32Helper.ComputeCRC32(FilePath);

            string[] lines = File.Exists(settingsFilePath) ? File.ReadAllLines(settingsFilePath) : new string[7];
            if (lines.Length < 7)
            {
                Array.Resize(ref lines, 7);
            }

            lines[0] = FilePath;
            lines[1] = crc32.ToString("X8");

            File.WriteAllLines(settingsFilePath, lines);
        }

        private void ResetPOSCounter(int lineIndex)
        {
            if (File.Exists(settingsFilePath))
            {
                string[] lines = File.ReadAllLines(settingsFilePath);
                if (lines.Length > lineIndex)
                {
                    lines[lineIndex] = "0";
                    File.WriteAllLines(settingsFilePath, lines);
                }
            }
        }

        private void LogChange(string fieldName, int oldValue, int newValue)
        {
            var historyFile = Path.Combine(Application.StartupPath, "history.json");
            List<object> history = File.Exists(historyFile)
                ? JsonSerializer.Deserialize<List<object>>(File.ReadAllText(historyFile)) ?? new List<object>()
                : new List<object>();

            history.Add(new
            {
                Username = CurrentUser?.Username ?? "Unknown",
                Timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Action = $"Changed {fieldName} from {oldValue} to {newValue}"
            });

            File.WriteAllText(historyFile, JsonSerializer.Serialize(history, new JsonSerializerOptions { WriteIndented = true }));
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists(textBoxFilePath.Text))
            {
                MessageBox.Show("Invalid file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FilePath = textBoxFilePath.Text;
            LoadExcelData();

            string crc32 = File.Exists(settingsFilePath) && File.ReadAllLines(settingsFilePath).Length > 1
                ? File.ReadAllLines(settingsFilePath)[1]
                : "00000000";

            string[] lines = File.Exists(settingsFilePath) ? File.ReadAllLines(settingsFilePath) : new string[7];
            if (lines.Length < 7)
            {
                Array.Resize(ref lines, 7);
            }

            lines[0] = FilePath;
            lines[1] = crc32;
            File.WriteAllLines(settingsFilePath, lines);

            MessageBox.Show("Excel file loaded successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public static class CRC32Helper
    {
        public static uint ComputeCRC32(string filePath)
        {
            using (var stream = File.OpenRead(filePath))
            {
                unchecked
                {
                    uint crc = 0xFFFFFFFF;
                    int currentByte;
                    while ((currentByte = stream.ReadByte()) != -1)
                    {
                        crc ^= (byte)currentByte;
                        for (int k = 0; k < 8; k++)
                        {
                            if ((crc & 1) == 1)
                                crc = (crc >> 1) ^ 0xEDB88320u;
                            else
                                crc >>= 1;
                        }
                    }
                    return ~crc;
                }
            }
        }
    }
}
