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
            this.gcSPK = new DevExpress.XtraEditors.GroupControl();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.lblCode = new DevExpress.XtraEditors.LabelControl();
            this.txtCreateDate = new DevExpress.XtraEditors.TextEdit();
            this.txtCustomer = new DevExpress.XtraEditors.TextEdit();
            this.lblCustomer = new DevExpress.XtraEditors.LabelControl();
            this.lblCreateDate = new DevExpress.XtraEditors.LabelControl();
            this.txtDueDate = new DevExpress.XtraEditors.TextEdit();
            this.txtSPKCategory = new DevExpress.XtraEditors.TextEdit();
            this.txtVehicle = new DevExpress.XtraEditors.TextEdit();
            this.gcSparepart = new DevExpress.XtraGrid.GridControl();
            this.gvSparepart = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSparepartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepartCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcMechanic = new DevExpress.XtraGrid.GridControl();
            this.gvMechanic = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMechanicMechanic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblCategory = new DevExpress.XtraEditors.LabelControl();
            this.lblDueDate = new DevExpress.XtraEditors.LabelControl();
            this.lblVehicle = new DevExpress.XtraEditors.LabelControl();
            this.btnReject = new DevExpress.XtraEditors.SimpleButton();
            this.btnApprove = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcSPK)).BeginInit();
            this.gcSPK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDueDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPKCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVehicle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMechanic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMechanic)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSPK
            // 
            this.gcSPK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSPK.Controls.Add(this.txtCode);
            this.gcSPK.Controls.Add(this.lblCode);
            this.gcSPK.Controls.Add(this.txtCreateDate);
            this.gcSPK.Controls.Add(this.txtCustomer);
            this.gcSPK.Controls.Add(this.lblCustomer);
            this.gcSPK.Controls.Add(this.lblCreateDate);
            this.gcSPK.Controls.Add(this.txtDueDate);
            this.gcSPK.Controls.Add(this.txtSPKCategory);
            this.gcSPK.Controls.Add(this.txtVehicle);
            this.gcSPK.Controls.Add(this.gcSparepart);
            this.gcSPK.Controls.Add(this.gcMechanic);
            this.gcSPK.Controls.Add(this.lblCategory);
            this.gcSPK.Controls.Add(this.lblDueDate);
            this.gcSPK.Controls.Add(this.lblVehicle);
            this.gcSPK.Location = new System.Drawing.Point(-5, 0);
            this.gcSPK.Name = "gcSPK";
            this.gcSPK.Size = new System.Drawing.Size(482, 391);
            this.gcSPK.TabIndex = 1;
            this.gcSPK.Text = "Informasi SPK";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(116, 28);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(111, 20);
            this.txtCode.TabIndex = 41;
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(15, 31);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(24, 13);
            this.lblCode.TabIndex = 40;
            this.lblCode.Text = "Kode";
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Location = new System.Drawing.Point(354, 28);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Size = new System.Drawing.Size(111, 20);
            this.txtCreateDate.TabIndex = 39;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(354, 81);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(111, 20);
            this.txtCustomer.TabIndex = 38;
            // 
            // lblCustomer
            // 
            this.lblCustomer.Location = new System.Drawing.Point(253, 84);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(46, 13);
            this.lblCustomer.TabIndex = 37;
            this.lblCustomer.Text = "Customer";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.Location = new System.Drawing.Point(253, 31);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(95, 13);
            this.lblCreateDate.TabIndex = 35;
            this.lblCreateDate.Text = "Tanggal Pembuatan";
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(354, 55);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(111, 20);
            this.txtDueDate.TabIndex = 34;
            // 
            // txtSPKCategory
            // 
            this.txtSPKCategory.Location = new System.Drawing.Point(116, 82);
            this.txtSPKCategory.Name = "txtSPKCategory";
            this.txtSPKCategory.Size = new System.Drawing.Size(111, 20);
            this.txtSPKCategory.TabIndex = 33;
            // 
            // txtVehicle
            // 
            this.txtVehicle.Location = new System.Drawing.Point(116, 55);
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.Size = new System.Drawing.Size(111, 20);
            this.txtVehicle.TabIndex = 29;
            // 
            // gcSparepart
            // 
            this.gcSparepart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSparepart.Location = new System.Drawing.Point(15, 124);
            this.gcSparepart.MainView = this.gvSparepart;
            this.gcSparepart.Name = "gcSparepart";
            this.gcSparepart.Size = new System.Drawing.Size(453, 113);
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
            // gcMechanic
            // 
            this.gcMechanic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gcMechanic.Location = new System.Drawing.Point(15, 256);
            this.gcMechanic.MainView = this.gvMechanic;
            this.gcMechanic.Name = "gcMechanic";
            this.gcMechanic.Size = new System.Drawing.Size(453, 113);
            this.gcMechanic.TabIndex = 18;
            this.gcMechanic.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMechanic});
            // 
            // gvMechanic
            // 
            this.gvMechanic.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnCode,
            this.colMechanicMechanic,
            this.colFee});
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
            // gridColumnCode
            // 
            this.gridColumnCode.Caption = "Kode";
            this.gridColumnCode.FieldName = "Mechanic.Code";
            this.gridColumnCode.Name = "gridColumnCode";
            this.gridColumnCode.Visible = true;
            this.gridColumnCode.VisibleIndex = 0;
            // 
            // colMechanicMechanic
            // 
            this.colMechanicMechanic.Caption = "Nama Mechanic";
            this.colMechanicMechanic.FieldName = "Mechanic.Name";
            this.colMechanicMechanic.Name = "colMechanicMechanic";
            this.colMechanicMechanic.Visible = true;
            this.colMechanicMechanic.VisibleIndex = 1;
            // 
            // colFee
            // 
            this.colFee.Caption = "Ongkos";
            this.colFee.FieldName = "Fee";
            this.colFee.Name = "colFee";
            this.colFee.Visible = true;
            this.colFee.VisibleIndex = 2;
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(15, 85);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 13);
            this.lblCategory.TabIndex = 13;
            this.lblCategory.Text = "Jenis layanan";
            // 
            // lblDueDate
            // 
            this.lblDueDate.Location = new System.Drawing.Point(253, 58);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(59, 13);
            this.lblDueDate.TabIndex = 12;
            this.lblDueDate.Text = "Batas waktu";
            // 
            // lblVehicle
            // 
            this.lblVehicle.Location = new System.Drawing.Point(15, 58);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(52, 13);
            this.lblVehicle.TabIndex = 2;
            this.lblVehicle.Text = "Kendaraan";
            // 
            // btnReject
            // 
            this.btnReject.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnReject.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnReject.Location = new System.Drawing.Point(131, 402);
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
            this.btnApprove.Location = new System.Drawing.Point(7, 402);
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
            this.btnCancel.Location = new System.Drawing.Point(369, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Tutup";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnPrint.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnPrint.Location = new System.Drawing.Point(248, 402);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(91, 23);
            this.btnPrint.TabIndex = 36;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // SPKViewDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 431);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gcSPK);
            this.Name = "SPKViewDetailForm";
            this.Text = "SPKViewDetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.gcSPK)).EndInit();
            this.gcSPK.ResumeLayout(false);
            this.gcSPK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDueDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPKCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVehicle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMechanic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMechanic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcSPK;
        private DevExpress.XtraGrid.GridControl gcSparepart;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSparepart;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartName;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalQty;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.GridControl gcMechanic;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMechanic;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCode;
        private DevExpress.XtraGrid.Columns.GridColumn colMechanicMechanic;
        private DevExpress.XtraGrid.Columns.GridColumn colFee;
        private DevExpress.XtraEditors.LabelControl lblCategory;
        private DevExpress.XtraEditors.LabelControl lblDueDate;
        private DevExpress.XtraEditors.LabelControl lblVehicle;
        private DevExpress.XtraEditors.TextEdit txtVehicle;
        private DevExpress.XtraEditors.TextEdit txtCreateDate;
        private DevExpress.XtraEditors.TextEdit txtCustomer;
        private DevExpress.XtraEditors.LabelControl lblCustomer;
        private DevExpress.XtraEditors.LabelControl lblCreateDate;
        private DevExpress.XtraEditors.TextEdit txtDueDate;
        private DevExpress.XtraEditors.TextEdit txtSPKCategory;
        private DevExpress.XtraEditors.SimpleButton btnReject;
        private DevExpress.XtraEditors.SimpleButton btnApprove;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl lblCode;
    }
}