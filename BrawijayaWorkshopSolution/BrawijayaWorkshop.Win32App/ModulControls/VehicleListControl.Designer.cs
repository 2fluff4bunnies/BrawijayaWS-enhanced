namespace BrawijayaWorkshop.Win32App.ModulControls
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
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtFilter = new DevExpress.XtraEditors.TextEdit();
            this.lblFilterCompanyName = new DevExpress.XtraEditors.LabelControl();
            this.btnNewVehicle = new DevExpress.XtraEditors.SimpleButton();
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdateLicenseNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsViewHistoryLicenseNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.gcVehicle = new DevExpress.XtraGrid.GridControl();
            this.gvVehicle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActiveLicenseNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearOfPurchase = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.txtFilter);
            this.gcFilter.Controls.Add(this.lblFilterCompanyName);
            this.gcFilter.Location = new System.Drawing.Point(8, 4);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(575, 62);
            this.gcFilter.TabIndex = 6;
            this.gcFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(508, 28);
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
            this.txtFilter.Location = new System.Drawing.Point(128, 30);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(374, 20);
            this.txtFilter.TabIndex = 1;
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
            this.btnNewVehicle.Location = new System.Drawing.Point(8, 72);
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
            this.cmsUpdateLicenseNumber,
            this.cmsViewHistoryLicenseNumber,
            this.cmsDeleteData});
            this.cmsEditor.Name = "cmsListEditor";
            this.cmsEditor.Size = new System.Drawing.Size(181, 114);
            // 
            // cmsEditData
            // 
            this.cmsEditData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.cmsEditData.Name = "cmsEditData";
            this.cmsEditData.Size = new System.Drawing.Size(180, 22);
            this.cmsEditData.Text = "Ubah Data";
            this.cmsEditData.Click += new System.EventHandler(this.cmsEditData_Click);
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
            this.gcVehicle.Location = new System.Drawing.Point(8, 102);
            this.gcVehicle.MainView = this.gvVehicle;
            this.gcVehicle.Name = "gcVehicle";
            this.gcVehicle.Size = new System.Drawing.Size(575, 224);
            this.gcVehicle.TabIndex = 9;
            this.gcVehicle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVehicle});
            // 
            // gvVehicle
            // 
            this.gvVehicle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomer,
            this.colActiveLicenseNumber,
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
            this.gvVehicle.OptionsView.ShowViewCaption = true;
            this.gvVehicle.ViewCaption = "Daftar Kendaraan";
            // 
            // colCustomer
            // 
            this.colCustomer.Caption = "Customer";
            this.colCustomer.FieldName = "Customer.CompanyName";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 1;
            // 
            // colActiveLicenseNumber
            // 
            this.colActiveLicenseNumber.Caption = "Nopol";
            this.colActiveLicenseNumber.FieldName = "ActiveLicenseNumber";
            this.colActiveLicenseNumber.Name = "colActiveLicenseNumber";
            this.colActiveLicenseNumber.Visible = true;
            this.colActiveLicenseNumber.VisibleIndex = 0;
            // 
            // colBrand
            // 
            this.colBrand.Caption = "Merek";
            this.colBrand.FieldName = "Brand";
            this.colBrand.Name = "colBrand";
            this.colBrand.Visible = true;
            this.colBrand.VisibleIndex = 2;
            // 
            // colType
            // 
            this.colType.Caption = "Tipe";
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 3;
            // 
            // colYearOfPurchase
            // 
            this.colYearOfPurchase.Caption = "Tahun Pembelian";
            this.colYearOfPurchase.FieldName = "YearOfPurchase";
            this.colYearOfPurchase.Name = "colYearOfPurchase";
            this.colYearOfPurchase.Visible = true;
            this.colYearOfPurchase.VisibleIndex = 4;
            // 
            // VehicleListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcVehicle);
            this.Controls.Add(this.gcFilter);
            this.Controls.Add(this.btnNewVehicle);
            this.Name = "VehicleListControl";
            this.Size = new System.Drawing.Size(590, 329);
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
    }
}
