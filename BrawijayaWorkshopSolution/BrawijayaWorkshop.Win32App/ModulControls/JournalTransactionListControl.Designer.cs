namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class JournalTransactionListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalTransactionListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lookupYear = new DevExpress.XtraEditors.LookUpEdit();
            this.lblFilterYear = new DevExpress.XtraEditors.LabelControl();
            this.lookupMonth = new DevExpress.XtraEditors.LookUpEdit();
            this.lblFilterMonth = new DevExpress.XtraEditors.LabelControl();
            this.gridTransaction = new DevExpress.XtraGrid.GridControl();
            this.gvTransaction = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colJournalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJournalName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJournalDebit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJournalCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransaction)).BeginInit();
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
            this.gcFilter.Size = new System.Drawing.Size(784, 66);
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
            // gridTransaction
            // 
            this.gridTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTransaction.Location = new System.Drawing.Point(3, 75);
            this.gridTransaction.MainView = this.gvTransaction;
            this.gridTransaction.Name = "gridTransaction";
            this.gridTransaction.Size = new System.Drawing.Size(784, 345);
            this.gridTransaction.TabIndex = 5;
            this.gridTransaction.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTransaction});
            // 
            // gvTransaction
            // 
            this.gvTransaction.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colJournalCode,
            this.colJournalName,
            this.colJournalDebit,
            this.colJournalCredit});
            this.gvTransaction.GridControl = this.gridTransaction;
            this.gvTransaction.Name = "gvTransaction";
            this.gvTransaction.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvTransaction.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvTransaction.OptionsBehavior.AutoPopulateColumns = false;
            this.gvTransaction.OptionsBehavior.Editable = false;
            this.gvTransaction.OptionsBehavior.ReadOnly = true;
            this.gvTransaction.OptionsCustomization.AllowColumnMoving = false;
            this.gvTransaction.OptionsCustomization.AllowFilter = false;
            this.gvTransaction.OptionsCustomization.AllowGroup = false;
            this.gvTransaction.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvTransaction.OptionsView.EnableAppearanceEvenRow = true;
            this.gvTransaction.OptionsView.ShowFooter = true;
            this.gvTransaction.OptionsView.ShowGroupPanel = false;
            this.gvTransaction.OptionsView.ShowViewCaption = true;
            this.gvTransaction.ViewCaption = "Daftar Transaksi Jurnal";
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
            // colJournalDebit
            // 
            this.colJournalDebit.Caption = "Debet";
            this.colJournalDebit.DisplayFormat.FormatString = "{0:#,#}";
            this.colJournalDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colJournalDebit.FieldName = "Debit";
            this.colJournalDebit.Name = "colJournalDebit";
            this.colJournalDebit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debit", "{0:#,#}")});
            this.colJournalDebit.Visible = true;
            this.colJournalDebit.VisibleIndex = 2;
            // 
            // colJournalCredit
            // 
            this.colJournalCredit.Caption = "Kredit";
            this.colJournalCredit.DisplayFormat.FormatString = "{0:#,#}";
            this.colJournalCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colJournalCredit.FieldName = "Credit";
            this.colJournalCredit.Name = "colJournalCredit";
            this.colJournalCredit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credit", "{0:#,#}")});
            this.colJournalCredit.Visible = true;
            this.colJournalCredit.VisibleIndex = 3;
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // JournalTransactionListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridTransaction);
            this.Controls.Add(this.gcFilter);
            this.Name = "JournalTransactionListControl";
            this.Size = new System.Drawing.Size(790, 423);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LookUpEdit lookupYear;
        private DevExpress.XtraEditors.LabelControl lblFilterYear;
        private DevExpress.XtraEditors.LookUpEdit lookupMonth;
        private DevExpress.XtraEditors.LabelControl lblFilterMonth;
        private DevExpress.XtraGrid.GridControl gridTransaction;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTransaction;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalName;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalDebit;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalCredit;
        private System.ComponentModel.BackgroundWorker bgwMain;
    }
}
