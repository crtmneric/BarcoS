using BarcoS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BarcoS.Classes.Views.EditForms
{
    public partial class frmEditCariDetail : Form
    {
        CloudEntities db;
        bool cancel = false;
        public frmEditCariDetail(Current_Details obj)
        {
            InitializeComponent();
            db = new CloudEntities();
            if (obj == null)
            {
                currentDetailsBindingSource.DataSource = new Current_Details();
                Current_Details newDetail = currentDetailsBindingSource.Current as Current_Details;
                newDetail.current_id = BarcoS.Classes.Views.MainForms.frmCariDetail.cariIDGlobal;
                db.Current_Details.Add(newDetail);
            }
            else
            {
                currentDetailsBindingSource.DataSource = obj;
                db.Current_Details.Attach(currentDetailsBindingSource.Current as Current_Details);
            }
        }

        private void frmEditCariDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {

                if (string.IsNullOrEmpty(txtText.Text)&&!cancel)
                {
                    MessageBox.Show("Lütfen Açıklama Giriniz", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if(String.IsNullOrEmpty((currentDetailsBindingSource.Current as Current_Details).text)||db.Current_Details.Where(u=>u.text==txtText.Text).ToList().Count()==0)
            {
                db.Current_Details.Remove(currentDetailsBindingSource.Current as Current_Details);
            }      
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPrice.Text))
            {
                Currenty editCari = db.Currenties.Where(u => u.id == BarcoS.Classes.Views.MainForms.frmCariDetail.cariIDGlobal).SingleOrDefault();
                editCari.bakiye += Convert.ToDecimal(txtPrice.Text);
                db.SaveChanges();
            }
        }

      
    }
}
