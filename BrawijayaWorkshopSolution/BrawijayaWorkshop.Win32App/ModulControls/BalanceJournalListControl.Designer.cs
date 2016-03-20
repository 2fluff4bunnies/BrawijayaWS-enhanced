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
            this.gvBalanceJournal = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gbJournalCode = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colJournalCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colJournalName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gbFirstBalance = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFirstBalanceDebit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colFirstBalanceCredit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gbMutation = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colMutationDebit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMutationCredit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gbReconciliation = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colReconcilDebit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colReconcilCredit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gbProfitLoss = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colProfitLossDebit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProfitLossCredit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gbLastBalance = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colLastDebiit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colLastCredit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
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
            this.btnRecalculateBalanceJournal.Location = new System.Drawing.Point(3, 72);
            this.btnRecalculateBalanceJournal.Name = "btnRecalculateBalanceJournal";
            this.btnRecalculateBalanceJournal.Size = new System.Drawing.Size(113, 29);
            this.btnRecalculateBalanceJournal.TabIndex = 2;
            this.btnRecalculateBalanceJournal.Text = "Hitung Neraca";
            this.btnRecalculateBalanceJournal.Click += new System.EventHandler(this.btnRecalculateBalanceJournal_Click);
            // 
            // gridBalanceJournal
            // 
            this.gridBalanceJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBalanceJournal.Location = new System.Drawing.Point(3, 107);
            this.gridBalanceJournal.MainView = this.gvBalanceJournal;
            this.gridBalanceJournal.Name = "gridBalanceJournal";
            this.gridBalanceJournal.Size = new System.Drawing.Size(889, 238);
            this.gridBalanceJournal.TabIndex = 7;
            this.gridBalanceJournal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBalanceJournal});
            // 
            // gvBalanceJournal
            // 
            this.gvBalanceJournal.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gbJournalCode,
            this.gbFirstBalance,
            this.gbMutation,
            this.gbReconciliation,
            this.gbProfitLoss,
            this.gbLastBalance});
            this.gvBalanceJournal.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
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
            // gbJournalCode
            // 
            this.gbJournalCode.Columns.Add(this.colJournalCode);
            this.gbJournalCode.Columns.Add(this.colJournalName);
            this.gbJournalCode.Name = "gbJournalCode";
            this.gbJournalCode.OptionsBand.ShowCaption = false;
            this.gbJournalCode.OptionsBand.ShowInCustomizationForm = false;
            this.gbJournalCode.VisibleIndex = 0;
            this.gbJournalCode.Width = 150;
            // 
            // colJournalCode
            // 
            this.colJournalCode.AppearanceHeader.Options.UseTextOptions = true;
            this.colJournalCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colJournalCode.Caption = "Kode Akun";
            this.colJournalCode.FieldName = "Journal.Code";
            this.colJournalCode.MinWidth = 30;
            this.colJournalCode.Name = "colJournalCode";
            this.colJournalCode.Visible = true;
            // 
            // colJournalName
            // 
            this.colJournalName.AppearanceHeader.Options.UseTextOptions = true;
            this.colJournalName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colJournalName.Caption = "Nama";
            this.colJournalName.FieldName = "Journal.Name";
            this.colJournalName.Name = "colJournalName";
            this.colJournalName.Visible = true;
            // 
            // gbFirstBalance
            // 
            this.gbFirstBalance.AppearanceHeader.Options.UseTextOptions = true;
            this.gbFirstBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gbFirstBalance.Caption = "Saldo Awal";
            this.gbFirstBalance.Columns.Add(this.colFirstBalanceDebit);
            this.gbFirstBalance.Columns.Add(this.colFirstBalanceCredit);
            this.gbFirstBalance.Name = "gbFirstBalance";
            this.gbFirstBalance.OptionsBand.ShowInCustomizationForm = false;
            this.gbFirstBalance.VisibleIndex = 1;
            this.gbFirstBalance.Width = 150;
            // 
            // colFirstBalanceDebit
            // 
            this.colFirstBalanceDebit.AppearanceHeader.Options.UseTextOptions = true;
            this.colFirstBalanceDebit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFirstBalanceDebit.Caption = "Debet";
            this.colFirstBalanceDebit.DisplayFormat.FormatString = "{0:#,#}";
            this.colFirstBalanceDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFirstBalanceDebit.FieldName = "FirstDebit";
            this.colFirstBalanceDebit.Name = "colFirstBalanceDebit";
            this.colFirstBalanceDebit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FirstDebit", "{0:#,#}")});
            this.colFirstBalanceDebit.Visible = true;
            // 
            // colFirstBalanceCredit
            // 
            this.colFirstBalanceCredit.AppearanceHeader.Options.UseTextOptions = true;
            this.colFirstBalanceCredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFirstBalanceCredit.Caption = "Kredit";
            this.colFirstBalanceCredit.DisplayFormat.FormatString = "{0:#,#}";
            this.colFirstBalanceCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFirstBalanceCredit.FieldName = "FirstCredit";
            this.colFirstBalanceCredit.Name = "colFirstBalanceCredit";
            this.colFirstBalanceCredit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FirstCredit", "{0:#,#}")});
            this.colFirstBalanceCredit.Visible = true;
            // 
            // gbMutation
            // 
            this.gbMutation.AppearanceHeader.Options.UseTextOptions = true;
            this.gbMutation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gbMutation.Caption = "Mutasi";
            this.gbMutation.Columns.Add(this.colMutationDebit);
            this.gbMutation.Columns.Add(this.colMutationCredit);
            this.gbMutation.Name = "gbMutation";
            this.gbMutation.OptionsBand.ShowInCustomizationForm = false;
            this.gbMutation.VisibleIndex = 2;
            this.gbMutation.Width = 150;
            // 
            // colMutationDebit
            // 
            this.colMutationDebit.AppearanceHeader.Options.UseTextOptions = true;
            this.colMutationDebit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMutationDebit.Caption = "Debet";
            this.colMutationDebit.DisplayFormat.FormatString = "{0:#,#}";
            this.colMutationDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMutationDebit.FieldName = "MutationDebit";
            this.colMutationDebit.Name = "colMutationDebit";
            this.colMutationDebit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MutationDebit", "{0:#,#}")});
            this.colMutationDebit.Visible = true;
            // 
            // colMutationCredit
            // 
            this.colMutationCredit.AppearanceHeader.Options.UseTextOptions = true;
            this.colMutationCredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMutationCredit.Caption = "Kredit";
            this.colMutationCredit.DisplayFormat.FormatString = "{0:#,#}";
            this.colMutationCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMutationCredit.FieldName = "MutationCredit";
            this.colMutationCredit.Name = "colMutationCredit";
            this.colMutationCredit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MutationCredit", "{0:#,#}")});
            this.colMutationCredit.Visible = true;
            // 
            // gbReconciliation
            // 
            this.gbReconciliation.AppearanceHeader.Options.UseTextOptions = true;
            this.gbReconciliation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gbReconciliation.Caption = "Penyesuaian";
            this.gbReconciliation.Columns.Add(this.colReconcilDebit);
            this.gbReconciliation.Columns.Add(this.colReconcilCredit);
            this.gbReconciliation.Name = "gbReconciliation";
            this.gbReconciliation.OptionsBand.ShowInCustomizationForm = false;
            this.gbReconciliation.VisibleIndex = 3;
            this.gbReconciliation.Width = 150;
            // 
            // colReconcilDebit
            // 
            this.colReconcilDebit.AppearanceHeader.Options.UseTextOptions = true;
            this.colReconcilDebit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReconcilDebit.Caption = "Debet";
            this.colReconcilDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colReconcilDebit.FieldName = "ReconciliationDebit";
            this.colReconcilDebit.Name = "colReconcilDebit";
            this.colReconcilDebit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ReconciliationDebit", "{0:#,#}")});
            this.colReconcilDebit.Visible = true;
            // 
            // colReconcilCredit
            // 
            this.colReconcilCredit.AppearanceHeader.Options.UseTextOptions = true;
            this.colReconcilCredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReconcilCredit.Caption = "Kredit";
            this.colReconcilCredit.DisplayFormat.FormatString = "{0:#,#}";
            this.colReconcilCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colReconcilCredit.FieldName = "ReconciliationCredit";
            this.colReconcilCredit.Name = "colReconcilCredit";
            this.colReconcilCredit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ReconciliationCredit", "{0:#,#}")});
            this.colReconcilCredit.Visible = true;
            // 
            // gbProfitLoss
            // 
            this.gbProfitLoss.AppearanceHeader.Options.UseTextOptions = true;
            this.gbProfitLoss.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gbProfitLoss.Caption = "Laba / Rugi";
            this.gbProfitLoss.Columns.Add(this.colProfitLossDebit);
            this.gbProfitLoss.Columns.Add(this.colProfitLossCredit);
            this.gbProfitLoss.Name = "gbProfitLoss";
            this.gbProfitLoss.VisibleIndex = 4;
            this.gbProfitLoss.Width = 150;
            // 
            // colProfitLossDebit
            // 
            this.colProfitLossDebit.AppearanceHeader.Options.UseTextOptions = true;
            this.colProfitLossDebit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProfitLossDebit.Caption = "Debet";
            this.colProfitLossDebit.DisplayFormat.FormatString = "{0:#,#}";
            this.colProfitLossDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colProfitLossDebit.FieldName = "ProfitLossDebit";
            this.colProfitLossDebit.Name = "colProfitLossDebit";
            this.colProfitLossDebit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ProfitLossDebit", "{0:#,#}")});
            this.colProfitLossDebit.Visible = true;
            // 
            // colProfitLossCredit
            // 
            this.colProfitLossCredit.AppearanceHeader.Options.UseTextOptions = true;
            this.colProfitLossCredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProfitLossCredit.Caption = "Kredit";
            this.colProfitLossCredit.DisplayFormat.FormatString = "{0:#,#}";
            this.colProfitLossCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colProfitLossCredit.FieldName = "ProfitLossCredit";
            this.colProfitLossCredit.Name = "colProfitLossCredit";
            this.colProfitLossCredit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ProfitLossCredit", "{0:#,#}")});
            this.colProfitLossCredit.Visible = true;
            // 
            // gbLastBalance
            // 
            this.gbLastBalance.AppearanceHeader.Options.UseTextOptions = true;
            this.gbLastBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gbLastBalance.Caption = "Saldo Akhir";
            this.gbLastBalance.Columns.Add(this.colLastDebiit);
            this.gbLastBalance.Columns.Add(this.colLastCredit);
            this.gbLastBalance.Name = "gbLastBalance";
            this.gbLastBalance.OptionsBand.ShowInCustomizationForm = false;
            this.gbLastBalance.VisibleIndex = 5;
            this.gbLastBalance.Width = 150;
            // 
            // colLastDebiit
            // 
            this.colLastDebiit.AppearanceHeader.Options.UseTextOptions = true;
            this.colLastDebiit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLastDebiit.Caption = "Debet";
            this.colLastDebiit.DisplayFormat.FormatString = "{0:#,#}";
            this.colLastDebiit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLastDebiit.FieldName = "LastDebit";
            this.colLastDebiit.Name = "colLastDebiit";
            this.colLastDebiit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LastDebit", "{0:#,#}")});
            this.colLastDebiit.Visible = true;
            // 
            // colLastCredit
            // 
            this.colLastCredit.AppearanceHeader.Options.UseTextOptions = true;
            this.colLastCredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLastCredit.Caption = "Kredit";
            this.colLastCredit.DisplayFormat.FormatString = "{0:#,#}";
            this.colLastCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLastCredit.FieldName = "LastCredit";
            this.colLastCredit.Name = "colLastCredit";
            this.colLastCredit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LastCredit", "{0:#,#}")});
            this.colLastCredit.Visible = true;
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
            // BalanceJournalListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridBalanceJournal);
            this.Controls.Add(this.btnRecalculateBalanceJournal);
            this.Controls.Add(this.gcFilter);
            this.Name = "BalanceJournalListControl";
            this.Size = new System.Drawing.Size(895, 348);
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
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.ComponentModel.BackgroundWorker bgwRecalculate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gvBalanceJournal;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gbJournalCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colJournalCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colJournalName;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gbFirstBalance;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFirstBalanceDebit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFirstBalanceCredit;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gbMutation;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMutationDebit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMutationCredit;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gbReconciliation;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colReconcilDebit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colReconcilCredit;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gbProfitLoss;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProfitLossDebit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProfitLossCredit;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gbLastBalance;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLastDebiit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLastCredit;
    }
}
