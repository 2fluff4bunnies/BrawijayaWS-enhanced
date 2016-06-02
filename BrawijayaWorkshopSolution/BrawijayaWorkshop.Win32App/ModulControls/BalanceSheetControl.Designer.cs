namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class BalanceSheetControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BalanceSheetControl));
            this.gridActiva = new DevExpress.XtraGrid.GridControl();
            this.gvActiva = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colActivaHeader = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActivaName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActivaAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoCheckBox = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gvPassivaDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridPassiva = new DevExpress.XtraGrid.GridControl();
            this.gvPassiva = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPassivaHeader = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassivaName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassivaAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnRecalculateBalanceJournal = new DevExpress.XtraEditors.SimpleButton();
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lookupYear = new DevExpress.XtraEditors.LookUpEdit();
            this.lblFilterYear = new DevExpress.XtraEditors.LabelControl();
            this.lookupMonth = new DevExpress.XtraEditors.LookUpEdit();
            this.lblFilterMonth = new DevExpress.XtraEditors.LabelControl();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.bgwRecalculate = new System.ComponentModel.BackgroundWorker();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlPrint = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridActiva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvActiva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPassivaDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPassiva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPassiva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPrint)).BeginInit();
            this.layoutControlPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridActiva
            // 
            this.gridActiva.Location = new System.Drawing.Point(0, 0);
            this.gridActiva.MainView = this.gvActiva;
            this.gridActiva.Name = "gridActiva";
            this.gridActiva.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoCheckBox});
            this.gridActiva.Size = new System.Drawing.Size(432, 334);
            this.gridActiva.TabIndex = 5;
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
            this.colActivaAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colActivaAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
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
            // gvPassivaDetail
            // 
            this.gvPassivaDetail.GridControl = this.gridPassiva;
            this.gvPassivaDetail.Name = "gvPassivaDetail";
            // 
            // gridPassiva
            // 
            this.gridPassiva.Location = new System.Drawing.Point(436, 0);
            this.gridPassiva.MainView = this.gvPassiva;
            this.gridPassiva.Name = "gridPassiva";
            this.gridPassiva.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridPassiva.Size = new System.Drawing.Size(421, 334);
            this.gridPassiva.TabIndex = 6;
            this.gridPassiva.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPassiva,
            this.gvPassivaDetail});
            // 
            // gvPassiva
            // 
            this.gvPassiva.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPassivaHeader,
            this.colPassivaName,
            this.colPassivaAmount});
            this.gvPassiva.GridControl = this.gridPassiva;
            this.gvPassiva.GroupCount = 1;
            this.gvPassiva.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", this.colPassivaAmount, "{0:#,#;(#,#);0}")});
            this.gvPassiva.Name = "gvPassiva";
            this.gvPassiva.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvPassiva.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvPassiva.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvPassiva.OptionsBehavior.AutoPopulateColumns = false;
            this.gvPassiva.OptionsBehavior.Editable = false;
            this.gvPassiva.OptionsBehavior.ReadOnly = true;
            this.gvPassiva.OptionsCustomization.AllowColumnMoving = false;
            this.gvPassiva.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvPassiva.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPassiva.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvPassiva.OptionsView.ShowFooter = true;
            this.gvPassiva.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gvPassiva.OptionsView.ShowGroupPanel = false;
            this.gvPassiva.OptionsView.ShowViewCaption = true;
            this.gvPassiva.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPassivaHeader, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvPassiva.ViewCaption = "PASSIVA";
            // 
            // colPassivaHeader
            // 
            this.colPassivaHeader.Caption = "Group";
            this.colPassivaHeader.FieldName = "Header.GroupName";
            this.colPassivaHeader.Name = "colPassivaHeader";
            this.colPassivaHeader.Visible = true;
            this.colPassivaHeader.VisibleIndex = 0;
            // 
            // colPassivaName
            // 
            this.colPassivaName.Caption = "Nama";
            this.colPassivaName.FieldName = "Name";
            this.colPassivaName.Name = "colPassivaName";
            this.colPassivaName.Visible = true;
            this.colPassivaName.VisibleIndex = 0;
            // 
            // colPassivaAmount
            // 
            this.colPassivaAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colPassivaAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPassivaAmount.Caption = "Jumlah";
            this.colPassivaAmount.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colPassivaAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPassivaAmount.FieldName = "Amount";
            this.colPassivaAmount.Name = "colPassivaAmount";
            this.colPassivaAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "{0:#,#;(#,#);0}")});
            this.colPassivaAmount.Visible = true;
            this.colPassivaAmount.VisibleIndex = 1;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // btnRecalculateBalanceJournal
            // 
            this.btnRecalculateBalanceJournal.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.calculator_16x16;
            this.btnRecalculateBalanceJournal.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnRecalculateBalanceJournal.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnRecalculateBalanceJournal.Location = new System.Drawing.Point(3, 75);
            this.btnRecalculateBalanceJournal.Name = "btnRecalculateBalanceJournal";
            this.btnRecalculateBalanceJournal.Size = new System.Drawing.Size(113, 29);
            this.btnRecalculateBalanceJournal.TabIndex = 4;
            this.btnRecalculateBalanceJournal.Text = "Hitung Neraca";
            this.btnRecalculateBalanceJournal.Click += new System.EventHandler(this.btnRecalculateBalanceJournal_Click);
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
            this.gcFilter.Size = new System.Drawing.Size(857, 66);
            this.gcFilter.TabIndex = 3;
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
            // btnPrint
            // 
            this.btnPrint.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.print_16x16;
            this.btnPrint.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnPrint.Location = new System.Drawing.Point(140, 75);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 29);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // layoutControlPrint
            // 
            this.layoutControlPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControlPrint.BackColor = System.Drawing.SystemColors.Control;
            this.layoutControlPrint.Controls.Add(this.gridActiva);
            this.layoutControlPrint.Controls.Add(this.gridPassiva);
            this.layoutControlPrint.Location = new System.Drawing.Point(3, 111);
            this.layoutControlPrint.Name = "layoutControlPrint";
            this.layoutControlPrint.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(362, 100, 873, 507);
            this.layoutControlPrint.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlPrint.Root = this.layoutControlGroup;
            this.layoutControlPrint.Size = new System.Drawing.Size(857, 334);
            this.layoutControlPrint.TabIndex = 8;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.AllowCustomizeChildren = false;
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "Root";
            this.layoutControlGroup.OptionsPrint.AllowPrintGroupCaption = false;
            this.layoutControlGroup.OptionsTableLayoutItem.RowSpan = 2;
            this.layoutControlGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup.Size = new System.Drawing.Size(857, 334);
            this.layoutControlGroup.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridActiva;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(434, 334);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 2, 0, 0);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridPassiva;
            this.layoutControlItem2.Location = new System.Drawing.Point(434, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem2.Size = new System.Drawing.Size(423, 334);
            this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 0, 0, 0);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // BalanceSheetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControlPrint);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnRecalculateBalanceJournal);
            this.Controls.Add(this.gcFilter);
            this.Name = "BalanceSheetControl";
            this.Size = new System.Drawing.Size(863, 448);
            ((System.ComponentModel.ISupportInitialize)(this.gridActiva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvActiva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPassivaDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPassiva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPassiva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPrint)).EndInit();
            this.layoutControlPrint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnRecalculateBalanceJournal;
        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LookUpEdit lookupYear;
        private DevExpress.XtraEditors.LabelControl lblFilterYear;
        private DevExpress.XtraEditors.LookUpEdit lookupMonth;
        private DevExpress.XtraEditors.LabelControl lblFilterMonth;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.ComponentModel.BackgroundWorker bgwRecalculate;
        private DevExpress.XtraGrid.GridControl gridActiva;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repoCheckBox;
        private DevExpress.XtraGrid.GridControl gridPassiva;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPassiva;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPassivaDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvActiva;
        private DevExpress.XtraGrid.Columns.GridColumn colActivaHeader;
        private DevExpress.XtraGrid.Columns.GridColumn colActivaName;
        private DevExpress.XtraGrid.Columns.GridColumn colActivaAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colPassivaHeader;
        private DevExpress.XtraGrid.Columns.GridColumn colPassivaName;
        private DevExpress.XtraGrid.Columns.GridColumn colPassivaAmount;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraLayout.LayoutControl layoutControlPrint;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
