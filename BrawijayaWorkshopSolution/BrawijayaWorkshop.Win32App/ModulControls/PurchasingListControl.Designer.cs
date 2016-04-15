namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class PurchasingListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchasingListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDateFilterTo = new DevExpress.XtraEditors.DateEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtDateFilterFrom = new DevExpress.XtraEditors.DateEdit();
            this.lblFilterDate = new DevExpress.XtraEditors.LabelControl();
            this.btnNewPurchasing = new DevExpress.XtraEditors.SimpleButton();
            this.gridPurchasing = new DevExpress.XtraGrid.GridControl();
            this.gvPurchasing = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDatePurchasing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierNamePurchasing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPricePurchasing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.persetujuanPembelianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatSelengkapnyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPrint = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchasing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchasing)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.labelControl1);
            this.gcFilter.Controls.Add(this.txtDateFilterTo);
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.txtDateFilterFrom);
            this.gcFilter.Controls.Add(this.lblFilterDate);
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(632, 64);
            this.gcFilter.TabIndex = 0;
            this.gcFilter.Text = "Filter";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(284, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(4, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "-";
            // 
            // txtDateFilterTo
            // 
            this.txtDateFilterTo.EditValue = null;
            this.txtDateFilterTo.Location = new System.Drawing.Point(294, 31);
            this.txtDateFilterTo.Name = "txtDateFilterTo";
            this.txtDateFilterTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateFilterTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateFilterTo.Properties.HideSelection = false;
            this.txtDateFilterTo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtDateFilterTo.Size = new System.Drawing.Size(138, 20);
            this.txtDateFilterTo.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(438, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDateFilterFrom
            // 
            this.txtDateFilterFrom.EditValue = null;
            this.txtDateFilterFrom.Location = new System.Drawing.Point(140, 31);
            this.txtDateFilterFrom.Name = "txtDateFilterFrom";
            this.txtDateFilterFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateFilterFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateFilterFrom.Properties.HideSelection = false;
            this.txtDateFilterFrom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtDateFilterFrom.Size = new System.Drawing.Size(138, 20);
            this.txtDateFilterFrom.TabIndex = 2;
            // 
            // lblFilterDate
            // 
            this.lblFilterDate.Location = new System.Drawing.Point(14, 34);
            this.lblFilterDate.Name = "lblFilterDate";
            this.lblFilterDate.Size = new System.Drawing.Size(89, 13);
            this.lblFilterDate.TabIndex = 1;
            this.lblFilterDate.Text = "Tanggal Pembelian";
            // 
            // btnNewPurchasing
            // 
            this.btnNewPurchasing.Image = ((System.Drawing.Image)(resources.GetObject("btnNewPurchasing.Image")));
            this.btnNewPurchasing.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewPurchasing.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewPurchasing.Location = new System.Drawing.Point(3, 73);
            this.btnNewPurchasing.Name = "btnNewPurchasing";
            this.btnNewPurchasing.Size = new System.Drawing.Size(144, 23);
            this.btnNewPurchasing.TabIndex = 3;
            this.btnNewPurchasing.Text = "Buat Pembelian Baru";
            this.btnNewPurchasing.Click += new System.EventHandler(this.btnNewPurchasing_Click);
            // 
            // gridPurchasing
            // 
            this.gridPurchasing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPurchasing.Location = new System.Drawing.Point(3, 102);
            this.gridPurchasing.MainView = this.gvPurchasing;
            this.gridPurchasing.Name = "gridPurchasing";
            this.gridPurchasing.Size = new System.Drawing.Size(632, 210);
            this.gridPurchasing.TabIndex = 4;
            this.gridPurchasing.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPurchasing});
            // 
            // gvPurchasing
            // 
            this.gvPurchasing.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDatePurchasing,
            this.colSupplierNamePurchasing,
            this.colTotalPricePurchasing,
            this.colStatus});
            this.gvPurchasing.GridControl = this.gridPurchasing;
            this.gvPurchasing.Name = "gvPurchasing";
            this.gvPurchasing.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvPurchasing.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvPurchasing.OptionsBehavior.AutoPopulateColumns = false;
            this.gvPurchasing.OptionsBehavior.Editable = false;
            this.gvPurchasing.OptionsBehavior.ReadOnly = true;
            this.gvPurchasing.OptionsCustomization.AllowColumnMoving = false;
            this.gvPurchasing.OptionsCustomization.AllowFilter = false;
            this.gvPurchasing.OptionsCustomization.AllowGroup = false;
            this.gvPurchasing.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvPurchasing.OptionsDetail.AllowZoomDetail = false;
            this.gvPurchasing.OptionsDetail.EnableMasterViewMode = false;
            this.gvPurchasing.OptionsDetail.ShowDetailTabs = false;
            this.gvPurchasing.OptionsDetail.SmartDetailExpand = false;
            this.gvPurchasing.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPurchasing.OptionsView.ShowGroupPanel = false;
            this.gvPurchasing.OptionsView.ShowViewCaption = true;
            this.gvPurchasing.ViewCaption = "Daftar Pembelian";
            this.gvPurchasing.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvPurchasing_PopupMenuShowing);
            this.gvPurchasing.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvPurchasing_FocusedRowChanged);
            this.gvPurchasing.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvPurchasing_CustomColumnDisplayText);
            // 
            // colDatePurchasing
            // 
            this.colDatePurchasing.Caption = "Tanggal";
            this.colDatePurchasing.FieldName = "Date";
            this.colDatePurchasing.Name = "colDatePurchasing";
            this.colDatePurchasing.Visible = true;
            this.colDatePurchasing.VisibleIndex = 0;
            // 
            // colSupplierNamePurchasing
            // 
            this.colSupplierNamePurchasing.Caption = "Supplier";
            this.colSupplierNamePurchasing.FieldName = "Supplier.Name";
            this.colSupplierNamePurchasing.Name = "colSupplierNamePurchasing";
            this.colSupplierNamePurchasing.Visible = true;
            this.colSupplierNamePurchasing.VisibleIndex = 1;
            // 
            // colTotalPricePurchasing
            // 
            this.colTotalPricePurchasing.Caption = "Total Harga";
            this.colTotalPricePurchasing.DisplayFormat.FormatString = "#,#";
            this.colTotalPricePurchasing.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalPricePurchasing.FieldName = "TotalPrice";
            this.colTotalPricePurchasing.Name = "colTotalPricePurchasing";
            this.colTotalPricePurchasing.Visible = true;
            this.colTotalPricePurchasing.VisibleIndex = 2;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
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
            this.persetujuanPembelianToolStripMenuItem,
            this.lihatSelengkapnyaToolStripMenuItem,
            this.cmsPrint});
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(196, 114);
            // 
            // cmsEditData
            // 
            this.cmsEditData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.cmsEditData.Name = "cmsEditData";
            this.cmsEditData.Size = new System.Drawing.Size(195, 22);
            this.cmsEditData.Text = "Ubah Data";
            this.cmsEditData.Click += new System.EventHandler(this.cmsEditData_Click);
            // 
            // persetujuanPembelianToolStripMenuItem
            // 
            this.persetujuanPembelianToolStripMenuItem.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.approve_16x16;
            this.persetujuanPembelianToolStripMenuItem.Name = "persetujuanPembelianToolStripMenuItem";
            this.persetujuanPembelianToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.persetujuanPembelianToolStripMenuItem.Text = "Persetujuan Pembelian";
            this.persetujuanPembelianToolStripMenuItem.Click += new System.EventHandler(this.persetujuanPembelianToolStripMenuItem_Click);
            // 
            // lihatSelengkapnyaToolStripMenuItem
            // 
            this.lihatSelengkapnyaToolStripMenuItem.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.history_16x16;
            this.lihatSelengkapnyaToolStripMenuItem.Name = "lihatSelengkapnyaToolStripMenuItem";
            this.lihatSelengkapnyaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.lihatSelengkapnyaToolStripMenuItem.Text = "Lihat Selengkapnya";
            this.lihatSelengkapnyaToolStripMenuItem.Click += new System.EventHandler(this.lihatSelengkapnyaToolStripMenuItem_Click);
            // 
            // cmsPrint
            // 
            this.cmsPrint.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.print_16x161;
            this.cmsPrint.Name = "cmsPrint";
            this.cmsPrint.Size = new System.Drawing.Size(195, 22);
            this.cmsPrint.Text = "Cetak";
            this.cmsPrint.Click += new System.EventHandler(this.cmsPrint_Click);
            // 
            // PurchasingListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridPurchasing);
            this.Controls.Add(this.btnNewPurchasing);
            this.Controls.Add(this.gcFilter);
            this.Name = "PurchasingListControl";
            this.Size = new System.Drawing.Size(638, 315);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchasing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchasing)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.LabelControl lblFilterDate;
        private DevExpress.XtraEditors.DateEdit txtDateFilterFrom;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnNewPurchasing;
        private DevExpress.XtraGrid.GridControl gridPurchasing;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPurchasing;
        private DevExpress.XtraGrid.Columns.GridColumn colDatePurchasing;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierNamePurchasing;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPricePurchasing;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtDateFilterTo;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private System.Windows.Forms.ToolStripMenuItem persetujuanPembelianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lihatSelengkapnyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmsPrint;

    }
}
