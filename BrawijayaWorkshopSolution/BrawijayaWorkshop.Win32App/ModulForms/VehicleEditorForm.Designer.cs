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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule8 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.lookUpCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.txtYearOfPurchase = new DevExpress.XtraEditors.TextEdit();
            this.lblCustomer = new DevExpress.XtraEditors.LabelControl();
            this.lblBrand = new DevExpress.XtraEditors.LabelControl();
            this.lblType = new DevExpress.XtraEditors.LabelControl();
            this.lblYearOfPurchase = new DevExpress.XtraEditors.LabelControl();
            this.gcVehicleInfo = new DevExpress.XtraEditors.GroupControl();
            this.lookupGroup = new DevExpress.XtraEditors.LookUpEdit();
            this.lblVehicleGroup = new DevExpress.XtraEditors.LabelControl();
            this.txtKilometer = new DevExpress.XtraEditors.TextEdit();
            this.lblKilometer = new DevExpress.XtraEditors.LabelControl();
            this.lookUpBrand = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpType = new DevExpress.XtraEditors.LookUpEdit();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.lblCode = new DevExpress.XtraEditors.LabelControl();
            this.btnNewVehicleWheel = new DevExpress.XtraEditors.SimpleButton();
            this.gridVehicleWheel = new DevExpress.XtraGrid.GridControl();
            this.gvVehicleWheel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWheelDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookupWheelDetailGv = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colWheelDtl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWheelNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtpExpirationDate = new DevExpress.XtraEditors.DateEdit();
            this.lblExpirationDate = new DevExpress.XtraEditors.LabelControl();
            this.txtLicenseNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblLicenseNumber = new DevExpress.XtraEditors.LabelControl();
            this.FieldsValidator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.bsVehicleWheel = new System.Windows.Forms.BindingSource(this.components);
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteWheelDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFromStockWheeldetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwSave = new System.ComponentModel.BackgroundWorker();
            this.ValidateExpireDate = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valGroupName = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.bgwDelete = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYearOfPurchase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVehicleInfo)).BeginInit();
            this.gcVehicleInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKilometer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehicleWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupWheelDetailGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpExpirationDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpExpirationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FieldsValidator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleWheel)).BeginInit();
            this.cmsEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValidateExpireDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valGroupName)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpCustomer
            // 
            this.lookUpCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpCustomer.Location = new System.Drawing.Point(126, 33);
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
            this.lookUpCustomer.Size = new System.Drawing.Size(256, 20);
            this.lookUpCustomer.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Customer harus dipilih";
            this.FieldsValidator.SetValidationRule(this.lookUpCustomer, conditionValidationRule1);
            // 
            // txtYearOfPurchase
            // 
            this.txtYearOfPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYearOfPurchase.Location = new System.Drawing.Point(126, 231);
            this.txtYearOfPurchase.Name = "txtYearOfPurchase";
            this.txtYearOfPurchase.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtYearOfPurchase.Properties.Mask.EditMask = "[12][0-9]{3}";
            this.txtYearOfPurchase.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtYearOfPurchase.Size = new System.Drawing.Size(256, 20);
            this.txtYearOfPurchase.TabIndex = 13;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Tahun Pembelian harus diisi";
            this.FieldsValidator.SetValidationRule(this.txtYearOfPurchase, conditionValidationRule2);
            // 
            // lblCustomer
            // 
            this.lblCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomer.Location = new System.Drawing.Point(14, 36);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(46, 13);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer";
            // 
            // lblBrand
            // 
            this.lblBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrand.Location = new System.Drawing.Point(14, 135);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(29, 13);
            this.lblBrand.TabIndex = 6;
            this.lblBrand.Text = "Merek";
            // 
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType.Location = new System.Drawing.Point(14, 168);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(20, 13);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Tipe";
            // 
            // lblYearOfPurchase
            // 
            this.lblYearOfPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYearOfPurchase.Location = new System.Drawing.Point(14, 234);
            this.lblYearOfPurchase.Name = "lblYearOfPurchase";
            this.lblYearOfPurchase.Size = new System.Drawing.Size(81, 13);
            this.lblYearOfPurchase.TabIndex = 12;
            this.lblYearOfPurchase.Text = "Tahun Pembelian";
            // 
            // gcVehicleInfo
            // 
            this.gcVehicleInfo.Controls.Add(this.lookupGroup);
            this.gcVehicleInfo.Controls.Add(this.lblVehicleGroup);
            this.gcVehicleInfo.Controls.Add(this.txtKilometer);
            this.gcVehicleInfo.Controls.Add(this.lblKilometer);
            this.gcVehicleInfo.Controls.Add(this.lookUpBrand);
            this.gcVehicleInfo.Controls.Add(this.lookUpType);
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
            this.gcVehicleInfo.Size = new System.Drawing.Size(394, 512);
            this.gcVehicleInfo.TabIndex = 0;
            this.gcVehicleInfo.Text = "Informasi Kendaraan";
            // 
            // lookupGroup
            // 
            this.lookupGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookupGroup.Location = new System.Drawing.Point(126, 66);
            this.lookupGroup.Name = "lookupGroup";
            this.lookupGroup.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookupGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupGroup.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Nama Kelompok")});
            this.lookupGroup.Properties.DisplayMember = "Name";
            this.lookupGroup.Properties.HideSelection = false;
            this.lookupGroup.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookupGroup.Properties.NullText = "-- Pilih Kelompok --";
            this.lookupGroup.Properties.ValueMember = "Id";
            this.lookupGroup.Size = new System.Drawing.Size(256, 20);
            this.lookupGroup.TabIndex = 3;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule3.ErrorText = "Pilih Kelompok";
            conditionValidationRule3.Value1 = "-- Pilih Kelompok --";
            this.valGroupName.SetValidationRule(this.lookupGroup, conditionValidationRule3);
            // 
            // lblVehicleGroup
            // 
            this.lblVehicleGroup.Location = new System.Drawing.Point(14, 69);
            this.lblVehicleGroup.Name = "lblVehicleGroup";
            this.lblVehicleGroup.Size = new System.Drawing.Size(45, 13);
            this.lblVehicleGroup.TabIndex = 2;
            this.lblVehicleGroup.Text = "Kelompok";
            // 
            // txtKilometer
            // 
            this.txtKilometer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKilometer.Location = new System.Drawing.Point(126, 264);
            this.txtKilometer.Name = "txtKilometer";
            this.txtKilometer.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtKilometer.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKilometer.Properties.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.txtKilometer.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtKilometer.Size = new System.Drawing.Size(256, 20);
            this.txtKilometer.TabIndex = 15;
            // 
            // lblKilometer
            // 
            this.lblKilometer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKilometer.Location = new System.Drawing.Point(14, 267);
            this.lblKilometer.Name = "lblKilometer";
            this.lblKilometer.Size = new System.Drawing.Size(44, 13);
            this.lblKilometer.TabIndex = 14;
            this.lblKilometer.Text = "Kilometer";
            // 
            // lookUpBrand
            // 
            this.lookUpBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpBrand.Location = new System.Drawing.Point(126, 132);
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
            this.lookUpBrand.Size = new System.Drawing.Size(256, 20);
            this.lookUpBrand.TabIndex = 7;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Merek harus dipilih";
            this.FieldsValidator.SetValidationRule(this.lookUpBrand, conditionValidationRule4);
            // 
            // lookUpType
            // 
            this.lookUpType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpType.Location = new System.Drawing.Point(126, 165);
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
            this.lookUpType.Properties.NullText = "-- Pilih Tipe--";
            this.lookUpType.Properties.ValueMember = "Id";
            this.lookUpType.Size = new System.Drawing.Size(256, 20);
            this.lookUpType.TabIndex = 9;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Tipe harus dipilih";
            this.FieldsValidator.SetValidationRule(this.lookUpType, conditionValidationRule5);
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Location = new System.Drawing.Point(126, 198);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode.Size = new System.Drawing.Size(256, 20);
            this.txtCode.TabIndex = 11;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule6.ErrorText = "Kode harus diisi";
            this.FieldsValidator.SetValidationRule(this.txtCode, conditionValidationRule6);
            // 
            // lblCode
            // 
            this.lblCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCode.Location = new System.Drawing.Point(14, 201);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(24, 13);
            this.lblCode.TabIndex = 10;
            this.lblCode.Text = "Kode";
            // 
            // btnNewVehicleWheel
            // 
            this.btnNewVehicleWheel.Image = ((System.Drawing.Image)(resources.GetObject("btnNewVehicleWheel.Image")));
            this.btnNewVehicleWheel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewVehicleWheel.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewVehicleWheel.Location = new System.Drawing.Point(14, 335);
            this.btnNewVehicleWheel.Name = "btnNewVehicleWheel";
            this.btnNewVehicleWheel.Size = new System.Drawing.Size(100, 23);
            this.btnNewVehicleWheel.TabIndex = 18;
            this.btnNewVehicleWheel.Text = "Tambah Ban";
            this.btnNewVehicleWheel.Click += new System.EventHandler(this.btnNewVehicleWheel_Click);
            // 
            // gridVehicleWheel
            // 
            this.gridVehicleWheel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVehicleWheel.Location = new System.Drawing.Point(12, 364);
            this.gridVehicleWheel.MainView = this.gvVehicleWheel;
            this.gridVehicleWheel.Name = "gridVehicleWheel";
            this.gridVehicleWheel.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookupWheelDetailGv});
            this.gridVehicleWheel.Size = new System.Drawing.Size(360, 136);
            this.gridVehicleWheel.TabIndex = 19;
            this.gridVehicleWheel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVehicleWheel});
            // 
            // gvVehicleWheel
            // 
            this.gvVehicleWheel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWheelDetail,
            this.colWheelDtl,
            this.colWheelNotes});
            this.gvVehicleWheel.GridControl = this.gridVehicleWheel;
            this.gvVehicleWheel.Name = "gvVehicleWheel";
            this.gvVehicleWheel.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvVehicleWheel.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvVehicleWheel.OptionsBehavior.AutoPopulateColumns = false;
            this.gvVehicleWheel.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gvVehicleWheel.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gvVehicleWheel.OptionsView.EnableAppearanceEvenRow = true;
            this.gvVehicleWheel.OptionsView.ShowGroupPanel = false;
            this.gvVehicleWheel.OptionsView.ShowViewCaption = true;
            this.gvVehicleWheel.ViewCaption = "Daftar Ban Terpasang";
            // 
            // colWheelDetail
            // 
            this.colWheelDetail.Caption = "Nomor Seri Ban";
            this.colWheelDetail.ColumnEdit = this.lookupWheelDetailGv;
            this.colWheelDetail.FieldName = "WheelDetailIds";
            this.colWheelDetail.Name = "colWheelDetail";
            // 
            // lookupWheelDetailGv
            // 
            this.lookupWheelDetailGv.AutoHeight = false;
            this.lookupWheelDetailGv.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookupWheelDetailGv.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupWheelDetailGv.DisplayMember = "SerialNumber";
            this.lookupWheelDetailGv.HideSelection = false;
            this.lookupWheelDetailGv.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookupWheelDetailGv.Name = "lookupWheelDetailGv";
            this.lookupWheelDetailGv.ValueMember = "SerialNumber";
            // 
            // colWheelDtl
            // 
            this.colWheelDtl.Caption = "Nomor Seri Ban";
            this.colWheelDtl.FieldName = "WheelDetail.SerialNumber";
            this.colWheelDtl.Name = "colWheelDtl";
            this.colWheelDtl.Visible = true;
            this.colWheelDtl.VisibleIndex = 0;
            // 
            // colWheelNotes
            // 
            this.colWheelNotes.Caption = "Keterangan";
            this.colWheelNotes.FieldName = "Notes";
            this.colWheelNotes.Name = "colWheelNotes";
            this.colWheelNotes.Visible = true;
            this.colWheelNotes.VisibleIndex = 1;
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpExpirationDate.EditValue = null;
            this.dtpExpirationDate.Location = new System.Drawing.Point(126, 297);
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
            this.dtpExpirationDate.Size = new System.Drawing.Size(256, 20);
            this.dtpExpirationDate.TabIndex = 17;
            conditionValidationRule7.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule7.ErrorText = "Tanggal kadaluarsa nopol harus diisi!";
            this.ValidateExpireDate.SetValidationRule(this.dtpExpirationDate, conditionValidationRule7);
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpirationDate.Location = new System.Drawing.Point(14, 300);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(100, 13);
            this.lblExpirationDate.TabIndex = 16;
            this.lblExpirationDate.Text = "Tgl Kadaluarsa Nopol";
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLicenseNumber.Location = new System.Drawing.Point(126, 99);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtLicenseNumber.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLicenseNumber.Properties.Mask.EditMask = "[a-zA-Z0-9\\-_]{0,40}";
            this.txtLicenseNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtLicenseNumber.Size = new System.Drawing.Size(256, 20);
            this.txtLicenseNumber.TabIndex = 5;
            conditionValidationRule8.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule8.ErrorText = "Nomor Polisi harus diisi";
            this.FieldsValidator.SetValidationRule(this.txtLicenseNumber, conditionValidationRule8);
            // 
            // lblLicenseNumber
            // 
            this.lblLicenseNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLicenseNumber.Location = new System.Drawing.Point(14, 102);
            this.lblLicenseNumber.Name = "lblLicenseNumber";
            this.lblLicenseNumber.Size = new System.Drawing.Size(57, 13);
            this.lblLicenseNumber.TabIndex = 4;
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
            this.deleteWheelDetailToolStripMenuItem,
            this.deleteFromStockWheeldetailToolStripMenuItem});
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(211, 70);
            // 
            // deleteWheelDetailToolStripMenuItem
            // 
            this.deleteWheelDetailToolStripMenuItem.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.if_ic_swap_horiz_16x16;
            this.deleteWheelDetailToolStripMenuItem.Name = "deleteWheelDetailToolStripMenuItem";
            this.deleteWheelDetailToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.deleteWheelDetailToolStripMenuItem.Text = "Lepas Ban Dari Kendaraan";
            this.deleteWheelDetailToolStripMenuItem.Click += new System.EventHandler(this.deleteWheelDetailToolStripMenuItem_Click);
            // 
            // deleteFromStockWheeldetailToolStripMenuItem
            // 
            this.deleteFromStockWheeldetailToolStripMenuItem.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.deleteFromStockWheeldetailToolStripMenuItem.Name = "deleteFromStockWheeldetailToolStripMenuItem";
            this.deleteFromStockWheeldetailToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.deleteFromStockWheeldetailToolStripMenuItem.Text = "Hapus Ban Dari Stock";
            this.deleteFromStockWheeldetailToolStripMenuItem.Click += new System.EventHandler(this.deleteFromStockWheeldetailToolStripMenuItem_Click);
            // 
            // bgwSave
            // 
            this.bgwSave.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSave_DoWork);
            this.bgwSave.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSave_RunWorkerCompleted);
            // 
            // ValidateExpireDate
            // 
            this.ValidateExpireDate.ValidateHiddenControls = false;
            this.ValidateExpireDate.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // bgwDelete
            // 
            this.bgwDelete.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDelete_DoWork);
            this.bgwDelete.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwDelete_RunWorkerCompleted);
            // 
            // VehicleEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 561);
            this.Controls.Add(this.gcVehicleInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VehicleEditorForm";
            this.Text = "Vehicle Editor";
            this.Controls.SetChildIndex(this.gcVehicleInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYearOfPurchase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVehicleInfo)).EndInit();
            this.gcVehicleInfo.ResumeLayout(false);
            this.gcVehicleInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKilometer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehicleWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupWheelDetailGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpExpirationDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpExpirationDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FieldsValidator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleWheel)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ValidateExpireDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valGroupName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCustomer;
        private DevExpress.XtraEditors.LabelControl lblBrand;
        private DevExpress.XtraEditors.LabelControl lblType;
        private DevExpress.XtraEditors.LabelControl lblYearOfPurchase;
        private DevExpress.XtraEditors.LookUpEdit lookUpCustomer;
        private DevExpress.XtraEditors.GroupControl gcVehicleInfo;
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
        private System.ComponentModel.BackgroundWorker bgwSave;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl lblCode;
        private DevExpress.XtraEditors.LookUpEdit lookUpBrand;
        private DevExpress.XtraEditors.LookUpEdit lookUpType;
        private DevExpress.XtraEditors.TextEdit txtLicenseNumber;
        private DevExpress.XtraEditors.TextEdit txtKilometer;
        private DevExpress.XtraEditors.LabelControl lblKilometer;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider ValidateExpireDate;
        private DevExpress.XtraEditors.LookUpEdit lookupGroup;
        private DevExpress.XtraEditors.LabelControl lblVehicleGroup;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valGroupName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookupWheelDetailGv;
        private DevExpress.XtraGrid.Columns.GridColumn colWheelDtl;
        private DevExpress.XtraGrid.Columns.GridColumn colWheelNotes;
        private System.ComponentModel.BackgroundWorker bgwDelete;
        private System.Windows.Forms.ToolStripMenuItem deleteFromStockWheeldetailToolStripMenuItem;
    }
}