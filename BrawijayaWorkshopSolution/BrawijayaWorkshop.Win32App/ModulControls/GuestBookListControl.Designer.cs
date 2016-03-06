namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class GuestBookListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestBookListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtFilter = new DevExpress.XtraEditors.TextEdit();
            this.lblFilterCompanyName = new DevExpress.XtraEditors.LabelControl();
            this.btnNewGuestBook = new DevExpress.XtraEditors.SimpleButton();
            this.gcGuestBook = new DevExpress.XtraGrid.GridControl();
            this.gvGuestBook = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActiveLicenseNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsViewVehicle = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGuestBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGuestBook)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.txtFilter);
            this.gcFilter.Controls.Add(this.lblFilterCompanyName);
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(691, 62);
            this.gcFilter.TabIndex = 7;
            this.gcFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(624, 28);
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
            this.txtFilter.Properties.Mask.EditMask = "[a-zA-Z0-9\\-_]{0,40}";
            this.txtFilter.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtFilter.Size = new System.Drawing.Size(490, 20);
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
            // btnNewGuestBook
            // 
            this.btnNewGuestBook.Image = ((System.Drawing.Image)(resources.GetObject("btnNewGuestBook.Image")));
            this.btnNewGuestBook.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewGuestBook.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewGuestBook.Location = new System.Drawing.Point(3, 71);
            this.btnNewGuestBook.Name = "btnNewGuestBook";
            this.btnNewGuestBook.Size = new System.Drawing.Size(170, 23);
            this.btnNewGuestBook.TabIndex = 9;
            this.btnNewGuestBook.Text = "Tambah Daftar Hadir Baru";
            // 
            // gcGuestBook
            // 
            this.gcGuestBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcGuestBook.Location = new System.Drawing.Point(3, 100);
            this.gcGuestBook.MainView = this.gvGuestBook;
            this.gcGuestBook.Name = "gcGuestBook";
            this.gcGuestBook.Size = new System.Drawing.Size(691, 307);
            this.gcGuestBook.TabIndex = 10;
            this.gcGuestBook.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGuestBook});
            // 
            // gvGuestBook
            // 
            this.gvGuestBook.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomer,
            this.colActiveLicenseNumber,
            this.colBrand,
            this.colType,
            this.colDescription});
            this.gvGuestBook.GridControl = this.gcGuestBook;
            this.gvGuestBook.Name = "gvGuestBook";
            this.gvGuestBook.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvGuestBook.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvGuestBook.OptionsBehavior.AutoPopulateColumns = false;
            this.gvGuestBook.OptionsBehavior.Editable = false;
            this.gvGuestBook.OptionsBehavior.ReadOnly = true;
            this.gvGuestBook.OptionsCustomization.AllowColumnMoving = false;
            this.gvGuestBook.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvGuestBook.OptionsMenu.EnableFooterMenu = false;
            this.gvGuestBook.OptionsView.EnableAppearanceEvenRow = true;
            this.gvGuestBook.OptionsView.ShowFooter = true;
            this.gvGuestBook.OptionsView.ShowGroupPanel = false;
            this.gvGuestBook.OptionsView.ShowViewCaption = true;
            this.gvGuestBook.ViewCaption = "Daftar Kendaraan";
            // 
            // colCustomer
            // 
            this.colCustomer.Caption = "Customer";
            this.colCustomer.FieldName = "Vehicle.Customer.CompanyName";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 1;
            // 
            // colActiveLicenseNumber
            // 
            this.colActiveLicenseNumber.Caption = "Nopol";
            this.colActiveLicenseNumber.FieldName = "Vehicle.ActiveLicenseNumber";
            this.colActiveLicenseNumber.Name = "colActiveLicenseNumber";
            this.colActiveLicenseNumber.Visible = true;
            this.colActiveLicenseNumber.VisibleIndex = 0;
            // 
            // colBrand
            // 
            this.colBrand.Caption = "Merek";
            this.colBrand.FieldName = "Vehicle.Brand";
            this.colBrand.Name = "colBrand";
            this.colBrand.Visible = true;
            this.colBrand.VisibleIndex = 2;
            // 
            // colType
            // 
            this.colType.Caption = "Tipe";
            this.colType.FieldName = "Vehicle.Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 3;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Tahun Pembelian";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
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
            this.cmsDeleteData,
            this.toolStripSeparator1,
            this.cmsViewVehicle});
            this.cmsEditor.Name = "cmsListEditor";
            this.cmsEditor.Size = new System.Drawing.Size(160, 76);
            // 
            // cmsEditData
            // 
            this.cmsEditData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.cmsEditData.Name = "cmsEditData";
            this.cmsEditData.Size = new System.Drawing.Size(159, 22);
            this.cmsEditData.Text = "Ubah Data";
            this.cmsEditData.Click += new System.EventHandler(this.cmsEditData_Click);
            // 
            // cmsDeleteData
            // 
            this.cmsDeleteData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.cmsDeleteData.Name = "cmsDeleteData";
            this.cmsDeleteData.Size = new System.Drawing.Size(159, 22);
            this.cmsDeleteData.Text = "Hapus Data";
            this.cmsDeleteData.Click += new System.EventHandler(this.cmsDeleteData_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // cmsViewVehicle
            // 
            this.cmsViewVehicle.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.Truck_Left_Green_icon_16x16;
            this.cmsViewVehicle.Name = "cmsViewVehicle";
            this.cmsViewVehicle.Size = new System.Drawing.Size(159, 22);
            this.cmsViewVehicle.Text = "Lihat Kendaraan";
            this.cmsViewVehicle.Click += new System.EventHandler(this.cmsViewVehicle_Click);
            // 
            // GuestBookListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcGuestBook);
            this.Controls.Add(this.btnNewGuestBook);
            this.Controls.Add(this.gcFilter);
            this.Name = "GuestBookListControl";
            this.Size = new System.Drawing.Size(697, 410);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGuestBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGuestBook)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtFilter;
        private DevExpress.XtraEditors.LabelControl lblFilterCompanyName;
        private DevExpress.XtraEditors.SimpleButton btnNewGuestBook;
        private DevExpress.XtraGrid.GridControl gcGuestBook;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGuestBook;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colActiveLicenseNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmsViewVehicle;
    }
}
