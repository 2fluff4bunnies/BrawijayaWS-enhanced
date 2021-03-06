﻿namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class ManualTransactionListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualTransactionListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.deTo = new DevExpress.XtraEditors.DateEdit();
            this.lblDateFilterTo = new DevExpress.XtraEditors.LabelControl();
            this.deFrom = new DevExpress.XtraEditors.DateEdit();
            this.lblDateFilter = new DevExpress.XtraEditors.LabelControl();
            this.btnNewTransaction = new DevExpress.XtraEditors.SimpleButton();
            this.gridManualTransaction = new DevExpress.XtraGrid.GridControl();
            this.gvManualTransaction = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportToCSV = new DevExpress.XtraEditors.SimpleButton();
            this.exportDialog = new System.Windows.Forms.SaveFileDialog();
            this.bgwExport = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridManualTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvManualTransaction)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.btnExportToCSV);
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.deTo);
            this.gcFilter.Controls.Add(this.lblDateFilterTo);
            this.gcFilter.Controls.Add(this.deFrom);
            this.gcFilter.Controls.Add(this.lblDateFilter);
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(696, 64);
            this.gcFilter.TabIndex = 0;
            this.gcFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(373, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // deTo
            // 
            this.deTo.EditValue = null;
            this.deTo.Location = new System.Drawing.Point(250, 30);
            this.deTo.Name = "deTo";
            this.deTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTo.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.deTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deTo.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.deTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deTo.Properties.HideSelection = false;
            this.deTo.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.deTo.Properties.NullDate = "";
            this.deTo.Properties.NullText = "-- Pilih Tanggal --";
            this.deTo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deTo.Size = new System.Drawing.Size(106, 20);
            this.deTo.TabIndex = 3;
            // 
            // lblDateFilterTo
            // 
            this.lblDateFilterTo.Location = new System.Drawing.Point(240, 33);
            this.lblDateFilterTo.Name = "lblDateFilterTo";
            this.lblDateFilterTo.Size = new System.Drawing.Size(4, 13);
            this.lblDateFilterTo.TabIndex = 2;
            this.lblDateFilterTo.Text = "-";
            // 
            // deFrom
            // 
            this.deFrom.EditValue = null;
            this.deFrom.Location = new System.Drawing.Point(128, 30);
            this.deFrom.Name = "deFrom";
            this.deFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFrom.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.deFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deFrom.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.deFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deFrom.Properties.HideSelection = false;
            this.deFrom.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.deFrom.Properties.NullDate = "";
            this.deFrom.Properties.NullText = "-- Pilih Tanggal --";
            this.deFrom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deFrom.Size = new System.Drawing.Size(106, 20);
            this.deFrom.TabIndex = 1;
            // 
            // lblDateFilter
            // 
            this.lblDateFilter.Location = new System.Drawing.Point(12, 33);
            this.lblDateFilter.Name = "lblDateFilter";
            this.lblDateFilter.Size = new System.Drawing.Size(86, 13);
            this.lblDateFilter.TabIndex = 0;
            this.lblDateFilter.Text = "Tanggal Transaksi";
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnNewTransaction.Image")));
            this.btnNewTransaction.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewTransaction.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewTransaction.Location = new System.Drawing.Point(3, 73);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(144, 23);
            this.btnNewTransaction.TabIndex = 3;
            this.btnNewTransaction.Text = "Buat Transaksi Baru";
            this.btnNewTransaction.Click += new System.EventHandler(this.btnNewTransaction_Click);
            // 
            // gridManualTransaction
            // 
            this.gridManualTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridManualTransaction.Location = new System.Drawing.Point(3, 102);
            this.gridManualTransaction.MainView = this.gvManualTransaction;
            this.gridManualTransaction.Name = "gridManualTransaction";
            this.gridManualTransaction.Size = new System.Drawing.Size(696, 255);
            this.gridManualTransaction.TabIndex = 4;
            this.gridManualTransaction.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvManualTransaction});
            // 
            // gvManualTransaction
            // 
            this.gvManualTransaction.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransDate,
            this.colTransAmount,
            this.colTransDescription});
            this.gvManualTransaction.GridControl = this.gridManualTransaction;
            this.gvManualTransaction.Name = "gvManualTransaction";
            this.gvManualTransaction.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvManualTransaction.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvManualTransaction.OptionsBehavior.AutoPopulateColumns = false;
            this.gvManualTransaction.OptionsBehavior.Editable = false;
            this.gvManualTransaction.OptionsBehavior.ReadOnly = true;
            this.gvManualTransaction.OptionsCustomization.AllowColumnMoving = false;
            this.gvManualTransaction.OptionsCustomization.AllowFilter = false;
            this.gvManualTransaction.OptionsCustomization.AllowGroup = false;
            this.gvManualTransaction.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvManualTransaction.OptionsView.EnableAppearanceEvenRow = true;
            this.gvManualTransaction.OptionsView.ShowGroupPanel = false;
            this.gvManualTransaction.OptionsView.ShowViewCaption = true;
            this.gvManualTransaction.ViewCaption = "Daftar Transaksi Manual";
            // 
            // colTransDate
            // 
            this.colTransDate.Caption = "Tanggal";
            this.colTransDate.DisplayFormat.FormatString = "dd MMM yyyy";
            this.colTransDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTransDate.FieldName = "TransactionDate";
            this.colTransDate.Name = "colTransDate";
            this.colTransDate.Visible = true;
            this.colTransDate.VisibleIndex = 0;
            // 
            // colTransAmount
            // 
            this.colTransAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colTransAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTransAmount.Caption = "Jumlah";
            this.colTransAmount.DisplayFormat.FormatString = "{0:#,#;0}";
            this.colTransAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTransAmount.FieldName = "TotalTransaction";
            this.colTransAmount.Name = "colTransAmount";
            this.colTransAmount.Visible = true;
            this.colTransAmount.VisibleIndex = 1;
            // 
            // colTransDescription
            // 
            this.colTransDescription.Caption = "Keterangan";
            this.colTransDescription.FieldName = "Description";
            this.colTransDescription.Name = "colTransDescription";
            this.colTransDescription.Visible = true;
            this.colTransDescription.VisibleIndex = 2;
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
            this.cmsDeleteData});
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(136, 48);
            // 
            // cmsEditData
            // 
            this.cmsEditData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.cmsEditData.Name = "cmsEditData";
            this.cmsEditData.Size = new System.Drawing.Size(135, 22);
            this.cmsEditData.Text = "Ubah Data";
            this.cmsEditData.Click += new System.EventHandler(this.cmsEditData_Click);
            // 
            // cmsDeleteData
            // 
            this.cmsDeleteData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.cmsDeleteData.Name = "cmsDeleteData";
            this.cmsDeleteData.Size = new System.Drawing.Size(135, 22);
            this.cmsDeleteData.Text = "Hapus Data";
            this.cmsDeleteData.Click += new System.EventHandler(this.cmsDeleteData_Click);
            // 
            // btnExportToCSV
            // 
            this.btnExportToCSV.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.export3_16x16;
            this.btnExportToCSV.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnExportToCSV.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExportToCSV.Location = new System.Drawing.Point(447, 28);
            this.btnExportToCSV.Name = "btnExportToCSV";
            this.btnExportToCSV.Size = new System.Drawing.Size(106, 23);
            this.btnExportToCSV.TabIndex = 32;
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
            // ManualTransactionListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridManualTransaction);
            this.Controls.Add(this.btnNewTransaction);
            this.Controls.Add(this.gcFilter);
            this.Name = "ManualTransactionListControl";
            this.Size = new System.Drawing.Size(702, 360);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridManualTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvManualTransaction)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.DateEdit deTo;
        private DevExpress.XtraEditors.LabelControl lblDateFilterTo;
        private DevExpress.XtraEditors.DateEdit deFrom;
        private DevExpress.XtraEditors.LabelControl lblDateFilter;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnNewTransaction;
        private DevExpress.XtraGrid.GridControl gridManualTransaction;
        private DevExpress.XtraGrid.Views.Grid.GridView gvManualTransaction;
        private DevExpress.XtraGrid.Columns.GridColumn colTransDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTransAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTransDescription;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
        private DevExpress.XtraEditors.SimpleButton btnExportToCSV;
        private System.Windows.Forms.SaveFileDialog exportDialog;
        private System.ComponentModel.BackgroundWorker bgwExport;
    }
}
