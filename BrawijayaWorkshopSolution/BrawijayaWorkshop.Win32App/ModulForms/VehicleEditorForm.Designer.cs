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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleEditorForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule7 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.lookUpCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.txtLicenseNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtYearOfPurchase = new DevExpress.XtraEditors.TextEdit();
            this.lblCustomer = new DevExpress.XtraEditors.LabelControl();
            this.lblBrand = new DevExpress.XtraEditors.LabelControl();
            this.lblType = new DevExpress.XtraEditors.LabelControl();
            this.lblYearOfPurchase = new DevExpress.XtraEditors.LabelControl();
            this.gcVehicleInfo = new DevExpress.XtraEditors.GroupControl();
            this.lookUpType = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpBrand = new DevExpress.XtraEditors.LookUpEdit();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.lblCode = new DevExpress.XtraEditors.LabelControl();
            this.btnNewVehicleWheel = new DevExpress.XtraEditors.SimpleButton();
            this.gridVehicleWheel = new DevExpress.XtraGrid.GridControl();
            this.gvVehicleWheel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWheelDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookupWheelDetailGv = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.dtpExpirationDate = new DevExpress.XtraEditors.DateEdit();
            this.lblExpirationDate = new DevExpress.XtraEditors.LabelControl();
            this.lblLicenseNumber = new DevExpress.XtraEditors.LabelControl();
            this.FieldsValidator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.bsVehicleWheel = new System.Windows.Forms.BindingSource(this.components);
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteWheelDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwSave = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYearOfPurchase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVehicleInfo)).BeginInit();
            this.gcVehicleInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehicleWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupWheelDetailGv)).BeginInit();
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
            this.lookUpCustomer.Location = new System.Drawing.Point(129, 181);
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
            this.lookUpCustomer.TabIndex = 9;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Customer harus dipilih";
            this.FieldsValidator.SetValidationRule(this.lookUpCustomer, conditionValidationRule1);
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLicenseNumber.Location = new System.Drawing.Point(129, 61);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtLicenseNumber.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLicenseNumber.Properties.Mask.EditMask = "[a-zA-Z0-9\\-_]{0,40}";
            this.txtLicenseNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtLicenseNumber.Size = new System.Drawing.Size(257, 20);
            this.txtLicenseNumber.TabIndex = 1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Nomor Polisi harus diisi";
            this.FieldsValidator.SetValidationRule(this.txtLicenseNumber, conditionValidationRule2);
            // 
            // txtYearOfPurchase
            // 
            this.txtYearOfPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYearOfPurchase.Location = new System.Drawing.Point(129, 151);
            this.txtYearOfPurchase.Name = "txtYearOfPurchase";
            this.txtYearOfPurchase.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtYearOfPurchase.Properties.Mask.EditMask = "[12][0-9]{3}";
            this.txtYearOfPurchase.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtYearOfPurchase.Size = new System.Drawing.Size(257, 20);
            this.txtYearOfPurchase.TabIndex = 7;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Tahun Pembelian harus diisi";
            this.FieldsValidator.SetValidationRule(this.txtYearOfPurchase, conditionValidationRule3);
            // 
            // lblCustomer
            // 
            this.lblCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomer.Location = new System.Drawing.Point(13, 184);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(46, 13);
            this.lblCustomer.TabIndex = 8;
            this.lblCustomer.Text = "Customer";
            // 
            // lblBrand
            // 
            this.lblBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrand.Location = new System.Drawing.Point(13, 94);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(29, 13);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "Merek";
            // 
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType.Location = new System.Drawing.Point(13, 124);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(20, 13);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Tipe";
            // 
            // lblYearOfPurchase
            // 
            this.lblYearOfPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYearOfPurchase.Location = new System.Drawing.Point(13, 154);
            this.lblYearOfPurchase.Name = "lblYearOfPurchase";
            this.lblYearOfPurchase.Size = new System.Drawing.Size(81, 13);
            this.lblYearOfPurchase.TabIndex = 6;
            this.lblYearOfPurchase.Text = "Tahun Pembelian";
            // 
            // gcVehicleInfo
            // 
            this.gcVehicleInfo.Controls.Add(this.lookUpType);
            this.gcVehicleInfo.Controls.Add(this.lookUpBrand);
            this.gcVehicleInfo.Controls.Add(this.txtCode);
            this.gcVehicleInfo.Controls.Add(this.lblCode);
            this.gcVehicleInfo.Controls.Add(this.btnNewVehicleWheel);
            this.gcVehicleInfo.Controls.Add(this.gridVehicleWheel);
            this.gcVehicleInfo.Controls.Add(this.txtYearOfPurchase);
            this.gcVehicleInfo.Controls.Add(this.dtpExpirationDate);
            this.gcVehicleInfo.Controls.Add(this.lblExpirationDate);
            this.gcVehicleInfo.Controls.Add(this.txtLicenseNumber);
            this.gcVehicleInfo.Controls.Add(this.lblLicenseNumber);
            this.gcVehicleInfo.Controls.Add(this.lookUpCustomer);
            this.gcVehicleInfo.Controls.Add(this.lblYearOfPurchase);
            this.gcVehicleInfo.Controls.Add(this.lblType);
            this.gcVehicleInfo.Controls.Add(this.lblBrand);
            this.gcVehicleInfo.Controls.Add(this.lblCustomer);
            this.gcVehicleInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcVehicleInfo.Location = new System.Drawing.Point(0, 0);
            this.gcVehicleInfo.Name = "gcVehicleInfo";
            this.gcVehicleInfo.Size = new System.Drawing.Size(404, 447);
            this.gcVehicleInfo.TabIndex = 1;
            this.gcVehicleInfo.Text = "Informasi Kendaraan";
            // 
            // lookUpType
            // 
            this.lookUpType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpType.Location = new System.Drawing.Point(129, 121);
            this.lookUpType.Name = "lookUpType";
            this.lookUpType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lookUpType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Nama")});
            this.lookUpType.Properties.DisplayMember = "Name";
            this.lookUpType.Properties.HideSelection = false;
            this.lookUpType.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookUpType.Properties.NullText = "-- Pilih Tipe --";
            this.lookUpType.Properties.ValueMember = "Id";
            this.lookUpType.Size = new System.Drawing.Size(257, 20);
            this.lookUpType.TabIndex = 17;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Tipe harus dipilih";
            this.FieldsValidator.SetValidationRule(this.lookUpType, conditionValidationRule4);
            // 
            // lookUpBrand
            // 
            this.lookUpBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpBrand.Location = new System.Drawing.Point(129, 91);
            this.lookUpBrand.Name = "lookUpBrand";
            this.lookUpBrand.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lookUpBrand.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpBrand.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpBrand.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Nama")});
            this.lookUpBrand.Properties.DisplayMember = "Name";
            this.lookUpBrand.Properties.HideSelection = false;
            this.lookUpBrand.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookUpBrand.Properties.NullText = "-- Pilih Merek --";
            this.lookUpBrand.Properties.ValueMember = "Id";
            this.lookUpBrand.Size = new System.Drawing.Size(257, 20);
            this.lookUpBrand.TabIndex = 16;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Merek harus dipilih";
            this.FieldsValidator.SetValidationRule(this.lookUpBrand, conditionValidationRule5);
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Location = new System.Drawing.Point(129, 30);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode.Properties.Mask.EditMask = "[a-zA-Z0-9\\-_]{0,40}";
            this.txtCode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCode.Size = new System.Drawing.Size(256, 20);
            this.txtCode.TabIndex = 15;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule6.ErrorText = "Kode harus diisi";
            this.FieldsValidator.SetValidationRule(this.txtCode, conditionValidationRule6);
            // 
            // lblCode
            // 
            this.lblCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCode.Location = new System.Drawing.Point(13, 33);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(24, 13);
            this.lblCode.TabIndex = 14;
            this.lblCode.Text = "Kode";
            // 
            // btnNewVehicleWheel
            // 
            this.btnNewVehicleWheel.Image = ((System.Drawing.Image)(resources.GetObject("btnNewVehicleWheel.Image")));
            this.btnNewVehicleWheel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewVehicleWheel.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewVehicleWheel.Location = new System.Drawing.Point(12, 250);
            this.btnNewVehicleWheel.Name = "btnNewVehicleWheel";
            this.btnNewVehicleWheel.Size = new System.Drawing.Size(100, 23);
            this.btnNewVehicleWheel.TabIndex = 12;
            this.btnNewVehicleWheel.Text = "Tambah Ban";
            this.btnNewVehicleWheel.Click += new System.EventHandler(this.btnNewVehicleWheel_Click);
            // 
            // gridVehicleWheel
            // 
            this.gridVehicleWheel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVehicleWheel.Location = new System.Drawing.Point(12, 289);
            this.gridVehicleWheel.MainView = this.gvVehicleWheel;
            this.gridVehicleWheel.Name = "gridVehicleWheel";
            this.gridVehicleWheel.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookupWheelDetailGv});
            this.gridVehicleWheel.Size = new System.Drawing.Size(373, 146);
            this.gridVehicleWheel.TabIndex = 13;
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
            this.colWheelDetail.ColumnEdit = this.lookupWheelDetailGv;
            this.colWheelDetail.FieldName = "WheelDetailId";
            this.colWheelDetail.Name = "colWheelDetail";
            this.colWheelDetail.Visible = true;
            this.colWheelDetail.VisibleIndex = 0;
            // 
            // lookupWheelDetailGv
            // 
            this.lookupWheelDetailGv.AutoHeight = false;
            this.lookupWheelDetailGv.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.lookupWheelDetailGv.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupWheelDetailGv.DisplayMember = "SerialNumber";
            this.lookupWheelDetailGv.HideSelection = false;
            this.lookupWheelDetailGv.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookupWheelDetailGv.Name = "lookupWheelDetailGv";
            this.lookupWheelDetailGv.NullText = "-- Pilih Ban --";
            this.lookupWheelDetailGv.ValueMember = "Id";
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpExpirationDate.EditValue = null;
            this.dtpExpirationDate.Location = new System.Drawing.Point(129, 211);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dtpExpirationDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpExpirationDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpExpirationDate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.dtpExpirationDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpExpirationDate.Properties.HideSelection = false;
            this.dtpExpirationDate.Properties.HighlightTodayCell = DevExpress.Utils.DefaultBoolean.True;
            this.dtpExpirationDate.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.dtpExpirationDate.Size = new System.Drawing.Size(257, 20);
            this.dtpExpirationDate.TabIndex = 11;
            conditionValidationRule7.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule7.ErrorText = "Tanggal Kadaluarsa harus diisi";
            this.FieldsValidator.SetValidationRule(this.dtpExpirationDate, conditionValidationRule7);
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpirationDate.Location = new System.Drawing.Point(13, 214);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(100, 13);
            this.lblExpirationDate.TabIndex = 10;
            this.lblExpirationDate.Text = "Tgl Kadaluarsa Nopol";
            // 
            // lblLicenseNumber
            // 
            this.lblLicenseNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLicenseNumber.Location = new System.Drawing.Point(13, 64);
            this.lblLicenseNumber.Name = "lblLicenseNumber";
            this.lblLicenseNumber.Size = new System.Drawing.Size(57, 13);
            this.lblLicenseNumber.TabIndex = 0;
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
            // bgwSave
            // 
            this.bgwSave.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSave_DoWork);
            this.bgwSave.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSave_RunWorkerCompleted);
            // 
            // VehicleEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 496);
            this.Controls.Add(this.gcVehicleInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VehicleEditorForm";
            this.Text = "Vehicle Editor";
            this.Controls.SetChildIndex(this.gcVehicleInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYearOfPurchase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVehicleInfo)).EndInit();
            this.gcVehicleInfo.ResumeLayout(false);
            this.gcVehicleInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehicleWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupWheelDetailGv)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl lblType;
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
        private DevExpress.XtraEditors.SimpleButton btnNewVehicleWheel;
        private System.Windows.Forms.BindingSource bsVehicleWheel;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem deleteWheelDetailToolStripMenuItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookupWheelDetailGv;
        private System.ComponentModel.BackgroundWorker bgwSave;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl lblCode;
        private DevExpress.XtraEditors.LookUpEdit lookUpType;
        private DevExpress.XtraEditors.LookUpEdit lookUpBrand;
    }
}