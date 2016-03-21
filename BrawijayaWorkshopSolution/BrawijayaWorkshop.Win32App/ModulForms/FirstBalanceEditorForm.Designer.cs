namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class FirstBalanceEditorForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstBalanceEditorForm));
            this.gcFirstBalanceInfo = new DevExpress.XtraEditors.GroupControl();
            this.deFirstBalanceDate = new DevExpress.XtraEditors.DateEdit();
            this.lblFirstBalanceDate = new DevExpress.XtraEditors.LabelControl();
            this.gcFirstBalanceDetailInfo = new DevExpress.XtraEditors.GroupControl();
            this.gridFirstBalanceDetail = new DevExpress.XtraGrid.GridControl();
            this.gvFirstBalanceDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colJournal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpJournalGv = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDebit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnNewDetailData = new DevExpress.XtraEditors.SimpleButton();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcFirstBalanceInfo)).BeginInit();
            this.gcFirstBalanceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deFirstBalanceDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFirstBalanceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFirstBalanceDetailInfo)).BeginInit();
            this.gcFirstBalanceDetailInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFirstBalanceDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFirstBalanceDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpJournalGv)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcFirstBalanceInfo
            // 
            this.gcFirstBalanceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFirstBalanceInfo.Controls.Add(this.deFirstBalanceDate);
            this.gcFirstBalanceInfo.Controls.Add(this.lblFirstBalanceDate);
            this.gcFirstBalanceInfo.Location = new System.Drawing.Point(12, 12);
            this.gcFirstBalanceInfo.Name = "gcFirstBalanceInfo";
            this.gcFirstBalanceInfo.Size = new System.Drawing.Size(681, 67);
            this.gcFirstBalanceInfo.TabIndex = 1;
            this.gcFirstBalanceInfo.Text = "Informasi Saldo Awal";
            // 
            // deFirstBalanceDate
            // 
            this.deFirstBalanceDate.EditValue = null;
            this.deFirstBalanceDate.Location = new System.Drawing.Point(89, 32);
            this.deFirstBalanceDate.Name = "deFirstBalanceDate";
            this.deFirstBalanceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFirstBalanceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFirstBalanceDate.Properties.DisplayFormat.FormatString = "MMMM yyyy";
            this.deFirstBalanceDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deFirstBalanceDate.Properties.HideSelection = false;
            this.deFirstBalanceDate.Properties.Mask.EditMask = "M/yyyy";
            this.deFirstBalanceDate.Size = new System.Drawing.Size(180, 20);
            this.deFirstBalanceDate.TabIndex = 1;
            // 
            // lblFirstBalanceDate
            // 
            this.lblFirstBalanceDate.Location = new System.Drawing.Point(13, 35);
            this.lblFirstBalanceDate.Name = "lblFirstBalanceDate";
            this.lblFirstBalanceDate.Size = new System.Drawing.Size(70, 13);
            this.lblFirstBalanceDate.TabIndex = 0;
            this.lblFirstBalanceDate.Text = "Bulan / Tahun:";
            // 
            // gcFirstBalanceDetailInfo
            // 
            this.gcFirstBalanceDetailInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFirstBalanceDetailInfo.Controls.Add(this.gridFirstBalanceDetail);
            this.gcFirstBalanceDetailInfo.Controls.Add(this.btnNewDetailData);
            this.gcFirstBalanceDetailInfo.Location = new System.Drawing.Point(12, 85);
            this.gcFirstBalanceDetailInfo.Name = "gcFirstBalanceDetailInfo";
            this.gcFirstBalanceDetailInfo.Size = new System.Drawing.Size(681, 240);
            this.gcFirstBalanceDetailInfo.TabIndex = 2;
            this.gcFirstBalanceDetailInfo.Text = "Detail Saldo Awal";
            // 
            // gridFirstBalanceDetail
            // 
            this.gridFirstBalanceDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridFirstBalanceDetail.Location = new System.Drawing.Point(5, 52);
            this.gridFirstBalanceDetail.MainView = this.gvFirstBalanceDetail;
            this.gridFirstBalanceDetail.Name = "gridFirstBalanceDetail";
            this.gridFirstBalanceDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookUpJournalGv});
            this.gridFirstBalanceDetail.Size = new System.Drawing.Size(671, 183);
            this.gridFirstBalanceDetail.TabIndex = 4;
            this.gridFirstBalanceDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFirstBalanceDetail});
            // 
            // gvFirstBalanceDetail
            // 
            this.gvFirstBalanceDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colJournal,
            this.colDebit,
            this.colCredit});
            this.gvFirstBalanceDetail.GridControl = this.gridFirstBalanceDetail;
            this.gvFirstBalanceDetail.Name = "gvFirstBalanceDetail";
            this.gvFirstBalanceDetail.OptionsBehavior.AutoPopulateColumns = false;
            this.gvFirstBalanceDetail.OptionsCustomization.AllowColumnMoving = false;
            this.gvFirstBalanceDetail.OptionsCustomization.AllowFilter = false;
            this.gvFirstBalanceDetail.OptionsCustomization.AllowGroup = false;
            this.gvFirstBalanceDetail.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvFirstBalanceDetail.OptionsView.EnableAppearanceEvenRow = true;
            this.gvFirstBalanceDetail.OptionsView.ShowFooter = true;
            this.gvFirstBalanceDetail.OptionsView.ShowGroupPanel = false;
            this.gvFirstBalanceDetail.OptionsView.ShowViewCaption = true;
            this.gvFirstBalanceDetail.ViewCaption = "Detail Saldo Awal";
            // 
            // colJournal
            // 
            this.colJournal.Caption = "Jurnal";
            this.colJournal.ColumnEdit = this.lookUpJournalGv;
            this.colJournal.FieldName = "JournalId";
            this.colJournal.Name = "colJournal";
            this.colJournal.Visible = true;
            this.colJournal.VisibleIndex = 0;
            // 
            // lookUpJournalGv
            // 
            this.lookUpJournalGv.AutoHeight = false;
            this.lookUpJournalGv.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpJournalGv.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Kode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Nama Akun")});
            this.lookUpJournalGv.DisplayMember = "Name";
            this.lookUpJournalGv.HideSelection = false;
            this.lookUpJournalGv.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookUpJournalGv.Name = "lookUpJournalGv";
            this.lookUpJournalGv.NullText = "-- Pilih Jurnal --";
            this.lookUpJournalGv.ValueMember = "Id";
            // 
            // colDebit
            // 
            this.colDebit.Caption = "Debit";
            this.colDebit.DisplayFormat.FormatString = "{0:#,#}";
            this.colDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDebit.FieldName = "LastDebit";
            this.colDebit.Name = "colDebit";
            this.colDebit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LastDebit", "{0:#,#}")});
            this.colDebit.Visible = true;
            this.colDebit.VisibleIndex = 1;
            // 
            // colCredit
            // 
            this.colCredit.Caption = "Credit";
            this.colCredit.DisplayFormat.FormatString = "{0:#,#}";
            this.colCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCredit.FieldName = "LastCredit";
            this.colCredit.Name = "colCredit";
            this.colCredit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LastCredit", "{0:#,#}")});
            this.colCredit.Visible = true;
            this.colCredit.VisibleIndex = 2;
            // 
            // btnNewDetailData
            // 
            this.btnNewDetailData.Image = ((System.Drawing.Image)(resources.GetObject("btnNewDetailData.Image")));
            this.btnNewDetailData.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewDetailData.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewDetailData.Location = new System.Drawing.Point(5, 23);
            this.btnNewDetailData.Name = "btnNewDetailData";
            this.btnNewDetailData.Size = new System.Drawing.Size(120, 23);
            this.btnNewDetailData.TabIndex = 4;
            this.btnNewDetailData.Text = "Tambah Jurnal";
            this.btnNewDetailData.Click += new System.EventHandler(this.btnNewDetailData_Click);
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDeleteData});
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(136, 26);
            // 
            // cmsDeleteData
            // 
            this.cmsDeleteData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.cmsDeleteData.Name = "cmsDeleteData";
            this.cmsDeleteData.Size = new System.Drawing.Size(135, 22);
            this.cmsDeleteData.Text = "Hapus Data";
            this.cmsDeleteData.Click += new System.EventHandler(this.cmsDeleteData_Click);
            // 
            // FirstBalanceEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 380);
            this.Controls.Add(this.gcFirstBalanceDetailInfo);
            this.Controls.Add(this.gcFirstBalanceInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstBalanceEditorForm";
            this.Text = "Saldo Awal Editor";
            this.Controls.SetChildIndex(this.gcFirstBalanceInfo, 0);
            this.Controls.SetChildIndex(this.gcFirstBalanceDetailInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcFirstBalanceInfo)).EndInit();
            this.gcFirstBalanceInfo.ResumeLayout(false);
            this.gcFirstBalanceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deFirstBalanceDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFirstBalanceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFirstBalanceDetailInfo)).EndInit();
            this.gcFirstBalanceDetailInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFirstBalanceDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFirstBalanceDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpJournalGv)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFirstBalanceInfo;
        private DevExpress.XtraEditors.DateEdit deFirstBalanceDate;
        private DevExpress.XtraEditors.LabelControl lblFirstBalanceDate;
        private DevExpress.XtraEditors.GroupControl gcFirstBalanceDetailInfo;
        private DevExpress.XtraEditors.SimpleButton btnNewDetailData;
        private DevExpress.XtraGrid.GridControl gridFirstBalanceDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFirstBalanceDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colJournal;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpJournalGv;
        private DevExpress.XtraGrid.Columns.GridColumn colDebit;
        private DevExpress.XtraGrid.Columns.GridColumn colCredit;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
    }
}