namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class RoleAccessListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleAccessListControl));
            this.btnNewRoleAccess = new DevExpress.XtraEditors.SimpleButton();
            this.gridRoleAccess = new DevExpress.XtraGrid.GridControl();
            this.gvRoleAccess = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colModulName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModulDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRead = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoleAccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoleAccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheckEdit)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewRoleAccess
            // 
            this.btnNewRoleAccess.Image = ((System.Drawing.Image)(resources.GetObject("btnNewRoleAccess.Image")));
            this.btnNewRoleAccess.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewRoleAccess.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewRoleAccess.Location = new System.Drawing.Point(3, 3);
            this.btnNewRoleAccess.Name = "btnNewRoleAccess";
            this.btnNewRoleAccess.Size = new System.Drawing.Size(155, 23);
            this.btnNewRoleAccess.TabIndex = 4;
            this.btnNewRoleAccess.Text = "Tambah Akses Role";
            this.btnNewRoleAccess.Click += new System.EventHandler(this.btnNewRoleAccess_Click);
            // 
            // gridRoleAccess
            // 
            this.gridRoleAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridRoleAccess.Location = new System.Drawing.Point(3, 32);
            this.gridRoleAccess.MainView = this.gvRoleAccess;
            this.gridRoleAccess.Name = "gridRoleAccess";
            this.gridRoleAccess.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoCheckEdit});
            this.gridRoleAccess.Size = new System.Drawing.Size(662, 267);
            this.gridRoleAccess.TabIndex = 5;
            this.gridRoleAccess.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRoleAccess});
            // 
            // gvRoleAccess
            // 
            this.gvRoleAccess.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colModulName,
            this.colRoleName,
            this.colModulDescription,
            this.colRead,
            this.colCreate,
            this.colUpdate,
            this.colDelete});
            this.gvRoleAccess.GridControl = this.gridRoleAccess;
            this.gvRoleAccess.Name = "gvRoleAccess";
            this.gvRoleAccess.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvRoleAccess.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvRoleAccess.OptionsBehavior.AutoPopulateColumns = false;
            this.gvRoleAccess.OptionsBehavior.Editable = false;
            this.gvRoleAccess.OptionsBehavior.ReadOnly = true;
            this.gvRoleAccess.OptionsCustomization.AllowColumnMoving = false;
            this.gvRoleAccess.OptionsCustomization.AllowFilter = false;
            this.gvRoleAccess.OptionsCustomization.AllowGroup = false;
            this.gvRoleAccess.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvRoleAccess.OptionsView.EnableAppearanceEvenRow = true;
            this.gvRoleAccess.OptionsView.ShowGroupPanel = false;
            this.gvRoleAccess.OptionsView.ShowViewCaption = true;
            this.gvRoleAccess.ViewCaption = "Daftar Akses Role";
            // 
            // colModulName
            // 
            this.colModulName.Caption = "Nama Modul";
            this.colModulName.FieldName = "ApplicationModul.ModulName";
            this.colModulName.Name = "colModulName";
            this.colModulName.Visible = true;
            this.colModulName.VisibleIndex = 0;
            // 
            // colRoleName
            // 
            this.colRoleName.Caption = "Role";
            this.colRoleName.FieldName = "Role.Name";
            this.colRoleName.Name = "colRoleName";
            this.colRoleName.Visible = true;
            this.colRoleName.VisibleIndex = 2;
            // 
            // colModulDescription
            // 
            this.colModulDescription.Caption = "Deskripsi Modul";
            this.colModulDescription.FieldName = "ApplicationModul.ModulDescription";
            this.colModulDescription.Name = "colModulDescription";
            this.colModulDescription.Visible = true;
            this.colModulDescription.VisibleIndex = 1;
            // 
            // colRead
            // 
            this.colRead.Caption = "Read";
            this.colRead.ColumnEdit = this.repoCheckEdit;
            this.colRead.Name = "colRead";
            this.colRead.Visible = true;
            this.colRead.VisibleIndex = 3;
            // 
            // repoCheckEdit
            // 
            this.repoCheckEdit.AutoHeight = false;
            this.repoCheckEdit.Name = "repoCheckEdit";
            // 
            // colCreate
            // 
            this.colCreate.Caption = "Create";
            this.colCreate.ColumnEdit = this.repoCheckEdit;
            this.colCreate.Name = "colCreate";
            this.colCreate.Visible = true;
            this.colCreate.VisibleIndex = 4;
            // 
            // colUpdate
            // 
            this.colUpdate.Caption = "Update";
            this.colUpdate.ColumnEdit = this.repoCheckEdit;
            this.colUpdate.Name = "colUpdate";
            this.colUpdate.Visible = true;
            this.colUpdate.VisibleIndex = 5;
            // 
            // colDelete
            // 
            this.colDelete.Caption = "Delete";
            this.colDelete.ColumnEdit = this.repoCheckEdit;
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 6;
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
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(135, 48);
            // 
            // cmsEditData
            // 
            this.cmsEditData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.cmsEditData.Name = "cmsEditData";
            this.cmsEditData.Size = new System.Drawing.Size(134, 22);
            this.cmsEditData.Text = "Ubah Data";
            this.cmsEditData.Click += new System.EventHandler(this.cmsEditData_Click);
            // 
            // cmsDeleteData
            // 
            this.cmsDeleteData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.cmsDeleteData.Name = "cmsDeleteData";
            this.cmsDeleteData.Size = new System.Drawing.Size(134, 22);
            this.cmsDeleteData.Text = "Delete Data";
            this.cmsDeleteData.Click += new System.EventHandler(this.cmsDeleteData_Click);
            // 
            // RoleAccessListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridRoleAccess);
            this.Controls.Add(this.btnNewRoleAccess);
            this.Name = "RoleAccessListControl";
            this.Size = new System.Drawing.Size(668, 302);
            ((System.ComponentModel.ISupportInitialize)(this.gridRoleAccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoleAccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheckEdit)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnNewRoleAccess;
        private DevExpress.XtraGrid.GridControl gridRoleAccess;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRoleAccess;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleName;
        private DevExpress.XtraGrid.Columns.GridColumn colModulName;
        private DevExpress.XtraGrid.Columns.GridColumn colModulDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colRead;
        private DevExpress.XtraGrid.Columns.GridColumn colCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repoCheckEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
    }
}
