using BarcoS.Models;
using BarcoS.Properties;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BarcoS.Classes.Views.MainForms
{
    public partial class frmNotifications : Form
    {
        CloudEntities db;
        public frmNotifications()
        {
            InitializeComponent();
            db = new CloudEntities();
            GetNotifications();
        }
        private void GetNotifications()
        {
            this.Cursor = Cursors.WaitCursor;
            List<Feature> features = new List<Feature>();
            features = db.Features.ToList();
            if(features.Count!=1)
            {
                foreach (Feature feature in features)
                {
                    if(feature.company_id==2)
                    {
                        TileItem item = new TileItem();
                        TileItemElement medTileItem = new TileItemElement();
                        medTileItem.Appearance.Normal.Font = new Font("Segoe UI", 12);
                        medTileItem.Text = feature.name;
                        item.ItemSize = TileItemSize.Wide;
                        item.AppearanceItem.Normal.BackColor = Color.DarkCyan;
                        item.AppearanceItem.Normal.BackColor2 = Color.Turquoise;
                        item.AppearanceItem.Normal.ForeColor = Color.Red;
                        item.TextAlignment = TileItemContentAlignment.TopCenter;
                        item.ImageAlignment = TileItemContentAlignment.BottomCenter;
                        if (feature.name.Contains("cari"))
                        {
                            item.Image = Resources.bocustomer_32x32;
                        }
                        if (feature.name.Contains("stok"))
                        {
                            item.Image = Resources.boorderitem_32x32;
                        }
                        item.ItemClick += new TileItemClickEventHandler(GetNotify);
                        item.Elements.Add(medTileItem);
                        tileGroupNotif.Items.Add(item);
                    }
                
                }              
            }
            else
            {
                TileItem item = new TileItem();
                TileItemElement medTileItem = new TileItemElement();
                medTileItem.Appearance.Normal.Font = new Font("Segoe UI", 12);
                medTileItem.Text = "Bildiriminiz bulunmamaktadır..";
                item.ItemSize = TileItemSize.Wide;
                item.AppearanceItem.Normal.BackColor = Color.DarkCyan;
                item.AppearanceItem.Normal.BackColor2 = Color.Turquoise;
                item.ImageAlignment = TileItemContentAlignment.MiddleLeft;
                item.ImageToTextAlignment = TileControlImageToTextAlignment.Left;
                item.Elements.Add(medTileItem);
                tileGroupNotif.Items.Add(item);
                
            }
            tileControl1.Refresh();
            this.Cursor = Cursors.Default;
            
           
        }
        private void GetNotify(object sender, TileItemEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
           
            bool cariContain =e.Item.Text2.Contains("cari"); 
            if(cariContain)
            {
                var result = db.Features.SingleOrDefault(b => b.name == e.Item.Text2);
                result.company_id = 3;
                frmCari cariForm = new frmCari();
                cariForm.ShowDialog();
               
              
                
            }
            bool stokContain = e.Item.Text2.Contains("stok");
            if (stokContain)
            {
                var result = db.Features.SingleOrDefault(b => b.name == e.Item.Text2);
                result.company_id = 3;
            
                frmStock stokForm = new frmStock();
                stokForm.ShowDialog();
               
            }
            db.SaveChanges();
            this.Cursor = Cursors.Default;
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }
    }
}
