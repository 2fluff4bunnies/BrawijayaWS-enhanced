namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class VehicleEditorForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleEditorForm));
            this.valCustomer = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valBrand = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.txtBrand = new DevExpress.XtraEditors.TextEdit();
            this.txtLicenseNumber = new DevExpress.XtraEditors.TextEdit();
            this.valType = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.txtType = new DevExpress.XtraEditors.TextEdit();
            this.txtYearOfPurchase = new DevExpress.XtraEditors.TextEdit();
            this.valYearOfBuy = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.lookUpCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCustomer = new DevExpress.XtraEditors.LabelControl();
            this.lblBrand = new DevExpress.XtraEditors.LabelControl();
            this.lblType = new DevExpress.XtraEditors.LabelControl();
            this.lblYearOfPurchase = new DevExpress.XtraEditors.LabelControl();
            this.gcCustomerInfo = new DevExpress.XtraEditors.GroupControl();
            this.dtpExpirationDate = new DevExpress.XtraEditors.DateEdit();
            this.lblExpirationDate = new DevExpress.XtraEditors.LabelControl();
            this.lblLicenseNumber = new DevExpress.XtraEditors.LabelControl();
            this.valLicenseNumber = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.valCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYearOfPurchase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valYearOfBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerInfo)).BeginInit();
            this.gcCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpExpirationDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpExpirationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valLicenseNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // valCustomer
            // 
            this.valCustomer.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valBrand
            // 
            this.valBrand.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // txtBrand
            // 
            this.txtBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBrand.Location = new System.Drawing.Point(128, 56);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtBrand.Size = new System.Drawing.Size(162, 20);
            this.txtBrand.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Nama Perusahaan harus diisi!";
            this.valBrand.SetValidationRule(this.txtBrand, conditionValidationRule1);
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLicenseNumber.Location = new System.Drawing.Point(128, 144);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtLicenseNumber.Properties.Mask.EditMask = "\\S*";
            this.txtLicenseNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtLicenseNumber.Size = new System.Drawing.Size(162, 20);
            this.txtLicenseNumber.TabIndex = 4;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Nama Perusahaan harus diisi!";
            this.valBrand.SetValidationRule(this.txtLicenseNumber, conditionValidationRule2);
            // 
            // valType
            // 
            this.valType.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // txtType
            // 
            this.txtType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtType.Location = new System.Drawing.Point(128, 86);
            this.txtType.Name = "txtType";
            this.txtType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtType.Size = new System.Drawing.Size(162, 20);
            this.txtType.TabIndex = 2;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Alamat harus diisi!";
            this.valType.SetValidationRule(this.txtType, conditionValidationRule3);
            // 
            // txtYearOfPurchase
            // 
            this.txtYearOfPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYearOfPurchase.Location = new System.Drawing.Point(128, 116);
            this.txtYearOfPurchase.Name = "txtYearOfPurchase";
            this.txtYearOfPurchase.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtYearOfPurchase.Properties.Mask.EditMask = "[12][0-9]{3}";
            this.txtYearOfPurchase.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtYearOfPurchase.Size = new System.Drawing.Size(162, 20);
            this.txtYearOfPurchase.TabIndex = 3;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Alamat harus diisi!";
            this.valType.SetValidationRule(this.txtYearOfPurchase, conditionValidationRule4);
            // 
            // valYearOfBuy
            // 
            this.valYearOfBuy.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // lookUpCustomer
            // 
            this.lookUpCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpCustomer.Location = new System.Drawing.Point(128, 27);
            this.lookUpCustomer.Name = "lookUpCustomer";
            this.lookUpCustomer.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lookUpCustomer.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCustomer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Kode Customer"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Nama")});
            this.lookUpCustomer.Properties.DisplayMember = "CompanyName";
            this.lookUpCustomer.Properties.HideSelection = false;
            this.lookUpCustomer.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookUpCustomer.Properties.NullText = "-- Pilih Customer --";
            this.lookUpCustomer.Properties.ValueMember = "Id";
            this.lookUpCustomer.Size = new System.Drawing.Size(162, 20);
            this.lookUpCustomer.TabIndex = 0;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule5.ErrorText = "Pilih salah satu kota";
            conditionValidationRule5.Value1 = "-- Pilih Kota --";
            this.valYearOfBuy.SetValidationRule(this.lookUpCustomer, conditionValidationRule5);
            // 
            // lblCustomer
            // 
            this.lblCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomer.Location = new System.Drawing.Point(12, 30);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(46, 13);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer";
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
            // gcCustomerInfo
            // 
            this.gcCustomerInfo.Controls.Add(this.txtYearOfPurchase);
            this.gcCustomerInfo.Controls.Add(this.dtpExpirationDate);
            this.gcCustomerInfo.Controls.Add(this.lblExpirationDate);
            this.gcCustomerInfo.Controls.Add(this.txtLicenseNumber);
            this.gcCustomerInfo.Controls.Add(this.lblLicenseNumber);
            this.gcCustomerInfo.Controls.Add(this.lookUpCustomer);
            this.gcCustomerInfo.Controls.Add(this.lblYearOfPurchase);
            this.gcCustomerInfo.Controls.Add(this.txtType);
            this.gcCustomerInfo.Controls.Add(this.lblType);
            this.gcCustomerInfo.Controls.Add(this.txtBrand);
            this.gcCustomerInfo.Controls.Add(this.lblBrand);
            this.gcCustomerInfo.Controls.Add(this.lblCustomer);
            this.gcCustomerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCustomerInfo.Location = new System.Drawing.Point(0, 0);
            this.gcCustomerInfo.Name = "gcCustomerInfo";
            this.gcCustomerInfo.Size = new System.Drawing.Size(309, 204);
            this.gcCustomerInfo.TabIndex = 1;
            this.gcCustomerInfo.Text = "Informasi Kendaraan";
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpExpirationDate.EditValue = null;
            this.dtpExpirationDate.Location = new System.Drawing.Point(128, 175);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dtpExpirationDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpExpirationDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpExpirationDate.Size = new System.Drawing.Size(162, 20);
            this.dtpExpirationDate.TabIndex = 5;
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
            // lblLicenseNumber
            // 
            this.lblLicenseNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLicenseNumber.Location = new System.Drawing.Point(12, 147);
            this.lblLicenseNumber.Name = "lblLicenseNumber";
            this.lblLicenseNumber.Size = new System.Drawing.Size(57, 13);
            this.lblLicenseNumber.TabIndex = 9;
            this.lblLicenseNumber.Text = "Nomor Polisi";
            // 
            // valLicenseNumber
            // 
            this.valLicenseNumber.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // VehicleEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 253);
            this.Controls.Add(this.gcCustomerInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VehicleEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Editor";
            this.Controls.SetChildIndex(this.gcCustomerInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.valCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYearOfPurchase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valYearOfBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerInfo)).EndInit();
            this.gcCustomerInfo.ResumeLayout(false);
            this.gcCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpExpirationDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpExpirationDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valLicenseNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valCustomer;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valYearOfBuy;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valType;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valBrand;
        private DevExpress.XtraEditors.LabelControl lblCustomer;
        private DevExpress.XtraEditors.LabelControl lblBrand;
        private DevExpress.XtraEditors.TextEdit txtBrand;
        private DevExpress.XtraEditors.LabelControl lblType;
        private DevExpress.XtraEditors.TextEdit txtType;
        private DevExpress.XtraEditors.LabelControl lblYearOfPurchase;
        private DevExpress.XtraEditors.LookUpEdit lookUpCustomer;
        private DevExpress.XtraEditors.GroupControl gcCustomerInfo;
        private DevExpress.XtraEditors.TextEdit txtLicenseNumber;
        private DevExpress.XtraEditors.LabelControl lblLicenseNumber;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valLicenseNumber;
        private DevExpress.XtraEditors.TextEdit txtYearOfPurchase;
        private DevExpress.XtraEditors.DateEdit dtpExpirationDate;
        private DevExpress.XtraEditors.LabelControl lblExpirationDate;
    }
}