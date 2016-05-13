﻿namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class InvoiceDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceDetailForm));
            this.lblTransactionDate = new DevExpress.XtraEditors.LabelControl();
            this.lblCustomer = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomer = new DevExpress.XtraEditors.TextEdit();
            this.pnlAction = new DevExpress.XtraEditors.PanelControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.gcInvoiceInfo = new DevExpress.XtraEditors.GroupControl();
            this.txtTotalTransaction = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalTransaction = new DevExpress.XtraEditors.LabelControl();
            this.txtFeeSparepart = new DevExpress.XtraEditors.TextEdit();
            this.lblFeeSparepart = new DevExpress.XtraEditors.LabelControl();
            this.txtFeeService20 = new DevExpress.XtraEditors.TextEdit();
            this.lblFeeService20 = new DevExpress.XtraEditors.LabelControl();
            this.txtFeeService10 = new DevExpress.XtraEditors.TextEdit();
            this.lblServiceFee10 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalSparepart = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalSparepartPlusFee = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalService = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalServicePlusFee = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridSparepart = new DevExpress.XtraGrid.GridControl();
            this.gvSparepart = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSparepartDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchasePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFeePctg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinalSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbPaymentType = new DevExpress.XtraEditors.LookUpEdit();
            this.lblPaymentType = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalPayment = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalPayment = new DevExpress.XtraEditors.LabelControl();
            this.bsSparepart = new System.Windows.Forms.BindingSource();
            this.deTransDate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).BeginInit();
            this.pnlAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcInvoiceInfo)).BeginInit();
            this.gcInvoiceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTransaction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFeeSparepart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFeeService20.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFeeService10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalSparepart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalSparepartPlusFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalService.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalServicePlusFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaymentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPayment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.Location = new System.Drawing.Point(16, 35);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(86, 13);
            this.lblTransactionDate.TabIndex = 4;
            this.lblTransactionDate.Text = "Tanggal Transaksi";
            // 
            // lblCustomer
            // 
            this.lblCustomer.Location = new System.Drawing.Point(16, 63);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(46, 13);
            this.lblCustomer.TabIndex = 6;
            this.lblCustomer.Text = "Customer";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(153, 60);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Properties.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(247, 20);
            this.txtCustomer.TabIndex = 7;
            // 
            // pnlAction
            // 
            this.pnlAction.Appearance.BackColor = System.Drawing.Color.Silver;
            this.pnlAction.Appearance.Options.UseBackColor = true;
            this.pnlAction.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlAction.Controls.Add(this.btnPrint);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAction.Location = new System.Drawing.Point(2, 550);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(802, 49);
            this.pnlAction.TabIndex = 11;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(717, 16);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Cetak";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(585, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Batal";
            // 
            // gcInvoiceInfo
            // 
            this.gcInvoiceInfo.Controls.Add(this.deTransDate);
            this.gcInvoiceInfo.Controls.Add(this.txtTotalTransaction);
            this.gcInvoiceInfo.Controls.Add(this.lblTotalTransaction);
            this.gcInvoiceInfo.Controls.Add(this.txtFeeSparepart);
            this.gcInvoiceInfo.Controls.Add(this.lblFeeSparepart);
            this.gcInvoiceInfo.Controls.Add(this.txtFeeService20);
            this.gcInvoiceInfo.Controls.Add(this.lblFeeService20);
            this.gcInvoiceInfo.Controls.Add(this.txtFeeService10);
            this.gcInvoiceInfo.Controls.Add(this.lblServiceFee10);
            this.gcInvoiceInfo.Controls.Add(this.txtTotalSparepart);
            this.gcInvoiceInfo.Controls.Add(this.labelControl4);
            this.gcInvoiceInfo.Controls.Add(this.txtTotalSparepartPlusFee);
            this.gcInvoiceInfo.Controls.Add(this.labelControl3);
            this.gcInvoiceInfo.Controls.Add(this.txtTotalService);
            this.gcInvoiceInfo.Controls.Add(this.labelControl2);
            this.gcInvoiceInfo.Controls.Add(this.txtTotalServicePlusFee);
            this.gcInvoiceInfo.Controls.Add(this.labelControl1);
            this.gcInvoiceInfo.Controls.Add(this.gridSparepart);
            this.gcInvoiceInfo.Controls.Add(this.cbPaymentType);
            this.gcInvoiceInfo.Controls.Add(this.lblPaymentType);
            this.gcInvoiceInfo.Controls.Add(this.txtTotalPayment);
            this.gcInvoiceInfo.Controls.Add(this.lblTotalPayment);
            this.gcInvoiceInfo.Controls.Add(this.pnlAction);
            this.gcInvoiceInfo.Controls.Add(this.txtCustomer);
            this.gcInvoiceInfo.Controls.Add(this.lblCustomer);
            this.gcInvoiceInfo.Controls.Add(this.lblTransactionDate);
            this.gcInvoiceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcInvoiceInfo.Location = new System.Drawing.Point(0, 0);
            this.gcInvoiceInfo.Name = "gcInvoiceInfo";
            this.gcInvoiceInfo.Size = new System.Drawing.Size(806, 601);
            this.gcInvoiceInfo.TabIndex = 2;
            this.gcInvoiceInfo.Text = "Informasi Invoice";
            // 
            // txtTotalTransaction
            // 
            this.txtTotalTransaction.Location = new System.Drawing.Point(153, 463);
            this.txtTotalTransaction.Name = "txtTotalTransaction";
            this.txtTotalTransaction.Properties.ReadOnly = true;
            this.txtTotalTransaction.Size = new System.Drawing.Size(158, 20);
            this.txtTotalTransaction.TabIndex = 58;
            // 
            // lblTotalTransaction
            // 
            this.lblTotalTransaction.Location = new System.Drawing.Point(16, 466);
            this.lblTotalTransaction.Name = "lblTotalTransaction";
            this.lblTotalTransaction.Size = new System.Drawing.Size(72, 13);
            this.lblTotalTransaction.TabIndex = 57;
            this.lblTotalTransaction.Text = "Total Transaksi";
            // 
            // txtFeeSparepart
            // 
            this.txtFeeSparepart.Location = new System.Drawing.Point(153, 310);
            this.txtFeeSparepart.Name = "txtFeeSparepart";
            this.txtFeeSparepart.Properties.ReadOnly = true;
            this.txtFeeSparepart.Size = new System.Drawing.Size(158, 20);
            this.txtFeeSparepart.TabIndex = 56;
            // 
            // lblFeeSparepart
            // 
            this.lblFeeSparepart.Location = new System.Drawing.Point(16, 313);
            this.lblFeeSparepart.Name = "lblFeeSparepart";
            this.lblFeeSparepart.Size = new System.Drawing.Size(96, 13);
            this.lblFeeSparepart.TabIndex = 55;
            this.lblFeeSparepart.Text = "Total Fee Sparepart";
            // 
            // txtFeeService20
            // 
            this.txtFeeService20.Location = new System.Drawing.Point(491, 397);
            this.txtFeeService20.Name = "txtFeeService20";
            this.txtFeeService20.Properties.ReadOnly = true;
            this.txtFeeService20.Size = new System.Drawing.Size(158, 20);
            this.txtFeeService20.TabIndex = 54;
            // 
            // lblFeeService20
            // 
            this.lblFeeService20.Location = new System.Drawing.Point(354, 400);
            this.lblFeeService20.Name = "lblFeeService20";
            this.lblFeeService20.Size = new System.Drawing.Size(120, 13);
            this.lblFeeService20.TabIndex = 53;
            this.lblFeeService20.Text = "Total Fee Service  (20%)";
            // 
            // txtFeeService10
            // 
            this.txtFeeService10.Location = new System.Drawing.Point(153, 397);
            this.txtFeeService10.Name = "txtFeeService10";
            this.txtFeeService10.Properties.ReadOnly = true;
            this.txtFeeService10.Size = new System.Drawing.Size(158, 20);
            this.txtFeeService10.TabIndex = 52;
            // 
            // lblServiceFee10
            // 
            this.lblServiceFee10.Location = new System.Drawing.Point(16, 400);
            this.lblServiceFee10.Name = "lblServiceFee10";
            this.lblServiceFee10.Size = new System.Drawing.Size(120, 13);
            this.lblServiceFee10.TabIndex = 51;
            this.lblServiceFee10.Text = "Total Fee Service  (10%)";
            // 
            // txtTotalSparepart
            // 
            this.txtTotalSparepart.Location = new System.Drawing.Point(153, 284);
            this.txtTotalSparepart.Name = "txtTotalSparepart";
            this.txtTotalSparepart.Properties.ReadOnly = true;
            this.txtTotalSparepart.Size = new System.Drawing.Size(158, 20);
            this.txtTotalSparepart.TabIndex = 50;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 286);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 13);
            this.labelControl4.TabIndex = 49;
            this.labelControl4.Text = "Total Sparepart";
            // 
            // txtTotalSparepartPlusFee
            // 
            this.txtTotalSparepartPlusFee.Location = new System.Drawing.Point(153, 337);
            this.txtTotalSparepartPlusFee.Name = "txtTotalSparepartPlusFee";
            this.txtTotalSparepartPlusFee.Properties.ReadOnly = true;
            this.txtTotalSparepartPlusFee.Size = new System.Drawing.Size(158, 20);
            this.txtTotalSparepartPlusFee.TabIndex = 48;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 341);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(112, 13);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "Total Sparepart (+Fee)";
            // 
            // txtTotalService
            // 
            this.txtTotalService.Location = new System.Drawing.Point(153, 370);
            this.txtTotalService.Name = "txtTotalService";
            this.txtTotalService.Properties.ReadOnly = true;
            this.txtTotalService.Size = new System.Drawing.Size(158, 20);
            this.txtTotalService.TabIndex = 46;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 377);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 45;
            this.labelControl2.Text = "Total Service";
            // 
            // txtTotalServicePlusFee
            // 
            this.txtTotalServicePlusFee.Location = new System.Drawing.Point(153, 423);
            this.txtTotalServicePlusFee.Name = "txtTotalServicePlusFee";
            this.txtTotalServicePlusFee.Properties.ReadOnly = true;
            this.txtTotalServicePlusFee.Size = new System.Drawing.Size(158, 20);
            this.txtTotalServicePlusFee.TabIndex = 44;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 426);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 13);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "Total Service (+Fee)";
            // 
            // gridSparepart
            // 
            this.gridSparepart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSparepart.Location = new System.Drawing.Point(5, 86);
            this.gridSparepart.MainView = this.gvSparepart;
            this.gridSparepart.Name = "gridSparepart";
            this.gridSparepart.Size = new System.Drawing.Size(796, 186);
            this.gridSparepart.TabIndex = 42;
            this.gridSparepart.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSparepart,
            this.gridView1});
            // 
            // gvSparepart
            // 
            this.gvSparepart.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSparepartDetail,
            this.colSparepartName,
            this.colPurchasePrice,
            this.colFeePctg,
            this.colFinalSubTotal});
            this.gvSparepart.GridControl = this.gridSparepart;
            this.gvSparepart.Name = "gvSparepart";
            this.gvSparepart.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvSparepart.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvSparepart.OptionsBehavior.AutoPopulateColumns = false;
            this.gvSparepart.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gvSparepart.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvSparepart.OptionsView.EnableAppearanceEvenRow = true;
            this.gvSparepart.OptionsView.ShowGroupPanel = false;
            this.gvSparepart.OptionsView.ShowViewCaption = true;
            this.gvSparepart.ViewCaption = "Daftar Sparepart";
            // 
            // colSparepartDetail
            // 
            this.colSparepartDetail.Caption = "Kode Item";
            this.colSparepartDetail.FieldName = "SPKDetailSparepartDetail.SparepartDetail.Code";
            this.colSparepartDetail.Name = "colSparepartDetail";
            this.colSparepartDetail.OptionsColumn.ReadOnly = true;
            this.colSparepartDetail.Visible = true;
            this.colSparepartDetail.VisibleIndex = 0;
            // 
            // colSparepartName
            // 
            this.colSparepartName.Caption = "Sparepart";
            this.colSparepartName.FieldName = "SPKDetailSparepartDetail.SparepartDetail.Sparepart.Name";
            this.colSparepartName.Name = "colSparepartName";
            this.colSparepartName.OptionsColumn.ReadOnly = true;
            this.colSparepartName.Visible = true;
            this.colSparepartName.VisibleIndex = 1;
            // 
            // colPurchasePrice
            // 
            this.colPurchasePrice.Caption = "Harga Beli";
            this.colPurchasePrice.DisplayFormat.FormatString = "{0:#,#}";
            this.colPurchasePrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPurchasePrice.FieldName = "ItemPrice";
            this.colPurchasePrice.Name = "colPurchasePrice";
            this.colPurchasePrice.OptionsColumn.ReadOnly = true;
            this.colPurchasePrice.Visible = true;
            this.colPurchasePrice.VisibleIndex = 2;
            // 
            // colFeePctg
            // 
            this.colFeePctg.Caption = "Tambahan Biaya (%)";
            this.colFeePctg.DisplayFormat.FormatString = "{0:#,#}";
            this.colFeePctg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFeePctg.FieldName = "FeePctg";
            this.colFeePctg.Name = "colFeePctg";
            this.colFeePctg.OptionsColumn.ReadOnly = true;
            this.colFeePctg.Visible = true;
            this.colFeePctg.VisibleIndex = 3;
            // 
            // colFinalSubTotal
            // 
            this.colFinalSubTotal.Caption = "Total + Fee";
            this.colFinalSubTotal.DisplayFormat.FormatString = "{0:#,#}";
            this.colFinalSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFinalSubTotal.FieldName = "SubTotalPrice";
            this.colFinalSubTotal.Name = "colFinalSubTotal";
            this.colFinalSubTotal.OptionsColumn.ReadOnly = true;
            this.colFinalSubTotal.Visible = true;
            this.colFinalSubTotal.VisibleIndex = 4;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridSparepart;
            this.gridView1.Name = "gridView1";
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.Location = new System.Drawing.Point(153, 515);
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
            this.cbPaymentType.Properties.NullText = "";
            this.cbPaymentType.Properties.ReadOnly = true;
            this.cbPaymentType.Properties.ValueMember = "Id";
            this.cbPaymentType.Size = new System.Drawing.Size(158, 20);
            this.cbPaymentType.TabIndex = 33;
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.Location = new System.Drawing.Point(16, 518);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(87, 13);
            this.lblPaymentType.TabIndex = 32;
            this.lblPaymentType.Text = "Jenis Pembayaran";
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Location = new System.Drawing.Point(153, 489);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.Properties.ReadOnly = true;
            this.txtTotalPayment.Size = new System.Drawing.Size(158, 20);
            this.txtTotalPayment.TabIndex = 31;
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.Location = new System.Drawing.Point(16, 492);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(87, 13);
            this.lblTotalPayment.TabIndex = 30;
            this.lblTotalPayment.Text = "Total Pembayaran";
            // 
            // deTransDate
            // 
            this.deTransDate.EditValue = null;
            this.deTransDate.Location = new System.Drawing.Point(153, 32);
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
            this.deTransDate.Size = new System.Drawing.Size(158, 20);
            this.deTransDate.TabIndex = 59;
            // 
            // InvoiceDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 601);
            this.Controls.Add(this.gcInvoiceInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvoiceDetailForm";
            this.Text = "Form Detail Invoice";
            this.Load += new System.EventHandler(this.InvoiceDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).EndInit();
            this.pnlAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcInvoiceInfo)).EndInit();
            this.gcInvoiceInfo.ResumeLayout(false);
            this.gcInvoiceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTransaction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFeeSparepart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFeeService20.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFeeService10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalSparepart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalSparepartPlusFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalService.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalServicePlusFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaymentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPayment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTransactionDate;
        private DevExpress.XtraEditors.LabelControl lblCustomer;
        private DevExpress.XtraEditors.TextEdit txtCustomer;
        private DevExpress.XtraEditors.PanelControl pnlAction;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.GroupControl gcInvoiceInfo;
        private DevExpress.XtraEditors.LookUpEdit cbPaymentType;
        private DevExpress.XtraEditors.LabelControl lblPaymentType;
        private DevExpress.XtraEditors.TextEdit txtTotalPayment;
        private DevExpress.XtraEditors.LabelControl lblTotalPayment;
        private System.Windows.Forms.BindingSource bsSparepart;
        private DevExpress.XtraGrid.GridControl gridSparepart;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSparepart;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartName;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchasePrice;
        private DevExpress.XtraGrid.Columns.GridColumn colFeePctg;
        private DevExpress.XtraGrid.Columns.GridColumn colFinalSubTotal;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtFeeSparepart;
        private DevExpress.XtraEditors.LabelControl lblFeeSparepart;
        private DevExpress.XtraEditors.TextEdit txtFeeService20;
        private DevExpress.XtraEditors.LabelControl lblFeeService20;
        private DevExpress.XtraEditors.TextEdit txtFeeService10;
        private DevExpress.XtraEditors.LabelControl lblServiceFee10;
        private DevExpress.XtraEditors.TextEdit txtTotalSparepart;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTotalSparepartPlusFee;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTotalService;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTotalServicePlusFee;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTotalTransaction;
        private DevExpress.XtraEditors.LabelControl lblTotalTransaction;
        private DevExpress.XtraEditors.DateEdit deTransDate;

    }
}