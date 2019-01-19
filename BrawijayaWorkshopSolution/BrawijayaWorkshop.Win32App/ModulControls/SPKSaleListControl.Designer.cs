namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class SPKSaleListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPKSaleListControl));
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.btnNewSale = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDateFilterTo = new DevExpress.XtraEditors.DateEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtDateFilterFrom = new DevExpress.XtraEditors.DateEdit();
            this.lblFilterDate = new DevExpress.XtraEditors.LabelControl();
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnExportToCSV = new DevExpress.XtraEditors.SimpleButton();
            this.gcSPKSales = new DevExpress.XtraGrid.GridControl();
            this.gvSPKSales = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLicenseNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.exportDialog = new System.Windows.Forms.SaveFileDialog();
            this.bgwExport = new System.ComponentModel.BackgroundWorker();
            this.cmsEditData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEndorseData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSPKApproval = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRollback = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsPrintData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRequestPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPrintApproval = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSetAsCompleted = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAbort = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSPKSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSPKSales)).BeginInit();
            this.cmsEditData.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // btnNewSale
            // 
            this.btnNewSale.Image = ((System.Drawing.Image)(resources.GetObject("btnNewSale.Image")));
            this.btnNewSale.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewSale.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewSale.Location = new System.Drawing.Point(3, 73);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(144, 23);
            this.btnNewSale.TabIndex = 6;
            this.btnNewSale.Text = "Buat Penjualan Baru";
            this.btnNewSale.Click += new System.EventHandler(this.btnNewSale_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(278, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(4, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "-";
            // 
            // txtDateFilterTo
            // 
            this.txtDateFilterTo.EditValue = null;
            this.txtDateFilterTo.Location = new System.Drawing.Point(288, 31);
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
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(432, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDateFilterFrom
            // 
            this.txtDateFilterFrom.EditValue = null;
            this.txtDateFilterFrom.Location = new System.Drawing.Point(134, 31);
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
            this.lblFilterDate.Size = new System.Drawing.Size(88, 13);
            this.lblFilterDate.TabIndex = 1;
            this.lblFilterDate.Text = "Tanggal Penjualan";
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.btnExportToCSV);
            this.gcFilter.Controls.Add(this.labelControl1);
            this.gcFilter.Controls.Add(this.txtDateFilterTo);
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.txtDateFilterFrom);
            this.gcFilter.Controls.Add(this.lblFilterDate);
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(632, 64);
            this.gcFilter.TabIndex = 5;
            this.gcFilter.Text = "Filter";
            // 
            // btnExportToCSV
            // 
            this.btnExportToCSV.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.export3_16x16;
            this.btnExportToCSV.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnExportToCSV.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExportToCSV.Location = new System.Drawing.Point(507, 29);
            this.btnExportToCSV.Name = "btnExportToCSV";
            this.btnExportToCSV.Size = new System.Drawing.Size(106, 23);
            this.btnExportToCSV.TabIndex = 32;
            this.btnExportToCSV.Text = "Export Data";
            this.btnExportToCSV.Click += new System.EventHandler(this.btnExportToCSV_Click);
            // 
            // gcSPKSales
            // 
            this.gcSPKSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSPKSales.Location = new System.Drawing.Point(3, 102);
            this.gcSPKSales.MainView = this.gvSPKSales;
            this.gcSPKSales.Name = "gcSPKSales";
            this.gcSPKSales.Size = new System.Drawing.Size(632, 210);
            this.gcSPKSales.TabIndex = 7;
            this.gcSPKSales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSPKSales});
            // 
            // gvSPKSales
            // 
            this.gvSPKSales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCreateDate,
            this.colCode,
            this.colLicenseNumber,
            this.colTotalPrice});
            this.gvSPKSales.GridControl = this.gcSPKSales;
            this.gvSPKSales.Name = "gvSPKSales";
            this.gvSPKSales.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSPKSales.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSPKSales.OptionsBehavior.AutoPopulateColumns = false;
            this.gvSPKSales.OptionsBehavior.Editable = false;
            this.gvSPKSales.OptionsBehavior.ReadOnly = true;
            this.gvSPKSales.OptionsCustomization.AllowColumnMoving = false;
            this.gvSPKSales.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvSPKSales.OptionsMenu.EnableFooterMenu = false;
            this.gvSPKSales.OptionsView.ShowDetailButtons = false;
            this.gvSPKSales.OptionsView.ShowFooter = true;
            this.gvSPKSales.OptionsView.ShowGroupPanel = false;
            this.gvSPKSales.OptionsView.ShowViewCaption = true;
            this.gvSPKSales.ViewCaption = "Daftar SPK";
            // 
            // colCreateDate
            // 
            this.colCreateDate.Caption = "Tanggal Pembuatan";
            this.colCreateDate.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colCreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 0;
            // 
            // colCode
            // 
            this.colCode.Caption = "Kode";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            // 
            // colLicenseNumber
            // 
            this.colLicenseNumber.Caption = "Nopol";
            this.colLicenseNumber.FieldName = "Vehicle.ActiveLicenseNumber";
            this.colLicenseNumber.Name = "colLicenseNumber";
            this.colLicenseNumber.Visible = true;
            this.colLicenseNumber.VisibleIndex = 2;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "Total Harga Sparepart";
            this.colTotalPrice.DisplayFormat.FormatString = "{0:#,#;0}";
            this.colTotalPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalPrice.FieldName = "TotalSparepartPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 3;
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
            // cmsEditData
            // 
            this.cmsEditData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDetailToolStripMenuItem,
            this.cmsEndorseData,
            this.cmsSPKApproval,
            this.cmsRollback,
            this.toolStripSeparator1,
            this.cmsPrintData,
            this.cmsRequestPrint,
            this.cmsPrintApproval,
            this.cmsSetAsCompleted,
            this.cmsAbort});
            this.cmsEditData.Name = "cmsListEditor";
            this.cmsEditData.Size = new System.Drawing.Size(172, 230);
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
            // cmsRollback
            // 
            this.cmsRollback.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources._1459465829_refresh;
            this.cmsRollback.Name = "cmsRollback";
            this.cmsRollback.Size = new System.Drawing.Size(171, 22);
            this.cmsRollback.Text = "Rollback";
            this.cmsRollback.Click += new System.EventHandler(this.cmsRollback_Click);
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
            // SPKSaleListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcSPKSales);
            this.Controls.Add(this.btnNewSale);
            this.Controls.Add(this.gcFilter);
            this.Name = "SPKSaleListControl";
            this.Size = new System.Drawing.Size(638, 315);
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSPKSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSPKSales)).EndInit();
            this.cmsEditData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgwMain;
        private DevExpress.XtraEditors.SimpleButton btnNewSale;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtDateFilterTo;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.DateEdit txtDateFilterFrom;
        private DevExpress.XtraEditors.LabelControl lblFilterDate;
        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraGrid.GridControl gcSPKSales;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSPKSales;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colLicenseNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraEditors.SimpleButton btnExportToCSV;
        private System.Windows.Forms.SaveFileDialog exportDialog;
        private System.ComponentModel.BackgroundWorker bgwExport;
        private System.Windows.Forms.ContextMenuStrip cmsEditData;
        private System.Windows.Forms.ToolStripMenuItem viewDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmsEndorseData;
        private System.Windows.Forms.ToolStripMenuItem cmsSPKApproval;
        private System.Windows.Forms.ToolStripMenuItem cmsRollback;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmsPrintData;
        private System.Windows.Forms.ToolStripMenuItem cmsRequestPrint;
        private System.Windows.Forms.ToolStripMenuItem cmsPrintApproval;
        private System.Windows.Forms.ToolStripMenuItem cmsSetAsCompleted;
        private System.Windows.Forms.ToolStripMenuItem cmsAbort;

    }
}
