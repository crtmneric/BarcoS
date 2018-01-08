namespace BarcoS.Classes.Views.MainForms
{
    partial class frmDayStatics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDayStatics));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.currentyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colauth_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colbakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileDetails = new DevExpress.XtraEditors.TileItem();
            this.tileDeleteUser = new DevExpress.XtraEditors.TileItem();
            this.tileClose = new DevExpress.XtraEditors.TileItem();
            this.tileReporting = new DevExpress.XtraEditors.TileItem();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1148, 695);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridControl1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1142, 674);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.currentyBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 18);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1136, 447);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            this.gridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyDown);
            // 
            // currentyBindingSource
            // 
            this.currentyBindingSource.DataSource = typeof(BarcoS.Models.Currenty);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colauth_name,
            this.colbakiye});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colauth_name
            // 
            this.colauth_name.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colauth_name.AppearanceCell.Options.UseFont = true;
            this.colauth_name.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colauth_name.AppearanceHeader.Options.UseFont = true;
            this.colauth_name.Caption = "Gün-Yetkili İsim";
            this.colauth_name.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colauth_name.FieldName = "auth_name";
            this.colauth_name.Image = global::BarcoS.Properties.Resources.bocustomer_32x32;
            this.colauth_name.Name = "colauth_name";
            this.colauth_name.OptionsColumn.AllowEdit = false;
            this.colauth_name.OptionsColumn.ReadOnly = true;
            this.colauth_name.Visible = true;
            this.colauth_name.VisibleIndex = 0;
            this.colauth_name.Width = 553;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colbakiye
            // 
            this.colbakiye.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colbakiye.AppearanceCell.Options.UseFont = true;
            this.colbakiye.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colbakiye.AppearanceHeader.Options.UseFont = true;
            this.colbakiye.Caption = "Gün Bakiyesi";
            this.colbakiye.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colbakiye.FieldName = "bakiye";
            this.colbakiye.Image = global::BarcoS.Properties.Resources.currency_32x32;
            this.colbakiye.Name = "colbakiye";
            this.colbakiye.OptionsColumn.AllowEdit = false;
            this.colbakiye.OptionsColumn.ReadOnly = true;
            this.colbakiye.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "bakiye", "TOPLAM={0:0.##}₺")});
            this.colbakiye.Visible = true;
            this.colbakiye.VisibleIndex = 1;
            this.colbakiye.Width = 565;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tileControl1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 465);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1136, 206);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // tileControl1
            // 
            this.tileControl1.AllowDrag = false;
            this.tileControl1.AllowDragTilesBetweenGroups = false;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.ItemSize = 160;
            this.tileControl1.Location = new System.Drawing.Point(3, 18);
            this.tileControl1.MaxId = 10;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(1130, 185);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileDetails);
            this.tileGroup2.Items.Add(this.tileDeleteUser);
            this.tileGroup2.Items.Add(this.tileClose);
            this.tileGroup2.Items.Add(this.tileReporting);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileDetails
            // 
            this.tileDetails.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkCyan;
            this.tileDetails.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.LightSeaGreen;
            this.tileDetails.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileDetails.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileDetails.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileDetails.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileDetails.AppearanceItem.Normal.Options.UseFont = true;
            this.tileDetails.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement1.Image = global::BarcoS.Properties.Resources.rsz_cariİcon;
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement1.Text = "Gün         Detayları Gör";
            this.tileDetails.Elements.Add(tileItemElement1);
            this.tileDetails.Id = 7;
            this.tileDetails.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileDetails.Name = "tileDetails";
            this.tileDetails.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileDetails_ItemClick);
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
            tileItemElement2.Image = global::BarcoS.Properties.Resources.rsz_1closeicon;
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement2.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement2.Text = "Gün Sil";
            this.tileDeleteUser.Elements.Add(tileItemElement2);
            this.tileDeleteUser.Id = 5;
            this.tileDeleteUser.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileDeleteUser.Name = "tileDeleteUser";
            this.tileDeleteUser.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileDeleteUser_ItemClick);
            // 
            // tileClose
            // 
            this.tileClose.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkCyan;
            this.tileClose.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.LightSeaGreen;
            this.tileClose.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileClose.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileClose.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileClose.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileClose.AppearanceItem.Normal.Options.UseFont = true;
            this.tileClose.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement3.Image = global::BarcoS.Properties.Resources.rsz_monitor_512;
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement3.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement3.Text = "Ana Ekrana Dön";
            this.tileClose.Elements.Add(tileItemElement3);
            this.tileClose.Id = 6;
            this.tileClose.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileClose.Name = "tileClose";
            this.tileClose.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileClose_ItemClick);
            // 
            // tileReporting
            // 
            this.tileReporting.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkCyan;
            this.tileReporting.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.LightSeaGreen;
            this.tileReporting.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileReporting.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileReporting.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileReporting.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileReporting.AppearanceItem.Normal.Options.UseFont = true;
            this.tileReporting.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement4.Image = global::BarcoS.Properties.Resources.rsz_reportingİcon;
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement4.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement4.Text = "Çıktı/Rapor Al";
            this.tileReporting.Elements.Add(tileItemElement4);
            this.tileReporting.Id = 8;
            this.tileReporting.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileReporting.Name = "tileReporting";
            this.tileReporting.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileReporting_ItemClick);
            // 
            // frmDayStatics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 695);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDayStatics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colauth_name;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colbakiye;
        private System.Windows.Forms.BindingSource currentyBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileDetails;
        private DevExpress.XtraEditors.TileItem tileDeleteUser;
        private DevExpress.XtraEditors.TileItem tileClose;
        private DevExpress.XtraEditors.TileItem tileReporting;
    }
}