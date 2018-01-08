namespace BarcoS.Classes.Views.MainForms
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colauth_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colis_admin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstore_admin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnotification = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconfirmation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileAddUser = new DevExpress.XtraEditors.TileItem();
            this.tileEdit = new DevExpress.XtraEditors.TileItem();
            this.tileDeleteUser = new DevExpress.XtraEditors.TileItem();
            this.tileClose = new DevExpress.XtraEditors.TileItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1263, 597);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.userBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 18);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1257, 576);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            this.gridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyDown);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(BarcoS.Models.user);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colauth_name,
            this.colemail,
            this.colpassword,
            this.colphone,
            this.coladress,
            this.colstatus,
            this.colis_admin,
            this.colstore_admin,
            this.colnotification,
            this.colconfirmation,
            this.colrank});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
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
            this.colauth_name.Caption = "İsim";
            this.colauth_name.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colauth_name.FieldName = "auth_name";
            this.colauth_name.Image = global::BarcoS.Properties.Resources.bocustomer_32x32;
            this.colauth_name.Name = "colauth_name";
            this.colauth_name.OptionsColumn.AllowEdit = false;
            this.colauth_name.Visible = true;
            this.colauth_name.VisibleIndex = 0;
            this.colauth_name.Width = 112;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
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
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 1;
            this.colemail.Width = 112;
            // 
            // colpassword
            // 
            this.colpassword.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colpassword.AppearanceCell.Options.UseFont = true;
            this.colpassword.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colpassword.AppearanceHeader.Options.UseFont = true;
            this.colpassword.Caption = "Şifre";
            this.colpassword.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colpassword.FieldName = "password";
            this.colpassword.Image = global::BarcoS.Properties.Resources.find_32x32;
            this.colpassword.Name = "colpassword";
            this.colpassword.OptionsColumn.AllowEdit = false;
            this.colpassword.Visible = true;
            this.colpassword.VisibleIndex = 2;
            this.colpassword.Width = 112;
            // 
            // colphone
            // 
            this.colphone.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colphone.AppearanceCell.Options.UseFont = true;
            this.colphone.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colphone.AppearanceHeader.Options.UseFont = true;
            this.colphone.Caption = "Telefon";
            this.colphone.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colphone.FieldName = "phone";
            this.colphone.Image = global::BarcoS.Properties.Resources.bocontact_32x32;
            this.colphone.Name = "colphone";
            this.colphone.OptionsColumn.AllowEdit = false;
            this.colphone.Visible = true;
            this.colphone.VisibleIndex = 3;
            this.colphone.Width = 111;
            // 
            // coladress
            // 
            this.coladress.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.coladress.AppearanceCell.Options.UseFont = true;
            this.coladress.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.coladress.AppearanceHeader.Options.UseFont = true;
            this.coladress.Caption = "Adres";
            this.coladress.ColumnEdit = this.repositoryItemMemoEdit1;
            this.coladress.FieldName = "adress";
            this.coladress.Image = global::BarcoS.Properties.Resources.geopointmap_32x32;
            this.coladress.Name = "coladress";
            this.coladress.OptionsColumn.AllowEdit = false;
            this.coladress.Visible = true;
            this.coladress.VisibleIndex = 4;
            this.coladress.Width = 111;
            // 
            // colstatus
            // 
            this.colstatus.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colstatus.AppearanceCell.Options.UseFont = true;
            this.colstatus.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colstatus.AppearanceHeader.Options.UseFont = true;
            this.colstatus.Caption = "Statü";
            this.colstatus.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colstatus.FieldName = "status";
            this.colstatus.Image = global::BarcoS.Properties.Resources.apply_32x32;
            this.colstatus.Name = "colstatus";
            this.colstatus.OptionsColumn.AllowEdit = false;
            this.colstatus.Visible = true;
            this.colstatus.VisibleIndex = 5;
            this.colstatus.Width = 111;
            // 
            // colis_admin
            // 
            this.colis_admin.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colis_admin.AppearanceCell.Options.UseFont = true;
            this.colis_admin.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colis_admin.AppearanceHeader.Options.UseFont = true;
            this.colis_admin.Caption = "Admin";
            this.colis_admin.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colis_admin.FieldName = "is_admin";
            this.colis_admin.Image = global::BarcoS.Properties.Resources.boposition_32x32;
            this.colis_admin.Name = "colis_admin";
            this.colis_admin.OptionsColumn.AllowEdit = false;
            this.colis_admin.Visible = true;
            this.colis_admin.VisibleIndex = 6;
            this.colis_admin.Width = 111;
            // 
            // colstore_admin
            // 
            this.colstore_admin.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colstore_admin.AppearanceCell.Options.UseFont = true;
            this.colstore_admin.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colstore_admin.AppearanceHeader.Options.UseFont = true;
            this.colstore_admin.Caption = "Mağaza Admini";
            this.colstore_admin.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colstore_admin.FieldName = "store_admin";
            this.colstore_admin.Image = global::BarcoS.Properties.Resources.boposition_32x32;
            this.colstore_admin.Name = "colstore_admin";
            this.colstore_admin.OptionsColumn.AllowEdit = false;
            this.colstore_admin.Visible = true;
            this.colstore_admin.VisibleIndex = 7;
            this.colstore_admin.Width = 111;
            // 
            // colnotification
            // 
            this.colnotification.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colnotification.AppearanceCell.Options.UseFont = true;
            this.colnotification.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colnotification.AppearanceHeader.Options.UseFont = true;
            this.colnotification.Caption = "Bildirimler";
            this.colnotification.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colnotification.FieldName = "notification";
            this.colnotification.Image = global::BarcoS.Properties.Resources.boscheduler_32x32;
            this.colnotification.Name = "colnotification";
            this.colnotification.OptionsColumn.AllowEdit = false;
            this.colnotification.Visible = true;
            this.colnotification.VisibleIndex = 8;
            this.colnotification.Width = 111;
            // 
            // colconfirmation
            // 
            this.colconfirmation.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colconfirmation.AppearanceCell.Options.UseFont = true;
            this.colconfirmation.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colconfirmation.AppearanceHeader.Options.UseFont = true;
            this.colconfirmation.Caption = "Onaylama";
            this.colconfirmation.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colconfirmation.FieldName = "confirmation";
            this.colconfirmation.Image = global::BarcoS.Properties.Resources.apply_32x32;
            this.colconfirmation.Name = "colconfirmation";
            this.colconfirmation.OptionsColumn.AllowEdit = false;
            this.colconfirmation.Visible = true;
            this.colconfirmation.VisibleIndex = 9;
            this.colconfirmation.Width = 111;
            // 
            // colrank
            // 
            this.colrank.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colrank.AppearanceCell.Options.UseFont = true;
            this.colrank.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colrank.AppearanceHeader.Options.UseFont = true;
            this.colrank.Caption = "Seviye";
            this.colrank.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colrank.FieldName = "rank";
            this.colrank.Image = global::BarcoS.Properties.Resources.usergroup_32x32;
            this.colrank.Name = "colrank";
            this.colrank.OptionsColumn.AllowEdit = false;
            this.colrank.Visible = true;
            this.colrank.VisibleIndex = 10;
            this.colrank.Width = 126;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tileControl1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 597);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1263, 201);
            this.groupBox2.TabIndex = 1;
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
            this.tileControl1.MaxId = 7;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(1257, 180);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileAddUser);
            this.tileGroup2.Items.Add(this.tileEdit);
            this.tileGroup2.Items.Add(this.tileDeleteUser);
            this.tileGroup2.Items.Add(this.tileClose);
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
            tileItemElement1.Text = "Yeni Kullanıcı";
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
            tileItemElement2.Text = "Kullanıcıyı Düzenle";
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
            tileItemElement3.Text = "Kullanıcıyı Sil";
            this.tileDeleteUser.Elements.Add(tileItemElement3);
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
            tileItemElement4.Image = global::BarcoS.Properties.Resources.rsz_monitor_512;
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement4.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement4.Text = "Ana Ekrana Dön";
            this.tileClose.Elements.Add(tileItemElement4);
            this.tileClose.Id = 6;
            this.tileClose.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileClose.Name = "tileClose";
            this.tileClose.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileClose_ItemClick);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1263, 798);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colauth_name;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colpassword;
        private DevExpress.XtraGrid.Columns.GridColumn colphone;
        private DevExpress.XtraGrid.Columns.GridColumn coladress;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colis_admin;
        private DevExpress.XtraGrid.Columns.GridColumn colstore_admin;
        private DevExpress.XtraGrid.Columns.GridColumn colnotification;
        private DevExpress.XtraGrid.Columns.GridColumn colconfirmation;
        private DevExpress.XtraGrid.Columns.GridColumn colrank;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileAddUser;
        private DevExpress.XtraEditors.TileItem tileEdit;
        private DevExpress.XtraEditors.TileItem tileDeleteUser;
        private DevExpress.XtraEditors.TileItem tileClose;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
    }
}