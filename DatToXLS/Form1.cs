using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;

namespace DatToXLS
{
    public partial class Form1 : Form
    {

        const decimal ASCII0020 = 20;
        const decimal ASCII0254 = 254;

        public Form1()
        {
            InitializeComponent();
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                this.tbConcordanceFilePath.Text = openFileDialog1.FileName;
            }

        }

        private void btConvert_Click(object sender, EventArgs e)
        {
            string outputFilename = Path.GetFileNameWithoutExtension(this.tbConcordanceFilePath.Text);
            string outputDir = Path.GetDirectoryName(this.tbConcordanceFilePath.Text);
            string excelFilePath = Path.Combine(outputDir, outputFilename + ".xlsx");
            string worksheetsName = "Exported DAT";

            bool firstRowIsHeader = true;

            var format = new ExcelTextFormat();
            format.Delimiter = (char)ASCII0020;  // ALT0020 Decimal 20
            format.EOL = "\r\n";              // DEFAULT IS "\r\n";
            format.TextQualifier = (char)ASCII0254;  // ALT+0254 Decimal 254
            format.Encoding = Encoding.UTF8;

            try
            {
                using (ExcelPackage package = new ExcelPackage(new FileInfo(excelFilePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(worksheetsName);
                    worksheet.Cells["A1"].LoadFromText(new FileInfo(this.tbConcordanceFilePath.Text), format, OfficeOpenXml.Table.TableStyles.Medium27, firstRowIsHeader);
                    package.Save();
                    MessageBox.Show("Successfully imported DAT file. Imported file available in " + excelFilePath + ".", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error converting DAT file. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbConcordanceFilePath_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(@tbConcordanceFilePath.Text)) 
            {
                btConvert.Enabled = true; // Checks if the specified file exists and enables convert button if it does
            }
            else
            {
                btConvert.Enabled = true; // otherwise, disable convert button
            }
        }

        private void tbConcordanceFilePath_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                tbConcordanceFilePath.Text = files[0];
            }

        }

        private void tbConcordanceFilePath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void tbConcordanceFilePath_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
