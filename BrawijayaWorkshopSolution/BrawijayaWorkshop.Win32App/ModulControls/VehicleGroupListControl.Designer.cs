namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class VehicleGroupListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleGroupListControl));
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewVehicleGroup = new DevExpress.XtraEditors.SimpleButton();
            this.gvVehicleGroup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridVehicleGroup = new DevExpress.XtraGrid.GridControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtFilterGroupName = new DevExpress.XtraEditors.TextEdit();
            this.lblFilterGroupName = new DevExpress.XtraEditors.LabelControl();
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.lookupCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCustomerFilter = new DevExpress.XtraEditors.LabelControl();
            this.cmsEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehicleGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterGroupName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCustomer.Properties)).BeginInit();
            this.SuspendLayout();
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
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditData,
            this.cmsDeleteData});
            this.cmsEditor.Name = "cmsListEditor";
            this.cmsEditor.Size = new System.Drawing.Size(136, 48);
            // 
            // cmsDeleteData
            // 
            this.cmsDeleteData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.cmsDeleteData.Name = "cmsDeleteData";
            this.cmsDeleteData.Size = new System.Drawing.Size(135, 22);
            this.cmsDeleteData.Text = "Hapus Data";
            this.cmsDeleteData.Click += new System.EventHandler(this.cmsDeleteData_Click);
            // 
            // btnNewVehicleGroup
            // 
            this.btnNewVehicleGroup.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.add_item_16x16;
            this.btnNewVehicleGroup.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewVehicleGroup.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewVehicleGroup.Location = new System.Drawing.Point(3, 71);
            this.btnNewVehicleGroup.Name = "btnNewVehicleGroup";
            this.btnNewVehicleGroup.Size = new System.Drawing.Size(139, 23);
            this.btnNewVehicleGroup.TabIndex = 1;
            this.btnNewVehicleGroup.Text = "Buat Kelompok Baru";
            this.btnNewVehicleGroup.Click += new System.EventHandler(this.btnNewVehicleGroup_Click);
            // 
            // gvVehicleGroup
            // 
            this.gvVehicleGroup.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerName,
            this.colGroupName});
            this.gvVehicleGroup.GridControl = this.gridVehicleGroup;
            this.gvVehicleGroup.Name = "gvVehicleGroup";
            this.gvVehicleGroup.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvVehicleGroup.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvVehicleGroup.OptionsBehavior.AutoPopulateColumns = false;
            this.gvVehicleGroup.OptionsBehavior.Editable = false;
            this.gvVehicleGroup.OptionsBehavior.ReadOnly = true;
            this.gvVehicleGroup.OptionsCustomization.AllowColumnMoving = false;
            this.gvVehicleGroup.OptionsCustomization.AllowFilter = false;
            this.gvVehicleGroup.OptionsCustomization.AllowGroup = false;
            this.gvVehicleGroup.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvVehicleGroup.OptionsView.EnableAppearanceEvenRow = true;
            this.gvVehicleGroup.OptionsView.ShowGroupPanel = false;
            this.gvVehicleGroup.OptionsView.ShowViewCaption = true;
            this.gvVehicleGroup.ViewCaption = "Daftar Kelompok";
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Nama Perusahaan";
            this.colCustomerName.FieldName = "Customer.CompanyName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 0;
            // 
            // colGroupName
            // 
            this.colGroupName.Caption = "Nama Kelompok";
            this.colGroupName.FieldName = "Name";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.Visible = true;
            this.colGroupName.VisibleIndex = 1;
            // 
            // gridVehicleGroup
            // 
            this.gridVehicleGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVehicleGroup.Location = new System.Drawing.Point(3, 100);
            this.gridVehicleGroup.MainView = this.gvVehicleGroup;
            this.gridVehicleGroup.Name = "gridVehicleGroup";
            this.gridVehicleGroup.Size = new System.Drawing.Size(726, 216);
            this.gridVehicleGroup.TabIndex = 2;
            this.gridVehicleGroup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVehicleGroup});
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(659, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFilterGroupName
            // 
            this.txtFilterGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterGroupName.Location = new System.Drawing.Point(456, 30);
            this.txtFilterGroupName.Name = "txtFilterGroupName";
            this.txtFilterGroupName.Size = new System.Drawing.Size(197, 20);
            this.txtFilterGroupName.TabIndex = 3;
            this.txtFilterGroupName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilterGroupName_KeyDown);
            // 
            // lblFilterGroupName
            // 
            this.lblFilterGroupName.Location = new System.Drawing.Point(375, 33);
            this.lblFilterGroupName.Name = "lblFilterGroupName";
            this.lblFilterGroupName.Size = new System.Drawing.Size(75, 13);
            this.lblFilterGroupName.TabIndex = 2;
            this.lblFilterGroupName.Text = "Nama Kelompok";
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.lookupCustomer);
            this.gcFilter.Controls.Add(this.lblCustomerFilter);
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.txtFilterGroupName);
            this.gcFilter.Controls.Add(this.lblFilterGroupName);
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(726, 62);
            this.gcFilter.TabIndex = 0;
            this.gcFilter.Text = "Filter";
            // 
            // lookupCustomer
            // 
            this.lookupCustomer.Location = new System.Drawing.Point(66, 30);
            this.lookupCustomer.Name = "lookupCustomer";
            this.lookupCustomer.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookupCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupCustomer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Kode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Nama Perusahaan")});
            this.lookupCustomer.Properties.DisplayMember = "CompanyName";
            this.lookupCustomer.Properties.HideSelection = false;
            this.lookupCustomer.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookupCustomer.Properties.NullText = "-- Pilih Customer --";
            this.lookupCustomer.Properties.ValueMember = "Id";
            this.lookupCustomer.Size = new System.Drawing.Size(276, 20);
            this.lookupCustomer.TabIndex = 1;
            // 
            // lblCustomerFilter
            // 
            this.lblCustomerFilter.Location = new System.Drawing.Point(14, 34);
            this.lblCustomerFilter.Name = "lblCustomerFilter";
            this.lblCustomerFilter.Size = new System.Drawing.Size(46, 13);
            this.lblCustomerFilter.TabIndex = 0;
            this.lblCustomerFilter.Text = "Customer";
            // 
            // VehicleGroupListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNewVehicleGroup);
            this.Controls.Add(this.gridVehicleGroup);
            this.Controls.Add(this.gcFilter);
            this.Name = "VehicleGroupListControl";
            this.Size = new System.Drawing.Size(732, 319);
            this.cmsEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehicleGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterGroupName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCustomer.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
        private DevExpress.XtraEditors.SimpleButton btnNewVehicleGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVehicleGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupName;
        private DevExpress.XtraGrid.GridControl gridVehicleGroup;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtFilterGroupName;
        private DevExpress.XtraEditors.LabelControl lblFilterGroupName;
        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.LookUpEdit lookupCustomer;
        private DevExpress.XtraEditors.LabelControl lblCustomerFilter;
    }
}
