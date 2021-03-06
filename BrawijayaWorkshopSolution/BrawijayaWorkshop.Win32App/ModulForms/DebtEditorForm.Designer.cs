﻿namespace BrawijayaWorkshop.Win32App.ModulForms
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebtEditorForm));
            this.gcDebtInfo = new DevExpress.XtraEditors.GroupControl();
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
            this.txtSupplier = new DevExpress.XtraEditors.TextEdit();
            this.lblSupplier = new DevExpress.XtraEditors.LabelControl();
            this.lblTransactionDate = new DevExpress.XtraEditors.LabelControl();
            this.valTotalPayment = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valPaymentMethod = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.bgwSave = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gcDebtInfo)).BeginInit();
            this.gcDebtInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaymentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPayment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalNotPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTransaction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valTotalPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valPaymentMethod)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDebtInfo
            // 
            this.gcDebtInfo.Controls.Add(this.deTransDate);
            this.gcDebtInfo.Controls.Add(this.cbPaymentType);
            this.gcDebtInfo.Controls.Add(this.lblPaymentType);
            this.gcDebtInfo.Controls.Add(this.txtTotalPayment);
            this.gcDebtInfo.Controls.Add(this.lblTotalPayment);
            this.gcDebtInfo.Controls.Add(this.txtTotalNotPaid);
            this.gcDebtInfo.Controls.Add(this.lblTotalNotPaid);
            this.gcDebtInfo.Controls.Add(this.txtTotalPaid);
            this.gcDebtInfo.Controls.Add(this.lblTotalPaid);
            this.gcDebtInfo.Controls.Add(this.txtTotalTransaction);
            this.gcDebtInfo.Controls.Add(this.lblTotalTransaction);
            this.gcDebtInfo.Controls.Add(this.txtSupplier);
            this.gcDebtInfo.Controls.Add(this.lblSupplier);
            this.gcDebtInfo.Controls.Add(this.lblTransactionDate);
            this.gcDebtInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDebtInfo.Location = new System.Drawing.Point(0, 0);
            this.gcDebtInfo.Name = "gcDebtInfo";
            this.gcDebtInfo.Size = new System.Drawing.Size(336, 252);
            this.gcDebtInfo.TabIndex = 1;
            this.gcDebtInfo.Text = "Informasi Pembayaran";
            // 
            // deTransDate
            // 
            this.deTransDate.EditValue = null;
            this.deTransDate.Location = new System.Drawing.Point(158, 33);
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
            this.cbPaymentType.Location = new System.Drawing.Point(158, 215);
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
            this.valTotalPayment.SetValidationRule(this.cbPaymentType, conditionValidationRule1);
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.Location = new System.Drawing.Point(17, 218);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(87, 13);
            this.lblPaymentType.TabIndex = 14;
            this.lblPaymentType.Text = "Jenis Pembayaran";
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Location = new System.Drawing.Point(158, 188);
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
            this.lblTotalPayment.Location = new System.Drawing.Point(17, 191);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(91, 13);
            this.lblTotalPayment.TabIndex = 12;
            this.lblTotalPayment.Text = "Total Akan Dibayar";
            // 
            // txtTotalNotPaid
            // 
            this.txtTotalNotPaid.Location = new System.Drawing.Point(158, 141);
            this.txtTotalNotPaid.Name = "txtTotalNotPaid";
            this.txtTotalNotPaid.Properties.DisplayFormat.FormatString = " {0:#,#;(#,#);0}";
            this.txtTotalNotPaid.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalNotPaid.Properties.ReadOnly = true;
            this.txtTotalNotPaid.Size = new System.Drawing.Size(157, 20);
            this.txtTotalNotPaid.TabIndex = 11;
            // 
            // lblTotalNotPaid
            // 
            this.lblTotalNotPaid.Location = new System.Drawing.Point(17, 144);
            this.lblTotalNotPaid.Name = "lblTotalNotPaid";
            this.lblTotalNotPaid.Size = new System.Drawing.Size(102, 13);
            this.lblTotalNotPaid.TabIndex = 10;
            this.lblTotalNotPaid.Text = "Total Belum Terbayar";
            // 
            // txtTotalPaid
            // 
            this.txtTotalPaid.Location = new System.Drawing.Point(158, 114);
            this.txtTotalPaid.Name = "txtTotalPaid";
            this.txtTotalPaid.Properties.DisplayFormat.FormatString = " {0:#,#;(#,#);0}";
            this.txtTotalPaid.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalPaid.Properties.ReadOnly = true;
            this.txtTotalPaid.Size = new System.Drawing.Size(157, 20);
            this.txtTotalPaid.TabIndex = 9;
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.Location = new System.Drawing.Point(17, 117);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(71, 13);
            this.lblTotalPaid.TabIndex = 8;
            this.lblTotalPaid.Text = "Total Terbayar";
            // 
            // txtTotalTransaction
            // 
            this.txtTotalTransaction.Location = new System.Drawing.Point(158, 87);
            this.txtTotalTransaction.Name = "txtTotalTransaction";
            this.txtTotalTransaction.Properties.DisplayFormat.FormatString = " {0:#,#;(#,#);0}";
            this.txtTotalTransaction.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalTransaction.Properties.ReadOnly = true;
            this.txtTotalTransaction.Size = new System.Drawing.Size(157, 20);
            this.txtTotalTransaction.TabIndex = 7;
            // 
            // lblTotalTransaction
            // 
            this.lblTotalTransaction.Location = new System.Drawing.Point(17, 90);
            this.lblTotalTransaction.Name = "lblTotalTransaction";
            this.lblTotalTransaction.Size = new System.Drawing.Size(72, 13);
            this.lblTotalTransaction.TabIndex = 6;
            this.lblTotalTransaction.Text = "Total Transaksi";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(158, 60);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Properties.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(157, 20);
            this.txtSupplier.TabIndex = 5;
            // 
            // lblSupplier
            // 
            this.lblSupplier.Location = new System.Drawing.Point(17, 63);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(38, 13);
            this.lblSupplier.TabIndex = 4;
            this.lblSupplier.Text = "Supplier";
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.Location = new System.Drawing.Point(17, 36);
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
            // DebtEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 301);
            this.Controls.Add(this.gcDebtInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DebtEditorForm";
            this.Text = "Form Pembayaran Hutang";
            this.Load += new System.EventHandler(this.DebtEditorForm_Load);
            this.Controls.SetChildIndex(this.gcDebtInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcDebtInfo)).EndInit();
            this.gcDebtInfo.ResumeLayout(false);
            this.gcDebtInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaymentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPayment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalNotPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTransaction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valTotalPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valPaymentMethod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcDebtInfo;
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
        private DevExpress.XtraEditors.TextEdit txtSupplier;
        private DevExpress.XtraEditors.LabelControl lblSupplier;
        private DevExpress.XtraEditors.LookUpEdit cbPaymentType;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valTotalPayment;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valPaymentMethod;
        private System.ComponentModel.BackgroundWorker bgwSave;
        private DevExpress.XtraEditors.DateEdit deTransDate;
    }
}