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
            this.btnAddMecInternal = new DevExpress.XtraEditors.SimpleButton();
            this.gridSparepart = new DevExpress.XtraGrid.GridControl();
            this.gvSparepart = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSparepartCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepartCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddSparepart = new DevExpress.XtraEditors.SimpleButton();
            this.lblCategory = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtpDueDate = new DevExpress.XtraEditors.DateEdit();
            this.LookUpVehicle = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.lblVehicle = new DevExpress.XtraEditors.LabelControl();
            this.gridMechanic = new DevExpress.XtraGrid.GridControl();
            this.gvMechanic = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMechanicMechanic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddMecExternal = new DevExpress.XtraEditors.SimpleButton();
            this.colFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.valVehicle = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valCategory = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valDueDate = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcSPK)).BeginInit();
            this.gcSPK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDueDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDueDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpVehicle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMechanic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMechanic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valDueDate)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSPK
            // 
            this.gcSPK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSPK.Controls.Add(this.btnAddMecExternal);
            this.gcSPK.Controls.Add(this.gridMechanic);
            this.gcSPK.Controls.Add(this.btnAddMecInternal);
            this.gcSPK.Controls.Add(this.gridSparepart);
            this.gcSPK.Controls.Add(this.btnAddSparepart);
            this.gcSPK.Controls.Add(this.lblCategory);
            this.gcSPK.Controls.Add(this.labelControl1);
            this.gcSPK.Controls.Add(this.dtpDueDate);
            this.gcSPK.Controls.Add(this.LookUpVehicle);
            this.gcSPK.Controls.Add(this.lookUpCategory);
            this.gcSPK.Controls.Add(this.lblVehicle);
            this.gcSPK.Location = new System.Drawing.Point(-3, -1);
            this.gcSPK.Name = "gcSPK";
            this.gcSPK.Size = new System.Drawing.Size(477, 405);
            this.gcSPK.TabIndex = 0;
            this.gcSPK.Text = "Informasi SPK";
            // 
            // btnAddMecInternal
            // 
            this.btnAddMecInternal.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.add_mechanic_16x16;
            this.btnAddMecInternal.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAddMecInternal.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddMecInternal.Location = new System.Drawing.Point(15, 259);
            this.btnAddMecInternal.Name = "btnAddMecInternal";
            this.btnAddMecInternal.Size = new System.Drawing.Size(165, 23);
            this.btnAddMecInternal.TabIndex = 17;
            this.btnAddMecInternal.Text = "Tambah Mekanik Internal";
            // 
            // gridSparepart
            // 
            this.gridSparepart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSparepart.Location = new System.Drawing.Point(15, 141);
            this.gridSparepart.MainView = this.gvSparepart;
            this.gridSparepart.Name = "gridSparepart";
            this.gridSparepart.Size = new System.Drawing.Size(448, 98);
            this.gridSparepart.TabIndex = 16;
            this.gridSparepart.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSparepart});
            // 
            // gvSparepart
            // 
            this.gvSparepart.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSparepartCode,
            this.colSparepartName,
            this.colSparepartCategory,
            this.colPrice});
            this.gvSparepart.GridControl = this.gridSparepart;
            this.gvSparepart.Name = "gvSparepart";
            this.gvSparepart.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSparepart.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSparepart.OptionsBehavior.AutoPopulateColumns = false;
            this.gvSparepart.OptionsBehavior.Editable = false;
            this.gvSparepart.OptionsBehavior.ReadOnly = true;
            this.gvSparepart.OptionsCustomization.AllowColumnMoving = false;
            this.gvSparepart.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvSparepart.OptionsView.EnableAppearanceEvenRow = true;
            this.gvSparepart.OptionsView.ShowGroupPanel = false;
            this.gvSparepart.OptionsView.ShowViewCaption = true;
            this.gvSparepart.ViewCaption = "Penggunaan Sparepart";
            // 
            // colSparepartCategory
            // 
            this.colSparepartCategory.Caption = "Kategori";
            this.colSparepartCategory.FieldName = "CategoryReference.Value";
            this.colSparepartCategory.Name = "colSparepartCategory";
            this.colSparepartCategory.Visible = true;
            this.colSparepartCategory.VisibleIndex = 0;
            // 
            // colSparepartCode
            // 
            this.colSparepartCode.Caption = "Kode";
            this.colSparepartCode.FieldName = "Code";
            this.colSparepartCode.Name = "colSparepartCode";
            this.colSparepartCode.Visible = true;
            this.colSparepartCode.VisibleIndex = 1;
            // 
            // colSparepartName
            // 
            this.colSparepartName.Caption = "Nama";
            this.colSparepartName.FieldName = "Name";
            this.colSparepartName.Name = "colSparepartName";
            this.colSparepartName.Visible = true;
            this.colSparepartName.VisibleIndex = 2;
            // 
            // btnAddSparepart
            // 
            this.btnAddSparepart.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.add_item_16x16;
            this.btnAddSparepart.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAddSparepart.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddSparepart.Location = new System.Drawing.Point(15, 112);
            this.btnAddSparepart.Name = "btnAddSparepart";
            this.btnAddSparepart.Size = new System.Drawing.Size(123, 23);
            this.btnAddSparepart.TabIndex = 15;
            this.btnAddSparepart.Text = "Tambah Sparepart";
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
            this.dtpDueDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDueDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDueDate.Size = new System.Drawing.Size(175, 20);
            this.dtpDueDate.TabIndex = 11;
            // 
            // LookUpVehicle
            // 
            this.LookUpVehicle.Location = new System.Drawing.Point(124, 27);
            this.LookUpVehicle.Name = "LookUpVehicle";
            this.LookUpVehicle.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.LookUpVehicle.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.LookUpVehicle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpVehicle.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LicenseNumber", "Kendaraan")});
            this.LookUpVehicle.Properties.DisplayMember = "Value";
            this.LookUpVehicle.Properties.HideSelection = false;
            this.LookUpVehicle.Properties.NullText = "-- Pilih Kendaraan --";
            this.LookUpVehicle.Properties.ValueMember = "Id";
            this.LookUpVehicle.Size = new System.Drawing.Size(175, 20);
            this.LookUpVehicle.TabIndex = 10;
            // 
            // lookUpCategory
            // 
            this.lookUpCategory.Location = new System.Drawing.Point(124, 55);
            this.lookUpCategory.Name = "lookUpCategory";
            this.lookUpCategory.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Kategori")});
            this.lookUpCategory.Properties.DisplayMember = "Value";
            this.lookUpCategory.Properties.HideSelection = false;
            this.lookUpCategory.Properties.NullText = "-- Pilih Layanan --";
            this.lookUpCategory.Properties.ValueMember = "Id";
            this.lookUpCategory.Size = new System.Drawing.Size(175, 20);
            this.lookUpCategory.TabIndex = 9;
            // 
            // lblVehicle
            // 
            this.lblVehicle.Location = new System.Drawing.Point(15, 30);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(52, 13);
            this.lblVehicle.TabIndex = 2;
            this.lblVehicle.Text = "Kendaraan";
            // 
            // gridMechanic
            // 
            this.gridMechanic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridMechanic.Location = new System.Drawing.Point(15, 288);
            this.gridMechanic.MainView = this.gvMechanic;
            this.gridMechanic.Name = "gridMechanic";
            this.gridMechanic.Size = new System.Drawing.Size(448, 96);
            this.gridMechanic.TabIndex = 18;
            this.gridMechanic.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMechanic});
            // 
            // gvMechanic
            // 
            this.gvMechanic.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMechanicMechanic,
            this.gridColumnCode,
            this.colFee});
            this.gvMechanic.GridControl = this.gridMechanic;
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
            // colMechanicMechanic
            // 
            this.colMechanicMechanic.Caption = "Nama Mechanic";
            this.colMechanicMechanic.FieldName = "Name";
            this.colMechanicMechanic.Name = "colMechanicMechanic";
            this.colMechanicMechanic.Visible = true;
            this.colMechanicMechanic.VisibleIndex = 1;
            // 
            // gridColumnCode
            // 
            this.gridColumnCode.Caption = "Kode";
            this.gridColumnCode.FieldName = "Code";
            this.gridColumnCode.Name = "gridColumnCode";
            this.gridColumnCode.Visible = true;
            this.gridColumnCode.VisibleIndex = 0;
            // 
            // btnAddMecExternal
            // 
            this.btnAddMecExternal.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.add_mechanic_16x16;
            this.btnAddMecExternal.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAddMecExternal.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddMecExternal.Location = new System.Drawing.Point(186, 259);
            this.btnAddMecExternal.Name = "btnAddMecExternal";
            this.btnAddMecExternal.Size = new System.Drawing.Size(165, 23);
            this.btnAddMecExternal.TabIndex = 19;
            this.btnAddMecExternal.Text = "Tambah Mekanik Eksternal\r\n";
            // 
            // colFee
            // 
            this.colFee.Caption = "Ongkos";
            this.colFee.Name = "colFee";
            this.colFee.Visible = true;
            this.colFee.VisibleIndex = 2;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Harga";
            this.colPrice.FieldName = "SparePartDetail.Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            // 
            // SPKEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 445);
            this.Controls.Add(this.gcSPK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SPKEditorForm";
            this.Text = "SPK Editor";
            this.Controls.SetChildIndex(this.gcSPK, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcSPK)).EndInit();
            this.gcSPK.ResumeLayout(false);
            this.gcSPK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDueDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDueDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpVehicle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMechanic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMechanic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valDueDate)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btnAddMecInternal;
        private DevExpress.XtraGrid.GridControl gridSparepart;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSparepart;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartName;
        private DevExpress.XtraEditors.SimpleButton btnAddMecExternal;
        private DevExpress.XtraGrid.GridControl gridMechanic;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMechanic;
        private DevExpress.XtraGrid.Columns.GridColumn colMechanicMechanic;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFee;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valVehicle;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valCategory;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valDueDate;
    }
}