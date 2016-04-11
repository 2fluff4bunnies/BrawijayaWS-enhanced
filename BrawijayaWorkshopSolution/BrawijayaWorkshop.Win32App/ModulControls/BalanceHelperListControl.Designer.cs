namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class BalanceHelperListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BalanceHelperListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.lookUpFilterJournal = new DevExpress.XtraEditors.LookUpEdit();
            this.lblFilterJournal = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lookupYear = new DevExpress.XtraEditors.LookUpEdit();
            this.lblFilterYear = new DevExpress.XtraEditors.LabelControl();
            this.lookupMonth = new DevExpress.XtraEditors.LookUpEdit();
            this.lblFilterMonth = new DevExpress.XtraEditors.LabelControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.gridBalanceHelper = new DevExpress.XtraGrid.GridControl();
            this.gvBalanceHelper = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJournalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJournalName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMutationDebit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMutationCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpFilterJournal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBalanceHelper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBalanceHelper)).BeginInit();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.lookUpFilterJournal);
            this.gcFilter.Controls.Add(this.lblFilterJournal);
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.lookupYear);
            this.gcFilter.Controls.Add(this.lblFilterYear);
            this.gcFilter.Controls.Add(this.lookupMonth);
            this.gcFilter.Controls.Add(this.lblFilterMonth);
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(883, 66);
            this.gcFilter.TabIndex = 0;
            this.gcFilter.Text = "Filter";
            // 
            // lookUpFilterJournal
            // 
            this.lookUpFilterJournal.Location = new System.Drawing.Point(435, 32);
            this.lookUpFilterJournal.Name = "lookUpFilterJournal";
            this.lookUpFilterJournal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpFilterJournal.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Kode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Nama")});
            this.lookUpFilterJournal.Properties.DisplayMember = "Name";
            this.lookUpFilterJournal.Properties.HideSelection = false;
            this.lookUpFilterJournal.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookUpFilterJournal.Properties.NullText = "-- Pilih Akun Jurnal --";
            this.lookUpFilterJournal.Properties.ValueMember = "Id";
            this.lookUpFilterJournal.Size = new System.Drawing.Size(269, 20);
            this.lookUpFilterJournal.TabIndex = 5;
            // 
            // lblFilterJournal
            // 
            this.lblFilterJournal.Location = new System.Drawing.Point(364, 35);
            this.lblFilterJournal.Name = "lblFilterJournal";
            this.lblFilterJournal.Size = new System.Drawing.Size(56, 13);
            this.lblFilterJournal.TabIndex = 4;
            this.lblFilterJournal.Text = "Akun Jurnal";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(710, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 6;
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
            // btnPrint
            // 
            this.btnPrint.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.print_16x16;
            this.btnPrint.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnPrint.Location = new System.Drawing.Point(3, 75);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 29);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gridBalanceHelper
            // 
            this.gridBalanceHelper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBalanceHelper.Location = new System.Drawing.Point(3, 110);
            this.gridBalanceHelper.MainView = this.gvBalanceHelper;
            this.gridBalanceHelper.Name = "gridBalanceHelper";
            this.gridBalanceHelper.Size = new System.Drawing.Size(883, 353);
            this.gridBalanceHelper.TabIndex = 8;
            this.gridBalanceHelper.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBalanceHelper});
            // 
            // gvBalanceHelper
            // 
            this.gvBalanceHelper.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransDate,
            this.colJournalCode,
            this.colJournalName,
            this.colMutationDebit,
            this.colMutationCredit,
            this.colBalance});
            this.gvBalanceHelper.GridControl = this.gridBalanceHelper;
            this.gvBalanceHelper.GroupCount = 1;
            this.gvBalanceHelper.Name = "gvBalanceHelper";
            this.gvBalanceHelper.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvBalanceHelper.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvBalanceHelper.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvBalanceHelper.OptionsBehavior.AutoPopulateColumns = false;
            this.gvBalanceHelper.OptionsBehavior.Editable = false;
            this.gvBalanceHelper.OptionsBehavior.ReadOnly = true;
            this.gvBalanceHelper.OptionsCustomization.AllowColumnMoving = false;
            this.gvBalanceHelper.OptionsCustomization.AllowFilter = false;
            this.gvBalanceHelper.OptionsCustomization.AllowGroup = false;
            this.gvBalanceHelper.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvBalanceHelper.OptionsCustomization.AllowSort = false;
            this.gvBalanceHelper.OptionsView.ShowGroupPanel = false;
            this.gvBalanceHelper.OptionsView.ShowViewCaption = true;
            this.gvBalanceHelper.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colJournalName, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colJournalCode, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTransDate, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvBalanceHelper.ViewCaption = "-";
            // 
            // colTransDate
            // 
            this.colTransDate.Caption = "Tanggal";
            this.colTransDate.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colTransDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTransDate.FieldName = "TransactionDate";
            this.colTransDate.Name = "colTransDate";
            this.colTransDate.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colTransDate.Visible = true;
            this.colTransDate.VisibleIndex = 0;
            // 
            // colJournalCode
            // 
            this.colJournalCode.Caption = "Kode Akun";
            this.colJournalCode.FieldName = "JournalCode";
            this.colJournalCode.Name = "colJournalCode";
            this.colJournalCode.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colJournalCode.Visible = true;
            this.colJournalCode.VisibleIndex = 1;
            // 
            // colJournalName
            // 
            this.colJournalName.Caption = "Nama Akun";
            this.colJournalName.FieldName = "JournalName";
            this.colJournalName.Name = "colJournalName";
            this.colJournalName.Visible = true;
            this.colJournalName.VisibleIndex = 2;
            // 
            // colMutationDebit
            // 
            this.colMutationDebit.AppearanceHeader.Options.UseTextOptions = true;
            this.colMutationDebit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colMutationDebit.Caption = "Debet";
            this.colMutationDebit.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colMutationDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMutationDebit.FieldName = "MutationDebit";
            this.colMutationDebit.Name = "colMutationDebit";
            this.colMutationDebit.Visible = true;
            this.colMutationDebit.VisibleIndex = 2;
            // 
            // colMutationCredit
            // 
            this.colMutationCredit.AppearanceHeader.Options.UseTextOptions = true;
            this.colMutationCredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colMutationCredit.Caption = "Kredit";
            this.colMutationCredit.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colMutationCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMutationCredit.FieldName = "MutationCredit";
            this.colMutationCredit.Name = "colMutationCredit";
            this.colMutationCredit.Visible = true;
            this.colMutationCredit.VisibleIndex = 3;
            // 
            // colBalance
            // 
            this.colBalance.AppearanceHeader.Options.UseTextOptions = true;
            this.colBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colBalance.Caption = "Saldo";
            this.colBalance.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBalance.FieldName = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.Visible = true;
            this.colBalance.VisibleIndex = 4;
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // BalanceHelperListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridBalanceHelper);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gcFilter);
            this.Name = "BalanceHelperListControl";
            this.Size = new System.Drawing.Size(889, 466);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpFilterJournal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBalanceHelper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBalanceHelper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.LookUpEdit lookUpFilterJournal;
        private DevExpress.XtraEditors.LabelControl lblFilterJournal;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LookUpEdit lookupYear;
        private DevExpress.XtraEditors.LabelControl lblFilterYear;
        private DevExpress.XtraEditors.LookUpEdit lookupMonth;
        private DevExpress.XtraEditors.LabelControl lblFilterMonth;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.GridControl gridBalanceHelper;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBalanceHelper;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private DevExpress.XtraGrid.Columns.GridColumn colTransDate;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalName;
        private DevExpress.XtraGrid.Columns.GridColumn colMutationDebit;
        private DevExpress.XtraGrid.Columns.GridColumn colMutationCredit;
        private DevExpress.XtraGrid.Columns.GridColumn colBalance;
    }
}
