namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class CreditListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDateFilterTo = new DevExpress.XtraEditors.DateEdit();
            this.txtDateFilterFrom = new DevExpress.XtraEditors.DateEdit();
            this.lblFilterDate = new DevExpress.XtraEditors.LabelControl();
            this.gridCredit = new DevExpress.XtraGrid.GridControl();
            this.gvDebt = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.columnPaidDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lihatDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewCredit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDebt)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.labelControl1);
            this.gcFilter.Controls.Add(this.txtDateFilterTo);
            this.gcFilter.Controls.Add(this.txtDateFilterFrom);
            this.gcFilter.Controls.Add(this.lblFilterDate);
            this.gcFilter.Location = new System.Drawing.Point(0, 0);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(636, 64);
            this.gcFilter.TabIndex = 1;
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
            this.lblFilterDate.Size = new System.Drawing.Size(101, 13);
            this.lblFilterDate.TabIndex = 1;
            this.lblFilterDate.Text = "Tanggal Pembayaran";
            // 
            // gridCredit
            // 
            this.gridCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCredit.Location = new System.Drawing.Point(0, 99);
            this.gridCredit.MainView = this.gvDebt;
            this.gridCredit.Name = "gridCredit";
            this.gridCredit.Size = new System.Drawing.Size(636, 213);
            this.gridCredit.TabIndex = 5;
            this.gridCredit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDebt});
            // 
            // gvDebt
            // 
            this.gvDebt.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnPaidDate,
            this.colTransactionDate,
            this.colCustomer,
            this.colTotalPrice,
            this.colTotalPayment});
            this.gvDebt.GridControl = this.gridCredit;
            this.gvDebt.Name = "gvDebt";
            this.gvDebt.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvDebt.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvDebt.OptionsBehavior.AutoPopulateColumns = false;
            this.gvDebt.OptionsBehavior.Editable = false;
            this.gvDebt.OptionsBehavior.ReadOnly = true;
            this.gvDebt.OptionsCustomization.AllowColumnMoving = false;
            this.gvDebt.OptionsCustomization.AllowFilter = false;
            this.gvDebt.OptionsCustomization.AllowGroup = false;
            this.gvDebt.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvDebt.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDebt.OptionsView.ShowGroupPanel = false;
            this.gvDebt.OptionsView.ShowViewCaption = true;
            this.gvDebt.ViewCaption = "Daftar Pembayaran Piutang";
            // 
            // columnPaidDate
            // 
            this.columnPaidDate.Caption = "Tgl Pembayaran";
            this.columnPaidDate.FieldName = "TransactionDate";
            this.columnPaidDate.Name = "columnPaidDate";
            this.columnPaidDate.Visible = true;
            this.columnPaidDate.VisibleIndex = 0;
            // 
            // colTransactionDate
            // 
            this.colTransactionDate.Caption = "Tgl Transaksi";
            this.colTransactionDate.Name = "colTransactionDate";
            this.colTransactionDate.Visible = true;
            this.colTransactionDate.VisibleIndex = 1;
            // 
            // colCustomer
            // 
            this.colCustomer.Caption = "Customer";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 2;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "Total Transaksi";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 3;
            // 
            // colTotalPayment
            // 
            this.colTotalPayment.Caption = "Jml Pembayaran";
            this.colTotalPayment.Name = "colTotalPayment";
            this.colTotalPayment.Visible = true;
            this.colTotalPayment.VisibleIndex = 4;
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lihatDetailToolStripMenuItem});
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(134, 26);
            // 
            // lihatDetailToolStripMenuItem
            // 
            this.lihatDetailToolStripMenuItem.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.history_16x16;
            this.lihatDetailToolStripMenuItem.Name = "lihatDetailToolStripMenuItem";
            this.lihatDetailToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.lihatDetailToolStripMenuItem.Text = "Lihat Detail";
            // 
            // btnNewCredit
            // 
            this.btnNewCredit.Image = ((System.Drawing.Image)(resources.GetObject("btnNewCredit.Image")));
            this.btnNewCredit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewCredit.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewCredit.Location = new System.Drawing.Point(3, 70);
            this.btnNewCredit.Name = "btnNewCredit";
            this.btnNewCredit.Size = new System.Drawing.Size(150, 23);
            this.btnNewCredit.TabIndex = 6;
            this.btnNewCredit.Text = "Buat Pembayaran Baru";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(457, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "cari";
            // 
            // CreditListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNewCredit);
            this.Controls.Add(this.gridCredit);
            this.Controls.Add(this.gcFilter);
            this.Name = "CreditListControl";
            this.Size = new System.Drawing.Size(636, 315);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDebt)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtDateFilterFrom;
        private DevExpress.XtraEditors.LabelControl lblFilterDate;
        private DevExpress.XtraEditors.DateEdit txtDateFilterTo;
        private DevExpress.XtraGrid.GridControl gridCredit;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDebt;
        private DevExpress.XtraGrid.Columns.GridColumn columnPaidDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPayment;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem lihatDetailToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton btnNewCredit;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
    }
}
