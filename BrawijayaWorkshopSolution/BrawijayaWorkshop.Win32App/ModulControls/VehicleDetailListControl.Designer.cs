namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class VehicleDetailListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleDetailListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtFilterLicenseNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblFilterLicenseNumber = new DevExpress.XtraEditors.LabelControl();
            this.btnUpdateDetail = new DevExpress.XtraEditors.SimpleButton();
            this.gridVehicleDetail = new DevExpress.XtraGrid.GridControl();
            this.gvVehicleDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLicenseNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterLicenseNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehicleDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.txtFilterLicenseNumber);
            this.gcFilter.Controls.Add(this.lblFilterLicenseNumber);
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(376, 61);
            this.gcFilter.TabIndex = 0;
            this.gcFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(316, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFilterLicenseNumber
            // 
            this.txtFilterLicenseNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterLicenseNumber.Location = new System.Drawing.Point(95, 23);
            this.txtFilterLicenseNumber.Name = "txtFilterLicenseNumber";
            this.txtFilterLicenseNumber.Size = new System.Drawing.Size(215, 20);
            this.txtFilterLicenseNumber.TabIndex = 4;
            // 
            // lblFilterLicenseNumber
            // 
            this.lblFilterLicenseNumber.Location = new System.Drawing.Point(5, 26);
            this.lblFilterLicenseNumber.Name = "lblFilterLicenseNumber";
            this.lblFilterLicenseNumber.Size = new System.Drawing.Size(68, 13);
            this.lblFilterLicenseNumber.TabIndex = 3;
            this.lblFilterLicenseNumber.Text = "Nama Supplier";
            // 
            // btnUpdateDetail
            // 
            this.btnUpdateDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateDetail.Image")));
            this.btnUpdateDetail.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnUpdateDetail.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnUpdateDetail.Location = new System.Drawing.Point(3, 70);
            this.btnUpdateDetail.Name = "btnUpdateDetail";
            this.btnUpdateDetail.Size = new System.Drawing.Size(158, 23);
            this.btnUpdateDetail.TabIndex = 3;
            this.btnUpdateDetail.Text = "Update Detail Kendaraan";
            this.btnUpdateDetail.Click += new System.EventHandler(this.btnUpdateDetail_Click);
            // 
            // gridVehicleDetail
            // 
            this.gridVehicleDetail.Location = new System.Drawing.Point(3, 99);
            this.gridVehicleDetail.MainView = this.gvVehicleDetail;
            this.gridVehicleDetail.Name = "gridVehicleDetail";
            this.gridVehicleDetail.Size = new System.Drawing.Size(376, 162);
            this.gridVehicleDetail.TabIndex = 4;
            this.gridVehicleDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVehicleDetail});
            // 
            // gvVehicleDetail
            // 
            this.gvVehicleDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLicenseNumber,
            this.colExpirationDate,
            this.colStatus});
            this.gvVehicleDetail.GridControl = this.gridVehicleDetail;
            this.gvVehicleDetail.Name = "gvVehicleDetail";
            this.gvVehicleDetail.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvVehicleDetail.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvVehicleDetail.OptionsBehavior.AutoPopulateColumns = false;
            this.gvVehicleDetail.OptionsBehavior.Editable = false;
            this.gvVehicleDetail.OptionsBehavior.ReadOnly = true;
            this.gvVehicleDetail.OptionsCustomization.AllowColumnMoving = false;
            this.gvVehicleDetail.OptionsCustomization.AllowFilter = false;
            this.gvVehicleDetail.OptionsCustomization.AllowGroup = false;
            this.gvVehicleDetail.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvVehicleDetail.OptionsView.ShowGroupPanel = false;
            this.gvVehicleDetail.OptionsView.ShowViewCaption = true;
            this.gvVehicleDetail.ViewCaption = "Detail Kendaraan";
            // 
            // colLicenseNumber
            // 
            this.colLicenseNumber.Caption = "Nomor Polisi";
            this.colLicenseNumber.FieldName = "LicenseNumber";
            this.colLicenseNumber.Name = "colLicenseNumber";
            this.colLicenseNumber.Visible = true;
            this.colLicenseNumber.VisibleIndex = 0;
            // 
            // colExpirationDate
            // 
            this.colExpirationDate.Caption = "Tanggal Kadaluarsa";
            this.colExpirationDate.FieldName = "ExpirationDate";
            this.colExpirationDate.Name = "colExpirationDate";
            this.colExpirationDate.Visible = true;
            this.colExpirationDate.VisibleIndex = 1;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 2;
            // 
            // VehicleDetailListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridVehicleDetail);
            this.Controls.Add(this.btnUpdateDetail);
            this.Controls.Add(this.gcFilter);
            this.Name = "VehicleDetailListControl";
            this.Size = new System.Drawing.Size(382, 264);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterLicenseNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehicleDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtFilterLicenseNumber;
        private DevExpress.XtraEditors.LabelControl lblFilterLicenseNumber;
        private DevExpress.XtraEditors.SimpleButton btnUpdateDetail;
        private DevExpress.XtraGrid.GridControl gridVehicleDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVehicleDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colLicenseNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colExpirationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private System.ComponentModel.BackgroundWorker bgwMain;
    }
}
