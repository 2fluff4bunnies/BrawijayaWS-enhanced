namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class PurchaseReturnTransactionListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseReturnTransactionListForm));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDateFilterTo = new DevExpress.XtraEditors.DateEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtDateFilterFrom = new DevExpress.XtraEditors.DateEdit();
            this.lblFilterDate = new DevExpress.XtraEditors.LabelControl();
            this.gridReturn = new DevExpress.XtraGrid.GridControl();
            this.gvReturn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReturn)).BeginInit();
            this.cmsEditor.SuspendLayout();
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
            this.gcFilter.Location = new System.Drawing.Point(-4, 2);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(641, 67);
            this.gcFilter.TabIndex = 2;
            this.gcFilter.Text = "Filter";
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
            this.lblFilterDate.Size = new System.Drawing.Size(68, 13);
            this.lblFilterDate.TabIndex = 1;
            this.lblFilterDate.Text = "Tanggal Retur";
            // 
            // gridReturn
            // 
            this.gridReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridReturn.Location = new System.Drawing.Point(-4, 87);
            this.gridReturn.MainView = this.gvReturn;
            this.gridReturn.Name = "gridReturn";
            this.gridReturn.Size = new System.Drawing.Size(641, 210);
            this.gridReturn.TabIndex = 7;
            this.gridReturn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvReturn});
            // 
            // gvReturn
            // 
            this.gvReturn.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colSupplierName});
            this.gvReturn.GridControl = this.gridReturn;
            this.gvReturn.Name = "gvReturn";
            this.gvReturn.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvReturn.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvReturn.OptionsBehavior.AutoPopulateColumns = false;
            this.gvReturn.OptionsBehavior.Editable = false;
            this.gvReturn.OptionsBehavior.ReadOnly = true;
            this.gvReturn.OptionsCustomization.AllowColumnMoving = false;
            this.gvReturn.OptionsCustomization.AllowFilter = false;
            this.gvReturn.OptionsCustomization.AllowGroup = false;
            this.gvReturn.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvReturn.OptionsView.EnableAppearanceEvenRow = true;
            this.gvReturn.OptionsView.ShowGroupPanel = false;
            this.gvReturn.OptionsView.ShowViewCaption = true;
            this.gvReturn.ViewCaption = "Daftar Retur Pembelian";
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
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditData,
            this.cmsDeleteData});
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(153, 70);
            // 
            // cmsEditData
            // 
            this.cmsEditData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.cmsEditData.Name = "cmsEditData";
            this.cmsEditData.Size = new System.Drawing.Size(152, 22);
            this.cmsEditData.Text = "Ubah Data";
            // 
            // cmsDeleteData
            // 
            this.cmsDeleteData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.cmsDeleteData.Name = "cmsDeleteData";
            this.cmsDeleteData.Size = new System.Drawing.Size(152, 22);
            this.cmsDeleteData.Text = "Hapus Data";
            // 
            // PurchaseReturnTransactionListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 261);
            this.Controls.Add(this.gridReturn);
            this.Controls.Add(this.gcFilter);
            this.Name = "PurchaseReturnTransactionListForm";
            this.Text = "From Daftar Retur Pembelian";
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReturn)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridReturn;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReturn;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierName;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
    }
}