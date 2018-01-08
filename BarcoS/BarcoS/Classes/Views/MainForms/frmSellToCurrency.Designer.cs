namespace BarcoS.Classes.Views.MainForms
{
    partial class frmSellToCurrency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSellToCurrency));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.currentyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpoint_card_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colauth_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colauth_gsm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrisk_limit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tileControl2 = new DevExpress.XtraEditors.TileControl();
            this.tileProccess = new DevExpress.XtraEditors.TileGroup();
            this.tileCategories = new DevExpress.XtraEditors.TileItem();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
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
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1219, 707);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridControl1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(249, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(967, 686);
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
            this.gridControl1.Size = new System.Drawing.Size(961, 665);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.colpoint_card_number,
            this.colauth_name,
            this.colauth_gsm,
            this.colrisk_limit,
            this.colbakiye});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colpoint_card_number
            // 
            this.colpoint_card_number.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colpoint_card_number.AppearanceCell.Options.UseFont = true;
            this.colpoint_card_number.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colpoint_card_number.AppearanceHeader.Options.UseFont = true;
            this.colpoint_card_number.Caption = "Müşteri Puan Kartı";
            this.colpoint_card_number.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colpoint_card_number.FieldName = "point_card_number";
            this.colpoint_card_number.Image = global::BarcoS.Properties.Resources.contact_32x32;
            this.colpoint_card_number.Name = "colpoint_card_number";
            this.colpoint_card_number.OptionsColumn.AllowEdit = false;
            this.colpoint_card_number.OptionsColumn.ReadOnly = true;
            this.colpoint_card_number.Visible = true;
            this.colpoint_card_number.VisibleIndex = 0;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colauth_name
            // 
            this.colauth_name.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colauth_name.AppearanceCell.Options.UseFont = true;
            this.colauth_name.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colauth_name.AppearanceHeader.Options.UseFont = true;
            this.colauth_name.Caption = "Yetkili İsmi-Firma";
            this.colauth_name.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colauth_name.FieldName = "auth_name";
            this.colauth_name.Image = global::BarcoS.Properties.Resources.bocustomer_32x32;
            this.colauth_name.Name = "colauth_name";
            this.colauth_name.OptionsColumn.AllowEdit = false;
            this.colauth_name.OptionsColumn.ReadOnly = true;
            this.colauth_name.Visible = true;
            this.colauth_name.VisibleIndex = 1;
            this.colauth_name.Width = 173;
            // 
            // colauth_gsm
            // 
            this.colauth_gsm.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colauth_gsm.AppearanceCell.Options.UseFont = true;
            this.colauth_gsm.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colauth_gsm.AppearanceHeader.Options.UseFont = true;
            this.colauth_gsm.Caption = "Yetkili Telefon";
            this.colauth_gsm.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colauth_gsm.FieldName = "auth_gsm";
            this.colauth_gsm.Image = global::BarcoS.Properties.Resources.bocontact_32x32;
            this.colauth_gsm.Name = "colauth_gsm";
            this.colauth_gsm.OptionsColumn.AllowEdit = false;
            this.colauth_gsm.OptionsColumn.ReadOnly = true;
            this.colauth_gsm.Visible = true;
            this.colauth_gsm.VisibleIndex = 2;
            // 
            // colrisk_limit
            // 
            this.colrisk_limit.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colrisk_limit.AppearanceCell.Options.UseFont = true;
            this.colrisk_limit.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colrisk_limit.AppearanceHeader.Options.UseFont = true;
            this.colrisk_limit.Caption = "Risk Limiti";
            this.colrisk_limit.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colrisk_limit.FieldName = "risk_limit";
            this.colrisk_limit.Image = ((System.Drawing.Image)(resources.GetObject("colrisk_limit.Image")));
            this.colrisk_limit.Name = "colrisk_limit";
            this.colrisk_limit.OptionsColumn.AllowEdit = false;
            this.colrisk_limit.OptionsColumn.ReadOnly = true;
            this.colrisk_limit.Visible = true;
            this.colrisk_limit.VisibleIndex = 3;
            // 
            // colbakiye
            // 
            this.colbakiye.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colbakiye.AppearanceCell.Options.UseFont = true;
            this.colbakiye.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colbakiye.AppearanceHeader.Options.UseFont = true;
            this.colbakiye.Caption = "Bakiye";
            this.colbakiye.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colbakiye.FieldName = "bakiye";
            this.colbakiye.Image = global::BarcoS.Properties.Resources.currency_32x32;
            this.colbakiye.Name = "colbakiye";
            this.colbakiye.OptionsColumn.AllowEdit = false;
            this.colbakiye.OptionsColumn.ReadOnly = true;
            this.colbakiye.Visible = true;
            this.colbakiye.VisibleIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.tileControl2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 686);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::BarcoS.Properties.Resources.cancel_32x32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 69);
            this.button1.TabIndex = 34;
            this.button1.Text = "IPTAL ET";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkCyan;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::BarcoS.Properties.Resources.apply_32x32;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(3, 614);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(240, 69);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "TAMAMLA";
            this.btnExit.UseVisualStyleBackColor = false;
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
            this.tileControl2.MaxId = 12;
            this.tileControl2.Name = "tileControl2";
            this.tileControl2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileControl2.Padding = new System.Windows.Forms.Padding(0);
            this.tileControl2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tileControl2.ShowGroupText = true;
            this.tileControl2.Size = new System.Drawing.Size(240, 665);
            this.tileControl2.TabIndex = 1;
            this.tileControl2.Text = "tileControl2";
            this.tileControl2.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            // 
            // tileProccess
            // 
            this.tileProccess.Items.Add(this.tileCategories);
            this.tileProccess.Items.Add(this.tileItem1);
            this.tileProccess.Name = "tileProccess";
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
            tileItemElement1.Image = global::BarcoS.Properties.Resources.send_32x32;
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement1.Text = "CARİ HESABA EKLE";
            this.tileCategories.Elements.Add(tileItemElement1);
            this.tileCategories.Id = 3;
            this.tileCategories.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileCategories.Name = "tileCategories";
            this.tileCategories.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileCategories_ItemClick);
            // 
            // tileItem1
            // 
            this.tileItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkCyan;
            this.tileItem1.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.LightSeaGreen;
            this.tileItem1.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileItem1.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem1.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem1.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement2.Image = global::BarcoS.Properties.Resources.customer_32x32;
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement2.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement2.Text = "Yeni Cari Hesap";
            this.tileItem1.Elements.Add(tileItemElement2);
            this.tileItem1.Id = 11;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem1.Name = "tileItem1";
            this.tileItem1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem1_ItemClick);
            // 
            // frmSellToCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1219, 707);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSellToCurrency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colpoint_card_number;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colauth_name;
        private DevExpress.XtraGrid.Columns.GridColumn colauth_gsm;
        private DevExpress.XtraGrid.Columns.GridColumn colrisk_limit;
        private DevExpress.XtraGrid.Columns.GridColumn colbakiye;
        private System.Windows.Forms.BindingSource currentyBindingSource;
        private DevExpress.XtraEditors.TileControl tileControl2;
        private DevExpress.XtraEditors.TileGroup tileProccess;
        private DevExpress.XtraEditors.TileItem tileCategories;
        private System.Windows.Forms.Button btnExit;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private System.Windows.Forms.Button button1;
    }
}