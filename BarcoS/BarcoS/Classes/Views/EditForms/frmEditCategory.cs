using BarcoS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BarcoS.Classes.Views.EditForms
{
    public partial class frmEditCategory : Form
    {
        CloudEntities db;
        bool cancel = false;
        public frmEditCategory(category obj)
        {
            InitializeComponent();
            db = new CloudEntities();
            if (obj == null)
            {
                categoryBindingSource.DataSource = new category();
                db.categories.Add(categoryBindingSource.Current as category);
            }
            else
            {
                categoryBindingSource.DataSource = obj;
                db.categories.Attach(categoryBindingSource.Current as category);
            }
        }

        private void cmbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            txtExpDate.Focus();
            if (Convert.ToString(cmbStatus.SelectedItem) == "Var")
            {
                txtExpDate.Text = "1";
            }
            else
            {
                txtExpDate.Text = "0";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            cancel = true;
            if (String.IsNullOrEmpty((categoryBindingSource.Current as category).name) || db.categories.Where(u => u.name == txtText.Text).ToList().Count == 0)
            {
                db.categories.Remove(categoryBindingSource.Current as category);
            }

            this.Close();
        }

        private void frmEditCategory_FormClosing(object sender, FormClosingEventArgs e)
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

      
    }
}
