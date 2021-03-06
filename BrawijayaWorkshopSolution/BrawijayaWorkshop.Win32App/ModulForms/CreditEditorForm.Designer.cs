﻿namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class CreditEditorForm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.gcCreditInfo = new DevExpress.XtraEditors.GroupControl();
            this.deTransDate = new DevExpress.XtraEditors.DateEdit();
            this.cbPaymentType = new DevExpress.XtraEditors.LookUpEdit();
            this.lblPaymentType = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalPayment = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalPayment = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalNotPaid = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalNotPaid = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalPaid = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalPaid = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalTransaction = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalTransaction = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomer = new DevExpress.XtraEditors.TextEdit();
            this.lblCustomer = new DevExpress.XtraEditors.LabelControl();
            this.lblTransactionDate = new DevExpress.XtraEditors.LabelControl();
            this.valTotalPayment = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valPaymentMethod = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.bgwSave = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gcCreditInfo)).BeginInit();
            this.gcCreditInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaymentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPayment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalNotPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTransaction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valTotalPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valPaymentMethod)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCreditInfo
            // 
            this.gcCreditInfo.Controls.Add(this.deTransDate);
            this.gcCreditInfo.Controls.Add(this.cbPaymentType);
            this.gcCreditInfo.Controls.Add(this.lblPaymentType);
            this.gcCreditInfo.Controls.Add(this.txtTotalPayment);
            this.gcCreditInfo.Controls.Add(this.lblTotalPayment);
            this.gcCreditInfo.Controls.Add(this.txtTotalNotPaid);
            this.gcCreditInfo.Controls.Add(this.lblTotalNotPaid);
            this.gcCreditInfo.Controls.Add(this.txtTotalPaid);
            this.gcCreditInfo.Controls.Add(this.lblTotalPaid);
            this.gcCreditInfo.Controls.Add(this.txtTotalTransaction);
            this.gcCreditInfo.Controls.Add(this.lblTotalTransaction);
            this.gcCreditInfo.Controls.Add(this.txtCustomer);
            this.gcCreditInfo.Controls.Add(this.lblCustomer);
            this.gcCreditInfo.Controls.Add(this.lblTransactionDate);
            this.gcCreditInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCreditInfo.Location = new System.Drawing.Point(0, 0);
            this.gcCreditInfo.Name = "gcCreditInfo";
            this.gcCreditInfo.Size = new System.Drawing.Size(326, 243);
            this.gcCreditInfo.TabIndex = 1;
            this.gcCreditInfo.Text = "Informasi Pembayaran";
            // 
            // deTransDate
            // 
            this.deTransDate.EditValue = null;
            this.deTransDate.Location = new System.Drawing.Point(149, 32);
            this.deTransDate.Name = "deTransDate";
            this.deTransDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTransDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTransDate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.deTransDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deTransDate.Properties.HideSelection = false;
            this.deTransDate.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.deTransDate.Properties.ReadOnly = true;
            this.deTransDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deTransDate.Size = new System.Drawing.Size(157, 20);
            this.deTransDate.TabIndex = 16;
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.Location = new System.Drawing.Point(149, 211);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cbPaymentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPaymentType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Nama")});
            this.cbPaymentType.Properties.DisplayMember = "Name";
            this.cbPaymentType.Properties.HideSelection = false;
            this.cbPaymentType.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.cbPaymentType.Properties.NullText = "";
            this.cbPaymentType.Properties.ValueMember = "Id";
            this.cbPaymentType.Size = new System.Drawing.Size(157, 20);
            this.cbPaymentType.TabIndex = 15;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Pilih salah satu jenis pembayaran";
            this.valPaymentMethod.SetValidationRule(this.cbPaymentType, conditionValidationRule1);
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.Location = new System.Drawing.Point(14, 214);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(87, 13);
            this.lblPaymentType.TabIndex = 14;
            this.lblPaymentType.Text = "Jenis Pembayaran";
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Location = new System.Drawing.Point(149, 184);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.Properties.DisplayFormat.FormatString = " {0:#,#;(#,#);0}";
            this.txtTotalPayment.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalPayment.Size = new System.Drawing.Size(157, 20);
            this.txtTotalPayment.TabIndex = 13;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Isi total akan dibayar";
            this.valTotalPayment.SetValidationRule(this.txtTotalPayment, conditionValidationRule2);
            this.txtTotalPayment.EditValueChanged += new System.EventHandler(this.txtTotalPayment_EditValueChanged);
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.Location = new System.Drawing.Point(14, 187);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(91, 13);
            this.lblTotalPayment.TabIndex = 12;
            this.lblTotalPayment.Text = "Total Akan Dibayar";
            // 
            // txtTotalNotPaid
            // 
            this.txtTotalNotPaid.Location = new System.Drawing.Point(149, 140);
            this.txtTotalNotPaid.Name = "txtTotalNotPaid";
            this.txtTotalNotPaid.Properties.DisplayFormat.FormatString = " {0:#,#;(#,#);0}";
            this.txtTotalNotPaid.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalNotPaid.Properties.ReadOnly = true;
            this.txtTotalNotPaid.Size = new System.Drawing.Size(157, 20);
            this.txtTotalNotPaid.TabIndex = 11;
            // 
            // lblTotalNotPaid
            // 
            this.lblTotalNotPaid.Location = new System.Drawing.Point(14, 143);
            this.lblTotalNotPaid.Name = "lblTotalNotPaid";
            this.lblTotalNotPaid.Size = new System.Drawing.Size(102, 13);
            this.lblTotalNotPaid.TabIndex = 10;
            this.lblTotalNotPaid.Text = "Total Belum Terbayar";
            // 
            // txtTotalPaid
            // 
            this.txtTotalPaid.Location = new System.Drawing.Point(149, 113);
            this.txtTotalPaid.Name = "txtTotalPaid";
            this.txtTotalPaid.Properties.DisplayFormat.FormatString = " {0:#,#;(#,#);0}";
            this.txtTotalPaid.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalPaid.Properties.ReadOnly = true;
            this.txtTotalPaid.Size = new System.Drawing.Size(157, 20);
            this.txtTotalPaid.TabIndex = 9;
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.Location = new System.Drawing.Point(14, 116);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(71, 13);
            this.lblTotalPaid.TabIndex = 8;
            this.lblTotalPaid.Text = "Total Terbayar";
            // 
            // txtTotalTransaction
            // 
            this.txtTotalTransaction.Location = new System.Drawing.Point(149, 86);
            this.txtTotalTransaction.Name = "txtTotalTransaction";
            this.txtTotalTransaction.Properties.DisplayFormat.FormatString = " {0:#,#;(#,#);0}";
            this.txtTotalTransaction.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalTransaction.Properties.ReadOnly = true;
            this.txtTotalTransaction.Size = new System.Drawing.Size(157, 20);
            this.txtTotalTransaction.TabIndex = 7;
            // 
            // lblTotalTransaction
            // 
            this.lblTotalTransaction.Location = new System.Drawing.Point(14, 89);
            this.lblTotalTransaction.Name = "lblTotalTransaction";
            this.lblTotalTransaction.Size = new System.Drawing.Size(72, 13);
            this.lblTotalTransaction.TabIndex = 6;
            this.lblTotalTransaction.Text = "Total Transaksi";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(149, 59);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Properties.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(157, 20);
            this.txtCustomer.TabIndex = 5;
            // 
            // lblCustomer
            // 
            this.lblCustomer.Location = new System.Drawing.Point(14, 62);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(46, 13);
            this.lblCustomer.TabIndex = 4;
            this.lblCustomer.Text = "Customer";
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.Location = new System.Drawing.Point(14, 35);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(86, 13);
            this.lblTransactionDate.TabIndex = 2;
            this.lblTransactionDate.Text = "Tanggal Transaksi";
            // 
            // bgwSave
            // 
            this.bgwSave.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSave_DoWork);
            this.bgwSave.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSave_RunWorkerCompleted);
            // 
            // CreditEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 292);
            this.Controls.Add(this.gcCreditInfo);
            this.Name = "CreditEditorForm";
            this.Text = "Form Pembayaran Piutang";
            this.Load += new System.EventHandler(this.CreditEditorForm_Load);
            this.Controls.SetChildIndex(this.gcCreditInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcCreditInfo)).EndInit();
            this.gcCreditInfo.ResumeLayout(false);
            this.gcCreditInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaymentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPayment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalNotPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTransaction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valTotalPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valPaymentMethod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcCreditInfo;
        private DevExpress.XtraEditors.LabelControl lblTransactionDate;
        private DevExpress.XtraEditors.LabelControl lblPaymentType;
        private DevExpress.XtraEditors.TextEdit txtTotalPayment;
        private DevExpress.XtraEditors.LabelControl lblTotalPayment;
        private DevExpress.XtraEditors.TextEdit txtTotalNotPaid;
        private DevExpress.XtraEditors.LabelControl lblTotalNotPaid;
        private DevExpress.XtraEditors.TextEdit txtTotalPaid;
        private DevExpress.XtraEditors.LabelControl lblTotalPaid;
        private DevExpress.XtraEditors.TextEdit txtTotalTransaction;
        private DevExpress.XtraEditors.LabelControl lblTotalTransaction;
        private DevExpress.XtraEditors.TextEdit txtCustomer;
        private DevExpress.XtraEditors.LabelControl lblCustomer;
        private DevExpress.XtraEditors.LookUpEdit cbPaymentType;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valTotalPayment;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valPaymentMethod;
        private System.ComponentModel.BackgroundWorker bgwSave;
        private DevExpress.XtraEditors.DateEdit deTransDate;
    }
}