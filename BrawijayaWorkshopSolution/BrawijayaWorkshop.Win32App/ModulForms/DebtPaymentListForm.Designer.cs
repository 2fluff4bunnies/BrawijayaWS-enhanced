namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class DebtPaymentListForm
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
            this.gcDebtPaymentListInfo = new DevExpress.XtraEditors.GroupControl();
            this.gridDebtPayment = new DevExpress.XtraGrid.GridControl();
            this.gvDebtPayment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPaymentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtTotalNotPaid = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalNotPaid = new DevExpress.XtraEditors.LabelControl();
            this.ttTotalPaid = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalPaid = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalTransaction = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalTransaction = new DevExpress.XtraEditors.LabelControl();
            this.txtSupplier = new DevExpress.XtraEditors.TextEdit();
            this.lblSupplier = new DevExpress.XtraEditors.LabelControl();
            this.txtTransactionDate = new DevExpress.XtraEditors.TextEdit();
            this.lblTransactionDate = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcDebtPaymentListInfo)).BeginInit();
            this.gcDebtPaymentListInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDebtPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDebtPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalNotPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttTotalPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTransaction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransactionDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDebtPaymentListInfo
            // 
            this.gcDebtPaymentListInfo.Controls.Add(this.gridDebtPayment);
            this.gcDebtPaymentListInfo.Controls.Add(this.txtTotalNotPaid);
            this.gcDebtPaymentListInfo.Controls.Add(this.lblTotalNotPaid);
            this.gcDebtPaymentListInfo.Controls.Add(this.ttTotalPaid);
            this.gcDebtPaymentListInfo.Controls.Add(this.lblTotalPaid);
            this.gcDebtPaymentListInfo.Controls.Add(this.txtTotalTransaction);
            this.gcDebtPaymentListInfo.Controls.Add(this.lblTotalTransaction);
            this.gcDebtPaymentListInfo.Controls.Add(this.txtSupplier);
            this.gcDebtPaymentListInfo.Controls.Add(this.lblSupplier);
            this.gcDebtPaymentListInfo.Controls.Add(this.txtTransactionDate);
            this.gcDebtPaymentListInfo.Controls.Add(this.lblTransactionDate);
            this.gcDebtPaymentListInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDebtPaymentListInfo.Location = new System.Drawing.Point(0, 0);
            this.gcDebtPaymentListInfo.Name = "gcDebtPaymentListInfo";
            this.gcDebtPaymentListInfo.Size = new System.Drawing.Size(538, 367);
            this.gcDebtPaymentListInfo.TabIndex = 1;
            this.gcDebtPaymentListInfo.Text = "Informasi Daftar Pembayaran";
            // 
            // gridDebtPayment
            // 
            this.gridDebtPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDebtPayment.Location = new System.Drawing.Point(0, 167);
            this.gridDebtPayment.MainView = this.gvDebtPayment;
            this.gridDebtPayment.Name = "gridDebtPayment";
            this.gridDebtPayment.Size = new System.Drawing.Size(538, 227);
            this.gridDebtPayment.TabIndex = 22;
            this.gridDebtPayment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDebtPayment});
            // 
            // gvDebtPayment
            // 
            this.gvDebtPayment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPaymentDate,
            this.colTotalPayment,
            this.colPaymentType});
            this.gvDebtPayment.GridControl = this.gridDebtPayment;
            this.gvDebtPayment.Name = "gvDebtPayment";
            this.gvDebtPayment.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvDebtPayment.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvDebtPayment.OptionsBehavior.AutoPopulateColumns = false;
            this.gvDebtPayment.OptionsBehavior.Editable = false;
            this.gvDebtPayment.OptionsBehavior.ReadOnly = true;
            this.gvDebtPayment.OptionsCustomization.AllowColumnMoving = false;
            this.gvDebtPayment.OptionsCustomization.AllowFilter = false;
            this.gvDebtPayment.OptionsCustomization.AllowGroup = false;
            this.gvDebtPayment.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvDebtPayment.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDebtPayment.OptionsView.ShowGroupPanel = false;
            this.gvDebtPayment.OptionsView.ShowViewCaption = true;
            this.gvDebtPayment.ViewCaption = "Daftar Pembayaran";
            // 
            // colPaymentDate
            // 
            this.colPaymentDate.Caption = "Tanggal Pmbayaran";
            this.colPaymentDate.Name = "colPaymentDate";
            this.colPaymentDate.Visible = true;
            this.colPaymentDate.VisibleIndex = 0;
            // 
            // colTotalPayment
            // 
            this.colTotalPayment.Caption = "Jumlah Pembayaran";
            this.colTotalPayment.Name = "colTotalPayment";
            this.colTotalPayment.Visible = true;
            this.colTotalPayment.VisibleIndex = 1;
            // 
            // colPaymentType
            // 
            this.colPaymentType.Caption = "Jenis Pembayaran";
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
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(200, 46);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Properties.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(157, 20);
            this.txtSupplier.TabIndex = 15;
            // 
            // lblSupplier
            // 
            this.lblSupplier.Location = new System.Drawing.Point(12, 49);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(38, 13);
            this.lblSupplier.TabIndex = 14;
            this.lblSupplier.Text = "Supplier";
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
            // DebtPaymentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 367);
            this.Controls.Add(this.gcDebtPaymentListInfo);
            this.Name = "DebtPaymentListForm";
            this.Text = "Daftar Pembayaran Hutang";
            ((System.ComponentModel.ISupportInitialize)(this.gcDebtPaymentListInfo)).EndInit();
            this.gcDebtPaymentListInfo.ResumeLayout(false);
            this.gcDebtPaymentListInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDebtPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDebtPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalNotPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttTotalPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTransaction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransactionDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcDebtPaymentListInfo;
        private DevExpress.XtraGrid.GridControl gridDebtPayment;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDebtPayment;
        private DevExpress.XtraEditors.TextEdit txtTotalNotPaid;
        private DevExpress.XtraEditors.LabelControl lblTotalNotPaid;
        private DevExpress.XtraEditors.TextEdit ttTotalPaid;
        private DevExpress.XtraEditors.LabelControl lblTotalPaid;
        private DevExpress.XtraEditors.TextEdit txtTotalTransaction;
        private DevExpress.XtraEditors.LabelControl lblTotalTransaction;
        private DevExpress.XtraEditors.TextEdit txtSupplier;
        private DevExpress.XtraEditors.LabelControl lblSupplier;
        private DevExpress.XtraEditors.TextEdit txtTransactionDate;
        private DevExpress.XtraEditors.LabelControl lblTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPayment;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentType;

    }
}