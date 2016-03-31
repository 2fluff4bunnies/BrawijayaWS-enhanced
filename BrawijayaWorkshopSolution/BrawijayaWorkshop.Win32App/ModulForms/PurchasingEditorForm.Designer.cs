namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class PurchasingEditorForm
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
            this.txtDate = new DevExpress.XtraEditors.DateEdit();
            this.gcPurchasingInfo = new DevExpress.XtraEditors.GroupControl();
            this.btnAddSparepart = new DevExpress.XtraEditors.SimpleButton();
            this.gridPurchasingDetail = new DevExpress.XtraGrid.GridControl();
            this.gvPurchasingDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSparepart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbSparepartGv = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerialNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblSupplier = new DevExpress.XtraEditors.LabelControl();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.cbSupplier = new DevExpress.XtraEditors.LookUpEdit();
            this.pnlAction = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.valDate = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valSupplier = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSparepartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSparepartDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bsDetails = new System.Windows.Forms.BindingSource(this.components);
            this.bgwSave = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPurchasingInfo)).BeginInit();
            this.gcPurchasingInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchasingDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchasingDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSparepartGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valSupplier)).BeginInit();
            this.cmsEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDate
            // 
            this.txtDate.EditValue = null;
            this.txtDate.Location = new System.Drawing.Point(148, 27);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Properties.HideSelection = false;
            this.txtDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtDate.Size = new System.Drawing.Size(159, 20);
            this.txtDate.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Tanggal penerimaan harus diisi";
            this.valDate.SetValidationRule(this.txtDate, conditionValidationRule1);
            // 
            // gcPurchasingInfo
            // 
            this.gcPurchasingInfo.Controls.Add(this.btnAddSparepart);
            this.gcPurchasingInfo.Controls.Add(this.gridPurchasingDetail);
            this.gcPurchasingInfo.Controls.Add(this.lblSupplier);
            this.gcPurchasingInfo.Controls.Add(this.lblDate);
            this.gcPurchasingInfo.Controls.Add(this.txtDate);
            this.gcPurchasingInfo.Controls.Add(this.cbSupplier);
            this.gcPurchasingInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPurchasingInfo.Location = new System.Drawing.Point(0, 0);
            this.gcPurchasingInfo.Name = "gcPurchasingInfo";
            this.gcPurchasingInfo.Size = new System.Drawing.Size(578, 323);
            this.gcPurchasingInfo.TabIndex = 1;
            this.gcPurchasingInfo.Text = "Informasi Pembelian";
            // 
            // btnAddSparepart
            // 
            this.btnAddSparepart.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.add_item_16x16;
            this.btnAddSparepart.Location = new System.Drawing.Point(5, 95);
            this.btnAddSparepart.Name = "btnAddSparepart";
            this.btnAddSparepart.Size = new System.Drawing.Size(132, 23);
            this.btnAddSparepart.TabIndex = 6;
            this.btnAddSparepart.Text = "Tambah Sparepart";
            this.btnAddSparepart.Click += new System.EventHandler(this.btnAddSparepart_Click);
            // 
            // gridPurchasingDetail
            // 
            this.gridPurchasingDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPurchasingDetail.Location = new System.Drawing.Point(5, 124);
            this.gridPurchasingDetail.MainView = this.gvPurchasingDetail;
            this.gridPurchasingDetail.Name = "gridPurchasingDetail";
            this.gridPurchasingDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbSparepartGv});
            this.gridPurchasingDetail.Size = new System.Drawing.Size(568, 199);
            this.gridPurchasingDetail.TabIndex = 4;
            this.gridPurchasingDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPurchasingDetail});
            // 
            // gvPurchasingDetail
            // 
            this.gvPurchasingDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSparepart,
            this.colQty,
            this.colPrice,
            this.colSerialNumber});
            this.gvPurchasingDetail.GridControl = this.gridPurchasingDetail;
            this.gvPurchasingDetail.Name = "gvPurchasingDetail";
            this.gvPurchasingDetail.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvPurchasingDetail.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvPurchasingDetail.OptionsBehavior.AutoPopulateColumns = false;
            this.gvPurchasingDetail.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gvPurchasingDetail.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvPurchasingDetail.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPurchasingDetail.OptionsView.ShowGroupPanel = false;
            this.gvPurchasingDetail.OptionsView.ShowViewCaption = true;
            this.gvPurchasingDetail.ViewCaption = "Daftar Sparepart";
            this.gvPurchasingDetail.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvPurchasingDetail_InitNewRow);
            // 
            // colSparepart
            // 
            this.colSparepart.Caption = "Sparepart";
            this.colSparepart.ColumnEdit = this.cbSparepartGv;
            this.colSparepart.FieldName = "SparepartId";
            this.colSparepart.Name = "colSparepart";
            this.colSparepart.Visible = true;
            this.colSparepart.VisibleIndex = 0;
            // 
            // cbSparepartGv
            // 
            this.cbSparepartGv.AutoHeight = false;
            this.cbSparepartGv.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSparepartGv.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Sparepart")});
            this.cbSparepartGv.DisplayMember = "Name";
            this.cbSparepartGv.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.cbSparepartGv.Name = "cbSparepartGv";
            this.cbSparepartGv.NullText = "--Pilih Sparepart--";
            this.cbSparepartGv.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbSparepartGv.ValidateOnEnterKey = true;
            this.cbSparepartGv.ValueMember = "Id";
            // 
            // colQty
            // 
            this.colQty.Caption = "Jumlah";
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 1;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Harga per Item";
            this.colPrice.DisplayFormat.FormatString = "#,#";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            // 
            // colSerialNumber
            // 
            this.colSerialNumber.Caption = "Nomor Seri";
            this.colSerialNumber.FieldName = "SerialNumber";
            this.colSerialNumber.Name = "colSerialNumber";
            this.colSerialNumber.Visible = true;
            this.colSerialNumber.VisibleIndex = 3;
            // 
            // lblSupplier
            // 
            this.lblSupplier.Location = new System.Drawing.Point(19, 63);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(38, 13);
            this.lblSupplier.TabIndex = 3;
            this.lblSupplier.Text = "Supplier";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(19, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(89, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Tanggal Pembelian";
            // 
            // cbSupplier
            // 
            this.cbSupplier.Location = new System.Drawing.Point(148, 60);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSupplier.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Supplier")});
            this.cbSupplier.Properties.DisplayMember = "Name";
            this.cbSupplier.Properties.ImmediatePopup = true;
            this.cbSupplier.Properties.NullText = "";
            this.cbSupplier.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbSupplier.Properties.ValueMember = "Id";
            this.cbSupplier.Size = new System.Drawing.Size(159, 20);
            this.cbSupplier.TabIndex = 2;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Pilih salah satu supplier";
            this.valSupplier.SetValidationRule(this.cbSupplier, conditionValidationRule2);
            // 
            // pnlAction
            // 
            this.pnlAction.Appearance.BackColor = System.Drawing.Color.Silver;
            this.pnlAction.Appearance.Options.UseBackColor = true;
            this.pnlAction.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlAction.Location = new System.Drawing.Point(3, 315);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(570, 57);
            this.pnlAction.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(381, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Simpan";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(485, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Batal";
            // 
            // valDate
            // 
            this.valDate.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valSupplier
            // 
            this.valSupplier.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSparepartToolStripMenuItem,
            this.viewSparepartDetailToolStripMenuItem});
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(187, 48);
            // 
            // deleteSparepartToolStripMenuItem
            // 
            this.deleteSparepartToolStripMenuItem.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.deleteSparepartToolStripMenuItem.Name = "deleteSparepartToolStripMenuItem";
            this.deleteSparepartToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.deleteSparepartToolStripMenuItem.Text = "Hapus Sparepart";
            this.deleteSparepartToolStripMenuItem.Click += new System.EventHandler(this.deleteSparepartToolStripMenuItem_Click);
            // 
            // viewSparepartDetailToolStripMenuItem
            // 
            this.viewSparepartDetailToolStripMenuItem.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.history_16x16;
            this.viewSparepartDetailToolStripMenuItem.Name = "viewSparepartDetailToolStripMenuItem";
            this.viewSparepartDetailToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.viewSparepartDetailToolStripMenuItem.Text = "Lihat Sparepart Detail";
            this.viewSparepartDetailToolStripMenuItem.Click += new System.EventHandler(this.viewSparepartDetailToolStripMenuItem_Click);
            // 
            // bgwSave
            // 
            this.bgwSave.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSave_DoWork);
            this.bgwSave.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSave_RunWorkerCompleted);
            // 
            // PurchasingEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 372);
            this.Controls.Add(this.gcPurchasingInfo);
            this.Name = "PurchasingEditorForm";
            this.Text = "Form Pembelian Barang";
            this.Controls.SetChildIndex(this.gcPurchasingInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPurchasingInfo)).EndInit();
            this.gcPurchasingInfo.ResumeLayout(false);
            this.gcPurchasingInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchasingDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchasingDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSparepartGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valSupplier)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit txtDate;
        private DevExpress.XtraEditors.GroupControl gcPurchasingInfo;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.LabelControl lblSupplier;
        private DevExpress.XtraGrid.GridControl gridPurchasingDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPurchasingDetail;
        private DevExpress.XtraEditors.LookUpEdit cbSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepart;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraEditors.PanelControl pnlAction;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valDate;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valSupplier;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem deleteSparepartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSparepartDetailToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton btnAddSparepart;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbSparepartGv;
        private System.Windows.Forms.BindingSource bsDetails;
        private System.ComponentModel.BackgroundWorker bgwSave;
        private DevExpress.XtraGrid.Columns.GridColumn colSerialNumber;
    }
}