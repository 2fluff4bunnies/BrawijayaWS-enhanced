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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleEditorForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.lookUpCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.txtBrand = new DevExpress.XtraEditors.TextEdit();
            this.txtLicenseNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtType = new DevExpress.XtraEditors.TextEdit();
            this.txtYearOfPurchase = new DevExpress.XtraEditors.TextEdit();
            this.lblCustomer = new DevExpress.XtraEditors.LabelControl();
            this.lblBrand = new DevExpress.XtraEditors.LabelControl();
            this.lblType = new DevExpress.XtraEditors.LabelControl();
            this.lblYearOfPurchase = new DevExpress.XtraEditors.LabelControl();
            this.gcVehicleInfo = new DevExpress.XtraEditors.GroupControl();
            this.btnNewVehicleWheel = new DevExpress.XtraEditors.SimpleButton();
            this.gridVehicleWheel = new DevExpress.XtraGrid.GridControl();
            this.gvVehicleWheel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWheelDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbWheelDetailGv = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.dtpExpirationDate = new DevExpress.XtraEditors.DateEdit();
            this.lblExpirationDate = new DevExpress.XtraEditors.LabelControl();
            this.lblLicenseNumber = new DevExpress.XtraEditors.LabelControl();
            this.FieldsValidator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            this.bsVehicleWheel = new System.Windows.Forms.BindingSource();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip();
            this.deleteWheelDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYearOfPurchase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVehicleInfo)).BeginInit();
            this.gcVehicleInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehicleWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbWheelDetailGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpExpirationDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpExpirationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FieldsValidator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleWheel)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lookUpCustomer
            // 
            this.lookUpCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpCustomer.Location = new System.Drawing.Point(128, 145);
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
            this.lookUpCustomer.Size = new System.Drawing.Size(257, 20);
            this.lookUpCustomer.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Customer harus dipilih";
            this.FieldsValidator.SetValidationRule(this.lookUpCustomer, conditionValidationRule1);
            // 
            // txtBrand
            // 
            this.txtBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBrand.Location = new System.Drawing.Point(128, 56);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtBrand.Size = new System.Drawing.Size(257, 20);
            this.txtBrand.TabIndex = 1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Merek harus diisi";
            this.FieldsValidator.SetValidationRule(this.txtBrand, conditionValidationRule2);
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
            this.txtLicenseNumber.Size = new System.Drawing.Size(257, 20);
            this.txtLicenseNumber.TabIndex = 4;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Nomor Polisi harus diisi";
            this.FieldsValidator.SetValidationRule(this.txtLicenseNumber, conditionValidationRule3);
            // 
            // txtType
            // 
            this.txtType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtType.Location = new System.Drawing.Point(128, 86);
            this.txtType.Name = "txtType";
            this.txtType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtType.Size = new System.Drawing.Size(257, 20);
            this.txtType.TabIndex = 2;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Tipe harus diisi";
            this.FieldsValidator.SetValidationRule(this.txtType, conditionValidationRule4);
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
            this.txtYearOfPurchase.Size = new System.Drawing.Size(257, 20);
            this.txtYearOfPurchase.TabIndex = 3;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Tahun Pembelian harus diisi";
            this.FieldsValidator.SetValidationRule(this.txtYearOfPurchase, conditionValidationRule5);
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
            // gcVehicleInfo
            // 
            this.gcVehicleInfo.Controls.Add(this.btnNewVehicleWheel);
            this.gcVehicleInfo.Controls.Add(this.gridVehicleWheel);
            this.gcVehicleInfo.Controls.Add(this.txtYearOfPurchase);
            this.gcVehicleInfo.Controls.Add(this.dtpExpirationDate);
            this.gcVehicleInfo.Controls.Add(this.lblExpirationDate);
            this.gcVehicleInfo.Controls.Add(this.txtLicenseNumber);
            this.gcVehicleInfo.Controls.Add(this.lblLicenseNumber);
            this.gcVehicleInfo.Controls.Add(this.lookUpCustomer);
            this.gcVehicleInfo.Controls.Add(this.lblYearOfPurchase);
            this.gcVehicleInfo.Controls.Add(this.txtType);
            this.gcVehicleInfo.Controls.Add(this.lblType);
            this.gcVehicleInfo.Controls.Add(this.txtBrand);
            this.gcVehicleInfo.Controls.Add(this.lblBrand);
            this.gcVehicleInfo.Controls.Add(this.lblCustomer);
            this.gcVehicleInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcVehicleInfo.Location = new System.Drawing.Point(0, 0);
            this.gcVehicleInfo.Name = "gcVehicleInfo";
            this.gcVehicleInfo.Size = new System.Drawing.Size(404, 387);
            this.gcVehicleInfo.TabIndex = 1;
            this.gcVehicleInfo.Text = "Informasi Kendaraan";
            // 
            // btnNewVehicleWheel
            // 
            this.btnNewVehicleWheel.Image = ((System.Drawing.Image)(resources.GetObject("btnNewVehicleWheel.Image")));
            this.btnNewVehicleWheel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewVehicleWheel.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewVehicleWheel.Location = new System.Drawing.Point(12, 212);
            this.btnNewVehicleWheel.Name = "btnNewVehicleWheel";
            this.btnNewVehicleWheel.Size = new System.Drawing.Size(100, 23);
            this.btnNewVehicleWheel.TabIndex = 13;
            this.btnNewVehicleWheel.Text = "Tambah Ban";
            this.btnNewVehicleWheel.Click += new System.EventHandler(this.btnNewVehicleWheel_Click);
            // 
            // gridVehicleWheel
            // 
            this.gridVehicleWheel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVehicleWheel.Location = new System.Drawing.Point(12, 241);
            this.gridVehicleWheel.MainView = this.gvVehicleWheel;
            this.gridVehicleWheel.Name = "gridVehicleWheel";
            this.gridVehicleWheel.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbWheelDetailGv});
            this.gridVehicleWheel.Size = new System.Drawing.Size(373, 140);
            this.gridVehicleWheel.TabIndex = 12;
            this.gridVehicleWheel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVehicleWheel});
            // 
            // gvVehicleWheel
            // 
            this.gvVehicleWheel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWheelDetail});
            this.gvVehicleWheel.GridControl = this.gridVehicleWheel;
            this.gvVehicleWheel.Name = "gvVehicleWheel";
            this.gvVehicleWheel.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvVehicleWheel.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvVehicleWheel.OptionsBehavior.AutoPopulateColumns = false;
            this.gvVehicleWheel.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gvVehicleWheel.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvVehicleWheel.OptionsView.EnableAppearanceEvenRow = true;
            this.gvVehicleWheel.OptionsView.ShowGroupPanel = false;
            this.gvVehicleWheel.OptionsView.ShowViewCaption = true;
            this.gvVehicleWheel.ViewCaption = "Daftar Ban Terpasang";
            // 
            // colWheelDetail
            // 
            this.colWheelDetail.Caption = "Nomor Seri Ban";
            this.colWheelDetail.ColumnEdit = this.cbWheelDetailGv;
            this.colWheelDetail.FieldName = "WheelDetailId";
            this.colWheelDetail.Name = "colWheelDetail";
            this.colWheelDetail.Visible = true;
            this.colWheelDetail.VisibleIndex = 0;
            // 
            // cbWheelDetailGv
            // 
            this.cbWheelDetailGv.AutoHeight = false;
            this.cbWheelDetailGv.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbWheelDetailGv.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Sparepart")});
            this.cbWheelDetailGv.DisplayMember = "SerialNumber";
            this.cbWheelDetailGv.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.cbWheelDetailGv.Name = "cbWheelDetailGv";
            this.cbWheelDetailGv.NullText = "-- Pilih Ban --";
            this.cbWheelDetailGv.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbWheelDetailGv.ValidateOnEnterKey = true;
            this.cbWheelDetailGv.ValueMember = "Id";
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
            this.dtpExpirationDate.Properties.HideSelection = false;
            this.dtpExpirationDate.Properties.HighlightTodayCell = DevExpress.Utils.DefaultBoolean.True;
            this.dtpExpirationDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtpExpirationDate.Size = new System.Drawing.Size(257, 20);
            this.dtpExpirationDate.TabIndex = 5;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule6.ErrorText = "Tanggal Kadaluarsa harus diisi";
            this.FieldsValidator.SetValidationRule(this.dtpExpirationDate, conditionValidationRule6);
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
            this.lblLicenseNumber.Location = new System.Drawing.Point(12, 28);
            this.lblLicenseNumber.Name = "lblLicenseNumber";
            this.lblLicenseNumber.Size = new System.Drawing.Size(57, 13);
            this.lblLicenseNumber.TabIndex = 9;
            this.lblLicenseNumber.Text = "Nomor Polisi";
            // 
            // FieldsValidator
            // 
            this.FieldsValidator.ValidateHiddenControls = false;
            this.FieldsValidator.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteWheelDetailToolStripMenuItem});
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(132, 26);
            // 
            // deleteWheelDetailToolStripMenuItem
            // 
            this.deleteWheelDetailToolStripMenuItem.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.deleteWheelDetailToolStripMenuItem.Name = "deleteWheelDetailToolStripMenuItem";
            this.deleteWheelDetailToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.deleteWheelDetailToolStripMenuItem.Text = "Hapus Ban";
            this.deleteWheelDetailToolStripMenuItem.Click += new System.EventHandler(this.deleteWheelDetailToolStripMenuItem_Click);
            // 
            // VehicleEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 436);
            this.Controls.Add(this.gcVehicleInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VehicleEditorForm";
            this.Text = "Vehicle Editor";
            this.Controls.SetChildIndex(this.gcVehicleInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYearOfPurchase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVehicleInfo)).EndInit();
            this.gcVehicleInfo.ResumeLayout(false);
            this.gcVehicleInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehicleWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbWheelDetailGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpExpirationDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpExpirationDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FieldsValidator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleWheel)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCustomer;
        private DevExpress.XtraEditors.LabelControl lblBrand;
        private DevExpress.XtraEditors.TextEdit txtBrand;
        private DevExpress.XtraEditors.LabelControl lblType;
        private DevExpress.XtraEditors.TextEdit txtType;
        private DevExpress.XtraEditors.LabelControl lblYearOfPurchase;
        private DevExpress.XtraEditors.LookUpEdit lookUpCustomer;
        private DevExpress.XtraEditors.GroupControl gcVehicleInfo;
        private DevExpress.XtraEditors.TextEdit txtLicenseNumber;
        private DevExpress.XtraEditors.LabelControl lblLicenseNumber;
        private DevExpress.XtraEditors.TextEdit txtYearOfPurchase;
        private DevExpress.XtraEditors.DateEdit dtpExpirationDate;
        private DevExpress.XtraEditors.LabelControl lblExpirationDate;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider FieldsValidator;
        private DevExpress.XtraGrid.GridControl gridVehicleWheel;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVehicleWheel;
        private DevExpress.XtraGrid.Columns.GridColumn colWheelDetail;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbWheelDetailGv;
        private DevExpress.XtraEditors.SimpleButton btnNewVehicleWheel;
        private System.Windows.Forms.BindingSource bsVehicleWheel;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem deleteWheelDetailToolStripMenuItem;
    }
}