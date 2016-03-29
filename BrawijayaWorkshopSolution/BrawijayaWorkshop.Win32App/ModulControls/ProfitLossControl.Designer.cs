namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class ProfitLossControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfitLossControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lookupYear = new DevExpress.XtraEditors.LookUpEdit();
            this.lblFilterYear = new DevExpress.XtraEditors.LabelControl();
            this.lookupMonth = new DevExpress.XtraEditors.LookUpEdit();
            this.lblFilterMonth = new DevExpress.XtraEditors.LabelControl();
            this.btnRecalculateBalanceJournal = new DevExpress.XtraEditors.SimpleButton();
            this.gridActiva = new DevExpress.XtraGrid.GridControl();
            this.gvActiva = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colActivaHeader = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActivaName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActivaAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoCheckBox = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.bgwRecalculate = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridActiva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvActiva)).BeginInit();
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
            this.gcFilter.Size = new System.Drawing.Size(851, 66);
            this.gcFilter.TabIndex = 4;
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
            this.btnRecalculateBalanceJournal.TabIndex = 5;
            this.btnRecalculateBalanceJournal.Text = "Hitung Neraca";
            this.btnRecalculateBalanceJournal.Click += new System.EventHandler(this.btnRecalculateBalanceJournal_Click);
            // 
            // gridActiva
            // 
            this.gridActiva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridActiva.Location = new System.Drawing.Point(3, 110);
            this.gridActiva.MainView = this.gvActiva;
            this.gridActiva.Name = "gridActiva";
            this.gridActiva.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoCheckBox});
            this.gridActiva.Size = new System.Drawing.Size(851, 335);
            this.gridActiva.TabIndex = 6;
            this.gridActiva.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvActiva});
            // 
            // gvActiva
            // 
            this.gvActiva.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colActivaHeader,
            this.colActivaName,
            this.colActivaAmount});
            this.gvActiva.GridControl = this.gridActiva;
            this.gvActiva.GroupCount = 1;
            this.gvActiva.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", this.colActivaAmount, "{0:#,#;(#,#);0}")});
            this.gvActiva.Name = "gvActiva";
            this.gvActiva.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvActiva.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvActiva.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvActiva.OptionsBehavior.AutoPopulateColumns = false;
            this.gvActiva.OptionsBehavior.Editable = false;
            this.gvActiva.OptionsBehavior.ReadOnly = true;
            this.gvActiva.OptionsCustomization.AllowColumnMoving = false;
            this.gvActiva.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvActiva.OptionsView.EnableAppearanceEvenRow = true;
            this.gvActiva.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvActiva.OptionsView.ShowFooter = true;
            this.gvActiva.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gvActiva.OptionsView.ShowGroupPanel = false;
            this.gvActiva.OptionsView.ShowViewCaption = true;
            this.gvActiva.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colActivaHeader, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvActiva.ViewCaption = "ACTIVA";
            // 
            // colActivaHeader
            // 
            this.colActivaHeader.Caption = "Group";
            this.colActivaHeader.FieldName = "Header.GroupName";
            this.colActivaHeader.Name = "colActivaHeader";
            this.colActivaHeader.Visible = true;
            this.colActivaHeader.VisibleIndex = 0;
            // 
            // colActivaName
            // 
            this.colActivaName.Caption = "Nama";
            this.colActivaName.FieldName = "Name";
            this.colActivaName.Name = "colActivaName";
            this.colActivaName.Visible = true;
            this.colActivaName.VisibleIndex = 0;
            // 
            // colActivaAmount
            // 
            this.colActivaAmount.Caption = "Jumlah";
            this.colActivaAmount.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colActivaAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colActivaAmount.FieldName = "Amount";
            this.colActivaAmount.Name = "colActivaAmount";
            this.colActivaAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "{0:#,#;(#,#);0}")});
            this.colActivaAmount.Visible = true;
            this.colActivaAmount.VisibleIndex = 1;
            // 
            // repoCheckBox
            // 
            this.repoCheckBox.AutoHeight = false;
            this.repoCheckBox.Name = "repoCheckBox";
            this.repoCheckBox.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
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
            // ProfitLossControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridActiva);
            this.Controls.Add(this.btnRecalculateBalanceJournal);
            this.Controls.Add(this.gcFilter);
            this.Name = "ProfitLossControl";
            this.Size = new System.Drawing.Size(857, 448);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridActiva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvActiva)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridActiva;
        private DevExpress.XtraGrid.Views.Grid.GridView gvActiva;
        private DevExpress.XtraGrid.Columns.GridColumn colActivaHeader;
        private DevExpress.XtraGrid.Columns.GridColumn colActivaName;
        private DevExpress.XtraGrid.Columns.GridColumn colActivaAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repoCheckBox;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.ComponentModel.BackgroundWorker bgwRecalculate;
    }
}
