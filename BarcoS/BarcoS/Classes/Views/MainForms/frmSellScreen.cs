using BarcoS.Models;
using BarcoS.Properties;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BarcoS.Classes.Views.MainForms
{
    public partial class frmSellScreen : Form
    {
        CloudEntities db;
        ProductforSale lastDeleted;
         BindingList<ProductforSale> productsList = new BindingList<ProductforSale>();
         Boolean cash, card,userClicked;
        public frmSellScreen()
        {
            InitializeComponent();
            lastDeleted = new ProductforSale();
            db=new CloudEntities();
            gridBarcodeSell.CellValueChanged +=  gridBarcodeSell_CellValueChanged;
            gridBarcodeSell.OptionsBehavior.EditorShowMode = EditorShowMode.Click;
            InitalizeCategories();
            
        }           
        private void InitalizeGrid()
        {
            
            gridBarcodeSell.Columns[0].Image = Resources.boorderitem_32x32;
            gridBarcodeSell.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 16);
            gridBarcodeSell.Columns[0].AppearanceHeader.Font = new Font("Segoe UI", 18);
            RepositoryItemMemoEdit repoMemo = new RepositoryItemMemoEdit();
            gridSales.RepositoryItems.Add(repoMemo);
            gridBarcodeSell.Columns[0].ColumnEdit = repoMemo;
            gridBarcodeSell.Columns[1].ColumnEdit = repoMemo;
            gridBarcodeSell.Columns[2].ColumnEdit = repoMemo;
            gridBarcodeSell.Columns[1].Image = Resources.boorder_32x32;
            gridBarcodeSell.Columns[1].AppearanceCell.Font = new Font("Segoe UI", 16);
            gridBarcodeSell.Columns[1].AppearanceHeader.Font = new Font("Segoe UI", 18);       
            gridBarcodeSell.Columns[2].Image = Resources.currency_32x32;
            gridBarcodeSell.Columns[2].AppearanceCell.Font = new Font("Segoe UI", 16);
            gridBarcodeSell.Columns[2].AppearanceHeader.Font = new Font("Segoe UI", 18);
            gridBarcodeSell.Columns[2].SummaryItem.DisplayFormat = "TOPLAM={0:0.##}₺";           
            gridBarcodeSell.Columns[2].SummaryItem.SummaryType = SummaryItemType.Sum;
            gridBarcodeSell.OptionsView.ColumnHeaderAutoHeight = DefaultBoolean.True;
            gridBarcodeSell.Columns[1].OptionsColumn.AllowEdit = false;
            gridBarcodeSell.Columns[1].OptionsColumn.ReadOnly = true;
            gridBarcodeSell.Columns[2].OptionsColumn.AllowEdit = false;
            gridBarcodeSell.Columns[2].OptionsColumn.ReadOnly = true;
            gridBarcodeSell.OptionsView.RowAutoHeight = true;
            gridBarcodeSell.OptionsView.ColumnAutoWidth = true;
            gridBarcodeSell.OptionsView.ColumnHeaderAutoHeight = DefaultBoolean.True;
            gridBarcodeSell.Appearance.FooterPanel.Font = new Font("Segoe UI", 18);
            gridBarcodeSell.Columns[0].BestFit();
            gridBarcodeSell.Columns[1].BestFit();
            gridBarcodeSell.Columns[2].BestFit();                       
        }
        private string GetAllRowValues()
        {
            string salesText = null;
            for(int i = 0 ; i< gridBarcodeSell.RowCount;i++)
            {
                salesText += string.Format("{0} - {1} - {2}{3}", gridBarcodeSell.GetRowCellValue(i, gridBarcodeSell.Columns[0]), gridBarcodeSell.GetRowCellValue(i, gridBarcodeSell.Columns[1]), gridBarcodeSell.GetRowCellValue(i, gridBarcodeSell.Columns[2]), Environment.NewLine);
            }
            return salesText;

        }
        private double getSellTotal()
        {
            double salesTotal =0;
            for(int i = 0; i<gridBarcodeSell.RowCount;i++)
            {
                salesTotal += Convert.ToDouble(gridBarcodeSell.GetRowCellValue(i, gridBarcodeSell.Columns[2]));
            }
            return salesTotal;

        }
        private void InitalizeCategories()
        {
            List<category> categories = new List<category>();
            categories = db.categories.ToList();
            foreach (category cat in categories)
            {
                if (cat.plu == 1)
                {
                    TileItem item = new TileItem();
                    TileItemElement medTileItem = new TileItemElement();
                    medTileItem.Appearance.Normal.Font = new Font("Segoe UI", tileClose.AppearanceItem.Normal.Font.Size);
                    medTileItem.Text = cat.name;
                    item.ItemSize = TileItemSize.Wide;
                    item.AppearanceItem.Normal.BackColor = Color.MediumTurquoise;
                    item.AppearanceItem.Normal.BackColor2 = Color.PaleTurquoise;
                    item.ItemClick += new TileItemClickEventHandler(GetCatItems);
                    item.Elements.Add(medTileItem);
                    tileCatItemss.Items.Add(item);
                }
            }
            tileControl3.Refresh();
            tileControl1.Refresh();
            
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void GetCatItems(object sender,TileItemEventArgs e)
        {
            List<Product> products = new List<Product>();
            products = db.Products.ToList();
            tileCategoryItems.Items.Clear();
            foreach(Product prod in products)
            {               
                
                    if (prod.category_id == Convert.ToInt32((db.categories.Where(u => u.name == e.Item.Text).Select(u => u.id)).SingleOrDefault()))
                    {
                        TileItem item = new TileItem();
                        TileItemElement medTileItem = new TileItemElement();
                       
                        item.ItemSize = TileItemSize.Wide;
                        item.AppearanceItem.Normal.BackColor = Color.DarkCyan;
                        item.AppearanceItem.Normal.BackColor2 = Color.Turquoise;
                        if (prod.product_İmage != null)
                        {
                            medTileItem.Appearance.Normal.Font = new Font("Segoe UI", tileClose.AppearanceItem.Normal.Font.Size);
                            medTileItem.Appearance.Normal.ForeColor = Color.White;
                            medTileItem.TextAlignment = TileItemContentAlignment.BottomCenter;
                            medTileItem.Text = prod.name;
                            item.BackgroundImage = byteArrayToImage(prod.product_İmage);
                        }
                        else
                        {
                            medTileItem.Appearance.Normal.Font = new Font("Segoe UI", tileClose.AppearanceItem.Normal.Font.Size);
                            medTileItem.Appearance.Normal.ForeColor = Color.White;
                            medTileItem.TextAlignment = TileItemContentAlignment.MiddleCenter;
                            medTileItem.Text = prod.name;
                        }
                        item.ItemClick += new TileItemClickEventHandler(GetProdBarcode);
                        item.BackgroundImageScaleMode = TileItemImageScaleMode.Stretch;
                        item.Elements.Add(medTileItem);
                        tileCategoryItems.Items.Add(item);
                    }
                
              
                
            }
           
            
        }
        private void GetProdBarcode(object sender,TileItemEventArgs e)
        {
            txtBarcode.Clear();
            txtBarcode.Text=(db.Products.Where(u=>u.name==e.Item.Text).Select(u=>u.barcode_number)).SingleOrDefault();
        }
        
        private void tileClose_ItemClick(object sender, TileItemEventArgs e)
        {
        
            this.Close();
        }


        private void gridBarcodeSell_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if(userClicked)
            {
                  int parsedValue;
                  if (int.TryParse(gridBarcodeSell.GetRowCellValue(e.RowHandle,gridBarcodeSell.Columns[0]).ToString(), out parsedValue))
                  {
                      userClicked = false;
                      Product productforSale = new Product();
                      string value = gridBarcodeSell.GetRowCellValue(e.RowHandle, gridBarcodeSell.Columns[1]).ToString();
                      productforSale = (db.Products.Where(u => u.name == value)).SingleOrDefault() as Product;
                      gridBarcodeSell.SetRowCellValue(e.RowHandle, gridBarcodeSell.Columns[2], Convert.ToInt32(gridBarcodeSell.GetRowCellValue(e.RowHandle, gridBarcodeSell.Columns[0])) * productforSale.sale_price);
                      gridSales.DataSource = productsList;
                      gridBarcodeSell.PopulateColumns();
                      gridSales.RefreshDataSource();
                      InitalizeGrid(); 
                  }
                 

            }
         
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {         
            try
            {
                if (!String.IsNullOrEmpty(txtBarcode.Text))
                {

                    Product productforSale = new Product();
                    productforSale = (db.Products.Where(u => u.barcode_number == txtBarcode.Text)).SingleOrDefault() as Product;
                    if(productforSale!=null)
                    {
                        int rowHandle = gridBarcodeSell.LocateByValue("Ürün_Adı", productforSale.name);
                        if (rowHandle !=GridControl.InvalidRowHandle)
                        {
                            userClicked = false;
                            gridBarcodeSell.SetRowCellValue(rowHandle, gridBarcodeSell.Columns[0], Convert.ToInt32(gridBarcodeSell.GetRowCellValue(rowHandle, gridBarcodeSell.Columns[0])) + 1);
                            gridBarcodeSell.SetRowCellValue(rowHandle, gridBarcodeSell.Columns[2], Convert.ToInt32(gridBarcodeSell.GetRowCellValue(rowHandle, gridBarcodeSell.Columns[0]))*productforSale.sale_price);

                        }
                        else
                        {
                            ProductforSale ifThereIs = new ProductforSale() { Ürün_Adı = productforSale.name, Toplam = Convert.ToDouble(productforSale.sale_price), Adet = 1 };
                            productsList.Add(ifThereIs);                                                  
                        }
                        gridSales.DataSource = productsList;
                        gridBarcodeSell.PopulateColumns();
                        gridSales.RefreshDataSource();
                        InitalizeGrid();                                    
                    }
                  
                }
            }
            catch(Exception ex)
            {
                frmLogin.Log.Error("There is no product with this barcode:" + txtBarcode.Text, ex);
            }
            
        }
        
        private class ProductforSale
        {
            String productName;      
            int productCount;
            double productTotal;
         
            public int Adet
            {
                get
                {
                    return productCount;
                }
                set
                {
                    productCount = value;
                }
            }
            public String Ürün_Adı
            {
                get
                {
                    return productName;
                }
                set
                {
                    productName = value;
                }
            }
            public double Toplam
            {
                get
                {
                    return productTotal;
                }
                set
                {
                    productTotal = value;
                }
            }
        }

        private void gridSales_KeyDown(object sender, KeyEventArgs e)
        {
            var grid = sender as GridControl;
            var view = grid.FocusedView as GridView;
            if(e.KeyCode==Keys.Delete)
            {
                view.DeleteSelectedRows();
                e.Handled = true;
            }
        }

        private void tileProducts_ItemClick(object sender, TileItemEventArgs e)
        {
            cash = true;
            card = false;
            PurchaseCash();           
        }

        private void PurchaseCash()
        {
            try
            {
                if (getSellTotal() > 0)
                {
                    frmLogin.Log.Info(string.Format("A Cash purchase has been made:{0}{1}{2}", Environment.NewLine, GetAllRowValues(), getSellTotal()));
                    CultureInfo tr = new CultureInfo("tr-TR");
                    Feature dailyFeature = (db.Features.Where(a => a.id == 1)).SingleOrDefault();
                    Currenty dailySell = db.Currenties.Where(u => u.auth_name ==dailyFeature.name).SingleOrDefault();                                  
                    dailySell.bakiye += Convert.ToDecimal(getSellTotal());
                    if(card)
                    {
                        Current_Details dailySellDetail = new Current_Details() { current_id = dailySell.id, text = string.Format("{0}{1}Kredi Kartı", GetAllRowValues(), Environment.NewLine), price = Convert.ToDecimal(getSellTotal()), reg_date = DateTime.Now.ToString("dd MMMM yyyy dddd HH:mm", tr) };
                        PurchaseToDB(dailySellDetail);
                    }
                    else if(cash)
                    {
                        Current_Details dailySellDetail = new Current_Details() { current_id = dailySell.id, text = string.Format("{0}{1}Nakit", GetAllRowValues(), Environment.NewLine), price = Convert.ToDecimal(getSellTotal()), reg_date = DateTime.Now.ToString("dd MMMM yyyy dddd HH:mm", tr) };
                        PurchaseToDB(dailySellDetail);
                    }
                 
                                       
                }
            }
            catch(Exception ex)
            {
                frmLogin.Log.Error("Somethink went wrong while purchasing", ex);               
            }                
        }
        private void PurchaseToDB(Current_Details dailySellDetail)
        {
            db.Current_Details.Add(dailySellDetail);
            db.SaveChanges();
            gridSales.DataSource = null;
            gridSales.RefreshDataSource();
            productsList.Clear();
        }

        private void tileCategories_ItemClick(object sender, TileItemEventArgs e)
        {
            card = true;
            cash = false;
            PurchaseCash();
        }

        private void tileBrands_ItemClick(object sender, TileItemEventArgs e)
        {
            using (frmSellToCurrency currencySell = new frmSellToCurrency(GetAllRowValues(), getSellTotal()))
            {
                if (currencySell.ShowDialog() == DialogResult.OK)
                {
                    gridSales.DataSource = null;
                    gridSales.RefreshDataSource();
                    productsList.Clear();
                }
              
            }
          
        }

        private void gridBarcodeSell_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            userClicked = true;
        }

      

       

     
        
       
    }
}
