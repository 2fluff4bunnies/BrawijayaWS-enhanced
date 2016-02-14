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
            this.btnNewUsedGoods = new DevExpress.XtraEditors.SimpleButton();
            this.gridUsedGoods = new DevExpress.XtraGrid.GridControl();
            this.gvUsedGoods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Sparepart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsUpdateStok = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterSparepartName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsedGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsedGoods)).BeginInit();
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
            // btnNewUsedGoods
            // 
            this.btnNewUsedGoods.Image = ((System.Drawing.Image)(resources.GetObject("btnNewUsedGoods.Image")));
            this.btnNewUsedGoods.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewUsedGoods.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewUsedGoods.Location = new System.Drawing.Point(3, 71);
            this.btnNewUsedGoods.Name = "btnNewUsedGoods";
            this.btnNewUsedGoods.Size = new System.Drawing.Size(164, 23);
            this.btnNewUsedGoods.TabIndex = 3;
            this.btnNewUsedGoods.Text = "Buat Barang Bekas Baru";
            // 
            // gridUsedGoods
            // 
            this.gridUsedGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUsedGoods.Location = new System.Drawing.Point(3, 100);
            this.gridUsedGoods.MainView = this.gvUsedGoods;
            this.gridUsedGoods.Name = "gridUsedGoods";
            this.gridUsedGoods.Size = new System.Drawing.Size(575, 224);
            this.gridUsedGoods.TabIndex = 4;
            this.gridUsedGoods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUsedGoods});
            // 
            // gvUsedGoods
            // 
            this.gvUsedGoods.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Sparepart,
            this.Stock});
            this.gvUsedGoods.GridControl = this.gridUsedGoods;
            this.gvUsedGoods.Name = "gvUsedGoods";
            this.gvUsedGoods.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvUsedGoods.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvUsedGoods.OptionsBehavior.AutoPopulateColumns = false;
            this.gvUsedGoods.OptionsBehavior.Editable = false;
            this.gvUsedGoods.OptionsBehavior.ReadOnly = true;
            this.gvUsedGoods.OptionsCustomization.AllowColumnMoving = false;
            this.gvUsedGoods.OptionsCustomization.AllowFilter = false;
            this.gvUsedGoods.OptionsCustomization.AllowGroup = false;
            this.gvUsedGoods.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvUsedGoods.OptionsView.EnableAppearanceEvenRow = true;
            this.gvUsedGoods.OptionsView.ShowGroupPanel = false;
            this.gvUsedGoods.OptionsView.ShowViewCaption = true;
            this.gvUsedGoods.ViewCaption = "Daftar Barang Bekas";
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
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEditData,
            this.tsUpdateStok});
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(130, 48);
            // 
            // tsEditData
            // 
            this.tsEditData.Name = "tsEditData";
            this.tsEditData.Size = new System.Drawing.Size(152, 22);
            this.tsEditData.Text = "Ubah Data";
            // 
            // tsUpdateStok
            // 
            this.tsUpdateStok.Name = "tsUpdateStok";
            this.tsUpdateStok.Size = new System.Drawing.Size(129, 22);
            this.tsUpdateStok.Text = "Ubah Stok";
            // 
            // UsedGoodsListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridUsedGoods);
            this.Controls.Add(this.btnNewUsedGoods);
            this.Controls.Add(this.gcFilter);
            this.Name = "UsedGoodsListControl";
            this.Size = new System.Drawing.Size(581, 327);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterSparepartName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsedGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsedGoods)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.LabelControl lblFilterCompanyName;
        private DevExpress.XtraEditors.TextEdit txtFilterSparepartName;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnNewUsedGoods;
        private DevExpress.XtraGrid.GridControl gridUsedGoods;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUsedGoods;
        private DevExpress.XtraGrid.Columns.GridColumn Sparepart;
        private DevExpress.XtraGrid.Columns.GridColumn Stock;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem tsEditData;
        private System.Windows.Forms.ToolStripMenuItem tsUpdateStok;
    }
}
