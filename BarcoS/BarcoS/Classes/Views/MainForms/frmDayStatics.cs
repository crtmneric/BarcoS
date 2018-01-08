using BarcoS.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BarcoS.Classes.Views.MainForms
{
    public partial class frmDayStatics : Form
    {
        CloudEntities db;
        public frmDayStatics()
        {
            InitializeComponent();
            db = new CloudEntities();
            ListCurrenties();
        }
        private void ListCurrenties()
        {
            List<Currenty> allCurrenties = new List<Currenty>();
            allCurrenties = db.Currenties.ToList();
            List<Currenty> withoutDailyCurrenties = new List<Currenty>();
            foreach (Currenty currentycik in allCurrenties)
            {
                if (currentycik.current_type == 5)
                {
                    withoutDailyCurrenties.Add(currentycik);
                }
            }
            gridView1.Appearance.FooterPanel.Font = new Font("Segoe UI", 18);
            gridView1.BestFitColumns();
            currentyBindingSource.DataSource = withoutDailyCurrenties;

          
        }

        private void tileDeleteUser_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (currentyBindingSource.Current != null)
            {
                if (MessageBox.Show("Bu kayıdı silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    frmLogin.Log.Info(string.Format("a Currenty has been deleted, Name:{0}, Bakiye:{1}", (currentyBindingSource.Current as Currenty).auth_name, (currentyBindingSource.Current as Currenty).bakiye));
                    foreach (Current_Details detailsOfCurrenty in db.Current_Details)
                    {
                        if ((detailsOfCurrenty as Current_Details).current_id == (currentyBindingSource.Current as Currenty).id)
                        {
                            db.Current_Details.Remove(detailsOfCurrenty);
                        }
                    }
                    db.Currenties.Remove(currentyBindingSource.Current as Currenty);
                    currentyBindingSource.RemoveCurrent();
                    db.SaveChanges();

                }
            }
        }

        private void tileDetails_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Currenty clickedCurrenty = currentyBindingSource.Current as Currenty;
            if (clickedCurrenty != null)
            {
                frmCariDetail formDetail = new frmCariDetail(clickedCurrenty.id, clickedCurrenty.auth_gsm, clickedCurrenty.auth_name);
                formDetail.ShowDialog();
                
            }
        }

        private void tileReporting_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            gridControl1.ShowRibbonPrintPreview();
            this.Cursor = Cursors.WaitCursor;
        }

        private void tileClose_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
           
            this.Close();
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Delete)
            {
                if (currentyBindingSource.Current != null)
                {
                    if (MessageBox.Show("Bu kayıdı silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        frmLogin.Log.Info(string.Format("a Currenty has been deleted, Name:{0}, Bakiye:{1}", (currentyBindingSource.Current as Currenty).auth_name, (currentyBindingSource.Current as Currenty).bakiye));
                        foreach (Current_Details detailsOfCurrenty in db.Current_Details)
                        {
                            if ((detailsOfCurrenty as Current_Details).current_id == (currentyBindingSource.Current as Currenty).id)
                            {
                                db.Current_Details.Remove(detailsOfCurrenty);
                            }
                        }
                        db.Currenties.Remove(currentyBindingSource.Current as Currenty);
                        currentyBindingSource.RemoveCurrent();
                        db.SaveChanges();

                    }
                }
            }
            if (e.Control && e.KeyCode == Keys.P)
            {
                this.Cursor = Cursors.WaitCursor;
                gridControl1.ShowRibbonPrintPreview();
                this.Cursor = Cursors.WaitCursor;
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            Currenty clickedCurrenty = currentyBindingSource.Current as Currenty;
            if (clickedCurrenty != null)
            {
                frmCariDetail formDetail = new frmCariDetail(clickedCurrenty.id, clickedCurrenty.auth_gsm, clickedCurrenty.auth_name);
                formDetail.ShowDialog();

            }
        }

    }
}
