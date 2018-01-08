using BarcoS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BarcoS.Classes.Views.EditForms
{
    public partial class frmEditBrands : Form
    {
        CloudEntities db;
        bool cancel = false;
        public frmEditBrands(Brand obj)
        {
            InitializeComponent();
            db = new CloudEntities();
            if (obj == null)
            {
                brandBindingSource.DataSource = new Brand();
                db.Brands.Add(brandBindingSource.Current as Brand);
            }
            else
            {
                brandBindingSource.DataSource = obj;
                db.Brands.Attach(brandBindingSource.Current as Brand);
            }
        }

        private void frmEditBrands_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txtText.Text) && !cancel)
                {
                    MessageBox.Show("Lütfen kategori adı giriniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtText.Focus();
                    e.Cancel = true;
                    return;
                }

                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            cancel = true;
            if (String.IsNullOrEmpty((brandBindingSource.Current as Brand).name) || db.Brands.Where(u => u.name == txtText.Text).ToList().Count == 0)
            {
                db.Brands.Remove(brandBindingSource.Current as Brand);
            }

            this.Close();
        }
    }
}
