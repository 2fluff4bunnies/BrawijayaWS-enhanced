namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class CreditListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnExportToCSV = new DevExpress.XtraEditors.SimpleButton();
            this.txtLicenseNumberFilter = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpVehicleGroup = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbPaymentStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblPaymentStatus = new DevExpress.XtraEditors.LabelControl();
            this.lookUpCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCustomer = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDateFilterTo = new DevExpress.XtraEditors.DateEdit();
            this.txtDateFilterFrom = new DevExpress.XtraEditors.DateEdit();
            this.lblFilterDate = new DevExpress.XtraEditors.LabelControl();
            this.gridCredit = new DevExpress.XtraGrid.GridControl();
            this.gvCredit = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLicense = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreditAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsNewPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsListPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDialog = new System.Windows.Forms.SaveFileDialog();
            this.bgwExport = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNumberFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpVehicleGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaymentStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCredit)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.btnExportToCSV);
            this.gcFilter.Controls.Add(this.txtLicenseNumberFilter);
            this.gcFilter.Controls.Add(this.labelControl4);
            this.gcFilter.Controls.Add(this.lookUpVehicleGroup);
            this.gcFilter.Controls.Add(this.labelControl2);
            this.gcFilter.Controls.Add(this.cbPaymentStatus);
            this.gcFilter.Controls.Add(this.lblPaymentStatus);
            this.gcFilter.Controls.Add(this.lookUpCustomer);
            this.gcFilter.Controls.Add(this.lblCustomer);
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.labelControl1);
            this.gcFilter.Controls.Add(this.txtDateFilterTo);
            this.gcFilter.Controls.Add(this.txtDateFilterFrom);
            this.gcFilter.Controls.Add(this.lblFilterDate);
            this.gcFilter.Location = new System.Drawing.Point(0, 0);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(757, 129);
            this.gcFilter.TabIndex = 1;
            this.gcFilter.Text = "Filter";
            // 
            // btnExportToCSV
            // 
            this.btnExportToCSV.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.export3_16x16;
            this.btnExportToCSV.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnExportToCSV.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExportToCSV.Location = new System.Drawing.Point(632, 97);
            this.btnExportToCSV.Name = "btnExportToCSV";
            this.btnExportToCSV.Size = new System.Drawing.Size(106, 23);
            this.btnExportToCSV.TabIndex = 30;
            this.btnExportToCSV.Text = "Export Data";
            this.btnExportToCSV.Click += new System.EventHandler(this.btnExportToCSV_Click);
            // 
            // txtLicenseNumberFilter
            // 
            this.txtLicenseNumberFilter.Location = new System.Drawing.Point(484, 63);
            this.txtLicenseNumberFilter.Name = "txtLicenseNumberFilter";
            this.txtLicenseNumberFilter.Size = new System.Drawing.Size(160, 20);
            this.txtLicenseNumberFilter.TabIndex = 29;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(413, 63);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(27, 13);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "NoPol";
            // 
            // lookUpVehicleGroup
            // 
            this.lookUpVehicleGroup.Location = new System.Drawing.Point(106, 94);
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
            this.lookUpVehicleGroup.TabIndex = 27;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 97);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Kelompok";
            // 
            // cbPaymentStatus
            // 
            this.cbPaymentStatus.Location = new System.Drawing.Point(484, 31);
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
            this.cbPaymentStatus.Size = new System.Drawing.Size(135, 20);
            this.cbPaymentStatus.TabIndex = 25;
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.Location = new System.Drawing.Point(413, 34);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(62, 13);
            this.lblPaymentStatus.TabIndex = 24;
            this.lblPaymentStatus.Text = "Status Bayar";
            // 
            // lookUpCustomer
            // 
            this.lookUpCustomer.Location = new System.Drawing.Point(106, 60);
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
            this.lookUpCustomer.TabIndex = 23;
            this.lookUpCustomer.EditValueChanged += new System.EventHandler(this.lookUpCustomer_EditValueChanged);
            // 
            // lblCustomer
            // 
            this.lblCustomer.Location = new System.Drawing.Point(14, 63);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(46, 13);
            this.lblCustomer.TabIndex = 22;
            this.lblCustomer.Text = "Customer";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(673, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 55);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(250, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(4, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "-";
            // 
            // txtDateFilterTo
            // 
            this.txtDateFilterTo.EditValue = null;
            this.txtDateFilterTo.Location = new System.Drawing.Point(260, 31);
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
            this.txtDateFilterTo.Size = new System.Drawing.Size(138, 20);
            this.txtDateFilterTo.TabIndex = 4;
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
            this.txtDateFilterFrom.Size = new System.Drawing.Size(138, 20);
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
            // gridCredit
            // 
            this.gridCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCredit.Location = new System.Drawing.Point(3, 135);
            this.gridCredit.MainView = this.gvCredit;
            this.gridCredit.Name = "gridCredit";
            this.gridCredit.Size = new System.Drawing.Size(754, 180);
            this.gridCredit.TabIndex = 5;
            this.gridCredit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCredit});
            // 
            // gvCredit
            // 
            this.gvCredit.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransDate,
            this.colCustomer,
            this.colLicense,
            this.colTotalPrice,
            this.colCreditAmount,
            this.colStatus});
            this.gvCredit.GridControl = this.gridCredit;
            this.gvCredit.Name = "gvCredit";
            this.gvCredit.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCredit.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCredit.OptionsBehavior.AutoPopulateColumns = false;
            this.gvCredit.OptionsBehavior.Editable = false;
            this.gvCredit.OptionsBehavior.ReadOnly = true;
            this.gvCredit.OptionsCustomization.AllowColumnMoving = false;
            this.gvCredit.OptionsCustomization.AllowFilter = false;
            this.gvCredit.OptionsCustomization.AllowGroup = false;
            this.gvCredit.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvCredit.OptionsDetail.AllowZoomDetail = false;
            this.gvCredit.OptionsDetail.EnableMasterViewMode = false;
            this.gvCredit.OptionsDetail.ShowDetailTabs = false;
            this.gvCredit.OptionsDetail.SmartDetailExpand = false;
            this.gvCredit.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCredit.OptionsView.ShowGroupPanel = false;
            this.gvCredit.OptionsView.ShowViewCaption = true;
            this.gvCredit.ViewCaption = "Daftar Transaksi Penjualan";
            this.gvCredit.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvCredit_PopupMenuShowing);
            this.gvCredit.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvCredit_FocusedRowChanged);
            this.gvCredit.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvCredit_CustomColumnDisplayText);
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
            // colLicense
            // 
            this.colLicense.Caption = "Nomor Polisi";
            this.colLicense.FieldName = "SPK.Vehicle.ActiveLicenseNumber";
            this.colLicense.Name = "colLicense";
            this.colLicense.Visible = true;
            this.colLicense.VisibleIndex = 2;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "Total Transaksi";
            this.colTotalPrice.DisplayFormat.FormatString = " {0:#,#;(#,#);0}";
            this.colTotalPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 3;
            // 
            // colCreditAmount
            // 
            this.colCreditAmount.Caption = "Total Terbayar";
            this.colCreditAmount.DisplayFormat.FormatString = " {0:#,#;(#,#);0}";
            this.colCreditAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCreditAmount.FieldName = "TotalHasPaid";
            this.colCreditAmount.Name = "colCreditAmount";
            this.colCreditAmount.Visible = true;
            this.colCreditAmount.VisibleIndex = 4;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status Bayar";
            this.colStatus.FieldName = "PaymentStatus";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 5;
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsNewPayment,
            this.cmsListPayment});
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(205, 48);
            // 
            // cmsNewPayment
            // 
            this.cmsNewPayment.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.add_item_16x16;
            this.cmsNewPayment.Name = "cmsNewPayment";
            this.cmsNewPayment.Size = new System.Drawing.Size(204, 22);
            this.cmsNewPayment.Text = "Buat Pembayaran";
            this.cmsNewPayment.Click += new System.EventHandler(this.cmsNewPayment_Click);
            // 
            // cmsListPayment
            // 
            this.cmsListPayment.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.history_16x16;
            this.cmsListPayment.Name = "cmsListPayment";
            this.cmsListPayment.Size = new System.Drawing.Size(204, 22);
            this.cmsListPayment.Text = "Lihat Daftar Pembayaran";
            this.cmsListPayment.Click += new System.EventHandler(this.cmsListPayment_Click);
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
            // CreditListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridCredit);
            this.Controls.Add(this.gcFilter);
            this.Name = "CreditListControl";
            this.Size = new System.Drawing.Size(757, 315);
            this.Load += new System.EventHandler(this.CreditListControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNumberFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpVehicleGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaymentStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCredit)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtDateFilterFrom;
        private DevExpress.XtraEditors.LabelControl lblFilterDate;
        private DevExpress.XtraEditors.DateEdit txtDateFilterTo;
        private DevExpress.XtraGrid.GridControl gridCredit;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCredit;
        private DevExpress.XtraGrid.Columns.GridColumn colTransDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditAmount;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsNewPayment;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.ToolStripMenuItem cmsListPayment;
        private DevExpress.XtraGrid.Columns.GridColumn colLicense;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraEditors.TextEdit txtLicenseNumberFilter;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit lookUpVehicleGroup;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbPaymentStatus;
        private DevExpress.XtraEditors.LabelControl lblPaymentStatus;
        private DevExpress.XtraEditors.LookUpEdit lookUpCustomer;
        private DevExpress.XtraEditors.LabelControl lblCustomer;
        private System.Windows.Forms.SaveFileDialog exportDialog;
        private System.ComponentModel.BackgroundWorker bgwExport;
        private DevExpress.XtraEditors.SimpleButton btnExportToCSV;
    }
}
