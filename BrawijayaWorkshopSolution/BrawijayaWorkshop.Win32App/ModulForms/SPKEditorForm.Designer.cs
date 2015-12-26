namespace BrawijayaWorkshop.Win32App.ModulForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPKEditorForm));
            this.groupSPK = new DevExpress.XtraEditors.GroupControl();
            this.groupMechanic = new DevExpress.XtraEditors.GroupControl();
            this.chxIsRegistered = new DevExpress.XtraEditors.CheckEdit();
            this.btnAddMechanic = new DevExpress.XtraEditors.SimpleButton();
            this.txtMechanicDescription = new DevExpress.XtraEditors.TextEdit();
            this.gcMechanic = new DevExpress.XtraGrid.GridControl();
            this.gvMechanic = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMechanicName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMechanicDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblMechanicDescprition = new DevExpress.XtraEditors.LabelControl();
            this.lbMechanic = new DevExpress.XtraEditors.LabelControl();
            this.txtMechanicName = new DevExpress.XtraEditors.TextEdit();
            this.lookUpMechanic = new DevExpress.XtraEditors.LookUpEdit();
            this.memoDescription = new DevExpress.XtraEditors.MemoEdit();
            this.groupSparepart = new DevExpress.XtraEditors.GroupControl();
            this.lookUpSparepart = new DevExpress.XtraEditors.LookUpEdit();
            this.btnAddSparepart = new DevExpress.XtraEditors.SimpleButton();
            this.lblSparepart = new DevExpress.XtraEditors.LabelControl();
            this.txtQty = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalSparepartPrice = new DevExpress.XtraEditors.TextEdit();
            this.lblQty = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalSparepart = new DevExpress.XtraEditors.LabelControl();
            this.gcSparepart = new DevExpress.XtraGrid.GridControl();
            this.gvSparepart = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSparepartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepartCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblCategory = new DevExpress.XtraEditors.LabelControl();
            this.lblDueDate = new DevExpress.XtraEditors.LabelControl();
            this.dtpDueDate = new DevExpress.XtraEditors.DateEdit();
            this.LookUpVehicle = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.lblVehicle = new DevExpress.XtraEditors.LabelControl();
            this.valVehicle = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valCategory = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valDueDate = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.cmsSparepartEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeleteDataSparepart = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMechanicEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeleteDataMechanic = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwFingerPrint = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.groupSPK)).BeginInit();
            this.groupSPK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupMechanic)).BeginInit();
            this.groupMechanic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chxIsRegistered.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMechanicDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMechanic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMechanic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMechanicName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMechanic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSparepart)).BeginInit();
            this.groupSparepart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSparepart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalSparepartPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDueDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDueDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpVehicle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valDueDate)).BeginInit();
            this.cmsSparepartEditor.SuspendLayout();
            this.cmsMechanicEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupSPK
            // 
            this.groupSPK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSPK.Controls.Add(this.groupMechanic);
            this.groupSPK.Controls.Add(this.memoDescription);
            this.groupSPK.Controls.Add(this.groupSparepart);
            this.groupSPK.Controls.Add(this.labelControl2);
            this.groupSPK.Controls.Add(this.lblCategory);
            this.groupSPK.Controls.Add(this.lblDueDate);
            this.groupSPK.Controls.Add(this.dtpDueDate);
            this.groupSPK.Controls.Add(this.LookUpVehicle);
            this.groupSPK.Controls.Add(this.lookUpCategory);
            this.groupSPK.Controls.Add(this.lblVehicle);
            this.groupSPK.Location = new System.Drawing.Point(-3, -1);
            this.groupSPK.Name = "groupSPK";
            this.groupSPK.Size = new System.Drawing.Size(586, 560);
            this.groupSPK.TabIndex = 0;
            this.groupSPK.Text = "Informasi SPK";
            // 
            // groupMechanic
            // 
            this.groupMechanic.Controls.Add(this.chxIsRegistered);
            this.groupMechanic.Controls.Add(this.btnAddMechanic);
            this.groupMechanic.Controls.Add(this.txtMechanicDescription);
            this.groupMechanic.Controls.Add(this.gcMechanic);
            this.groupMechanic.Controls.Add(this.lblMechanicDescprition);
            this.groupMechanic.Controls.Add(this.lbMechanic);
            this.groupMechanic.Controls.Add(this.txtMechanicName);
            this.groupMechanic.Controls.Add(this.lookUpMechanic);
            this.groupMechanic.Location = new System.Drawing.Point(15, 343);
            this.groupMechanic.Name = "groupMechanic";
            this.groupMechanic.Size = new System.Drawing.Size(556, 209);
            this.groupMechanic.TabIndex = 4;
            this.groupMechanic.Text = "Mekanik";
            // 
            // chxIsRegistered
            // 
            this.chxIsRegistered.Location = new System.Drawing.Point(14, 26);
            this.chxIsRegistered.Name = "chxIsRegistered";
            this.chxIsRegistered.Properties.Caption = "Gunakan Daftar Mekanik";
            this.chxIsRegistered.Size = new System.Drawing.Size(138, 19);
            this.chxIsRegistered.TabIndex = 6;
            this.chxIsRegistered.CheckedChanged += new System.EventHandler(this.chxIsRegistered_CheckedChanged);
            // 
            // btnAddMechanic
            // 
            this.btnAddMechanic.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.add_mechanic_16x16;
            this.btnAddMechanic.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAddMechanic.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddMechanic.Location = new System.Drawing.Point(425, 75);
            this.btnAddMechanic.Name = "btnAddMechanic";
            this.btnAddMechanic.Size = new System.Drawing.Size(123, 23);
            this.btnAddMechanic.TabIndex = 8;
            this.btnAddMechanic.Text = "Tambah Mekanik";
            this.btnAddMechanic.Click += new System.EventHandler(this.btnAddMechanic_Click);
            // 
            // txtMechanicDescription
            // 
            this.txtMechanicDescription.Location = new System.Drawing.Point(94, 76);
            this.txtMechanicDescription.Name = "txtMechanicDescription";
            this.txtMechanicDescription.Size = new System.Drawing.Size(134, 20);
            this.txtMechanicDescription.TabIndex = 34;
            // 
            // gcMechanic
            // 
            this.gcMechanic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcMechanic.Location = new System.Drawing.Point(14, 104);
            this.gcMechanic.MainView = this.gvMechanic;
            this.gcMechanic.Name = "gcMechanic";
            this.gcMechanic.Size = new System.Drawing.Size(534, 96);
            this.gcMechanic.TabIndex = 18;
            this.gcMechanic.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMechanic});
            // 
            // gvMechanic
            // 
            this.gvMechanic.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMechanicName,
            this.colMechanicDescription});
            this.gvMechanic.GridControl = this.gcMechanic;
            this.gvMechanic.Name = "gvMechanic";
            this.gvMechanic.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvMechanic.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvMechanic.OptionsBehavior.AutoPopulateColumns = false;
            this.gvMechanic.OptionsBehavior.Editable = false;
            this.gvMechanic.OptionsBehavior.ReadOnly = true;
            this.gvMechanic.OptionsCustomization.AllowColumnMoving = false;
            this.gvMechanic.OptionsCustomization.AllowFilter = false;
            this.gvMechanic.OptionsCustomization.AllowGroup = false;
            this.gvMechanic.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvMechanic.OptionsView.ShowGroupPanel = false;
            this.gvMechanic.OptionsView.ShowViewCaption = true;
            this.gvMechanic.ViewCaption = "Mekanik Terlibat";
            // 
            // colMechanicName
            // 
            this.colMechanicName.Caption = "Nama";
            this.colMechanicName.FieldName = "Name";
            this.colMechanicName.Name = "colMechanicName";
            this.colMechanicName.Visible = true;
            this.colMechanicName.VisibleIndex = 0;
            // 
            // colMechanicDescription
            // 
            this.colMechanicDescription.Caption = "Keterangan";
            this.colMechanicDescription.FieldName = "Description";
            this.colMechanicDescription.Name = "colMechanicDescription";
            this.colMechanicDescription.Visible = true;
            this.colMechanicDescription.VisibleIndex = 1;
            // 
            // lblMechanicDescprition
            // 
            this.lblMechanicDescprition.Location = new System.Drawing.Point(14, 79);
            this.lblMechanicDescprition.Name = "lblMechanicDescprition";
            this.lblMechanicDescprition.Size = new System.Drawing.Size(56, 13);
            this.lblMechanicDescprition.TabIndex = 33;
            this.lblMechanicDescprition.Text = "Keterangan";
            // 
            // lbMechanic
            // 
            this.lbMechanic.Location = new System.Drawing.Point(14, 52);
            this.lbMechanic.Name = "lbMechanic";
            this.lbMechanic.Size = new System.Drawing.Size(38, 13);
            this.lbMechanic.TabIndex = 25;
            this.lbMechanic.Text = "Mekanik";
            // 
            // txtMechanicName
            // 
            this.txtMechanicName.Location = new System.Drawing.Point(94, 49);
            this.txtMechanicName.Name = "txtMechanicName";
            this.txtMechanicName.Size = new System.Drawing.Size(134, 20);
            this.txtMechanicName.TabIndex = 30;
            // 
            // lookUpMechanic
            // 
            this.lookUpMechanic.Location = new System.Drawing.Point(94, 50);
            this.lookUpMechanic.Name = "lookUpMechanic";
            this.lookUpMechanic.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookUpMechanic.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpMechanic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpMechanic.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Mekanik")});
            this.lookUpMechanic.Properties.DisplayMember = "Name";
            this.lookUpMechanic.Properties.HideSelection = false;
            this.lookUpMechanic.Properties.NullText = "";
            this.lookUpMechanic.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpMechanic.Properties.ValueMember = "Id";
            this.lookUpMechanic.Size = new System.Drawing.Size(134, 20);
            this.lookUpMechanic.TabIndex = 7;
            // 
            // memoDescription
            // 
            this.memoDescription.Location = new System.Drawing.Point(340, 29);
            this.memoDescription.Name = "memoDescription";
            this.memoDescription.Size = new System.Drawing.Size(231, 73);
            this.memoDescription.TabIndex = 36;
            // 
            // groupSparepart
            // 
            this.groupSparepart.Controls.Add(this.lookUpSparepart);
            this.groupSparepart.Controls.Add(this.btnAddSparepart);
            this.groupSparepart.Controls.Add(this.lblSparepart);
            this.groupSparepart.Controls.Add(this.txtQty);
            this.groupSparepart.Controls.Add(this.txtTotalSparepartPrice);
            this.groupSparepart.Controls.Add(this.lblQty);
            this.groupSparepart.Controls.Add(this.lblTotalSparepart);
            this.groupSparepart.Controls.Add(this.gcSparepart);
            this.groupSparepart.Location = new System.Drawing.Point(15, 107);
            this.groupSparepart.Name = "groupSparepart";
            this.groupSparepart.Size = new System.Drawing.Size(556, 230);
            this.groupSparepart.TabIndex = 3;
            this.groupSparepart.Text = "Sparepart";
            // 
            // lookUpSparepart
            // 
            this.lookUpSparepart.Location = new System.Drawing.Point(94, 25);
            this.lookUpSparepart.Name = "lookUpSparepart";
            this.lookUpSparepart.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookUpSparepart.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpSparepart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpSparepart.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Sparepart"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockQty", "Stok")});
            this.lookUpSparepart.Properties.DisplayMember = "Name";
            this.lookUpSparepart.Properties.HideSelection = false;
            this.lookUpSparepart.Properties.NullText = "";
            this.lookUpSparepart.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpSparepart.Properties.ValueMember = "Id";
            this.lookUpSparepart.Size = new System.Drawing.Size(134, 20);
            this.lookUpSparepart.TabIndex = 3;
            // 
            // btnAddSparepart
            // 
            this.btnAddSparepart.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.add_item_16x16;
            this.btnAddSparepart.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAddSparepart.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddSparepart.Location = new System.Drawing.Point(425, 52);
            this.btnAddSparepart.Name = "btnAddSparepart";
            this.btnAddSparepart.Size = new System.Drawing.Size(123, 23);
            this.btnAddSparepart.TabIndex = 5;
            this.btnAddSparepart.Text = "Tambah Sparepart";
            this.btnAddSparepart.Click += new System.EventHandler(this.btnAddSparepart_Click);
            // 
            // lblSparepart
            // 
            this.lblSparepart.Location = new System.Drawing.Point(14, 31);
            this.lblSparepart.Name = "lblSparepart";
            this.lblSparepart.Size = new System.Drawing.Size(48, 13);
            this.lblSparepart.TabIndex = 21;
            this.lblSparepart.Text = "Sparepart";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(94, 51);
            this.txtQty.Name = "txtQty";
            this.txtQty.Properties.Mask.EditMask = "n0";
            this.txtQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQty.Size = new System.Drawing.Size(134, 20);
            this.txtQty.TabIndex = 4;
            // 
            // txtTotalSparepartPrice
            // 
            this.txtTotalSparepartPrice.Location = new System.Drawing.Point(425, 199);
            this.txtTotalSparepartPrice.Name = "txtTotalSparepartPrice";
            this.txtTotalSparepartPrice.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalSparepartPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotalSparepartPrice.Properties.DisplayFormat.FormatString = "#,#";
            this.txtTotalSparepartPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalSparepartPrice.Properties.Mask.EditMask = "n0";
            this.txtTotalSparepartPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalSparepartPrice.Properties.ReadOnly = true;
            this.txtTotalSparepartPrice.Size = new System.Drawing.Size(123, 20);
            this.txtTotalSparepartPrice.TabIndex = 32;
            // 
            // lblQty
            // 
            this.lblQty.Location = new System.Drawing.Point(14, 54);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(33, 13);
            this.lblQty.TabIndex = 23;
            this.lblQty.Text = "Jumlah";
            // 
            // lblTotalSparepart
            // 
            this.lblTotalSparepart.Location = new System.Drawing.Point(344, 202);
            this.lblTotalSparepart.Name = "lblTotalSparepart";
            this.lblTotalSparepart.Size = new System.Drawing.Size(75, 13);
            this.lblTotalSparepart.TabIndex = 31;
            this.lblTotalSparepart.Text = "Total Sparepart";
            // 
            // gcSparepart
            // 
            this.gcSparepart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSparepart.Location = new System.Drawing.Point(14, 81);
            this.gcSparepart.MainView = this.gvSparepart;
            this.gcSparepart.Name = "gcSparepart";
            this.gcSparepart.Size = new System.Drawing.Size(534, 112);
            this.gcSparepart.TabIndex = 28;
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
            this.colTotalPrice.DisplayFormat.FormatString = "#,#";
            this.colTotalPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(271, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 35;
            this.labelControl2.Text = "Deskripsi SPK";
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(15, 58);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 13);
            this.lblCategory.TabIndex = 13;
            this.lblCategory.Text = "Jenis layanan";
            // 
            // lblDueDate
            // 
            this.lblDueDate.Location = new System.Drawing.Point(15, 84);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(62, 13);
            this.lblDueDate.TabIndex = 12;
            this.lblDueDate.Text = "Jatuh Tempo";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.EditValue = null;
            this.dtpDueDate.Location = new System.Drawing.Point(96, 81);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dtpDueDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDueDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDueDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtpDueDate.Size = new System.Drawing.Size(161, 20);
            this.dtpDueDate.TabIndex = 2;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Batas waktu pengerjaan harus diisi!";
            this.valDueDate.SetValidationRule(this.dtpDueDate, conditionValidationRule1);
            // 
            // LookUpVehicle
            // 
            this.LookUpVehicle.Location = new System.Drawing.Point(96, 28);
            this.LookUpVehicle.Name = "LookUpVehicle";
            this.LookUpVehicle.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.LookUpVehicle.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.LookUpVehicle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpVehicle.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Customer.CompanyName", "Customer"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ActiveLicenseNumber", "Nopol"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Brand", "Merek"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Type", "Tipe")});
            this.LookUpVehicle.Properties.DisplayMember = "ActiveLicenseNumber";
            this.LookUpVehicle.Properties.HideSelection = false;
            this.LookUpVehicle.Properties.NullText = "-- Pilih Kendaraan --";
            this.LookUpVehicle.Properties.ValueMember = "Id";
            this.LookUpVehicle.Size = new System.Drawing.Size(161, 20);
            this.LookUpVehicle.TabIndex = 0;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Kendaraan harus dipilih!";
            this.valVehicle.SetValidationRule(this.LookUpVehicle, conditionValidationRule2);
            // 
            // lookUpCategory
            // 
            this.lookUpCategory.Location = new System.Drawing.Point(96, 55);
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
            this.lookUpCategory.TabIndex = 1;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Kategori harus dipilih!";
            this.valCategory.SetValidationRule(this.lookUpCategory, conditionValidationRule3);
            // 
            // lblVehicle
            // 
            this.lblVehicle.Location = new System.Drawing.Point(15, 33);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(52, 13);
            this.lblVehicle.TabIndex = 2;
            this.lblVehicle.Text = "Kendaraan";
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
            // cmsMechanicEditor
            // 
            this.cmsMechanicEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDeleteDataMechanic});
            this.cmsMechanicEditor.Name = "cmsListEditor";
            this.cmsMechanicEditor.Size = new System.Drawing.Size(136, 26);
            // 
            // cmsDeleteDataMechanic
            // 
            this.cmsDeleteDataMechanic.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.cmsDeleteDataMechanic.Name = "cmsDeleteDataMechanic";
            this.cmsDeleteDataMechanic.Size = new System.Drawing.Size(135, 22);
            this.cmsDeleteDataMechanic.Text = "Hapus Data";
            this.cmsDeleteDataMechanic.Click += new System.EventHandler(this.cmsDeleteDataMechanic_Click);
            // 
            // bgwFingerPrint
            // 
            this.bgwFingerPrint.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwFingerPrint_DoWork);
            this.bgwFingerPrint.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwFingerPrint_RunWorkerCompleted);
            // 
            // SPKEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 600);
            this.Controls.Add(this.groupSPK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SPKEditorForm";
            this.Text = "SPK Editor";
            this.Controls.SetChildIndex(this.groupSPK, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupSPK)).EndInit();
            this.groupSPK.ResumeLayout(false);
            this.groupSPK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupMechanic)).EndInit();
            this.groupMechanic.ResumeLayout(false);
            this.groupMechanic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chxIsRegistered.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMechanicDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMechanic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMechanic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMechanicName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMechanic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSparepart)).EndInit();
            this.groupSparepart.ResumeLayout(false);
            this.groupSparepart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSparepart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalSparepartPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDueDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDueDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpVehicle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valDueDate)).EndInit();
            this.cmsSparepartEditor.ResumeLayout(false);
            this.cmsMechanicEditor.ResumeLayout(false);
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
        private DevExpress.XtraEditors.SimpleButton btnAddSparepart;
        private DevExpress.XtraEditors.SimpleButton btnAddMechanic;
        private DevExpress.XtraGrid.GridControl gcMechanic;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMechanic;
        private DevExpress.XtraGrid.Columns.GridColumn colMechanicName;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valVehicle;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valCategory;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valDueDate;
        private DevExpress.XtraEditors.LabelControl lbMechanic;
        private DevExpress.XtraEditors.LabelControl lblQty;
        private DevExpress.XtraEditors.LabelControl lblSparepart;
        private DevExpress.XtraEditors.LookUpEdit lookUpMechanic;
        private System.Windows.Forms.ContextMenuStrip cmsSparepartEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteDataSparepart;
        private System.Windows.Forms.ContextMenuStrip cmsMechanicEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteDataMechanic;
        private DevExpress.XtraEditors.LookUpEdit lookUpSparepart;
        private DevExpress.XtraEditors.TextEdit txtQty;
        private DevExpress.XtraGrid.GridControl gcSparepart;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSparepart;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartName;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalQty;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private System.ComponentModel.BackgroundWorker bgwFingerPrint;
        private DevExpress.XtraEditors.CheckEdit chxIsRegistered;
        private DevExpress.XtraEditors.TextEdit txtMechanicName;
        private DevExpress.XtraEditors.LabelControl lblTotalSparepart;
        private DevExpress.XtraEditors.TextEdit txtTotalSparepartPrice;
        private DevExpress.XtraEditors.MemoEdit memoDescription;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMechanicDescription;
        private DevExpress.XtraEditors.LabelControl lblMechanicDescprition;
        private DevExpress.XtraEditors.GroupControl groupSparepart;
        private DevExpress.XtraEditors.GroupControl groupMechanic;
        private DevExpress.XtraGrid.Columns.GridColumn colMechanicDescription;
    }
}