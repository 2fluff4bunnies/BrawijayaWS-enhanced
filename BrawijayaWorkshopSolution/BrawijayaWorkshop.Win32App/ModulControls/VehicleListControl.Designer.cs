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
            this.txtFilterLicenseId = new DevExpress.XtraEditors.TextEdit();
            this.lblFilterCompanyName = new DevExpress.XtraEditors.LabelControl();
            this.gridVehicle = new DevExpress.XtraGrid.GridControl();
            this.gvVehicle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLicenseIdVehicle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeVehicle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVehilceCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnNewVehicle = new DevExpress.XtraEditors.SimpleButton();
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterLicenseId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicle)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.txtFilterLicenseId);
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
            // 
            // txtFilterLicenseId
            // 
            this.txtFilterLicenseId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterLicenseId.Location = new System.Drawing.Point(128, 30);
            this.txtFilterLicenseId.Name = "txtFilterLicenseId";
            this.txtFilterLicenseId.Size = new System.Drawing.Size(374, 20);
            this.txtFilterLicenseId.TabIndex = 1;
            // 
            // lblFilterCompanyName
            // 
            this.lblFilterCompanyName.Location = new System.Drawing.Point(12, 33);
            this.lblFilterCompanyName.Name = "lblFilterCompanyName";
            this.lblFilterCompanyName.Size = new System.Drawing.Size(57, 13);
            this.lblFilterCompanyName.TabIndex = 0;
            this.lblFilterCompanyName.Text = "Nomor Polisi";
            // 
            // gridVehicle
            // 
            this.gridVehicle.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.gridVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVehicle.Location = new System.Drawing.Point(8, 101);
            this.gridVehicle.MainView = this.gvVehicle;
            this.gridVehicle.Name = "gridVehicle";
            this.gridVehicle.Size = new System.Drawing.Size(575, 224);
            this.gridVehicle.TabIndex = 7;
            this.gridVehicle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVehicle});
            // 
            // gvVehicle
            // 
            this.gvVehicle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLicenseIdVehicle,
            this.colTypeVehicle,
            this.colVehilceCustomer});
            this.gvVehicle.GridControl = this.gridVehicle;
            this.gvVehicle.Name = "gvVehicle";
            this.gvVehicle.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvVehicle.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvVehicle.OptionsBehavior.AutoPopulateColumns = false;
            this.gvVehicle.OptionsBehavior.Editable = false;
            this.gvVehicle.OptionsBehavior.ReadOnly = true;
            this.gvVehicle.OptionsCustomization.AllowColumnMoving = false;
            this.gvVehicle.OptionsCustomization.AllowFilter = false;
            this.gvVehicle.OptionsCustomization.AllowGroup = false;
            this.gvVehicle.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvVehicle.OptionsView.ShowGroupPanel = false;
            this.gvVehicle.OptionsView.ShowViewCaption = true;
            this.gvVehicle.ViewCaption = "Daftar Kendaraan";
            // 
            // colLicenseIdVehicle
            // 
            this.colLicenseIdVehicle.Caption = "Nopol";
            this.colLicenseIdVehicle.FieldName = "NoPol";
            this.colLicenseIdVehicle.Name = "colLicenseIdVehicle";
            this.colLicenseIdVehicle.Visible = true;
            this.colLicenseIdVehicle.VisibleIndex = 0;
            // 
            // colTypeVehicle
            // 
            this.colTypeVehicle.Caption = "Tipe";
            this.colTypeVehicle.FieldName = "Type";
            this.colTypeVehicle.Name = "colTypeVehicle";
            this.colTypeVehicle.Visible = true;
            this.colTypeVehicle.VisibleIndex = 1;
            // 
            // colVehilceCustomer
            // 
            this.colVehilceCustomer.Caption = "Customer";
            this.colVehilceCustomer.FieldName = "Customer";
            this.colVehilceCustomer.Name = "colVehilceCustomer";
            this.colVehilceCustomer.Visible = true;
            this.colVehilceCustomer.VisibleIndex = 2;
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
            // 
            // cmsDeleteData
            // 
            this.cmsDeleteData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.cmsDeleteData.Name = "cmsDeleteData";
            this.cmsDeleteData.Size = new System.Drawing.Size(135, 22);
            this.cmsDeleteData.Text = "Hapus Data";
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditData,
            this.cmsDeleteData});
            this.cmsEditor.Name = "cmsListEditor";
            this.cmsEditor.Size = new System.Drawing.Size(136, 48);
            // 
            // cmsEditData
            // 
            this.cmsEditData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.cmsEditData.Name = "cmsEditData";
            this.cmsEditData.Size = new System.Drawing.Size(135, 22);
            this.cmsEditData.Text = "Ubah Data";
            // 
            // VehicleListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcFilter);
            this.Controls.Add(this.gridVehicle);
            this.Controls.Add(this.btnNewVehicle);
            this.Name = "VehicleListControl";
            this.Size = new System.Drawing.Size(590, 329);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterLicenseId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicle)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtFilterLicenseId;
        private DevExpress.XtraEditors.LabelControl lblFilterCompanyName;
        private DevExpress.XtraGrid.GridControl gridVehicle;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVehicle;
        private DevExpress.XtraGrid.Columns.GridColumn colLicenseIdVehicle;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeVehicle;
        private DevExpress.XtraGrid.Columns.GridColumn colVehilceCustomer;
        private DevExpress.XtraEditors.SimpleButton btnNewVehicle;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private System.ComponentModel.BackgroundWorker bgwMain;
    }
}
