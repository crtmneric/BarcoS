namespace BarcoS.Classes.Views.MainForms
{
    partial class frmCariDetail
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariDetail));
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tileControl2 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileAddUser = new DevExpress.XtraEditors.TileItem();
            this.tileEdit = new DevExpress.XtraEditors.TileItem();
            this.tileDeleteUser = new DevExpress.XtraEditors.TileItem();
            this.tileClose = new DevExpress.XtraEditors.TileItem();
            this.tileReporting = new DevExpress.XtraEditors.TileItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.currentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltext = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colreg_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexpiry_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAuth = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(240, 150);
            this.tileControl1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tileControl2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 552);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1360, 190);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // tileControl2
            // 
            this.tileControl2.AllowDrag = false;
            this.tileControl2.AllowDragTilesBetweenGroups = false;
            this.tileControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl2.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl2.Groups.Add(this.tileGroup2);
            this.tileControl2.ItemSize = 160;
            this.tileControl2.Location = new System.Drawing.Point(3, 18);
            this.tileControl2.MaxId = 10;
            this.tileControl2.Name = "tileControl2";
            this.tileControl2.Size = new System.Drawing.Size(1354, 169);
            this.tileControl2.TabIndex = 0;
            this.tileControl2.Text = "tileControl2";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileAddUser);
            this.tileGroup2.Items.Add(this.tileEdit);
            this.tileGroup2.Items.Add(this.tileDeleteUser);
            this.tileGroup2.Items.Add(this.tileClose);
            this.tileGroup2.Items.Add(this.tileReporting);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileAddUser
            // 
            this.tileAddUser.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkCyan;
            this.tileAddUser.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Turquoise;
            this.tileAddUser.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileAddUser.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileAddUser.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileAddUser.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileAddUser.AppearanceItem.Normal.Options.UseFont = true;
            this.tileAddUser.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement1.Image = global::BarcoS.Properties.Resources.rsz_cariİcon;
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement1.Text = "Borçlandır     Alacaklandır";
            this.tileAddUser.Elements.Add(tileItemElement1);
            this.tileAddUser.Id = 3;
            this.tileAddUser.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileAddUser.Name = "tileAddUser";
            this.tileAddUser.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileAddUser_ItemClick);
            // 
            // tileEdit
            // 
            this.tileEdit.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkCyan;
            this.tileEdit.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Turquoise;
            this.tileEdit.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileEdit.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileEdit.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileEdit.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileEdit.AppearanceItem.Normal.Options.UseFont = true;
            this.tileEdit.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement2.Image = global::BarcoS.Properties.Resources.rsz_katologİcon;
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement2.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement2.Text = "Detay Düzenle";
            this.tileEdit.Elements.Add(tileItemElement2);
            this.tileEdit.Id = 4;
            this.tileEdit.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileEdit.Name = "tileEdit";
            this.tileEdit.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileEdit_ItemClick);
            // 
            // tileDeleteUser
            // 
            this.tileDeleteUser.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkRed;
            this.tileDeleteUser.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Firebrick;
            this.tileDeleteUser.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileDeleteUser.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileDeleteUser.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileDeleteUser.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileDeleteUser.AppearanceItem.Normal.Options.UseFont = true;
            this.tileDeleteUser.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement3.Image = global::BarcoS.Properties.Resources.rsz_1closeicon;
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement3.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement3.Text = "Detay Sil";
            this.tileDeleteUser.Elements.Add(tileItemElement3);
            this.tileDeleteUser.Id = 5;
            this.tileDeleteUser.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileDeleteUser.Name = "tileDeleteUser";
            this.tileDeleteUser.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileDeleteUser_ItemClick);
            // 
            // tileClose
            // 
            this.tileClose.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkCyan;
            this.tileClose.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Turquoise;
            this.tileClose.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileClose.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileClose.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileClose.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileClose.AppearanceItem.Normal.Options.UseFont = true;
            this.tileClose.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement4.Image = global::BarcoS.Properties.Resources.rsz_monitor_512;
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement4.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement4.Text = "Geri Dön";
            this.tileClose.Elements.Add(tileItemElement4);
            this.tileClose.Id = 6;
            this.tileClose.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileClose.Name = "tileClose";
            this.tileClose.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileClose_ItemClick);
            // 
            // tileReporting
            // 
            this.tileReporting.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkCyan;
            this.tileReporting.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Turquoise;
            this.tileReporting.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileReporting.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileReporting.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileReporting.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileReporting.AppearanceItem.Normal.Options.UseFont = true;
            this.tileReporting.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement5.Image = global::BarcoS.Properties.Resources.rsz_reportingİcon;
            tileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement5.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement5.Text = "Çıktı/Rapor Al";
            this.tileReporting.Elements.Add(tileItemElement5);
            this.tileReporting.Id = 9;
            this.tileReporting.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileReporting.Name = "tileReporting";
            this.tileReporting.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileReporting_ItemClick);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.currentDetailsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1360, 495);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            this.gridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyDown);
            // 
            // currentDetailsBindingSource
            // 
            this.currentDetailsBindingSource.DataSource = typeof(BarcoS.Models.Current_Details);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltext,
            this.colreg_date,
            this.colexpiry_date,
            this.colprice});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // coltext
            // 
            this.coltext.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.coltext.AppearanceCell.Options.UseFont = true;
            this.coltext.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.coltext.AppearanceHeader.Options.UseFont = true;
            this.coltext.Caption = "Açıklama";
            this.coltext.ColumnEdit = this.repositoryItemMemoEdit1;
            this.coltext.FieldName = "text";
            this.coltext.Image = global::BarcoS.Properties.Resources.notes_32x32;
            this.coltext.Name = "coltext";
            this.coltext.OptionsColumn.AllowEdit = false;
            this.coltext.OptionsColumn.ReadOnly = true;
            this.coltext.Visible = true;
            this.coltext.VisibleIndex = 0;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colreg_date
            // 
            this.colreg_date.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colreg_date.AppearanceCell.Options.UseFont = true;
            this.colreg_date.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colreg_date.AppearanceHeader.Options.UseFont = true;
            this.colreg_date.Caption = "İşlem Tarihi";
            this.colreg_date.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colreg_date.FieldName = "reg_date";
            this.colreg_date.Image = global::BarcoS.Properties.Resources.adateoccurring_32x32;
            this.colreg_date.Name = "colreg_date";
            this.colreg_date.OptionsColumn.AllowEdit = false;
            this.colreg_date.OptionsColumn.ReadOnly = true;
            this.colreg_date.Visible = true;
            this.colreg_date.VisibleIndex = 1;
            // 
            // colexpiry_date
            // 
            this.colexpiry_date.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colexpiry_date.AppearanceCell.Options.UseFont = true;
            this.colexpiry_date.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colexpiry_date.AppearanceHeader.Options.UseFont = true;
            this.colexpiry_date.Caption = "Vade Tarihi";
            this.colexpiry_date.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colexpiry_date.FieldName = "expiry_date";
            this.colexpiry_date.Image = ((System.Drawing.Image)(resources.GetObject("colexpiry_date.Image")));
            this.colexpiry_date.Name = "colexpiry_date";
            this.colexpiry_date.OptionsColumn.AllowEdit = false;
            this.colexpiry_date.OptionsColumn.ReadOnly = true;
            this.colexpiry_date.Visible = true;
            this.colexpiry_date.VisibleIndex = 2;
            // 
            // colprice
            // 
            this.colprice.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colprice.AppearanceCell.Options.UseFont = true;
            this.colprice.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colprice.AppearanceHeader.Options.UseFont = true;
            this.colprice.Caption = "Tutar";
            this.colprice.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colprice.FieldName = "price";
            this.colprice.Image = global::BarcoS.Properties.Resources.financial_32x32;
            this.colprice.Name = "colprice";
            this.colprice.OptionsColumn.AllowEdit = false;
            this.colprice.OptionsColumn.ReadOnly = true;
            this.colprice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "price", "TOPLAM={0:0.##}₺")});
            this.colprice.Visible = true;
            this.colprice.VisibleIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblAuth);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 495);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1360, 57);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhone.Location = new System.Drawing.Point(839, 18);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(78, 28);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Telefon:";
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuth.Location = new System.Drawing.Point(31, 18);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(159, 28);
            this.lblAuth.TabIndex = 0;
            this.lblAuth.Text = "Yetkili Kişi-Firma:";
            // 
            // frmCariDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 742);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCariDetail";
            this.Text = "frmCariDetail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TileControl tileControl2;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileAddUser;
        private DevExpress.XtraEditors.TileItem tileEdit;
        private DevExpress.XtraEditors.TileItem tileDeleteUser;
        private DevExpress.XtraEditors.TileItem tileClose;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource currentDetailsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coltext;
        private DevExpress.XtraGrid.Columns.GridColumn colreg_date;
        private DevExpress.XtraGrid.Columns.GridColumn colexpiry_date;
        private DevExpress.XtraGrid.Columns.GridColumn colprice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAuth;
        private DevExpress.XtraEditors.TileItem tileReporting;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
    }
}