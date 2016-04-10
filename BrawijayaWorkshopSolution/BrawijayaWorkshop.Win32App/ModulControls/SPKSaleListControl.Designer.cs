namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class SPKSaleListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPKSaleListControl));
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.btnNewSale = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDateFilterTo = new DevExpress.XtraEditors.DateEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtDateFilterFrom = new DevExpress.XtraEditors.DateEdit();
            this.lblFilterDate = new DevExpress.XtraEditors.LabelControl();
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.gcSPKSales = new DevExpress.XtraGrid.GridControl();
            this.gvSPKSales = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLicenseNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmsEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSPKSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSPKSales)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsEditData
            // 
            this.cmsEditData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.cmsEditData.Name = "cmsEditData";
            this.cmsEditData.Size = new System.Drawing.Size(129, 22);
            this.cmsEditData.Text = "Ubah Data";
            this.cmsEditData.Click += new System.EventHandler(this.cmsEditData_Click);
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditData});
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(130, 26);
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // btnNewSale
            // 
            this.btnNewSale.Image = ((System.Drawing.Image)(resources.GetObject("btnNewSale.Image")));
            this.btnNewSale.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewSale.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewSale.Location = new System.Drawing.Point(3, 73);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(144, 23);
            this.btnNewSale.TabIndex = 6;
            this.btnNewSale.Text = "Buat Penjualan Baru";
            this.btnNewSale.Click += new System.EventHandler(this.btnNewSale_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(284, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(4, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "-";
            // 
            // txtDateFilterTo
            // 
            this.txtDateFilterTo.EditValue = null;
            this.txtDateFilterTo.Location = new System.Drawing.Point(294, 31);
            this.txtDateFilterTo.Name = "txtDateFilterTo";
            this.txtDateFilterTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateFilterTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateFilterTo.Properties.HideSelection = false;
            this.txtDateFilterTo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtDateFilterTo.Size = new System.Drawing.Size(138, 20);
            this.txtDateFilterTo.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(438, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDateFilterFrom
            // 
            this.txtDateFilterFrom.EditValue = null;
            this.txtDateFilterFrom.Location = new System.Drawing.Point(140, 31);
            this.txtDateFilterFrom.Name = "txtDateFilterFrom";
            this.txtDateFilterFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateFilterFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateFilterFrom.Properties.HideSelection = false;
            this.txtDateFilterFrom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtDateFilterFrom.Size = new System.Drawing.Size(138, 20);
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
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.labelControl1);
            this.gcFilter.Controls.Add(this.txtDateFilterTo);
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.txtDateFilterFrom);
            this.gcFilter.Controls.Add(this.lblFilterDate);
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(632, 64);
            this.gcFilter.TabIndex = 5;
            this.gcFilter.Text = "Filter";
            // 
            // gcSPKSales
            // 
            this.gcSPKSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSPKSales.Location = new System.Drawing.Point(3, 102);
            this.gcSPKSales.MainView = this.gvSPKSales;
            this.gcSPKSales.Name = "gcSPKSales";
            this.gcSPKSales.Size = new System.Drawing.Size(632, 210);
            this.gcSPKSales.TabIndex = 7;
            this.gcSPKSales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSPKSales});
            // 
            // gvSPKSales
            // 
            this.gvSPKSales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colLicenseNumber,
            this.colTotalPrice,
            this.colCreateDate});
            this.gvSPKSales.GridControl = this.gcSPKSales;
            this.gvSPKSales.Name = "gvSPKSales";
            this.gvSPKSales.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSPKSales.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSPKSales.OptionsBehavior.AutoPopulateColumns = false;
            this.gvSPKSales.OptionsBehavior.Editable = false;
            this.gvSPKSales.OptionsBehavior.ReadOnly = true;
            this.gvSPKSales.OptionsCustomization.AllowColumnMoving = false;
            this.gvSPKSales.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvSPKSales.OptionsMenu.EnableFooterMenu = false;
            this.gvSPKSales.OptionsView.ShowDetailButtons = false;
            this.gvSPKSales.OptionsView.ShowFooter = true;
            this.gvSPKSales.OptionsView.ShowGroupPanel = false;
            this.gvSPKSales.OptionsView.ShowViewCaption = true;
            this.gvSPKSales.ViewCaption = "Daftar SPK";
            // 
            // colCode
            // 
            this.colCode.Caption = "Kode";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // colLicenseNumber
            // 
            this.colLicenseNumber.Caption = "Nopol";
            this.colLicenseNumber.FieldName = "Vehicle.ActiveLicenseNumber";
            this.colLicenseNumber.Name = "colLicenseNumber";
            this.colLicenseNumber.Visible = true;
            this.colLicenseNumber.VisibleIndex = 1;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "Total Harga Sparepart";
            this.colTotalPrice.FieldName = "TotalSparepartPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 2;
            // 
            // colCreateDate
            // 
            this.colCreateDate.Caption = "Tanggal Pembuatan";
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 3;
            // 
            // SPKSaleListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcSPKSales);
            this.Controls.Add(this.btnNewSale);
            this.Controls.Add(this.gcFilter);
            this.Name = "SPKSaleListControl";
            this.Size = new System.Drawing.Size(638, 315);
            this.cmsEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSPKSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSPKSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private DevExpress.XtraEditors.SimpleButton btnNewSale;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtDateFilterTo;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.DateEdit txtDateFilterFrom;
        private DevExpress.XtraEditors.LabelControl lblFilterDate;
        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraGrid.GridControl gcSPKSales;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSPKSales;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colLicenseNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;

    }
}
