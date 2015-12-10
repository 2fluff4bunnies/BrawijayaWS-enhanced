namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class PurchasingListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchasingListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtDateFilterFrom = new DevExpress.XtraEditors.DateEdit();
            this.lblFilterDate = new DevExpress.XtraEditors.LabelControl();
            this.btnNewPurchasing = new DevExpress.XtraEditors.SimpleButton();
            this.gridPurchasing = new DevExpress.XtraGrid.GridControl();
            this.gvPurchasing = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDatePurchasing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierNamePurchasing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPricePurchasing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDateFilterTo = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchasing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchasing)).BeginInit();
            this.cmsEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.gcFilter.TabIndex = 0;
            this.gcFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(572, 28);
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
            this.txtDateFilterFrom.Size = new System.Drawing.Size(138, 20);
            this.txtDateFilterFrom.TabIndex = 2;
            // 
            // lblFilterDate
            // 
            this.lblFilterDate.Location = new System.Drawing.Point(14, 34);
            this.lblFilterDate.Name = "lblFilterDate";
            this.lblFilterDate.Size = new System.Drawing.Size(97, 13);
            this.lblFilterDate.TabIndex = 1;
            this.lblFilterDate.Text = "Tanggal Penerimaan";
            // 
            // btnNewPurchasing
            // 
            this.btnNewPurchasing.Image = ((System.Drawing.Image)(resources.GetObject("btnNewPurchasing.Image")));
            this.btnNewPurchasing.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewPurchasing.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewPurchasing.Location = new System.Drawing.Point(3, 73);
            this.btnNewPurchasing.Name = "btnNewPurchasing";
            this.btnNewPurchasing.Size = new System.Drawing.Size(144, 23);
            this.btnNewPurchasing.TabIndex = 3;
            this.btnNewPurchasing.Text = "Buat Penerimaan Baru";
            // 
            // gridPurchasing
            // 
            this.gridPurchasing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPurchasing.Location = new System.Drawing.Point(5, 102);
            this.gridPurchasing.MainView = this.gvPurchasing;
            this.gridPurchasing.Name = "gridPurchasing";
            this.gridPurchasing.Size = new System.Drawing.Size(630, 210);
            this.gridPurchasing.TabIndex = 4;
            this.gridPurchasing.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPurchasing});
            // 
            // gvPurchasing
            // 
            this.gvPurchasing.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDatePurchasing,
            this.colSupplierNamePurchasing,
            this.colTotalPricePurchasing});
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
            this.gvPurchasing.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPurchasing.OptionsView.ShowGroupPanel = false;
            this.gvPurchasing.OptionsView.ShowViewCaption = true;
            this.gvPurchasing.ViewCaption = "Daftar Penerimaan";
            // 
            // colDatePurchasing
            // 
            this.colDatePurchasing.Caption = "Tanggal";
            this.colDatePurchasing.FieldName = "Date";
            this.colDatePurchasing.Name = "colDatePurchasing";
            this.colDatePurchasing.Visible = true;
            this.colDatePurchasing.VisibleIndex = 0;
            // 
            // colSupplierNamePurchasing
            // 
            this.colSupplierNamePurchasing.Caption = "Supplier";
            this.colSupplierNamePurchasing.FieldName = "Supplier.Name";
            this.colSupplierNamePurchasing.Name = "colSupplierNamePurchasing";
            this.colSupplierNamePurchasing.Visible = true;
            this.colSupplierNamePurchasing.VisibleIndex = 1;
            // 
            // colTotalPricePurchasing
            // 
            this.colTotalPricePurchasing.Caption = "Total Harga";
            this.colTotalPricePurchasing.FieldName = "TotalPrice";
            this.colTotalPricePurchasing.Name = "colTotalPricePurchasing";
            this.colTotalPricePurchasing.Visible = true;
            this.colTotalPricePurchasing.VisibleIndex = 2;
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditData});
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(130, 26);
            // 
            // cmsEditData
            // 
            this.cmsEditData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.cmsEditData.Name = "cmsEditData";
            this.cmsEditData.Size = new System.Drawing.Size(129, 22);
            this.cmsEditData.Text = "Ubah Data";
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
            this.txtDateFilterTo.Size = new System.Drawing.Size(138, 20);
            this.txtDateFilterTo.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(284, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(4, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "-";
            // 
            // PurchasingListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridPurchasing);
            this.Controls.Add(this.btnNewPurchasing);
            this.Controls.Add(this.gcFilter);
            this.Name = "PurchasingListControl";
            this.Size = new System.Drawing.Size(638, 315);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchasing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchasing)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.LabelControl lblFilterDate;
        private DevExpress.XtraEditors.DateEdit txtDateFilterFrom;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnNewPurchasing;
        private DevExpress.XtraGrid.GridControl gridPurchasing;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPurchasing;
        private DevExpress.XtraGrid.Columns.GridColumn colDatePurchasing;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierNamePurchasing;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPricePurchasing;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtDateFilterTo;

    }
}
