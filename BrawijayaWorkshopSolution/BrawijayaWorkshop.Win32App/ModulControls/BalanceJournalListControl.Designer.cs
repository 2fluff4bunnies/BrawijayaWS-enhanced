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
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.bgwRecalculate = new System.ComponentModel.BackgroundWorker();
            this.gridBalanceJournal = new DevExpress.XtraGrid.GridControl();
            this.gvBalanceJournal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colJournalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJournalName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoCheckBox = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colFirstBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebitMutation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreditMutation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBalanceJournal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBalanceJournal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheckBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.lookupYear);
            this.gcFilter.Controls.Add(this.lblFilterYear);
            this.gcFilter.Controls.Add(this.lookupMonth);
            this.gcFilter.Controls.Add(this.lblFilterMonth);
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(814, 66);
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.lookupYear.Properties.ShowHeader = false;
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
            this.btnRecalculateBalanceJournal.Location = new System.Drawing.Point(3, 75);
            this.btnRecalculateBalanceJournal.Name = "btnRecalculateBalanceJournal";
            this.btnRecalculateBalanceJournal.Size = new System.Drawing.Size(113, 29);
            this.btnRecalculateBalanceJournal.TabIndex = 2;
            this.btnRecalculateBalanceJournal.Text = "Hitung Neraca";
            this.btnRecalculateBalanceJournal.Click += new System.EventHandler(this.btnRecalculateBalanceJournal_Click);
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
            // gridBalanceJournal
            // 
            this.gridBalanceJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBalanceJournal.Location = new System.Drawing.Point(3, 110);
            this.gridBalanceJournal.MainView = this.gvBalanceJournal;
            this.gridBalanceJournal.Name = "gridBalanceJournal";
            this.gridBalanceJournal.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoCheckBox});
            this.gridBalanceJournal.Size = new System.Drawing.Size(814, 262);
            this.gridBalanceJournal.TabIndex = 5;
            this.gridBalanceJournal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBalanceJournal});
            // 
            // gvBalanceJournal
            // 
            this.gvBalanceJournal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colJournalCode,
            this.colJournalName,
            this.colFirstBalance,
            this.colDebitMutation,
            this.colCreditMutation,
            this.colLastBalance});
            this.gvBalanceJournal.GridControl = this.gridBalanceJournal;
            this.gvBalanceJournal.Name = "gvBalanceJournal";
            this.gvBalanceJournal.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvBalanceJournal.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvBalanceJournal.OptionsBehavior.AutoPopulateColumns = false;
            this.gvBalanceJournal.OptionsBehavior.Editable = false;
            this.gvBalanceJournal.OptionsBehavior.ReadOnly = true;
            this.gvBalanceJournal.OptionsCustomization.AllowColumnMoving = false;
            this.gvBalanceJournal.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvBalanceJournal.OptionsView.EnableAppearanceEvenRow = true;
            this.gvBalanceJournal.OptionsView.ShowFooter = true;
            this.gvBalanceJournal.OptionsView.ShowGroupPanel = false;
            this.gvBalanceJournal.OptionsView.ShowViewCaption = true;
            this.gvBalanceJournal.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colJournalCode, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvBalanceJournal.ViewCaption = "Neraca Saldo";
            // 
            // colJournalCode
            // 
            this.colJournalCode.Caption = "Kode";
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
            // repoCheckBox
            // 
            this.repoCheckBox.AutoHeight = false;
            this.repoCheckBox.Name = "repoCheckBox";
            this.repoCheckBox.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colFirstBalance
            // 
            this.colFirstBalance.Caption = "Saldo Awal";
            this.colFirstBalance.DisplayFormat.FormatString = "{0:#,#;(#,#)}";
            this.colFirstBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFirstBalance.FieldName = "FirstBalance";
            this.colFirstBalance.Name = "colFirstBalance";
            this.colFirstBalance.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FirstBalance", "{0:#,#;(#,#)}")});
            this.colFirstBalance.Visible = true;
            this.colFirstBalance.VisibleIndex = 2;
            // 
            // colDebitMutation
            // 
            this.colDebitMutation.Caption = "Debet";
            this.colDebitMutation.DisplayFormat.FormatString = "{0:#,#}";
            this.colDebitMutation.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDebitMutation.FieldName = "BalanceAfterReconciliationDebit";
            this.colDebitMutation.Name = "colDebitMutation";
            this.colDebitMutation.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BalanceAfterReconciliationDebit", "{0:#,#}")});
            this.colDebitMutation.Visible = true;
            this.colDebitMutation.VisibleIndex = 3;
            // 
            // colCreditMutation
            // 
            this.colCreditMutation.Caption = "Kredit";
            this.colCreditMutation.DisplayFormat.FormatString = "{0:#,#}";
            this.colCreditMutation.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCreditMutation.FieldName = "BalanceAfterReconciliationCredit";
            this.colCreditMutation.Name = "colCreditMutation";
            this.colCreditMutation.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BalanceAfterReconciliationCredit", "{0:#,#}")});
            this.colCreditMutation.Visible = true;
            this.colCreditMutation.VisibleIndex = 4;
            // 
            // colLastBalance
            // 
            this.colLastBalance.Caption = "Saldo Akhir";
            this.colLastBalance.DisplayFormat.FormatString = "{0:#,#;(#,#)}";
            this.colLastBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLastBalance.FieldName = "LastBalance";
            this.colLastBalance.Name = "colLastBalance";
            this.colLastBalance.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LastBalance", "{0:#,#;(#,#)}")});
            this.colLastBalance.Visible = true;
            this.colLastBalance.VisibleIndex = 5;
            // 
            // BalanceJournalListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridBalanceJournal);
            this.Controls.Add(this.btnRecalculateBalanceJournal);
            this.Controls.Add(this.gcFilter);
            this.Name = "BalanceJournalListControl";
            this.Size = new System.Drawing.Size(820, 375);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBalanceJournal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBalanceJournal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheckBox)).EndInit();
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
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.ComponentModel.BackgroundWorker bgwRecalculate;
        private DevExpress.XtraGrid.GridControl gridBalanceJournal;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBalanceJournal;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalName;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repoCheckBox;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstBalance;
        private DevExpress.XtraGrid.Columns.GridColumn colDebitMutation;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditMutation;
        private DevExpress.XtraGrid.Columns.GridColumn colLastBalance;
    }
}
