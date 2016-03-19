namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class HPPListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HPPListControl));
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.bgwRecalculate = new System.ComponentModel.BackgroundWorker();
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.lblFilterYear = new DevExpress.XtraEditors.LabelControl();
            this.lookupMonth = new DevExpress.XtraEditors.LookUpEdit();
            this.lblFilterMonth = new DevExpress.XtraEditors.LabelControl();
            this.btnRecalculateHPP = new DevExpress.XtraEditors.SimpleButton();
            this.gridHPP = new DevExpress.XtraGrid.GridControl();
            this.gvHPP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colJournalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJournalName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServiceAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookupYear = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupYear.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // bgwRecalculate
            // 
            this.bgwRecalculate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwRecalculate_DoWork);
            this.bgwRecalculate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwRecalculate_RunWorkerCompleted);
            // 
            // gcFilter
            // 
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.lookupYear);
            this.gcFilter.Controls.Add(this.lblFilterYear);
            this.gcFilter.Controls.Add(this.lookupMonth);
            this.gcFilter.Controls.Add(this.lblFilterMonth);
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(828, 66);
            this.gcFilter.TabIndex = 0;
            this.gcFilter.Text = "Filter";
            // 
            // lblFilterYear
            // 
            this.lblFilterYear.Location = new System.Drawing.Point(196, 35);
            this.lblFilterYear.Name = "lblFilterYear";
            this.lblFilterYear.Size = new System.Drawing.Size(34, 13);
            this.lblFilterYear.TabIndex = 2;
            this.lblFilterYear.Text = "Tahun:";
            // 
            // lookupMonth
            // 
            this.lookupMonth.Location = new System.Drawing.Point(48, 32);
            this.lookupMonth.Name = "lookupMonth";
            this.lookupMonth.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookupMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupMonth.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Bulan")});
            this.lookupMonth.Properties.DisplayMember = "Value";
            this.lookupMonth.Properties.HideSelection = false;
            this.lookupMonth.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookupMonth.Properties.NullText = "-- Pilih Bulan --";
            this.lookupMonth.Properties.ValueMember = "Key";
            this.lookupMonth.Size = new System.Drawing.Size(128, 20);
            this.lookupMonth.TabIndex = 1;
            // 
            // lblFilterMonth
            // 
            this.lblFilterMonth.Location = new System.Drawing.Point(12, 35);
            this.lblFilterMonth.Name = "lblFilterMonth";
            this.lblFilterMonth.Size = new System.Drawing.Size(30, 13);
            this.lblFilterMonth.TabIndex = 0;
            this.lblFilterMonth.Text = "Bulan:";
            // 
            // btnRecalculateHPP
            // 
            this.btnRecalculateHPP.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.calculator_16x16;
            this.btnRecalculateHPP.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnRecalculateHPP.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnRecalculateHPP.Location = new System.Drawing.Point(3, 75);
            this.btnRecalculateHPP.Name = "btnRecalculateHPP";
            this.btnRecalculateHPP.Size = new System.Drawing.Size(96, 29);
            this.btnRecalculateHPP.TabIndex = 1;
            this.btnRecalculateHPP.Text = "Hitung HPP";
            this.btnRecalculateHPP.Click += new System.EventHandler(this.btnRecalculateHPP_Click);
            // 
            // gridHPP
            // 
            this.gridHPP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridHPP.Location = new System.Drawing.Point(3, 110);
            this.gridHPP.MainView = this.gvHPP;
            this.gridHPP.Name = "gridHPP";
            this.gridHPP.Size = new System.Drawing.Size(611, 235);
            this.gridHPP.TabIndex = 6;
            this.gridHPP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHPP});
            // 
            // gvHPP
            // 
            this.gvHPP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colJournalCode,
            this.colJournalName,
            this.colBaseAmount,
            this.colServiceAmount,
            this.colTotal});
            this.gvHPP.GridControl = this.gridHPP;
            this.gvHPP.Name = "gvHPP";
            this.gvHPP.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvHPP.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvHPP.OptionsBehavior.AutoPopulateColumns = false;
            this.gvHPP.OptionsBehavior.Editable = false;
            this.gvHPP.OptionsBehavior.ReadOnly = true;
            this.gvHPP.OptionsCustomization.AllowColumnMoving = false;
            this.gvHPP.OptionsCustomization.AllowFilter = false;
            this.gvHPP.OptionsCustomization.AllowGroup = false;
            this.gvHPP.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvHPP.OptionsView.EnableAppearanceEvenRow = true;
            this.gvHPP.OptionsView.ShowFooter = true;
            this.gvHPP.OptionsView.ShowGroupPanel = false;
            this.gvHPP.OptionsView.ShowViewCaption = true;
            this.gvHPP.ViewCaption = "Harga Pokok Penjualan";
            // 
            // colJournalCode
            // 
            this.colJournalCode.Caption = "Kode Akun";
            this.colJournalCode.FieldName = "Journal.Code";
            this.colJournalCode.Name = "colJournalCode";
            this.colJournalCode.Visible = true;
            this.colJournalCode.VisibleIndex = 0;
            // 
            // colJournalName
            // 
            this.colJournalName.Caption = "Nama";
            this.colJournalName.FieldName = "Journal.Name";
            this.colJournalName.Name = "colJournalName";
            this.colJournalName.Visible = true;
            this.colJournalName.VisibleIndex = 1;
            // 
            // colBaseAmount
            // 
            this.colBaseAmount.Caption = "Jumlah";
            this.colBaseAmount.DisplayFormat.FormatString = "{0:#,#}";
            this.colBaseAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBaseAmount.FieldName = "BaseAmount";
            this.colBaseAmount.Name = "colBaseAmount";
            this.colBaseAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BaseAmount", "{0:#,#}")});
            this.colBaseAmount.Visible = true;
            this.colBaseAmount.VisibleIndex = 2;
            // 
            // colServiceAmount
            // 
            this.colServiceAmount.Caption = "Jasa 10%";
            this.colServiceAmount.DisplayFormat.FormatString = "{0:#,#}";
            this.colServiceAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colServiceAmount.FieldName = "ServiceAmount";
            this.colServiceAmount.Name = "colServiceAmount";
            this.colServiceAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ServiceAmount", "{0:#,#}")});
            this.colServiceAmount.Visible = true;
            this.colServiceAmount.VisibleIndex = 3;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.DisplayFormat.FormatString = "{0:#,#}";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "TotalAmount";
            this.colTotal.Name = "colTotal";
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAmount", "{0:#,#}")});
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 4;
            // 
            // lookupYear
            // 
            this.lookupYear.Location = new System.Drawing.Point(236, 32);
            this.lookupYear.Name = "lookupYear";
            this.lookupYear.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookupYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupYear.Properties.HideSelection = false;
            this.lookupYear.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookupYear.Properties.NullText = "-- Pilih Tahun --";
            this.lookupYear.Size = new System.Drawing.Size(100, 20);
            this.lookupYear.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(342, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // HPPListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridHPP);
            this.Controls.Add(this.btnRecalculateHPP);
            this.Controls.Add(this.gcFilter);
            this.Name = "HPPListControl";
            this.Size = new System.Drawing.Size(617, 348);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupYear.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.ComponentModel.BackgroundWorker bgwRecalculate;
        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.LabelControl lblFilterYear;
        private DevExpress.XtraEditors.LookUpEdit lookupMonth;
        private DevExpress.XtraEditors.LabelControl lblFilterMonth;
        private DevExpress.XtraEditors.SimpleButton btnRecalculateHPP;
        private DevExpress.XtraGrid.GridControl gridHPP;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHPP;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalName;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraEditors.LookUpEdit lookupYear;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
    }
}
