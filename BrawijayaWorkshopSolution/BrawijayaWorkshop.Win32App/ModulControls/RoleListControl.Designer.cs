namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class RoleListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtFilterRole = new DevExpress.XtraEditors.TextEdit();
            this.lblFilterRoleName = new DevExpress.XtraEditors.LabelControl();
            this.btnNewRole = new DevExpress.XtraEditors.SimpleButton();
            this.gridRole = new DevExpress.XtraGrid.GridControl();
            this.gvRole = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRole)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.txtFilterRole);
            this.gcFilter.Controls.Add(this.lblFilterRoleName);
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(561, 62);
            this.gcFilter.TabIndex = 1;
            this.gcFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(494, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFilterRole
            // 
            this.txtFilterRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterRole.Location = new System.Drawing.Point(64, 30);
            this.txtFilterRole.Name = "txtFilterRole";
            this.txtFilterRole.Size = new System.Drawing.Size(424, 20);
            this.txtFilterRole.TabIndex = 1;
            // 
            // lblFilterRoleName
            // 
            this.lblFilterRoleName.Location = new System.Drawing.Point(12, 33);
            this.lblFilterRoleName.Name = "lblFilterRoleName";
            this.lblFilterRoleName.Size = new System.Drawing.Size(21, 13);
            this.lblFilterRoleName.TabIndex = 0;
            this.lblFilterRoleName.Text = "Role";
            // 
            // btnNewRole
            // 
            this.btnNewRole.Image = ((System.Drawing.Image)(resources.GetObject("btnNewRole.Image")));
            this.btnNewRole.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewRole.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewRole.Location = new System.Drawing.Point(3, 71);
            this.btnNewRole.Name = "btnNewRole";
            this.btnNewRole.Size = new System.Drawing.Size(120, 23);
            this.btnNewRole.TabIndex = 3;
            this.btnNewRole.Text = "Buat Role Baru";
            this.btnNewRole.Click += new System.EventHandler(this.btnNewRole_Click);
            // 
            // gridRole
            // 
            this.gridRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridRole.Location = new System.Drawing.Point(3, 100);
            this.gridRole.MainView = this.gvRole;
            this.gridRole.Name = "gridRole";
            this.gridRole.Size = new System.Drawing.Size(561, 149);
            this.gridRole.TabIndex = 4;
            this.gridRole.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRole});
            // 
            // gvRole
            // 
            this.gvRole.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRoleName});
            this.gvRole.GridControl = this.gridRole;
            this.gvRole.Name = "gvRole";
            this.gvRole.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvRole.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvRole.OptionsBehavior.AutoPopulateColumns = false;
            this.gvRole.OptionsBehavior.Editable = false;
            this.gvRole.OptionsBehavior.ReadOnly = true;
            this.gvRole.OptionsCustomization.AllowColumnMoving = false;
            this.gvRole.OptionsCustomization.AllowFilter = false;
            this.gvRole.OptionsCustomization.AllowGroup = false;
            this.gvRole.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvRole.OptionsView.EnableAppearanceEvenRow = true;
            this.gvRole.OptionsView.ShowGroupPanel = false;
            this.gvRole.OptionsView.ShowViewCaption = true;
            this.gvRole.ViewCaption = "Daftar Role";
            // 
            // colRoleName
            // 
            this.colRoleName.Caption = "Role";
            this.colRoleName.FieldName = "Name";
            this.colRoleName.Name = "colRoleName";
            this.colRoleName.Visible = true;
            this.colRoleName.VisibleIndex = 0;
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditData,
            this.cmsDeleteData});
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(153, 70);
            // 
            // cmsEditData
            // 
            this.cmsEditData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.cmsEditData.Name = "cmsEditData";
            this.cmsEditData.Size = new System.Drawing.Size(152, 22);
            this.cmsEditData.Text = "Ubah Data";
            this.cmsEditData.Click += new System.EventHandler(this.cmsEditData_Click);
            // 
            // cmsDeleteData
            // 
            this.cmsDeleteData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.cmsDeleteData.Name = "cmsDeleteData";
            this.cmsDeleteData.Size = new System.Drawing.Size(152, 22);
            this.cmsDeleteData.Text = "Hapus Data";
            this.cmsDeleteData.Click += new System.EventHandler(this.cmsDeleteData_Click);
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // RoleListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridRole);
            this.Controls.Add(this.btnNewRole);
            this.Controls.Add(this.gcFilter);
            this.Name = "RoleListControl";
            this.Size = new System.Drawing.Size(567, 252);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRole)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtFilterRole;
        private DevExpress.XtraEditors.LabelControl lblFilterRoleName;
        private DevExpress.XtraEditors.SimpleButton btnNewRole;
        private DevExpress.XtraGrid.GridControl gridRole;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRole;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleName;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
        private System.ComponentModel.BackgroundWorker bgwMain;
    }
}
