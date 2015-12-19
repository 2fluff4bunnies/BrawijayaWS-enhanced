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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPKEditorForm));
            this.gcSPK = new DevExpress.XtraEditors.GroupControl();
            this.lookUpMechanic = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpSparepart = new DevExpress.XtraEditors.LookUpEdit();
            this.lblFee = new DevExpress.XtraEditors.LabelControl();
            this.txtFee = new DevExpress.XtraEditors.TextEdit();
            this.lbMechanic = new DevExpress.XtraEditors.LabelControl();
            this.lblQty = new DevExpress.XtraEditors.LabelControl();
            this.txtQty = new DevExpress.XtraEditors.TextEdit();
            this.lblSparepart = new DevExpress.XtraEditors.LabelControl();
            this.gcMechanic = new DevExpress.XtraGrid.GridControl();
            this.gvMechanic = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMechanicMechanic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddMechanic = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddSparepart = new DevExpress.XtraEditors.SimpleButton();
            this.lblCategory = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
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
            this.gcSparepart = new DevExpress.XtraGrid.GridControl();
            this.gvSparepart = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSparepartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepartCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcSPK)).BeginInit();
            this.gcSPK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMechanic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSparepart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMechanic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMechanic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDueDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDueDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpVehicle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valDueDate)).BeginInit();
            this.cmsSparepartEditor.SuspendLayout();
            this.cmsMechanicEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSPK
            // 
            this.gcSPK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSPK.Controls.Add(this.gcSparepart);
            this.gcSPK.Controls.Add(this.lookUpMechanic);
            this.gcSPK.Controls.Add(this.lookUpSparepart);
            this.gcSPK.Controls.Add(this.lblFee);
            this.gcSPK.Controls.Add(this.txtFee);
            this.gcSPK.Controls.Add(this.lbMechanic);
            this.gcSPK.Controls.Add(this.lblQty);
            this.gcSPK.Controls.Add(this.txtQty);
            this.gcSPK.Controls.Add(this.lblSparepart);
            this.gcSPK.Controls.Add(this.gcMechanic);
            this.gcSPK.Controls.Add(this.btnAddMechanic);
            this.gcSPK.Controls.Add(this.btnAddSparepart);
            this.gcSPK.Controls.Add(this.lblCategory);
            this.gcSPK.Controls.Add(this.labelControl1);
            this.gcSPK.Controls.Add(this.dtpDueDate);
            this.gcSPK.Controls.Add(this.LookUpVehicle);
            this.gcSPK.Controls.Add(this.lookUpCategory);
            this.gcSPK.Controls.Add(this.lblVehicle);
            this.gcSPK.Location = new System.Drawing.Point(-3, -1);
            this.gcSPK.Name = "gcSPK";
            this.gcSPK.Size = new System.Drawing.Size(477, 391);
            this.gcSPK.TabIndex = 0;
            this.gcSPK.Text = "Informasi SPK";
            // 
            // lookUpMechanic
            // 
            this.lookUpMechanic.Location = new System.Drawing.Point(69, 260);
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
            this.lookUpMechanic.Size = new System.Drawing.Size(110, 20);
            this.lookUpMechanic.TabIndex = 6;
            // 
            // lookUpSparepart
            // 
            this.lookUpSparepart.Location = new System.Drawing.Point(69, 115);
            this.lookUpSparepart.Name = "lookUpSparepart";
            this.lookUpSparepart.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookUpSparepart.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpSparepart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpSparepart.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Sparepart"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StokQty", "Stok")});
            this.lookUpSparepart.Properties.DisplayMember = "Name";
            this.lookUpSparepart.Properties.HideSelection = false;
            this.lookUpSparepart.Properties.NullText = "";
            this.lookUpSparepart.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpSparepart.Properties.ValueMember = "Id";
            this.lookUpSparepart.Size = new System.Drawing.Size(110, 20);
            this.lookUpSparepart.TabIndex = 3;
            // 
            // lblFee
            // 
            this.lblFee.Location = new System.Drawing.Point(185, 263);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(36, 13);
            this.lblFee.TabIndex = 27;
            this.lblFee.Text = "Ongkos";
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(224, 260);
            this.txtFee.Name = "txtFee";
            this.txtFee.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtFee.Size = new System.Drawing.Size(100, 20);
            this.txtFee.TabIndex = 7;
            // 
            // lbMechanic
            // 
            this.lbMechanic.Location = new System.Drawing.Point(15, 263);
            this.lbMechanic.Name = "lbMechanic";
            this.lbMechanic.Size = new System.Drawing.Size(38, 13);
            this.lbMechanic.TabIndex = 25;
            this.lbMechanic.Text = "Mekanik";
            // 
            // lblQty
            // 
            this.lblQty.Location = new System.Drawing.Point(185, 118);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(33, 13);
            this.lblQty.TabIndex = 23;
            this.lblQty.Text = "Jumlah";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(224, 115);
            this.txtQty.Name = "txtQty";
            this.txtQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 4;
            // 
            // lblSparepart
            // 
            this.lblSparepart.Location = new System.Drawing.Point(15, 118);
            this.lblSparepart.Name = "lblSparepart";
            this.lblSparepart.Size = new System.Drawing.Size(48, 13);
            this.lblSparepart.TabIndex = 21;
            this.lblSparepart.Text = "Sparepart";
            // 
            // gridMechanic
            // 
            this.gcMechanic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcMechanic.Location = new System.Drawing.Point(15, 288);
            this.gcMechanic.MainView = this.gvMechanic;
            this.gcMechanic.Name = "gridMechanic";
            this.gcMechanic.Size = new System.Drawing.Size(448, 96);
            this.gcMechanic.TabIndex = 18;
            this.gcMechanic.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMechanic});
            // 
            // gvMechanic
            // 
            this.gvMechanic.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnCode,
            this.colMechanicMechanic,
            this.colFee});
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
            // gridColumnCode
            // 
            this.gridColumnCode.Caption = "Kode";
            this.gridColumnCode.FieldName = "Mechanic.Code";
            this.gridColumnCode.Name = "gridColumnCode";
            this.gridColumnCode.Visible = true;
            this.gridColumnCode.VisibleIndex = 0;
            // 
            // colMechanicMechanic
            // 
            this.colMechanicMechanic.Caption = "Nama Mechanic";
            this.colMechanicMechanic.FieldName = "Mechanic.Name";
            this.colMechanicMechanic.Name = "colMechanicMechanic";
            this.colMechanicMechanic.Visible = true;
            this.colMechanicMechanic.VisibleIndex = 1;
            // 
            // colFee
            // 
            this.colFee.Caption = "Ongkos";
            this.colFee.FieldName = "Fee";
            this.colFee.Name = "colFee";
            this.colFee.Visible = true;
            this.colFee.VisibleIndex = 2;
            // 
            // btnAddMechanic
            // 
            this.btnAddMechanic.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.add_mechanic_16x16;
            this.btnAddMechanic.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAddMechanic.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddMechanic.Location = new System.Drawing.Point(340, 259);
            this.btnAddMechanic.Name = "btnAddMechanic";
            this.btnAddMechanic.Size = new System.Drawing.Size(123, 23);
            this.btnAddMechanic.TabIndex = 8;
            this.btnAddMechanic.Text = "Tambah Mekanik";
            this.btnAddMechanic.Click += new System.EventHandler(this.btnAddMechanic_Click);
            // 
            // btnAddSparepart
            // 
            this.btnAddSparepart.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.add_item_16x16;
            this.btnAddSparepart.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAddSparepart.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddSparepart.Location = new System.Drawing.Point(340, 114);
            this.btnAddSparepart.Name = "btnAddSparepart";
            this.btnAddSparepart.Size = new System.Drawing.Size(123, 23);
            this.btnAddSparepart.TabIndex = 5;
            this.btnAddSparepart.Text = "Tambah Sparepart";
            this.btnAddSparepart.Click += new System.EventHandler(this.btnAddSparepart_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(15, 58);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 13);
            this.lblCategory.TabIndex = 13;
            this.lblCategory.Text = "Jenis layanan";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 84);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Batas waktu";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.EditValue = null;
            this.dtpDueDate.Location = new System.Drawing.Point(124, 81);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dtpDueDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDueDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDueDate.Size = new System.Drawing.Size(175, 20);
            this.dtpDueDate.TabIndex = 2;
            // 
            // LookUpVehicle
            // 
            this.LookUpVehicle.Location = new System.Drawing.Point(124, 28);
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
            this.LookUpVehicle.Size = new System.Drawing.Size(175, 20);
            this.LookUpVehicle.TabIndex = 0;
            // 
            // lookUpCategory
            // 
            this.lookUpCategory.Location = new System.Drawing.Point(124, 55);
            this.lookUpCategory.Name = "lookUpCategory";
            this.lookUpCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lookUpCategory.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Kategori")});
            this.lookUpCategory.Properties.DisplayMember = "Description";
            this.lookUpCategory.Properties.HideSelection = false;
            this.lookUpCategory.Properties.NullText = "-- Pilih Layanan --";
            this.lookUpCategory.Properties.ValueMember = "Id";
            this.lookUpCategory.Size = new System.Drawing.Size(175, 20);
            this.lookUpCategory.TabIndex = 1;
            // 
            // lblVehicle
            // 
            this.lblVehicle.Location = new System.Drawing.Point(15, 31);
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
            // gcSparepart
            // 
            this.gcSparepart.Location = new System.Drawing.Point(15, 143);
            this.gcSparepart.MainView = this.gvSparepart;
            this.gcSparepart.Name = "gcSparepart";
            this.gcSparepart.Size = new System.Drawing.Size(448, 99);
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
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 3;
            // 
            // SPKEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 431);
            this.Controls.Add(this.gcSPK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SPKEditorForm";
            this.Text = "SPK Editor";
            this.Controls.SetChildIndex(this.gcSPK, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcSPK)).EndInit();
            this.gcSPK.ResumeLayout(false);
            this.gcSPK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMechanic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSparepart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMechanic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMechanic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDueDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDueDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpVehicle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valDueDate)).EndInit();
            this.cmsSparepartEditor.ResumeLayout(false);
            this.cmsMechanicEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcSPK;
        private DevExpress.XtraEditors.LabelControl lblVehicle;
        private DevExpress.XtraEditors.LookUpEdit lookUpCategory;
        private DevExpress.XtraEditors.LookUpEdit LookUpVehicle;
        private DevExpress.XtraEditors.LabelControl lblCategory;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtpDueDate;
        private DevExpress.XtraEditors.SimpleButton btnAddSparepart;
        private DevExpress.XtraEditors.SimpleButton btnAddMechanic;
        private DevExpress.XtraGrid.GridControl gcMechanic;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMechanic;
        private DevExpress.XtraGrid.Columns.GridColumn colMechanicMechanic;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFee;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valVehicle;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valCategory;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valDueDate;
        private DevExpress.XtraEditors.LabelControl lblFee;
        private DevExpress.XtraEditors.TextEdit txtFee;
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
    }
}