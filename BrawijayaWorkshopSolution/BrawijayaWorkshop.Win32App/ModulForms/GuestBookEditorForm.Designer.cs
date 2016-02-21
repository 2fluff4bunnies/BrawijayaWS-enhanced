namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class GuestBookEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestBookEditorForm));
            this.gcCustomerInfo = new DevExpress.XtraEditors.GroupControl();
            this.gridVehicleWheel = new DevExpress.XtraGrid.GridControl();
            this.gvVehicleWheel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodeDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerialNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblExpirationDate = new DevExpress.XtraEditors.LabelControl();
            this.txtLicenseNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblLicenseNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblYearOfPurchase = new DevExpress.XtraEditors.LabelControl();
            this.lblType = new DevExpress.XtraEditors.LabelControl();
            this.lblBrand = new DevExpress.XtraEditors.LabelControl();
            this.lblCustomer = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lblBrandValue = new DevExpress.XtraEditors.LabelControl();
            this.lblTypeValue = new DevExpress.XtraEditors.LabelControl();
            this.lblYearOfBuyValue = new DevExpress.XtraEditors.LabelControl();
            this.lblCustomerValue = new DevExpress.XtraEditors.LabelControl();
            this.lblExpirationDateValue = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerInfo)).BeginInit();
            this.gcCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehicleWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCustomerInfo
            // 
            this.gcCustomerInfo.Controls.Add(this.lblExpirationDateValue);
            this.gcCustomerInfo.Controls.Add(this.lblCustomerValue);
            this.gcCustomerInfo.Controls.Add(this.lblYearOfBuyValue);
            this.gcCustomerInfo.Controls.Add(this.lblTypeValue);
            this.gcCustomerInfo.Controls.Add(this.lblBrandValue);
            this.gcCustomerInfo.Controls.Add(this.btnSearch);
            this.gcCustomerInfo.Controls.Add(this.gridVehicleWheel);
            this.gcCustomerInfo.Controls.Add(this.lblExpirationDate);
            this.gcCustomerInfo.Controls.Add(this.txtLicenseNumber);
            this.gcCustomerInfo.Controls.Add(this.lblLicenseNumber);
            this.gcCustomerInfo.Controls.Add(this.lblYearOfPurchase);
            this.gcCustomerInfo.Controls.Add(this.lblType);
            this.gcCustomerInfo.Controls.Add(this.lblBrand);
            this.gcCustomerInfo.Controls.Add(this.lblCustomer);
            this.gcCustomerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCustomerInfo.Location = new System.Drawing.Point(0, 0);
            this.gcCustomerInfo.Name = "gcCustomerInfo";
            this.gcCustomerInfo.Size = new System.Drawing.Size(404, 436);
            this.gcCustomerInfo.TabIndex = 2;
            this.gcCustomerInfo.Text = "Informasi Kendaraan";
            // 
            // gridVehicleWheel
            // 
            this.gridVehicleWheel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVehicleWheel.Location = new System.Drawing.Point(12, 205);
            this.gridVehicleWheel.MainView = this.gvVehicleWheel;
            this.gridVehicleWheel.Name = "gridVehicleWheel";
            this.gridVehicleWheel.Size = new System.Drawing.Size(373, 169);
            this.gridVehicleWheel.TabIndex = 12;
            this.gridVehicleWheel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVehicleWheel});
            // 
            // gvVehicleWheel
            // 
            this.gvVehicleWheel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodeDetail,
            this.colSerialNumber});
            this.gvVehicleWheel.GridControl = this.gridVehicleWheel;
            this.gvVehicleWheel.Name = "gvVehicleWheel";
            this.gvVehicleWheel.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvVehicleWheel.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvVehicleWheel.OptionsBehavior.AutoPopulateColumns = false;
            this.gvVehicleWheel.OptionsBehavior.Editable = false;
            this.gvVehicleWheel.OptionsBehavior.ReadOnly = true;
            this.gvVehicleWheel.OptionsCustomization.AllowColumnMoving = false;
            this.gvVehicleWheel.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvVehicleWheel.OptionsMenu.EnableFooterMenu = false;
            this.gvVehicleWheel.OptionsView.EnableAppearanceEvenRow = true;
            this.gvVehicleWheel.OptionsView.ShowFooter = true;
            this.gvVehicleWheel.OptionsView.ShowGroupPanel = false;
            this.gvVehicleWheel.OptionsView.ShowViewCaption = true;
            this.gvVehicleWheel.ViewCaption = "Daftar Ban Terpasang";
            // 
            // colCodeDetail
            // 
            this.colCodeDetail.Caption = "Kode";
            this.colCodeDetail.FieldName = "Code";
            this.colCodeDetail.Name = "colCodeDetail";
            this.colCodeDetail.Visible = true;
            this.colCodeDetail.VisibleIndex = 0;
            // 
            // colSerialNumber
            // 
            this.colSerialNumber.Caption = "Nomor Seri";
            this.colSerialNumber.Name = "colSerialNumber";
            this.colSerialNumber.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "", "Jumlah Data: {0}")});
            this.colSerialNumber.Visible = true;
            this.colSerialNumber.VisibleIndex = 1;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpirationDate.Location = new System.Drawing.Point(12, 178);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(100, 13);
            this.lblExpirationDate.TabIndex = 11;
            this.lblExpirationDate.Text = "Tgl Kadaluarsa Nopol";
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLicenseNumber.Location = new System.Drawing.Point(128, 25);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtLicenseNumber.Properties.Mask.EditMask = "[a-zA-Z0-9\\-_]{0,40}";
            this.txtLicenseNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtLicenseNumber.Size = new System.Drawing.Size(196, 20);
            this.txtLicenseNumber.TabIndex = 4;
            // 
            // lblLicenseNumber
            // 
            this.lblLicenseNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLicenseNumber.Location = new System.Drawing.Point(12, 28);
            this.lblLicenseNumber.Name = "lblLicenseNumber";
            this.lblLicenseNumber.Size = new System.Drawing.Size(57, 13);
            this.lblLicenseNumber.TabIndex = 9;
            this.lblLicenseNumber.Text = "Nomor Polisi";
            // 
            // lblYearOfPurchase
            // 
            this.lblYearOfPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYearOfPurchase.Location = new System.Drawing.Point(12, 119);
            this.lblYearOfPurchase.Name = "lblYearOfPurchase";
            this.lblYearOfPurchase.Size = new System.Drawing.Size(81, 13);
            this.lblYearOfPurchase.TabIndex = 6;
            this.lblYearOfPurchase.Text = "Tahun Pembelian";
            // 
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType.Location = new System.Drawing.Point(12, 89);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(20, 13);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Tipe";
            // 
            // lblBrand
            // 
            this.lblBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrand.Location = new System.Drawing.Point(12, 59);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(29, 13);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "Merek";
            // 
            // lblCustomer
            // 
            this.lblCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomer.Location = new System.Drawing.Point(12, 148);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(46, 13);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(330, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "cari";
            // 
            // lblBrandValue
            // 
            this.lblBrandValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrandValue.Location = new System.Drawing.Point(128, 59);
            this.lblBrandValue.Name = "lblBrandValue";
            this.lblBrandValue.Size = new System.Drawing.Size(8, 13);
            this.lblBrandValue.TabIndex = 14;
            this.lblBrandValue.Text = "--";
            // 
            // lblTypeValue
            // 
            this.lblTypeValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTypeValue.Location = new System.Drawing.Point(128, 89);
            this.lblTypeValue.Name = "lblTypeValue";
            this.lblTypeValue.Size = new System.Drawing.Size(8, 13);
            this.lblTypeValue.TabIndex = 15;
            this.lblTypeValue.Text = "--";
            // 
            // lblYearOfBuyValue
            // 
            this.lblYearOfBuyValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYearOfBuyValue.Location = new System.Drawing.Point(128, 119);
            this.lblYearOfBuyValue.Name = "lblYearOfBuyValue";
            this.lblYearOfBuyValue.Size = new System.Drawing.Size(8, 13);
            this.lblYearOfBuyValue.TabIndex = 16;
            this.lblYearOfBuyValue.Text = "--";
            // 
            // lblCustomerValue
            // 
            this.lblCustomerValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerValue.Location = new System.Drawing.Point(128, 148);
            this.lblCustomerValue.Name = "lblCustomerValue";
            this.lblCustomerValue.Size = new System.Drawing.Size(8, 13);
            this.lblCustomerValue.TabIndex = 17;
            this.lblCustomerValue.Text = "--";
            // 
            // lblExpirationDateValue
            // 
            this.lblExpirationDateValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpirationDateValue.Location = new System.Drawing.Point(128, 178);
            this.lblExpirationDateValue.Name = "lblExpirationDateValue";
            this.lblExpirationDateValue.Size = new System.Drawing.Size(8, 13);
            this.lblExpirationDateValue.TabIndex = 18;
            this.lblExpirationDateValue.Text = "--";
            // 
            // GuestBookEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 436);
            this.Controls.Add(this.gcCustomerInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuestBookEditorForm";
            this.Text = "GuestBookEditorForm";
            this.Controls.SetChildIndex(this.gcCustomerInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerInfo)).EndInit();
            this.gcCustomerInfo.ResumeLayout(false);
            this.gcCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehicleWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNumber.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcCustomerInfo;
        private DevExpress.XtraGrid.GridControl gridVehicleWheel;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVehicleWheel;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colSerialNumber;
        private DevExpress.XtraEditors.LabelControl lblExpirationDate;
        private DevExpress.XtraEditors.TextEdit txtLicenseNumber;
        private DevExpress.XtraEditors.LabelControl lblLicenseNumber;
        private DevExpress.XtraEditors.LabelControl lblYearOfPurchase;
        private DevExpress.XtraEditors.LabelControl lblType;
        private DevExpress.XtraEditors.LabelControl lblBrand;
        private DevExpress.XtraEditors.LabelControl lblCustomer;
        private DevExpress.XtraEditors.LabelControl lblExpirationDateValue;
        private DevExpress.XtraEditors.LabelControl lblCustomerValue;
        private DevExpress.XtraEditors.LabelControl lblYearOfBuyValue;
        private DevExpress.XtraEditors.LabelControl lblTypeValue;
        private DevExpress.XtraEditors.LabelControl lblBrandValue;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
    }
}