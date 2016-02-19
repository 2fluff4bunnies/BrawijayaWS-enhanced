namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class InvoiceEditorForm
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
            this.txtCustomer = new DevExpress.XtraEditors.TextEdit();
            this.lblCustomer = new DevExpress.XtraEditors.LabelControl();
            this.txtTransactionDate = new DevExpress.XtraEditors.TextEdit();
            this.lblTransactionDate = new DevExpress.XtraEditors.LabelControl();
            this.gridSparepart = new DevExpress.XtraGrid.GridControl();
            this.gvSparepart = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtTotalTransaction = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalTransaction = new DevExpress.XtraEditors.LabelControl();
            this.colSparepart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFeePctg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinalSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcInvoiceInfo)).BeginInit();
            this.gcInvoiceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransactionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTransaction.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcInvoiceInfo
            // 
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
            this.gcInvoiceInfo.Size = new System.Drawing.Size(451, 335);
            this.gcInvoiceInfo.TabIndex = 1;
            this.gcInvoiceInfo.Text = "Informasi Invoice";
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
            // gridSparepart
            // 
            this.gridSparepart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSparepart.Location = new System.Drawing.Point(5, 104);
            this.gridSparepart.MainView = this.gvSparepart;
            this.gridSparepart.Name = "gridSparepart";
            this.gridSparepart.Size = new System.Drawing.Size(446, 167);
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
            // txtTotalTransaction
            // 
            this.txtTotalTransaction.Location = new System.Drawing.Point(130, 296);
            this.txtTotalTransaction.Name = "txtTotalTransaction";
            this.txtTotalTransaction.Properties.ReadOnly = true;
            this.txtTotalTransaction.Size = new System.Drawing.Size(134, 20);
            this.txtTotalTransaction.TabIndex = 10;
            // 
            // lblTotalTransaction
            // 
            this.lblTotalTransaction.Location = new System.Drawing.Point(14, 299);
            this.lblTotalTransaction.Name = "lblTotalTransaction";
            this.lblTotalTransaction.Size = new System.Drawing.Size(72, 13);
            this.lblTotalTransaction.TabIndex = 9;
            this.lblTotalTransaction.Text = "Total Transaksi";
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
            // colFeePctg
            // 
            this.colFeePctg.Caption = "Tambahan Biaya (%)";
            this.colFeePctg.Name = "colFeePctg";
            this.colFeePctg.Visible = true;
            this.colFeePctg.VisibleIndex = 3;
            // 
            // colSubTotal
            // 
            this.colSubTotal.Caption = "Sub Total";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.Visible = true;
            this.colSubTotal.VisibleIndex = 2;
            // 
            // colFinalSubTotal
            // 
            this.colFinalSubTotal.Caption = "Sub Total + Biaya";
            this.colFinalSubTotal.Name = "colFinalSubTotal";
            this.colFinalSubTotal.Visible = true;
            this.colFinalSubTotal.VisibleIndex = 4;
            // 
            // InvoiceEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 384);
            this.Controls.Add(this.gcInvoiceInfo);
            this.Name = "InvoiceEditorForm";
            this.Text = "Form Editor Invoice";
            this.Controls.SetChildIndex(this.gcInvoiceInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcInvoiceInfo)).EndInit();
            this.gcInvoiceInfo.ResumeLayout(false);
            this.gcInvoiceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransactionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTransaction.Properties)).EndInit();
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
    }
}