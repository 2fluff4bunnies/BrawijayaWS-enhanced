namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class CustomerListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtFilterCompanyName = new DevExpress.XtraEditors.TextEdit();
            this.lblFilterCompanyName = new DevExpress.XtraEditors.LabelControl();
            this.gridCustomer = new DevExpress.XtraGrid.GridControl();
            this.gvCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodeCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCityCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactPersonCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnNewCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterCompanyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.txtFilterCompanyName);
            this.gcFilter.Controls.Add(this.lblFilterCompanyName);
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(575, 62);
            this.gcFilter.TabIndex = 0;
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
            // txtFilterCompanyName
            // 
            this.txtFilterCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterCompanyName.Location = new System.Drawing.Point(128, 30);
            this.txtFilterCompanyName.Name = "txtFilterCompanyName";
            this.txtFilterCompanyName.Size = new System.Drawing.Size(374, 20);
            this.txtFilterCompanyName.TabIndex = 1;
            this.txtFilterCompanyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilterCompanyName_KeyDown);
            // 
            // lblFilterCompanyName
            // 
            this.lblFilterCompanyName.Location = new System.Drawing.Point(12, 33);
            this.lblFilterCompanyName.Name = "lblFilterCompanyName";
            this.lblFilterCompanyName.Size = new System.Drawing.Size(87, 13);
            this.lblFilterCompanyName.TabIndex = 0;
            this.lblFilterCompanyName.Text = "Nama Perusahaan";
            // 
            // gridCustomer
            // 
            this.gridCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCustomer.Location = new System.Drawing.Point(3, 100);
            this.gridCustomer.MainView = this.gvCustomer;
            this.gridCustomer.Name = "gridCustomer";
            this.gridCustomer.Size = new System.Drawing.Size(575, 224);
            this.gridCustomer.TabIndex = 1;
            this.gridCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCustomer});
            // 
            // gvCustomer
            // 
            this.gvCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodeCustomer,
            this.colCompanyCustomer,
            this.colAddressCustomer,
            this.colCityCustomer,
            this.colPhoneCustomer,
            this.colContactPersonCustomer});
            this.gvCustomer.GridControl = this.gridCustomer;
            this.gvCustomer.Name = "gvCustomer";
            this.gvCustomer.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCustomer.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCustomer.OptionsBehavior.AutoPopulateColumns = false;
            this.gvCustomer.OptionsBehavior.Editable = false;
            this.gvCustomer.OptionsBehavior.ReadOnly = true;
            this.gvCustomer.OptionsCustomization.AllowColumnMoving = false;
            this.gvCustomer.OptionsCustomization.AllowFilter = false;
            this.gvCustomer.OptionsCustomization.AllowGroup = false;
            this.gvCustomer.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvCustomer.OptionsView.ShowGroupPanel = false;
            this.gvCustomer.OptionsView.ShowViewCaption = true;
            this.gvCustomer.ViewCaption = "Daftar Customer";
            // 
            // colCodeCustomer
            // 
            this.colCodeCustomer.Caption = "Kode";
            this.colCodeCustomer.FieldName = "Code";
            this.colCodeCustomer.Name = "colCodeCustomer";
            this.colCodeCustomer.Visible = true;
            this.colCodeCustomer.VisibleIndex = 0;
            // 
            // colCompanyCustomer
            // 
            this.colCompanyCustomer.Caption = "Nama Perusahaan";
            this.colCompanyCustomer.FieldName = "CompanyName";
            this.colCompanyCustomer.Name = "colCompanyCustomer";
            this.colCompanyCustomer.Visible = true;
            this.colCompanyCustomer.VisibleIndex = 1;
            // 
            // colAddressCustomer
            // 
            this.colAddressCustomer.Caption = "Alamat";
            this.colAddressCustomer.FieldName = "Address";
            this.colAddressCustomer.Name = "colAddressCustomer";
            this.colAddressCustomer.Visible = true;
            this.colAddressCustomer.VisibleIndex = 2;
            // 
            // colCityCustomer
            // 
            this.colCityCustomer.Caption = "Kota";
            this.colCityCustomer.FieldName = "City.Name";
            this.colCityCustomer.Name = "colCityCustomer";
            this.colCityCustomer.Visible = true;
            this.colCityCustomer.VisibleIndex = 3;
            // 
            // colPhoneCustomer
            // 
            this.colPhoneCustomer.Caption = "No. Telp.";
            this.colPhoneCustomer.FieldName = "PhoneNumber";
            this.colPhoneCustomer.Name = "colPhoneCustomer";
            this.colPhoneCustomer.Visible = true;
            this.colPhoneCustomer.VisibleIndex = 4;
            // 
            // colContactPersonCustomer
            // 
            this.colContactPersonCustomer.Caption = "Nama Kontak";
            this.colContactPersonCustomer.FieldName = "ContactPerson";
            this.colContactPersonCustomer.Name = "colContactPersonCustomer";
            this.colContactPersonCustomer.Visible = true;
            this.colContactPersonCustomer.VisibleIndex = 5;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnNewCustomer.Image")));
            this.btnNewCustomer.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewCustomer.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewCustomer.Location = new System.Drawing.Point(3, 71);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(144, 23);
            this.btnNewCustomer.TabIndex = 2;
            this.btnNewCustomer.Text = "Buat Customer Baru";
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
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
            // CustomerListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.gridCustomer);
            this.Controls.Add(this.gcFilter);
            this.Name = "CustomerListControl";
            this.Size = new System.Drawing.Size(581, 327);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterCompanyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtFilterCompanyName;
        private DevExpress.XtraEditors.LabelControl lblFilterCompanyName;
        private DevExpress.XtraGrid.GridControl gridCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCustomer;
        private DevExpress.XtraEditors.SimpleButton btnNewCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colCityCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colContactPersonCustomer;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
        private System.ComponentModel.BackgroundWorker bgwMain;
    }
}
