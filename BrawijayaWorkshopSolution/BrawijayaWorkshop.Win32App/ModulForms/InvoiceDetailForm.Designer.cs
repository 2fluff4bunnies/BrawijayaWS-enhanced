namespace BrawijayaWorkshop.Win32App.ModulForms
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
            this.gcInvoiceInfo = new DevExpress.XtraEditors.GroupControl();
            this.pnlAction = new DevExpress.XtraEditors.PanelControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtTotalTransaction = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalTransaction = new DevExpress.XtraEditors.LabelControl();
            this.gridSparepart = new DevExpress.XtraGrid.GridControl();
            this.gvSparepart = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSparepart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFeePctg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinalSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCustomer = new DevExpress.XtraEditors.TextEdit();
            this.lblCustomer = new DevExpress.XtraEditors.LabelControl();
            this.txtTransactionDate = new DevExpress.XtraEditors.TextEdit();
            this.lblTransactionDate = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalServicePlusFee = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalService = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalSparepartPlusFee = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalSparepart = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcInvoiceInfo)).BeginInit();
            this.gcInvoiceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).BeginInit();
            this.pnlAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTransaction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransactionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalServicePlusFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalService.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalSparepartPlusFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalSparepart.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcInvoiceInfo
            // 
            this.gcInvoiceInfo.Controls.Add(this.txtTotalSparepart);
            this.gcInvoiceInfo.Controls.Add(this.labelControl4);
            this.gcInvoiceInfo.Controls.Add(this.txtTotalSparepartPlusFee);
            this.gcInvoiceInfo.Controls.Add(this.labelControl3);
            this.gcInvoiceInfo.Controls.Add(this.txtTotalService);
            this.gcInvoiceInfo.Controls.Add(this.labelControl2);
            this.gcInvoiceInfo.Controls.Add(this.txtTotalServicePlusFee);
            this.gcInvoiceInfo.Controls.Add(this.labelControl1);
            this.gcInvoiceInfo.Controls.Add(this.pnlAction);
            this.gcInvoiceInfo.Controls.Add(this.txtTotalTransaction);
            this.gcInvoiceInfo.Controls.Add(this.lblTotalTransaction);
            this.gcInvoiceInfo.Controls.Add(this.gridSparepart);
            this.gcInvoiceInfo.Controls.Add(this.txtCustomer);
            this.gcInvoiceInfo.Controls.Add(this.lblCustomer);
            this.gcInvoiceInfo.Controls.Add(this.txtTransactionDate);
            this.gcInvoiceInfo.Controls.Add(this.lblTransactionDate);
            this.gcInvoiceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcInvoiceInfo.Location = new System.Drawing.Point(0, 0);
            this.gcInvoiceInfo.Name = "gcInvoiceInfo";
            this.gcInvoiceInfo.Size = new System.Drawing.Size(418, 474);
            this.gcInvoiceInfo.TabIndex = 2;
            this.gcInvoiceInfo.Text = "Informasi Invoice";
            // 
            // pnlAction
            // 
            this.pnlAction.Appearance.BackColor = System.Drawing.Color.Silver;
            this.pnlAction.Appearance.Options.UseBackColor = true;
            this.pnlAction.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlAction.Controls.Add(this.btnPrint);
            this.pnlAction.Controls.Add(this.btnCancel);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAction.Location = new System.Drawing.Point(2, 423);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(414, 49);
            this.pnlAction.TabIndex = 11;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(234, 14);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Cetak";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(327, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Batal";
            // 
            // txtTotalTransaction
            // 
            this.txtTotalTransaction.Location = new System.Drawing.Point(151, 387);
            this.txtTotalTransaction.Name = "txtTotalTransaction";
            this.txtTotalTransaction.Properties.ReadOnly = true;
            this.txtTotalTransaction.Size = new System.Drawing.Size(134, 20);
            this.txtTotalTransaction.TabIndex = 10;
            // 
            // lblTotalTransaction
            // 
            this.lblTotalTransaction.Location = new System.Drawing.Point(14, 390);
            this.lblTotalTransaction.Name = "lblTotalTransaction";
            this.lblTotalTransaction.Size = new System.Drawing.Size(72, 13);
            this.lblTotalTransaction.TabIndex = 9;
            this.lblTotalTransaction.Text = "Total Transaksi";
            // 
            // gridSparepart
            // 
            this.gridSparepart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSparepart.Location = new System.Drawing.Point(5, 104);
            this.gridSparepart.MainView = this.gvSparepart;
            this.gridSparepart.Name = "gridSparepart";
            this.gridSparepart.Size = new System.Drawing.Size(413, 167);
            this.gridSparepart.TabIndex = 8;
            this.gridSparepart.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSparepart});
            // 
            // gvSparepart
            // 
            this.gvSparepart.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSparepart,
            this.colQty,
            this.colSubTotal,
            this.colFeePctg,
            this.colFinalSubTotal});
            this.gvSparepart.GridControl = this.gridSparepart;
            this.gvSparepart.Name = "gvSparepart";
            this.gvSparepart.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvSparepart.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvSparepart.OptionsBehavior.AutoPopulateColumns = false;
            this.gvSparepart.OptionsBehavior.Editable = false;
            this.gvSparepart.OptionsBehavior.ReadOnly = true;
            this.gvSparepart.OptionsCustomization.AllowColumnMoving = false;
            this.gvSparepart.OptionsCustomization.AllowFilter = false;
            this.gvSparepart.OptionsCustomization.AllowGroup = false;
            this.gvSparepart.OptionsView.EnableAppearanceEvenRow = true;
            this.gvSparepart.OptionsView.ShowGroupPanel = false;
            this.gvSparepart.OptionsView.ShowViewCaption = true;
            this.gvSparepart.ViewCaption = "Daftar Sparepart";
            // 
            // colSparepart
            // 
            this.colSparepart.Caption = "Sparepart";
            this.colSparepart.Name = "colSparepart";
            this.colSparepart.Visible = true;
            this.colSparepart.VisibleIndex = 0;
            // 
            // colQty
            // 
            this.colQty.Caption = "Jumlah";
            this.colQty.Name = "colQty";
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 1;
            // 
            // colSubTotal
            // 
            this.colSubTotal.Caption = "Sub Total";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.Visible = true;
            this.colSubTotal.VisibleIndex = 2;
            // 
            // colFeePctg
            // 
            this.colFeePctg.Caption = "Tambahan Biaya (%)";
            this.colFeePctg.Name = "colFeePctg";
            this.colFeePctg.Visible = true;
            this.colFeePctg.VisibleIndex = 3;
            // 
            // colFinalSubTotal
            // 
            this.colFinalSubTotal.Caption = "Sub Total + Biaya";
            this.colFinalSubTotal.Name = "colFinalSubTotal";
            this.colFinalSubTotal.Visible = true;
            this.colFinalSubTotal.VisibleIndex = 4;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(130, 60);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Properties.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(247, 20);
            this.txtCustomer.TabIndex = 7;
            // 
            // lblCustomer
            // 
            this.lblCustomer.Location = new System.Drawing.Point(14, 63);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(46, 13);
            this.lblCustomer.TabIndex = 6;
            this.lblCustomer.Text = "Customer";
            // 
            // txtTransactionDate
            // 
            this.txtTransactionDate.Location = new System.Drawing.Point(130, 32);
            this.txtTransactionDate.Name = "txtTransactionDate";
            this.txtTransactionDate.Properties.ReadOnly = true;
            this.txtTransactionDate.Size = new System.Drawing.Size(115, 20);
            this.txtTransactionDate.TabIndex = 5;
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.Location = new System.Drawing.Point(14, 33);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(86, 13);
            this.lblTransactionDate.TabIndex = 4;
            this.lblTransactionDate.Text = "Tanggal Transaksi";
            // 
            // txtTotalServicePlusFee
            // 
            this.txtTotalServicePlusFee.Location = new System.Drawing.Point(151, 361);
            this.txtTotalServicePlusFee.Name = "txtTotalServicePlusFee";
            this.txtTotalServicePlusFee.Properties.ReadOnly = true;
            this.txtTotalServicePlusFee.Size = new System.Drawing.Size(134, 20);
            this.txtTotalServicePlusFee.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 364);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Total Service (+Fee)";
            // 
            // txtTotalService
            // 
            this.txtTotalService.Location = new System.Drawing.Point(151, 335);
            this.txtTotalService.Name = "txtTotalService";
            this.txtTotalService.Properties.ReadOnly = true;
            this.txtTotalService.Size = new System.Drawing.Size(134, 20);
            this.txtTotalService.TabIndex = 15;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 338);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Total Service";
            // 
            // txtTotalSparepartPlusFee
            // 
            this.txtTotalSparepartPlusFee.Location = new System.Drawing.Point(151, 309);
            this.txtTotalSparepartPlusFee.Name = "txtTotalSparepartPlusFee";
            this.txtTotalSparepartPlusFee.Properties.ReadOnly = true;
            this.txtTotalSparepartPlusFee.Size = new System.Drawing.Size(134, 20);
            this.txtTotalSparepartPlusFee.TabIndex = 17;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 312);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(112, 13);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Total Sparepart (+Fee)";
            // 
            // txtTotalSparepart
            // 
            this.txtTotalSparepart.Location = new System.Drawing.Point(151, 283);
            this.txtTotalSparepart.Name = "txtTotalSparepart";
            this.txtTotalSparepart.Properties.ReadOnly = true;
            this.txtTotalSparepart.Size = new System.Drawing.Size(134, 20);
            this.txtTotalSparepart.TabIndex = 19;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 286);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 13);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Total Sparepart";
            // 
            // InvoiceDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 474);
            this.Controls.Add(this.gcInvoiceInfo);
            this.Name = "InvoiceDetailForm";
            this.Text = "InvoiceDetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.gcInvoiceInfo)).EndInit();
            this.gcInvoiceInfo.ResumeLayout(false);
            this.gcInvoiceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).EndInit();
            this.pnlAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTransaction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransactionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalServicePlusFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalService.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalSparepartPlusFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalSparepart.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcInvoiceInfo;
        private DevExpress.XtraEditors.TextEdit txtTotalTransaction;
        private DevExpress.XtraEditors.LabelControl lblTotalTransaction;
        private DevExpress.XtraGrid.GridControl gridSparepart;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSparepart;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepart;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colFeePctg;
        private DevExpress.XtraGrid.Columns.GridColumn colFinalSubTotal;
        private DevExpress.XtraEditors.TextEdit txtCustomer;
        private DevExpress.XtraEditors.LabelControl lblCustomer;
        private DevExpress.XtraEditors.TextEdit txtTransactionDate;
        private DevExpress.XtraEditors.LabelControl lblTransactionDate;
        private DevExpress.XtraEditors.PanelControl pnlAction;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TextEdit txtTotalSparepart;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTotalSparepartPlusFee;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTotalService;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTotalServicePlusFee;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}