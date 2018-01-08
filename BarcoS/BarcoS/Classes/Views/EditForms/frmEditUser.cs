using BarcoS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BarcoS.Classes.Views.EditForms
{
    public partial class frmEditUser : Form
    {
        CloudEntities db;
        bool cancel = false;
        public frmEditUser(user obj)
        {
           
            InitializeComponent();
            db = new CloudEntities();
            if (obj == null)
            {
                userBindingSource.DataSource = new user();
                db.users.Add(userBindingSource.Current as user);
            }
            else
            {
              
                userBindingSource.DataSource = obj;
                db.users.Attach(userBindingSource.Current as user);
            }
        }

        private void frmEditUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                int password=0;
                if(!String.IsNullOrEmpty(txtPass.Text))
                {
                     password = Convert.ToInt32(txtPass.Text);
                }
              
                if (string.IsNullOrEmpty(txtName.Text)&&!cancel)
                {
                    MessageBox.Show("Lütfen kullanıcı adı giriniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Focus();
                    e.Cancel = true;
                    return;
                }
                else if(string.IsNullOrEmpty(txtPass.Text)&&!cancel)
                {
                    MessageBox.Show("Lütfen kullanıcı şifresi giriniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPass.Focus();
                    e.Cancel = true;
                    return;
                }
                else if(db.users.Where(u=>u.password==password).ToList().Count>0&&db.users.Where(u=>u.auth_name==txtName.Text).ToList().Count==0&&!cancel)
                {
                    MessageBox.Show("Aynı şifreye sahip kullanıcı mevcut!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPass.Focus();
                    e.Cancel = true;
                    return;
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void cmbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            txtStatus.Focus();
            if(Convert.ToString(cmbStatus.SelectedItem)=="Var")
            {
                txtStatus.Text = "1";
            }
            else
            {
                txtStatus.Text = "0";
            }
        }

        private void cmbAdmin_SelectedValueChanged(object sender, EventArgs e)
        {
            txtAdmin.Focus();
            if (Convert.ToString(cmbAdmin.SelectedItem) == "Var")
            {
                txtAdmin.Text = "1";
            }
            else
            {
                txtAdmin.Text = "0";
            }
        }

        private void cmbCompanyAdmin_SelectedValueChanged(object sender, EventArgs e)
        {
            txtCompanyAdmin.Focus();
            if (Convert.ToString(cmbCompanyAdmin.SelectedItem) == "Var")
            {
                txtCompanyAdmin.Text = "1";
            }
            else
            {
                txtCompanyAdmin.Text = "0";
            }
        }

        private void cmbNotif_SelectedValueChanged(object sender, EventArgs e)
        {
            txtNotif.Focus();
            if (Convert.ToString(cmbNotif.SelectedItem )== "Var")
            {
                txtNotif.Text = "1";
            }
            else
            {
                txtNotif.Text = "0";
            }
        }

        private void cmbUserActivate_SelectedValueChanged(object sender, EventArgs e)
        {
            txtUserActivate.Focus();
            if (Convert.ToString(cmbUserActivate.SelectedItem) == "Var")
            {
                txtUserActivate.Text = "1";
            }
            else
            {
                txtUserActivate.Text = "0";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            cancel = true;
            if(String.IsNullOrEmpty((userBindingSource.Current as user).auth_name)||db.users.Where(u=>u.auth_name==txtName.Text).ToList().Count==0)
            {
                  db.users.Remove(userBindingSource.Current as user);
            }
          
            this.Close();
        }

       
    }
}
