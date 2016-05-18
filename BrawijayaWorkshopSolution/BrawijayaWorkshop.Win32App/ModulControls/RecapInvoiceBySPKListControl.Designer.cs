namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class RecapInvoiceBySPKListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecapInvoiceBySPKListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.lookupVehicleGroup = new DevExpress.XtraEditors.LookUpEdit();
            this.lblVehicleGroup = new DevExpress.XtraEditors.LabelControl();
            this.lookupLicenseNumber = new DevExpress.XtraEditors.LookUpEdit();
            this.lblLicenseNumber = new DevExpress.XtraEditors.LabelControl();
            this.lookupCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCustomer = new DevExpress.XtraEditors.LabelControl();
            this.lookupCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCategory = new DevExpress.XtraEditors.LabelControl();
            this.dePeriodeTo = new DevExpress.XtraEditors.DateEdit();
            this.lblPeriodTo = new DevExpress.XtraEditors.LabelControl();
            this.dePeriodFrom = new DevExpress.XtraEditors.DateEdit();
            this.lblDateFrom = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintAll = new DevExpress.XtraEditors.SimpleButton();
            this.gridRecapInvoice = new DevExpress.XtraGrid.GridControl();
            this.gvRecapInvoice = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVehicleGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVehicleLicense = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepartQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWithoutFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServiceTenPersen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupVehicleGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupLicenseNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePeriodeTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePeriodeTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePeriodFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePeriodFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecapInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecapInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.lookupVehicleGroup);
            this.gcFilter.Controls.Add(this.lblVehicleGroup);
            this.gcFilter.Controls.Add(this.lookupLicenseNumber);
            this.gcFilter.Controls.Add(this.lblLicenseNumber);
            this.gcFilter.Controls.Add(this.lookupCustomer);
            this.gcFilter.Controls.Add(this.lblCustomer);
            this.gcFilter.Controls.Add(this.lookupCategory);
            this.gcFilter.Controls.Add(this.lblCategory);
            this.gcFilter.Controls.Add(this.dePeriodeTo);
            this.gcFilter.Controls.Add(this.lblPeriodTo);
            this.gcFilter.Controls.Add(this.dePeriodFrom);
            this.gcFilter.Controls.Add(this.lblDateFrom);
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(959, 137);
            this.gcFilter.TabIndex = 1;
            this.gcFilter.Text = "Filter";
            // 
            // lookupVehicleGroup
            // 
            this.lookupVehicleGroup.Location = new System.Drawing.Point(72, 102);
            this.lookupVehicleGroup.Name = "lookupVehicleGroup";
            this.lookupVehicleGroup.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookupVehicleGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupVehicleGroup.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Nama")});
            this.lookupVehicleGroup.Properties.DisplayMember = "Name";
            this.lookupVehicleGroup.Properties.HideSelection = false;
            this.lookupVehicleGroup.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookupVehicleGroup.Properties.NullText = "-- Pilih Kelompok --";
            this.lookupVehicleGroup.Properties.ValueMember = "Id";
            this.lookupVehicleGroup.Size = new System.Drawing.Size(130, 20);
            this.lookupVehicleGroup.TabIndex = 14;
            // 
            // lblVehicleGroup
            // 
            this.lblVehicleGroup.Location = new System.Drawing.Point(12, 105);
            this.lblVehicleGroup.Name = "lblVehicleGroup";
            this.lblVehicleGroup.Size = new System.Drawing.Size(49, 13);
            this.lblVehicleGroup.TabIndex = 13;
            this.lblVehicleGroup.Text = "Kelompok:";
            // 
            // lookupLicenseNumber
            // 
            this.lookupLicenseNumber.Location = new System.Drawing.Point(318, 102);
            this.lookupLicenseNumber.Name = "lookupLicenseNumber";
            this.lookupLicenseNumber.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookupLicenseNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupLicenseNumber.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Kode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ActiveLicenseNumber", "Nopol")});
            this.lookupLicenseNumber.Properties.DisplayMember = "ActiveLicenseNumber";
            this.lookupLicenseNumber.Properties.HideSelection = false;
            this.lookupLicenseNumber.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookupLicenseNumber.Properties.NullText = "-- Pilih Nopol --";
            this.lookupLicenseNumber.Properties.ValueMember = "Id";
            this.lookupLicenseNumber.Size = new System.Drawing.Size(177, 20);
            this.lookupLicenseNumber.TabIndex = 12;
            // 
            // lblLicenseNumber
            // 
            this.lblLicenseNumber.Location = new System.Drawing.Point(262, 105);
            this.lblLicenseNumber.Name = "lblLicenseNumber";
            this.lblLicenseNumber.Size = new System.Drawing.Size(31, 13);
            this.lblLicenseNumber.TabIndex = 11;
            this.lblLicenseNumber.Text = "Nopol:";
            // 
            // lookupCustomer
            // 
            this.lookupCustomer.Location = new System.Drawing.Point(318, 67);
            this.lookupCustomer.Name = "lookupCustomer";
            this.lookupCustomer.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookupCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupCustomer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Kode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Nama"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address", "Alamat")});
            this.lookupCustomer.Properties.DisplayMember = "CompanyName";
            this.lookupCustomer.Properties.HideSelection = false;
            this.lookupCustomer.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookupCustomer.Properties.NullText = "-- Pilih Customer --";
            this.lookupCustomer.Properties.ValueMember = "Id";
            this.lookupCustomer.Size = new System.Drawing.Size(177, 20);
            this.lookupCustomer.TabIndex = 10;
            // 
            // lblCustomer
            // 
            this.lblCustomer.Location = new System.Drawing.Point(262, 70);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(50, 13);
            this.lblCustomer.TabIndex = 9;
            this.lblCustomer.Text = "Customer:";
            // 
            // lookupCategory
            // 
            this.lookupCategory.Location = new System.Drawing.Point(72, 67);
            this.lookupCategory.Name = "lookupCategory";
            this.lookupCategory.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookupCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Nama"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Keterangan")});
            this.lookupCategory.Properties.DisplayMember = "Name";
            this.lookupCategory.Properties.HideSelection = false;
            this.lookupCategory.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookupCategory.Properties.NullText = "-- Pilih Kategori --";
            this.lookupCategory.Properties.ValueMember = "Id";
            this.lookupCategory.Size = new System.Drawing.Size(162, 20);
            this.lookupCategory.TabIndex = 8;
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(12, 70);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(44, 13);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Kategori:";
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
            this.btnSearch.Location = new System.Drawing.Point(517, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 92);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.print_16x16;
            this.btnPrintAll.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPrintAll.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnPrintAll.Location = new System.Drawing.Point(3, 146);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(107, 23);
            this.btnPrintAll.TabIndex = 2;
            this.btnPrintAll.Text = "Print Semua";
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // gridRecapInvoice
            // 
            this.gridRecapInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridRecapInvoice.Location = new System.Drawing.Point(3, 175);
            this.gridRecapInvoice.MainView = this.gvRecapInvoice;
            this.gridRecapInvoice.Name = "gridRecapInvoice";
            this.gridRecapInvoice.Size = new System.Drawing.Size(959, 246);
            this.gridRecapInvoice.TabIndex = 3;
            this.gridRecapInvoice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRecapInvoice});
            // 
            // gvRecapInvoice
            // 
            this.gvRecapInvoice.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomer,
            this.colVehicleGroup,
            this.colVehicleLicense,
            this.colInvoiceDate,
            this.colSparepartName,
            this.colSparepartQuantity,
            this.colWithoutFee,
            this.colServiceTenPersen,
            this.colSubTotal});
            this.gvRecapInvoice.GridControl = this.gridRecapInvoice;
            this.gvRecapInvoice.GroupCount = 3;
            this.gvRecapInvoice.Name = "gvRecapInvoice";
            this.gvRecapInvoice.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvRecapInvoice.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvRecapInvoice.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvRecapInvoice.OptionsBehavior.AutoPopulateColumns = false;
            this.gvRecapInvoice.OptionsBehavior.Editable = false;
            this.gvRecapInvoice.OptionsBehavior.ReadOnly = true;
            this.gvRecapInvoice.OptionsCustomization.AllowColumnMoving = false;
            this.gvRecapInvoice.OptionsCustomization.AllowGroup = false;
            this.gvRecapInvoice.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvRecapInvoice.OptionsView.ShowFooter = true;
            this.gvRecapInvoice.OptionsView.ShowGroupPanel = false;
            this.gvRecapInvoice.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCustomer, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colVehicleGroup, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colVehicleLicense, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCustomer
            // 
            this.colCustomer.Caption = "Customer";
            this.colCustomer.FieldName = "Customer.CompanyName";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 0;
            // 
            // colVehicleGroup
            // 
            this.colVehicleGroup.Caption = "Kelompok";
            this.colVehicleGroup.FieldName = "VehicleGroup.Name";
            this.colVehicleGroup.Name = "colVehicleGroup";
            this.colVehicleGroup.Visible = true;
            this.colVehicleGroup.VisibleIndex = 0;
            // 
            // colVehicleLicense
            // 
            this.colVehicleLicense.Caption = "Nopol";
            this.colVehicleLicense.FieldName = "Invoice.SPK.Vehicle.ActiveLicenseNumber";
            this.colVehicleLicense.Name = "colVehicleLicense";
            this.colVehicleLicense.Visible = true;
            this.colVehicleLicense.VisibleIndex = 0;
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.Caption = "Tanggal";
            this.colInvoiceDate.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colInvoiceDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colInvoiceDate.FieldName = "Invoice.CreateDate";
            this.colInvoiceDate.Name = "colInvoiceDate";
            this.colInvoiceDate.Visible = true;
            this.colInvoiceDate.VisibleIndex = 0;
            this.colInvoiceDate.Width = 83;
            // 
            // colSparepartName
            // 
            this.colSparepartName.Caption = "Nama Barang";
            this.colSparepartName.FieldName = "ItemName";
            this.colSparepartName.Name = "colSparepartName";
            this.colSparepartName.Visible = true;
            this.colSparepartName.VisibleIndex = 1;
            // 
            // colSparepartQuantity
            // 
            this.colSparepartQuantity.Caption = "Jumlah";
            this.colSparepartQuantity.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colSparepartQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSparepartQuantity.FieldName = "Quantity";
            this.colSparepartQuantity.Name = "colSparepartQuantity";
            this.colSparepartQuantity.Visible = true;
            this.colSparepartQuantity.VisibleIndex = 2;
            // 
            // colWithoutFee
            // 
            this.colWithoutFee.Caption = "Tagihan";
            this.colWithoutFee.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colWithoutFee.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colWithoutFee.FieldName = "SubTotalWithoutFee";
            this.colWithoutFee.Name = "colWithoutFee";
            this.colWithoutFee.Visible = true;
            this.colWithoutFee.VisibleIndex = 3;
            // 
            // colServiceTenPersen
            // 
            this.colServiceTenPersen.Caption = "Jasa 10%";
            this.colServiceTenPersen.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colServiceTenPersen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colServiceTenPersen.FieldName = "NominalFee";
            this.colServiceTenPersen.Name = "colServiceTenPersen";
            this.colServiceTenPersen.Visible = true;
            this.colServiceTenPersen.VisibleIndex = 4;
            // 
            // colSubTotal
            // 
            this.colSubTotal.Caption = "Sub Total";
            this.colSubTotal.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubTotal.FieldName = "SubTotalWithFee";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubTotalWithFee", "{0:#,#;(#,#);0}")});
            this.colSubTotal.Visible = true;
            this.colSubTotal.VisibleIndex = 5;
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // RecapInvoiceBySPKListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridRecapInvoice);
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.gcFilter);
            this.Name = "RecapInvoiceBySPKListControl";
            this.Size = new System.Drawing.Size(965, 424);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupVehicleGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupLicenseNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePeriodeTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePeriodeTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePeriodFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePeriodFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecapInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecapInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LookUpEdit lookupCustomer;
        private DevExpress.XtraEditors.LabelControl lblCustomer;
        private DevExpress.XtraEditors.LookUpEdit lookupCategory;
        private DevExpress.XtraEditors.LabelControl lblCategory;
        private DevExpress.XtraEditors.DateEdit dePeriodeTo;
        private DevExpress.XtraEditors.LabelControl lblPeriodTo;
        private DevExpress.XtraEditors.DateEdit dePeriodFrom;
        private DevExpress.XtraEditors.LabelControl lblDateFrom;
        private DevExpress.XtraEditors.LookUpEdit lookupLicenseNumber;
        private DevExpress.XtraEditors.LabelControl lblLicenseNumber;
        private DevExpress.XtraEditors.LookUpEdit lookupVehicleGroup;
        private DevExpress.XtraEditors.LabelControl lblVehicleGroup;
        private DevExpress.XtraEditors.SimpleButton btnPrintAll;
        private DevExpress.XtraGrid.GridControl gridRecapInvoice;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRecapInvoice;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colVehicleGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colVehicleLicense;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartName;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotal;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceTenPersen;
        private DevExpress.XtraGrid.Columns.GridColumn colWithoutFee;
    }
}
