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
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDateFilterTo = new DevExpress.XtraEditors.DateEdit();
            this.txtDateFilterFrom = new DevExpress.XtraEditors.DateEdit();
            this.lblFilterDate = new DevExpress.XtraEditors.LabelControl();
            this.gridCredit = new DevExpress.XtraGrid.GridControl();
            this.gvCredit = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLicense = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreditAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsNewPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsListPayment = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCredit)).BeginInit();
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.lblFilterDate.Size = new System.Drawing.Size(86, 13);
            this.lblFilterDate.TabIndex = 1;
            this.lblFilterDate.Text = "Tanggal Transaksi";
            // 
            // gridCredit
            // 
            this.gridCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCredit.Location = new System.Drawing.Point(0, 99);
            this.gridCredit.MainView = this.gvCredit;
            this.gridCredit.Name = "gridCredit";
            this.gridCredit.Size = new System.Drawing.Size(636, 213);
            this.gridCredit.TabIndex = 5;
            this.gridCredit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCredit});
            // 
            // gvCredit
            // 
            this.gvCredit.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransDate,
            this.colCustomer,
            this.colLicense,
            this.colTotalPrice,
            this.colCreditAmount,
            this.colStatus});
            this.gvCredit.GridControl = this.gridCredit;
            this.gvCredit.Name = "gvCredit";
            this.gvCredit.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCredit.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCredit.OptionsBehavior.AutoPopulateColumns = false;
            this.gvCredit.OptionsBehavior.Editable = false;
            this.gvCredit.OptionsBehavior.ReadOnly = true;
            this.gvCredit.OptionsCustomization.AllowColumnMoving = false;
            this.gvCredit.OptionsCustomization.AllowFilter = false;
            this.gvCredit.OptionsCustomization.AllowGroup = false;
            this.gvCredit.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvCredit.OptionsDetail.AllowZoomDetail = false;
            this.gvCredit.OptionsDetail.EnableMasterViewMode = false;
            this.gvCredit.OptionsDetail.ShowDetailTabs = false;
            this.gvCredit.OptionsDetail.SmartDetailExpand = false;
            this.gvCredit.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCredit.OptionsView.ShowGroupPanel = false;
            this.gvCredit.OptionsView.ShowViewCaption = true;
            this.gvCredit.ViewCaption = "Daftar Transaksi Penjualan";
            this.gvCredit.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvCredit_PopupMenuShowing);
            this.gvCredit.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvCredit_FocusedRowChanged);
            this.gvCredit.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvCredit_CustomColumnDisplayText);
            // 
            // colTransDate
            // 
            this.colTransDate.Caption = "Tgl Transaksi";
            this.colTransDate.FieldName = "CreateDate";
            this.colTransDate.Name = "colTransDate";
            this.colTransDate.Visible = true;
            this.colTransDate.VisibleIndex = 0;
            // 
            // colCustomer
            // 
            this.colCustomer.Caption = "Customer";
            this.colCustomer.FieldName = "SPK.Vehicle.Customer.CompanyName";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 1;
            // 
            // colLicense
            // 
            this.colLicense.Caption = "Nomor Polisi";
            this.colLicense.FieldName = "SPK.Vehicle.ActiveLicenseNumber";
            this.colLicense.Name = "colLicense";
            this.colLicense.Visible = true;
            this.colLicense.VisibleIndex = 2;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "Total Transaksi";
            this.colTotalPrice.DisplayFormat.FormatString = "{0:#,#}";
            this.colTotalPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 3;
            // 
            // colCreditAmount
            // 
            this.colCreditAmount.Caption = "Total Terbayar";
            this.colCreditAmount.DisplayFormat.FormatString = "{0:#,#}";
            this.colCreditAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCreditAmount.FieldName = "TotalHasPaid";
            this.colCreditAmount.Name = "colCreditAmount";
            this.colCreditAmount.Visible = true;
            this.colCreditAmount.VisibleIndex = 4;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status Bayar";
            this.colStatus.FieldName = "PaymentStatus";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 5;
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsNewPayment,
            this.cmsListPayment});
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(205, 48);
            // 
            // cmsNewPayment
            // 
            this.cmsNewPayment.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.add_item_16x16;
            this.cmsNewPayment.Name = "cmsNewPayment";
            this.cmsNewPayment.Size = new System.Drawing.Size(204, 22);
            this.cmsNewPayment.Text = "Buat Pembayaran";
            this.cmsNewPayment.Click += new System.EventHandler(this.cmsNewPayment_Click);
            // 
            // cmsListPayment
            // 
            this.cmsListPayment.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.history_16x16;
            this.cmsListPayment.Name = "cmsListPayment";
            this.cmsListPayment.Size = new System.Drawing.Size(204, 22);
            this.cmsListPayment.Text = "Lihat Daftar Pembayaran";
            this.cmsListPayment.Click += new System.EventHandler(this.cmsListPayment_Click);
            // 
            // CreditListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridCredit);
            this.Controls.Add(this.gcFilter);
            this.Name = "CreditListControl";
            this.Size = new System.Drawing.Size(636, 315);
            this.Load += new System.EventHandler(this.CreditListControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCredit)).EndInit();
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
        private DevExpress.XtraGrid.Views.Grid.GridView gvCredit;
        private DevExpress.XtraGrid.Columns.GridColumn colTransDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditAmount;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsNewPayment;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.ToolStripMenuItem cmsListPayment;
        private DevExpress.XtraGrid.Columns.GridColumn colLicense;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
    }
}
