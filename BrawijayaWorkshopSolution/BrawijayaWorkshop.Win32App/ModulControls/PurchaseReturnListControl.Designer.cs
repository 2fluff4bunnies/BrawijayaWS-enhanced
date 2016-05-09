namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class PurchaseReturnListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseReturnListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.lblSupplier = new DevExpress.XtraEditors.LabelControl();
            this.cbSupplierFilter = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDateFilterTo = new DevExpress.XtraEditors.DateEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtDateFilterFrom = new DevExpress.XtraEditors.DateEdit();
            this.lblFilterDate = new DevExpress.XtraEditors.LabelControl();
            this.btnListReturn = new DevExpress.XtraEditors.SimpleButton();
            this.gridPurchasing = new DevExpress.XtraGrid.GridControl();
            this.gvPurchasing = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsAddReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEditReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPrintReturn = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSupplierFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchasing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchasing)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.lblSupplier);
            this.gcFilter.Controls.Add(this.cbSupplierFilter);
            this.gcFilter.Controls.Add(this.labelControl1);
            this.gcFilter.Controls.Add(this.txtDateFilterTo);
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.txtDateFilterFrom);
            this.gcFilter.Controls.Add(this.lblFilterDate);
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(742, 67);
            this.gcFilter.TabIndex = 1;
            this.gcFilter.Text = "Filter";
            // 
            // lblSupplier
            // 
            this.lblSupplier.Location = new System.Drawing.Point(413, 34);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(38, 13);
            this.lblSupplier.TabIndex = 15;
            this.lblSupplier.Text = "Supplier";
            // 
            // cbSupplierFilter
            // 
            this.cbSupplierFilter.Location = new System.Drawing.Point(467, 31);
            this.cbSupplierFilter.Name = "cbSupplierFilter";
            this.cbSupplierFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSupplierFilter.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Supplier")});
            this.cbSupplierFilter.Properties.DisplayMember = "Name";
            this.cbSupplierFilter.Properties.NullText = "Semua";
            this.cbSupplierFilter.Properties.ValueMember = "Id";
            this.cbSupplierFilter.Size = new System.Drawing.Size(186, 20);
            this.cbSupplierFilter.TabIndex = 14;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(241, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(4, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "-";
            // 
            // txtDateFilterTo
            // 
            this.txtDateFilterTo.EditValue = null;
            this.txtDateFilterTo.Location = new System.Drawing.Point(253, 31);
            this.txtDateFilterTo.Name = "txtDateFilterTo";
            this.txtDateFilterTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateFilterTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateFilterTo.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.txtDateFilterTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDateFilterTo.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.txtDateFilterTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDateFilterTo.Properties.HideSelection = false;
            this.txtDateFilterTo.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.txtDateFilterTo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtDateFilterTo.Size = new System.Drawing.Size(116, 20);
            this.txtDateFilterTo.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(664, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDateFilterFrom
            // 
            this.txtDateFilterFrom.EditValue = null;
            this.txtDateFilterFrom.Location = new System.Drawing.Point(118, 31);
            this.txtDateFilterFrom.Name = "txtDateFilterFrom";
            this.txtDateFilterFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateFilterFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateFilterFrom.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.txtDateFilterFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDateFilterFrom.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.txtDateFilterFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDateFilterFrom.Properties.HideSelection = false;
            this.txtDateFilterFrom.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.txtDateFilterFrom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtDateFilterFrom.Size = new System.Drawing.Size(116, 20);
            this.txtDateFilterFrom.TabIndex = 2;
            // 
            // lblFilterDate
            // 
            this.lblFilterDate.Location = new System.Drawing.Point(14, 34);
            this.lblFilterDate.Name = "lblFilterDate";
            this.lblFilterDate.Size = new System.Drawing.Size(89, 13);
            this.lblFilterDate.TabIndex = 1;
            this.lblFilterDate.Text = "Tanggal Pembelian";
            // 
            // btnListReturn
            // 
            this.btnListReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnListReturn.Image")));
            this.btnListReturn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnListReturn.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnListReturn.Location = new System.Drawing.Point(3, 76);
            this.btnListReturn.Name = "btnListReturn";
            this.btnListReturn.Size = new System.Drawing.Size(175, 23);
            this.btnListReturn.TabIndex = 5;
            this.btnListReturn.Text = "Lihat Daftar Retur Pembelian";
            this.btnListReturn.Click += new System.EventHandler(this.btnListReturn_Click);
            // 
            // gridPurchasing
            // 
            this.gridPurchasing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPurchasing.Location = new System.Drawing.Point(3, 105);
            this.gridPurchasing.MainView = this.gvPurchasing;
            this.gridPurchasing.Name = "gridPurchasing";
            this.gridPurchasing.Size = new System.Drawing.Size(742, 207);
            this.gridPurchasing.TabIndex = 6;
            this.gridPurchasing.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPurchasing});
            // 
            // gvPurchasing
            // 
            this.gvPurchasing.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colSupplierName,
            this.colTotalPrice});
            this.gvPurchasing.GridControl = this.gridPurchasing;
            this.gvPurchasing.Name = "gvPurchasing";
            this.gvPurchasing.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvPurchasing.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvPurchasing.OptionsBehavior.AutoPopulateColumns = false;
            this.gvPurchasing.OptionsBehavior.Editable = false;
            this.gvPurchasing.OptionsBehavior.ReadOnly = true;
            this.gvPurchasing.OptionsCustomization.AllowColumnMoving = false;
            this.gvPurchasing.OptionsCustomization.AllowFilter = false;
            this.gvPurchasing.OptionsCustomization.AllowGroup = false;
            this.gvPurchasing.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvPurchasing.OptionsDetail.AllowZoomDetail = false;
            this.gvPurchasing.OptionsDetail.EnableMasterViewMode = false;
            this.gvPurchasing.OptionsDetail.ShowDetailTabs = false;
            this.gvPurchasing.OptionsDetail.SmartDetailExpand = false;
            this.gvPurchasing.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPurchasing.OptionsView.ShowGroupPanel = false;
            this.gvPurchasing.OptionsView.ShowViewCaption = true;
            this.gvPurchasing.ViewCaption = "Daftar Pembelian";
            this.gvPurchasing.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvPurchasing_PopupMenuShowing);
            this.gvPurchasing.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvPurchasing_FocusedRowChanged);
            // 
            // colDate
            // 
            this.colDate.Caption = "Tanggal";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            // 
            // colSupplierName
            // 
            this.colSupplierName.Caption = "Supplier";
            this.colSupplierName.FieldName = "Supplier.Name";
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.Visible = true;
            this.colSupplierName.VisibleIndex = 1;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "Total Transaksi";
            this.colTotalPrice.DisplayFormat.FormatString = "{0:#,#}";
            this.colTotalPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 2;
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAddReturn,
            this.cmsEditReturn,
            this.cmsDeleteReturn,
            this.cmsPrintReturn});
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(149, 92);
            // 
            // cmsAddReturn
            // 
            this.cmsAddReturn.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.add_item_16x16;
            this.cmsAddReturn.Name = "cmsAddReturn";
            this.cmsAddReturn.Size = new System.Drawing.Size(148, 22);
            this.cmsAddReturn.Text = "Tambah Retur";
            this.cmsAddReturn.Click += new System.EventHandler(this.cmsAddReturn_Click);
            // 
            // cmsEditReturn
            // 
            this.cmsEditReturn.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.cmsEditReturn.Name = "cmsEditReturn";
            this.cmsEditReturn.Size = new System.Drawing.Size(148, 22);
            this.cmsEditReturn.Text = "Ubah Retur";
            this.cmsEditReturn.Click += new System.EventHandler(this.cmdEditReturn_Click);
            // 
            // cmsDeleteReturn
            // 
            this.cmsDeleteReturn.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.cmsDeleteReturn.Name = "cmsDeleteReturn";
            this.cmsDeleteReturn.Size = new System.Drawing.Size(148, 22);
            this.cmsDeleteReturn.Text = "Delete Retur";
            this.cmsDeleteReturn.Click += new System.EventHandler(this.cmsDeleteReturn_Click);
            // 
            // cmsPrintReturn
            // 
            this.cmsPrintReturn.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.print_16x16;
            this.cmsPrintReturn.Name = "cmsPrintReturn";
            this.cmsPrintReturn.Size = new System.Drawing.Size(148, 22);
            this.cmsPrintReturn.Text = "Cetak Retur";
            this.cmsPrintReturn.Click += new System.EventHandler(this.cmsPrintReturn_Click);
            // 
            // PurchaseReturnListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridPurchasing);
            this.Controls.Add(this.btnListReturn);
            this.Controls.Add(this.gcFilter);
            this.Name = "PurchaseReturnListControl";
            this.Size = new System.Drawing.Size(748, 315);
            this.Load += new System.EventHandler(this.PurchaseReturnListControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSupplierFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchasing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchasing)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtDateFilterTo;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.DateEdit txtDateFilterFrom;
        private DevExpress.XtraEditors.LabelControl lblFilterDate;
        private DevExpress.XtraEditors.SimpleButton btnListReturn;
        private DevExpress.XtraGrid.GridControl gridPurchasing;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPurchasing;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsAddReturn;
        private System.Windows.Forms.ToolStripMenuItem cmsEditReturn;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteReturn;
        private System.Windows.Forms.ToolStripMenuItem cmsPrintReturn;
        private DevExpress.XtraEditors.LabelControl lblSupplier;
        private DevExpress.XtraEditors.LookUpEdit cbSupplierFilter;
    }
}
