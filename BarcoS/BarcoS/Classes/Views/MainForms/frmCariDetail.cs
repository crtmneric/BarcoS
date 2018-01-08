using BarcoS.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BarcoS.Classes.Views.MainForms
{
    public partial class frmCariDetail : Form
    {
        CloudEntities db;
        public static int cariIDGlobal;
        public frmCariDetail(int cariID,String telefon,String authName)
        {

          
            InitializeComponent();
            db = new CloudEntities();
            cariIDGlobal = cariID;
            var cariDetails = db.Current_Details.Where(u => u.current_id == cariID);            
            lblAuth.Text = "Yetkili Kişi-Firma:" + authName;
            lblPhone.Text = "Telefon:" + telefon;
            gridView1.Appearance.FooterPanel.Font = new Font("Segoe UI", 18);
            gridView1.BestFitColumns();
            currentDetailsBindingSource.DataSource = cariDetails.ToList(); 
        }

        private void tileClose_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Close();
        }

        private void tileDeleteUser_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (currentDetailsBindingSource.Current != null)
            {
                if (MessageBox.Show("Bu kayıdı silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Currenty editCari = db.Currenties.Where(u => u.id == cariIDGlobal).SingleOrDefault();
                    editCari.bakiye += -1 * Convert.ToDecimal((currentDetailsBindingSource.Current as Current_Details).price);
                    frmLogin.Log.Info(string.Format("a Current Detail has been deleted, Deleted Bakiye:{0}", (currentDetailsBindingSource.Current as Current_Details).price));
                    db.Current_Details.Remove(currentDetailsBindingSource.Current as Current_Details);
                    currentDetailsBindingSource.RemoveCurrent();
                    db.SaveChanges();

                }
            }
        }

        private void tileAddUser_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            using (BarcoS.Classes.Views.EditForms.frmEditCariDetail frm = new BarcoS.Classes.Views.EditForms.frmEditCariDetail(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var cariDetails = db.Current_Details.Where(u => u.current_id == cariIDGlobal);
                    currentDetailsBindingSource.DataSource = cariDetails.ToList(); 
                }
            }
        }

        private void tileEdit_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (currentDetailsBindingSource.Current == null)
                return;
            using (BarcoS.Classes.Views.EditForms.frmEditCariDetail frm = new BarcoS.Classes.Views.EditForms.frmEditCariDetail(currentDetailsBindingSource.Current as Current_Details))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var cariDetails = db.Current_Details.Where(u => u.current_id == cariIDGlobal);
                    currentDetailsBindingSource.DataSource = cariDetails.ToList(); 
                }
            }
        }

        private void tileReporting_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            gridControl1.ShowRibbonPrintPreview();          
            this.Cursor = Cursors.Default;
        }

      

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (currentDetailsBindingSource.Current == null)
                return;
            using (BarcoS.Classes.Views.EditForms.frmEditCariDetail frm = new BarcoS.Classes.Views.EditForms.frmEditCariDetail(currentDetailsBindingSource.Current as Current_Details))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var cariDetails = db.Current_Details.Where(u => u.current_id == cariIDGlobal);
                    currentDetailsBindingSource.DataSource = cariDetails.ToList();
                }
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
                if (currentDetailsBindingSource.Current != null)
                {
                    if (MessageBox.Show("Bu kayıdı silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Currenty editCari = db.Currenties.Where(u => u.id == cariIDGlobal).SingleOrDefault();
                        editCari.bakiye += -1 * Convert.ToDecimal((currentDetailsBindingSource.Current as Current_Details).price);
                        frmLogin.Log.Info(string.Format("a Current Detail has been deleted, Deleted Bakiye:{0}", (currentDetailsBindingSource.Current as Current_Details).price));
                        db.Current_Details.Remove(currentDetailsBindingSource.Current as Current_Details);
                        currentDetailsBindingSource.RemoveCurrent();
                        db.SaveChanges();

                    }
                }
            }
        }

       
    }
}
