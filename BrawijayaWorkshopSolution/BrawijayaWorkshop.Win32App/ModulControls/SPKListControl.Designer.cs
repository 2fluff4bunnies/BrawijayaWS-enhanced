namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class SPKListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPKListControl));
            this.groupFilter = new DevExpress.XtraEditors.GroupControl();
            this.lookUpContractWorkStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.lblContractWork = new DevExpress.XtraEditors.LabelControl();
            this.lblCompletedStatus = new DevExpress.XtraEditors.LabelControl();
            this.lookUpCompletedStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.lblPrintStatus = new DevExpress.XtraEditors.LabelControl();
            this.lookUpPrintStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.txtLicenseNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblLicenseNumber = new DevExpress.XtraEditors.LabelControl();
            this.lookUpApprovalStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.lblApprovalStatus = new DevExpress.XtraEditors.LabelControl();
            this.lookUpCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.lblCode = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lblCategory = new DevExpress.XtraEditors.LabelControl();
            this.btnNewSPK = new DevExpress.XtraEditors.SimpleButton();
            this.gcSPK = new DevExpress.XtraGrid.GridControl();
            this.gvSPK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLicenseNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusApproval = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusPrint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusCompleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEndorseData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSPKApproval = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsPrintData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRequestPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPrintApproval = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSetAsCompleted = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAbort = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.txtDateFilterTo = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDateFilterFrom = new DevExpress.XtraEditors.DateEdit();
            this.lblFilterDate = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupFilter)).BeginInit();
            this.groupFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpContractWorkStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCompletedStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrintStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpApprovalStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSPK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSPK)).BeginInit();
            this.cmsEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupFilter
            // 
            this.groupFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFilter.Controls.Add(this.txtDateFilterTo);
            this.groupFilter.Controls.Add(this.labelControl1);
            this.groupFilter.Controls.Add(this.txtDateFilterFrom);
            this.groupFilter.Controls.Add(this.lblFilterDate);
            this.groupFilter.Controls.Add(this.lookUpContractWorkStatus);
            this.groupFilter.Controls.Add(this.lblContractWork);
            this.groupFilter.Controls.Add(this.lblCompletedStatus);
            this.groupFilter.Controls.Add(this.lookUpCompletedStatus);
            this.groupFilter.Controls.Add(this.lblPrintStatus);
            this.groupFilter.Controls.Add(this.lookUpPrintStatus);
            this.groupFilter.Controls.Add(this.txtLicenseNumber);
            this.groupFilter.Controls.Add(this.lblLicenseNumber);
            this.groupFilter.Controls.Add(this.lookUpApprovalStatus);
            this.groupFilter.Controls.Add(this.lblApprovalStatus);
            this.groupFilter.Controls.Add(this.lookUpCategory);
            this.groupFilter.Controls.Add(this.txtCode);
            this.groupFilter.Controls.Add(this.lblCode);
            this.groupFilter.Controls.Add(this.btnSearch);
            this.groupFilter.Controls.Add(this.lblCategory);
            this.groupFilter.Location = new System.Drawing.Point(3, 3);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(1085, 128);
            this.groupFilter.TabIndex = 0;
            this.groupFilter.Text = "Filter";
            // 
            // lookUpContractWorkStatus
            // 
            this.lookUpContractWorkStatus.Location = new System.Drawing.Point(730, 64);
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
            this.lblContractWork.Location = new System.Drawing.Point(672, 67);
            this.lblContractWork.Name = "lblContractWork";
            this.lblContractWork.Size = new System.Drawing.Size(46, 13);
            this.lblContractWork.TabIndex = 12;
            this.lblContractWork.Text = "Borongan";
            // 
            // lblCompletedStatus
            // 
            this.lblCompletedStatus.Location = new System.Drawing.Point(393, 98);
            this.lblCompletedStatus.Name = "lblCompletedStatus";
            this.lblCompletedStatus.Size = new System.Drawing.Size(89, 13);
            this.lblCompletedStatus.TabIndex = 16;
            this.lblCompletedStatus.Text = "Status Pengerjaan";
            // 
            // lookUpCompletedStatus
            // 
            this.lookUpCompletedStatus.Location = new System.Drawing.Point(488, 95);
            this.lookUpCompletedStatus.Name = "lookUpCompletedStatus";
            this.lookUpCompletedStatus.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpCompletedStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCompletedStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Status")});
            this.lookUpCompletedStatus.Properties.DisplayMember = "Description";
            this.lookUpCompletedStatus.Properties.HideSelection = false;
            this.lookUpCompletedStatus.Properties.NullText = "-- Status --";
            this.lookUpCompletedStatus.Properties.ValueMember = "Status";
            this.lookUpCompletedStatus.Size = new System.Drawing.Size(141, 20);
            this.lookUpCompletedStatus.TabIndex = 17;
            // 
            // lblPrintStatus
            // 
            this.lblPrintStatus.Location = new System.Drawing.Point(393, 67);
            this.lblPrintStatus.Name = "lblPrintStatus";
            this.lblPrintStatus.Size = new System.Drawing.Size(56, 13);
            this.lblPrintStatus.TabIndex = 10;
            this.lblPrintStatus.Text = "Status Print";
            // 
            // lookUpPrintStatus
            // 
            this.lookUpPrintStatus.Location = new System.Drawing.Point(488, 64);
            this.lookUpPrintStatus.Name = "lookUpPrintStatus";
            this.lookUpPrintStatus.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpPrintStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpPrintStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Status")});
            this.lookUpPrintStatus.Properties.DisplayMember = "Description";
            this.lookUpPrintStatus.Properties.HideSelection = false;
            this.lookUpPrintStatus.Properties.NullText = "-- Status --";
            this.lookUpPrintStatus.Properties.ValueMember = "Status";
            this.lookUpPrintStatus.Size = new System.Drawing.Size(141, 20);
            this.lookUpPrintStatus.TabIndex = 11;
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Location = new System.Drawing.Point(110, 64);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Size = new System.Drawing.Size(141, 20);
            this.txtLicenseNumber.TabIndex = 9;
            // 
            // lblLicenseNumber
            // 
            this.lblLicenseNumber.Location = new System.Drawing.Point(12, 67);
            this.lblLicenseNumber.Name = "lblLicenseNumber";
            this.lblLicenseNumber.Size = new System.Drawing.Size(76, 13);
            this.lblLicenseNumber.TabIndex = 8;
            this.lblLicenseNumber.Text = "Nopol Kendaran";
            // 
            // lookUpApprovalStatus
            // 
            this.lookUpApprovalStatus.Location = new System.Drawing.Point(110, 95);
            this.lookUpApprovalStatus.Name = "lookUpApprovalStatus";
            this.lookUpApprovalStatus.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpApprovalStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpApprovalStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Status")});
            this.lookUpApprovalStatus.Properties.DisplayMember = "Description";
            this.lookUpApprovalStatus.Properties.HideSelection = false;
            this.lookUpApprovalStatus.Properties.NullText = "-- Status --";
            this.lookUpApprovalStatus.Properties.ValueMember = "Status";
            this.lookUpApprovalStatus.Size = new System.Drawing.Size(141, 20);
            this.lookUpApprovalStatus.TabIndex = 15;
            // 
            // lblApprovalStatus
            // 
            this.lblApprovalStatus.Location = new System.Drawing.Point(12, 98);
            this.lblApprovalStatus.Name = "lblApprovalStatus";
            this.lblApprovalStatus.Size = new System.Drawing.Size(92, 13);
            this.lblApprovalStatus.TabIndex = 14;
            this.lblApprovalStatus.Text = "Status Persetujuan";
            // 
            // lookUpCategory
            // 
            this.lookUpCategory.Location = new System.Drawing.Point(730, 30);
            this.lookUpCategory.Name = "lookUpCategory";
            this.lookUpCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookUpCategory.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Kategori")});
            this.lookUpCategory.Properties.DisplayMember = "Name";
            this.lookUpCategory.Properties.HideSelection = false;
            this.lookUpCategory.Properties.NullText = "-- Kategori --";
            this.lookUpCategory.Properties.ValueMember = "Id";
            this.lookUpCategory.Size = new System.Drawing.Size(141, 20);
            this.lookUpCategory.TabIndex = 7;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(488, 30);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(141, 20);
            this.txtCode.TabIndex = 5;
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(393, 33);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(45, 13);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Kode SPK";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(891, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 86);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(672, 33);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(40, 13);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Kategori";
            // 
            // btnNewSPK
            // 
            this.btnNewSPK.Image = ((System.Drawing.Image)(resources.GetObject("btnNewSPK.Image")));
            this.btnNewSPK.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewSPK.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewSPK.Location = new System.Drawing.Point(3, 137);
            this.btnNewSPK.Name = "btnNewSPK";
            this.btnNewSPK.Size = new System.Drawing.Size(103, 23);
            this.btnNewSPK.TabIndex = 1;
            this.btnNewSPK.Text = "Buat SPK Baru";
            this.btnNewSPK.Click += new System.EventHandler(this.btnNewSPK_Click);
            // 
            // gcSPK
            // 
            this.gcSPK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSPK.Location = new System.Drawing.Point(3, 166);
            this.gcSPK.MainView = this.gvSPK;
            this.gcSPK.Name = "gcSPK";
            this.gcSPK.Size = new System.Drawing.Size(1085, 275);
            this.gcSPK.TabIndex = 2;
            this.gcSPK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSPK});
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
            // colCode
            // 
            this.colCode.Caption = "Kode";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
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
            this.viewDetailToolStripMenuItem,
            this.cmsEndorseData,
            this.cmsSPKApproval,
            this.toolStripSeparator1,
            this.cmsPrintData,
            this.cmsRequestPrint,
            this.cmsPrintApproval,
            this.cmsSetAsCompleted,
            this.cmsAbort});
            this.cmsEditor.Name = "cmsListEditor";
            this.cmsEditor.Size = new System.Drawing.Size(172, 186);
            // 
            // viewDetailToolStripMenuItem
            // 
            this.viewDetailToolStripMenuItem.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.zoom_icon;
            this.viewDetailToolStripMenuItem.Name = "viewDetailToolStripMenuItem";
            this.viewDetailToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.viewDetailToolStripMenuItem.Text = "Lihat Detail";
            this.viewDetailToolStripMenuItem.Click += new System.EventHandler(this.viewDetailToolStripMenuItem_Click);
            // 
            // cmsEndorseData
            // 
            this.cmsEndorseData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.cmsEndorseData.Name = "cmsEndorseData";
            this.cmsEndorseData.Size = new System.Drawing.Size(171, 22);
            this.cmsEndorseData.Text = "Revisi";
            this.cmsEndorseData.Click += new System.EventHandler(this.cmsEndorseData_Click);
            // 
            // cmsSPKApproval
            // 
            this.cmsSPKApproval.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.approve_16x16;
            this.cmsSPKApproval.Name = "cmsSPKApproval";
            this.cmsSPKApproval.Size = new System.Drawing.Size(171, 22);
            this.cmsSPKApproval.Text = "Persetujuan SPK";
            this.cmsSPKApproval.Click += new System.EventHandler(this.cmsSPKApproval_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // cmsPrintData
            // 
            this.cmsPrintData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.print_16x16;
            this.cmsPrintData.Name = "cmsPrintData";
            this.cmsPrintData.Size = new System.Drawing.Size(171, 22);
            this.cmsPrintData.Text = "Print";
            this.cmsPrintData.Click += new System.EventHandler(this.cmsPrintData_Click);
            // 
            // cmsRequestPrint
            // 
            this.cmsRequestPrint.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.print_16x16;
            this.cmsRequestPrint.Name = "cmsRequestPrint";
            this.cmsRequestPrint.Size = new System.Drawing.Size(171, 22);
            this.cmsRequestPrint.Text = "Permohonan Print";
            this.cmsRequestPrint.Click += new System.EventHandler(this.cmsRequestPrint_Click);
            // 
            // cmsPrintApproval
            // 
            this.cmsPrintApproval.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.approve_16x16;
            this.cmsPrintApproval.Name = "cmsPrintApproval";
            this.cmsPrintApproval.Size = new System.Drawing.Size(171, 22);
            this.cmsPrintApproval.Text = "Persetujuan Print";
            this.cmsPrintApproval.Click += new System.EventHandler(this.cmsPrintApproval_Click);
            // 
            // cmsSetAsCompleted
            // 
            this.cmsSetAsCompleted.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.completed_16x16;
            this.cmsSetAsCompleted.Name = "cmsSetAsCompleted";
            this.cmsSetAsCompleted.Size = new System.Drawing.Size(171, 22);
            this.cmsSetAsCompleted.Text = "Set SPK Selesai";
            this.cmsSetAsCompleted.Click += new System.EventHandler(this.cmsSetAsCompleted_Click);
            // 
            // cmsAbort
            // 
            this.cmsAbort.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.cmsAbort.Name = "cmsAbort";
            this.cmsAbort.Size = new System.Drawing.Size(171, 22);
            this.cmsAbort.Text = "Batalkan";
            this.cmsAbort.Click += new System.EventHandler(this.cmsAbort_Click);
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // txtDateFilterTo
            // 
            this.txtDateFilterTo.EditValue = null;
            this.txtDateFilterTo.Location = new System.Drawing.Point(245, 30);
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
            this.txtDateFilterTo.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(235, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(4, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "-";
            // 
            // txtDateFilterFrom
            // 
            this.txtDateFilterFrom.EditValue = null;
            this.txtDateFilterFrom.Location = new System.Drawing.Point(110, 30);
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
            this.txtDateFilterFrom.TabIndex = 1;
            // 
            // lblFilterDate
            // 
            this.lblFilterDate.Location = new System.Drawing.Point(12, 33);
            this.lblFilterDate.Name = "lblFilterDate";
            this.lblFilterDate.Size = new System.Drawing.Size(63, 13);
            this.lblFilterDate.TabIndex = 0;
            this.lblFilterDate.Text = "Tanggal SPK:";
            // 
            // SPKListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcSPK);
            this.Controls.Add(this.btnNewSPK);
            this.Controls.Add(this.groupFilter);
            this.Name = "SPKListControl";
            this.Size = new System.Drawing.Size(1091, 444);
            ((System.ComponentModel.ISupportInitialize)(this.groupFilter)).EndInit();
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpContractWorkStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCompletedStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrintStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpApprovalStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSPK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSPK)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupFilter;
        private DevExpress.XtraEditors.LookUpEdit lookUpCategory;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl lblCode;
        private DevExpress.XtraEditors.LabelControl lblCategory;
        private DevExpress.XtraEditors.SimpleButton btnNewSPK;
        private DevExpress.XtraGrid.GridControl gcSPK;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSPK;
        private DevExpress.XtraEditors.TextEdit txtLicenseNumber;
        private DevExpress.XtraEditors.LabelControl lblLicenseNumber;
        private DevExpress.XtraEditors.LookUpEdit lookUpApprovalStatus;
        private DevExpress.XtraEditors.LabelControl lblApprovalStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLicenseNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem viewDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private DevExpress.XtraEditors.LookUpEdit lookUpPrintStatus;
        private DevExpress.XtraEditors.LabelControl lblPrintStatus;
        private System.Windows.Forms.ToolStripMenuItem cmsEndorseData;
        private System.Windows.Forms.ToolStripMenuItem cmsPrintData;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusApproval;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusPrint;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusCompleted;
        private System.Windows.Forms.ToolStripMenuItem cmsRequestPrint;
        private System.Windows.Forms.ToolStripMenuItem cmsAbort;
        private System.Windows.Forms.ToolStripMenuItem cmsSetAsCompleted;
        private DevExpress.XtraEditors.LabelControl lblCompletedStatus;
        private DevExpress.XtraEditors.LookUpEdit lookUpCompletedStatus;
        private System.Windows.Forms.ToolStripMenuItem cmsSPKApproval;
        private System.Windows.Forms.ToolStripMenuItem cmsPrintApproval;
        private DevExpress.XtraEditors.LookUpEdit lookUpContractWorkStatus;
        private DevExpress.XtraEditors.LabelControl lblContractWork;
        private DevExpress.XtraEditors.DateEdit txtDateFilterTo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtDateFilterFrom;
        private DevExpress.XtraEditors.LabelControl lblFilterDate;
    }
}
