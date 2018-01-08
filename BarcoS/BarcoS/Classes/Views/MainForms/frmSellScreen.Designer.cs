namespace BarcoS.Classes.Views.MainForms
{
    partial class frmSellScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSellScreen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tileControl2 = new DevExpress.XtraEditors.TileControl();
            this.tileProccess = new DevExpress.XtraEditors.TileGroup();
            this.tileProducts = new DevExpress.XtraEditors.TileItem();
            this.tileCategories = new DevExpress.XtraEditors.TileItem();
            this.tileBrands = new DevExpress.XtraEditors.TileItem();
            this.tileClose = new DevExpress.XtraEditors.TileItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileCategoryItems = new DevExpress.XtraEditors.TileGroup();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridSales = new DevExpress.XtraGrid.GridControl();
            this.gridBarcodeSell = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridNamee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tileControl3 = new DevExpress.XtraEditors.TileControl();
            this.tileCatItemss = new DevExpress.XtraEditors.TileGroup();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.tileCats = new DevExpress.XtraEditors.TileGroup();
            this.tileCatItems = new DevExpress.XtraEditors.TileGroup();
            this.gridName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBarcodeSell)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tileControl2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 827);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // tileControl2
            // 
            this.tileControl2.AllowDrag = false;
            this.tileControl2.AllowDragTilesBetweenGroups = false;
            this.tileControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl2.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl2.Groups.Add(this.tileProccess);
            this.tileControl2.IndentBetweenItems = 10;
            this.tileControl2.ItemSize = 100;
            this.tileControl2.Location = new System.Drawing.Point(3, 18);
            this.tileControl2.MaxId = 10;
            this.tileControl2.Name = "tileControl2";
            this.tileControl2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileControl2.Padding = new System.Windows.Forms.Padding(0);
            this.tileControl2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tileControl2.ShowGroupText = true;
            this.tileControl2.Size = new System.Drawing.Size(248, 806);
            this.tileControl2.TabIndex = 0;
            this.tileControl2.Text = "tileControl2";
            this.tileControl2.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            // 
            // tileProccess
            // 
            this.tileProccess.Items.Add(this.tileProducts);
            this.tileProccess.Items.Add(this.tileCategories);
            this.tileProccess.Items.Add(this.tileBrands);
            this.tileProccess.Items.Add(this.tileClose);
            this.tileProccess.Name = "tileProccess";
            // 
            // tileProducts
            // 
            this.tileProducts.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkCyan;
            this.tileProducts.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.LightSeaGreen;
            this.tileProducts.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileProducts.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileProducts.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileProducts.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileProducts.AppearanceItem.Normal.Options.UseFont = true;
            this.tileProducts.AppearanceItem.Selected.BackColor = System.Drawing.Color.Turquoise;
            this.tileProducts.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.Gold;
            this.tileProducts.AppearanceItem.Selected.BorderColor = System.Drawing.Color.Black;
            this.tileProducts.AppearanceItem.Selected.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileProducts.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tileProducts.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.tileProducts.AppearanceItem.Selected.Options.UseFont = true;
            this.tileProducts.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement1.Image = global::BarcoS.Properties.Resources.currency_32x32;
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement1.Text = "NAKİT";
            this.tileProducts.Elements.Add(tileItemElement1);
            this.tileProducts.Id = 1;
            this.tileProducts.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileProducts.Name = "tileProducts";
            this.tileProducts.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileProducts_ItemClick);
            // 
            // tileCategories
            // 
            this.tileCategories.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkCyan;
            this.tileCategories.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.LightSeaGreen;
            this.tileCategories.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileCategories.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileCategories.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileCategories.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileCategories.AppearanceItem.Normal.Options.UseFont = true;
            this.tileCategories.AppearanceItem.Selected.BackColor = System.Drawing.Color.Turquoise;
            this.tileCategories.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.Gold;
            this.tileCategories.AppearanceItem.Selected.BorderColor = System.Drawing.Color.Black;
            this.tileCategories.AppearanceItem.Selected.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileCategories.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tileCategories.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.tileCategories.AppearanceItem.Selected.Options.UseFont = true;
            this.tileCategories.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement2.Image = global::BarcoS.Properties.Resources.send_32x32;
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement2.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement2.Text = "KREDİ KARTI";
            this.tileCategories.Elements.Add(tileItemElement2);
            this.tileCategories.Id = 3;
            this.tileCategories.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileCategories.Name = "tileCategories";
            this.tileCategories.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileCategories_ItemClick);
            // 
            // tileBrands
            // 
            this.tileBrands.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkCyan;
            this.tileBrands.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.LightSeaGreen;
            this.tileBrands.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileBrands.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileBrands.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBrands.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileBrands.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBrands.AppearanceItem.Selected.BackColor = System.Drawing.Color.Turquoise;
            this.tileBrands.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.Gold;
            this.tileBrands.AppearanceItem.Selected.BorderColor = System.Drawing.Color.Black;
            this.tileBrands.AppearanceItem.Selected.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileBrands.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tileBrands.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.tileBrands.AppearanceItem.Selected.Options.UseFont = true;
            this.tileBrands.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement3.Image = global::BarcoS.Properties.Resources.boreport_32x32;
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement3.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement3.Text = "VERESİYE";
            this.tileBrands.Elements.Add(tileItemElement3);
            this.tileBrands.Id = 4;
            this.tileBrands.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileBrands.Name = "tileBrands";
            this.tileBrands.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBrands_ItemClick);
            // 
            // tileClose
            // 
            this.tileClose.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkCyan;
            this.tileClose.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.LightSeaGreen;
            this.tileClose.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileClose.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileClose.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement4.Image = global::BarcoS.Properties.Resources.backward_32x32;
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement4.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement4.Text = "Ana Ekrana Dön";
            this.tileClose.Elements.Add(tileItemElement4);
            this.tileClose.Id = 9;
            this.tileClose.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileClose.Name = "tileClose";
            this.tileClose.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileClose_ItemClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tileControl1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(1247, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 827);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // tileControl1
            // 
            this.tileControl1.AllowDrag = false;
            this.tileControl1.AllowDragTilesBetweenGroups = false;
            this.tileControl1.BackColor = System.Drawing.Color.White;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl1.Groups.Add(this.tileCategoryItems);
            this.tileControl1.IndentBetweenItems = 10;
            this.tileControl1.ItemSize = 100;
            this.tileControl1.Location = new System.Drawing.Point(3, 18);
            this.tileControl1.MaxId = 11;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Padding = new System.Windows.Forms.Padding(0);
            this.tileControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tileControl1.RowCount = 10;
            this.tileControl1.ShowGroupText = true;
            this.tileControl1.Size = new System.Drawing.Size(234, 806);
            this.tileControl1.TabIndex = 1;
            this.tileControl1.Text = "tileControl1";
            this.tileControl1.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            // 
            // tileCategoryItems
            // 
            this.tileCategoryItems.Name = "tileCategoryItems";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.gridSales);
            this.groupBox3.Controls.Add(this.txtBarcode);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(254, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(731, 827);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // gridSales
            // 
            this.gridSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSales.Location = new System.Drawing.Point(3, 99);
            this.gridSales.MainView = this.gridBarcodeSell;
            this.gridSales.Name = "gridSales";
            this.gridSales.Size = new System.Drawing.Size(725, 725);
            this.gridSales.TabIndex = 1;
            this.gridSales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridBarcodeSell});
            this.gridSales.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridSales_KeyDown);
            // 
            // gridBarcodeSell
            // 
            this.gridBarcodeSell.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridBarcodeSell.Appearance.Row.Options.UseFont = true;
            this.gridBarcodeSell.Appearance.ViewCaption.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.gridBarcodeSell.Appearance.ViewCaption.Options.UseFont = true;
            this.gridBarcodeSell.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridNamee,
            this.gridCount,
            this.gridTotal});
            this.gridBarcodeSell.GridControl = this.gridSales;
            this.gridBarcodeSell.Name = "gridBarcodeSell";
            this.gridBarcodeSell.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridBarcodeSell.OptionsView.RowAutoHeight = true;
            this.gridBarcodeSell.OptionsView.ShowFooter = true;
            this.gridBarcodeSell.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridBarcodeSell_RowCellClick);
            // 
            // gridNamee
            // 
            this.gridNamee.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridNamee.AppearanceCell.Options.UseFont = true;
            this.gridNamee.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.gridNamee.AppearanceHeader.Options.UseFont = true;
            this.gridNamee.Caption = "Adet";
            this.gridNamee.Image = global::BarcoS.Properties.Resources.boorderitem_32x32;
            this.gridNamee.Name = "gridNamee";
            this.gridNamee.Visible = true;
            this.gridNamee.VisibleIndex = 0;
            // 
            // gridCount
            // 
            this.gridCount.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridCount.AppearanceCell.Options.UseFont = true;
            this.gridCount.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.gridCount.AppearanceHeader.Options.UseFont = true;
            this.gridCount.Caption = "Ürün_Adı";
            this.gridCount.Image = global::BarcoS.Properties.Resources.boorder_32x32;
            this.gridCount.Name = "gridCount";
            this.gridCount.OptionsColumn.AllowEdit = false;
            this.gridCount.OptionsColumn.ReadOnly = true;
            this.gridCount.Visible = true;
            this.gridCount.VisibleIndex = 1;
            // 
            // gridTotal
            // 
            this.gridTotal.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridTotal.AppearanceCell.Options.UseFont = true;
            this.gridTotal.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.gridTotal.AppearanceHeader.Options.UseFont = true;
            this.gridTotal.Caption = "Toplam";
            this.gridTotal.Image = global::BarcoS.Properties.Resources.currency_32x32;
            this.gridTotal.Name = "gridTotal";
            this.gridTotal.OptionsColumn.AllowEdit = false;
            this.gridTotal.OptionsColumn.ReadOnly = true;
            this.gridTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "TOPLAM={0:0.##}")});
            this.gridTotal.Visible = true;
            this.gridTotal.VisibleIndex = 2;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarcode.Location = new System.Drawing.Point(3, 18);
            this.txtBarcode.Multiline = true;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(725, 81);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.Text = "46465465456456546";
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tileControl3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(985, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 827);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // tileControl3
            // 
            this.tileControl3.AllowDrag = false;
            this.tileControl3.AllowDragTilesBetweenGroups = false;
            this.tileControl3.BackColor = System.Drawing.Color.White;
            this.tileControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl3.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl3.Groups.Add(this.tileCatItemss);
            this.tileControl3.IndentBetweenItems = 10;
            this.tileControl3.ItemSize = 100;
            this.tileControl3.Location = new System.Drawing.Point(3, 18);
            this.tileControl3.MaxId = 13;
            this.tileControl3.Name = "tileControl3";
            this.tileControl3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileControl3.Padding = new System.Windows.Forms.Padding(0);
            this.tileControl3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tileControl3.ShowGroupText = true;
            this.tileControl3.Size = new System.Drawing.Size(256, 806);
            this.tileControl3.TabIndex = 1;
            this.tileControl3.Text = "tileControl3";
            this.tileControl3.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            // 
            // tileCatItemss
            // 
            this.tileCatItemss.Name = "tileCatItemss";
            // 
            // tileItem1
            // 
            tileItemElement5.Text = "tileItem1";
            this.tileItem1.Elements.Add(tileItemElement5);
            this.tileItem1.Id = 11;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem1.Name = "tileItem1";
            // 
            // tileCats
            // 
            this.tileCats.Items.Add(this.tileItem1);
            this.tileCats.Name = "tileCats";
            // 
            // tileCatItems
            // 
            this.tileCatItems.Name = "tileCatItems";
            // 
            // gridName
            // 
            this.gridName.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridName.AppearanceCell.Options.UseFont = true;
            this.gridName.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridName.AppearanceHeader.Options.UseFont = true;
            this.gridName.Caption = "Ürün Adı";
            this.gridName.Image = global::BarcoS.Properties.Resources.boorderitem_32x32;
            this.gridName.Name = "gridName";
            this.gridName.OptionsColumn.AllowEdit = false;
            this.gridName.OptionsColumn.ReadOnly = true;
            // 
            // frmSellScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1487, 827);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSellScreen";
            this.Text = "frmSellScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBarcodeSell)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TileControl tileControl2;
        private DevExpress.XtraEditors.TileGroup tileProccess;
        private DevExpress.XtraEditors.TileItem tileProducts;
        private DevExpress.XtraEditors.TileItem tileCategories;
        private DevExpress.XtraEditors.TileItem tileBrands;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBarcode;
        private DevExpress.XtraEditors.TileControl tileControl3;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private DevExpress.XtraEditors.TileGroup tileCats;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileCategoryItems;
        private DevExpress.XtraEditors.TileGroup tileCatItemss;
        private DevExpress.XtraEditors.TileGroup tileCatItems;
        private DevExpress.XtraGrid.GridControl gridSales;
        private DevExpress.XtraEditors.TileItem tileClose;
        private DevExpress.XtraGrid.Columns.GridColumn gridName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridBarcodeSell;
        private DevExpress.XtraGrid.Columns.GridColumn gridNamee;
        private DevExpress.XtraGrid.Columns.GridColumn gridCount;
        private DevExpress.XtraGrid.Columns.GridColumn gridTotal;


    }
}