using BarcoS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BarcoS.Classes.Views.EditForms
{
    public partial class frmEditCari : Form
    {
        CloudEntities db;
        bool cancel = false;
        public frmEditCari(Currenty obj)
        {
           
            InitializeComponent();
            db = new CloudEntities();
            if (obj == null)
            {
                currentyBindingSource.DataSource = new Currenty();
                db.Currenties.Add(currentyBindingSource.Current as Currenty);
            }
            else
            {               
                currentyBindingSource.DataSource = obj;
                db.Currenties.Attach(currentyBindingSource.Current as Currenty);              
              
                if (obj.sms_notification==1)
                {
                    cmbSms.SelectedIndex = 0;
                }
                else if (obj.sms_notification==0)
                {
                    cmbSms.SelectedIndex = 1;
                }
                if (obj.current_type == 1)
                {
                    cmbCariType.SelectedIndex = 0;
                }
                else if (obj.current_type == 2)
                {
                    cmbCariType.SelectedIndex = 1;
                }
                else if (obj.current_type == 3)
                {
                    cmbCariType.SelectedIndex = 2;
                }
                      
            }    
           
          
        }

        private void frmEditCari_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
              
                if (string.IsNullOrEmpty(txtName.Text)&&!cancel)
                {
                    MessageBox.Show("Lütfen yetkili adı giriniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Focus();
                    e.Cancel = true;
                    return;
                }
                if(string.IsNullOrEmpty(txtBakiye.Text))
                {
                    (currentyBindingSource.Current as Currenty).bakiye = 0;
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }

        private void cmbCariType_SelectedValueChanged(object sender, EventArgs e)
        {
            txtCurrentType.Focus();
            if(Convert.ToString(cmbCariType.SelectedItem)=="Müşteri")
            {
                txtCurrentType.Text = "1";
            }
            else if(Convert.ToString(cmbCariType.SelectedItem)=="Çalışan")
            {
                txtCurrentType.Text = "2";
            }
            else if (Convert.ToString(cmbCariType.SelectedItem) == "Toptancı")
            {
                txtCurrentType.Text = "3";
            }
        }

        private void cmbSms_SelectedValueChanged(object sender, EventArgs e)
        {
            txtSms.Focus();
            if(Convert.ToString(cmbSms.SelectedItem)=="Var")
            {
                txtSms.Text = "1";
            }
            else
            {
                txtSms.Text = "0";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            cancel = true;
            if(String.IsNullOrEmpty((currentyBindingSource.Current as Currenty).auth_name)||db.Currenties.Where(u=>u.auth_name==txtName.Text).ToList().Count==0)
            {
                db.Currenties.Remove(currentyBindingSource.Current as Currenty);
            }
            
            this.Close();
        }
    }
}
