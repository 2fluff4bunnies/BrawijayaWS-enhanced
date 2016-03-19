namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class BalanceJournalListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BalanceJournalListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lookupYear = new DevExpress.XtraEditors.LookUpEdit();
            this.lblFilterYear = new DevExpress.XtraEditors.LabelControl();
            this.lookupMonth = new DevExpress.XtraEditors.LookUpEdit();
            this.lblFilterMonth = new DevExpress.XtraEditors.LabelControl();
            this.btnRecalculateBalanceJournal = new DevExpress.XtraEditors.SimpleButton();
            this.gridBalanceJournal = new DevExpress.XtraGrid.GridControl();
            this.gvBalanceJournal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colJournalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJournalName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstBalanceDebit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstBalanceCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMutationDebit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMutationCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReconcilDebit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReconcilCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfitLossDebit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfitLossCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastDebiit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.bgwRecalculate = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBalanceJournal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBalanceJournal)).BeginInit();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.lookupYear);
            this.gcFilter.Controls.Add(this.lblFilterYear);
            this.gcFilter.Controls.Add(this.lookupMonth);
            this.gcFilter.Controls.Add(this.lblFilterMonth);
            this.gcFilter.Location = new System.Drawing.Point(0, 0);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(1244, 66);
            this.gcFilter.TabIndex = 1;
            this.gcFilter.Text = "Filter";
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
            // btnRecalculateBalanceJournal
            // 
            this.btnRecalculateBalanceJournal.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.calculator_16x16;
            this.btnRecalculateBalanceJournal.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnRecalculateBalanceJournal.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnRecalculateBalanceJournal.Location = new System.Drawing.Point(3, 72);
            this.btnRecalculateBalanceJournal.Name = "btnRecalculateBalanceJournal";
            this.btnRecalculateBalanceJournal.Size = new System.Drawing.Size(113, 29);
            this.btnRecalculateBalanceJournal.TabIndex = 2;
            this.btnRecalculateBalanceJournal.Text = "Hitung Neraca";
            // 
            // gridBalanceJournal
            // 
            this.gridBalanceJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBalanceJournal.Location = new System.Drawing.Point(3, 107);
            this.gridBalanceJournal.MainView = this.gvBalanceJournal;
            this.gridBalanceJournal.Name = "gridBalanceJournal";
            this.gridBalanceJournal.Size = new System.Drawing.Size(1238, 235);
            this.gridBalanceJournal.TabIndex = 7;
            this.gridBalanceJournal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBalanceJournal});
            // 
            // gvBalanceJournal
            // 
            this.gvBalanceJournal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colJournalCode,
            this.colJournalName,
            this.colFirstBalanceDebit,
            this.colFirstBalanceCredit,
            this.colMutationDebit,
            this.colMutationCredit,
            this.colReconcilDebit,
            this.colReconcilCredit,
            this.colProfitLossDebit,
            this.colProfitLossCredit,
            this.colLastDebiit,
            this.colLastCredit});
            this.gvBalanceJournal.GridControl = this.gridBalanceJournal;
            this.gvBalanceJournal.Name = "gvBalanceJournal";
            this.gvBalanceJournal.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvBalanceJournal.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvBalanceJournal.OptionsBehavior.AutoPopulateColumns = false;
            this.gvBalanceJournal.OptionsBehavior.Editable = false;
            this.gvBalanceJournal.OptionsBehavior.ReadOnly = true;
            this.gvBalanceJournal.OptionsCustomization.AllowColumnMoving = false;
            this.gvBalanceJournal.OptionsCustomization.AllowFilter = false;
            this.gvBalanceJournal.OptionsCustomization.AllowGroup = false;
            this.gvBalanceJournal.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvBalanceJournal.OptionsView.EnableAppearanceEvenRow = true;
            this.gvBalanceJournal.OptionsView.ShowFooter = true;
            this.gvBalanceJournal.OptionsView.ShowGroupPanel = false;
            this.gvBalanceJournal.OptionsView.ShowViewCaption = true;
            this.gvBalanceJournal.ViewCaption = "Neraca";
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
            // colFirstBalanceDebit
            // 
            this.colFirstBalanceDebit.Caption = "Saldo Debet";
            this.colFirstBalanceDebit.DisplayFormat.FormatString = "{0:#,#}";
            this.colFirstBalanceDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFirstBalanceDebit.FieldName = "FirstDebit";
            this.colFirstBalanceDebit.Name = "colFirstBalanceDebit";
            this.colFirstBalanceDebit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FirstDebit", "{0:#,#}")});
            this.colFirstBalanceDebit.Visible = true;
            this.colFirstBalanceDebit.VisibleIndex = 2;
            // 
            // colFirstBalanceCredit
            // 
            this.colFirstBalanceCredit.Caption = "Saldo Kredit";
            this.colFirstBalanceCredit.DisplayFormat.FormatString = "{0:#,#}";
            this.colFirstBalanceCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFirstBalanceCredit.FieldName = "FirstCredit";
            this.colFirstBalanceCredit.Name = "colFirstBalanceCredit";
            this.colFirstBalanceCredit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FirstCredit", "{0:#,#}")});
            this.colFirstBalanceCredit.Visible = true;
            this.colFirstBalanceCredit.VisibleIndex = 3;
            // 
            // colMutationDebit
            // 
            this.colMutationDebit.Caption = "Mutasi Debet";
            this.colMutationDebit.DisplayFormat.FormatString = "{0:#,#}";
            this.colMutationDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMutationDebit.FieldName = "MutationDebit";
            this.colMutationDebit.Name = "colMutationDebit";
            this.colMutationDebit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MutationDebit", "{0:#,#}")});
            this.colMutationDebit.Visible = true;
            this.colMutationDebit.VisibleIndex = 4;
            // 
            // colMutationCredit
            // 
            this.colMutationCredit.Caption = "Mutasi Kredit";
            this.colMutationCredit.DisplayFormat.FormatString = "{0:#,#}";
            this.colMutationCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMutationCredit.FieldName = "MutationCredit";
            this.colMutationCredit.Name = "colMutationCredit";
            this.colMutationCredit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MutationCredit", "{0:#,#}")});
            this.colMutationCredit.Visible = true;
            this.colMutationCredit.VisibleIndex = 5;
            // 
            // colReconcilDebit
            // 
            this.colReconcilDebit.Caption = "Penyesuaian Debet";
            this.colReconcilDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colReconcilDebit.FieldName = "ReconciliationDebit";
            this.colReconcilDebit.Name = "colReconcilDebit";
            this.colReconcilDebit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ReconciliationDebit", "{0:#,#}")});
            this.colReconcilDebit.Visible = true;
            this.colReconcilDebit.VisibleIndex = 6;
            // 
            // colReconcilCredit
            // 
            this.colReconcilCredit.Caption = "Penyesuaian Kredit";
            this.colReconcilCredit.DisplayFormat.FormatString = "{0:#,#}";
            this.colReconcilCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colReconcilCredit.FieldName = "ReconciliationCredit";
            this.colReconcilCredit.Name = "colReconcilCredit";
            this.colReconcilCredit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ReconciliationCredit", "{0:#,#}")});
            this.colReconcilCredit.Visible = true;
            this.colReconcilCredit.VisibleIndex = 7;
            // 
            // colProfitLossDebit
            // 
            this.colProfitLossDebit.Caption = "Rugi/Laba Debet";
            this.colProfitLossDebit.DisplayFormat.FormatString = "{0:#,#}";
            this.colProfitLossDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colProfitLossDebit.FieldName = "ProfitLossDebit";
            this.colProfitLossDebit.Name = "colProfitLossDebit";
            this.colProfitLossDebit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ProfitLossDebit", "{0:#,#}")});
            this.colProfitLossDebit.Visible = true;
            this.colProfitLossDebit.VisibleIndex = 8;
            // 
            // colProfitLossCredit
            // 
            this.colProfitLossCredit.Caption = "Rugi/Laba Kredit";
            this.colProfitLossCredit.DisplayFormat.FormatString = "{0:#,#}";
            this.colProfitLossCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colProfitLossCredit.FieldName = "ProfitLossCredit";
            this.colProfitLossCredit.Name = "colProfitLossCredit";
            this.colProfitLossCredit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ProfitLossCredit", "{0:#,#}")});
            this.colProfitLossCredit.Visible = true;
            this.colProfitLossCredit.VisibleIndex = 9;
            // 
            // colLastDebiit
            // 
            this.colLastDebiit.Caption = "Saldo Akhir Debet";
            this.colLastDebiit.DisplayFormat.FormatString = "{0:#,#}";
            this.colLastDebiit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLastDebiit.FieldName = "LastDebit";
            this.colLastDebiit.Name = "colLastDebiit";
            this.colLastDebiit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LastDebit", "{0:#,#}")});
            this.colLastDebiit.Visible = true;
            this.colLastDebiit.VisibleIndex = 11;
            // 
            // colLastCredit
            // 
            this.colLastCredit.Caption = "Saldo Akhir Kredit";
            this.colLastCredit.DisplayFormat.FormatString = "{0:#,#}";
            this.colLastCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLastCredit.FieldName = "LastCredit";
            this.colLastCredit.Name = "colLastCredit";
            this.colLastCredit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LastCredit", "{0:#,#}")});
            this.colLastCredit.Visible = true;
            this.colLastCredit.VisibleIndex = 10;
            // 
            // BalanceJournalListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridBalanceJournal);
            this.Controls.Add(this.btnRecalculateBalanceJournal);
            this.Controls.Add(this.gcFilter);
            this.Name = "BalanceJournalListControl";
            this.Size = new System.Drawing.Size(1244, 348);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBalanceJournal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBalanceJournal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LookUpEdit lookupYear;
        private DevExpress.XtraEditors.LabelControl lblFilterYear;
        private DevExpress.XtraEditors.LookUpEdit lookupMonth;
        private DevExpress.XtraEditors.LabelControl lblFilterMonth;
        private DevExpress.XtraEditors.SimpleButton btnRecalculateBalanceJournal;
        private DevExpress.XtraGrid.GridControl gridBalanceJournal;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBalanceJournal;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalName;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstBalanceDebit;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstBalanceCredit;
        private DevExpress.XtraGrid.Columns.GridColumn colMutationDebit;
        private DevExpress.XtraGrid.Columns.GridColumn colMutationCredit;
        private DevExpress.XtraGrid.Columns.GridColumn colReconcilDebit;
        private DevExpress.XtraGrid.Columns.GridColumn colReconcilCredit;
        private DevExpress.XtraGrid.Columns.GridColumn colProfitLossDebit;
        private DevExpress.XtraGrid.Columns.GridColumn colProfitLossCredit;
        private DevExpress.XtraGrid.Columns.GridColumn colLastDebiit;
        private DevExpress.XtraGrid.Columns.GridColumn colLastCredit;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.ComponentModel.BackgroundWorker bgwRecalculate;
    }
}
