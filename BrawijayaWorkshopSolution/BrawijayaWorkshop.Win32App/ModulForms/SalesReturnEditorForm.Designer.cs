namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class SalesReturnEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReturnEditorForm));
            this.gcSalesReturnInfo = new DevExpress.XtraEditors.GroupControl();
            this.gridSparepart = new DevExpress.XtraGrid.GridControl();
            this.gvSparepart = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSparepartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReturQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtCustomer = new DevExpress.XtraEditors.TextEdit();
            this.lblSupplier = new DevExpress.XtraEditors.LabelControl();
            this.txtTransactionDate = new DevExpress.XtraEditors.TextEdit();
            this.lblTransactionDate = new DevExpress.XtraEditors.LabelControl();
            this.bsSparepart = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcSalesReturnInfo)).BeginInit();
            this.gcSalesReturnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransactionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSparepart)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSalesReturnInfo
            // 
            this.gcSalesReturnInfo.Controls.Add(this.gridSparepart);
            this.gcSalesReturnInfo.Controls.Add(this.txtCustomer);
            this.gcSalesReturnInfo.Controls.Add(this.lblSupplier);
            this.gcSalesReturnInfo.Controls.Add(this.txtTransactionDate);
            this.gcSalesReturnInfo.Controls.Add(this.lblTransactionDate);
            this.gcSalesReturnInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSalesReturnInfo.Location = new System.Drawing.Point(0, 0);
            this.gcSalesReturnInfo.Name = "gcSalesReturnInfo";
            this.gcSalesReturnInfo.Size = new System.Drawing.Size(577, 281);
            this.gcSalesReturnInfo.TabIndex = 2;
            this.gcSalesReturnInfo.Text = "Informasi Retur Penjualan";
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
            this.colReturQty.Caption = "Jumlah Retur";
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
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(140, 60);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Properties.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(208, 20);
            this.txtCustomer.TabIndex = 11;
            // 
            // lblSupplier
            // 
            this.lblSupplier.Location = new System.Drawing.Point(12, 63);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(46, 13);
            this.lblSupplier.TabIndex = 10;
            this.lblSupplier.Text = "Customer";
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
            this.lblTransactionDate.Size = new System.Drawing.Size(68, 13);
            this.lblTransactionDate.TabIndex = 8;
            this.lblTransactionDate.Text = "Tanggal Retur";
            // 
            // SalesReturnEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 330);
            this.Controls.Add(this.gcSalesReturnInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesReturnEditorForm";
            this.Text = "Form Retur Penjualan";
            this.Controls.SetChildIndex(this.gcSalesReturnInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcSalesReturnInfo)).EndInit();
            this.gcSalesReturnInfo.ResumeLayout(false);
            this.gcSalesReturnInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransactionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSparepart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcSalesReturnInfo;
        private DevExpress.XtraGrid.GridControl gridSparepart;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSparepart;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartName;
        private DevExpress.XtraGrid.Columns.GridColumn colReturQty;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtCustomer;
        private DevExpress.XtraEditors.LabelControl lblSupplier;
        private DevExpress.XtraEditors.TextEdit txtTransactionDate;
        private DevExpress.XtraEditors.LabelControl lblTransactionDate;
        private System.Windows.Forms.BindingSource bsSparepart;

    }
}