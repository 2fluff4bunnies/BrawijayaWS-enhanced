namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class MechanicListControl
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
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtFilterMechanicName = new DevExpress.XtraEditors.TextEdit();
            this.lblFilterMechanicName = new DevExpress.XtraEditors.LabelControl();
            this.gridMechanic = new DevExpress.XtraGrid.GridControl();
            this.gvMechanic = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMechanicMechanic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressMechanic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneMechanic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnNewMechanic = new DevExpress.XtraEditors.SimpleButton();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.bgwFingerprint = new System.ComponentModel.BackgroundWorker();
            this.btnExportToCSV = new DevExpress.XtraEditors.SimpleButton();
            this.exportDialog = new System.Windows.Forms.SaveFileDialog();
            this.bgwExport = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterMechanicName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMechanic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMechanic)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.btnExportToCSV);
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.txtFilterMechanicName);
            this.gcFilter.Controls.Add(this.lblFilterMechanicName);
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(709, 62);
            this.gcFilter.TabIndex = 0;
            this.gcFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(501, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFilterMechanicName
            // 
            this.txtFilterMechanicName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterMechanicName.Location = new System.Drawing.Point(128, 30);
            this.txtFilterMechanicName.Name = "txtFilterMechanicName";
            this.txtFilterMechanicName.Size = new System.Drawing.Size(350, 20);
            this.txtFilterMechanicName.TabIndex = 1;
            this.txtFilterMechanicName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilterMechanicName_KeyDown);
            // 
            // lblFilterMechanicName
            // 
            this.lblFilterMechanicName.Location = new System.Drawing.Point(12, 33);
            this.lblFilterMechanicName.Name = "lblFilterMechanicName";
            this.lblFilterMechanicName.Size = new System.Drawing.Size(74, 13);
            this.lblFilterMechanicName.TabIndex = 0;
            this.lblFilterMechanicName.Text = "Nama Mechanic";
            // 
            // gridMechanic
            // 
            this.gridMechanic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridMechanic.Location = new System.Drawing.Point(3, 100);
            this.gridMechanic.MainView = this.gvMechanic;
            this.gridMechanic.Name = "gridMechanic";
            this.gridMechanic.Size = new System.Drawing.Size(709, 224);
            this.gridMechanic.TabIndex = 1;
            this.gridMechanic.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMechanic});
            // 
            // gvMechanic
            // 
            this.gvMechanic.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMechanicMechanic,
            this.colAddressMechanic,
            this.colPhoneMechanic,
            this.gridColumnCode});
            this.gvMechanic.GridControl = this.gridMechanic;
            this.gvMechanic.Name = "gvMechanic";
            this.gvMechanic.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvMechanic.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvMechanic.OptionsBehavior.AutoPopulateColumns = false;
            this.gvMechanic.OptionsBehavior.Editable = false;
            this.gvMechanic.OptionsBehavior.ReadOnly = true;
            this.gvMechanic.OptionsCustomization.AllowColumnMoving = false;
            this.gvMechanic.OptionsCustomization.AllowFilter = false;
            this.gvMechanic.OptionsCustomization.AllowGroup = false;
            this.gvMechanic.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvMechanic.OptionsView.ShowGroupPanel = false;
            this.gvMechanic.OptionsView.ShowViewCaption = true;
            this.gvMechanic.ViewCaption = "Daftar Mechanic";
            // 
            // colMechanicMechanic
            // 
            this.colMechanicMechanic.Caption = "Nama Mechanic";
            this.colMechanicMechanic.FieldName = "Name";
            this.colMechanicMechanic.Name = "colMechanicMechanic";
            this.colMechanicMechanic.Visible = true;
            this.colMechanicMechanic.VisibleIndex = 1;
            // 
            // colAddressMechanic
            // 
            this.colAddressMechanic.Caption = "Alamat";
            this.colAddressMechanic.FieldName = "Address";
            this.colAddressMechanic.Name = "colAddressMechanic";
            this.colAddressMechanic.Visible = true;
            this.colAddressMechanic.VisibleIndex = 2;
            // 
            // colPhoneMechanic
            // 
            this.colPhoneMechanic.Caption = "No. Telp.";
            this.colPhoneMechanic.FieldName = "PhoneNumber";
            this.colPhoneMechanic.Name = "colPhoneMechanic";
            this.colPhoneMechanic.Visible = true;
            this.colPhoneMechanic.VisibleIndex = 3;
            // 
            // gridColumnCode
            // 
            this.gridColumnCode.Caption = "Code";
            this.gridColumnCode.FieldName = "Code";
            this.gridColumnCode.Name = "gridColumnCode";
            this.gridColumnCode.Visible = true;
            this.gridColumnCode.VisibleIndex = 0;
            // 
            // btnNewMechanic
            // 
            this.btnNewMechanic.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.add_mechanic_16x16;
            this.btnNewMechanic.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewMechanic.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewMechanic.Location = new System.Drawing.Point(3, 71);
            this.btnNewMechanic.Name = "btnNewMechanic";
            this.btnNewMechanic.Size = new System.Drawing.Size(144, 23);
            this.btnNewMechanic.TabIndex = 2;
            this.btnNewMechanic.Text = "Buat Mechanic Baru";
            this.btnNewMechanic.Click += new System.EventHandler(this.btnNewMechanic_Click);
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
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // bgwFingerprint
            // 
            this.bgwFingerprint.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwFingerprint_DoWork);
            this.bgwFingerprint.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwFingerprint_RunWorkerCompleted);
            // 
            // btnExportToCSV
            // 
            this.btnExportToCSV.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.export3_16x16;
            this.btnExportToCSV.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnExportToCSV.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExportToCSV.Location = new System.Drawing.Point(576, 27);
            this.btnExportToCSV.Name = "btnExportToCSV";
            this.btnExportToCSV.Size = new System.Drawing.Size(106, 23);
            this.btnExportToCSV.TabIndex = 32;
            this.btnExportToCSV.Text = "Export Data";
            this.btnExportToCSV.Click += new System.EventHandler(this.btnExportToCSV_Click);
            // 
            // exportDialog
            // 
            this.exportDialog.DefaultExt = "csv";
            this.exportDialog.Filter = "CSV (*.csv) | *.csv";
            this.exportDialog.Title = "Export Invoice";
            this.exportDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.exportDialog_FileOk);
            // 
            // bgwExport
            // 
            this.bgwExport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwExport_DoWork);
            this.bgwExport.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwExport_RunWorkerCompleted);
            // 
            // MechanicListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNewMechanic);
            this.Controls.Add(this.gridMechanic);
            this.Controls.Add(this.gcFilter);
            this.Name = "MechanicListControl";
            this.Size = new System.Drawing.Size(715, 327);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterMechanicName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMechanic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMechanic)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtFilterMechanicName;
        private DevExpress.XtraEditors.LabelControl lblFilterMechanicName;
        private DevExpress.XtraGrid.GridControl gridMechanic;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMechanic;
        private DevExpress.XtraEditors.SimpleButton btnNewMechanic;
        private DevExpress.XtraGrid.Columns.GridColumn colNameMechanic;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressMechanic;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneMechanic;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private DevExpress.XtraGrid.Columns.GridColumn colMechanicMechanic;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCode;
        private System.ComponentModel.BackgroundWorker bgwFingerprint;
        private DevExpress.XtraEditors.SimpleButton btnExportToCSV;
        private System.Windows.Forms.SaveFileDialog exportDialog;
        private System.ComponentModel.BackgroundWorker bgwExport;
    }
}
