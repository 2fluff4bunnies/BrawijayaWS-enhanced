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
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupSparepart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStockCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockCard)).BeginInit();
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
            this.gcFilter.Size = new System.Drawing.Size(932, 82);
            this.gcFilter.TabIndex = 0;
            this.gcFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(854, 37);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 28);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lookupSparepart
            // 
            this.lookupSparepart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookupSparepart.Location = new System.Drawing.Point(472, 39);
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
            this.lookupSparepart.Size = new System.Drawing.Size(360, 22);
            this.lookupSparepart.TabIndex = 5;
            // 
            // lblSparepartFilter
            // 
            this.lblSparepartFilter.Location = new System.Drawing.Point(395, 43);
            this.lblSparepartFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSparepartFilter.Name = "lblSparepartFilter";
            this.lblSparepartFilter.Size = new System.Drawing.Size(57, 16);
            this.lblSparepartFilter.TabIndex = 4;
            this.lblSparepartFilter.Text = "Sparepart";
            // 
            // deTo
            // 
            this.deTo.EditValue = null;
            this.deTo.Location = new System.Drawing.Point(230, 39);
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
            this.deTo.Size = new System.Drawing.Size(122, 22);
            this.deTo.TabIndex = 3;
            // 
            // lblDateTo
            // 
            this.lblDateTo.Location = new System.Drawing.Point(195, 43);
            this.lblDateTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(18, 16);
            this.lblDateTo.TabIndex = 2;
            this.lblDateTo.Text = "s/d";
            // 
            // deFrom
            // 
            this.deFrom.EditValue = null;
            this.deFrom.Location = new System.Drawing.Point(57, 39);
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
            this.deFrom.Size = new System.Drawing.Size(122, 22);
            this.deFrom.TabIndex = 1;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.Location = new System.Drawing.Point(15, 43);
            this.lblDateFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(23, 16);
            this.lblDateFrom.TabIndex = 0;
            this.lblDateFrom.Text = "Dari";
            // 
            // gcStockCard
            // 
            this.gcStockCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcStockCard.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcStockCard.Location = new System.Drawing.Point(3, 130);
            this.gcStockCard.MainView = this.gvStockCard;
            this.gcStockCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcStockCard.Name = "gcStockCard";
            this.gcStockCard.Size = new System.Drawing.Size(932, 352);
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
            this.colQtyIn,
            this.colQtyOut,
            this.colQtyLast});
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
            this.colQtyIn.Visible = true;
            this.colQtyIn.VisibleIndex = 4;
            // 
            // colQtyOut
            // 
            this.colQtyOut.Caption = "Keluar";
            this.colQtyOut.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colQtyOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQtyOut.FieldName = "TotalQtyOut";
            this.colQtyOut.Name = "colQtyOut";
            this.colQtyOut.Visible = true;
            this.colQtyOut.VisibleIndex = 5;
            // 
            // colQtyLast
            // 
            this.colQtyLast.Caption = "Saldo Akhir";
            this.colQtyLast.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colQtyLast.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQtyLast.FieldName = "TotalQtyLast";
            this.colQtyLast.Name = "colQtyLast";
            this.colQtyLast.Visible = true;
            this.colQtyLast.VisibleIndex = 6;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.print_16x16;
            this.btnPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnPrint.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnPrint.Location = new System.Drawing.Point(3, 91);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(115, 34);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.export_16x16;
            this.btnExport.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnExport.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExport.Location = new System.Drawing.Point(140, 91);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(115, 34);
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
            // SparepartStockCardListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gcStockCard);
            this.Controls.Add(this.gcFilter);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SparepartStockCardListControl";
            this.Size = new System.Drawing.Size(938, 486);
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
    }
}
