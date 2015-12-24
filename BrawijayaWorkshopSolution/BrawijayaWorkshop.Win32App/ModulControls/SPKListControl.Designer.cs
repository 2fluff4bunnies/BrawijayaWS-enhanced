namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class SPKListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPKListControl));
            this.groupFilter = new DevExpress.XtraEditors.GroupControl();
            this.dtpDueDate = new DevExpress.XtraEditors.DateEdit();
            this.dtpCreateDate = new DevExpress.XtraEditors.DateEdit();
            this.lblDueDate = new DevExpress.XtraEditors.LabelControl();
            this.lblCreateDate = new DevExpress.XtraEditors.LabelControl();
            this.txtLicenseNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblLicenseNumber = new DevExpress.XtraEditors.LabelControl();
            this.lookUpStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            this.lookUpCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.lblCode = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lblCategory = new DevExpress.XtraEditors.LabelControl();
            this.btnNewSPK = new DevExpress.XtraEditors.SimpleButton();
            this.gcSPK = new DevExpress.XtraGrid.GridControl();
            this.gvSPK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLicenseNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsApproval = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.groupFilter)).BeginInit();
            this.groupFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDueDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDueDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpCreateDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpCreateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSPK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSPK)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupFilter
            // 
            this.groupFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFilter.Controls.Add(this.dtpDueDate);
            this.groupFilter.Controls.Add(this.dtpCreateDate);
            this.groupFilter.Controls.Add(this.lblDueDate);
            this.groupFilter.Controls.Add(this.lblCreateDate);
            this.groupFilter.Controls.Add(this.txtLicenseNumber);
            this.groupFilter.Controls.Add(this.lblLicenseNumber);
            this.groupFilter.Controls.Add(this.lookUpStatus);
            this.groupFilter.Controls.Add(this.lblStatus);
            this.groupFilter.Controls.Add(this.lookUpCategory);
            this.groupFilter.Controls.Add(this.txtCode);
            this.groupFilter.Controls.Add(this.lblCode);
            this.groupFilter.Controls.Add(this.btnSearch);
            this.groupFilter.Controls.Add(this.lblCategory);
            this.groupFilter.Location = new System.Drawing.Point(3, 3);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(853, 88);
            this.groupFilter.TabIndex = 1;
            this.groupFilter.Text = "Filter";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.EditValue = null;
            this.dtpDueDate.Location = new System.Drawing.Point(610, 59);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDueDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDueDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtpDueDate.Size = new System.Drawing.Size(141, 20);
            this.dtpDueDate.TabIndex = 12;
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.EditValue = null;
            this.dtpCreateDate.Location = new System.Drawing.Point(610, 31);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpCreateDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpCreateDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtpCreateDate.Size = new System.Drawing.Size(141, 20);
            this.dtpCreateDate.TabIndex = 11;
            // 
            // lblDueDate
            // 
            this.lblDueDate.Location = new System.Drawing.Point(513, 66);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(61, 13);
            this.lblDueDate.TabIndex = 10;
            this.lblDueDate.Text = "Batas Waktu";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.Location = new System.Drawing.Point(513, 34);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(71, 13);
            this.lblCreateDate.TabIndex = 9;
            this.lblCreateDate.Text = "Tgl Pembuatan";
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Location = new System.Drawing.Point(339, 31);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Size = new System.Drawing.Size(141, 20);
            this.txtLicenseNumber.TabIndex = 8;
            // 
            // lblLicenseNumber
            // 
            this.lblLicenseNumber.Location = new System.Drawing.Point(243, 34);
            this.lblLicenseNumber.Name = "lblLicenseNumber";
            this.lblLicenseNumber.Size = new System.Drawing.Size(76, 13);
            this.lblLicenseNumber.TabIndex = 7;
            this.lblLicenseNumber.Text = "Nopol Kendaran";
            // 
            // lookUpStatus
            // 
            this.lookUpStatus.Location = new System.Drawing.Point(71, 31);
            this.lookUpStatus.Name = "lookUpStatus";
            this.lookUpStatus.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Status")});
            this.lookUpStatus.Properties.DisplayMember = "Description";
            this.lookUpStatus.Properties.HideSelection = false;
            this.lookUpStatus.Properties.NullText = "-- Status --";
            this.lookUpStatus.Properties.ValueMember = "Status";
            this.lookUpStatus.Size = new System.Drawing.Size(141, 20);
            this.lookUpStatus.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(13, 34);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(31, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // lookUpCategory
            // 
            this.lookUpCategory.Location = new System.Drawing.Point(71, 63);
            this.lookUpCategory.Name = "lookUpCategory";
            this.lookUpCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookUpCategory.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Kategori")});
            this.lookUpCategory.Properties.DisplayMember = "Name";
            this.lookUpCategory.Properties.HideSelection = false;
            this.lookUpCategory.Properties.NullText = "-- Kategori --";
            this.lookUpCategory.Properties.ValueMember = "Id";
            this.lookUpCategory.Size = new System.Drawing.Size(141, 20);
            this.lookUpCategory.TabIndex = 1;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(339, 61);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(141, 20);
            this.txtCode.TabIndex = 3;
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(243, 64);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(45, 13);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Kode SPK";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(768, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 55);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(13, 66);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(40, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // btnNewSPK
            // 
            this.btnNewSPK.Image = ((System.Drawing.Image)(resources.GetObject("btnNewSPK.Image")));
            this.btnNewSPK.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewSPK.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewSPK.Location = new System.Drawing.Point(3, 97);
            this.btnNewSPK.Name = "btnNewSPK";
            this.btnNewSPK.Size = new System.Drawing.Size(103, 23);
            this.btnNewSPK.TabIndex = 4;
            this.btnNewSPK.Text = "Buat SPK Baru";
            this.btnNewSPK.Click += new System.EventHandler(this.btnNewSPK_Click);
            // 
            // gcSPK
            // 
            this.gcSPK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSPK.Location = new System.Drawing.Point(3, 126);
            this.gcSPK.MainView = this.gvSPK;
            this.gcSPK.Name = "gcSPK";
            this.gcSPK.Size = new System.Drawing.Size(853, 232);
            this.gcSPK.TabIndex = 5;
            this.gcSPK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSPK});
            // 
            // gvSPK
            // 
            this.gvSPK.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colCreateDate,
            this.colDueDate,
            this.colLicenseNumber,
            this.colCategory});
            this.gvSPK.GridControl = this.gcSPK;
            this.gvSPK.Name = "gvSPK";
            this.gvSPK.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSPK.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSPK.OptionsBehavior.AutoPopulateColumns = false;
            this.gvSPK.OptionsBehavior.Editable = false;
            this.gvSPK.OptionsBehavior.ReadOnly = true;
            this.gvSPK.OptionsCustomization.AllowColumnMoving = false;
            this.gvSPK.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvSPK.OptionsMenu.EnableFooterMenu = false;
            this.gvSPK.OptionsView.ShowDetailButtons = false;
            this.gvSPK.OptionsView.ShowFooter = true;
            this.gvSPK.OptionsView.ShowGroupPanel = false;
            this.gvSPK.OptionsView.ShowViewCaption = true;
            this.gvSPK.ViewCaption = "Daftar SPK";
            // 
            // colCode
            // 
            this.colCode.Caption = "Kode";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // colCreateDate
            // 
            this.colCreateDate.Caption = "Tgl Pembuatan";
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 1;
            // 
            // colDueDate
            // 
            this.colDueDate.Caption = "Batas Waktu";
            this.colDueDate.FieldName = "DueDate";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.Visible = true;
            this.colDueDate.VisibleIndex = 2;
            // 
            // colLicenseNumber
            // 
            this.colLicenseNumber.Caption = "Nopol";
            this.colLicenseNumber.FieldName = "Vehicle.ActiveLicenseNumber";
            this.colLicenseNumber.Name = "colLicenseNumber";
            this.colLicenseNumber.Visible = true;
            this.colLicenseNumber.VisibleIndex = 3;
            // 
            // colCategory
            // 
            this.colCategory.Caption = "Kategori";
            this.colCategory.FieldName = "CategoryReference.Name";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 4;
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDetailToolStripMenuItem,
            this.toolStripSeparator1,
            this.cmsEditData,
            this.cmsDeleteData,
            this.cmsApproval});
            this.cmsEditor.Name = "cmsListEditor";
            this.cmsEditor.Size = new System.Drawing.Size(136, 98);
            // 
            // viewDetailToolStripMenuItem
            // 
            this.viewDetailToolStripMenuItem.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.zoom_icon;
            this.viewDetailToolStripMenuItem.Name = "viewDetailToolStripMenuItem";
            this.viewDetailToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.viewDetailToolStripMenuItem.Text = "Lihat Detail";
            this.viewDetailToolStripMenuItem.Click += new System.EventHandler(this.viewDetailToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // cmsEditData
            // 
            this.cmsEditData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.cmsEditData.Name = "cmsEditData";
            this.cmsEditData.Size = new System.Drawing.Size(135, 22);
            this.cmsEditData.Text = "Ubah Data";
            // 
            // cmsDeleteData
            // 
            this.cmsDeleteData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.cmsDeleteData.Name = "cmsDeleteData";
            this.cmsDeleteData.Size = new System.Drawing.Size(135, 22);
            this.cmsDeleteData.Text = "Hapus Data";
            // 
            // cmsApproval
            // 
            this.cmsApproval.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.apply_32x32;
            this.cmsApproval.Name = "cmsApproval";
            this.cmsApproval.Size = new System.Drawing.Size(135, 22);
            this.cmsApproval.Text = "Approval";
            this.cmsApproval.Click += new System.EventHandler(this.cmsApproval_Click);
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // SPKListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcSPK);
            this.Controls.Add(this.btnNewSPK);
            this.Controls.Add(this.groupFilter);
            this.Name = "SPKListControl";
            this.Size = new System.Drawing.Size(859, 361);
            ((System.ComponentModel.ISupportInitialize)(this.groupFilter)).EndInit();
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDueDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDueDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpCreateDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpCreateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSPK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSPK)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupFilter;
        private DevExpress.XtraEditors.LookUpEdit lookUpCategory;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl lblCode;
        private DevExpress.XtraEditors.LabelControl lblCategory;
        private DevExpress.XtraEditors.SimpleButton btnNewSPK;
        private DevExpress.XtraGrid.GridControl gcSPK;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSPK;
        private DevExpress.XtraEditors.DateEdit dtpDueDate;
        private DevExpress.XtraEditors.DateEdit dtpCreateDate;
        private DevExpress.XtraEditors.LabelControl lblDueDate;
        private DevExpress.XtraEditors.LabelControl lblCreateDate;
        private DevExpress.XtraEditors.TextEdit txtLicenseNumber;
        private DevExpress.XtraEditors.LabelControl lblLicenseNumber;
        private DevExpress.XtraEditors.LookUpEdit lookUpStatus;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLicenseNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem viewDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.ToolStripMenuItem cmsApproval;
    }
}
