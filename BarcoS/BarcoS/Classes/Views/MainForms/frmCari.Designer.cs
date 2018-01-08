namespace BarcoS.Classes.Views.MainForms
{
    partial class frmCari
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
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCari));
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileAddUser = new DevExpress.XtraEditors.TileItem();
            this.tileEdit = new DevExpress.XtraEditors.TileItem();
            this.tileDetails = new DevExpress.XtraEditors.TileItem();
            this.tileDeleteUser = new DevExpress.XtraEditors.TileItem();
            this.tileClose = new DevExpress.XtraEditors.TileItem();
            this.tileReporting = new DevExpress.XtraEditors.TileItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.currentyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.coladress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltax_office = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltax_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurrent_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpoint_card_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colauth_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colauth_gsm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrisk_limit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsms_notification = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tileBakiye = new DevExpress.XtraEditors.TileItem();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tileControl1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 529);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1370, 206);
            this.groupBox2.TabIndex = 2;
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
            this.tileControl1.Size = new System.Drawing.Size(1364, 185);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileAddUser);
            this.tileGroup2.Items.Add(this.tileEdit);
            this.tileGroup2.Items.Add(this.tileDetails);
            this.tileGroup2.Items.Add(this.tileDeleteUser);
            this.tileGroup2.Items.Add(this.tileClose);
            this.tileGroup2.Items.Add(this.tileReporting);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileAddUser
            // 
            this.tileAddUser.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkCyan;
            this.tileAddUser.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.LightSeaGreen;
            this.tileAddUser.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileAddUser.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileAddUser.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileAddUser.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileAddUser.AppearanceItem.Normal.Options.UseFont = true;
            this.tileAddUser.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement1.Image = global::BarcoS.Properties.Resources.rsz_kullanıcıİcon;
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement1.Text = "Yeni Cari Hesap";
            this.tileAddUser.Elements.Add(tileItemElement1);
            this.tileAddUser.Id = 3;
            this.tileAddUser.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileAddUser.Name = "tileAddUser";
            this.tileAddUser.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileAddUser_ItemClick);
            // 
            // tileEdit
            // 
            this.tileEdit.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkCyan;
            this.tileEdit.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.LightSeaGreen;
            this.tileEdit.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileEdit.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileEdit.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileEdit.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileEdit.AppearanceItem.Normal.Options.UseFont = true;
            this.tileEdit.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement2.Image = global::BarcoS.Properties.Resources.rsz_katologİcon;
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement2.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement2.Text = "Cari Düzenle";
            this.tileEdit.Elements.Add(tileItemElement2);
            this.tileEdit.Id = 4;
            this.tileEdit.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileEdit.Name = "tileEdit";
            this.tileEdit.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileEdit_ItemClick);
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
            tileItemElement3.Image = global::BarcoS.Properties.Resources.rsz_cariİcon;
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement3.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement3.Text = "Cari          Detayları Gör";
            this.tileDetails.Elements.Add(tileItemElement3);
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
            tileItemElement4.Image = global::BarcoS.Properties.Resources.rsz_1closeicon;
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement4.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement4.Text = "Cari Sil";
            this.tileDeleteUser.Elements.Add(tileItemElement4);
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
            tileItemElement5.Image = global::BarcoS.Properties.Resources.rsz_monitor_512;
            tileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement5.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement5.Text = "Ana Ekrana Dön";
            this.tileClose.Elements.Add(tileItemElement5);
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
            tileItemElement6.Image = global::BarcoS.Properties.Resources.rsz_reportingİcon;
            tileItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement6.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement6.Text = "Çıktı/Rapor Al";
            this.tileReporting.Elements.Add(tileItemElement6);
            this.tileReporting.Id = 8;
            this.tileReporting.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileReporting.Name = "tileReporting";
            this.tileReporting.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileReporting_ItemClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1370, 529);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
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
            this.gridControl1.Size = new System.Drawing.Size(1364, 508);
            this.gridControl1.TabIndex = 0;
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
            this.colemail,
            this.coladress,
            this.coltax_office,
            this.coltax_number,
            this.colcurrent_type,
            this.colpoint_card_number,
            this.colauth_name,
            this.colauth_gsm,
            this.colrisk_limit,
            this.colsms_notification,
            this.colbakiye});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colemail
            // 
            this.colemail.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colemail.AppearanceCell.Options.UseFont = true;
            this.colemail.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colemail.AppearanceHeader.Options.UseFont = true;
            this.colemail.Caption = "Email";
            this.colemail.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colemail.FieldName = "email";
            this.colemail.Image = global::BarcoS.Properties.Resources.mail_32x32;
            this.colemail.Name = "colemail";
            this.colemail.OptionsColumn.AllowEdit = false;
            this.colemail.OptionsColumn.ReadOnly = true;
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 0;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // coladress
            // 
            this.coladress.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.coladress.AppearanceCell.Options.UseFont = true;
            this.coladress.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.coladress.AppearanceHeader.Options.UseFont = true;
            this.coladress.Caption = "Adresi";
            this.coladress.ColumnEdit = this.repositoryItemMemoEdit1;
            this.coladress.FieldName = "adress";
            this.coladress.Image = global::BarcoS.Properties.Resources.geopointmap_32x32;
            this.coladress.Name = "coladress";
            this.coladress.OptionsColumn.AllowEdit = false;
            this.coladress.OptionsColumn.ReadOnly = true;
            this.coladress.Visible = true;
            this.coladress.VisibleIndex = 1;
            // 
            // coltax_office
            // 
            this.coltax_office.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.coltax_office.AppearanceCell.Options.UseFont = true;
            this.coltax_office.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.coltax_office.AppearanceHeader.Options.UseFont = true;
            this.coltax_office.Caption = "Vergi Dairesi";
            this.coltax_office.ColumnEdit = this.repositoryItemMemoEdit1;
            this.coltax_office.FieldName = "tax_office";
            this.coltax_office.Image = global::BarcoS.Properties.Resources.bocontact2_32x32;
            this.coltax_office.Name = "coltax_office";
            this.coltax_office.OptionsColumn.AllowEdit = false;
            this.coltax_office.OptionsColumn.ReadOnly = true;
            this.coltax_office.Visible = true;
            this.coltax_office.VisibleIndex = 2;
            // 
            // coltax_number
            // 
            this.coltax_number.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.coltax_number.AppearanceCell.Options.UseFont = true;
            this.coltax_number.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.coltax_number.AppearanceHeader.Options.UseFont = true;
            this.coltax_number.Caption = "Vergi Numarası";
            this.coltax_number.ColumnEdit = this.repositoryItemMemoEdit1;
            this.coltax_number.FieldName = "tax_number";
            this.coltax_number.Image = global::BarcoS.Properties.Resources.barcode2_32x32;
            this.coltax_number.Name = "coltax_number";
            this.coltax_number.OptionsColumn.AllowEdit = false;
            this.coltax_number.OptionsColumn.ReadOnly = true;
            this.coltax_number.Visible = true;
            this.coltax_number.VisibleIndex = 3;
            // 
            // colcurrent_type
            // 
            this.colcurrent_type.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colcurrent_type.AppearanceCell.Options.UseFont = true;
            this.colcurrent_type.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colcurrent_type.AppearanceHeader.Options.UseFont = true;
            this.colcurrent_type.Caption = "Cari Tipi";
            this.colcurrent_type.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colcurrent_type.FieldName = "current_type";
            this.colcurrent_type.Image = global::BarcoS.Properties.Resources.usergroup_32x32;
            this.colcurrent_type.Name = "colcurrent_type";
            this.colcurrent_type.OptionsColumn.AllowEdit = false;
            this.colcurrent_type.OptionsColumn.ReadOnly = true;
            this.colcurrent_type.Visible = true;
            this.colcurrent_type.VisibleIndex = 4;
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
            this.colpoint_card_number.VisibleIndex = 5;
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
            this.colauth_name.VisibleIndex = 6;
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
            this.colauth_gsm.VisibleIndex = 7;
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
            this.colrisk_limit.VisibleIndex = 8;
            // 
            // colsms_notification
            // 
            this.colsms_notification.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colsms_notification.AppearanceCell.Options.UseFont = true;
            this.colsms_notification.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colsms_notification.AppearanceHeader.Options.UseFont = true;
            this.colsms_notification.Caption = "Sms Bildirimi";
            this.colsms_notification.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colsms_notification.FieldName = "sms_notification";
            this.colsms_notification.Image = global::BarcoS.Properties.Resources.mail_32x32;
            this.colsms_notification.Name = "colsms_notification";
            this.colsms_notification.OptionsColumn.AllowEdit = false;
            this.colsms_notification.OptionsColumn.ReadOnly = true;
            this.colsms_notification.Visible = true;
            this.colsms_notification.VisibleIndex = 9;
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
            this.colbakiye.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "bakiye", "TOPLAM={0:0.##}₺")});
            this.colbakiye.Visible = true;
            this.colbakiye.VisibleIndex = 10;
            // 
            // tileBakiye
            // 
            this.tileBakiye.AppearanceItem.Normal.BackColor = System.Drawing.Color.Turquoise;
            this.tileBakiye.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Black;
            this.tileBakiye.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileBakiye.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileBakiye.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBakiye.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileBakiye.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement7.Image = global::BarcoS.Properties.Resources.rsz_refreshicon;
            tileItemElement7.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement7.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement7.Text = "Bakiye Senkronize Et";
            this.tileBakiye.Elements.Add(tileItemElement7);
            this.tileBakiye.Id = 9;
            this.tileBakiye.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileBakiye.Name = "tileBakiye";
            // 
            // frmCari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 735);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCari";
            this.Text = "frmCari";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileAddUser;
        private DevExpress.XtraEditors.TileItem tileEdit;
        private DevExpress.XtraEditors.TileItem tileDeleteUser;
        private DevExpress.XtraEditors.TileItem tileClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource currentyBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn coladress;
        private DevExpress.XtraGrid.Columns.GridColumn coltax_office;
        private DevExpress.XtraGrid.Columns.GridColumn coltax_number;
        private DevExpress.XtraGrid.Columns.GridColumn colcurrent_type;
        private DevExpress.XtraGrid.Columns.GridColumn colpoint_card_number;
        private DevExpress.XtraGrid.Columns.GridColumn colauth_name;
        private DevExpress.XtraGrid.Columns.GridColumn colauth_gsm;
        private DevExpress.XtraGrid.Columns.GridColumn colrisk_limit;
        private DevExpress.XtraGrid.Columns.GridColumn colsms_notification;
        private DevExpress.XtraGrid.Columns.GridColumn colbakiye;
        private DevExpress.XtraEditors.TileItem tileDetails;
        private DevExpress.XtraEditors.TileItem tileReporting;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.TileItem tileBakiye;
    }
}