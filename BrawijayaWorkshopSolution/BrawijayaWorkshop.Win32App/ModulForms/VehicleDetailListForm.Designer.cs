namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class VehicleDetailListForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleDetailListForm));
            this.gcVehicleDetail = new DevExpress.XtraGrid.GridControl();
            this.gvVehicleDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnUpdateVehicleDetail = new DevExpress.XtraEditors.SimpleButton();
            this.colLicenseNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcVehicleDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // gcVehicleDetail
            // 
            this.gcVehicleDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcVehicleDetail.Location = new System.Drawing.Point(12, 41);
            this.gcVehicleDetail.MainView = this.gvVehicleDetail;
            this.gcVehicleDetail.Name = "gcVehicleDetail";
            this.gcVehicleDetail.Size = new System.Drawing.Size(400, 168);
            this.gcVehicleDetail.TabIndex = 0;
            this.gcVehicleDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVehicleDetail});
            // 
            // gvVehicleDetail
            // 
            this.gvVehicleDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLicenseNumber,
            this.colExpirationDate,
            this.colStatus});
            this.gvVehicleDetail.GridControl = this.gcVehicleDetail;
            this.gvVehicleDetail.Name = "gvVehicleDetail";
            this.gvVehicleDetail.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvVehicleDetail.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvVehicleDetail.OptionsBehavior.AutoPopulateColumns = false;
            this.gvVehicleDetail.OptionsBehavior.Editable = false;
            this.gvVehicleDetail.OptionsBehavior.ReadOnly = true;
            this.gvVehicleDetail.OptionsCustomization.AllowColumnMoving = false;
            this.gvVehicleDetail.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvVehicleDetail.OptionsMenu.EnableFooterMenu = false;
            this.gvVehicleDetail.OptionsView.ShowFooter = true;
            this.gvVehicleDetail.OptionsView.ShowGroupPanel = false;
            this.gvVehicleDetail.OptionsView.ShowViewCaption = true;
            this.gvVehicleDetail.ViewCaption = "Daftar Nomor Polisi";
            // 
            // btnUpdateVehicleDetail
            // 
            this.btnUpdateVehicleDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateVehicleDetail.Image")));
            this.btnUpdateVehicleDetail.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnUpdateVehicleDetail.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnUpdateVehicleDetail.Location = new System.Drawing.Point(12, 12);
            this.btnUpdateVehicleDetail.Name = "btnUpdateVehicleDetail";
            this.btnUpdateVehicleDetail.Size = new System.Drawing.Size(144, 23);
            this.btnUpdateVehicleDetail.TabIndex = 9;
            this.btnUpdateVehicleDetail.Text = "Update Nomor Polisi";
            this.btnUpdateVehicleDetail.Click += new System.EventHandler(this.btnUpdateVehicleDetail_Click);
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
            // VehicleDetailListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 218);
            this.Controls.Add(this.btnUpdateVehicleDetail);
            this.Controls.Add(this.gcVehicleDetail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VehicleDetailListForm";
            this.Text = "Riwayat Nomor Polisi Kendaraan";
            ((System.ComponentModel.ISupportInitialize)(this.gcVehicleDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcVehicleDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVehicleDetail;
        private DevExpress.XtraEditors.SimpleButton btnUpdateVehicleDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colLicenseNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colExpirationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
    }
}