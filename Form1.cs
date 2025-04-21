using System;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;
using System.Collections.Generic;

namespace ICCS_HW_CFG
{
    public partial class Form1 : Form
    {
        private const string FilePath = @"C:\Users\F6CAF02\Documents\TEST_GUI_APP\HWCfg_ICCS_eX.xls";
        private HSSFWorkbook workbook;
        private ISheet sheet;

        public Form1()
        {
            InitializeComponent();
            LoadExcelData();
        }

        private void LoadExcelData()
        {
            FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            workbook = new HSSFWorkbook(fs);
            sheet = workbook.GetSheet("HWCfg");
            fs.Close();
        }

        private void btnCheckStatus_Click(object sender, EventArgs e)
        {
            // Read current traceability status from Excel
            var traceabilityCell = sheet.GetRow(13).GetCell(1);
            lblCurrentStatus.Text = $"Current Status: {traceabilityCell.ToString()}";
        }

        private void btnSetStatus_Click(object sender, EventArgs e)
        {
            // Update traceability status based on the selected option
            var traceabilityCell = sheet.GetRow(13).GetCell(1);
            traceabilityCell.SetCellValue(comboBoxSetStatus.SelectedIndex == 0 ? 0 : 1);

            // Save changes
            SaveExcelFile();
        }

        private void btnSetPOS_Click(object sender, EventArgs e)
        {
            // Update POS 1-4 based on selected options
            sheet.GetRow(41).GetCell(1).SetCellValue(comboBoxPOS1.SelectedIndex == 0 ? 0 : 1);
            sheet.GetRow(42).GetCell(1).SetCellValue(comboBoxPOS2.SelectedIndex == 0 ? 0 : 1);
            sheet.GetRow(43).GetCell(1).SetCellValue(comboBoxPOS3.SelectedIndex == 0 ? 0 : 1);
            sheet.GetRow(44).GetCell(1).SetCellValue(comboBoxPOS4.SelectedIndex == 0 ? 0 : 1);

            // Save changes
            SaveExcelFile();
        }

        private void SaveExcelFile()
        {
            using (FileStream fs = new FileStream(FilePath, FileMode.Create, FileAccess.Write))
            {
                workbook.Write(fs);
            }
        }
    }
}

