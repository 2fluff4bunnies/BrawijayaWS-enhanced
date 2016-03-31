namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class SPKScheduleListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPKScheduleListControl));
            this.groupFilter = new DevExpress.XtraEditors.GroupControl();
            this.dteCreatedDate = new DevExpress.XtraEditors.DateEdit();
            this.lblCreatedDate = new DevExpress.XtraEditors.LabelControl();
            this.lookUpSPKVehicle = new DevExpress.XtraEditors.LookUpEdit();
            this.lblSPKVehicle = new DevExpress.XtraEditors.LabelControl();
            this.lookUpMechanic = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lblMechanic = new DevExpress.XtraEditors.LabelControl();
            this.btnNewSPKSchedule = new DevExpress.XtraEditors.SimpleButton();
            this.gcSPKSchedule = new DevExpress.XtraGrid.GridControl();
            this.gvSPKSchedule = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMechanic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPKVehicle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.groupFilter)).BeginInit();
            this.groupFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteCreatedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteCreatedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSPKVehicle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMechanic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSPKSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSPKSchedule)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupFilter
            // 
            this.groupFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFilter.Controls.Add(this.dteCreatedDate);
            this.groupFilter.Controls.Add(this.lblCreatedDate);
            this.groupFilter.Controls.Add(this.lookUpSPKVehicle);
            this.groupFilter.Controls.Add(this.lblSPKVehicle);
            this.groupFilter.Controls.Add(this.lookUpMechanic);
            this.groupFilter.Controls.Add(this.btnSearch);
            this.groupFilter.Controls.Add(this.lblMechanic);
            this.groupFilter.Location = new System.Drawing.Point(3, 3);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(752, 88);
            this.groupFilter.TabIndex = 2;
            this.groupFilter.Text = "Filter";
            // 
            // dteCreatedDate
            // 
            this.dteCreatedDate.EditValue = null;
            this.dteCreatedDate.Location = new System.Drawing.Point(332, 23);
            this.dteCreatedDate.Name = "dteCreatedDate";
            this.dteCreatedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteCreatedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteCreatedDate.Size = new System.Drawing.Size(141, 20);
            this.dteCreatedDate.TabIndex = 17;
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.Location = new System.Drawing.Point(274, 26);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(38, 13);
            this.lblCreatedDate.TabIndex = 16;
            this.lblCreatedDate.Text = "Tanggal";
            // 
            // lookUpSPKVehicle
            // 
            this.lookUpSPKVehicle.Location = new System.Drawing.Point(111, 55);
            this.lookUpSPKVehicle.Name = "lookUpSPKVehicle";
            this.lookUpSPKVehicle.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpSPKVehicle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpSPKVehicle.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Status")});
            this.lookUpSPKVehicle.Properties.DisplayMember = "Description";
            this.lookUpSPKVehicle.Properties.HideSelection = false;
            this.lookUpSPKVehicle.Properties.NullText = "-- Pilih Kendaraan --";
            this.lookUpSPKVehicle.Properties.ValueMember = "Status";
            this.lookUpSPKVehicle.Size = new System.Drawing.Size(141, 20);
            this.lookUpSPKVehicle.TabIndex = 6;
            // 
            // lblSPKVehicle
            // 
            this.lblSPKVehicle.Location = new System.Drawing.Point(11, 58);
            this.lblSPKVehicle.Name = "lblSPKVehicle";
            this.lblSPKVehicle.Size = new System.Drawing.Size(82, 13);
            this.lblSPKVehicle.TabIndex = 5;
            this.lblSPKVehicle.Text = "Nopol Kendaraan";
            // 
            // lookUpMechanic
            // 
            this.lookUpMechanic.Location = new System.Drawing.Point(111, 23);
            this.lookUpMechanic.Name = "lookUpMechanic";
            this.lookUpMechanic.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookUpMechanic.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpMechanic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpMechanic.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Kategori")});
            this.lookUpMechanic.Properties.DisplayMember = "Name";
            this.lookUpMechanic.Properties.HideSelection = false;
            this.lookUpMechanic.Properties.NullText = "-- Pilih Mekanik--";
            this.lookUpMechanic.Properties.ValueMember = "Id";
            this.lookUpMechanic.Size = new System.Drawing.Size(141, 20);
            this.lookUpMechanic.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(489, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 55);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblMechanic
            // 
            this.lblMechanic.Location = new System.Drawing.Point(11, 26);
            this.lblMechanic.Name = "lblMechanic";
            this.lblMechanic.Size = new System.Drawing.Size(38, 13);
            this.lblMechanic.TabIndex = 0;
            this.lblMechanic.Text = "Mekanik";
            // 
            // btnNewSPK
            // 
            this.btnNewSPKSchedule.Image = ((System.Drawing.Image)(resources.GetObject("btnNewSPK.Image")));
            this.btnNewSPKSchedule.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewSPKSchedule.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewSPKSchedule.Location = new System.Drawing.Point(3, 97);
            this.btnNewSPKSchedule.Name = "btnNewSPK";
            this.btnNewSPKSchedule.Size = new System.Drawing.Size(176, 23);
            this.btnNewSPKSchedule.TabIndex = 18;
            this.btnNewSPKSchedule.Text = "Tambah Jadwal Harian SPK";
            this.btnNewSPKSchedule.Click += new System.EventHandler(this.btnNewSPK_Click);
            // 
            // gcSPKSchedule
            // 
            this.gcSPKSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSPKSchedule.Location = new System.Drawing.Point(3, 126);
            this.gcSPKSchedule.MainView = this.gvSPKSchedule;
            this.gcSPKSchedule.Name = "gcSPKSchedule";
            this.gcSPKSchedule.Size = new System.Drawing.Size(752, 224);
            this.gcSPKSchedule.TabIndex = 19;
            this.gcSPKSchedule.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSPKSchedule});
            // 
            // gvSPKSchedule
            // 
            this.gvSPKSchedule.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMechanic,
            this.colSPKVehicle,
            this.ColCreatedDate,
            this.colDescription});
            this.gvSPKSchedule.GridControl = this.gcSPKSchedule;
            this.gvSPKSchedule.Name = "gvSPKSchedule";
            this.gvSPKSchedule.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSPKSchedule.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSPKSchedule.OptionsBehavior.AutoPopulateColumns = false;
            this.gvSPKSchedule.OptionsBehavior.Editable = false;
            this.gvSPKSchedule.OptionsBehavior.ReadOnly = true;
            this.gvSPKSchedule.OptionsCustomization.AllowColumnMoving = false;
            this.gvSPKSchedule.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvSPKSchedule.OptionsMenu.EnableFooterMenu = false;
            this.gvSPKSchedule.OptionsView.EnableAppearanceEvenRow = true;
            this.gvSPKSchedule.OptionsView.ShowFooter = true;
            this.gvSPKSchedule.OptionsView.ShowGroupPanel = false;
            this.gvSPKSchedule.OptionsView.ShowViewCaption = true;
            this.gvSPKSchedule.ViewCaption = "Daftar Kendaraan";
            // 
            // colMechanic
            // 
            this.colMechanic.Caption = "Mekanik";
            this.colMechanic.FieldName = "Mechanic.Name";
            this.colMechanic.Name = "colMechanic";
            this.colMechanic.Visible = true;
            this.colMechanic.VisibleIndex = 1;
            // 
            // colSPKVehicle
            // 
            this.colSPKVehicle.Caption = "Nopol";
            this.colSPKVehicle.FieldName = "SPK.Vehicle.ActiveLicenseNumber";
            this.colSPKVehicle.Name = "colSPKVehicle";
            this.colSPKVehicle.Visible = true;
            this.colSPKVehicle.VisibleIndex = 0;
            // 
            // ColCreatedDate
            // 
            this.ColCreatedDate.Caption = "Tanggal";
            this.ColCreatedDate.FieldName = "CreatedDate";
            this.ColCreatedDate.Name = "ColCreatedDate";
            this.ColCreatedDate.Visible = true;
            this.ColCreatedDate.VisibleIndex = 2;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Keterangan";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
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
            this.cmsDeleteData,
            this.toolStripSeparator1});
            this.cmsEditor.Name = "cmsListEditor";
            this.cmsEditor.Size = new System.Drawing.Size(136, 54);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // SPKScheduleListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcSPKSchedule);
            this.Controls.Add(this.btnNewSPKSchedule);
            this.Controls.Add(this.groupFilter);
            this.Name = "SPKScheduleListControl";
            this.Size = new System.Drawing.Size(759, 360);
            ((System.ComponentModel.ISupportInitialize)(this.groupFilter)).EndInit();
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteCreatedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteCreatedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSPKVehicle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMechanic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSPKSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSPKSchedule)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupFilter;
        private DevExpress.XtraEditors.DateEdit dteCreatedDate;
        private DevExpress.XtraEditors.LabelControl lblCreatedDate;
        private DevExpress.XtraEditors.LookUpEdit lookUpSPKVehicle;
        private DevExpress.XtraEditors.LabelControl lblSPKVehicle;
        private DevExpress.XtraEditors.LookUpEdit lookUpMechanic;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl lblMechanic;
        private DevExpress.XtraEditors.SimpleButton btnNewSPKSchedule;
        private DevExpress.XtraGrid.GridControl gcSPKSchedule;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSPKSchedule;
        private DevExpress.XtraGrid.Columns.GridColumn colMechanic;
        private DevExpress.XtraGrid.Columns.GridColumn colSPKVehicle;
        private DevExpress.XtraGrid.Columns.GridColumn ColCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
