namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class JournalMasterListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalMasterListControl));
            this.groupFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtJournalName = new DevExpress.XtraEditors.TextEdit();
            this.lblJournalName = new DevExpress.XtraEditors.LabelControl();
            this.lookupJournalParent = new DevExpress.XtraEditors.LookUpEdit();
            this.lblParent = new DevExpress.XtraEditors.LabelControl();
            this.btnNewJournal = new DevExpress.XtraEditors.SimpleButton();
            this.gridJournalMaster = new DevExpress.XtraGrid.GridControl();
            this.gvJournalMaster = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colJournalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJournalName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupFilter)).BeginInit();
            this.groupFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtJournalName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupJournalParent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridJournalMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvJournalMaster)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupFilter
            // 
            this.groupFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFilter.Controls.Add(this.btnSearch);
            this.groupFilter.Controls.Add(this.txtJournalName);
            this.groupFilter.Controls.Add(this.lblJournalName);
            this.groupFilter.Controls.Add(this.lookupJournalParent);
            this.groupFilter.Controls.Add(this.lblParent);
            this.groupFilter.Location = new System.Drawing.Point(3, 3);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(774, 60);
            this.groupFilter.TabIndex = 0;
            this.groupFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(714, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtJournalName
            // 
            this.txtJournalName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJournalName.Location = new System.Drawing.Point(456, 29);
            this.txtJournalName.Name = "txtJournalName";
            this.txtJournalName.Size = new System.Drawing.Size(252, 20);
            this.txtJournalName.TabIndex = 3;
            this.txtJournalName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJournalName_KeyDown);
            // 
            // lblJournalName
            // 
            this.lblJournalName.Location = new System.Drawing.Point(381, 32);
            this.lblJournalName.Name = "lblJournalName";
            this.lblJournalName.Size = new System.Drawing.Size(69, 13);
            this.lblJournalName.TabIndex = 2;
            this.lblJournalName.Text = "Nama Account";
            // 
            // lookupJournalParent
            // 
            this.lookupJournalParent.Location = new System.Drawing.Point(87, 29);
            this.lookupJournalParent.Name = "lookupJournalParent";
            this.lookupJournalParent.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookupJournalParent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupJournalParent.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Kode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Nama")});
            this.lookupJournalParent.Properties.DisplayMember = "Name";
            this.lookupJournalParent.Properties.HideSelection = false;
            this.lookupJournalParent.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookupJournalParent.Properties.NullText = "-- Induk Account --";
            this.lookupJournalParent.Properties.ValueMember = "Id";
            this.lookupJournalParent.Size = new System.Drawing.Size(259, 20);
            this.lookupJournalParent.TabIndex = 1;
            // 
            // lblParent
            // 
            this.lblParent.Location = new System.Drawing.Point(12, 32);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(69, 13);
            this.lblParent.TabIndex = 0;
            this.lblParent.Text = "Induk Account";
            // 
            // btnNewJournal
            // 
            this.btnNewJournal.Image = ((System.Drawing.Image)(resources.GetObject("btnNewJournal.Image")));
            this.btnNewJournal.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewJournal.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewJournal.Location = new System.Drawing.Point(3, 69);
            this.btnNewJournal.Name = "btnNewJournal";
            this.btnNewJournal.Size = new System.Drawing.Size(124, 23);
            this.btnNewJournal.TabIndex = 3;
            this.btnNewJournal.Text = "Buat Account Baru";
            this.btnNewJournal.Click += new System.EventHandler(this.btnNewJournal_Click);
            // 
            // gridJournalMaster
            // 
            this.gridJournalMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridJournalMaster.Location = new System.Drawing.Point(3, 98);
            this.gridJournalMaster.MainView = this.gvJournalMaster;
            this.gridJournalMaster.Name = "gridJournalMaster";
            this.gridJournalMaster.Size = new System.Drawing.Size(774, 303);
            this.gridJournalMaster.TabIndex = 4;
            this.gridJournalMaster.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvJournalMaster});
            // 
            // gvJournalMaster
            // 
            this.gvJournalMaster.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colJournalCode,
            this.colJournalName,
            this.colParent});
            this.gvJournalMaster.GridControl = this.gridJournalMaster;
            this.gvJournalMaster.Name = "gvJournalMaster";
            this.gvJournalMaster.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvJournalMaster.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvJournalMaster.OptionsBehavior.AutoPopulateColumns = false;
            this.gvJournalMaster.OptionsBehavior.Editable = false;
            this.gvJournalMaster.OptionsBehavior.ReadOnly = true;
            this.gvJournalMaster.OptionsCustomization.AllowColumnMoving = false;
            this.gvJournalMaster.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvJournalMaster.OptionsView.EnableAppearanceEvenRow = true;
            this.gvJournalMaster.OptionsView.ShowGroupPanel = false;
            this.gvJournalMaster.OptionsView.ShowViewCaption = true;
            this.gvJournalMaster.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colJournalCode, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvJournalMaster.ViewCaption = "Daftar Account";
            // 
            // colJournalCode
            // 
            this.colJournalCode.Caption = "Kode";
            this.colJournalCode.FieldName = "Code";
            this.colJournalCode.Name = "colJournalCode";
            this.colJournalCode.Visible = true;
            this.colJournalCode.VisibleIndex = 0;
            // 
            // colJournalName
            // 
            this.colJournalName.Caption = "Nama";
            this.colJournalName.FieldName = "Name";
            this.colJournalName.Name = "colJournalName";
            this.colJournalName.Visible = true;
            this.colJournalName.VisibleIndex = 1;
            // 
            // colParent
            // 
            this.colParent.Caption = "Induk";
            this.colParent.FieldName = "Parent.Code";
            this.colParent.Name = "colParent";
            this.colParent.Visible = true;
            this.colParent.VisibleIndex = 2;
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditData,
            this.cmsDeleteData});
            this.cmsEditor.Name = "cmsListEditor";
            this.cmsEditor.Size = new System.Drawing.Size(136, 48);
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
            // JournalMasterListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridJournalMaster);
            this.Controls.Add(this.btnNewJournal);
            this.Controls.Add(this.groupFilter);
            this.Name = "JournalMasterListControl";
            this.Size = new System.Drawing.Size(780, 404);
            ((System.ComponentModel.ISupportInitialize)(this.groupFilter)).EndInit();
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtJournalName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupJournalParent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridJournalMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvJournalMaster)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupFilter;
        private DevExpress.XtraEditors.SimpleButton btnNewJournal;
        private DevExpress.XtraEditors.LookUpEdit lookupJournalParent;
        private DevExpress.XtraEditors.LabelControl lblParent;
        private DevExpress.XtraEditors.TextEdit txtJournalName;
        private DevExpress.XtraEditors.LabelControl lblJournalName;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraGrid.GridControl gridJournalMaster;
        private DevExpress.XtraGrid.Views.Grid.GridView gvJournalMaster;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalName;
        private DevExpress.XtraGrid.Columns.GridColumn colParent;
    }
}
