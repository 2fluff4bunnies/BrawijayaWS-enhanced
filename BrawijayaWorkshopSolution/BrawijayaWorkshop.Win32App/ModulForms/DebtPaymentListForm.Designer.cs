﻿namespace BrawijayaWorkshop.Win32App.ModulControls
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebtPaymentListForm));
            this.gcDebtPaymentListInfo = new DevExpress.XtraEditors.GroupControl();
            this.deTransDate = new DevExpress.XtraEditors.DateEdit();
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
            this.lblTransactionDate = new DevExpress.XtraEditors.LabelControl();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcDebtPaymentListInfo)).BeginInit();
            this.gcDebtPaymentListInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDebtPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDebtPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalNotPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttTotalPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTransaction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplier.Properties)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcDebtPaymentListInfo
            // 
            this.gcDebtPaymentListInfo.Controls.Add(this.deTransDate);
            this.gcDebtPaymentListInfo.Controls.Add(this.gridDebtPayment);
            this.gcDebtPaymentListInfo.Controls.Add(this.txtTotalNotPaid);
            this.gcDebtPaymentListInfo.Controls.Add(this.lblTotalNotPaid);
            this.gcDebtPaymentListInfo.Controls.Add(this.ttTotalPaid);
            this.gcDebtPaymentListInfo.Controls.Add(this.lblTotalPaid);
            this.gcDebtPaymentListInfo.Controls.Add(this.txtTotalTransaction);
            this.gcDebtPaymentListInfo.Controls.Add(this.lblTotalTransaction);
            this.gcDebtPaymentListInfo.Controls.Add(this.txtSupplier);
            this.gcDebtPaymentListInfo.Controls.Add(this.lblSupplier);
            this.gcDebtPaymentListInfo.Controls.Add(this.lblTransactionDate);
            this.gcDebtPaymentListInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDebtPaymentListInfo.Location = new System.Drawing.Point(0, 0);
            this.gcDebtPaymentListInfo.Name = "gcDebtPaymentListInfo";
            this.gcDebtPaymentListInfo.Size = new System.Drawing.Size(538, 406);
            this.gcDebtPaymentListInfo.TabIndex = 1;
            this.gcDebtPaymentListInfo.Text = "Informasi Daftar Pembayaran";
            // 
            // deTransDate
            // 
            this.deTransDate.EditValue = null;
            this.deTransDate.Location = new System.Drawing.Point(148, 28);
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
            this.deTransDate.TabIndex = 23;
            // 
            // gridDebtPayment
            // 
            this.gridDebtPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDebtPayment.Location = new System.Drawing.Point(5, 174);
            this.gridDebtPayment.MainView = this.gvDebtPayment;
            this.gridDebtPayment.Name = "gridDebtPayment";
            this.gridDebtPayment.Size = new System.Drawing.Size(528, 227);
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
            this.colPaymentDate.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colPaymentDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colPaymentDate.FieldName = "TransactionDate";
            this.colPaymentDate.Name = "colPaymentDate";
            this.colPaymentDate.Visible = true;
            this.colPaymentDate.VisibleIndex = 0;
            // 
            // colTotalPayment
            // 
            this.colTotalPayment.Caption = "Jumlah Pembayaran";
            this.colTotalPayment.DisplayFormat.FormatString = " {0:#,#;(#,#);0}";
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
            this.txtTotalNotPaid.Location = new System.Drawing.Point(148, 136);
            this.txtTotalNotPaid.Name = "txtTotalNotPaid";
            this.txtTotalNotPaid.Properties.DisplayFormat.FormatString = " {0:#,#;(#,#);0}";
            this.txtTotalNotPaid.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalNotPaid.Properties.ReadOnly = true;
            this.txtTotalNotPaid.Size = new System.Drawing.Size(157, 20);
            this.txtTotalNotPaid.TabIndex = 21;
            // 
            // lblTotalNotPaid
            // 
            this.lblTotalNotPaid.Location = new System.Drawing.Point(12, 139);
            this.lblTotalNotPaid.Name = "lblTotalNotPaid";
            this.lblTotalNotPaid.Size = new System.Drawing.Size(102, 13);
            this.lblTotalNotPaid.TabIndex = 20;
            this.lblTotalNotPaid.Text = "Total Belum Terbayar";
            // 
            // ttTotalPaid
            // 
            this.ttTotalPaid.Location = new System.Drawing.Point(148, 109);
            this.ttTotalPaid.Name = "ttTotalPaid";
            this.ttTotalPaid.Properties.DisplayFormat.FormatString = " {0:#,#;(#,#);0}";
            this.ttTotalPaid.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ttTotalPaid.Properties.ReadOnly = true;
            this.ttTotalPaid.Size = new System.Drawing.Size(157, 20);
            this.ttTotalPaid.TabIndex = 19;
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.Location = new System.Drawing.Point(12, 112);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(71, 13);
            this.lblTotalPaid.TabIndex = 18;
            this.lblTotalPaid.Text = "Total Terbayar";
            // 
            // txtTotalTransaction
            // 
            this.txtTotalTransaction.Location = new System.Drawing.Point(148, 82);
            this.txtTotalTransaction.Name = "txtTotalTransaction";
            this.txtTotalTransaction.Properties.DisplayFormat.FormatString = " {0:#,#;(#,#);0}";
            this.txtTotalTransaction.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalTransaction.Properties.ReadOnly = true;
            this.txtTotalTransaction.Size = new System.Drawing.Size(157, 20);
            this.txtTotalTransaction.TabIndex = 17;
            // 
            // lblTotalTransaction
            // 
            this.lblTotalTransaction.Location = new System.Drawing.Point(12, 85);
            this.lblTotalTransaction.Name = "lblTotalTransaction";
            this.lblTotalTransaction.Size = new System.Drawing.Size(72, 13);
            this.lblTotalTransaction.TabIndex = 16;
            this.lblTotalTransaction.Text = "Total Transaksi";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(148, 55);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Properties.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(157, 20);
            this.txtSupplier.TabIndex = 15;
            // 
            // lblSupplier
            // 
            this.lblSupplier.Location = new System.Drawing.Point(12, 58);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(38, 13);
            this.lblSupplier.TabIndex = 14;
            this.lblSupplier.Text = "Supplier";
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.Location = new System.Drawing.Point(12, 31);
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
            // DebtPaymentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 406);
            this.Controls.Add(this.gcDebtPaymentListInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DebtPaymentListForm";
            this.Text = "Daftar Pembayaran Hutang";
            this.Load += new System.EventHandler(this.DebtPaymentListControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDebtPaymentListInfo)).EndInit();
            this.gcDebtPaymentListInfo.ResumeLayout(false);
            this.gcDebtPaymentListInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDebtPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDebtPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalNotPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttTotalPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTransaction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplier.Properties)).EndInit();
            this.cmsEditor.ResumeLayout(false);
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
        private DevExpress.XtraEditors.LabelControl lblTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPayment;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentType;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsDelete;
        private DevExpress.XtraEditors.DateEdit deTransDate;

    }
}