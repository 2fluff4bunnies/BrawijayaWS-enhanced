namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class SPKHistoryListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPKHistoryListControl));
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLicenseNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusApproval = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusPrint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusCompleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.gvSPK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcSPK = new DevExpress.XtraGrid.GridControl();
            this.groupFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnExportToCSV = new DevExpress.XtraEditors.SimpleButton();
            this.txtDateFilterTo = new DevExpress.XtraEditors.DateEdit();
            this.txtDateFilterFrom = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblFilterDate = new DevExpress.XtraEditors.LabelControl();
            this.lookUpContractWorkStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.lblContractWork = new DevExpress.XtraEditors.LabelControl();
            this.txtLicenseNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblLicenseNumber = new DevExpress.XtraEditors.LabelControl();
            this.lookUpCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.lblApprovalStatus = new DevExpress.XtraEditors.LabelControl();
            this.lookUpCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.lblCode = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lblCategory = new DevExpress.XtraEditors.LabelControl();
            this.exportDialog = new System.Windows.Forms.SaveFileDialog();
            this.bgwExport = new System.ComponentModel.BackgroundWorker();
            this.cmsEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSPK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSPK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupFilter)).BeginInit();
            this.groupFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpContractWorkStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // colCode
            // 
            this.colCode.Caption = "Kode";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // colDueDate
            // 
            this.colDueDate.Caption = "Batas Waktu";
            this.colDueDate.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colDueDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDueDate.FieldName = "DueDate";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.Visible = true;
            this.colDueDate.VisibleIndex = 2;
            // 
            // colLicenseNumber
            // 
            this.colLicenseNumber.Caption = "Nopol";
            this.colLicenseNumber.FieldName = "Vehicle.ActiveLicenseNumber";
            this.colLicenseNumber.Name = "colLicenseNumber";
            this.colLicenseNumber.Visible = true;
            this.colLicenseNumber.VisibleIndex = 3;
            // 
            // colCategory
            // 
            this.colCategory.Caption = "Kategori";
            this.colCategory.FieldName = "CategoryReference.Name";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 4;
            // 
            // colStatusApproval
            // 
            this.colStatusApproval.Caption = "Status Persetujuan";
            this.colStatusApproval.FieldName = "StatusApprovalId";
            this.colStatusApproval.Name = "colStatusApproval";
            this.colStatusApproval.Visible = true;
            this.colStatusApproval.VisibleIndex = 5;
            // 
            // colStatusPrint
            // 
            this.colStatusPrint.Caption = "Status Print";
            this.colStatusPrint.FieldName = "StatusPrintId";
            this.colStatusPrint.Name = "colStatusPrint";
            this.colStatusPrint.Visible = true;
            this.colStatusPrint.VisibleIndex = 6;
            // 
            // colStatusCompleted
            // 
            this.colStatusCompleted.Caption = "Status Pengerjaan";
            this.colStatusCompleted.FieldName = "StatusCompletedId";
            this.colStatusCompleted.Name = "colStatusCompleted";
            this.colStatusCompleted.Visible = true;
            this.colStatusCompleted.VisibleIndex = 7;
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDetailToolStripMenuItem});
            this.cmsEditor.Name = "cmsListEditor";
            this.cmsEditor.Size = new System.Drawing.Size(134, 26);
            // 
            // viewDetailToolStripMenuItem
            // 
            this.viewDetailToolStripMenuItem.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.zoom_icon;
            this.viewDetailToolStripMenuItem.Name = "viewDetailToolStripMenuItem";
            this.viewDetailToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.viewDetailToolStripMenuItem.Text = "Lihat Detail";
            this.viewDetailToolStripMenuItem.Click += new System.EventHandler(this.viewDetailToolStripMenuItem_Click);
            // 
            // colCreateDate
            // 
            this.colCreateDate.Caption = "Tgl Pembuatan";
            this.colCreateDate.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colCreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 1;
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // gvSPK
            // 
            this.gvSPK.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colCreateDate,
            this.colDueDate,
            this.colLicenseNumber,
            this.colCategory,
            this.colStatusApproval,
            this.colStatusPrint,
            this.colStatusCompleted});
            this.gvSPK.GridControl = this.gcSPK;
            this.gvSPK.Name = "gvSPK";
            this.gvSPK.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSPK.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSPK.OptionsBehavior.AutoPopulateColumns = false;
            this.gvSPK.OptionsBehavior.Editable = false;
            this.gvSPK.OptionsBehavior.ReadOnly = true;
            this.gvSPK.OptionsCustomization.AllowColumnMoving = false;
            this.gvSPK.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvSPK.OptionsMenu.EnableFooterMenu = false;
            this.gvSPK.OptionsView.ShowDetailButtons = false;
            this.gvSPK.OptionsView.ShowFooter = true;
            this.gvSPK.OptionsView.ShowGroupPanel = false;
            this.gvSPK.OptionsView.ShowViewCaption = true;
            this.gvSPK.ViewCaption = "Daftar SPK";
            this.gvSPK.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvSPK_CustomColumnDisplayText);
            // 
            // gcSPK
            // 
            this.gcSPK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSPK.Location = new System.Drawing.Point(3, 138);
            this.gcSPK.MainView = this.gvSPK;
            this.gcSPK.Name = "gcSPK";
            this.gcSPK.Size = new System.Drawing.Size(1085, 303);
            this.gcSPK.TabIndex = 5;
            this.gcSPK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSPK});
            // 
            // groupFilter
            // 
            this.groupFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFilter.Controls.Add(this.btnExportToCSV);
            this.groupFilter.Controls.Add(this.txtDateFilterTo);
            this.groupFilter.Controls.Add(this.txtDateFilterFrom);
            this.groupFilter.Controls.Add(this.labelControl2);
            this.groupFilter.Controls.Add(this.lblFilterDate);
            this.groupFilter.Controls.Add(this.lookUpContractWorkStatus);
            this.groupFilter.Controls.Add(this.lblContractWork);
            this.groupFilter.Controls.Add(this.txtLicenseNumber);
            this.groupFilter.Controls.Add(this.lblLicenseNumber);
            this.groupFilter.Controls.Add(this.lookUpCustomer);
            this.groupFilter.Controls.Add(this.lblApprovalStatus);
            this.groupFilter.Controls.Add(this.lookUpCategory);
            this.groupFilter.Controls.Add(this.txtCode);
            this.groupFilter.Controls.Add(this.lblCode);
            this.groupFilter.Controls.Add(this.btnSearch);
            this.groupFilter.Controls.Add(this.lblCategory);
            this.groupFilter.Location = new System.Drawing.Point(3, 3);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(1085, 129);
            this.groupFilter.TabIndex = 3;
            this.groupFilter.Text = "Filter";
            // 
            // btnExportToCSV
            // 
            this.btnExportToCSV.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.export3_16x16;
            this.btnExportToCSV.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnExportToCSV.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExportToCSV.Location = new System.Drawing.Point(716, 73);
            this.btnExportToCSV.Name = "btnExportToCSV";
            this.btnExportToCSV.Size = new System.Drawing.Size(101, 44);
            this.btnExportToCSV.TabIndex = 32;
            this.btnExportToCSV.Text = "Export Data";
            this.btnExportToCSV.Click += new System.EventHandler(this.btnExportToCSV_Click);
            // 
            // txtDateFilterTo
            // 
            this.txtDateFilterTo.EditValue = null;
            this.txtDateFilterTo.Location = new System.Drawing.Point(286, 25);
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
            this.txtDateFilterTo.TabIndex = 21;
            // 
            // txtDateFilterFrom
            // 
            this.txtDateFilterFrom.EditValue = null;
            this.txtDateFilterFrom.Location = new System.Drawing.Point(109, 25);
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
            this.txtDateFilterFrom.Size = new System.Drawing.Size(141, 20);
            this.txtDateFilterFrom.TabIndex = 20;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(261, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(15, 13);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "s/d";
            // 
            // lblFilterDate
            // 
            this.lblFilterDate.Location = new System.Drawing.Point(8, 28);
            this.lblFilterDate.Name = "lblFilterDate";
            this.lblFilterDate.Size = new System.Drawing.Size(70, 13);
            this.lblFilterDate.TabIndex = 15;
            this.lblFilterDate.Text = "Tanggal Servis";
            // 
            // lookUpContractWorkStatus
            // 
            this.lookUpContractWorkStatus.Location = new System.Drawing.Point(524, 91);
            this.lookUpContractWorkStatus.Name = "lookUpContractWorkStatus";
            this.lookUpContractWorkStatus.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpContractWorkStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpContractWorkStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Status")});
            this.lookUpContractWorkStatus.Properties.DisplayMember = "Description";
            this.lookUpContractWorkStatus.Properties.HideSelection = false;
            this.lookUpContractWorkStatus.Properties.NullText = "";
            this.lookUpContractWorkStatus.Properties.ValueMember = "Status";
            this.lookUpContractWorkStatus.Size = new System.Drawing.Size(141, 20);
            this.lookUpContractWorkStatus.TabIndex = 13;
            // 
            // lblContractWork
            // 
            this.lblContractWork.Location = new System.Drawing.Point(458, 94);
            this.lblContractWork.Name = "lblContractWork";
            this.lblContractWork.Size = new System.Drawing.Size(46, 13);
            this.lblContractWork.TabIndex = 12;
            this.lblContractWork.Text = "Borongan";
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Location = new System.Drawing.Point(109, 87);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Size = new System.Drawing.Size(141, 20);
            this.txtLicenseNumber.TabIndex = 3;
            // 
            // lblLicenseNumber
            // 
            this.lblLicenseNumber.Location = new System.Drawing.Point(8, 94);
            this.lblLicenseNumber.Name = "lblLicenseNumber";
            this.lblLicenseNumber.Size = new System.Drawing.Size(76, 13);
            this.lblLicenseNumber.TabIndex = 2;
            this.lblLicenseNumber.Text = "Nopol Kendaran";
            // 
            // lookUpCustomer
            // 
            this.lookUpCustomer.Location = new System.Drawing.Point(524, 25);
            this.lookUpCustomer.Name = "lookUpCustomer";
            this.lookUpCustomer.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCustomer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Customer")});
            this.lookUpCustomer.Properties.DisplayMember = "CompanyName";
            this.lookUpCustomer.Properties.HideSelection = false;
            this.lookUpCustomer.Properties.NullText = "-- Pilih Customer --";
            this.lookUpCustomer.Properties.ValueMember = "Id";
            this.lookUpCustomer.Size = new System.Drawing.Size(141, 20);
            this.lookUpCustomer.TabIndex = 7;
            // 
            // lblApprovalStatus
            // 
            this.lblApprovalStatus.Location = new System.Drawing.Point(458, 28);
            this.lblApprovalStatus.Name = "lblApprovalStatus";
            this.lblApprovalStatus.Size = new System.Drawing.Size(46, 13);
            this.lblApprovalStatus.TabIndex = 6;
            this.lblApprovalStatus.Text = "Customer";
            // 
            // lookUpCategory
            // 
            this.lookUpCategory.Location = new System.Drawing.Point(524, 59);
            this.lookUpCategory.Name = "lookUpCategory";
            this.lookUpCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookUpCategory.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Kategori")});
            this.lookUpCategory.Properties.DisplayMember = "Name";
            this.lookUpCategory.Properties.HideSelection = false;
            this.lookUpCategory.Properties.NullText = "-- Pilih Kategori --";
            this.lookUpCategory.Properties.ValueMember = "Id";
            this.lookUpCategory.Size = new System.Drawing.Size(141, 20);
            this.lookUpCategory.TabIndex = 5;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(109, 57);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(141, 20);
            this.txtCode.TabIndex = 1;
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(8, 62);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(45, 13);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Kode SPK";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(715, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 44);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(458, 62);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(40, 13);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Kategori";
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
            // SPKHistoryListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupFilter);
            this.Controls.Add(this.gcSPK);
            this.Name = "SPKHistoryListControl";
            this.Size = new System.Drawing.Size(1091, 444);
            this.cmsEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSPK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSPK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupFilter)).EndInit();
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpContractWorkStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLicenseNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusApproval;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusPrint;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusCompleted;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem viewDetailToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSPK;
        private DevExpress.XtraGrid.GridControl gcSPK;
        private DevExpress.XtraEditors.GroupControl groupFilter;
        private DevExpress.XtraEditors.LookUpEdit lookUpContractWorkStatus;
        private DevExpress.XtraEditors.LabelControl lblContractWork;
        private DevExpress.XtraEditors.TextEdit txtLicenseNumber;
        private DevExpress.XtraEditors.LabelControl lblLicenseNumber;
        private DevExpress.XtraEditors.LookUpEdit lookUpCustomer;
        private DevExpress.XtraEditors.LabelControl lblApprovalStatus;
        private DevExpress.XtraEditors.LookUpEdit lookUpCategory;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl lblCode;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl lblCategory;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblFilterDate;
        private DevExpress.XtraEditors.DateEdit txtDateFilterTo;
        private DevExpress.XtraEditors.DateEdit txtDateFilterFrom;
        private DevExpress.XtraEditors.SimpleButton btnExportToCSV;
        private System.Windows.Forms.SaveFileDialog exportDialog;
        private System.ComponentModel.BackgroundWorker bgwExport;
    }
}
