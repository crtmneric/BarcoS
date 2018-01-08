using BarcoS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BarcoS.Classes.Views.MainForms
{
    public partial class frmUsers : Form
    {
        CloudEntities db = new CloudEntities();
        public frmUsers()
        {
            InitializeComponent();     
            userBindingSource.DataSource = db.users.ToList();
        }

        private void tileClose_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
         
            this.Close();
        }

        private void tileEdit_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (userBindingSource.Current == null)
                return;
            using (BarcoS.Classes.Views.EditForms.frmEditUser frm = new BarcoS.Classes.Views.EditForms.frmEditUser(userBindingSource.Current as user))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    userBindingSource.DataSource = db.users.ToList();
            }
        }

        private void tileAddUser_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            
            using (BarcoS.Classes.Views.EditForms.frmEditUser frm = new BarcoS.Classes.Views.EditForms.frmEditUser(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    userBindingSource.DataSource = db.users.ToList();
            }
        }

        private void tileDeleteUser_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (userBindingSource.Current != null)
            {
                if (MessageBox.Show("Bu kayıdı silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    BarcoS.Classes.Views.MainForms.frmLogin.Log.Info("a user has been deleted, Name:" + (userBindingSource.Current as user).auth_name);
                    db.users.Remove(userBindingSource.Current as user);
                    userBindingSource.RemoveCurrent();
                    db.SaveChanges();               
                }
            }
        }

       

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (userBindingSource.Current == null)
                return;
            using (BarcoS.Classes.Views.EditForms.frmEditUser frm = new BarcoS.Classes.Views.EditForms.frmEditUser(userBindingSource.Current as user))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    userBindingSource.DataSource = db.users.ToList();
            }
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.P)
            {
                this.Cursor = Cursors.WaitCursor;
                gridControl1.ShowRibbonPrintPreview();
                this.Cursor = Cursors.WaitCursor;
            }
            if (e.KeyCode == Keys.Delete)
            {
                if (userBindingSource.Current != null)
                {
                    if (MessageBox.Show("Bu kayıdı silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        BarcoS.Classes.Views.MainForms.frmLogin.Log.Info("a user has been deleted, Name:" + (userBindingSource.Current as user).auth_name);
                        db.users.Remove(userBindingSource.Current as user);
                        userBindingSource.RemoveCurrent();
                        db.SaveChanges();
                    }
                }
            }
        }

       

       
      
    }
}
