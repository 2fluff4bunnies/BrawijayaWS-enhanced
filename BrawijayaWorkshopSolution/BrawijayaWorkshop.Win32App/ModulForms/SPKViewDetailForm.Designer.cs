namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class SPKViewDetailForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPKViewDetailForm));
            this.groupSPK = new DevExpress.XtraEditors.GroupControl();
            this.groupMechanic = new DevExpress.XtraEditors.GroupControl();
            this.gcMechanic = new DevExpress.XtraGrid.GridControl();
            this.gvMechanic = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMechanicMechanic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupSparepart = new DevExpress.XtraEditors.GroupControl();
            this.lblTotalSparepartValue = new DevExpress.XtraEditors.LabelControl();
            this.gcSparepart = new DevExpress.XtraGrid.GridControl();
            this.gvSparepart = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSparepartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepartCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblTotalSparepart = new DevExpress.XtraEditors.LabelControl();
            this.lblDescriptionValue = new DevExpress.XtraEditors.LabelControl();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.lblStatusCompletedValue = new DevExpress.XtraEditors.LabelControl();
            this.lblStatusCompleted = new DevExpress.XtraEditors.LabelControl();
            this.lblStatusPrintValue = new DevExpress.XtraEditors.LabelControl();
            this.lblStatusPrint = new DevExpress.XtraEditors.LabelControl();
            this.lblStatusApprovalValue = new DevExpress.XtraEditors.LabelControl();
            this.lblStatusApproval = new DevExpress.XtraEditors.LabelControl();
            this.lblCreateDateValue = new DevExpress.XtraEditors.LabelControl();
            this.lblDueDateValue = new DevExpress.XtraEditors.LabelControl();
            this.lblCategoryValue = new DevExpress.XtraEditors.LabelControl();
            this.lblVehicleValue = new DevExpress.XtraEditors.LabelControl();
            this.lblCustomerValue = new DevExpress.XtraEditors.LabelControl();
            this.lblCodeValue = new DevExpress.XtraEditors.LabelControl();
            this.lblCode = new DevExpress.XtraEditors.LabelControl();
            this.lblCustomer = new DevExpress.XtraEditors.LabelControl();
            this.lblCreateDate = new DevExpress.XtraEditors.LabelControl();
            this.lblCategory = new DevExpress.XtraEditors.LabelControl();
            this.lblDueDate = new DevExpress.XtraEditors.LabelControl();
            this.lblVehicle = new DevExpress.XtraEditors.LabelControl();
            this.btnEndorse = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnReject = new DevExpress.XtraEditors.SimpleButton();
            this.btnApprove = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnRequestPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnAbort = new DevExpress.XtraEditors.SimpleButton();
            this.btnSetAsComplete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupSPK)).BeginInit();
            this.groupSPK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupMechanic)).BeginInit();
            this.groupMechanic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMechanic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMechanic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSparepart)).BeginInit();
            this.groupSparepart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupSPK
            // 
            this.groupSPK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupSPK.Controls.Add(this.groupMechanic);
            this.groupSPK.Controls.Add(this.groupSparepart);
            this.groupSPK.Controls.Add(this.lblDescriptionValue);
            this.groupSPK.Controls.Add(this.lblDescription);
            this.groupSPK.Controls.Add(this.lblStatusCompletedValue);
            this.groupSPK.Controls.Add(this.lblStatusCompleted);
            this.groupSPK.Controls.Add(this.lblStatusPrintValue);
            this.groupSPK.Controls.Add(this.lblStatusPrint);
            this.groupSPK.Controls.Add(this.lblStatusApprovalValue);
            this.groupSPK.Controls.Add(this.lblStatusApproval);
            this.groupSPK.Controls.Add(this.lblCreateDateValue);
            this.groupSPK.Controls.Add(this.lblDueDateValue);
            this.groupSPK.Controls.Add(this.lblCategoryValue);
            this.groupSPK.Controls.Add(this.lblVehicleValue);
            this.groupSPK.Controls.Add(this.lblCustomerValue);
            this.groupSPK.Controls.Add(this.lblCodeValue);
            this.groupSPK.Controls.Add(this.lblCode);
            this.groupSPK.Controls.Add(this.lblCustomer);
            this.groupSPK.Controls.Add(this.lblCreateDate);
            this.groupSPK.Controls.Add(this.lblCategory);
            this.groupSPK.Controls.Add(this.lblDueDate);
            this.groupSPK.Controls.Add(this.lblVehicle);
            this.groupSPK.Location = new System.Drawing.Point(-5, 0);
            this.groupSPK.Name = "groupSPK";
            this.groupSPK.Size = new System.Drawing.Size(610, 526);
            this.groupSPK.TabIndex = 1;
            this.groupSPK.Text = "Informasi SPK";
            // 
            // groupMechanic
            // 
            this.groupMechanic.Controls.Add(this.gcMechanic);
            this.groupMechanic.Location = new System.Drawing.Point(15, 364);
            this.groupMechanic.Name = "groupMechanic";
            this.groupMechanic.Size = new System.Drawing.Size(583, 162);
            this.groupMechanic.TabIndex = 29;
            this.groupMechanic.Text = "Mekanik";
            // 
            // gcMechanic
            // 
            this.gcMechanic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gcMechanic.Location = new System.Drawing.Point(5, 36);
            this.gcMechanic.MainView = this.gvMechanic;
            this.gcMechanic.Name = "gcMechanic";
            this.gcMechanic.Size = new System.Drawing.Size(573, 113);
            this.gcMechanic.TabIndex = 18;
            this.gcMechanic.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMechanic});
            // 
            // gvMechanic
            // 
            this.gvMechanic.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMechanicMechanic,
            this.colDescription});
            this.gvMechanic.GridControl = this.gcMechanic;
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
            this.gvMechanic.ViewCaption = "Mekanik Terlibat";
            // 
            // colMechanicMechanic
            // 
            this.colMechanicMechanic.Caption = "Nama Mechanic";
            this.colMechanicMechanic.FieldName = "Mechanic.Name";
            this.colMechanicMechanic.Name = "colMechanicMechanic";
            this.colMechanicMechanic.Visible = true;
            this.colMechanicMechanic.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Keterangan";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // groupSparepart
            // 
            this.groupSparepart.Controls.Add(this.lblTotalSparepartValue);
            this.groupSparepart.Controls.Add(this.gcSparepart);
            this.groupSparepart.Controls.Add(this.lblTotalSparepart);
            this.groupSparepart.Location = new System.Drawing.Point(15, 170);
            this.groupSparepart.Name = "groupSparepart";
            this.groupSparepart.Size = new System.Drawing.Size(583, 186);
            this.groupSparepart.TabIndex = 30;
            this.groupSparepart.Text = "Sparepart";
            // 
            // lblTotalSparepartValue
            // 
            this.lblTotalSparepartValue.Location = new System.Drawing.Point(461, 157);
            this.lblTotalSparepartValue.Name = "lblTotalSparepartValue";
            this.lblTotalSparepartValue.Size = new System.Drawing.Size(4, 13);
            this.lblTotalSparepartValue.TabIndex = 58;
            this.lblTotalSparepartValue.Text = ":";
            // 
            // gcSparepart
            // 
            this.gcSparepart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSparepart.Location = new System.Drawing.Point(5, 38);
            this.gcSparepart.MainView = this.gvSparepart;
            this.gcSparepart.Name = "gcSparepart";
            this.gcSparepart.Size = new System.Drawing.Size(573, 113);
            this.gcSparepart.TabIndex = 28;
            this.gcSparepart.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSparepart});
            // 
            // gvSparepart
            // 
            this.gvSparepart.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSparepartName,
            this.colSparepartCode,
            this.colTotalQty,
            this.colTotalPrice});
            this.gvSparepart.GridControl = this.gcSparepart;
            this.gvSparepart.Name = "gvSparepart";
            this.gvSparepart.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSparepart.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSparepart.OptionsBehavior.Editable = false;
            this.gvSparepart.OptionsBehavior.ReadOnly = true;
            this.gvSparepart.OptionsCustomization.AllowColumnMoving = false;
            this.gvSparepart.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvSparepart.OptionsMenu.EnableFooterMenu = false;
            this.gvSparepart.OptionsView.ShowGroupPanel = false;
            this.gvSparepart.OptionsView.ShowViewCaption = true;
            this.gvSparepart.ViewCaption = "Penggunaan Sparepart";
            // 
            // colSparepartName
            // 
            this.colSparepartName.Caption = "Sparepart";
            this.colSparepartName.FieldName = "Sparepart.Name";
            this.colSparepartName.Name = "colSparepartName";
            this.colSparepartName.Visible = true;
            this.colSparepartName.VisibleIndex = 0;
            // 
            // colSparepartCode
            // 
            this.colSparepartCode.Caption = "Kode";
            this.colSparepartCode.FieldName = "Sparepart.Code";
            this.colSparepartCode.Name = "colSparepartCode";
            this.colSparepartCode.Visible = true;
            this.colSparepartCode.VisibleIndex = 1;
            // 
            // colTotalQty
            // 
            this.colTotalQty.Caption = "Jumlah";
            this.colTotalQty.FieldName = "TotalQuantity";
            this.colTotalQty.Name = "colTotalQty";
            this.colTotalQty.Visible = true;
            this.colTotalQty.VisibleIndex = 2;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "Total Harga";
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 3;
            // 
            // lblTotalSparepart
            // 
            this.lblTotalSparepart.Location = new System.Drawing.Point(357, 157);
            this.lblTotalSparepart.Name = "lblTotalSparepart";
            this.lblTotalSparepart.Size = new System.Drawing.Size(75, 13);
            this.lblTotalSparepart.TabIndex = 42;
            this.lblTotalSparepart.Text = "Total Sparepart";
            // 
            // lblDescriptionValue
            // 
            this.lblDescriptionValue.Location = new System.Drawing.Point(394, 89);
            this.lblDescriptionValue.Name = "lblDescriptionValue";
            this.lblDescriptionValue.Size = new System.Drawing.Size(4, 13);
            this.lblDescriptionValue.TabIndex = 57;
            this.lblDescriptionValue.Text = ":";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(290, 88);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(42, 13);
            this.lblDescription.TabIndex = 56;
            this.lblDescription.Text = "Deskripsi";
            // 
            // lblStatusCompletedValue
            // 
            this.lblStatusCompletedValue.Location = new System.Drawing.Point(394, 70);
            this.lblStatusCompletedValue.Name = "lblStatusCompletedValue";
            this.lblStatusCompletedValue.Size = new System.Drawing.Size(4, 13);
            this.lblStatusCompletedValue.TabIndex = 55;
            this.lblStatusCompletedValue.Text = ":";
            // 
            // lblStatusCompleted
            // 
            this.lblStatusCompleted.Location = new System.Drawing.Point(290, 69);
            this.lblStatusCompleted.Name = "lblStatusCompleted";
            this.lblStatusCompleted.Size = new System.Drawing.Size(89, 13);
            this.lblStatusCompleted.TabIndex = 54;
            this.lblStatusCompleted.Text = "Status Pengerjaan";
            // 
            // lblStatusPrintValue
            // 
            this.lblStatusPrintValue.Location = new System.Drawing.Point(394, 51);
            this.lblStatusPrintValue.Name = "lblStatusPrintValue";
            this.lblStatusPrintValue.Size = new System.Drawing.Size(4, 13);
            this.lblStatusPrintValue.TabIndex = 53;
            this.lblStatusPrintValue.Text = ":";
            // 
            // lblStatusPrint
            // 
            this.lblStatusPrint.Location = new System.Drawing.Point(290, 50);
            this.lblStatusPrint.Name = "lblStatusPrint";
            this.lblStatusPrint.Size = new System.Drawing.Size(56, 13);
            this.lblStatusPrint.TabIndex = 52;
            this.lblStatusPrint.Text = "Status Print";
            // 
            // lblStatusApprovalValue
            // 
            this.lblStatusApprovalValue.Location = new System.Drawing.Point(394, 32);
            this.lblStatusApprovalValue.Name = "lblStatusApprovalValue";
            this.lblStatusApprovalValue.Size = new System.Drawing.Size(4, 13);
            this.lblStatusApprovalValue.TabIndex = 51;
            this.lblStatusApprovalValue.Text = ":";
            // 
            // lblStatusApproval
            // 
            this.lblStatusApproval.Location = new System.Drawing.Point(290, 31);
            this.lblStatusApproval.Name = "lblStatusApproval";
            this.lblStatusApproval.Size = new System.Drawing.Size(92, 13);
            this.lblStatusApproval.TabIndex = 50;
            this.lblStatusApproval.Text = "Status Persetujuan";
            // 
            // lblCreateDateValue
            // 
            this.lblCreateDateValue.Location = new System.Drawing.Point(119, 107);
            this.lblCreateDateValue.Name = "lblCreateDateValue";
            this.lblCreateDateValue.Size = new System.Drawing.Size(4, 13);
            this.lblCreateDateValue.TabIndex = 49;
            this.lblCreateDateValue.Text = ":";
            // 
            // lblDueDateValue
            // 
            this.lblDueDateValue.Location = new System.Drawing.Point(119, 126);
            this.lblDueDateValue.Name = "lblDueDateValue";
            this.lblDueDateValue.Size = new System.Drawing.Size(4, 13);
            this.lblDueDateValue.TabIndex = 48;
            this.lblDueDateValue.Text = ":";
            // 
            // lblCategoryValue
            // 
            this.lblCategoryValue.Location = new System.Drawing.Point(119, 88);
            this.lblCategoryValue.Name = "lblCategoryValue";
            this.lblCategoryValue.Size = new System.Drawing.Size(4, 13);
            this.lblCategoryValue.TabIndex = 47;
            this.lblCategoryValue.Text = ":";
            // 
            // lblVehicleValue
            // 
            this.lblVehicleValue.Location = new System.Drawing.Point(119, 69);
            this.lblVehicleValue.Name = "lblVehicleValue";
            this.lblVehicleValue.Size = new System.Drawing.Size(4, 13);
            this.lblVehicleValue.TabIndex = 46;
            this.lblVehicleValue.Text = ":";
            // 
            // lblCustomerValue
            // 
            this.lblCustomerValue.Location = new System.Drawing.Point(119, 50);
            this.lblCustomerValue.Name = "lblCustomerValue";
            this.lblCustomerValue.Size = new System.Drawing.Size(4, 13);
            this.lblCustomerValue.TabIndex = 45;
            this.lblCustomerValue.Text = ":";
            // 
            // lblCodeValue
            // 
            this.lblCodeValue.Location = new System.Drawing.Point(119, 31);
            this.lblCodeValue.Name = "lblCodeValue";
            this.lblCodeValue.Size = new System.Drawing.Size(4, 13);
            this.lblCodeValue.TabIndex = 44;
            this.lblCodeValue.Text = ":";
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(15, 31);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(24, 13);
            this.lblCode.TabIndex = 40;
            this.lblCode.Text = "Kode";
            // 
            // lblCustomer
            // 
            this.lblCustomer.Location = new System.Drawing.Point(15, 50);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(46, 13);
            this.lblCustomer.TabIndex = 37;
            this.lblCustomer.Text = "Customer";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.Location = new System.Drawing.Point(15, 107);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(95, 13);
            this.lblCreateDate.TabIndex = 35;
            this.lblCreateDate.Text = "Tanggal Pembuatan";
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(15, 88);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 13);
            this.lblCategory.TabIndex = 13;
            this.lblCategory.Text = "Jenis layanan";
            // 
            // lblDueDate
            // 
            this.lblDueDate.Location = new System.Drawing.Point(15, 126);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(59, 13);
            this.lblDueDate.TabIndex = 12;
            this.lblDueDate.Text = "Batas waktu";
            // 
            // lblVehicle
            // 
            this.lblVehicle.Location = new System.Drawing.Point(15, 69);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(52, 13);
            this.lblVehicle.TabIndex = 2;
            this.lblVehicle.Text = "Kendaraan";
            // 
            // btnEndorse
            // 
            this.btnEndorse.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.btnEndorse.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnEndorse.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEndorse.Location = new System.Drawing.Point(302, 532);
            this.btnEndorse.Name = "btnEndorse";
            this.btnEndorse.Size = new System.Drawing.Size(91, 23);
            this.btnEndorse.TabIndex = 37;
            this.btnEndorse.Text = "Revisi";
            this.btnEndorse.Click += new System.EventHandler(this.btnEndorse_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.print_16x16;
            this.btnPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnPrint.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnPrint.Location = new System.Drawing.Point(10, 532);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(91, 23);
            this.btnPrint.TabIndex = 36;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReject
            // 
            this.btnReject.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnReject.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnReject.Location = new System.Drawing.Point(107, 532);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(91, 23);
            this.btnReject.TabIndex = 35;
            this.btnReject.Text = "Tolak";
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnApprove.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnApprove.Location = new System.Drawing.Point(10, 532);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(91, 23);
            this.btnApprove.TabIndex = 34;
            this.btnApprove.Text = "Setuju";
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCancel.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(499, 532);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Tutup";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRequestPrint
            // 
            this.btnRequestPrint.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.print_16x16;
            this.btnRequestPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnRequestPrint.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnRequestPrint.Location = new System.Drawing.Point(10, 532);
            this.btnRequestPrint.Name = "btnRequestPrint";
            this.btnRequestPrint.Size = new System.Drawing.Size(122, 23);
            this.btnRequestPrint.TabIndex = 38;
            this.btnRequestPrint.Text = "Print Request";
            this.btnRequestPrint.Click += new System.EventHandler(this.btnRequestPrint_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAbort.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAbort.Location = new System.Drawing.Point(10, 532);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(91, 23);
            this.btnAbort.TabIndex = 39;
            this.btnAbort.Text = "Batalkan";
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnSetAsComplete
            // 
            this.btnSetAsComplete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSetAsComplete.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSetAsComplete.Location = new System.Drawing.Point(10, 532);
            this.btnSetAsComplete.Name = "btnSetAsComplete";
            this.btnSetAsComplete.Size = new System.Drawing.Size(91, 23);
            this.btnSetAsComplete.TabIndex = 40;
            this.btnSetAsComplete.Text = "Set SPK Selesai";
            this.btnSetAsComplete.Click += new System.EventHandler(this.btnSetAsComplete_Click);
            // 
            // SPKViewDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 562);
            this.Controls.Add(this.btnSetAsComplete);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnRequestPrint);
            this.Controls.Add(this.groupSPK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnEndorse);
            this.Controls.Add(this.btnApprove);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SPKViewDetailForm";
            this.Text = "Informasi Detail SPK";
            ((System.ComponentModel.ISupportInitialize)(this.groupSPK)).EndInit();
            this.groupSPK.ResumeLayout(false);
            this.groupSPK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupMechanic)).EndInit();
            this.groupMechanic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMechanic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMechanic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSparepart)).EndInit();
            this.groupSparepart.ResumeLayout(false);
            this.groupSparepart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupSPK;
        private DevExpress.XtraGrid.GridControl gcSparepart;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSparepart;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartName;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalQty;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.GridControl gcMechanic;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMechanic;
        private DevExpress.XtraGrid.Columns.GridColumn colMechanicMechanic;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraEditors.LabelControl lblCategory;
        private DevExpress.XtraEditors.LabelControl lblDueDate;
        private DevExpress.XtraEditors.LabelControl lblVehicle;
        private DevExpress.XtraEditors.LabelControl lblCustomer;
        private DevExpress.XtraEditors.LabelControl lblCreateDate;
        private DevExpress.XtraEditors.SimpleButton btnReject;
        private DevExpress.XtraEditors.SimpleButton btnApprove;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.LabelControl lblCode;
        private DevExpress.XtraEditors.LabelControl lblTotalSparepart;
        private DevExpress.XtraEditors.SimpleButton btnEndorse;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.LabelControl lblStatusCompletedValue;
        private DevExpress.XtraEditors.LabelControl lblStatusCompleted;
        private DevExpress.XtraEditors.LabelControl lblStatusPrintValue;
        private DevExpress.XtraEditors.LabelControl lblStatusPrint;
        private DevExpress.XtraEditors.LabelControl lblStatusApprovalValue;
        private DevExpress.XtraEditors.LabelControl lblStatusApproval;
        private DevExpress.XtraEditors.LabelControl lblCreateDateValue;
        private DevExpress.XtraEditors.LabelControl lblDueDateValue;
        private DevExpress.XtraEditors.LabelControl lblCategoryValue;
        private DevExpress.XtraEditors.LabelControl lblVehicleValue;
        private DevExpress.XtraEditors.LabelControl lblCustomerValue;
        private DevExpress.XtraEditors.LabelControl lblCodeValue;
        private DevExpress.XtraEditors.LabelControl lblDescriptionValue;
        private DevExpress.XtraEditors.LabelControl lblTotalSparepartValue;
        private DevExpress.XtraEditors.GroupControl groupMechanic;
        private DevExpress.XtraEditors.GroupControl groupSparepart;
        private DevExpress.XtraEditors.SimpleButton btnRequestPrint;
        private DevExpress.XtraEditors.SimpleButton btnAbort;
        private DevExpress.XtraEditors.SimpleButton btnSetAsComplete;
    }
}