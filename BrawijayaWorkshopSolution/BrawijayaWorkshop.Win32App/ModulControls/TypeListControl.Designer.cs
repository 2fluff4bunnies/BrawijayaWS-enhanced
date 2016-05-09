namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class TypeListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypeListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtFilterName = new DevExpress.XtraEditors.TextEdit();
            this.lblFilterName = new DevExpress.XtraEditors.LabelControl();
            this.btnNewType = new DevExpress.XtraEditors.SimpleButton();
            this.gridType = new DevExpress.XtraGrid.GridControl();
            this.gvType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvType)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.txtFilterName);
            this.gcFilter.Controls.Add(this.lblFilterName);
            this.gcFilter.Location = new System.Drawing.Point(3, 2);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(575, 62);
            this.gcFilter.TabIndex = 2;
            this.gcFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(508, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFilterName
            // 
            this.txtFilterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterName.Location = new System.Drawing.Point(69, 30);
            this.txtFilterName.Name = "txtFilterName";
            this.txtFilterName.Size = new System.Drawing.Size(433, 20);
            this.txtFilterName.TabIndex = 1;
            // 
            // lblFilterName
            // 
            this.lblFilterName.Location = new System.Drawing.Point(12, 33);
            this.lblFilterName.Name = "lblFilterName";
            this.lblFilterName.Size = new System.Drawing.Size(27, 13);
            this.lblFilterName.TabIndex = 0;
            this.lblFilterName.Text = "Nama";
            // 
            // btnNewType
            // 
            this.btnNewType.Image = ((System.Drawing.Image)(resources.GetObject("btnNewType.Image")));
            this.btnNewType.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewType.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewType.Location = new System.Drawing.Point(3, 70);
            this.btnNewType.Name = "btnNewType";
            this.btnNewType.Size = new System.Drawing.Size(123, 23);
            this.btnNewType.TabIndex = 4;
            this.btnNewType.Text = "Buat Tipe Baru";
            this.btnNewType.Click += new System.EventHandler(this.btnNewType_Click);
            // 
            // gridType
            // 
            this.gridType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridType.Location = new System.Drawing.Point(3, 102);
            this.gridType.MainView = this.gvType;
            this.gridType.Name = "gridType";
            this.gridType.Size = new System.Drawing.Size(575, 224);
            this.gridType.TabIndex = 5;
            this.gridType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvType});
            // 
            // gvType
            // 
            this.gvType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDescription});
            this.gvType.GridControl = this.gridType;
            this.gvType.Name = "gvType";
            this.gvType.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvType.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvType.OptionsBehavior.AutoPopulateColumns = false;
            this.gvType.OptionsBehavior.Editable = false;
            this.gvType.OptionsBehavior.ReadOnly = true;
            this.gvType.OptionsCustomization.AllowColumnMoving = false;
            this.gvType.OptionsCustomization.AllowFilter = false;
            this.gvType.OptionsCustomization.AllowGroup = false;
            this.gvType.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvType.OptionsView.EnableAppearanceEvenRow = true;
            this.gvType.OptionsView.ShowGroupPanel = false;
            this.gvType.OptionsView.ShowViewCaption = true;
            this.gvType.ViewCaption = "Daftar Tipe";
            this.gvType.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvType_PopupMenuShowing);
            this.gvType.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvType_FocusedRowChanged);
            // 
            // colName
            // 
            this.colName.Caption = "Nama";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Deskripsi";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
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
            // TypeListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridType);
            this.Controls.Add(this.btnNewType);
            this.Controls.Add(this.gcFilter);
            this.Name = "TypeListControl";
            this.Size = new System.Drawing.Size(581, 327);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvType)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtFilterName;
        private DevExpress.XtraEditors.LabelControl lblFilterName;
        private DevExpress.XtraEditors.SimpleButton btnNewType;
        private DevExpress.XtraGrid.GridControl gridType;
        private DevExpress.XtraGrid.Views.Grid.GridView gvType;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
    }
}
