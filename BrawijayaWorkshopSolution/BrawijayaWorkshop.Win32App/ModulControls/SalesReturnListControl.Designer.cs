namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class SalesReturnListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReturnListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.lblCustomerFilter = new DevExpress.XtraEditors.LabelControl();
            this.cbCustomerFilter = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDateFilterTo = new DevExpress.XtraEditors.DateEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtDateFilterFrom = new DevExpress.XtraEditors.DateEdit();
            this.lblFilterDate = new DevExpress.XtraEditors.LabelControl();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.btnListReturn = new DevExpress.XtraEditors.SimpleButton();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsAddReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEditReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPrintReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.gridInvoice = new DevExpress.XtraGrid.GridControl();
            this.gvInvoice = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHasReturn = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCustomerFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).BeginInit();
            this.cmsEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.lblCustomerFilter);
            this.gcFilter.Controls.Add(this.cbCustomerFilter);
            this.gcFilter.Controls.Add(this.labelControl1);
            this.gcFilter.Controls.Add(this.txtDateFilterTo);
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.txtDateFilterFrom);
            this.gcFilter.Controls.Add(this.lblFilterDate);
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(667, 64);
            this.gcFilter.TabIndex = 1;
            this.gcFilter.Text = "Filter";
            // 
            // lblCustomerFilter
            // 
            this.lblCustomerFilter.Location = new System.Drawing.Point(403, 34);
            this.lblCustomerFilter.Name = "lblCustomerFilter";
            this.lblCustomerFilter.Size = new System.Drawing.Size(46, 13);
            this.lblCustomerFilter.TabIndex = 17;
            this.lblCustomerFilter.Text = "Customer";
            // 
            // cbCustomerFilter
            // 
            this.cbCustomerFilter.Location = new System.Drawing.Point(456, 31);
            this.cbCustomerFilter.Name = "cbCustomerFilter";
            this.cbCustomerFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCustomerFilter.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Supplier")});
            this.cbCustomerFilter.Properties.DisplayMember = "CompanyName";
            this.cbCustomerFilter.Properties.NullText = "Semua";
            this.cbCustomerFilter.Properties.ValueMember = "Id";
            this.cbCustomerFilter.Size = new System.Drawing.Size(135, 20);
            this.cbCustomerFilter.TabIndex = 16;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(237, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(4, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "-";
            // 
            // txtDateFilterTo
            // 
            this.txtDateFilterTo.EditValue = null;
            this.txtDateFilterTo.Location = new System.Drawing.Point(247, 31);
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
            this.txtDateFilterTo.Size = new System.Drawing.Size(122, 20);
            this.txtDateFilterTo.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(598, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDateFilterFrom
            // 
            this.txtDateFilterFrom.EditValue = null;
            this.txtDateFilterFrom.Location = new System.Drawing.Point(109, 31);
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
            this.txtDateFilterFrom.Size = new System.Drawing.Size(122, 20);
            this.txtDateFilterFrom.TabIndex = 2;
            // 
            // lblFilterDate
            // 
            this.lblFilterDate.Location = new System.Drawing.Point(14, 34);
            this.lblFilterDate.Name = "lblFilterDate";
            this.lblFilterDate.Size = new System.Drawing.Size(88, 13);
            this.lblFilterDate.TabIndex = 1;
            this.lblFilterDate.Text = "Tanggal Penjualan";
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // btnListReturn
            // 
            this.btnListReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnListReturn.Image")));
            this.btnListReturn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnListReturn.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnListReturn.Location = new System.Drawing.Point(3, 73);
            this.btnListReturn.Name = "btnListReturn";
            this.btnListReturn.Size = new System.Drawing.Size(175, 23);
            this.btnListReturn.TabIndex = 6;
            this.btnListReturn.Text = "Lihat Daftar Retur Penjualan";
            this.btnListReturn.Click += new System.EventHandler(this.btnListReturn_Click);
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAddReturn,
            this.cmsEditReturn,
            this.cmsDeleteReturn,
            this.cmsPrintReturn});
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(150, 92);
            // 
            // cmsAddReturn
            // 
            this.cmsAddReturn.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.add_item_16x16;
            this.cmsAddReturn.Name = "cmsAddReturn";
            this.cmsAddReturn.Size = new System.Drawing.Size(149, 22);
            this.cmsAddReturn.Text = "Tambah Retur";
            this.cmsAddReturn.Click += new System.EventHandler(this.cmsAddReturn_Click);
            // 
            // cmsEditReturn
            // 
            this.cmsEditReturn.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.cmsEditReturn.Name = "cmsEditReturn";
            this.cmsEditReturn.Size = new System.Drawing.Size(149, 22);
            this.cmsEditReturn.Text = "Ubah Retur";
            this.cmsEditReturn.Click += new System.EventHandler(this.cmsEditReturn_Click);
            // 
            // cmsDeleteReturn
            // 
            this.cmsDeleteReturn.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.cmsDeleteReturn.Name = "cmsDeleteReturn";
            this.cmsDeleteReturn.Size = new System.Drawing.Size(149, 22);
            this.cmsDeleteReturn.Text = "Hapus Retur";
            this.cmsDeleteReturn.Click += new System.EventHandler(this.cmsDeleteReturn_Click);
            // 
            // cmsPrintReturn
            // 
            this.cmsPrintReturn.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.print_16x16;
            this.cmsPrintReturn.Name = "cmsPrintReturn";
            this.cmsPrintReturn.Size = new System.Drawing.Size(149, 22);
            this.cmsPrintReturn.Text = "Cetak Retur";
            this.cmsPrintReturn.Click += new System.EventHandler(this.cmsPrintReturn_Click);
            // 
            // gridInvoice
            // 
            this.gridInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridInvoice.Location = new System.Drawing.Point(3, 102);
            this.gridInvoice.MainView = this.gvInvoice;
            this.gridInvoice.Name = "gridInvoice";
            this.gridInvoice.Size = new System.Drawing.Size(667, 210);
            this.gridInvoice.TabIndex = 8;
            this.gridInvoice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInvoice});
            // 
            // gvInvoice
            // 
            this.gvInvoice.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colCustomerName,
            this.colTotalPrice,
            this.colHasReturn});
            this.gvInvoice.GridControl = this.gridInvoice;
            this.gvInvoice.Name = "gvInvoice";
            this.gvInvoice.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvInvoice.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvInvoice.OptionsBehavior.AutoPopulateColumns = false;
            this.gvInvoice.OptionsBehavior.Editable = false;
            this.gvInvoice.OptionsBehavior.ReadOnly = true;
            this.gvInvoice.OptionsCustomization.AllowColumnMoving = false;
            this.gvInvoice.OptionsCustomization.AllowFilter = false;
            this.gvInvoice.OptionsCustomization.AllowGroup = false;
            this.gvInvoice.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvInvoice.OptionsDetail.AllowZoomDetail = false;
            this.gvInvoice.OptionsDetail.EnableMasterViewMode = false;
            this.gvInvoice.OptionsDetail.ShowDetailTabs = false;
            this.gvInvoice.OptionsDetail.SmartDetailExpand = false;
            this.gvInvoice.OptionsView.EnableAppearanceEvenRow = true;
            this.gvInvoice.OptionsView.ShowGroupPanel = false;
            this.gvInvoice.OptionsView.ShowViewCaption = true;
            this.gvInvoice.ViewCaption = "Daftar Penjualan";
            this.gvInvoice.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvInvoice_PopupMenuShowing);
            this.gvInvoice.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvInvoice_FocusedRowChanged);
            // 
            // colDate
            // 
            this.colDate.Caption = "Tanggal";
            this.colDate.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDate.FieldName = "CreateDate";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Customer";
            this.colCustomerName.FieldName = "SPK.Vehicle.Customer.CompanyName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
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
            // colHasReturn
            // 
            this.colHasReturn.Caption = "Ada Retur";
            this.colHasReturn.FieldName = "IsHasReturn";
            this.colHasReturn.Name = "colHasReturn";
            this.colHasReturn.Visible = true;
            this.colHasReturn.VisibleIndex = 3;
            // 
            // SalesReturnListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridInvoice);
            this.Controls.Add(this.btnListReturn);
            this.Controls.Add(this.gcFilter);
            this.Name = "SalesReturnListControl";
            this.Size = new System.Drawing.Size(673, 315);
            this.Load += new System.EventHandler(this.SalesReturnListControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCustomerFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtDateFilterTo;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.DateEdit txtDateFilterFrom;
        private DevExpress.XtraEditors.LabelControl lblFilterDate;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private DevExpress.XtraEditors.SimpleButton btnListReturn;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsAddReturn;
        private DevExpress.XtraGrid.GridControl gridInvoice;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInvoice;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private System.Windows.Forms.ToolStripMenuItem cmsEditReturn;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteReturn;
        private System.Windows.Forms.ToolStripMenuItem cmsPrintReturn;
        private DevExpress.XtraEditors.LabelControl lblCustomerFilter;
        private DevExpress.XtraEditors.LookUpEdit cbCustomerFilter;
        private DevExpress.XtraGrid.Columns.GridColumn colHasReturn;
    }
}
