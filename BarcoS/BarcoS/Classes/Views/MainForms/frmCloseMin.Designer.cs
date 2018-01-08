namespace BarcoS.Classes.Views.MainForms
{
    partial class frmCloseMin
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
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCloseMin));
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileClose = new DevExpress.XtraEditors.TileItem();
            this.tileMinimize = new DevExpress.XtraEditors.TileItem();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.AllowDrag = false;
            this.tileControl1.AllowDragTilesBetweenGroups = false;
            this.tileControl1.BackColor = System.Drawing.Color.White;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.ItemSize = 160;
            this.tileControl1.Location = new System.Drawing.Point(3, 18);
            this.tileControl1.MaxId = 4;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(578, 630);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileClose);
            this.tileGroup2.Items.Add(this.tileMinimize);
            this.tileGroup2.Items.Add(this.tileItem1);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileClose
            // 
            this.tileClose.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkCyan;
            this.tileClose.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Turquoise;
            this.tileClose.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileClose.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileClose.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileClose.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileClose.AppearanceItem.Normal.Options.UseFont = true;
            this.tileClose.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement4.Image = global::BarcoS.Properties.Resources.cancel_32x32;
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement4.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement4.ImageToTextIndent = 30;
            tileItemElement4.Text = "KAPAT";
            this.tileClose.Elements.Add(tileItemElement4);
            this.tileClose.Id = 1;
            this.tileClose.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileClose.Name = "tileClose";
            this.tileClose.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileClose_ItemClick);
            // 
            // tileMinimize
            // 
            this.tileMinimize.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkCyan;
            this.tileMinimize.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Turquoise;
            this.tileMinimize.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileMinimize.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileMinimize.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileMinimize.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileMinimize.AppearanceItem.Normal.Options.UseFont = true;
            this.tileMinimize.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement5.Image = global::BarcoS.Properties.Resources.remove_32x32;
            tileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement5.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement5.ImageToTextIndent = 30;
            tileItemElement5.Text = "SİMGE DURUMUNA KÜÇÜLT";
            this.tileMinimize.Elements.Add(tileItemElement5);
            this.tileMinimize.Id = 2;
            this.tileMinimize.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileMinimize.Name = "tileMinimize";
            this.tileMinimize.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileMinimize_ItemClick);
            // 
            // tileItem1
            // 
            this.tileItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkCyan;
            this.tileItem1.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Turquoise;
            this.tileItem1.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileItem1.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileItem1.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem1.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem1.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem1.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement6.Image = global::BarcoS.Properties.Resources.backward_32x32;
            tileItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement6.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement6.Text = "VAZGEÇ";
            this.tileItem1.Elements.Add(tileItemElement6);
            this.tileItem1.Id = 3;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem1.Name = "tileItem1";
            this.tileItem1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem1_ItemClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tileControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 651);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // frmCloseMin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 651);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCloseMin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCloseMin";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileClose;
        private DevExpress.XtraEditors.TileItem tileMinimize;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TileItem tileItem1;
    }
}