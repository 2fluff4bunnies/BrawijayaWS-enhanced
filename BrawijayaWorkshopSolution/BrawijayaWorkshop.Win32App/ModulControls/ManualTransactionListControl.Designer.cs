namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class ManualTransactionListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualTransactionListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.lblDateFilter = new DevExpress.XtraEditors.LabelControl();
            this.deFrom = new DevExpress.XtraEditors.DateEdit();
            this.lblDateFilterTo = new DevExpress.XtraEditors.LabelControl();
            this.deTo = new DevExpress.XtraEditors.DateEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewTransaction = new DevExpress.XtraEditors.SimpleButton();
            this.gridManualTransaction = new DevExpress.XtraGrid.GridControl();
            this.gvManualTransaction = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodeCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCityCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactPersonCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridManualTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvManualTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.deTo);
            this.gcFilter.Controls.Add(this.lblDateFilterTo);
            this.gcFilter.Controls.Add(this.deFrom);
            this.gcFilter.Controls.Add(this.lblDateFilter);
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(696, 64);
            this.gcFilter.TabIndex = 0;
            this.gcFilter.Text = "Filter";
            // 
            // lblDateFilter
            // 
            this.lblDateFilter.Location = new System.Drawing.Point(12, 33);
            this.lblDateFilter.Name = "lblDateFilter";
            this.lblDateFilter.Size = new System.Drawing.Size(86, 13);
            this.lblDateFilter.TabIndex = 0;
            this.lblDateFilter.Text = "Tanggal Transaksi";
            // 
            // deFrom
            // 
            this.deFrom.EditValue = null;
            this.deFrom.Location = new System.Drawing.Point(128, 30);
            this.deFrom.Name = "deFrom";
            this.deFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFrom.Properties.DisplayFormat.FormatString = "dd MMM yyyy";
            this.deFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deFrom.Properties.HideSelection = false;
            this.deFrom.Properties.NullDate = "";
            this.deFrom.Properties.NullText = "-- Pilih Tanggal --";
            this.deFrom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deFrom.Size = new System.Drawing.Size(106, 20);
            this.deFrom.TabIndex = 1;
            // 
            // lblDateFilterTo
            // 
            this.lblDateFilterTo.Location = new System.Drawing.Point(240, 33);
            this.lblDateFilterTo.Name = "lblDateFilterTo";
            this.lblDateFilterTo.Size = new System.Drawing.Size(15, 13);
            this.lblDateFilterTo.TabIndex = 2;
            this.lblDateFilterTo.Text = "s/d";
            // 
            // deTo
            // 
            this.deTo.EditValue = null;
            this.deTo.Location = new System.Drawing.Point(261, 30);
            this.deTo.Name = "deTo";
            this.deTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTo.Properties.DisplayFormat.FormatString = "dd MMM yyyy";
            this.deTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deTo.Properties.HideSelection = false;
            this.deTo.Properties.NullDate = "";
            this.deTo.Properties.NullText = "-- Pilih Tanggal --";
            this.deTo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deTo.Size = new System.Drawing.Size(106, 20);
            this.deTo.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(373, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "cari";
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnNewTransaction.Image")));
            this.btnNewTransaction.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewTransaction.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewTransaction.Location = new System.Drawing.Point(3, 73);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(144, 23);
            this.btnNewTransaction.TabIndex = 3;
            this.btnNewTransaction.Text = "Buat Transaksi Baru";
            // 
            // gridManualTransaction
            // 
            this.gridManualTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridManualTransaction.Location = new System.Drawing.Point(3, 102);
            this.gridManualTransaction.MainView = this.gvManualTransaction;
            this.gridManualTransaction.Name = "gridManualTransaction";
            this.gridManualTransaction.Size = new System.Drawing.Size(696, 255);
            this.gridManualTransaction.TabIndex = 4;
            this.gridManualTransaction.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvManualTransaction});
            // 
            // gvManualTransaction
            // 
            this.gvManualTransaction.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodeCustomer,
            this.colCompanyCustomer,
            this.colAddressCustomer,
            this.colCityCustomer,
            this.colPhoneCustomer,
            this.colContactPersonCustomer});
            this.gvManualTransaction.GridControl = this.gridManualTransaction;
            this.gvManualTransaction.Name = "gvManualTransaction";
            this.gvManualTransaction.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvManualTransaction.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvManualTransaction.OptionsBehavior.AutoPopulateColumns = false;
            this.gvManualTransaction.OptionsBehavior.Editable = false;
            this.gvManualTransaction.OptionsBehavior.ReadOnly = true;
            this.gvManualTransaction.OptionsCustomization.AllowColumnMoving = false;
            this.gvManualTransaction.OptionsCustomization.AllowFilter = false;
            this.gvManualTransaction.OptionsCustomization.AllowGroup = false;
            this.gvManualTransaction.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvManualTransaction.OptionsView.EnableAppearanceEvenRow = true;
            this.gvManualTransaction.OptionsView.ShowGroupPanel = false;
            this.gvManualTransaction.OptionsView.ShowViewCaption = true;
            this.gvManualTransaction.ViewCaption = "Daftar Transaksi Manual";
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
            // ManualTransactionListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridManualTransaction);
            this.Controls.Add(this.btnNewTransaction);
            this.Controls.Add(this.gcFilter);
            this.Name = "ManualTransactionListControl";
            this.Size = new System.Drawing.Size(702, 360);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridManualTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvManualTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.DateEdit deTo;
        private DevExpress.XtraEditors.LabelControl lblDateFilterTo;
        private DevExpress.XtraEditors.DateEdit deFrom;
        private DevExpress.XtraEditors.LabelControl lblDateFilter;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnNewTransaction;
        private DevExpress.XtraGrid.GridControl gridManualTransaction;
        private DevExpress.XtraGrid.Views.Grid.GridView gvManualTransaction;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colCityCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colContactPersonCustomer;
    }
}
