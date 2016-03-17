namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class ManualTransactionEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualTransactionEditorForm));
            this.gcTransactionParent = new DevExpress.XtraEditors.GroupControl();
            this.txtTransDesc = new DevExpress.XtraEditors.TextEdit();
            this.txtTransTotal = new DevExpress.XtraEditors.TextEdit();
            this.lblTransTotal = new DevExpress.XtraEditors.LabelControl();
            this.lblTransDesc = new DevExpress.XtraEditors.LabelControl();
            this.deTransDate = new DevExpress.XtraEditors.DateEdit();
            this.lblTransDate = new DevExpress.XtraEditors.LabelControl();
            this.gcTransactionDetail = new DevExpress.XtraEditors.GroupControl();
            this.gridTransactionDetail = new DevExpress.XtraGrid.GridControl();
            this.gvTransactionDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colJournal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpJournalGv = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDebit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnNewTransDetail = new DevExpress.XtraEditors.SimpleButton();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxIsReconciliation = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTransactionParent)).BeginInit();
            this.gcTransactionParent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTransactionDetail)).BeginInit();
            this.gcTransactionDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransactionDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpJournalGv)).BeginInit();
            this.cmsEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxIsReconciliation.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcTransactionParent
            // 
            this.gcTransactionParent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTransactionParent.Controls.Add(this.cbxIsReconciliation);
            this.gcTransactionParent.Controls.Add(this.txtTransDesc);
            this.gcTransactionParent.Controls.Add(this.txtTransTotal);
            this.gcTransactionParent.Controls.Add(this.lblTransTotal);
            this.gcTransactionParent.Controls.Add(this.lblTransDesc);
            this.gcTransactionParent.Controls.Add(this.deTransDate);
            this.gcTransactionParent.Controls.Add(this.lblTransDate);
            this.gcTransactionParent.Location = new System.Drawing.Point(12, 12);
            this.gcTransactionParent.Name = "gcTransactionParent";
            this.gcTransactionParent.Size = new System.Drawing.Size(722, 88);
            this.gcTransactionParent.TabIndex = 1;
            this.gcTransactionParent.Text = "Transaksi";
            // 
            // txtTransDesc
            // 
            this.txtTransDesc.Location = new System.Drawing.Point(98, 55);
            this.txtTransDesc.Name = "txtTransDesc";
            this.txtTransDesc.Size = new System.Drawing.Size(248, 20);
            this.txtTransDesc.TabIndex = 6;
            // 
            // txtTransTotal
            // 
            this.txtTransTotal.Location = new System.Drawing.Point(494, 29);
            this.txtTransTotal.Name = "txtTransTotal";
            this.txtTransTotal.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTransTotal.Properties.Appearance.Options.UseBackColor = true;
            this.txtTransTotal.Properties.DisplayFormat.FormatString = "{0:#,#}";
            this.txtTransTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTransTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTransTotal.Properties.ReadOnly = true;
            this.txtTransTotal.Size = new System.Drawing.Size(216, 20);
            this.txtTransTotal.TabIndex = 5;
            // 
            // lblTransTotal
            // 
            this.lblTransTotal.Location = new System.Drawing.Point(397, 32);
            this.lblTransTotal.Name = "lblTransTotal";
            this.lblTransTotal.Size = new System.Drawing.Size(72, 13);
            this.lblTransTotal.TabIndex = 4;
            this.lblTransTotal.Text = "Total Transaksi";
            // 
            // lblTransDesc
            // 
            this.lblTransDesc.Location = new System.Drawing.Point(12, 58);
            this.lblTransDesc.Name = "lblTransDesc";
            this.lblTransDesc.Size = new System.Drawing.Size(56, 13);
            this.lblTransDesc.TabIndex = 2;
            this.lblTransDesc.Text = "Keterangan";
            // 
            // deTransDate
            // 
            this.deTransDate.EditValue = null;
            this.deTransDate.Location = new System.Drawing.Point(98, 29);
            this.deTransDate.Name = "deTransDate";
            this.deTransDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTransDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTransDate.Properties.DisplayFormat.FormatString = "dd MMM yyyy";
            this.deTransDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deTransDate.Properties.HideSelection = false;
            this.deTransDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deTransDate.Size = new System.Drawing.Size(248, 20);
            this.deTransDate.TabIndex = 1;
            // 
            // lblTransDate
            // 
            this.lblTransDate.Location = new System.Drawing.Point(12, 32);
            this.lblTransDate.Name = "lblTransDate";
            this.lblTransDate.Size = new System.Drawing.Size(66, 13);
            this.lblTransDate.TabIndex = 0;
            this.lblTransDate.Text = "Tgl. Transaksi";
            // 
            // gcTransactionDetail
            // 
            this.gcTransactionDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTransactionDetail.Controls.Add(this.gridTransactionDetail);
            this.gcTransactionDetail.Controls.Add(this.btnNewTransDetail);
            this.gcTransactionDetail.Location = new System.Drawing.Point(12, 106);
            this.gcTransactionDetail.Name = "gcTransactionDetail";
            this.gcTransactionDetail.Size = new System.Drawing.Size(722, 258);
            this.gcTransactionDetail.TabIndex = 2;
            this.gcTransactionDetail.Text = "Detail Transaksi";
            // 
            // gridTransactionDetail
            // 
            this.gridTransactionDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTransactionDetail.Location = new System.Drawing.Point(5, 52);
            this.gridTransactionDetail.MainView = this.gvTransactionDetail;
            this.gridTransactionDetail.Name = "gridTransactionDetail";
            this.gridTransactionDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookUpJournalGv});
            this.gridTransactionDetail.Size = new System.Drawing.Size(712, 201);
            this.gridTransactionDetail.TabIndex = 3;
            this.gridTransactionDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTransactionDetail});
            // 
            // gvTransactionDetail
            // 
            this.gvTransactionDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colJournal,
            this.colDebit,
            this.colCredit});
            this.gvTransactionDetail.GridControl = this.gridTransactionDetail;
            this.gvTransactionDetail.Name = "gvTransactionDetail";
            this.gvTransactionDetail.OptionsBehavior.AutoPopulateColumns = false;
            this.gvTransactionDetail.OptionsCustomization.AllowColumnMoving = false;
            this.gvTransactionDetail.OptionsCustomization.AllowFilter = false;
            this.gvTransactionDetail.OptionsCustomization.AllowGroup = false;
            this.gvTransactionDetail.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvTransactionDetail.OptionsView.EnableAppearanceEvenRow = true;
            this.gvTransactionDetail.OptionsView.ShowFooter = true;
            this.gvTransactionDetail.OptionsView.ShowGroupPanel = false;
            this.gvTransactionDetail.OptionsView.ShowViewCaption = true;
            this.gvTransactionDetail.ViewCaption = "Detail Transaksi";
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
            this.colDebit.FieldName = "Debit";
            this.colDebit.Name = "colDebit";
            this.colDebit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debit", "{0:#,#}")});
            this.colDebit.Visible = true;
            this.colDebit.VisibleIndex = 1;
            // 
            // colCredit
            // 
            this.colCredit.Caption = "Credit";
            this.colCredit.FieldName = "Credit";
            this.colCredit.Name = "colCredit";
            this.colCredit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credit", "{0:#,#}")});
            this.colCredit.Visible = true;
            this.colCredit.VisibleIndex = 2;
            // 
            // btnNewTransDetail
            // 
            this.btnNewTransDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnNewTransDetail.Image")));
            this.btnNewTransDetail.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewTransDetail.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewTransDetail.Location = new System.Drawing.Point(5, 23);
            this.btnNewTransDetail.Name = "btnNewTransDetail";
            this.btnNewTransDetail.Size = new System.Drawing.Size(171, 23);
            this.btnNewTransDetail.TabIndex = 3;
            this.btnNewTransDetail.Text = "Tambah Detail Transaksi";
            this.btnNewTransDetail.Click += new System.EventHandler(this.btnNewTransDetail_Click);
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDeleteData});
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(142, 26);
            // 
            // cmsDeleteData
            // 
            this.cmsDeleteData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.cmsDeleteData.Name = "cmsDeleteData";
            this.cmsDeleteData.Size = new System.Drawing.Size(141, 22);
            this.cmsDeleteData.Text = "Hapus Detail";
            this.cmsDeleteData.Click += new System.EventHandler(this.cmsDeleteData_Click);
            // 
            // cbxIsReconciliation
            // 
            this.cbxIsReconciliation.Location = new System.Drawing.Point(397, 56);
            this.cbxIsReconciliation.Name = "cbxIsReconciliation";
            this.cbxIsReconciliation.Properties.Caption = "Jurnal Penyesuaian";
            this.cbxIsReconciliation.Size = new System.Drawing.Size(134, 19);
            this.cbxIsReconciliation.TabIndex = 7;
            // 
            // ManualTransactionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 419);
            this.Controls.Add(this.gcTransactionDetail);
            this.Controls.Add(this.gcTransactionParent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManualTransactionEditorForm";
            this.Text = "Transaksi Manual Editor";
            this.Controls.SetChildIndex(this.gcTransactionParent, 0);
            this.Controls.SetChildIndex(this.gcTransactionDetail, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcTransactionParent)).EndInit();
            this.gcTransactionParent.ResumeLayout(false);
            this.gcTransactionParent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTransactionDetail)).EndInit();
            this.gcTransactionDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransactionDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpJournalGv)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxIsReconciliation.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcTransactionParent;
        private DevExpress.XtraEditors.GroupControl gcTransactionDetail;
        private DevExpress.XtraEditors.LabelControl lblTransDate;
        private DevExpress.XtraEditors.DateEdit deTransDate;
        private DevExpress.XtraEditors.LabelControl lblTransTotal;
        private DevExpress.XtraEditors.LabelControl lblTransDesc;
        private DevExpress.XtraEditors.SimpleButton btnNewTransDetail;
        private DevExpress.XtraGrid.GridControl gridTransactionDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTransactionDetail;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpJournalGv;
        private DevExpress.XtraGrid.Columns.GridColumn colJournal;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
        private DevExpress.XtraGrid.Columns.GridColumn colDebit;
        private DevExpress.XtraGrid.Columns.GridColumn colCredit;
        private DevExpress.XtraEditors.TextEdit txtTransTotal;
        private DevExpress.XtraEditors.TextEdit txtTransDesc;
        private DevExpress.XtraEditors.CheckEdit cbxIsReconciliation;
    }
}