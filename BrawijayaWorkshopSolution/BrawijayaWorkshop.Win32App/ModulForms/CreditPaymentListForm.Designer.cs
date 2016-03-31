namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class CreditPaymentListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditPaymentListForm));
            this.gcCreditPaymentListInfo = new DevExpress.XtraEditors.GroupControl();
            this.gridCreditPayment = new DevExpress.XtraGrid.GridControl();
            this.gvCreditPayment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPaymentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtTotalNotPaid = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalNotPaid = new DevExpress.XtraEditors.LabelControl();
            this.ttTotalPaid = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalPaid = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalTransaction = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalTransaction = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomer = new DevExpress.XtraEditors.TextEdit();
            this.lblCustomer = new DevExpress.XtraEditors.LabelControl();
            this.txtTransactionDate = new DevExpress.XtraEditors.TextEdit();
            this.lblTransactionDate = new DevExpress.XtraEditors.LabelControl();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcCreditPaymentListInfo)).BeginInit();
            this.gcCreditPaymentListInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCreditPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCreditPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalNotPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttTotalPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTransaction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransactionDate.Properties)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcCreditPaymentListInfo
            // 
            this.gcCreditPaymentListInfo.Controls.Add(this.gridCreditPayment);
            this.gcCreditPaymentListInfo.Controls.Add(this.txtTotalNotPaid);
            this.gcCreditPaymentListInfo.Controls.Add(this.lblTotalNotPaid);
            this.gcCreditPaymentListInfo.Controls.Add(this.ttTotalPaid);
            this.gcCreditPaymentListInfo.Controls.Add(this.lblTotalPaid);
            this.gcCreditPaymentListInfo.Controls.Add(this.txtTotalTransaction);
            this.gcCreditPaymentListInfo.Controls.Add(this.lblTotalTransaction);
            this.gcCreditPaymentListInfo.Controls.Add(this.txtCustomer);
            this.gcCreditPaymentListInfo.Controls.Add(this.lblCustomer);
            this.gcCreditPaymentListInfo.Controls.Add(this.txtTransactionDate);
            this.gcCreditPaymentListInfo.Controls.Add(this.lblTransactionDate);
            this.gcCreditPaymentListInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCreditPaymentListInfo.Location = new System.Drawing.Point(0, 0);
            this.gcCreditPaymentListInfo.Name = "gcCreditPaymentListInfo";
            this.gcCreditPaymentListInfo.Size = new System.Drawing.Size(538, 367);
            this.gcCreditPaymentListInfo.TabIndex = 1;
            this.gcCreditPaymentListInfo.Text = "Informasi Daftar Pembayaran";
            // 
            // gridCreditPayment
            // 
            this.gridCreditPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCreditPayment.Location = new System.Drawing.Point(0, 167);
            this.gridCreditPayment.MainView = this.gvCreditPayment;
            this.gridCreditPayment.Name = "gridCreditPayment";
            this.gridCreditPayment.Size = new System.Drawing.Size(538, 200);
            this.gridCreditPayment.TabIndex = 22;
            this.gridCreditPayment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCreditPayment});
            // 
            // gvCreditPayment
            // 
            this.gvCreditPayment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPaymentDate,
            this.colTotalPayment,
            this.colPaymentType});
            this.gvCreditPayment.GridControl = this.gridCreditPayment;
            this.gvCreditPayment.Name = "gvCreditPayment";
            this.gvCreditPayment.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCreditPayment.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCreditPayment.OptionsBehavior.AutoPopulateColumns = false;
            this.gvCreditPayment.OptionsBehavior.Editable = false;
            this.gvCreditPayment.OptionsBehavior.ReadOnly = true;
            this.gvCreditPayment.OptionsCustomization.AllowColumnMoving = false;
            this.gvCreditPayment.OptionsCustomization.AllowFilter = false;
            this.gvCreditPayment.OptionsCustomization.AllowGroup = false;
            this.gvCreditPayment.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvCreditPayment.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCreditPayment.OptionsView.ShowGroupPanel = false;
            this.gvCreditPayment.OptionsView.ShowViewCaption = true;
            this.gvCreditPayment.ViewCaption = "Daftar Pembayaran";
            this.gvCreditPayment.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvCreditPayment_PopupMenuShowing);
            this.gvCreditPayment.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvCreditPayment_FocusedRowChanged);
            // 
            // colPaymentDate
            // 
            this.colPaymentDate.Caption = "Tanggal Pmbayaran";
            this.colPaymentDate.FieldName = "TransactionDate";
            this.colPaymentDate.Name = "colPaymentDate";
            this.colPaymentDate.Visible = true;
            this.colPaymentDate.VisibleIndex = 0;
            // 
            // colTotalPayment
            // 
            this.colTotalPayment.Caption = "Jumlah Pembayaran";
            this.colTotalPayment.DisplayFormat.FormatString = "{0:#,#}";
            this.colTotalPayment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalPayment.FieldName = "TotalPayment";
            this.colTotalPayment.Name = "colTotalPayment";
            this.colTotalPayment.Visible = true;
            this.colTotalPayment.VisibleIndex = 1;
            // 
            // colPaymentType
            // 
            this.colPaymentType.Caption = "Jenis Pembayaran";
            this.colPaymentType.FieldName = "PaymentMethod.Name";
            this.colPaymentType.Name = "colPaymentType";
            this.colPaymentType.Visible = true;
            this.colPaymentType.VisibleIndex = 2;
            // 
            // txtTotalNotPaid
            // 
            this.txtTotalNotPaid.Location = new System.Drawing.Point(201, 130);
            this.txtTotalNotPaid.Name = "txtTotalNotPaid";
            this.txtTotalNotPaid.Properties.ReadOnly = true;
            this.txtTotalNotPaid.Size = new System.Drawing.Size(157, 20);
            this.txtTotalNotPaid.TabIndex = 21;
            // 
            // lblTotalNotPaid
            // 
            this.lblTotalNotPaid.Location = new System.Drawing.Point(13, 133);
            this.lblTotalNotPaid.Name = "lblTotalNotPaid";
            this.lblTotalNotPaid.Size = new System.Drawing.Size(102, 13);
            this.lblTotalNotPaid.TabIndex = 20;
            this.lblTotalNotPaid.Text = "Total Belum Terbayar";
            // 
            // ttTotalPaid
            // 
            this.ttTotalPaid.Location = new System.Drawing.Point(200, 101);
            this.ttTotalPaid.Name = "ttTotalPaid";
            this.ttTotalPaid.Properties.ReadOnly = true;
            this.ttTotalPaid.Size = new System.Drawing.Size(157, 20);
            this.ttTotalPaid.TabIndex = 19;
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.Location = new System.Drawing.Point(12, 104);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(71, 13);
            this.lblTotalPaid.TabIndex = 18;
            this.lblTotalPaid.Text = "Total Terbayar";
            // 
            // txtTotalTransaction
            // 
            this.txtTotalTransaction.Location = new System.Drawing.Point(200, 75);
            this.txtTotalTransaction.Name = "txtTotalTransaction";
            this.txtTotalTransaction.Properties.ReadOnly = true;
            this.txtTotalTransaction.Size = new System.Drawing.Size(157, 20);
            this.txtTotalTransaction.TabIndex = 17;
            // 
            // lblTotalTransaction
            // 
            this.lblTotalTransaction.Location = new System.Drawing.Point(12, 78);
            this.lblTotalTransaction.Name = "lblTotalTransaction";
            this.lblTotalTransaction.Size = new System.Drawing.Size(72, 13);
            this.lblTotalTransaction.TabIndex = 16;
            this.lblTotalTransaction.Text = "Total Transaksi";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(200, 46);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Properties.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(157, 20);
            this.txtCustomer.TabIndex = 15;
            // 
            // lblCustomer
            // 
            this.lblCustomer.Location = new System.Drawing.Point(12, 49);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(46, 13);
            this.lblCustomer.TabIndex = 14;
            this.lblCustomer.Text = "Customer";
            // 
            // txtTransactionDate
            // 
            this.txtTransactionDate.Location = new System.Drawing.Point(200, 20);
            this.txtTransactionDate.Name = "txtTransactionDate";
            this.txtTransactionDate.Properties.ReadOnly = true;
            this.txtTransactionDate.Size = new System.Drawing.Size(157, 20);
            this.txtTransactionDate.TabIndex = 13;
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.Location = new System.Drawing.Point(12, 23);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(86, 13);
            this.lblTransactionDate.TabIndex = 12;
            this.lblTransactionDate.Text = "Tanggal Transaksi";
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEdit,
            this.cmsDelete});
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(136, 48);
            // 
            // cmsEdit
            // 
            this.cmsEdit.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.cmsEdit.Name = "cmsEdit";
            this.cmsEdit.Size = new System.Drawing.Size(135, 22);
            this.cmsEdit.Text = "Ubah Data";
            this.cmsEdit.Click += new System.EventHandler(this.cmsEditData_Click);
            // 
            // cmsDelete
            // 
            this.cmsDelete.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(135, 22);
            this.cmsDelete.Text = "Hapus Data";
            this.cmsDelete.Click += new System.EventHandler(this.cmsDeleteData_Click);
            // 
            // CreditPaymentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 367);
            this.Controls.Add(this.gcCreditPaymentListInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreditPaymentListForm";
            this.Text = "Daftar Pembayaran Piutang";
            this.Load += new System.EventHandler(this.CreditPaymentListControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcCreditPaymentListInfo)).EndInit();
            this.gcCreditPaymentListInfo.ResumeLayout(false);
            this.gcCreditPaymentListInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCreditPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCreditPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalNotPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttTotalPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTransaction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransactionDate.Properties)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcCreditPaymentListInfo;
        private DevExpress.XtraGrid.GridControl gridCreditPayment;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCreditPayment;
        private DevExpress.XtraEditors.TextEdit txtTotalNotPaid;
        private DevExpress.XtraEditors.LabelControl lblTotalNotPaid;
        private DevExpress.XtraEditors.TextEdit ttTotalPaid;
        private DevExpress.XtraEditors.LabelControl lblTotalPaid;
        private DevExpress.XtraEditors.TextEdit txtTotalTransaction;
        private DevExpress.XtraEditors.LabelControl lblTotalTransaction;
        private DevExpress.XtraEditors.TextEdit txtCustomer;
        private DevExpress.XtraEditors.LabelControl lblCustomer;
        private DevExpress.XtraEditors.TextEdit txtTransactionDate;
        private DevExpress.XtraEditors.LabelControl lblTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPayment;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentType;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsDelete;

    }
}