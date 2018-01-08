using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcoS.Classes.Views.MainForms
{
    public partial class frmCloseMin : Form
    {
        public frmCloseMin()
        {
            InitializeComponent();
        }

        private void tileClose_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmLogin.Log.Info("User has been logout:" + frmLogin.sessionuser);         
            Application.Exit();
        }

        private void tileMinimize_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
           try
           {
               foreach (Form openForms in Application.OpenForms)
               {                  
                   openForms.WindowState = FormWindowState.Minimized;                  
               }                           
           }
            catch(Exception ex)
           {
               frmLogin.Log.Error("Cannot minimize app", ex);
           }
           
        }

        private void notifyApp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                foreach (Form openForms in Application.OpenForms)
                {
                    openForms.WindowState = FormWindowState.Maximized;
                  
                }

            }
            catch(Exception ex)
            {
                frmLogin.Log.Error("Cannot open app from tray", ex);
            }
           

        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Close();
          
        }
    }
}
