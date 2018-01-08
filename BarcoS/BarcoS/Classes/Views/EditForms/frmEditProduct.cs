using BarcoS.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BarcoS.Classes.Views.EditForms
{
    public partial class frmEditProduct : Form
    {
        CloudEntities db;
        bool cancel = false;
        public frmEditProduct(Product obj)
        {
            InitializeComponent();
            db = new CloudEntities();
            ComboBoxBindings();     
            if (obj == null)
            {
                productBindingSource.DataSource = new Product();
                db.Products.Add(productBindingSource.Current as Product);
            }
            else
            {
                productBindingSource.DataSource = obj;
                db.Products.Attach(productBindingSource.Current as Product);
            }
        }

        private void ComboBoxBindings()
        {
            List<String> brandNames = new List<String>();
            List<String> categoryNames = new List<String>();
            foreach (Brand brandcik in db.Brands)
            {
                brandNames.Add(brandcik.name);
            }
            foreach (category catcik in db.categories)
            {
                categoryNames.Add(catcik.name);
            }
            BindingSource brandBindingSource = new BindingSource();
            BindingSource catBindingSource = new BindingSource();
            brandBindingSource.DataSource = brandNames;
            catBindingSource.DataSource = categoryNames;
            cmbCariType.DataSource = brandBindingSource;
            cmbSms.DataSource = catBindingSource;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            cancel = true;
            if (String.IsNullOrEmpty((productBindingSource.Current as Product).name) || db.Products.Where(u => u.name == txtName.Text).ToList().Count() == 0)
            {
                db.Products.Remove(productBindingSource.Current as Product);
            }
            this.Close();
        }

        private void btnPicPicker_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog() { Filter = "Resim Dosyaları (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png", InitialDirectory = @"C:\", Title = "Lütfen bir resim dosyası seçiniz." };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image productImage = Image.FromFile(dialog.FileName);
                pctPic.BackgroundImage = productImage;
                 var convertedByteImage = imageToByteArray(productImage);
                 (productBindingSource.Current as Product).product_İmage = convertedByteImage;
            }     
        }
        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

       

        private void frmEditProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {

                if ((string.IsNullOrEmpty(txtBrandID.Text) || string.IsNullOrEmpty(txtCatID.Text) || string.IsNullOrEmpty(txtName.Text)) && !cancel)
                {
                    MessageBox.Show("Lütfen zorunlu alanları giriniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Focus();
                    e.Cancel = true;
                    return;
                }

                db.SaveChanges();
                e.Cancel = false;
               
            }
            e.Cancel = false;
        }

        private void cmbCariType_SelectedValueChanged(object sender, EventArgs e)
        {
            txtBrandID.Focus();        
            Brand thatBrand = db.Brands.Where(u => u.name == (cmbCariType.SelectedItem)).SingleOrDefault() as Brand;
            txtBrandID.Text = thatBrand.id.ToString();
        }

        private void cmbSms_SelectedValueChanged(object sender, EventArgs e)
        {
            txtCatID.Focus();
            category thatCat = db.categories.Where(u => u.name == (cmbSms.SelectedItem)).SingleOrDefault() as category;
            txtCatID.Text =thatCat.id.ToString();
        }

       
    }
}
