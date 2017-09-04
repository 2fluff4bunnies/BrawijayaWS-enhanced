namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class BrandListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnExportToCSV = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtFilterName = new DevExpress.XtraEditors.TextEdit();
            this.lblFilterName = new DevExpress.XtraEditors.LabelControl();
            this.btnNewBrand = new DevExpress.XtraEditors.SimpleButton();
            this.gridBrand = new DevExpress.XtraGrid.GridControl();
            this.gvBrand = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwExport = new System.ComponentModel.BackgroundWorker();
            this.exportDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBrand)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.btnExportToCSV);
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.txtFilterName);
            this.gcFilter.Controls.Add(this.lblFilterName);
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(660, 62);
            this.gcFilter.TabIndex = 1;
            this.gcFilter.Text = "Filter";
            // 
            // btnExportToCSV
            // 
            this.btnExportToCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToCSV.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.export3_16x16;
            this.btnExportToCSV.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnExportToCSV.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExportToCSV.Location = new System.Drawing.Point(549, 27);
            this.btnExportToCSV.Name = "btnExportToCSV";
            this.btnExportToCSV.Size = new System.Drawing.Size(106, 23);
            this.btnExportToCSV.TabIndex = 32;
            this.btnExportToCSV.Text = "Export Data";
            this.btnExportToCSV.Click += new System.EventHandler(this.btnExportToCSV_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(470, 27);
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
            this.txtFilterName.Location = new System.Drawing.Point(63, 30);
            this.txtFilterName.Name = "txtFilterName";
            this.txtFilterName.Size = new System.Drawing.Size(401, 20);
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
            // btnNewBrand
            // 
            this.btnNewBrand.Image = ((System.Drawing.Image)(resources.GetObject("btnNewBrand.Image")));
            this.btnNewBrand.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewBrand.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewBrand.Location = new System.Drawing.Point(3, 71);
            this.btnNewBrand.Name = "btnNewBrand";
            this.btnNewBrand.Size = new System.Drawing.Size(123, 23);
            this.btnNewBrand.TabIndex = 3;
            this.btnNewBrand.Text = "Buat Brand Baru";
            this.btnNewBrand.Click += new System.EventHandler(this.btnNewBrand_Click);
            // 
            // gridBrand
            // 
            this.gridBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBrand.Location = new System.Drawing.Point(3, 100);
            this.gridBrand.MainView = this.gvBrand;
            this.gridBrand.Name = "gridBrand";
            this.gridBrand.Size = new System.Drawing.Size(660, 224);
            this.gridBrand.TabIndex = 4;
            this.gridBrand.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBrand});
            // 
            // gvBrand
            // 
            this.gvBrand.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDescription});
            this.gvBrand.GridControl = this.gridBrand;
            this.gvBrand.Name = "gvBrand";
            this.gvBrand.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvBrand.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvBrand.OptionsBehavior.AutoPopulateColumns = false;
            this.gvBrand.OptionsBehavior.Editable = false;
            this.gvBrand.OptionsBehavior.ReadOnly = true;
            this.gvBrand.OptionsCustomization.AllowColumnMoving = false;
            this.gvBrand.OptionsCustomization.AllowFilter = false;
            this.gvBrand.OptionsCustomization.AllowGroup = false;
            this.gvBrand.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvBrand.OptionsView.EnableAppearanceEvenRow = true;
            this.gvBrand.OptionsView.ShowGroupPanel = false;
            this.gvBrand.OptionsView.ShowViewCaption = true;
            this.gvBrand.ViewCaption = "Daftar Brand";
            this.gvBrand.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvBrand_PopupMenuShowing);
            this.gvBrand.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvBrand_FocusedRowChanged);
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
            // bgwExport
            // 
            this.bgwExport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwExport_DoWork);
            this.bgwExport.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwExport_RunWorkerCompleted);
            // 
            // exportDialog
            // 
            this.exportDialog.DefaultExt = "csv";
            this.exportDialog.Filter = "CSV (*.csv) | *.csv";
            this.exportDialog.Title = "Export Invoice";
            this.exportDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.exportDialog_FileOk);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.print_16x161;
            this.btnPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnPrint.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnPrint.Location = new System.Drawing.Point(552, 71);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(106, 23);
            this.btnPrint.TabIndex = 34;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // BrandListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gridBrand);
            this.Controls.Add(this.btnNewBrand);
            this.Controls.Add(this.gcFilter);
            this.Name = "BrandListControl";
            this.Size = new System.Drawing.Size(666, 327);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBrand)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtFilterName;
        private DevExpress.XtraEditors.LabelControl lblFilterName;
        private DevExpress.XtraEditors.SimpleButton btnNewBrand;
        private DevExpress.XtraGrid.GridControl gridBrand;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
        private DevExpress.XtraEditors.SimpleButton btnExportToCSV;
        private System.ComponentModel.BackgroundWorker bgwExport;
        private System.Windows.Forms.SaveFileDialog exportDialog;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
    }
}
