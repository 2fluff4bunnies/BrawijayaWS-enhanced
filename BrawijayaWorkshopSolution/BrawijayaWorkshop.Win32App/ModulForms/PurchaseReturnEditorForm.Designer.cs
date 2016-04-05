namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class PurchaseReturnEditorForm
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
            this.gcPurchaseReturnInfo = new DevExpress.XtraEditors.GroupControl();
            this.gridSparepart = new DevExpress.XtraGrid.GridControl();
            this.gvSparepart = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSparepartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReturQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtSupplier = new DevExpress.XtraEditors.TextEdit();
            this.lblSupplier = new DevExpress.XtraEditors.LabelControl();
            this.txtTransactionDate = new DevExpress.XtraEditors.TextEdit();
            this.lblTransactionDate = new DevExpress.XtraEditors.LabelControl();
            this.bsSparepart = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcPurchaseReturnInfo)).BeginInit();
            this.gcPurchaseReturnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransactionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSparepart)).BeginInit();
            this.SuspendLayout();
            // 
            // gcPurchaseReturnInfo
            // 
            this.gcPurchaseReturnInfo.Controls.Add(this.gridSparepart);
            this.gcPurchaseReturnInfo.Controls.Add(this.txtSupplier);
            this.gcPurchaseReturnInfo.Controls.Add(this.lblSupplier);
            this.gcPurchaseReturnInfo.Controls.Add(this.txtTransactionDate);
            this.gcPurchaseReturnInfo.Controls.Add(this.lblTransactionDate);
            this.gcPurchaseReturnInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPurchaseReturnInfo.Location = new System.Drawing.Point(0, 0);
            this.gcPurchaseReturnInfo.Name = "gcPurchaseReturnInfo";
            this.gcPurchaseReturnInfo.Size = new System.Drawing.Size(577, 281);
            this.gcPurchaseReturnInfo.TabIndex = 1;
            this.gcPurchaseReturnInfo.Text = "Informasi Retur Pembelian";
            // 
            // gridSparepart
            // 
            this.gridSparepart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSparepart.Location = new System.Drawing.Point(0, 102);
            this.gridSparepart.MainView = this.gvSparepart;
            this.gridSparepart.Name = "gridSparepart";
            this.gridSparepart.Size = new System.Drawing.Size(577, 179);
            this.gridSparepart.TabIndex = 29;
            this.gridSparepart.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSparepart,
            this.gridView1});
            // 
            // gvSparepart
            // 
            this.gvSparepart.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSparepartName,
            this.colReturQty});
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
            // colSparepartName
            // 
            this.colSparepartName.Caption = "Sparepart";
            this.colSparepartName.FieldName = "SparepartName";
            this.colSparepartName.Name = "colSparepartName";
            this.colSparepartName.OptionsColumn.ReadOnly = true;
            this.colSparepartName.Visible = true;
            this.colSparepartName.VisibleIndex = 0;
            // 
            // colReturQty
            // 
            this.colReturQty.Caption = "Tambahan Biaya (%)";
            this.colReturQty.DisplayFormat.FormatString = "{0:#,#}";
            this.colReturQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colReturQty.FieldName = "ReturQty";
            this.colReturQty.Name = "colReturQty";
            this.colReturQty.Visible = true;
            this.colReturQty.VisibleIndex = 1;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridSparepart;
            this.gridView1.Name = "gridView1";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(140, 60);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Properties.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(208, 20);
            this.txtSupplier.TabIndex = 11;
            // 
            // lblSupplier
            // 
            this.lblSupplier.Location = new System.Drawing.Point(12, 63);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(38, 13);
            this.lblSupplier.TabIndex = 10;
            this.lblSupplier.Text = "Supplier";
            // 
            // txtTransactionDate
            // 
            this.txtTransactionDate.Location = new System.Drawing.Point(140, 27);
            this.txtTransactionDate.Name = "txtTransactionDate";
            this.txtTransactionDate.Properties.ReadOnly = true;
            this.txtTransactionDate.Size = new System.Drawing.Size(115, 20);
            this.txtTransactionDate.TabIndex = 9;
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.Location = new System.Drawing.Point(12, 30);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(86, 13);
            this.lblTransactionDate.TabIndex = 8;
            this.lblTransactionDate.Text = "Tanggal Transaksi";
            // 
            // PurchaseReturnEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 330);
            this.Controls.Add(this.gcPurchaseReturnInfo);
            this.Name = "PurchaseReturnEditorForm";
            this.Text = "Form Retur Pembelian";
            this.Load += new System.EventHandler(this.PurchaseReturnEditorForm_Load);
            this.Controls.SetChildIndex(this.gcPurchaseReturnInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcPurchaseReturnInfo)).EndInit();
            this.gcPurchaseReturnInfo.ResumeLayout(false);
            this.gcPurchaseReturnInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransactionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSparepart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcPurchaseReturnInfo;
        private DevExpress.XtraEditors.TextEdit txtSupplier;
        private DevExpress.XtraEditors.LabelControl lblSupplier;
        private DevExpress.XtraEditors.TextEdit txtTransactionDate;
        private DevExpress.XtraEditors.LabelControl lblTransactionDate;
        private DevExpress.XtraGrid.GridControl gridSparepart;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSparepart;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartName;
        private DevExpress.XtraGrid.Columns.GridColumn colReturQty;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bsSparepart;
    }
}