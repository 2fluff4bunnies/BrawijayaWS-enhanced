namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class SparepartStockCardListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SparepartStockCardListControl));
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lookupSparepart = new DevExpress.XtraEditors.LookUpEdit();
            this.lblSparepartFilter = new DevExpress.XtraEditors.LabelControl();
            this.deTo = new DevExpress.XtraEditors.DateEdit();
            this.lblDateTo = new DevExpress.XtraEditors.LabelControl();
            this.deFrom = new DevExpress.XtraEditors.DateEdit();
            this.lblDateFrom = new DevExpress.XtraEditors.LabelControl();
            this.gcStockCard = new DevExpress.XtraGrid.GridControl();
            this.gvStockCard = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSparepartCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepartUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyFirst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyLast = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.bgwInit = new System.ComponentModel.BackgroundWorker();
            this.exportFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsLoadFifoData = new System.Windows.Forms.ToolStripMenuItem();
            this.colQtyFirstPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyInPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyOutPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyLastPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupSparepart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStockCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockCard)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.lookupSparepart);
            this.gcFilter.Controls.Add(this.lblSparepartFilter);
            this.gcFilter.Controls.Add(this.deTo);
            this.gcFilter.Controls.Add(this.lblDateTo);
            this.gcFilter.Controls.Add(this.deFrom);
            this.gcFilter.Controls.Add(this.lblDateFrom);
            this.gcFilter.Location = new System.Drawing.Point(3, 2);
            this.gcFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(799, 67);
            this.gcFilter.TabIndex = 0;
            this.gcFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(732, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lookupSparepart
            // 
            this.lookupSparepart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookupSparepart.Location = new System.Drawing.Point(405, 32);
            this.lookupSparepart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lookupSparepart.Name = "lookupSparepart";
            this.lookupSparepart.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookupSparepart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupSparepart.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Kode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Nama")});
            this.lookupSparepart.Properties.DisplayMember = "Name";
            this.lookupSparepart.Properties.HideSelection = false;
            this.lookupSparepart.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookupSparepart.Properties.NullText = "-- Pilih Sparepart --";
            this.lookupSparepart.Properties.ValueMember = "Id";
            this.lookupSparepart.Size = new System.Drawing.Size(309, 20);
            this.lookupSparepart.TabIndex = 5;
            // 
            // lblSparepartFilter
            // 
            this.lblSparepartFilter.Location = new System.Drawing.Point(339, 35);
            this.lblSparepartFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSparepartFilter.Name = "lblSparepartFilter";
            this.lblSparepartFilter.Size = new System.Drawing.Size(48, 13);
            this.lblSparepartFilter.TabIndex = 4;
            this.lblSparepartFilter.Text = "Sparepart";
            // 
            // deTo
            // 
            this.deTo.EditValue = null;
            this.deTo.Location = new System.Drawing.Point(197, 32);
            this.deTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deTo.Name = "deTo";
            this.deTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTo.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.deTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deTo.Properties.HideSelection = false;
            this.deTo.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.deTo.Size = new System.Drawing.Size(105, 20);
            this.deTo.TabIndex = 3;
            // 
            // lblDateTo
            // 
            this.lblDateTo.Location = new System.Drawing.Point(167, 35);
            this.lblDateTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(15, 13);
            this.lblDateTo.TabIndex = 2;
            this.lblDateTo.Text = "s/d";
            // 
            // deFrom
            // 
            this.deFrom.EditValue = null;
            this.deFrom.Location = new System.Drawing.Point(49, 32);
            this.deFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deFrom.Name = "deFrom";
            this.deFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFrom.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.deFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deFrom.Properties.HideSelection = false;
            this.deFrom.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.deFrom.Size = new System.Drawing.Size(105, 20);
            this.deFrom.TabIndex = 1;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.Location = new System.Drawing.Point(13, 35);
            this.lblDateFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(19, 13);
            this.lblDateFrom.TabIndex = 0;
            this.lblDateFrom.Text = "Dari";
            // 
            // gcStockCard
            // 
            this.gcStockCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcStockCard.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcStockCard.Location = new System.Drawing.Point(3, 106);
            this.gcStockCard.MainView = this.gvStockCard;
            this.gcStockCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcStockCard.Name = "gcStockCard";
            this.gcStockCard.Size = new System.Drawing.Size(799, 286);
            this.gcStockCard.TabIndex = 1;
            this.gcStockCard.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStockCard});
            // 
            // gvStockCard
            // 
            this.gvStockCard.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSparepartCode,
            this.colSparepartName,
            this.colSparepartUnit,
            this.colQtyFirst,
            this.colQtyFirstPrice,
            this.colQtyIn,
            this.colQtyInPrice,
            this.colQtyOut,
            this.colQtyOutPrice,
            this.colQtyLast,
            this.colQtyLastPrice});
            this.gvStockCard.GridControl = this.gcStockCard;
            this.gvStockCard.Name = "gvStockCard";
            this.gvStockCard.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvStockCard.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvStockCard.OptionsBehavior.AutoPopulateColumns = false;
            this.gvStockCard.OptionsBehavior.Editable = false;
            this.gvStockCard.OptionsCustomization.AllowColumnMoving = false;
            this.gvStockCard.OptionsCustomization.AllowGroup = false;
            this.gvStockCard.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvStockCard.OptionsView.EnableAppearanceEvenRow = true;
            this.gvStockCard.OptionsView.ShowFooter = true;
            this.gvStockCard.OptionsView.ShowGroupPanel = false;
            // 
            // colSparepartCode
            // 
            this.colSparepartCode.Caption = "Kode";
            this.colSparepartCode.FieldName = "Sparepart.Code";
            this.colSparepartCode.Name = "colSparepartCode";
            this.colSparepartCode.Visible = true;
            this.colSparepartCode.VisibleIndex = 0;
            // 
            // colSparepartName
            // 
            this.colSparepartName.Caption = "Nama";
            this.colSparepartName.FieldName = "Sparepart.Name";
            this.colSparepartName.Name = "colSparepartName";
            this.colSparepartName.Visible = true;
            this.colSparepartName.VisibleIndex = 1;
            // 
            // colSparepartUnit
            // 
            this.colSparepartUnit.Caption = "Satuan";
            this.colSparepartUnit.FieldName = "Sparepart.UnitReference.Value";
            this.colSparepartUnit.Name = "colSparepartUnit";
            this.colSparepartUnit.Visible = true;
            this.colSparepartUnit.VisibleIndex = 2;
            // 
            // colQtyFirst
            // 
            this.colQtyFirst.Caption = "Saldo Awal";
            this.colQtyFirst.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colQtyFirst.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQtyFirst.FieldName = "TotalQtyFirst";
            this.colQtyFirst.Name = "colQtyFirst";
            this.colQtyFirst.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalQtyFirst", "{0:#,#;(#,#);0}")});
            this.colQtyFirst.Visible = true;
            this.colQtyFirst.VisibleIndex = 3;
            // 
            // colQtyIn
            // 
            this.colQtyIn.Caption = "Masuk";
            this.colQtyIn.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colQtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQtyIn.FieldName = "TotalQtyIn";
            this.colQtyIn.Name = "colQtyIn";
            this.colQtyIn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalQtyIn", "{0:#,#;(#,#);0}")});
            this.colQtyIn.Visible = true;
            this.colQtyIn.VisibleIndex = 5;
            // 
            // colQtyOut
            // 
            this.colQtyOut.Caption = "Keluar";
            this.colQtyOut.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colQtyOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQtyOut.FieldName = "TotalQtyOut";
            this.colQtyOut.Name = "colQtyOut";
            this.colQtyOut.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalQtyOut", "{0:#,#;(#,#);0}")});
            this.colQtyOut.Visible = true;
            this.colQtyOut.VisibleIndex = 7;
            // 
            // colQtyLast
            // 
            this.colQtyLast.Caption = "Saldo Akhir";
            this.colQtyLast.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colQtyLast.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQtyLast.FieldName = "TotalQtyLast";
            this.colQtyLast.Name = "colQtyLast";
            this.colQtyLast.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalQtyLast", "{0:#,#;(#,#);0}")});
            this.colQtyLast.Visible = true;
            this.colQtyLast.VisibleIndex = 9;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.print_16x16;
            this.btnPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnPrint.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnPrint.Location = new System.Drawing.Point(3, 74);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(99, 28);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.export_16x16;
            this.btnExport.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnExport.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExport.Location = new System.Drawing.Point(120, 74);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(99, 28);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // bgwInit
            // 
            this.bgwInit.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwInit_DoWork);
            this.bgwInit.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwInit_RunWorkerCompleted);
            // 
            // exportFileDialog
            // 
            this.exportFileDialog.DefaultExt = "xlsx";
            this.exportFileDialog.Filter = "Excel File (*.xlsx)|*xlsx";
            this.exportFileDialog.Title = "Export Sparepart Stock Data";
            // 
            // cmsEditor
            // 
            this.cmsEditor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsLoadFifoData});
            this.cmsEditor.Name = "cmsListEditor";
            this.cmsEditor.Size = new System.Drawing.Size(132, 30);
            // 
            // cmsLoadFifoData
            // 
            this.cmsLoadFifoData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.cmsLoadFifoData.Name = "cmsLoadFifoData";
            this.cmsLoadFifoData.Size = new System.Drawing.Size(131, 26);
            this.cmsLoadFifoData.Text = "Lihat FIFO";
            this.cmsLoadFifoData.Click += new System.EventHandler(this.cmsLoadFifoData_Click);
            // 
            // colQtyFirstPrice
            // 
            this.colQtyFirstPrice.Caption = "Saldo Awal (Harga)";
            this.colQtyFirstPrice.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colQtyFirstPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQtyFirstPrice.FieldName = "TotalQtyFirstPrice";
            this.colQtyFirstPrice.Name = "colQtyFirstPrice";
            this.colQtyFirstPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalQtyFirstPrice", "{0:#,#;(#,#);0}")});
            this.colQtyFirstPrice.Visible = true;
            this.colQtyFirstPrice.VisibleIndex = 4;
            // 
            // colQtyInPrice
            // 
            this.colQtyInPrice.Caption = "Masuk (Harga)";
            this.colQtyInPrice.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colQtyInPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQtyInPrice.FieldName = "TotalQtyInPrice";
            this.colQtyInPrice.Name = "colQtyInPrice";
            this.colQtyInPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalQtyInPrice", "{0:#,#;(#,#);0}")});
            this.colQtyInPrice.Visible = true;
            this.colQtyInPrice.VisibleIndex = 6;
            // 
            // colQtyOutPrice
            // 
            this.colQtyOutPrice.Caption = "Keluar (Harga)";
            this.colQtyOutPrice.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colQtyOutPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQtyOutPrice.FieldName = "TotalQtyOutPrice";
            this.colQtyOutPrice.Name = "colQtyOutPrice";
            this.colQtyOutPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalQtyOutPrice", "{0:#,#;(#,#);0}")});
            this.colQtyOutPrice.Visible = true;
            this.colQtyOutPrice.VisibleIndex = 8;
            // 
            // colQtyLastPrice
            // 
            this.colQtyLastPrice.Caption = "Saldo Akhir (Harga)";
            this.colQtyLastPrice.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colQtyLastPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQtyLastPrice.FieldName = "TotalQtyLastPrice";
            this.colQtyLastPrice.Name = "colQtyLastPrice";
            this.colQtyLastPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalQtyLastPrice", "{0:#,#;(#,#);0}")});
            this.colQtyLastPrice.Visible = true;
            this.colQtyLastPrice.VisibleIndex = 10;
            // 
            // SparepartStockCardListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gcStockCard);
            this.Controls.Add(this.gcFilter);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SparepartStockCardListControl";
            this.Size = new System.Drawing.Size(804, 395);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupSparepart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStockCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockCard)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgwMain;
        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.LabelControl lblDateFrom;
        private DevExpress.XtraGrid.GridControl gcStockCard;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStockCard;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.LookUpEdit lookupSparepart;
        private DevExpress.XtraEditors.LabelControl lblSparepartFilter;
        private DevExpress.XtraEditors.DateEdit deTo;
        private DevExpress.XtraEditors.LabelControl lblDateTo;
        private DevExpress.XtraEditors.DateEdit deFrom;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.ComponentModel.BackgroundWorker bgwInit;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartName;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyFirst;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyIn;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyOut;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyLast;
        private System.Windows.Forms.SaveFileDialog exportFileDialog;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsLoadFifoData;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyFirstPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyInPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyOutPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyLastPrice;
    }
}
