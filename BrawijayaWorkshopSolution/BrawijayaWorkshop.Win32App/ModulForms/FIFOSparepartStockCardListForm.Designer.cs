namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class FIFOSparepartStockCardListForm
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
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.gcFIFOSparepart = new DevExpress.XtraGrid.GridControl();
            this.gvFIFOSparepart = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFIFODate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIFOPricePerItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIFOQtyFirst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIFOQtyIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIFOQtyOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIFOQtyLast = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.exportFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gcFIFOSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFIFOSparepart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.export_16x16;
            this.btnExport.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnExport.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExport.Location = new System.Drawing.Point(149, 11);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(115, 34);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.print_16x16;
            this.btnPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnPrint.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnPrint.Location = new System.Drawing.Point(12, 11);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(115, 34);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gcFIFOSparepart
            // 
            this.gcFIFOSparepart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFIFOSparepart.Location = new System.Drawing.Point(12, 50);
            this.gcFIFOSparepart.MainView = this.gvFIFOSparepart;
            this.gcFIFOSparepart.Name = "gcFIFOSparepart";
            this.gcFIFOSparepart.Size = new System.Drawing.Size(1075, 469);
            this.gcFIFOSparepart.TabIndex = 6;
            this.gcFIFOSparepart.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFIFOSparepart});
            // 
            // gvFIFOSparepart
            // 
            this.gvFIFOSparepart.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFIFODate,
            this.colFIFOPricePerItem,
            this.colFIFOQtyFirst,
            this.colFIFOQtyIn,
            this.colFIFOQtyOut,
            this.colFIFOQtyLast});
            this.gvFIFOSparepart.GridControl = this.gcFIFOSparepart;
            this.gvFIFOSparepart.Name = "gvFIFOSparepart";
            this.gvFIFOSparepart.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvFIFOSparepart.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvFIFOSparepart.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gvFIFOSparepart.OptionsBehavior.AutoPopulateColumns = false;
            this.gvFIFOSparepart.OptionsBehavior.Editable = false;
            this.gvFIFOSparepart.OptionsBehavior.ReadOnly = true;
            this.gvFIFOSparepart.OptionsCustomization.AllowColumnMoving = false;
            this.gvFIFOSparepart.OptionsCustomization.AllowGroup = false;
            this.gvFIFOSparepart.OptionsView.EnableAppearanceEvenRow = true;
            this.gvFIFOSparepart.OptionsView.ShowFooter = true;
            this.gvFIFOSparepart.OptionsView.ShowGroupPanel = false;
            this.gvFIFOSparepart.OptionsView.ShowViewCaption = true;
            this.gvFIFOSparepart.ViewCaption = "Daftar FIFO";
            // 
            // colFIFODate
            // 
            this.colFIFODate.Caption = "Tanggal";
            this.colFIFODate.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colFIFODate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFIFODate.FieldName = "LastPurchaseDate";
            this.colFIFODate.Name = "colFIFODate";
            this.colFIFODate.Visible = true;
            this.colFIFODate.VisibleIndex = 0;
            // 
            // colFIFOPricePerItem
            // 
            this.colFIFOPricePerItem.Caption = "Harga Satuan";
            this.colFIFOPricePerItem.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colFIFOPricePerItem.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFIFOPricePerItem.FieldName = "PricePerItem";
            this.colFIFOPricePerItem.Name = "colFIFOPricePerItem";
            this.colFIFOPricePerItem.Visible = true;
            this.colFIFOPricePerItem.VisibleIndex = 1;
            // 
            // colFIFOQtyFirst
            // 
            this.colFIFOQtyFirst.Caption = "Saldo Awal";
            this.colFIFOQtyFirst.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colFIFOQtyFirst.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFIFOQtyFirst.FieldName = "TotalQtyFirst";
            this.colFIFOQtyFirst.Name = "colFIFOQtyFirst";
            this.colFIFOQtyFirst.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalQtyFirst", "{0:#,#;(#,#);0}")});
            this.colFIFOQtyFirst.Visible = true;
            this.colFIFOQtyFirst.VisibleIndex = 2;
            // 
            // colFIFOQtyIn
            // 
            this.colFIFOQtyIn.Caption = "Masuk";
            this.colFIFOQtyIn.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colFIFOQtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFIFOQtyIn.FieldName = "TotalQtyIn";
            this.colFIFOQtyIn.Name = "colFIFOQtyIn";
            this.colFIFOQtyIn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalQtyIn", "{0:#,#;(#,#);0}")});
            this.colFIFOQtyIn.Visible = true;
            this.colFIFOQtyIn.VisibleIndex = 3;
            // 
            // colFIFOQtyOut
            // 
            this.colFIFOQtyOut.Caption = "Keluar";
            this.colFIFOQtyOut.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colFIFOQtyOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFIFOQtyOut.FieldName = "TotalQtyOut";
            this.colFIFOQtyOut.Name = "colFIFOQtyOut";
            this.colFIFOQtyOut.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalQtyOut", "{0:#,#;(#,#);0}")});
            this.colFIFOQtyOut.Visible = true;
            this.colFIFOQtyOut.VisibleIndex = 4;
            // 
            // colFIFOQtyLast
            // 
            this.colFIFOQtyLast.Caption = "Saldo Akhir";
            this.colFIFOQtyLast.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colFIFOQtyLast.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFIFOQtyLast.FieldName = "TotalQtyLast";
            this.colFIFOQtyLast.Name = "colFIFOQtyLast";
            this.colFIFOQtyLast.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalQtyLast", "{0:#,#;(#,#);0}")});
            this.colFIFOQtyLast.Visible = true;
            this.colFIFOQtyLast.VisibleIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(512, 538);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 29);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Tutup";
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // exportFileDialog
            // 
            this.exportFileDialog.DefaultExt = "xlsx";
            this.exportFileDialog.Filter = "Excel File (*.xlsx)|*xlsx";
            this.exportFileDialog.Title = "Export Fifo Sparepart Stock Data";
            // 
            // FIFOSparepartStockCardListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1099, 579);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gcFIFOSparepart);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPrint);
            this.Name = "FIFOSparepartStockCardListForm";
            this.ShowInTaskbar = false;
            this.Text = "FIFO Sparepart: {0}";
            ((System.ComponentModel.ISupportInitialize)(this.gcFIFOSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFIFOSparepart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.GridControl gcFIFOSparepart;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFIFOSparepart;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private DevExpress.XtraGrid.Columns.GridColumn colFIFODate;
        private DevExpress.XtraGrid.Columns.GridColumn colFIFOPricePerItem;
        private DevExpress.XtraGrid.Columns.GridColumn colFIFOQtyFirst;
        private DevExpress.XtraGrid.Columns.GridColumn colFIFOQtyIn;
        private DevExpress.XtraGrid.Columns.GridColumn colFIFOQtyOut;
        private DevExpress.XtraGrid.Columns.GridColumn colFIFOQtyLast;
        private System.Windows.Forms.SaveFileDialog exportFileDialog;
    }
}