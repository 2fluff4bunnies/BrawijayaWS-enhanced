namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class UsedGoodsListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsedGoodsListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtFilterSparepartName = new DevExpress.XtraEditors.TextEdit();
            this.lblFilterCompanyName = new DevExpress.XtraEditors.LabelControl();
            this.btnNewUsedGood = new DevExpress.XtraEditors.SimpleButton();
            this.gridUsedGood = new DevExpress.XtraGrid.GridControl();
            this.gvUsedGood = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Sparepart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsManageStok = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterSparepartName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsedGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsedGood)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.txtFilterSparepartName);
            this.gcFilter.Controls.Add(this.lblFilterCompanyName);
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(575, 62);
            this.gcFilter.TabIndex = 0;
            this.gcFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(511, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFilterSparepartName
            // 
            this.txtFilterSparepartName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterSparepartName.Location = new System.Drawing.Point(131, 29);
            this.txtFilterSparepartName.Name = "txtFilterSparepartName";
            this.txtFilterSparepartName.Size = new System.Drawing.Size(374, 20);
            this.txtFilterSparepartName.TabIndex = 2;
            // 
            // lblFilterCompanyName
            // 
            this.lblFilterCompanyName.Location = new System.Drawing.Point(14, 32);
            this.lblFilterCompanyName.Name = "lblFilterCompanyName";
            this.lblFilterCompanyName.Size = new System.Drawing.Size(78, 13);
            this.lblFilterCompanyName.TabIndex = 1;
            this.lblFilterCompanyName.Text = "Nama Sparepart";
            // 
            // btnNewUsedGood
            // 
            this.btnNewUsedGood.Image = ((System.Drawing.Image)(resources.GetObject("btnNewUsedGood.Image")));
            this.btnNewUsedGood.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewUsedGood.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewUsedGood.Location = new System.Drawing.Point(3, 71);
            this.btnNewUsedGood.Name = "btnNewUsedGood";
            this.btnNewUsedGood.Size = new System.Drawing.Size(164, 23);
            this.btnNewUsedGood.TabIndex = 3;
            this.btnNewUsedGood.Text = "Buat Barang Bekas Baru";
            this.btnNewUsedGood.Click += new System.EventHandler(this.btnNewUsedGood_Click);
            // 
            // gridUsedGood
            // 
            this.gridUsedGood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUsedGood.Location = new System.Drawing.Point(3, 100);
            this.gridUsedGood.MainView = this.gvUsedGood;
            this.gridUsedGood.Name = "gridUsedGood";
            this.gridUsedGood.Size = new System.Drawing.Size(575, 224);
            this.gridUsedGood.TabIndex = 4;
            this.gridUsedGood.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUsedGood});
            // 
            // gvUsedGood
            // 
            this.gvUsedGood.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Sparepart,
            this.Stock});
            this.gvUsedGood.GridControl = this.gridUsedGood;
            this.gvUsedGood.Name = "gvUsedGood";
            this.gvUsedGood.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvUsedGood.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvUsedGood.OptionsBehavior.AutoPopulateColumns = false;
            this.gvUsedGood.OptionsBehavior.Editable = false;
            this.gvUsedGood.OptionsBehavior.ReadOnly = true;
            this.gvUsedGood.OptionsCustomization.AllowColumnMoving = false;
            this.gvUsedGood.OptionsCustomization.AllowFilter = false;
            this.gvUsedGood.OptionsCustomization.AllowGroup = false;
            this.gvUsedGood.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvUsedGood.OptionsView.EnableAppearanceEvenRow = true;
            this.gvUsedGood.OptionsView.ShowGroupPanel = false;
            this.gvUsedGood.OptionsView.ShowViewCaption = true;
            this.gvUsedGood.ViewCaption = "Daftar Barang Bekas";
            // 
            // Sparepart
            // 
            this.Sparepart.Caption = "Sparepart";
            this.Sparepart.FieldName = "Sparepart.Name";
            this.Sparepart.Name = "Sparepart";
            this.Sparepart.Visible = true;
            this.Sparepart.VisibleIndex = 0;
            // 
            // Stock
            // 
            this.Stock.Caption = "Stock";
            this.Stock.FieldName = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.Visible = true;
            this.Stock.VisibleIndex = 1;
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditData,
            this.cmsManageStok,
            this.cmsDeleteData});
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(136, 70);
            // 
            // cmsEditData
            // 
            this.cmsEditData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.cmsEditData.Name = "cmsEditData";
            this.cmsEditData.Size = new System.Drawing.Size(135, 22);
            this.cmsEditData.Text = "Ubah Data";
            this.cmsEditData.Click += new System.EventHandler(this.cmsEditData_Click);
            // 
            // cmsManageStok
            // 
            this.cmsManageStok.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.cmsManageStok.Name = "cmsManageStok";
            this.cmsManageStok.Size = new System.Drawing.Size(135, 22);
            this.cmsManageStok.Text = "Atur Stok";
            this.cmsManageStok.Click += new System.EventHandler(this.cmsManageStock_Click);
            // 
            // cmsDeleteData
            // 
            this.cmsDeleteData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.cmsDeleteData.Name = "cmsDeleteData";
            this.cmsDeleteData.Size = new System.Drawing.Size(135, 22);
            this.cmsDeleteData.Text = "Hapus Data";
            this.cmsDeleteData.Click += new System.EventHandler(this.cmsDeleteData_Click);
            // 
            // UsedGoodsListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridUsedGood);
            this.Controls.Add(this.btnNewUsedGood);
            this.Controls.Add(this.gcFilter);
            this.Name = "UsedGoodsListControl";
            this.Size = new System.Drawing.Size(581, 327);
            this.Load += new System.EventHandler(this.UsedGoodsListControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterSparepartName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsedGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsedGood)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.LabelControl lblFilterCompanyName;
        private DevExpress.XtraEditors.TextEdit txtFilterSparepartName;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnNewUsedGood;
        private DevExpress.XtraGrid.GridControl gridUsedGood;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUsedGood;
        private DevExpress.XtraGrid.Columns.GridColumn Sparepart;
        private DevExpress.XtraGrid.Columns.GridColumn Stock;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private System.Windows.Forms.ToolStripMenuItem cmsManageStok;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
    }
}
