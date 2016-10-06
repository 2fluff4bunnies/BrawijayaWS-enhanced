namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class HistorySparepartListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorySparepartListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDateFilterTo = new DevExpress.XtraEditors.DateEdit();
            this.txtDateFilterFrom = new DevExpress.XtraEditors.DateEdit();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lookupSparepart = new DevExpress.XtraEditors.LookUpEdit();
            this.lblFilterSparepart = new DevExpress.XtraEditors.LabelControl();
            this.lookupVehicleNo = new DevExpress.XtraEditors.LookUpEdit();
            this.lblFilterVehicleNo = new DevExpress.XtraEditors.LabelControl();
            this.gridHistorySparepart = new DevExpress.XtraGrid.GridControl();
            this.gvHistorySparepart = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLicenseNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepartCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoCheckBox = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupSparepart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupVehicleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistorySparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHistorySparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheckBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.labelControl1);
            this.gcFilter.Controls.Add(this.txtDateFilterTo);
            this.gcFilter.Controls.Add(this.txtDateFilterFrom);
            this.gcFilter.Controls.Add(this.lblDate);
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.lookupSparepart);
            this.gcFilter.Controls.Add(this.lblFilterSparepart);
            this.gcFilter.Controls.Add(this.lookupVehicleNo);
            this.gcFilter.Controls.Add(this.lblFilterVehicleNo);
            this.gcFilter.Location = new System.Drawing.Point(3, 2);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(877, 66);
            this.gcFilter.TabIndex = 2;
            this.gcFilter.Text = "Filter";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(661, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(4, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "-";
            // 
            // txtDateFilterTo
            // 
            this.txtDateFilterTo.EditValue = null;
            this.txtDateFilterTo.Location = new System.Drawing.Point(671, 32);
            this.txtDateFilterTo.Name = "txtDateFilterTo";
            this.txtDateFilterTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateFilterTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateFilterTo.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.txtDateFilterTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDateFilterTo.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.txtDateFilterTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDateFilterTo.Properties.HideSelection = false;
            this.txtDateFilterTo.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.txtDateFilterTo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtDateFilterTo.Size = new System.Drawing.Size(138, 20);
            this.txtDateFilterTo.TabIndex = 7;
            // 
            // txtDateFilterFrom
            // 
            this.txtDateFilterFrom.EditValue = null;
            this.txtDateFilterFrom.Location = new System.Drawing.Point(517, 32);
            this.txtDateFilterFrom.Name = "txtDateFilterFrom";
            this.txtDateFilterFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateFilterFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateFilterFrom.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.txtDateFilterFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDateFilterFrom.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.txtDateFilterFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDateFilterFrom.Properties.HideSelection = false;
            this.txtDateFilterFrom.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.txtDateFilterFrom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtDateFilterFrom.Size = new System.Drawing.Size(138, 20);
            this.txtDateFilterFrom.TabIndex = 6;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(460, 35);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Tanggal : ";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(816, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lookupSparepart
            // 
            this.lookupSparepart.Location = new System.Drawing.Point(276, 32);
            this.lookupSparepart.Name = "lookupSparepart";
            this.lookupSparepart.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookupSparepart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupSparepart.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Sparepart")});
            this.lookupSparepart.Properties.DisplayMember = "Name";
            this.lookupSparepart.Properties.HideSelection = false;
            this.lookupSparepart.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookupSparepart.Properties.NullText = "-- Pilih Sparepart --";
            this.lookupSparepart.Properties.ShowHeader = false;
            this.lookupSparepart.Properties.ValueMember = "Id";
            this.lookupSparepart.Size = new System.Drawing.Size(169, 20);
            this.lookupSparepart.TabIndex = 3;
            // 
            // lblFilterSparepart
            // 
            this.lblFilterSparepart.Location = new System.Drawing.Point(215, 35);
            this.lblFilterSparepart.Name = "lblFilterSparepart";
            this.lblFilterSparepart.Size = new System.Drawing.Size(55, 13);
            this.lblFilterSparepart.TabIndex = 2;
            this.lblFilterSparepart.Text = "Sparepart :";
            // 
            // lookupVehicleNo
            // 
            this.lookupVehicleNo.Location = new System.Drawing.Point(52, 32);
            this.lookupVehicleNo.Name = "lookupVehicleNo";
            this.lookupVehicleNo.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookupVehicleNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupVehicleNo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ActiveLicenseNumber", "Nopol")});
            this.lookupVehicleNo.Properties.DisplayMember = "ActiveLicenseNumber";
            this.lookupVehicleNo.Properties.HideSelection = false;
            this.lookupVehicleNo.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookupVehicleNo.Properties.NullText = "-- Pilih Nopol --";
            this.lookupVehicleNo.Properties.ValueMember = "Id";
            this.lookupVehicleNo.Size = new System.Drawing.Size(153, 20);
            this.lookupVehicleNo.TabIndex = 1;
            // 
            // lblFilterVehicleNo
            // 
            this.lblFilterVehicleNo.Location = new System.Drawing.Point(12, 35);
            this.lblFilterVehicleNo.Name = "lblFilterVehicleNo";
            this.lblFilterVehicleNo.Size = new System.Drawing.Size(34, 13);
            this.lblFilterVehicleNo.TabIndex = 0;
            this.lblFilterVehicleNo.Text = "Nopol :";
            // 
            // gridHistorySparepart
            // 
            this.gridHistorySparepart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridHistorySparepart.Location = new System.Drawing.Point(3, 113);
            this.gridHistorySparepart.MainView = this.gvHistorySparepart;
            this.gridHistorySparepart.Name = "gridHistorySparepart";
            this.gridHistorySparepart.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoCheckBox});
            this.gridHistorySparepart.Size = new System.Drawing.Size(877, 262);
            this.gridHistorySparepart.TabIndex = 6;
            this.gridHistorySparepart.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHistorySparepart});
            // 
            // gvHistorySparepart
            // 
            this.gvHistorySparepart.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colLicenseNumber,
            this.colSparepartCode,
            this.colSparepartName,
            this.colUnitName,
            this.colQty,
            this.colSubTotal,
            this.colCategory});
            this.gvHistorySparepart.GridControl = this.gridHistorySparepart;
            this.gvHistorySparepart.Name = "gvHistorySparepart";
            this.gvHistorySparepart.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvHistorySparepart.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvHistorySparepart.OptionsBehavior.AutoPopulateColumns = false;
            this.gvHistorySparepart.OptionsBehavior.Editable = false;
            this.gvHistorySparepart.OptionsBehavior.ReadOnly = true;
            this.gvHistorySparepart.OptionsCustomization.AllowColumnMoving = false;
            this.gvHistorySparepart.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvHistorySparepart.OptionsView.EnableAppearanceEvenRow = true;
            this.gvHistorySparepart.OptionsView.ShowFooter = true;
            this.gvHistorySparepart.OptionsView.ShowGroupPanel = false;
            this.gvHistorySparepart.OptionsView.ShowViewCaption = true;
            this.gvHistorySparepart.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDate, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvHistorySparepart.ViewCaption = "History Sparepart";
            // 
            // colDate
            // 
            this.colDate.Caption = "Tanggal";
            this.colDate.FieldName = "SPK.CreateDate";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            // 
            // colLicenseNumber
            // 
            this.colLicenseNumber.Caption = "Nopol";
            this.colLicenseNumber.FieldName = "SPK.Vehicle.ActiveLicenseNumber";
            this.colLicenseNumber.Name = "colLicenseNumber";
            this.colLicenseNumber.Visible = true;
            this.colLicenseNumber.VisibleIndex = 1;
            // 
            // colSparepartCode
            // 
            this.colSparepartCode.AppearanceHeader.Options.UseTextOptions = true;
            this.colSparepartCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSparepartCode.Caption = "Kode";
            this.colSparepartCode.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colSparepartCode.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSparepartCode.FieldName = "Sparepart.Code";
            this.colSparepartCode.Name = "colSparepartCode";
            this.colSparepartCode.Visible = true;
            this.colSparepartCode.VisibleIndex = 2;
            // 
            // colSparepartName
            // 
            this.colSparepartName.AppearanceHeader.Options.UseTextOptions = true;
            this.colSparepartName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSparepartName.Caption = "Nama";
            this.colSparepartName.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colSparepartName.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSparepartName.FieldName = "Sparepart.Name";
            this.colSparepartName.Name = "colSparepartName";
            this.colSparepartName.Visible = true;
            this.colSparepartName.VisibleIndex = 3;
            // 
            // colUnitName
            // 
            this.colUnitName.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnitName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colUnitName.Caption = "Unit";
            this.colUnitName.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colUnitName.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitName.FieldName = "Sparepart.UnitReference.Name";
            this.colUnitName.Name = "colUnitName";
            this.colUnitName.Visible = true;
            this.colUnitName.VisibleIndex = 4;
            // 
            // colQty
            // 
            this.colQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colQty.Caption = "Qty";
            this.colQty.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQty.FieldName = "TotalQuantity";
            this.colQty.Name = "colQty";
            this.colQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "{0:#,#;(#,#);0}")});
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 5;
            // 
            // colSubTotal
            // 
            this.colSubTotal.Caption = "SubTotal";
            this.colSubTotal.FieldName = "TotalPrice";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubTotal", "{0:#,#;(#,#);0}")});
            this.colSubTotal.Visible = true;
            this.colSubTotal.VisibleIndex = 6;
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
            // colCategory
            // 
            this.colCategory.Caption = "Kategori";
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 7;
            // 
            // HistorySparepartListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridHistorySparepart);
            this.Controls.Add(this.gcFilter);
            this.Name = "HistorySparepartListControl";
            this.Size = new System.Drawing.Size(883, 375);
            this.Load += new System.EventHandler(this.HistorySparepartListControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFilterFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupSparepart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupVehicleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistorySparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHistorySparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheckBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LookUpEdit lookupSparepart;
        private DevExpress.XtraEditors.LabelControl lblFilterSparepart;
        private DevExpress.XtraEditors.LookUpEdit lookupVehicleNo;
        private DevExpress.XtraEditors.LabelControl lblFilterVehicleNo;
        private DevExpress.XtraGrid.GridControl gridHistorySparepart;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHistorySparepart;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLicenseNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitName;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repoCheckBox;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtDateFilterTo;
        private DevExpress.XtraEditors.DateEdit txtDateFilterFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotal;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
    }
}
