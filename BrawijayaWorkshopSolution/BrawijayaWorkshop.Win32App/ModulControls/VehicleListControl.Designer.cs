﻿namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class VehicleListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnExportToCSV = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtFilter = new DevExpress.XtraEditors.TextEdit();
            this.lblFilterCompanyName = new DevExpress.XtraEditors.LabelControl();
            this.btnNewVehicle = new DevExpress.XtraEditors.SimpleButton();
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsUpdateLicenseNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsViewHistoryLicenseNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.gcVehicle = new DevExpress.XtraGrid.GridControl();
            this.gvVehicle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colActiveLicenseNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVehicleGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearOfPurchase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.exportDialog = new System.Windows.Forms.SaveFileDialog();
            this.bgwExport = new System.ComponentModel.BackgroundWorker();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnVehicleWheelSwap = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilter.Properties)).BeginInit();
            this.cmsEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.btnExportToCSV);
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.txtFilter);
            this.gcFilter.Controls.Add(this.lblFilterCompanyName);
            this.gcFilter.Location = new System.Drawing.Point(3, 4);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(877, 62);
            this.gcFilter.TabIndex = 6;
            this.gcFilter.Text = "Filter";
            // 
            // btnExportToCSV
            // 
            this.btnExportToCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToCSV.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.export3_16x16;
            this.btnExportToCSV.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnExportToCSV.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExportToCSV.Location = new System.Drawing.Point(766, 27);
            this.btnExportToCSV.Name = "btnExportToCSV";
            this.btnExportToCSV.Size = new System.Drawing.Size(106, 23);
            this.btnExportToCSV.TabIndex = 32;
            this.btnExportToCSV.Text = "Export Data";
            this.btnExportToCSV.Click += new System.EventHandler(this.btnExportToCSV_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(524, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(100, 30);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Properties.Mask.EditMask = "[a-zA-Z0-9\\-_]{0,40}";
            this.txtFilter.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtFilter.Size = new System.Drawing.Size(418, 20);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            // 
            // lblFilterCompanyName
            // 
            this.lblFilterCompanyName.Location = new System.Drawing.Point(12, 33);
            this.lblFilterCompanyName.Name = "lblFilterCompanyName";
            this.lblFilterCompanyName.Size = new System.Drawing.Size(57, 13);
            this.lblFilterCompanyName.TabIndex = 0;
            this.lblFilterCompanyName.Text = "Nomor Polisi";
            // 
            // btnNewVehicle
            // 
            this.btnNewVehicle.Image = ((System.Drawing.Image)(resources.GetObject("btnNewVehicle.Image")));
            this.btnNewVehicle.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewVehicle.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewVehicle.Location = new System.Drawing.Point(3, 72);
            this.btnNewVehicle.Name = "btnNewVehicle";
            this.btnNewVehicle.Size = new System.Drawing.Size(144, 23);
            this.btnNewVehicle.TabIndex = 8;
            this.btnNewVehicle.Text = "Buat Kendaraan Baru";
            this.btnNewVehicle.Click += new System.EventHandler(this.btnNewVehicle_Click);
            // 
            // cmsDeleteData
            // 
            this.cmsDeleteData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.cmsDeleteData.Name = "cmsDeleteData";
            this.cmsDeleteData.Size = new System.Drawing.Size(180, 22);
            this.cmsDeleteData.Text = "Hapus Data";
            this.cmsDeleteData.Click += new System.EventHandler(this.cmsDeleteData_Click);
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditData,
            this.cmsDeleteData,
            this.toolStripSeparator1,
            this.cmsUpdateLicenseNumber,
            this.cmsViewHistoryLicenseNumber});
            this.cmsEditor.Name = "cmsListEditor";
            this.cmsEditor.Size = new System.Drawing.Size(181, 98);
            // 
            // cmsEditData
            // 
            this.cmsEditData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.cmsEditData.Name = "cmsEditData";
            this.cmsEditData.Size = new System.Drawing.Size(180, 22);
            this.cmsEditData.Text = "Ubah Data";
            this.cmsEditData.Click += new System.EventHandler(this.cmsEditData_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // cmsUpdateLicenseNumber
            // 
            this.cmsUpdateLicenseNumber.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.license_16x16;
            this.cmsUpdateLicenseNumber.Name = "cmsUpdateLicenseNumber";
            this.cmsUpdateLicenseNumber.Size = new System.Drawing.Size(180, 22);
            this.cmsUpdateLicenseNumber.Text = "Update Nopol";
            this.cmsUpdateLicenseNumber.Click += new System.EventHandler(this.cmsUpdateLicenseNumber_Click);
            // 
            // cmsViewHistoryLicenseNumber
            // 
            this.cmsViewHistoryLicenseNumber.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.history_16x16;
            this.cmsViewHistoryLicenseNumber.Name = "cmsViewHistoryLicenseNumber";
            this.cmsViewHistoryLicenseNumber.Size = new System.Drawing.Size(180, 22);
            this.cmsViewHistoryLicenseNumber.Text = "Lihat Riwayat Nopol";
            this.cmsViewHistoryLicenseNumber.Click += new System.EventHandler(this.cmsViewHistoryLicenseNumber_Click);
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // gcVehicle
            // 
            this.gcVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcVehicle.Location = new System.Drawing.Point(3, 102);
            this.gcVehicle.MainView = this.gvVehicle;
            this.gcVehicle.Name = "gcVehicle";
            this.gcVehicle.Size = new System.Drawing.Size(877, 317);
            this.gcVehicle.TabIndex = 9;
            this.gcVehicle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVehicle});
            // 
            // gvVehicle
            // 
            this.gvVehicle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colActiveLicenseNumber,
            this.colCustomer,
            this.colVehicleGroup,
            this.colBrand,
            this.colType,
            this.colYearOfPurchase});
            this.gvVehicle.GridControl = this.gcVehicle;
            this.gvVehicle.Name = "gvVehicle";
            this.gvVehicle.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvVehicle.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvVehicle.OptionsBehavior.AutoPopulateColumns = false;
            this.gvVehicle.OptionsBehavior.Editable = false;
            this.gvVehicle.OptionsBehavior.ReadOnly = true;
            this.gvVehicle.OptionsCustomization.AllowColumnMoving = false;
            this.gvVehicle.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvVehicle.OptionsMenu.EnableFooterMenu = false;
            this.gvVehicle.OptionsView.EnableAppearanceEvenRow = true;
            this.gvVehicle.OptionsView.ShowFooter = true;
            this.gvVehicle.OptionsView.ShowGroupPanel = false;
            this.gvVehicle.OptionsView.ShowViewCaption = true;
            this.gvVehicle.ViewCaption = "Daftar Kendaraan";
            // 
            // colActiveLicenseNumber
            // 
            this.colActiveLicenseNumber.Caption = "Nopol";
            this.colActiveLicenseNumber.FieldName = "ActiveLicenseNumber";
            this.colActiveLicenseNumber.Name = "colActiveLicenseNumber";
            this.colActiveLicenseNumber.Visible = true;
            this.colActiveLicenseNumber.VisibleIndex = 0;
            // 
            // colCustomer
            // 
            this.colCustomer.Caption = "Customer";
            this.colCustomer.FieldName = "Customer.CompanyName";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 1;
            // 
            // colVehicleGroup
            // 
            this.colVehicleGroup.Caption = "Kelompok";
            this.colVehicleGroup.FieldName = "VehicleGroup.Name";
            this.colVehicleGroup.Name = "colVehicleGroup";
            this.colVehicleGroup.Visible = true;
            this.colVehicleGroup.VisibleIndex = 2;
            // 
            // colBrand
            // 
            this.colBrand.Caption = "Merek";
            this.colBrand.FieldName = "Brand.Name";
            this.colBrand.Name = "colBrand";
            this.colBrand.Visible = true;
            this.colBrand.VisibleIndex = 3;
            // 
            // colType
            // 
            this.colType.Caption = "Tipe";
            this.colType.FieldName = "Type.Name";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 4;
            // 
            // colYearOfPurchase
            // 
            this.colYearOfPurchase.Caption = "Tahun Pembelian";
            this.colYearOfPurchase.FieldName = "YearOfPurchase";
            this.colYearOfPurchase.Name = "colYearOfPurchase";
            this.colYearOfPurchase.Visible = true;
            this.colYearOfPurchase.VisibleIndex = 5;
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
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.print_16x161;
            this.btnPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnPrint.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnPrint.Location = new System.Drawing.Point(769, 72);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(106, 23);
            this.btnPrint.TabIndex = 34;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnVehicleWheelSwap
            // 
            this.btnVehicleWheelSwap.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.if_ic_swap_horiz_16x16;
            this.btnVehicleWheelSwap.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnVehicleWheelSwap.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnVehicleWheelSwap.Location = new System.Drawing.Point(153, 72);
            this.btnVehicleWheelSwap.Name = "btnVehicleWheelSwap";
            this.btnVehicleWheelSwap.Size = new System.Drawing.Size(144, 23);
            this.btnVehicleWheelSwap.TabIndex = 35;
            this.btnVehicleWheelSwap.Text = "Tukar Ban Kendaraan";
            this.btnVehicleWheelSwap.Click += new System.EventHandler(this.btnVehicleWheelSwap_Click);
            // 
            // VehicleListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnVehicleWheelSwap);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gcVehicle);
            this.Controls.Add(this.gcFilter);
            this.Controls.Add(this.btnNewVehicle);
            this.Name = "VehicleListControl";
            this.Size = new System.Drawing.Size(883, 422);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilter.Properties)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtFilter;
        private DevExpress.XtraEditors.LabelControl lblFilterCompanyName;
        private DevExpress.XtraEditors.SimpleButton btnNewVehicle;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private DevExpress.XtraGrid.GridControl gcVehicle;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVehicle;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colActiveLicenseNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colYearOfPurchase;
        private System.Windows.Forms.ToolStripMenuItem cmsUpdateLicenseNumber;
        private System.Windows.Forms.ToolStripMenuItem cmsViewHistoryLicenseNumber;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraGrid.Columns.GridColumn colVehicleGroup;
        private DevExpress.XtraEditors.SimpleButton btnExportToCSV;
        private System.Windows.Forms.SaveFileDialog exportDialog;
        private System.ComponentModel.BackgroundWorker bgwExport;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnVehicleWheelSwap;
    }
}
