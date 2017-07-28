namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class RecapPurchasingBySupplierListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecapPurchasingBySupplierListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.lookupSupplier = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCustomer = new DevExpress.XtraEditors.LabelControl();
            this.dePeriodeTo = new DevExpress.XtraEditors.DateEdit();
            this.lblPeriodTo = new DevExpress.XtraEditors.LabelControl();
            this.dePeriodFrom = new DevExpress.XtraEditors.DateEdit();
            this.lblDateFrom = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintAll = new DevExpress.XtraEditors.SimpleButton();
            this.gridRecapPurchasing = new DevExpress.XtraGrid.GridControl();
            this.gvRecapPurchasing = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDatePurchasing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierNamePurchasing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPricePurchasing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePeriodeTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePeriodeTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePeriodFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePeriodFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecapPurchasing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecapPurchasing)).BeginInit();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.lookupSupplier);
            this.gcFilter.Controls.Add(this.lblCustomer);
            this.gcFilter.Controls.Add(this.dePeriodeTo);
            this.gcFilter.Controls.Add(this.lblPeriodTo);
            this.gcFilter.Controls.Add(this.dePeriodFrom);
            this.gcFilter.Controls.Add(this.lblDateFrom);
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Location = new System.Drawing.Point(2, 4);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(729, 79);
            this.gcFilter.TabIndex = 9;
            this.gcFilter.Text = "Filter";
            // 
            // lookupSupplier
            // 
            this.lookupSupplier.Location = new System.Drawing.Point(441, 29);
            this.lookupSupplier.Name = "lookupSupplier";
            this.lookupSupplier.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookupSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupSupplier.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Kode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Nama"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address", "Alamat")});
            this.lookupSupplier.Properties.DisplayMember = "Name";
            this.lookupSupplier.Properties.HideSelection = false;
            this.lookupSupplier.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookupSupplier.Properties.NullText = "-- Pilih Supplier --";
            this.lookupSupplier.Properties.ValueMember = "Id";
            this.lookupSupplier.Size = new System.Drawing.Size(177, 20);
            this.lookupSupplier.TabIndex = 10;
            // 
            // lblCustomer
            // 
            this.lblCustomer.Location = new System.Drawing.Point(385, 33);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(42, 13);
            this.lblCustomer.TabIndex = 9;
            this.lblCustomer.Text = "Supplier:";
            // 
            // dePeriodeTo
            // 
            this.dePeriodeTo.EditValue = null;
            this.dePeriodeTo.Location = new System.Drawing.Point(229, 32);
            this.dePeriodeTo.Name = "dePeriodeTo";
            this.dePeriodeTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dePeriodeTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dePeriodeTo.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.dePeriodeTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dePeriodeTo.Properties.HideSelection = false;
            this.dePeriodeTo.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.dePeriodeTo.Size = new System.Drawing.Size(130, 20);
            this.dePeriodeTo.TabIndex = 6;
            // 
            // lblPeriodTo
            // 
            this.lblPeriodTo.Location = new System.Drawing.Point(208, 36);
            this.lblPeriodTo.Name = "lblPeriodTo";
            this.lblPeriodTo.Size = new System.Drawing.Size(15, 13);
            this.lblPeriodTo.TabIndex = 5;
            this.lblPeriodTo.Text = "s/d";
            // 
            // dePeriodFrom
            // 
            this.dePeriodFrom.EditValue = null;
            this.dePeriodFrom.Location = new System.Drawing.Point(72, 32);
            this.dePeriodFrom.Name = "dePeriodFrom";
            this.dePeriodFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dePeriodFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dePeriodFrom.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.dePeriodFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dePeriodFrom.Properties.HideSelection = false;
            this.dePeriodFrom.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.dePeriodFrom.Size = new System.Drawing.Size(130, 20);
            this.dePeriodFrom.TabIndex = 4;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.Location = new System.Drawing.Point(12, 35);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(40, 13);
            this.lblDateFrom.TabIndex = 3;
            this.lblDateFrom.Text = "Periode:";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(636, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 21);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.print_16x16;
            this.btnPrintAll.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPrintAll.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnPrintAll.Location = new System.Drawing.Point(-166, 195);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(107, 23);
            this.btnPrintAll.TabIndex = 10;
            this.btnPrintAll.Text = "Print Semua";
            // 
            // gridRecapPurchasing
            // 
            this.gridRecapPurchasing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridRecapPurchasing.Location = new System.Drawing.Point(2, 116);
            this.gridRecapPurchasing.MainView = this.gvRecapPurchasing;
            this.gridRecapPurchasing.Name = "gridRecapPurchasing";
            this.gridRecapPurchasing.Size = new System.Drawing.Size(728, 289);
            this.gridRecapPurchasing.TabIndex = 11;
            this.gridRecapPurchasing.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRecapPurchasing});
            // 
            // gvRecapPurchasing
            // 
            this.gvRecapPurchasing.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colDatePurchasing,
            this.colSupplierNamePurchasing,
            this.colTotalPricePurchasing});
            this.gvRecapPurchasing.GridControl = this.gridRecapPurchasing;
            this.gvRecapPurchasing.Name = "gvRecapPurchasing";
            this.gvRecapPurchasing.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvRecapPurchasing.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvRecapPurchasing.OptionsBehavior.AutoPopulateColumns = false;
            this.gvRecapPurchasing.OptionsBehavior.Editable = false;
            this.gvRecapPurchasing.OptionsBehavior.ReadOnly = true;
            this.gvRecapPurchasing.OptionsCustomization.AllowColumnMoving = false;
            this.gvRecapPurchasing.OptionsCustomization.AllowFilter = false;
            this.gvRecapPurchasing.OptionsCustomization.AllowGroup = false;
            this.gvRecapPurchasing.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvRecapPurchasing.OptionsDetail.AllowZoomDetail = false;
            this.gvRecapPurchasing.OptionsDetail.EnableMasterViewMode = false;
            this.gvRecapPurchasing.OptionsDetail.ShowDetailTabs = false;
            this.gvRecapPurchasing.OptionsDetail.SmartDetailExpand = false;
            this.gvRecapPurchasing.OptionsView.EnableAppearanceEvenRow = true;
            this.gvRecapPurchasing.OptionsView.ShowGroupPanel = false;
            this.gvRecapPurchasing.ViewCaption = "Daftar Pembelian";
            // 
            // colDatePurchasing
            // 
            this.colDatePurchasing.Caption = "Tanggal";
            this.colDatePurchasing.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colDatePurchasing.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDatePurchasing.FieldName = "Date";
            this.colDatePurchasing.Name = "colDatePurchasing";
            this.colDatePurchasing.Visible = true;
            this.colDatePurchasing.VisibleIndex = 1;
            // 
            // colSupplierNamePurchasing
            // 
            this.colSupplierNamePurchasing.Caption = "Supplier";
            this.colSupplierNamePurchasing.FieldName = "Supplier.Name";
            this.colSupplierNamePurchasing.Name = "colSupplierNamePurchasing";
            this.colSupplierNamePurchasing.Visible = true;
            this.colSupplierNamePurchasing.VisibleIndex = 2;
            // 
            // colTotalPricePurchasing
            // 
            this.colTotalPricePurchasing.Caption = "Total Harga";
            this.colTotalPricePurchasing.DisplayFormat.FormatString = "#,#";
            this.colTotalPricePurchasing.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalPricePurchasing.FieldName = "TotalPrice";
            this.colTotalPricePurchasing.Name = "colTotalPricePurchasing";
            this.colTotalPricePurchasing.Visible = true;
            this.colTotalPricePurchasing.VisibleIndex = 3;
            // 
            // colCode
            // 
            this.colCode.Caption = "Kode";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // RecapPurchasingBySupplierListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridRecapPurchasing);
            this.Controls.Add(this.gcFilter);
            this.Controls.Add(this.btnPrintAll);
            this.Name = "RecapPurchasingBySupplierListControl";
            this.Size = new System.Drawing.Size(734, 383);
            this.Load += new System.EventHandler(this.RecapInvoiceByCustomerListControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePeriodeTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePeriodeTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePeriodFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePeriodFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecapPurchasing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecapPurchasing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.LookUpEdit lookupSupplier;
        private DevExpress.XtraEditors.LabelControl lblCustomer;
        private DevExpress.XtraEditors.DateEdit dePeriodeTo;
        private DevExpress.XtraEditors.LabelControl lblPeriodTo;
        private DevExpress.XtraEditors.DateEdit dePeriodFrom;
        private DevExpress.XtraEditors.LabelControl lblDateFrom;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnPrintAll;
        private DevExpress.XtraGrid.GridControl gridRecapPurchasing;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRecapPurchasing;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDatePurchasing;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierNamePurchasing;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPricePurchasing;
        private System.ComponentModel.BackgroundWorker bgwMain;
    }
}
