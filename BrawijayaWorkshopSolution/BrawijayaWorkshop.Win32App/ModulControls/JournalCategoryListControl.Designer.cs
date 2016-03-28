namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class JournalCategoryListControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalCategoryListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.lblParentFilter = new DevExpress.XtraEditors.LabelControl();
            this.gridCatJournal = new DevExpress.XtraGrid.GridControl();
            this.gvCatJournal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colJournalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJournalName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoCheckBox = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnNewChildren = new DevExpress.XtraEditors.SimpleButton();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCatJournal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCatJournal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheckBox)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.lookUpCategory);
            this.gcFilter.Controls.Add(this.lblParentFilter);
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(709, 61);
            this.gcFilter.TabIndex = 0;
            this.gcFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(643, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lookUpCategory
            // 
            this.lookUpCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpCategory.Location = new System.Drawing.Point(103, 30);
            this.lookUpCategory.Name = "lookUpCategory";
            this.lookUpCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Keterangan")});
            this.lookUpCategory.Properties.DisplayMember = "Description";
            this.lookUpCategory.Properties.HideSelection = false;
            this.lookUpCategory.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookUpCategory.Properties.NullText = "-- Pilih Jurnal Kategori --";
            this.lookUpCategory.Properties.ValueMember = "Id";
            this.lookUpCategory.Size = new System.Drawing.Size(534, 20);
            this.lookUpCategory.TabIndex = 1;
            // 
            // lblParentFilter
            // 
            this.lblParentFilter.Location = new System.Drawing.Point(12, 33);
            this.lblParentFilter.Name = "lblParentFilter";
            this.lblParentFilter.Size = new System.Drawing.Size(72, 13);
            this.lblParentFilter.TabIndex = 0;
            this.lblParentFilter.Text = "Kategori Jurnal";
            // 
            // gridCatJournal
            // 
            this.gridCatJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCatJournal.Location = new System.Drawing.Point(3, 99);
            this.gridCatJournal.MainView = this.gvCatJournal;
            this.gridCatJournal.Name = "gridCatJournal";
            this.gridCatJournal.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoCheckBox});
            this.gridCatJournal.Size = new System.Drawing.Size(709, 218);
            this.gridCatJournal.TabIndex = 6;
            this.gridCatJournal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCatJournal});
            // 
            // gvCatJournal
            // 
            this.gvCatJournal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colJournalCode,
            this.colJournalName,
            this.colParent});
            this.gvCatJournal.GridControl = this.gridCatJournal;
            this.gvCatJournal.Name = "gvCatJournal";
            this.gvCatJournal.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCatJournal.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCatJournal.OptionsBehavior.AutoPopulateColumns = false;
            this.gvCatJournal.OptionsBehavior.Editable = false;
            this.gvCatJournal.OptionsBehavior.ReadOnly = true;
            this.gvCatJournal.OptionsCustomization.AllowColumnMoving = false;
            this.gvCatJournal.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvCatJournal.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCatJournal.OptionsView.ShowGroupPanel = false;
            this.gvCatJournal.OptionsView.ShowViewCaption = true;
            this.gvCatJournal.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colJournalCode, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvCatJournal.ViewCaption = "Daftar Akun Jurnal";
            // 
            // colJournalCode
            // 
            this.colJournalCode.Caption = "Kode";
            this.colJournalCode.FieldName = "Value";
            this.colJournalCode.Name = "colJournalCode";
            this.colJournalCode.Visible = true;
            this.colJournalCode.VisibleIndex = 0;
            // 
            // colJournalName
            // 
            this.colJournalName.Caption = "Nama";
            this.colJournalName.FieldName = "Description";
            this.colJournalName.Name = "colJournalName";
            this.colJournalName.Visible = true;
            this.colJournalName.VisibleIndex = 1;
            // 
            // colParent
            // 
            this.colParent.Caption = "Kategori";
            this.colParent.FieldName = "Parent.Description";
            this.colParent.Name = "colParent";
            this.colParent.Visible = true;
            this.colParent.VisibleIndex = 2;
            // 
            // repoCheckBox
            // 
            this.repoCheckBox.AutoHeight = false;
            this.repoCheckBox.Name = "repoCheckBox";
            this.repoCheckBox.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // btnNewChildren
            // 
            this.btnNewChildren.Image = ((System.Drawing.Image)(resources.GetObject("btnNewChildren.Image")));
            this.btnNewChildren.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewChildren.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewChildren.Location = new System.Drawing.Point(3, 70);
            this.btnNewChildren.Name = "btnNewChildren";
            this.btnNewChildren.Size = new System.Drawing.Size(180, 23);
            this.btnNewChildren.TabIndex = 5;
            this.btnNewChildren.Text = "Daftarkan Kategori Akun";
            this.btnNewChildren.Click += new System.EventHandler(this.btnNewChildren_Click);
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // cmsEditData
            // 
            this.cmsEditData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.cmsEditData.Name = "cmsEditData";
            this.cmsEditData.Size = new System.Drawing.Size(135, 22);
            this.cmsEditData.Text = "Ubah Data";
            this.cmsEditData.Click += new System.EventHandler(this.cmsEditData_Click);
            // 
            // cmsDeleteData
            // 
            this.cmsDeleteData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.cmsDeleteData.Name = "cmsDeleteData";
            this.cmsDeleteData.Size = new System.Drawing.Size(135, 22);
            this.cmsDeleteData.Text = "Hapus Data";
            this.cmsDeleteData.Click += new System.EventHandler(this.cmsDeleteData_Click);
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditData,
            this.cmsDeleteData});
            this.cmsEditor.Name = "cmsListEditor";
            this.cmsEditor.Size = new System.Drawing.Size(136, 48);
            // 
            // JournalCategoryListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridCatJournal);
            this.Controls.Add(this.btnNewChildren);
            this.Controls.Add(this.gcFilter);
            this.Name = "JournalCategoryListControl";
            this.Size = new System.Drawing.Size(715, 320);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCatJournal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCatJournal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheckBox)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.LookUpEdit lookUpCategory;
        private DevExpress.XtraEditors.LabelControl lblParentFilter;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraGrid.GridControl gridCatJournal;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCatJournal;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalName;
        private DevExpress.XtraGrid.Columns.GridColumn colParent;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repoCheckBox;
        private DevExpress.XtraEditors.SimpleButton btnNewChildren;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
    }
}
