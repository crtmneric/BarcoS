using BarcoS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcoS.Classes.Views.MainForms
{
    public partial class frmSellToCurrency : Form
    {
        CloudEntities db;
        double SellTotalCurrent = 0;
        String AllRawValues;
 
        public frmSellToCurrency(String RowValues , double SellTotal)
        {
            InitializeComponent();
            AllRawValues = RowValues;
            SellTotalCurrent = SellTotal;
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
                if (currentycik.current_type != 5)
                {
                    withoutDailyCurrenties.Add(currentycik);
                }
            }
            gridView1.Appearance.FooterPanel.Font = new Font("Segoe UI", 18);
            currentyBindingSource.DataSource = withoutDailyCurrenties;
        }

      
        private void tileCategories_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            PurchaseCash();
        }
        private void PurchaseCash()
        {
            try
            {
                
                    frmLogin.Log.Info(string.Format("A Cash purchase has been made:{0}{1}{2}", Environment.NewLine, AllRawValues, SellTotalCurrent));
                    CultureInfo tr = new CultureInfo("tr-TR");
                    Currenty dailySell =currentyBindingSource.Current as Currenty;
                    if (dailySell != null)
                    {
                        dailySell.bakiye += Convert.ToDecimal(SellTotalCurrent);
                        Current_Details dailySellDetail = new Current_Details() { current_id = dailySell.id, text = string.Format("{0}{1}Veresiye", AllRawValues, Environment.NewLine), price = Convert.ToDecimal(SellTotalCurrent), reg_date = DateTime.Now.ToString("dd MMMM yyyy dddd hh:mm", tr) };
                        PurchaseToDB(dailySellDetail);
                    }
                    Feature dailyFeature = (db.Features.Where(a => a.id == 1)).SingleOrDefault();
                    Currenty dailySellDate = db.Currenties.Where(u => u.auth_name == dailyFeature.name).SingleOrDefault();                                       
                    dailySellDate.bakiye += Convert.ToDecimal(SellTotalCurrent);
                    Current_Details dailySellDetailt = new Current_Details() { current_id = dailySellDate.id, text = string.Format("{0}{1}Veresiye", AllRawValues, Environment.NewLine), price = Convert.ToDecimal(SellTotalCurrent), reg_date = DateTime.Now.ToString("dd MMMM yyyy dddd hh:mm", tr) };
                    PurchaseToDB(dailySellDetailt);
                    
            }
            catch (Exception ex)
            {
                frmLogin.Log.Error("Somethink went wrong", ex);
            }
        }
        private void PurchaseToDB(Current_Details dailySellDetail)
        {
            db.Current_Details.Add(dailySellDetail);
            db.SaveChanges();
            ListCurrenties();
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            using (BarcoS.Classes.Views.EditForms.frmEditCari frm = new BarcoS.Classes.Views.EditForms.frmEditCari(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    ListCurrenties();
            }
        }
    }
}
