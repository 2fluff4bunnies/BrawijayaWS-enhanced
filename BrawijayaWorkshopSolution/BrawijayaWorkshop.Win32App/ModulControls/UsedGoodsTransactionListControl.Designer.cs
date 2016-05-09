namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class UsedGoodsTransactionListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsedGoodsTransactionListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtFilterSparepartName = new DevExpress.XtraEditors.TextEdit();
            this.lblFilterCompanyName = new DevExpress.XtraEditors.LabelControl();
            this.gridUsedGoodTrans = new DevExpress.XtraGrid.GridControl();
            this.gvUsedGoodTrans = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnNewUsedGoodTrans = new DevExpress.XtraEditors.SimpleButton();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterSparepartName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsedGoodTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsedGoodTrans)).BeginInit();
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
            this.gcFilter.TabIndex = 1;
            this.gcFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(511, 27);
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
            // gridUsedGoodTrans
            // 
            this.gridUsedGoodTrans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUsedGoodTrans.Location = new System.Drawing.Point(3, 100);
            this.gridUsedGoodTrans.MainView = this.gvUsedGoodTrans;
            this.gridUsedGoodTrans.Name = "gridUsedGoodTrans";
            this.gridUsedGoodTrans.Size = new System.Drawing.Size(575, 224);
            this.gridUsedGoodTrans.TabIndex = 6;
            this.gridUsedGoodTrans.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUsedGoodTrans});
            // 
            // gvUsedGoodTrans
            // 
            this.gvUsedGoodTrans.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransDate,
            this.colSparepart,
            this.colQty,
            this.colType});
            this.gvUsedGoodTrans.GridControl = this.gridUsedGoodTrans;
            this.gvUsedGoodTrans.Name = "gvUsedGoodTrans";
            this.gvUsedGoodTrans.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvUsedGoodTrans.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvUsedGoodTrans.OptionsBehavior.AutoPopulateColumns = false;
            this.gvUsedGoodTrans.OptionsBehavior.Editable = false;
            this.gvUsedGoodTrans.OptionsBehavior.ReadOnly = true;
            this.gvUsedGoodTrans.OptionsCustomization.AllowColumnMoving = false;
            this.gvUsedGoodTrans.OptionsCustomization.AllowFilter = false;
            this.gvUsedGoodTrans.OptionsCustomization.AllowGroup = false;
            this.gvUsedGoodTrans.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvUsedGoodTrans.OptionsView.EnableAppearanceEvenRow = true;
            this.gvUsedGoodTrans.OptionsView.ShowGroupPanel = false;
            this.gvUsedGoodTrans.OptionsView.ShowViewCaption = true;
            this.gvUsedGoodTrans.ViewCaption = "Daftar Transaksi Barang Bekas";
            // 
            // colTransDate
            // 
            this.colTransDate.Caption = "Tanggal Transaksi";
            this.colTransDate.FieldName = "TransactionDate";
            this.colTransDate.Name = "colTransDate";
            this.colTransDate.Visible = true;
            this.colTransDate.VisibleIndex = 0;
            // 
            // colSparepart
            // 
            this.colSparepart.Caption = "Sparepart";
            this.colSparepart.FieldName = "UsedGood.Sparepart.Name";
            this.colSparepart.Name = "colSparepart";
            this.colSparepart.Visible = true;
            this.colSparepart.VisibleIndex = 1;
            // 
            // colQty
            // 
            this.colQty.Caption = "Stock Keluar";
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 2;
            // 
            // colType
            // 
            this.colType.Caption = "Tipe";
            this.colType.FieldName = "TypeReference.Name";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 3;
            // 
            // btnNewUsedGoodTrans
            // 
            this.btnNewUsedGoodTrans.Image = ((System.Drawing.Image)(resources.GetObject("btnNewUsedGoodTrans.Image")));
            this.btnNewUsedGoodTrans.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewUsedGoodTrans.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewUsedGoodTrans.Location = new System.Drawing.Point(3, 71);
            this.btnNewUsedGoodTrans.Name = "btnNewUsedGoodTrans";
            this.btnNewUsedGoodTrans.Size = new System.Drawing.Size(219, 23);
            this.btnNewUsedGoodTrans.TabIndex = 5;
            this.btnNewUsedGoodTrans.Text = "Buat Transaksi Barang Bekas Baru";
            this.btnNewUsedGoodTrans.Click += new System.EventHandler(this.btnNewTransaction_Click);
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditData});
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(122, 26);
            // 
            // cmsEditData
            // 
            this.cmsEditData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.cmsEditData.Name = "cmsEditData";
            this.cmsEditData.Size = new System.Drawing.Size(121, 22);
            this.cmsEditData.Text = "Edit Data";
            this.cmsEditData.Click += new System.EventHandler(this.cmsEditData_Click);
            // 
            // UsedGoodsTransactionListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridUsedGoodTrans);
            this.Controls.Add(this.btnNewUsedGoodTrans);
            this.Controls.Add(this.gcFilter);
            this.Name = "UsedGoodsTransactionListControl";
            this.Size = new System.Drawing.Size(581, 327);
            this.Load += new System.EventHandler(this.UsedGoodsListTransactionControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterSparepartName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsedGoodTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsedGoodTrans)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtFilterSparepartName;
        private DevExpress.XtraEditors.LabelControl lblFilterCompanyName;
        private DevExpress.XtraGrid.GridControl gridUsedGoodTrans;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUsedGoodTrans;
        private DevExpress.XtraGrid.Columns.GridColumn colTransDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepart;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraEditors.SimpleButton btnNewUsedGoodTrans;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
    }
}
