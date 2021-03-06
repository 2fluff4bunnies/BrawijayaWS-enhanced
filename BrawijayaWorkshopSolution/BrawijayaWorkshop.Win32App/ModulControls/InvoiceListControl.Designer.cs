﻿namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class InvoiceListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.lookUpServiceCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.txtLicenseNumberFilter = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpVehicleGroup = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbPaymentStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblPaymentStatus = new DevExpress.XtraEditors.LabelControl();
            this.lookUpCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCustomer = new DevExpress.XtraEditors.LabelControl();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            this.cbStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.txtDateFilterTo = new DevExpress.XtraEditors.DateEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDateFilterFrom = new DevExpress.XtraEditors.DateEdit();
            this.lblFilterDate = new DevExpress.XtraEditors.LabelControl();
            this.gridInvoice = new DevExpress.XtraGrid.GridControl();
            this.gvInvoice = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVehicle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsAddData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAddReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportToCSV = new DevExpress.XtraEditors.SimpleButton();
            this.exportDialog = new System.Windows.Forms.SaveFileDialog();
            this.bgwExport = new System.ComponentModel.BackgroundWorker();
            this.btnRepairAll = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpServiceCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNumberFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpVehicleGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaymentStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvoice)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.lookUpServiceCategory);
            this.gcFilter.Controls.Add(this.txtLicenseNumberFilter);
            this.gcFilter.Controls.Add(this.labelControl4);
            this.gcFilter.Controls.Add(this.labelControl3);
            this.gcFilter.Controls.Add(this.lookUpVehicleGroup);
            this.gcFilter.Controls.Add(this.labelControl2);
            this.gcFilter.Controls.Add(this.cbPaymentStatus);
            this.gcFilter.Controls.Add(this.lblPaymentStatus);
            this.gcFilter.Controls.Add(this.lookUpCustomer);
            this.gcFilter.Controls.Add(this.lblCustomer);
            this.gcFilter.Controls.Add(this.lblStatus);
            this.gcFilter.Controls.Add(this.cbStatus);
            this.gcFilter.Controls.Add(this.txtDateFilterTo);
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.labelControl1);
            this.gcFilter.Controls.Add(this.txtDateFilterFrom);
            this.gcFilter.Controls.Add(this.lblFilterDate);
            this.gcFilter.Location = new System.Drawing.Point(0, 0);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(808, 169);
            this.gcFilter.TabIndex = 2;
            this.gcFilter.Text = "Filter";
            // 
            // lookUpServiceCategory
            // 
            this.lookUpServiceCategory.Location = new System.Drawing.Point(106, 95);
            this.lookUpServiceCategory.Name = "lookUpServiceCategory";
            this.lookUpServiceCategory.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpServiceCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpServiceCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Nama"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address", "Alamat")});
            this.lookUpServiceCategory.Properties.DisplayMember = "CompanyName";
            this.lookUpServiceCategory.Properties.HideSelection = false;
            this.lookUpServiceCategory.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookUpServiceCategory.Properties.NullText = "Semua";
            this.lookUpServiceCategory.Properties.ValueMember = "Id";
            this.lookUpServiceCategory.Size = new System.Drawing.Size(181, 20);
            this.lookUpServiceCategory.TabIndex = 22;
            // 
            // txtLicenseNumberFilter
            // 
            this.txtLicenseNumberFilter.Location = new System.Drawing.Point(454, 129);
            this.txtLicenseNumberFilter.Name = "txtLicenseNumberFilter";
            this.txtLicenseNumberFilter.Size = new System.Drawing.Size(181, 20);
            this.txtLicenseNumberFilter.TabIndex = 21;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(386, 132);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(27, 13);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "NoPol";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 98);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 13);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Jenis Layanan";
            // 
            // lookUpVehicleGroup
            // 
            this.lookUpVehicleGroup.Location = new System.Drawing.Point(454, 61);
            this.lookUpVehicleGroup.Name = "lookUpVehicleGroup";
            this.lookUpVehicleGroup.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpVehicleGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpVehicleGroup.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Nama")});
            this.lookUpVehicleGroup.Properties.DisplayMember = "Name";
            this.lookUpVehicleGroup.Properties.HideSelection = false;
            this.lookUpVehicleGroup.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookUpVehicleGroup.Properties.NullText = "Semua";
            this.lookUpVehicleGroup.Properties.ValueMember = "Id";
            this.lookUpVehicleGroup.Size = new System.Drawing.Size(223, 20);
            this.lookUpVehicleGroup.TabIndex = 17;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(386, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Kelompok";
            // 
            // cbPaymentStatus
            // 
            this.cbPaymentStatus.Location = new System.Drawing.Point(454, 95);
            this.cbPaymentStatus.Name = "cbPaymentStatus";
            this.cbPaymentStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPaymentStatus.Properties.HideSelection = false;
            this.cbPaymentStatus.Properties.Items.AddRange(new object[] {
            "Semua",
            "Belum Lunas",
            "Lunas"});
            this.cbPaymentStatus.Properties.NullText = "Semua";
            this.cbPaymentStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbPaymentStatus.Size = new System.Drawing.Size(181, 20);
            this.cbPaymentStatus.TabIndex = 15;
            this.cbPaymentStatus.EditValueChanged += new System.EventHandler(this.cbPaymentStatus_EditValueChanged);
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.Location = new System.Drawing.Point(386, 98);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(62, 13);
            this.lblPaymentStatus.TabIndex = 14;
            this.lblPaymentStatus.Text = "Status Bayar";
            // 
            // lookUpCustomer
            // 
            this.lookUpCustomer.Location = new System.Drawing.Point(454, 31);
            this.lookUpCustomer.Name = "lookUpCustomer";
            this.lookUpCustomer.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCustomer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Nama"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address", "Alamat")});
            this.lookUpCustomer.Properties.DisplayMember = "CompanyName";
            this.lookUpCustomer.Properties.HideSelection = false;
            this.lookUpCustomer.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookUpCustomer.Properties.NullText = "Semua";
            this.lookUpCustomer.Properties.ValueMember = "Id";
            this.lookUpCustomer.Size = new System.Drawing.Size(223, 20);
            this.lookUpCustomer.TabIndex = 13;
            this.lookUpCustomer.EditValueChanged += new System.EventHandler(this.lookUpCustomer_EditValueChanged);
            // 
            // lblCustomer
            // 
            this.lblCustomer.Location = new System.Drawing.Point(386, 34);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(46, 13);
            this.lblCustomer.TabIndex = 12;
            this.lblCustomer.Text = "Customer";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(14, 64);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(78, 13);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status Dokumen";
            // 
            // cbStatus
            // 
            this.cbStatus.Location = new System.Drawing.Point(106, 61);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Metode")});
            this.cbStatus.Properties.DisplayMember = "Description";
            this.cbStatus.Properties.NullText = "Semua";
            this.cbStatus.Properties.ValueMember = "Status";
            this.cbStatus.Size = new System.Drawing.Size(181, 20);
            this.cbStatus.TabIndex = 10;
            // 
            // txtDateFilterTo
            // 
            this.txtDateFilterTo.EditValue = null;
            this.txtDateFilterTo.Location = new System.Drawing.Point(241, 31);
            this.txtDateFilterTo.Name = "txtDateFilterTo";
            this.txtDateFilterTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateFilterTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateFilterTo.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.txtDateFilterTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDateFilterTo.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.txtDateFilterTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDateFilterTo.Properties.HideSelection = false;
            this.txtDateFilterTo.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.txtDateFilterTo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtDateFilterTo.Size = new System.Drawing.Size(119, 20);
            this.txtDateFilterTo.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(697, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 51);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(231, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(4, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "-";
            // 
            // txtDateFilterFrom
            // 
            this.txtDateFilterFrom.EditValue = null;
            this.txtDateFilterFrom.Location = new System.Drawing.Point(106, 31);
            this.txtDateFilterFrom.Name = "txtDateFilterFrom";
            this.txtDateFilterFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateFilterFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateFilterFrom.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.txtDateFilterFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDateFilterFrom.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.txtDateFilterFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDateFilterFrom.Properties.HideSelection = false;
            this.txtDateFilterFrom.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.txtDateFilterFrom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtDateFilterFrom.Size = new System.Drawing.Size(119, 20);
            this.txtDateFilterFrom.TabIndex = 2;
            // 
            // lblFilterDate
            // 
            this.lblFilterDate.Location = new System.Drawing.Point(14, 34);
            this.lblFilterDate.Name = "lblFilterDate";
            this.lblFilterDate.Size = new System.Drawing.Size(86, 13);
            this.lblFilterDate.TabIndex = 1;
            this.lblFilterDate.Text = "Tanggal Transaksi";
            // 
            // gridInvoice
            // 
            this.gridInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridInvoice.Location = new System.Drawing.Point(0, 218);
            this.gridInvoice.MainView = this.gvInvoice;
            this.gridInvoice.Name = "gridInvoice";
            this.gridInvoice.Size = new System.Drawing.Size(808, 263);
            this.gridInvoice.TabIndex = 6;
            this.gridInvoice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInvoice});
            // 
            // gvInvoice
            // 
            this.gvInvoice.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransDate,
            this.colCustomer,
            this.colVehicle,
            this.colTotalPrice,
            this.colStatus});
            this.gvInvoice.GridControl = this.gridInvoice;
            this.gvInvoice.Name = "gvInvoice";
            this.gvInvoice.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvInvoice.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvInvoice.OptionsBehavior.AutoPopulateColumns = false;
            this.gvInvoice.OptionsBehavior.Editable = false;
            this.gvInvoice.OptionsBehavior.ReadOnly = true;
            this.gvInvoice.OptionsCustomization.AllowColumnMoving = false;
            this.gvInvoice.OptionsCustomization.AllowFilter = false;
            this.gvInvoice.OptionsCustomization.AllowGroup = false;
            this.gvInvoice.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvInvoice.OptionsDetail.AllowZoomDetail = false;
            this.gvInvoice.OptionsDetail.EnableMasterViewMode = false;
            this.gvInvoice.OptionsDetail.ShowDetailTabs = false;
            this.gvInvoice.OptionsDetail.SmartDetailExpand = false;
            this.gvInvoice.OptionsView.EnableAppearanceEvenRow = true;
            this.gvInvoice.OptionsView.ShowGroupPanel = false;
            this.gvInvoice.OptionsView.ShowViewCaption = true;
            this.gvInvoice.ViewCaption = "Daftar Invoice";
            this.gvInvoice.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvInvoice_CustomColumnDisplayText);
            // 
            // colTransDate
            // 
            this.colTransDate.Caption = "Tgl Transaksi";
            this.colTransDate.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colTransDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTransDate.FieldName = "CreateDate";
            this.colTransDate.Name = "colTransDate";
            this.colTransDate.Visible = true;
            this.colTransDate.VisibleIndex = 0;
            // 
            // colCustomer
            // 
            this.colCustomer.Caption = "Customer";
            this.colCustomer.FieldName = "SPK.Vehicle.Customer.CompanyName";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 1;
            // 
            // colVehicle
            // 
            this.colVehicle.Caption = "Kendaraan";
            this.colVehicle.FieldName = "SPK.Vehicle.ActiveLicenseNumber";
            this.colVehicle.Name = "colVehicle";
            this.colVehicle.Visible = true;
            this.colVehicle.VisibleIndex = 2;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "Total Tagihan";
            this.colTotalPrice.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colTotalPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 3;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 4;
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAddData,
            this.cmsEditData,
            this.cmsPrint,
            this.cmsAddReturn});
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(146, 92);
            // 
            // cmsAddData
            // 
            this.cmsAddData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.add_item_16x16;
            this.cmsAddData.Name = "cmsAddData";
            this.cmsAddData.Size = new System.Drawing.Size(145, 22);
            this.cmsAddData.Text = "Buat Invoice";
            this.cmsAddData.Click += new System.EventHandler(this.cmsNewData_Click);
            // 
            // cmsEditData
            // 
            this.cmsEditData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.cmsEditData.Name = "cmsEditData";
            this.cmsEditData.Size = new System.Drawing.Size(145, 22);
            this.cmsEditData.Text = "Ubah Data";
            this.cmsEditData.Click += new System.EventHandler(this.cmEditData_Click);
            // 
            // cmsPrint
            // 
            this.cmsPrint.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.print_16x16;
            this.cmsPrint.Name = "cmsPrint";
            this.cmsPrint.Size = new System.Drawing.Size(145, 22);
            this.cmsPrint.Text = "Cetak Invoice";
            this.cmsPrint.Click += new System.EventHandler(this.cmsPrint_Click);
            // 
            // cmsAddReturn
            // 
            this.cmsAddReturn.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.add_item_16x16;
            this.cmsAddReturn.Name = "cmsAddReturn";
            this.cmsAddReturn.Size = new System.Drawing.Size(145, 22);
            this.cmsAddReturn.Text = "Buat Retur";
            this.cmsAddReturn.Click += new System.EventHandler(this.cmsAddReturn_Click);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.print_16x16;
            this.btnPrintAll.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnPrintAll.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnPrintAll.Location = new System.Drawing.Point(14, 189);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(97, 23);
            this.btnPrintAll.TabIndex = 7;
            this.btnPrintAll.Text = "Print Semua";
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // btnExportToCSV
            // 
            this.btnExportToCSV.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.export3_16x16;
            this.btnExportToCSV.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnExportToCSV.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExportToCSV.Location = new System.Drawing.Point(119, 189);
            this.btnExportToCSV.Name = "btnExportToCSV";
            this.btnExportToCSV.Size = new System.Drawing.Size(106, 23);
            this.btnExportToCSV.TabIndex = 8;
            this.btnExportToCSV.Text = "Export Data";
            this.btnExportToCSV.Click += new System.EventHandler(this.btnExportToCSV_Click);
            // 
            // exportDialog
            // 
            this.exportDialog.DefaultExt = "csv";
            this.exportDialog.Filter = "CSV (*.csv) | *.csv";
            this.exportDialog.Title = "Export Invoice";
            this.exportDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.exportDialog_FileOk);
            // 
            // bgwExport
            // 
            this.bgwExport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwExport_DoWork);
            this.bgwExport.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwExport_RunWorkerCompleted);
            // 
            // btnRepairAll
            // 
            this.btnRepairAll.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnRepairAll.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnRepairAll.Location = new System.Drawing.Point(231, 189);
            this.btnRepairAll.Name = "btnRepairAll";
            this.btnRepairAll.Size = new System.Drawing.Size(106, 23);
            this.btnRepairAll.TabIndex = 9;
            this.btnRepairAll.Text = "Repair All";
            this.btnRepairAll.Click += new System.EventHandler(this.btnRepairAll_Click);
            // 
            // InvoiceListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRepairAll);
            this.Controls.Add(this.btnExportToCSV);
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.gridInvoice);
            this.Controls.Add(this.gcFilter);
            this.Name = "InvoiceListControl";
            this.Size = new System.Drawing.Size(808, 481);
            this.Load += new System.EventHandler(this.InvoiceListControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpServiceCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNumberFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpVehicleGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaymentStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvoice)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtDateFilterTo;
        private DevExpress.XtraEditors.DateEdit txtDateFilterFrom;
        private DevExpress.XtraEditors.LabelControl lblFilterDate;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.LookUpEdit cbStatus;
        private DevExpress.XtraGrid.GridControl gridInvoice;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInvoice;
        private DevExpress.XtraGrid.Columns.GridColumn colTransDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsAddData;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private System.Windows.Forms.ToolStripMenuItem cmsPrint;
        private DevExpress.XtraGrid.Columns.GridColumn colVehicle;
        private DevExpress.XtraEditors.SimpleButton btnPrintAll;
        private DevExpress.XtraEditors.LookUpEdit lookUpCustomer;
        private DevExpress.XtraEditors.LabelControl lblCustomer;
        private DevExpress.XtraEditors.ComboBoxEdit cbPaymentStatus;
        private DevExpress.XtraEditors.LabelControl lblPaymentStatus;
        private DevExpress.XtraEditors.SimpleButton btnExportToCSV;
        private System.Windows.Forms.SaveFileDialog exportDialog;
        private System.ComponentModel.BackgroundWorker bgwExport;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private System.Windows.Forms.ToolStripMenuItem cmsAddReturn;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lookUpVehicleGroup;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtLicenseNumberFilter;
        private DevExpress.XtraEditors.LookUpEdit lookUpServiceCategory;
        private DevExpress.XtraEditors.SimpleButton btnRepairAll;

    }
}
