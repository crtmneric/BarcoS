using BarcoS.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;


namespace BarcoS.Classes.Views.MainForms
{
    public partial class frmMain : Form
    {
        CloudEntities db;
        public frmMain()
        {
            InitializeComponent();
            db = new CloudEntities();
            CultureInfo tr = tileEddits();
            dailyCurrentyCheck(tr);
            CheckNotifications();
        }

        private void CheckNotifications()
        {
            int notifyCount = 0;
            
            this.Cursor = Cursors.WaitCursor;
            List<Currenty> currenties = new List<Currenty>();
            currenties = db.Currenties.ToList();
            List<Product> products = new List<Product>();
            products = db.Products.ToList();
            foreach(Currenty currenty in currenties)
            {
                if(currenty.bakiye<currenty.risk_limit)
                {
                    Feature notify = new Feature() { name = string.Format("{0} cari hesabının bakiyesi risk limitinin altındadır! Bakiye:{1} Limit:{2}", currenty.auth_name, currenty.bakiye, currenty.risk_limit),company_id=2 };
                    Feature notifyToFind = new Feature();
                    notifyToFind = db.Features.Where(u=>u.name==notify.name).SingleOrDefault() as Feature;
                    if(notifyToFind==null)
                    {
                        db.Features.Add(notify);
                    }
                  
                }
            }
            foreach(Product product in products)
            {
                if(product.stock<product.risk_limit)
                {
                    Feature notify = new Feature() { name = string.Format("{0} ürününün stok sayısı risk limitinin altındadır! Stok Sayısı:{1} Risk Limiti:{2}", product.name, product.stock, product.risk_limit) ,company_id=2};
                    Feature notifyToFind = new Feature();
                    notifyToFind = db.Features.Where(u => u.name == notify.name).SingleOrDefault() as Feature;
                    if(notifyToFind==null)
                    {
                        db.Features.Add(notify);
                    }                
                }
            }
            db.SaveChanges();
            List<Feature> features = new List<Feature>();
            features = db.Features.ToList();
            foreach(Feature feature in features)
            {
                if(feature.company_id==2)
                {
                    notifyCount++;
                }
            }
          
            if(notifyCount>0)
            {
                tileNotif.AppearanceItem.Normal.ForeColor = Color.Red;
                tileNotif.Text = notifyCount + " BİLDİRİM BULUNMAKTA!";
            }
            else
            {
                tileNotif.Text = "BİLDİRİM YOK";
            }
            
            this.Cursor = Cursors.Default;
        }
        private void dailyCurrentyCheck(CultureInfo tr)
        {
            String datecik = string.Format("{0}-{1}", DateTime.Now.ToString("dd MMMM yyyy dddd HH:mm", tr), frmLogin.sessionuser);            
            if(db.Features.ToList().Count==0)
            {
                Currenty dayStarts = new Currenty() { auth_name = string.Format("{0}-{1}", DateTime.Now.ToString("dd MMMM yyyy dddd HH:mm", tr), frmLogin.sessionuser), current_type = 5, bakiye = 0 };
                Feature currentDate = new Feature() { name = datecik ,company_id=1};
                db.Features.Add(currentDate);
                db.Currenties.Add(dayStarts);             
                db.SaveChanges();
            }         
        }

        private CultureInfo tileEddits()
        {
            CultureInfo tr = new CultureInfo("tr-TR");
            lblSystemInf.Text = string.Format("RNAPOS | {0} | {1} | Licence:{2}-{3}", DateTime.Now.ToString("dd MMMM yyyy dddd", tr), frmLogin.sessionuser, GetMACAddress2(), Environment.MachineName);            
            int isAdmin = Convert.ToInt32(db.users.Where(u => u.auth_name == frmLogin.sessionuser).Select(u => u.is_admin).SingleOrDefault());
            if (isAdmin == 0)
            {
                isAdminnControl();
            }
            return tr;
        }
        public static string GetMACAddress2()
        {
            try
            {
                NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
                String sMacAddress = string.Empty;
                foreach (NetworkInterface adapter in nics)
                {
                    if (sMacAddress == String.Empty)  
                    {
                        sMacAddress = adapter.GetPhysicalAddress().ToString();
                    }
                } return sMacAddress;
            }
            catch(Exception ex)
            {
                frmLogin.Log.Error("Can't get mac adress", ex);
                return null;
            }
        }
        private void isAdminnControl()
        {
            tileAddItem.Enabled = false;
            tileCari.Enabled = false;
            tileReport.Enabled = false;
            tileNotif.Enabled = false;
            tileUsers.Enabled = false;
            tileTicket.Enabled = false;
        }



        private void tileSellScreen_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;     
            frmSellScreen sellScreen = new frmSellScreen();         
            sellScreen.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void tileAddItem_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmStock formStock = new frmStock();         
            formStock.ShowDialog();
            this.Cursor = Cursors.Default;
                    
        }

        private void tileQuit_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmCloseMin formClos= new frmCloseMin();
            formClos.ShowDialog();
        }

        

        private void tileReport_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmDayStatics DailyStatics = new frmDayStatics();      
            DailyStatics.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void tileUsers_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmUsers usersForm = new frmUsers();          
            usersForm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void tileCari_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmCari cariForm = new frmCari();        
            cariForm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void tileTicket_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
          

        }

        private void tileDayToDo_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            CultureInfo tr = new CultureInfo("tr-TR");

            Currenty dayStarts = new Currenty() { auth_name = string.Format("{0}-{1}", DateTime.Now.ToString("dd MMMM yyyy dddd HH:mm", tr), frmLogin.sessionuser), current_type = 5 ,bakiye=0};
            Feature currentDay = db.Features.Where(u => u.id == 1).SingleOrDefault() as Feature;
            MessageBox.Show(currentDay.name+" Tarihli gün sonu işleminiz başarıyla gerçekleşmiştir.", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            currentDay.name=string.Format("{0}-{1}", DateTime.Now.ToString("dd MMMM yyyy dddd HH:mm", tr),frmLogin.sessionuser);         
            db.Currenties.Add(dayStarts);
            db.SaveChanges();
           
      
        }

       

        private void tileNotif_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmNotifications notifyForm = new frmNotifications();
            notifyForm.ShowDialog();

        }
    }
}
