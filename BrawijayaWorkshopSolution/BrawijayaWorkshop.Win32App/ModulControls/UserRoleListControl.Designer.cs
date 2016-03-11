namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class UserRoleListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRoleListControl));
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpRole = new DevExpress.XtraEditors.LookUpEdit();
            this.lblRole = new DevExpress.XtraEditors.LabelControl();
            this.btnNewUserRole = new DevExpress.XtraEditors.SimpleButton();
            this.gridUserRole = new DevExpress.XtraGrid.GridControl();
            this.gvUserRole = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cmsEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheckEdit)).BeginInit();
            this.SuspendLayout();
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
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.lookUpRole);
            this.gcFilter.Controls.Add(this.lblRole);
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(741, 62);
            this.gcFilter.TabIndex = 1;
            this.gcFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(216, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lookUpRole
            // 
            this.lookUpRole.Location = new System.Drawing.Point(55, 30);
            this.lookUpRole.Name = "lookUpRole";
            this.lookUpRole.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpRole.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Role")});
            this.lookUpRole.Properties.DisplayMember = "Name";
            this.lookUpRole.Properties.HideSelection = false;
            this.lookUpRole.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookUpRole.Properties.NullText = "-- Pilih Role --";
            this.lookUpRole.Properties.ValueMember = "Id";
            this.lookUpRole.Size = new System.Drawing.Size(155, 20);
            this.lookUpRole.TabIndex = 1;
            // 
            // lblRole
            // 
            this.lblRole.Location = new System.Drawing.Point(13, 33);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(21, 13);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Role";
            // 
            // btnNewUserRole
            // 
            this.btnNewUserRole.Image = ((System.Drawing.Image)(resources.GetObject("btnNewUserRole.Image")));
            this.btnNewUserRole.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewUserRole.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewUserRole.Location = new System.Drawing.Point(3, 71);
            this.btnNewUserRole.Name = "btnNewUserRole";
            this.btnNewUserRole.Size = new System.Drawing.Size(144, 23);
            this.btnNewUserRole.TabIndex = 3;
            this.btnNewUserRole.Text = "Buat User Role Baru";
            this.btnNewUserRole.Click += new System.EventHandler(this.btnNewUserRole_Click);
            // 
            // gridUserRole
            // 
            this.gridUserRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUserRole.Location = new System.Drawing.Point(3, 100);
            this.gridUserRole.MainView = this.gvUserRole;
            this.gridUserRole.Name = "gridUserRole";
            this.gridUserRole.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoCheckEdit});
            this.gridUserRole.Size = new System.Drawing.Size(741, 218);
            this.gridUserRole.TabIndex = 6;
            this.gridUserRole.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUserRole});
            // 
            // gvUserRole
            // 
            this.gvUserRole.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFirstName,
            this.colLastName,
            this.colUserName,
            this.colRole,
            this.colIsActive});
            this.gvUserRole.GridControl = this.gridUserRole;
            this.gvUserRole.Name = "gvUserRole";
            this.gvUserRole.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvUserRole.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvUserRole.OptionsBehavior.AutoPopulateColumns = false;
            this.gvUserRole.OptionsBehavior.Editable = false;
            this.gvUserRole.OptionsBehavior.ReadOnly = true;
            this.gvUserRole.OptionsCustomization.AllowColumnMoving = false;
            this.gvUserRole.OptionsCustomization.AllowFilter = false;
            this.gvUserRole.OptionsCustomization.AllowGroup = false;
            this.gvUserRole.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvUserRole.OptionsView.EnableAppearanceEvenRow = true;
            this.gvUserRole.OptionsView.ShowGroupPanel = false;
            this.gvUserRole.OptionsView.ShowViewCaption = true;
            this.gvUserRole.ViewCaption = "Daftar User Role";
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "Nama Depan";
            this.colFirstName.FieldName = "User.FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 0;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Nama Belakang";
            this.colLastName.FieldName = "User.LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 1;
            // 
            // colUserName
            // 
            this.colUserName.Caption = "Username";
            this.colUserName.FieldName = "User.UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 2;
            // 
            // colRole
            // 
            this.colRole.Caption = "Role";
            this.colRole.FieldName = "Role.Name";
            this.colRole.Name = "colRole";
            this.colRole.Visible = true;
            this.colRole.VisibleIndex = 3;
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "Aktif";
            this.colIsActive.ColumnEdit = this.repoCheckEdit;
            this.colIsActive.FieldName = "User.IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 4;
            // 
            // repoCheckEdit
            // 
            this.repoCheckEdit.AutoHeight = false;
            this.repoCheckEdit.Name = "repoCheckEdit";
            // 
            // UserRoleListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridUserRole);
            this.Controls.Add(this.btnNewUserRole);
            this.Controls.Add(this.gcFilter);
            this.Name = "UserRoleListControl";
            this.Size = new System.Drawing.Size(747, 321);
            this.cmsEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheckEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.LabelControl lblRole;
        private DevExpress.XtraEditors.LookUpEdit lookUpRole;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnNewUserRole;
        private DevExpress.XtraGrid.GridControl gridUserRole;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUserRole;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colRole;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repoCheckEdit;
    }
}
