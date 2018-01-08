using BarcoS.Models;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.BarCode;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BarcoS.Classes.Views.MainForms
{
    public partial class frmBarcode : Form
    {
        public frmBarcode(Product product)
        {
            InitializeComponent();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                cmbPrinters.Items.Add(printer);
            }
            txtBarcode.Text = product.barcode_number;
            txtName.Text = product.name;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\cookies.rna";
            String dbConnection;
            StreamReader file2 = new StreamReader(path);
            while ((dbConnection = file2.ReadLine()) != null)
            {
                if (dbConnection.Contains("printWidth:"))
                {
                    String width = dbConnection.Replace("printWidth:", "");
                    txtWidth.Text = width;
                }
                if (dbConnection.Contains("printHeight:"))
                {
                    String width = dbConnection.Replace("printHeight:", "");
                    txtHeight.Text = width;
                }
                if(dbConnection.Contains("printer:"))
                {
                    String printer = dbConnection.Replace("printer:", "");
                    cmbPrinters.SelectedItem=printer;
                }
            }
            file2.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuickPrint_Click(object sender, EventArgs e)
        {
            PrintSelection(false);
          
        }

        private void PrintSelection(Boolean details)
        {
            int parsedValue;
            if (!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtHeight.Text) && !String.IsNullOrEmpty(cmbPrinters.SelectedItem.ToString()) && int.TryParse(txtWidth.Text, out parsedValue) && int.TryParse(txtHeight.Text, out parsedValue))
            {
                this.Cursor = Cursors.WaitCursor;
                DetailBand detail = new DetailBand();

                XtraReport quickPrint = new XtraReport() { ReportUnit = ReportUnit.TenthsOfAMillimeter, PaperKind = PaperKind.Custom, PageWidth = Convert.ToInt32(txtWidth.Text) * 10, PageHeight = Convert.ToInt32(txtHeight.Text) * 10 };
                quickPrint.Margins.Bottom = 0;
                quickPrint.Margins.Top = 0;
                quickPrint.Margins.Left = 0;
                quickPrint.Margins.Right = 0;
               
                quickPrint.RequestParameters = false;
                quickPrint.Bands.AddRange(new Band[] { detail });
                quickPrint.Bands[BandKind.Detail].Controls.Add(new XRLabel() { Text = txtName.Text, LocationF = new PointF(0, 0), Font = new Font("Segoe UI", 12) });
                quickPrint.Bands[BandKind.Detail].Controls.Add(CreateCode39BarCode(txtBarcode.Text));
                quickPrint.CreateDocument();
                quickPrint.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                if(details)
                {
                   
                    quickPrint.ShowRibbonDesignerDialog();
                    
                }
                else
                {
                   
                    quickPrint.Print(cmbPrinters.SelectedItem.ToString());
                    
                }
                this.Cursor = Cursors.Default;
            }
            else
            {
                MessageBox.Show("Kağıt boyutlarını giriniz!", "Üzgünüm!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void DetailReport()
        {
            PrintSelection(true);
        }
        public XRBarCode CreateCode39BarCode(string BarCodeText)
        {
            XRBarCode barCode = new XRBarCode() { Symbology = new Code39Generator(), Text = BarCodeText,AutoModule=true ,TextAlignment = TextAlignment.MiddleCenter ,LocationF=new PointF(0,30),CanGrow=true,CanShrink=true,HeightF=Convert.ToSingle(txtHeight.Text)*3};
            ((Code39Generator)barCode.Symbology).CalcCheckSum = false;
            ((Code39Generator)barCode.Symbology).WideNarrowRatio = 2.5F;
            return barCode;
        }

        private void btnDetailPrint_Click(object sender, EventArgs e)
        {
            DetailReport();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SavePrinterSettings();                   
        }

        private void SavePrinterSettings()
        {
            int parsedValue;
            if (!String.IsNullOrEmpty(txtHeight.Text) && !String.IsNullOrEmpty(txtWidth.Text) && int.TryParse(txtWidth.Text, out parsedValue) && int.TryParse(txtHeight.Text, out parsedValue))
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\cookies.rna";
                StreamWriter file3 = new StreamWriter(path);
                file3.WriteLine("datasource:saved");
                file3.WriteLine("printWidth:" + txtWidth.Text);
                file3.WriteLine("printHeight:" + txtHeight.Text);
                file3.WriteLine("printer:" + cmbPrinters.SelectedItem.ToString());
                file3.Close();
                MessageBox.Show("Başarıyla Kaydedildi!", "Succeed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kağıt boyutlarını boş bırakmayınız ve sadece rakam giriniz!", "Üzgünüm!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool IsStringInFile(string fileName, string searchString)
        {
            StreamReader readFile = new StreamReader(fileName);
            String text = readFile.ReadToEnd();
            readFile.Close();
            if(text.Contains(searchString))
            {
                return true;
            }
            else
                return false;
          
            
        }
         

        
    }
}
