using BarcoS.Classes.Views.EditForms;
using BarcoS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BarcoS.Classes.Views.MainForms
{
    public partial class frmStock : Form
    {
        CloudEntities db;
        public frmStock()
        {
            InitializeComponent();
            db = new CloudEntities();
            
            isProductGrid = true;
            productBindingSource.DataSource = db.Products.ToList();
            brandBindingSource.DataSource = db.Brands.ToList();
            categoryBindingSource.DataSource = db.categories.ToList();
            gridBrands.Hide();
            gridCategories.Hide();           
        }
    
        bool isProductGrid,isBrandGrid,isCategoriesGrid;
        
        private void tileClose_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
          
            this.Close();
           
        }

        private void tileProducts_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            tileProducts.Checked = true;
            tileBrands.Checked = false;
            tileCategories.Checked = false;
            gridBrands.Hide();
            gridCategories.Hide();
            gridProducts.Show();
            isProductGrid = true;
            isBrandGrid = false;
            isCategoriesGrid = false;
            tileBarcode.Enabled = true;
        }

        private void tileCategories_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            tileCategories.Checked = true;
            tileProducts.Checked = false;
            tileBrands.Checked = false;
            gridCategories.Show();
            gridBrands.Hide();
            gridProducts.Hide();
            isCategoriesGrid = true;
            isProductGrid = false;
            isBrandGrid = false;
            tileBarcode.Enabled = false;
        }

        private void tileBrands_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            tileBrands.Checked = true;
            tileCategories.Checked = false;
            tileProducts.Checked = false;
            gridBrands.Show();
            gridCategories.Hide();
            gridProducts.Hide();
            isBrandGrid = true;
            isCategoriesGrid = false;
            isProductGrid = false;
            tileBarcode.Enabled = false; ;
        }

        private void tileAddUser_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if(isProductGrid)
            {
                using(frmEditProduct frm = new frmEditProduct(null))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                        productBindingSource.DataSource = db.Products.ToList();
                }
            }
            else if(isBrandGrid)
            {
                using (frmEditBrands frm = new frmEditBrands(null))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                        brandBindingSource.DataSource = db.Brands.ToList();
                }
            }
            else if(isCategoriesGrid)
            {
                using (frmEditCategory frm = new frmEditCategory(null))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                       categoryBindingSource.DataSource = db.categories.ToList();
                }
            }
        }

        private void tileEdit_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (isProductGrid)
            {
                if (productBindingSource.Current == null)
                    return;
                using (frmEditProduct frm = new frmEditProduct(productBindingSource.Current as Product))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                        productBindingSource.DataSource = db.Products.ToList();
                }
            }
            else if (isBrandGrid)
            {
                if (brandBindingSource.Current == null)
                    return;
                using (frmEditBrands frm = new frmEditBrands(brandBindingSource.Current as Brand))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                        brandBindingSource.DataSource = db.Brands.ToList();
                }
            }
            else if (isCategoriesGrid)
            {
                if (categoryBindingSource.Current == null)
                    return;
                using (frmEditCategory frm = new frmEditCategory(categoryBindingSource.Current as category))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                        categoryBindingSource.DataSource = db.categories.ToList();
                }
            }
        }

        private void tileDeleteUser_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (isProductGrid)
            {
                if (productBindingSource.Current != null)
                {
                    if (MessageBox.Show("Bu kayıdı silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        frmLogin.Log.Info("a Product has been deleted, Name:" + (productBindingSource.Current as Product).name);
                        db.Products.Remove(productBindingSource.Current as Product);
                        productBindingSource.RemoveCurrent();
                        db.SaveChanges();

                    }
                }
            }
            else if (isBrandGrid)
            {
                if (brandBindingSource.Current != null)
                {
                    if (MessageBox.Show("Bu kayıdı silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        frmLogin.Log.Info("a Brand has been deleted, Name:" + (brandBindingSource.Current as Brand).name);
                        db.Brands.Remove(brandBindingSource.Current as Brand);
                        brandBindingSource.RemoveCurrent();
                        db.SaveChanges();

                    }
                }
            }
            else if (isCategoriesGrid)
            {
                if (categoryBindingSource.Current != null)
                {
                    if (MessageBox.Show("Bu kayıdı silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        frmLogin.Log.Info("a Category has been deleted, Name:" + (categoryBindingSource.Current as category).name);
                        db.categories.Remove(categoryBindingSource.Current as category);
                        categoryBindingSource.RemoveCurrent();
                        db.SaveChanges();

                    }
                }
            }
        }

        private void gridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (categoryBindingSource.Current != null)
                {
                    if (MessageBox.Show("Bu kayıdı silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        frmLogin.Log.Info("a Category has been deleted, Name:" + (categoryBindingSource.Current as category).name);
                        db.categories.Remove(categoryBindingSource.Current as category);
                        categoryBindingSource.RemoveCurrent();
                        db.SaveChanges();

                    }
                }
            }
        }

        private void gridView3_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Delete)
            {
                if (brandBindingSource.Current != null)
                {
                    if (MessageBox.Show("Bu kayıdı silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        frmLogin.Log.Info("a Brand has been deleted, Name:" + (brandBindingSource.Current as Brand).name);
                        db.Brands.Remove(brandBindingSource.Current as Brand);
                        brandBindingSource.RemoveCurrent();
                        db.SaveChanges();

                    }
                }
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (productBindingSource.Current != null)
                {
                    if (MessageBox.Show("Bu kayıdı silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        frmLogin.Log.Info("a Product has been deleted, Name:" + (productBindingSource.Current as Product).name);
                        db.Products.Remove(productBindingSource.Current as Product);
                        productBindingSource.RemoveCurrent();
                        db.SaveChanges();

                    }
                }
            }
        }

        private void tileReport_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if(isBrandGrid)
            {
                this.Cursor = Cursors.WaitCursor;
                gridBrands.ShowRibbonPrintPreview();
                this.Cursor = Cursors.Default;
            }
            else if(isCategoriesGrid)
            {
                this.Cursor = Cursors.WaitCursor;
                gridCategories.ShowRibbonPrintPreview();
                this.Cursor = Cursors.Default;
            }
            else if(isProductGrid)
            {
                this.Cursor = Cursors.WaitCursor;
                gridProducts.ShowRibbonPrintPreview();
                this.Cursor = Cursors.Default;
            }
        }

        private void tileBarcode_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (productBindingSource.Current == null)
                return;
            using (frmBarcode frm = new frmBarcode(productBindingSource.Current as Product))
            {
                frm.ShowDialog();
            }
          
        }

        private void gridProducts_DoubleClick(object sender, EventArgs e)
        {
            if (productBindingSource.Current == null)
                return;
            using (frmEditProduct frm = new frmEditProduct(productBindingSource.Current as Product))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    productBindingSource.DataSource = db.Products.ToList();
            }
        }

        private void gridCategories_DoubleClick(object sender, EventArgs e)
        {
            if (categoryBindingSource.Current == null)
                return;
            using (frmEditCategory frm = new frmEditCategory(categoryBindingSource.Current as category))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    categoryBindingSource.DataSource = db.categories.ToList();
            }
        }

        private void gridBrands_DoubleClick(object sender, EventArgs e)
        {
            if (brandBindingSource.Current == null)
                return;
            using (frmEditBrands frm = new frmEditBrands(brandBindingSource.Current as Brand))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    brandBindingSource.DataSource = db.Brands.ToList();
            }
        }
    }
}
