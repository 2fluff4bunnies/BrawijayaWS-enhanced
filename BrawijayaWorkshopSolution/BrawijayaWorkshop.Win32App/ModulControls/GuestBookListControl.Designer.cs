namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class GuestBookListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestBookListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.dtpCreatedDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtFilter = new DevExpress.XtraEditors.TextEdit();
            this.lblFilterCompanyName = new DevExpress.XtraEditors.LabelControl();
            this.btnNewGuestBook = new DevExpress.XtraEditors.SimpleButton();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsViewVehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.gcGuestBook = new DevExpress.XtraGrid.GridControl();
            this.gvGuestBook = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colArrivalTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpCreatedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpCreatedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilter.Properties)).BeginInit();
            this.cmsEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcGuestBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGuestBook)).BeginInit();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.dtpCreatedDate);
            this.gcFilter.Controls.Add(this.labelControl1);
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.txtFilter);
            this.gcFilter.Controls.Add(this.lblFilterCompanyName);
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(691, 95);
            this.gcFilter.TabIndex = 7;
            this.gcFilter.Text = "Filter";
            // 
            // dtpCreatedDate
            // 
            this.dtpCreatedDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCreatedDate.EditValue = null;
            this.dtpCreatedDate.Location = new System.Drawing.Point(75, 64);
            this.dtpCreatedDate.Name = "dtpCreatedDate";
            this.dtpCreatedDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dtpCreatedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpCreatedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpCreatedDate.Properties.HideSelection = false;
            this.dtpCreatedDate.Properties.HighlightTodayCell = DevExpress.Utils.DefaultBoolean.True;
            this.dtpCreatedDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtpCreatedDate.Size = new System.Drawing.Size(115, 20);
            this.dtpCreatedDate.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Tanggal";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(196, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 57);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(75, 30);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Properties.Mask.EditMask = "[a-zA-Z0-9\\-_]{0,40}";
            this.txtFilter.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtFilter.Size = new System.Drawing.Size(115, 20);
            this.txtFilter.TabIndex = 1;
            // 
            // lblFilterCompanyName
            // 
            this.lblFilterCompanyName.Location = new System.Drawing.Point(12, 33);
            this.lblFilterCompanyName.Name = "lblFilterCompanyName";
            this.lblFilterCompanyName.Size = new System.Drawing.Size(57, 13);
            this.lblFilterCompanyName.TabIndex = 0;
            this.lblFilterCompanyName.Text = "Nomor Polisi";
            // 
            // btnNewGuestBook
            // 
            this.btnNewGuestBook.Image = ((System.Drawing.Image)(resources.GetObject("btnNewGuestBook.Image")));
            this.btnNewGuestBook.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewGuestBook.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewGuestBook.Location = new System.Drawing.Point(3, 104);
            this.btnNewGuestBook.Name = "btnNewGuestBook";
            this.btnNewGuestBook.Size = new System.Drawing.Size(170, 23);
            this.btnNewGuestBook.TabIndex = 9;
            this.btnNewGuestBook.Text = "Tambah Daftar Hadir Baru";
            this.btnNewGuestBook.Click += new System.EventHandler(this.btnNewGuestBook_Click);
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
            this.toolStripSeparator1,
            this.cmsViewVehicle});
            this.cmsEditor.Name = "cmsListEditor";
            this.cmsEditor.Size = new System.Drawing.Size(160, 76);
            // 
            // cmsEditData
            // 
            this.cmsEditData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.cmsEditData.Name = "cmsEditData";
            this.cmsEditData.Size = new System.Drawing.Size(159, 22);
            this.cmsEditData.Text = "Ubah Data";
            this.cmsEditData.Click += new System.EventHandler(this.cmsEditData_Click);
            // 
            // cmsDeleteData
            // 
            this.cmsDeleteData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.cmsDeleteData.Name = "cmsDeleteData";
            this.cmsDeleteData.Size = new System.Drawing.Size(159, 22);
            this.cmsDeleteData.Text = "Hapus Data";
            this.cmsDeleteData.Click += new System.EventHandler(this.cmsDeleteData_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // cmsViewVehicle
            // 
            this.cmsViewVehicle.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.Truck_Left_Green_icon_16x16;
            this.cmsViewVehicle.Name = "cmsViewVehicle";
            this.cmsViewVehicle.Size = new System.Drawing.Size(159, 22);
            this.cmsViewVehicle.Text = "Lihat Kendaraan";
            this.cmsViewVehicle.Click += new System.EventHandler(this.cmsViewVehicle_Click);
            // 
            // gcGuestBook
            // 
            this.gcGuestBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcGuestBook.Location = new System.Drawing.Point(3, 133);
            this.gcGuestBook.MainView = this.gvGuestBook;
            this.gcGuestBook.Name = "gcGuestBook";
            this.gcGuestBook.Size = new System.Drawing.Size(691, 316);
            this.gcGuestBook.TabIndex = 10;
            this.gcGuestBook.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGuestBook});
            // 
            // gvGuestBook
            // 
            this.gvGuestBook.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colArrivalTime,
            this.colDescription});
            this.gvGuestBook.GridControl = this.gcGuestBook;
            this.gvGuestBook.Name = "gvGuestBook";
            this.gvGuestBook.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvGuestBook.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvGuestBook.OptionsBehavior.AutoPopulateColumns = false;
            this.gvGuestBook.OptionsBehavior.Editable = false;
            this.gvGuestBook.OptionsBehavior.ReadOnly = true;
            this.gvGuestBook.OptionsCustomization.AllowColumnMoving = false;
            this.gvGuestBook.OptionsCustomization.AllowFilter = false;
            this.gvGuestBook.OptionsCustomization.AllowGroup = false;
            this.gvGuestBook.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvGuestBook.OptionsView.EnableAppearanceEvenRow = true;
            this.gvGuestBook.OptionsView.ShowGroupPanel = false;
            this.gvGuestBook.OptionsView.ShowViewCaption = true;
            this.gvGuestBook.ViewCaption = "Daftar Customer";
            // 
            // colArrivalTime
            // 
            this.colArrivalTime.Caption = "Waktu Kedatangan";
            this.colArrivalTime.FieldName = "ArrivalTime";
            this.colArrivalTime.Name = "colArrivalTime";
            this.colArrivalTime.Visible = true;
            this.colArrivalTime.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Keterangan";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // GuestBookListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcGuestBook);
            this.Controls.Add(this.btnNewGuestBook);
            this.Controls.Add(this.gcFilter);
            this.Name = "GuestBookListControl";
            this.Size = new System.Drawing.Size(697, 452);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpCreatedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpCreatedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilter.Properties)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcGuestBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGuestBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtFilter;
        private DevExpress.XtraEditors.LabelControl lblFilterCompanyName;
        private DevExpress.XtraEditors.SimpleButton btnNewGuestBook;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmsViewVehicle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtpCreatedDate;
        private DevExpress.XtraGrid.GridControl gcGuestBook;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGuestBook;
        private DevExpress.XtraGrid.Columns.GridColumn colArrivalTime;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
    }
}
