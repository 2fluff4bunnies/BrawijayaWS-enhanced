﻿namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class SPKEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPKEditorForm));
            this.lookupWheelDetailGv = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ckeIsUsedWheelRetrieved = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.groupSPK = new DevExpress.XtraEditors.GroupControl();
            this.btnChangeWheel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAssignMechanic = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.deTransDate = new DevExpress.XtraEditors.DateEdit();
            this.lblTransactionDate = new DevExpress.XtraEditors.LabelControl();
            this.gridVehicleWheel = new DevExpress.XtraGrid.GridControl();
            this.gvVehicleWheel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWheelDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWheelDetailChanged = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsUsedGoodReceived = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpSparepartWheelGv = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lblCostEstimation = new DevExpress.XtraEditors.LabelControl();
            this.txtCostEstimation = new DevExpress.XtraEditors.TextEdit();
            this.lblCategory = new DevExpress.XtraEditors.LabelControl();
            this.txtKilometer = new DevExpress.XtraEditors.TextEdit();
            this.lblVehicle = new DevExpress.XtraEditors.LabelControl();
            this.lblKilometer = new DevExpress.XtraEditors.LabelControl();
            this.lookUpCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.lblContractor = new DevExpress.XtraEditors.LabelControl();
            this.LookUpVehicle = new DevExpress.XtraEditors.LookUpEdit();
            this.txtContractor = new DevExpress.XtraEditors.TextEdit();
            this.dtpDueDate = new DevExpress.XtraEditors.DateEdit();
            this.lblDueDate = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblContractPrice = new DevExpress.XtraEditors.LabelControl();
            this.memoDescription = new DevExpress.XtraEditors.MemoEdit();
            this.ckeIsContractWork = new DevExpress.XtraEditors.CheckEdit();
            this.txtContractWorkFee = new DevExpress.XtraEditors.TextEdit();
            this.lblValLastUsageQty = new DevExpress.XtraEditors.LabelControl();
            this.lblValLastUsageDate = new DevExpress.XtraEditors.LabelControl();
            this.lblLastUsedQty = new DevExpress.XtraEditors.LabelControl();
            this.lblLastUsageDate = new DevExpress.XtraEditors.LabelControl();
            this.ckeIsReturnRequired = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpSerialNumber = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpSparepart = new DevExpress.XtraEditors.LookUpEdit();
            this.btnAddSparepart = new DevExpress.XtraEditors.SimpleButton();
            this.lblSparepart = new DevExpress.XtraEditors.LabelControl();
            this.txtQty = new DevExpress.XtraEditors.TextEdit();
            this.lblQty = new DevExpress.XtraEditors.LabelControl();
            this.gcSparepart = new DevExpress.XtraGrid.GridControl();
            this.gvSparepart = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSparepartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepartCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtTotalSparepartPrice = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalSparepart = new DevExpress.XtraEditors.LabelControl();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.valVehicle = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valCategory = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valDueDate = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.cmsSparepartEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeleteDataSparepart = new System.Windows.Forms.ToolStripMenuItem();
            this.bsVehicleWheel = new System.Windows.Forms.BindingSource(this.components);
            this.cmsVehicleWheel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsVehicleWheelItemReset = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwSave = new System.ComponentModel.BackgroundWorker();
            this.valDate = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lookupWheelDetailGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeIsUsedWheelRetrieved)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSPK)).BeginInit();
            this.groupSPK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehicleWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSparepartWheelGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostEstimation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKilometer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpVehicle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContractor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDueDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDueDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeIsContractWork.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContractWorkFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeIsReturnRequired.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSerialNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSparepart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalSparepartPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valDueDate)).BeginInit();
            this.cmsSparepartEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleWheel)).BeginInit();
            this.cmsVehicleWheel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valDate)).BeginInit();
            this.SuspendLayout();
            // 
            // lookupWheelDetailGv
            // 
            this.lookupWheelDetailGv.AutoHeight = false;
            this.lookupWheelDetailGv.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.lookupWheelDetailGv.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupWheelDetailGv.DisplayMember = "SerialNumber";
            this.lookupWheelDetailGv.Name = "lookupWheelDetailGv";
            this.lookupWheelDetailGv.NullText = "-- Pilih Ban --";
            this.lookupWheelDetailGv.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookupWheelDetailGv.ValueMember = "Id";
            // 
            // ckeIsUsedWheelRetrieved
            // 
            this.ckeIsUsedWheelRetrieved.AutoHeight = false;
            this.ckeIsUsedWheelRetrieved.Name = "ckeIsUsedWheelRetrieved";
            // 
            // groupSPK
            // 
            this.groupSPK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSPK.Controls.Add(this.btnChangeWheel);
            this.groupSPK.Controls.Add(this.btnAssignMechanic);
            this.groupSPK.Controls.Add(this.splitContainerMain);
            this.groupSPK.Controls.Add(this.txtTotalSparepartPrice);
            this.groupSPK.Controls.Add(this.lblTotalSparepart);
            this.groupSPK.Location = new System.Drawing.Point(-3, -1);
            this.groupSPK.Name = "groupSPK";
            this.groupSPK.Size = new System.Drawing.Size(1143, 531);
            this.groupSPK.TabIndex = 0;
            this.groupSPK.Text = "Informasi SPK";
            // 
            // btnChangeWheel
            // 
            this.btnChangeWheel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChangeWheel.Enabled = false;
            this.btnChangeWheel.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.Tire_16x16;
            this.btnChangeWheel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnChangeWheel.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnChangeWheel.Location = new System.Drawing.Point(148, 503);
            this.btnChangeWheel.Name = "btnChangeWheel";
            this.btnChangeWheel.Size = new System.Drawing.Size(123, 23);
            this.btnChangeWheel.TabIndex = 27;
            this.btnChangeWheel.Text = "Ganti Ban";
            this.btnChangeWheel.Click += new System.EventHandler(this.btnChangeWheel_Click);
            // 
            // btnAssignMechanic
            // 
            this.btnAssignMechanic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAssignMechanic.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.add_mechanic_16x16;
            this.btnAssignMechanic.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAssignMechanic.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAssignMechanic.Location = new System.Drawing.Point(14, 503);
            this.btnAssignMechanic.Name = "btnAssignMechanic";
            this.btnAssignMechanic.Size = new System.Drawing.Size(123, 23);
            this.btnAssignMechanic.TabIndex = 26;
            this.btnAssignMechanic.Text = "Tugaskan Mekanik";
            this.btnAssignMechanic.Click += new System.EventHandler(this.btnAssignMechanic_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerMain.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerMain.Location = new System.Drawing.Point(5, 23);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Panel1.Controls.Add(this.deTransDate);
            this.splitContainerMain.Panel1.Controls.Add(this.lblTransactionDate);
            this.splitContainerMain.Panel1.Controls.Add(this.gridVehicleWheel);
            this.splitContainerMain.Panel1.Controls.Add(this.lblCostEstimation);
            this.splitContainerMain.Panel1.Controls.Add(this.txtCostEstimation);
            this.splitContainerMain.Panel1.Controls.Add(this.lblCategory);
            this.splitContainerMain.Panel1.Controls.Add(this.txtKilometer);
            this.splitContainerMain.Panel1.Controls.Add(this.lblVehicle);
            this.splitContainerMain.Panel1.Controls.Add(this.lblKilometer);
            this.splitContainerMain.Panel1.Controls.Add(this.lookUpCategory);
            this.splitContainerMain.Panel1.Controls.Add(this.lblContractor);
            this.splitContainerMain.Panel1.Controls.Add(this.LookUpVehicle);
            this.splitContainerMain.Panel1.Controls.Add(this.txtContractor);
            this.splitContainerMain.Panel1.Controls.Add(this.dtpDueDate);
            this.splitContainerMain.Panel1.Controls.Add(this.lblDueDate);
            this.splitContainerMain.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerMain.Panel1.Controls.Add(this.lblContractPrice);
            this.splitContainerMain.Panel1.Controls.Add(this.memoDescription);
            this.splitContainerMain.Panel1.Controls.Add(this.ckeIsContractWork);
            this.splitContainerMain.Panel1.Controls.Add(this.txtContractWorkFee);
            this.splitContainerMain.Panel1.Text = "Panel1";
            this.splitContainerMain.Panel2.Controls.Add(this.lblValLastUsageQty);
            this.splitContainerMain.Panel2.Controls.Add(this.lblValLastUsageDate);
            this.splitContainerMain.Panel2.Controls.Add(this.lblLastUsedQty);
            this.splitContainerMain.Panel2.Controls.Add(this.lblLastUsageDate);
            this.splitContainerMain.Panel2.Controls.Add(this.ckeIsReturnRequired);
            this.splitContainerMain.Panel2.Controls.Add(this.labelControl1);
            this.splitContainerMain.Panel2.Controls.Add(this.lookUpSerialNumber);
            this.splitContainerMain.Panel2.Controls.Add(this.lookUpSparepart);
            this.splitContainerMain.Panel2.Controls.Add(this.btnAddSparepart);
            this.splitContainerMain.Panel2.Controls.Add(this.lblSparepart);
            this.splitContainerMain.Panel2.Controls.Add(this.txtQty);
            this.splitContainerMain.Panel2.Controls.Add(this.lblQty);
            this.splitContainerMain.Panel2.Controls.Add(this.gcSparepart);
            this.splitContainerMain.Panel2.Padding = new System.Windows.Forms.Padding(4);
            this.splitContainerMain.Panel2.Text = "Panel2";
            this.splitContainerMain.Size = new System.Drawing.Size(1131, 472);
            this.splitContainerMain.SplitterPosition = 532;
            this.splitContainerMain.TabIndex = 19;
            this.splitContainerMain.Text = "splitContainerControl1";
            // 
            // deTransDate
            // 
            this.deTransDate.EditValue = null;
            this.deTransDate.Location = new System.Drawing.Point(124, 6);
            this.deTransDate.Name = "deTransDate";
            this.deTransDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTransDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTransDate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.deTransDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deTransDate.Properties.HideSelection = false;
            this.deTransDate.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.deTransDate.Size = new System.Drawing.Size(142, 20);
            this.deTransDate.TabIndex = 40;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Tanggal transaksi harus diisi";
            this.valDate.SetValidationRule(this.deTransDate, conditionValidationRule1);
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.Location = new System.Drawing.Point(12, 9);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(86, 13);
            this.lblTransactionDate.TabIndex = 39;
            this.lblTransactionDate.Text = "Tanggal Transaksi";
            // 
            // gridVehicleWheel
            // 
            this.gridVehicleWheel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVehicleWheel.Location = new System.Drawing.Point(9, 195);
            this.gridVehicleWheel.MainView = this.gvVehicleWheel;
            this.gridVehicleWheel.Name = "gridVehicleWheel";
            this.gridVehicleWheel.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookUpSparepartWheelGv});
            this.gridVehicleWheel.Size = new System.Drawing.Size(556, 273);
            this.gridVehicleWheel.TabIndex = 32;
            this.gridVehicleWheel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVehicleWheel});
            // 
            // gvVehicleWheel
            // 
            this.gvVehicleWheel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colWheelDetail,
            this.colSparepart,
            this.colWheelDetailChanged,
            this.colIsUsedGoodReceived,
            this.colPrice});
            this.gvVehicleWheel.GridControl = this.gridVehicleWheel;
            this.gvVehicleWheel.Name = "gvVehicleWheel";
            this.gvVehicleWheel.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvVehicleWheel.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvVehicleWheel.OptionsBehavior.AutoPopulateColumns = false;
            this.gvVehicleWheel.OptionsBehavior.Editable = false;
            this.gvVehicleWheel.OptionsView.EnableAppearanceEvenRow = true;
            this.gvVehicleWheel.OptionsView.ShowGroupPanel = false;
            this.gvVehicleWheel.OptionsView.ShowViewCaption = true;
            this.gvVehicleWheel.ViewCaption = "Daftar Ban Kendaraan";
            // 
            // colName
            // 
            this.colName.Caption = "Jenis Ban (Terpasang)";
            this.colName.FieldName = "WheelDetail.Sparepart.Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colWheelDetail
            // 
            this.colWheelDetail.Caption = "Nomor Seri (Terpasang)";
            this.colWheelDetail.FieldName = "WheelDetail.SerialNumber";
            this.colWheelDetail.Name = "colWheelDetail";
            this.colWheelDetail.Visible = true;
            this.colWheelDetail.VisibleIndex = 1;
            // 
            // colSparepart
            // 
            this.colSparepart.Caption = "Jenis Ban (Pengganti)";
            this.colSparepart.FieldName = "ReplaceWithWheelDetailName";
            this.colSparepart.Name = "colSparepart";
            this.colSparepart.Visible = true;
            this.colSparepart.VisibleIndex = 2;
            // 
            // colWheelDetailChanged
            // 
            this.colWheelDetailChanged.Caption = "Nomor Seri (Pengganti)";
            this.colWheelDetailChanged.FieldName = "ReplaceWithWheelDetailSerialNumber";
            this.colWheelDetailChanged.Name = "colWheelDetailChanged";
            this.colWheelDetailChanged.Visible = true;
            this.colWheelDetailChanged.VisibleIndex = 3;
            // 
            // colIsUsedGoodReceived
            // 
            this.colIsUsedGoodReceived.Caption = "Ban Bekas Diterima";
            this.colIsUsedGoodReceived.FieldName = "IsUsedWheelRetrieved";
            this.colIsUsedGoodReceived.Name = "colIsUsedGoodReceived";
            this.colIsUsedGoodReceived.Visible = true;
            this.colIsUsedGoodReceived.VisibleIndex = 4;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Harga";
            this.colPrice.DisplayFormat.FormatString = "#,#";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 5;
            // 
            // lookUpSparepartWheelGv
            // 
            this.lookUpSparepartWheelGv.AutoHeight = false;
            this.lookUpSparepartWheelGv.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpSparepartWheelGv.DisplayMember = "Name";
            this.lookUpSparepartWheelGv.Name = "lookUpSparepartWheelGv";
            this.lookUpSparepartWheelGv.NullText = "-- Pilih Jenis Ban --";
            this.lookUpSparepartWheelGv.ValueMember = "Id";
            // 
            // lblCostEstimation
            // 
            this.lblCostEstimation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCostEstimation.Location = new System.Drawing.Point(9, 157);
            this.lblCostEstimation.Name = "lblCostEstimation";
            this.lblCostEstimation.Size = new System.Drawing.Size(84, 13);
            this.lblCostEstimation.TabIndex = 20;
            this.lblCostEstimation.Text = "Perkiraan Ongkos";
            // 
            // txtCostEstimation
            // 
            this.txtCostEstimation.Location = new System.Drawing.Point(105, 154);
            this.txtCostEstimation.Name = "txtCostEstimation";
            this.txtCostEstimation.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCostEstimation.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCostEstimation.Properties.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.txtCostEstimation.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCostEstimation.Properties.Mask.EditMask = "d";
            this.txtCostEstimation.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCostEstimation.Size = new System.Drawing.Size(161, 20);
            this.txtCostEstimation.TabIndex = 19;
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(9, 54);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Jenis layanan";
            // 
            // txtKilometer
            // 
            this.txtKilometer.Location = new System.Drawing.Point(105, 128);
            this.txtKilometer.Name = "txtKilometer";
            this.txtKilometer.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtKilometer.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKilometer.Properties.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.txtKilometer.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtKilometer.Size = new System.Drawing.Size(161, 20);
            this.txtKilometer.TabIndex = 3;
            // 
            // lblVehicle
            // 
            this.lblVehicle.Location = new System.Drawing.Point(9, 79);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(52, 13);
            this.lblVehicle.TabIndex = 0;
            this.lblVehicle.Text = "Kendaraan";
            // 
            // lblKilometer
            // 
            this.lblKilometer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKilometer.Location = new System.Drawing.Point(9, 131);
            this.lblKilometer.Name = "lblKilometer";
            this.lblKilometer.Size = new System.Drawing.Size(44, 13);
            this.lblKilometer.TabIndex = 18;
            this.lblKilometer.Text = "Kilometer";
            // 
            // lookUpCategory
            // 
            this.lookUpCategory.Location = new System.Drawing.Point(105, 50);
            this.lookUpCategory.Name = "lookUpCategory";
            this.lookUpCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lookUpCategory.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Kategori")});
            this.lookUpCategory.Properties.DisplayMember = "Name";
            this.lookUpCategory.Properties.HideSelection = false;
            this.lookUpCategory.Properties.NullText = "-- Pilih Layanan --";
            this.lookUpCategory.Properties.ValueMember = "Id";
            this.lookUpCategory.Size = new System.Drawing.Size(161, 20);
            this.lookUpCategory.TabIndex = 0;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Kategori harus dipilih!";
            this.valCategory.SetValidationRule(this.lookUpCategory, conditionValidationRule2);
            this.lookUpCategory.EditValueChanged += new System.EventHandler(this.lookUpCategory_EditValueChanged);
            // 
            // lblContractor
            // 
            this.lblContractor.Location = new System.Drawing.Point(303, 78);
            this.lblContractor.Name = "lblContractor";
            this.lblContractor.Size = new System.Drawing.Size(77, 13);
            this.lblContractor.TabIndex = 16;
            this.lblContractor.Text = "Ketua Borongan";
            // 
            // LookUpVehicle
            // 
            this.LookUpVehicle.Location = new System.Drawing.Point(105, 76);
            this.LookUpVehicle.Name = "LookUpVehicle";
            this.LookUpVehicle.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.LookUpVehicle.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.LookUpVehicle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpVehicle.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ActiveLicenseNumber", "Nopol"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VehicleGroupName", "Kelompok"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Kode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kilometers", "Kilometer"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Customer")});
            this.LookUpVehicle.Properties.DisplayMember = "ActiveLicenseNumber";
            this.LookUpVehicle.Properties.HideSelection = false;
            this.LookUpVehicle.Properties.NullText = "-- Pilih Kendaraan --";
            this.LookUpVehicle.Properties.ValueMember = "Id";
            this.LookUpVehicle.Size = new System.Drawing.Size(161, 20);
            this.LookUpVehicle.TabIndex = 1;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Kendaraan harus dipilih!";
            this.valVehicle.SetValidationRule(this.LookUpVehicle, conditionValidationRule3);
            this.LookUpVehicle.EditValueChanged += new System.EventHandler(this.LookUpVehicle_EditValueChanged);
            // 
            // txtContractor
            // 
            this.txtContractor.Location = new System.Drawing.Point(404, 75);
            this.txtContractor.Name = "txtContractor";
            this.txtContractor.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtContractor.Size = new System.Drawing.Size(161, 20);
            this.txtContractor.TabIndex = 5;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.EditValue = null;
            this.dtpDueDate.Location = new System.Drawing.Point(105, 102);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dtpDueDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDueDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDueDate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.dtpDueDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpDueDate.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.dtpDueDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtpDueDate.Size = new System.Drawing.Size(161, 20);
            this.dtpDueDate.TabIndex = 2;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Batas waktu pengerjaan harus diisi!";
            this.valDueDate.SetValidationRule(this.dtpDueDate, conditionValidationRule4);
            // 
            // lblDueDate
            // 
            this.lblDueDate.Location = new System.Drawing.Point(9, 105);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(62, 13);
            this.lblDueDate.TabIndex = 4;
            this.lblDueDate.Text = "Jatuh Tempo";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(303, 131);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Deskripsi SPK";
            // 
            // lblContractPrice
            // 
            this.lblContractPrice.Location = new System.Drawing.Point(303, 105);
            this.lblContractPrice.Name = "lblContractPrice";
            this.lblContractPrice.Size = new System.Drawing.Size(71, 13);
            this.lblContractPrice.TabIndex = 7;
            this.lblContractPrice.Text = "Tarif Borongan";
            // 
            // memoDescription
            // 
            this.memoDescription.Location = new System.Drawing.Point(404, 129);
            this.memoDescription.Name = "memoDescription";
            this.memoDescription.Size = new System.Drawing.Size(161, 50);
            this.memoDescription.TabIndex = 7;
            // 
            // ckeIsContractWork
            // 
            this.ckeIsContractWork.Location = new System.Drawing.Point(301, 50);
            this.ckeIsContractWork.Name = "ckeIsContractWork";
            this.ckeIsContractWork.Properties.Caption = "Borongan";
            this.ckeIsContractWork.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ckeIsContractWork.Size = new System.Drawing.Size(119, 19);
            this.ckeIsContractWork.TabIndex = 4;
            this.ckeIsContractWork.CheckedChanged += new System.EventHandler(this.ckeIsContractWork_CheckedChanged);
            // 
            // txtContractWorkFee
            // 
            this.txtContractWorkFee.Location = new System.Drawing.Point(404, 102);
            this.txtContractWorkFee.Name = "txtContractWorkFee";
            this.txtContractWorkFee.Properties.Appearance.Options.UseTextOptions = true;
            this.txtContractWorkFee.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtContractWorkFee.Properties.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.txtContractWorkFee.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtContractWorkFee.Properties.Mask.EditMask = "d";
            this.txtContractWorkFee.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtContractWorkFee.Size = new System.Drawing.Size(161, 20);
            this.txtContractWorkFee.TabIndex = 6;
            // 
            // lblValLastUsageQty
            // 
            this.lblValLastUsageQty.Location = new System.Drawing.Point(410, 70);
            this.lblValLastUsageQty.Name = "lblValLastUsageQty";
            this.lblValLastUsageQty.Size = new System.Drawing.Size(8, 13);
            this.lblValLastUsageQty.TabIndex = 24;
            this.lblValLastUsageQty.Text = "--";
            // 
            // lblValLastUsageDate
            // 
            this.lblValLastUsageDate.Location = new System.Drawing.Point(410, 40);
            this.lblValLastUsageDate.Name = "lblValLastUsageDate";
            this.lblValLastUsageDate.Size = new System.Drawing.Size(8, 13);
            this.lblValLastUsageDate.TabIndex = 22;
            this.lblValLastUsageDate.Text = "--";
            // 
            // lblLastUsedQty
            // 
            this.lblLastUsedQty.Location = new System.Drawing.Point(252, 70);
            this.lblLastUsedQty.Name = "lblLastUsedQty";
            this.lblLastUsedQty.Size = new System.Drawing.Size(136, 13);
            this.lblLastUsedQty.TabIndex = 23;
            this.lblLastUsedQty.Text = "Jumlah penggantian terakhir";
            // 
            // lblLastUsageDate
            // 
            this.lblLastUsageDate.Location = new System.Drawing.Point(252, 39);
            this.lblLastUsageDate.Name = "lblLastUsageDate";
            this.lblLastUsageDate.Size = new System.Drawing.Size(141, 13);
            this.lblLastUsageDate.TabIndex = 21;
            this.lblLastUsageDate.Text = "Tanggal penggantian terakhir";
            // 
            // ckeIsReturnRequired
            // 
            this.ckeIsReturnRequired.Location = new System.Drawing.Point(252, 6);
            this.ckeIsReturnRequired.Name = "ckeIsReturnRequired";
            this.ckeIsReturnRequired.Properties.Caption = "BS Diterima";
            this.ckeIsReturnRequired.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ckeIsReturnRequired.Size = new System.Drawing.Size(175, 19);
            this.ckeIsReturnRequired.TabIndex = 18;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Nomor Seri";
            // 
            // lookUpSerialNumber
            // 
            this.lookUpSerialNumber.Location = new System.Drawing.Point(75, 67);
            this.lookUpSerialNumber.Name = "lookUpSerialNumber";
            this.lookUpSerialNumber.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookUpSerialNumber.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpSerialNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpSerialNumber.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SerialNumber", "Nomor Seri")});
            this.lookUpSerialNumber.Properties.DisplayMember = "SerialNumber";
            this.lookUpSerialNumber.Properties.HideSelection = false;
            this.lookUpSerialNumber.Properties.NullText = "";
            this.lookUpSerialNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpSerialNumber.Properties.ValueMember = "Id";
            this.lookUpSerialNumber.Size = new System.Drawing.Size(161, 20);
            this.lookUpSerialNumber.TabIndex = 16;
            // 
            // lookUpSparepart
            // 
            this.lookUpSparepart.Location = new System.Drawing.Point(75, 5);
            this.lookUpSparepart.Name = "lookUpSparepart";
            this.lookUpSparepart.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookUpSparepart.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpSparepart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpSparepart.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Sparepart"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockQty", "Stok"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Kode")});
            this.lookUpSparepart.Properties.DisplayMember = "Name";
            this.lookUpSparepart.Properties.HideSelection = false;
            this.lookUpSparepart.Properties.NullText = "";
            this.lookUpSparepart.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpSparepart.Properties.ValueMember = "Id";
            this.lookUpSparepart.Size = new System.Drawing.Size(161, 20);
            this.lookUpSparepart.TabIndex = 13;
            this.lookUpSparepart.EditValueChanged += new System.EventHandler(this.lookUpSparepart_EditValueChanged);
            // 
            // btnAddSparepart
            // 
            this.btnAddSparepart.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.add_item_16x16;
            this.btnAddSparepart.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAddSparepart.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddSparepart.Location = new System.Drawing.Point(5, 109);
            this.btnAddSparepart.Name = "btnAddSparepart";
            this.btnAddSparepart.Size = new System.Drawing.Size(123, 23);
            this.btnAddSparepart.TabIndex = 20;
            this.btnAddSparepart.Text = "Tambah Sparepart";
            this.btnAddSparepart.Click += new System.EventHandler(this.btnAddSparepart_Click);
            // 
            // lblSparepart
            // 
            this.lblSparepart.Location = new System.Drawing.Point(6, 8);
            this.lblSparepart.Name = "lblSparepart";
            this.lblSparepart.Size = new System.Drawing.Size(48, 13);
            this.lblSparepart.TabIndex = 14;
            this.lblSparepart.Text = "Sparepart";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(75, 36);
            this.txtQty.Name = "txtQty";
            this.txtQty.Properties.Mask.EditMask = "n0";
            this.txtQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQty.Size = new System.Drawing.Size(161, 20);
            this.txtQty.TabIndex = 15;
            // 
            // lblQty
            // 
            this.lblQty.Location = new System.Drawing.Point(6, 40);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(33, 13);
            this.lblQty.TabIndex = 17;
            this.lblQty.Text = "Jumlah";
            // 
            // gcSparepart
            // 
            this.gcSparepart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSparepart.Location = new System.Drawing.Point(5, 195);
            this.gcSparepart.MainView = this.gvSparepart;
            this.gcSparepart.Name = "gcSparepart";
            this.gcSparepart.Size = new System.Drawing.Size(524, 273);
            this.gcSparepart.TabIndex = 25;
            this.gcSparepart.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSparepart});
            // 
            // gvSparepart
            // 
            this.gvSparepart.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSparepartName,
            this.colSparepartCode,
            this.colTotalQty,
            this.colTotalPrice});
            this.gvSparepart.GridControl = this.gcSparepart;
            this.gvSparepart.Name = "gvSparepart";
            this.gvSparepart.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSparepart.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSparepart.OptionsBehavior.AutoPopulateColumns = false;
            this.gvSparepart.OptionsBehavior.Editable = false;
            this.gvSparepart.OptionsBehavior.ReadOnly = true;
            this.gvSparepart.OptionsCustomization.AllowColumnMoving = false;
            this.gvSparepart.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvSparepart.OptionsMenu.EnableFooterMenu = false;
            this.gvSparepart.OptionsView.ShowGroupPanel = false;
            this.gvSparepart.OptionsView.ShowViewCaption = true;
            this.gvSparepart.ViewCaption = "Penggunaan Sparepart";
            // 
            // colSparepartName
            // 
            this.colSparepartName.Caption = "Sparepart";
            this.colSparepartName.FieldName = "Sparepart.Name";
            this.colSparepartName.Name = "colSparepartName";
            this.colSparepartName.Visible = true;
            this.colSparepartName.VisibleIndex = 0;
            // 
            // colSparepartCode
            // 
            this.colSparepartCode.Caption = "Kode";
            this.colSparepartCode.FieldName = "Sparepart.Code";
            this.colSparepartCode.Name = "colSparepartCode";
            this.colSparepartCode.Visible = true;
            this.colSparepartCode.VisibleIndex = 1;
            // 
            // colTotalQty
            // 
            this.colTotalQty.Caption = "Jumlah";
            this.colTotalQty.FieldName = "TotalQuantity";
            this.colTotalQty.Name = "colTotalQty";
            this.colTotalQty.Visible = true;
            this.colTotalQty.VisibleIndex = 2;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "Total Harga";
            this.colTotalPrice.DisplayFormat.FormatString = "{0:#,#;0}";
            this.colTotalPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 3;
            // 
            // txtTotalSparepartPrice
            // 
            this.txtTotalSparepartPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalSparepartPrice.Location = new System.Drawing.Point(993, 502);
            this.txtTotalSparepartPrice.Name = "txtTotalSparepartPrice";
            this.txtTotalSparepartPrice.Properties.AllowFocused = false;
            this.txtTotalSparepartPrice.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalSparepartPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotalSparepartPrice.Properties.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.txtTotalSparepartPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalSparepartPrice.Properties.Mask.EditMask = "d";
            this.txtTotalSparepartPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalSparepartPrice.Size = new System.Drawing.Size(134, 20);
            this.txtTotalSparepartPrice.TabIndex = 14;
            // 
            // lblTotalSparepart
            // 
            this.lblTotalSparepart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalSparepart.Location = new System.Drawing.Point(873, 505);
            this.lblTotalSparepart.Name = "lblTotalSparepart";
            this.lblTotalSparepart.Size = new System.Drawing.Size(107, 13);
            this.lblTotalSparepart.TabIndex = 13;
            this.lblTotalSparepart.Text = "Total Harga Sparepart";
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // cmsSparepartEditor
            // 
            this.cmsSparepartEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDeleteDataSparepart});
            this.cmsSparepartEditor.Name = "cmsListEditor";
            this.cmsSparepartEditor.Size = new System.Drawing.Size(136, 26);
            // 
            // cmsDeleteDataSparepart
            // 
            this.cmsDeleteDataSparepart.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.cmsDeleteDataSparepart.Name = "cmsDeleteDataSparepart";
            this.cmsDeleteDataSparepart.Size = new System.Drawing.Size(135, 22);
            this.cmsDeleteDataSparepart.Text = "Hapus Data";
            this.cmsDeleteDataSparepart.Click += new System.EventHandler(this.cmsDeleteDataSparepart_Click);
            // 
            // cmsVehicleWheel
            // 
            this.cmsVehicleWheel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsVehicleWheelItemReset});
            this.cmsVehicleWheel.Name = "cmsListEditor";
            this.cmsVehicleWheel.Size = new System.Drawing.Size(130, 26);
            // 
            // cmsVehicleWheelItemReset
            // 
            this.cmsVehicleWheelItemReset.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources._1459465829_refresh;
            this.cmsVehicleWheelItemReset.Name = "cmsVehicleWheelItemReset";
            this.cmsVehicleWheelItemReset.Size = new System.Drawing.Size(129, 22);
            this.cmsVehicleWheelItemReset.Text = "Reset Data";
            this.cmsVehicleWheelItemReset.Click += new System.EventHandler(this.cmsVehicleWheelItemReset_Click);
            // 
            // bgwSave
            // 
            this.bgwSave.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSave_DoWork);
            this.bgwSave.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSave_RunWorkerCompleted);
            // 
            // SPKEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 585);
            this.Controls.Add(this.groupSPK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SPKEditorForm";
            this.Text = "SPK Editor";
            this.Controls.SetChildIndex(this.groupSPK, 0);
            ((System.ComponentModel.ISupportInitialize)(this.lookupWheelDetailGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeIsUsedWheelRetrieved)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSPK)).EndInit();
            this.groupSPK.ResumeLayout(false);
            this.groupSPK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehicleWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSparepartWheelGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostEstimation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKilometer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpVehicle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContractor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDueDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDueDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeIsContractWork.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContractWorkFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeIsReturnRequired.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSerialNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSparepart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalSparepartPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valDueDate)).EndInit();
            this.cmsSparepartEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleWheel)).EndInit();
            this.cmsVehicleWheel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.valDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupSPK;
        private DevExpress.XtraEditors.LabelControl lblVehicle;
        private DevExpress.XtraEditors.LookUpEdit lookUpCategory;
        private DevExpress.XtraEditors.LookUpEdit LookUpVehicle;
        private DevExpress.XtraEditors.LabelControl lblCategory;
        private DevExpress.XtraEditors.LabelControl lblDueDate;
        private DevExpress.XtraEditors.DateEdit dtpDueDate;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valVehicle;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valCategory;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valDueDate;
        private System.Windows.Forms.ContextMenuStrip cmsSparepartEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteDataSparepart;
        private DevExpress.XtraEditors.LabelControl lblTotalSparepart;
        private DevExpress.XtraEditors.MemoEdit memoDescription;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblContractPrice;
        private DevExpress.XtraEditors.TextEdit txtContractWorkFee;
        private DevExpress.XtraEditors.CheckEdit ckeIsContractWork;
        private System.Windows.Forms.BindingSource bsVehicleWheel;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookupWheelDetailGv;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ckeIsUsedWheelRetrieved;
        private System.Windows.Forms.ContextMenuStrip cmsVehicleWheel;
        private System.Windows.Forms.ToolStripMenuItem cmsVehicleWheelItemReset;
        private DevExpress.XtraEditors.TextEdit txtTotalSparepartPrice;
        private System.ComponentModel.BackgroundWorker bgwSave;
        private DevExpress.XtraEditors.LabelControl lblContractor;
        private DevExpress.XtraEditors.TextEdit txtContractor;
        private DevExpress.XtraEditors.TextEdit txtKilometer;
        private DevExpress.XtraEditors.LabelControl lblKilometer;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerMain;
        private DevExpress.XtraEditors.LabelControl lblValLastUsageQty;
        private DevExpress.XtraEditors.LabelControl lblValLastUsageDate;
        private DevExpress.XtraEditors.LabelControl lblLastUsedQty;
        private DevExpress.XtraEditors.LabelControl lblLastUsageDate;
        private DevExpress.XtraEditors.CheckEdit ckeIsReturnRequired;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpSerialNumber;
        private DevExpress.XtraEditors.LookUpEdit lookUpSparepart;
        private DevExpress.XtraEditors.SimpleButton btnAddSparepart;
        private DevExpress.XtraEditors.LabelControl lblSparepart;
        private DevExpress.XtraEditors.TextEdit txtQty;
        private DevExpress.XtraEditors.LabelControl lblQty;
        private DevExpress.XtraGrid.GridControl gcSparepart;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSparepart;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartName;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalQty;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl lblCostEstimation;
        private DevExpress.XtraEditors.TextEdit txtCostEstimation;
        private DevExpress.XtraEditors.SimpleButton btnAssignMechanic;
        private DevExpress.XtraEditors.SimpleButton btnChangeWheel;
        private DevExpress.XtraGrid.GridControl gridVehicleWheel;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVehicleWheel;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colWheelDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepart;
        private DevExpress.XtraGrid.Columns.GridColumn colWheelDetailChanged;
        private DevExpress.XtraGrid.Columns.GridColumn colIsUsedGoodReceived;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpSparepartWheelGv;
        private DevExpress.XtraEditors.DateEdit deTransDate;
        private DevExpress.XtraEditors.LabelControl lblTransactionDate;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valDate;
    }
}