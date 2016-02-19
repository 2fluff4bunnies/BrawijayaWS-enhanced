namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class DebtEditorForm
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
            this.gcDebtInfo = new DevExpress.XtraEditors.GroupControl();
            this.cbPaymentType = new DevExpress.XtraEditors.LookUpEdit();
            this.lblPaymentType = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalPayment = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalPayment = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalNotPaid = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalNotPaid = new DevExpress.XtraEditors.LabelControl();
            this.ttTotalPaid = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalPaid = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalTransaction = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalTransaction = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomer = new DevExpress.XtraEditors.TextEdit();
            this.lblSupplier = new DevExpress.XtraEditors.LabelControl();
            this.txtSupplier = new DevExpress.XtraEditors.TextEdit();
            this.lblTransactionDate = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcDebtInfo)).BeginInit();
            this.gcDebtInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaymentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPayment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalNotPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttTotalPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTransaction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplier.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDebtInfo
            // 
            this.gcDebtInfo.Controls.Add(this.cbPaymentType);
            this.gcDebtInfo.Controls.Add(this.lblPaymentType);
            this.gcDebtInfo.Controls.Add(this.txtTotalPayment);
            this.gcDebtInfo.Controls.Add(this.lblTotalPayment);
            this.gcDebtInfo.Controls.Add(this.txtTotalNotPaid);
            this.gcDebtInfo.Controls.Add(this.lblTotalNotPaid);
            this.gcDebtInfo.Controls.Add(this.ttTotalPaid);
            this.gcDebtInfo.Controls.Add(this.lblTotalPaid);
            this.gcDebtInfo.Controls.Add(this.txtTotalTransaction);
            this.gcDebtInfo.Controls.Add(this.lblTotalTransaction);
            this.gcDebtInfo.Controls.Add(this.txtCustomer);
            this.gcDebtInfo.Controls.Add(this.lblSupplier);
            this.gcDebtInfo.Controls.Add(this.txtSupplier);
            this.gcDebtInfo.Controls.Add(this.lblTransactionDate);
            this.gcDebtInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDebtInfo.Location = new System.Drawing.Point(0, 0);
            this.gcDebtInfo.Name = "gcDebtInfo";
            this.gcDebtInfo.Size = new System.Drawing.Size(389, 285);
            this.gcDebtInfo.TabIndex = 1;
            this.gcDebtInfo.Text = "Informasi Pembayaran";
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.Location = new System.Drawing.Point(199, 225);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cbPaymentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPaymentType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Kode Kota"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Nama")});
            this.cbPaymentType.Properties.DisplayMember = "Name";
            this.cbPaymentType.Properties.HideSelection = false;
            this.cbPaymentType.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.cbPaymentType.Properties.NullText = "-- Pilih Pembayaran --";
            this.cbPaymentType.Properties.ValueMember = "Id";
            this.cbPaymentType.Size = new System.Drawing.Size(158, 20);
            this.cbPaymentType.TabIndex = 15;
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.Location = new System.Drawing.Point(12, 228);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(87, 13);
            this.lblPaymentType.TabIndex = 14;
            this.lblPaymentType.Text = "Jenis Pembayaran";
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Location = new System.Drawing.Point(199, 198);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.Size = new System.Drawing.Size(157, 20);
            this.txtTotalPayment.TabIndex = 13;
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.Location = new System.Drawing.Point(12, 201);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(91, 13);
            this.lblTotalPayment.TabIndex = 12;
            this.lblTotalPayment.Text = "Total Akan Dibayar";
            // 
            // txtTotalNotPaid
            // 
            this.txtTotalNotPaid.Location = new System.Drawing.Point(201, 134);
            this.txtTotalNotPaid.Name = "txtTotalNotPaid";
            this.txtTotalNotPaid.Properties.ReadOnly = true;
            this.txtTotalNotPaid.Size = new System.Drawing.Size(157, 20);
            this.txtTotalNotPaid.TabIndex = 11;
            // 
            // lblTotalNotPaid
            // 
            this.lblTotalNotPaid.Location = new System.Drawing.Point(13, 137);
            this.lblTotalNotPaid.Name = "lblTotalNotPaid";
            this.lblTotalNotPaid.Size = new System.Drawing.Size(102, 13);
            this.lblTotalNotPaid.TabIndex = 10;
            this.lblTotalNotPaid.Text = "Total Belum Terbayar";
            // 
            // ttTotalPaid
            // 
            this.ttTotalPaid.Location = new System.Drawing.Point(200, 105);
            this.ttTotalPaid.Name = "ttTotalPaid";
            this.ttTotalPaid.Properties.ReadOnly = true;
            this.ttTotalPaid.Size = new System.Drawing.Size(157, 20);
            this.ttTotalPaid.TabIndex = 9;
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.Location = new System.Drawing.Point(12, 108);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(71, 13);
            this.lblTotalPaid.TabIndex = 8;
            this.lblTotalPaid.Text = "Total Terbayar";
            // 
            // txtTotalTransaction
            // 
            this.txtTotalTransaction.Location = new System.Drawing.Point(200, 79);
            this.txtTotalTransaction.Name = "txtTotalTransaction";
            this.txtTotalTransaction.Properties.ReadOnly = true;
            this.txtTotalTransaction.Size = new System.Drawing.Size(157, 20);
            this.txtTotalTransaction.TabIndex = 7;
            // 
            // lblTotalTransaction
            // 
            this.lblTotalTransaction.Location = new System.Drawing.Point(12, 82);
            this.lblTotalTransaction.Name = "lblTotalTransaction";
            this.lblTotalTransaction.Size = new System.Drawing.Size(72, 13);
            this.lblTotalTransaction.TabIndex = 6;
            this.lblTotalTransaction.Text = "Total Transaksi";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(200, 50);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Properties.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(157, 20);
            this.txtCustomer.TabIndex = 5;
            // 
            // lblSupplier
            // 
            this.lblSupplier.Location = new System.Drawing.Point(12, 53);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(38, 13);
            this.lblSupplier.TabIndex = 4;
            this.lblSupplier.Text = "Supplier";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(200, 24);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Properties.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(157, 20);
            this.txtSupplier.TabIndex = 3;
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.Location = new System.Drawing.Point(12, 27);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(86, 13);
            this.lblTransactionDate.TabIndex = 2;
            this.lblTransactionDate.Text = "Tanggal Transaksi";
            // 
            // DebtEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 334);
            this.Controls.Add(this.gcDebtInfo);
            this.Name = "DebtEditorForm";
            this.Text = "Form Pembayaran Hutang";
            this.Controls.SetChildIndex(this.gcDebtInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcDebtInfo)).EndInit();
            this.gcDebtInfo.ResumeLayout(false);
            this.gcDebtInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaymentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPayment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalNotPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttTotalPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTransaction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplier.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcDebtInfo;
        private DevExpress.XtraEditors.TextEdit txtSupplier;
        private DevExpress.XtraEditors.LabelControl lblTransactionDate;
        private DevExpress.XtraEditors.LabelControl lblPaymentType;
        private DevExpress.XtraEditors.TextEdit txtTotalPayment;
        private DevExpress.XtraEditors.LabelControl lblTotalPayment;
        private DevExpress.XtraEditors.TextEdit txtTotalNotPaid;
        private DevExpress.XtraEditors.LabelControl lblTotalNotPaid;
        private DevExpress.XtraEditors.TextEdit ttTotalPaid;
        private DevExpress.XtraEditors.LabelControl lblTotalPaid;
        private DevExpress.XtraEditors.TextEdit txtTotalTransaction;
        private DevExpress.XtraEditors.LabelControl lblTotalTransaction;
        private DevExpress.XtraEditors.TextEdit txtCustomer;
        private DevExpress.XtraEditors.LabelControl lblSupplier;
        private DevExpress.XtraEditors.LookUpEdit cbPaymentType;
    }
}