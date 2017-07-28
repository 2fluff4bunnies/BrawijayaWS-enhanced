namespace BrawijayaWorkshop.Win32App.NavigationControls
{
    partial class ReportingDataNavigationControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportingDataNavigationControl));
            this.navbarReportingData = new DevExpress.XtraNavBar.NavBarControl();
            this.navbarGroupReportingData = new DevExpress.XtraNavBar.NavBarGroup();
            this.iSPKHistory = new DevExpress.XtraNavBar.NavBarItem();
            this.iRecapInvoiceBySPK = new DevExpress.XtraNavBar.NavBarItem();
            this.iRecapInvoiceByVehicleGroup = new DevExpress.XtraNavBar.NavBarItem();
            this.iRecapInvoiceByCustomer = new DevExpress.XtraNavBar.NavBarItem();
            this.iHistorySparepart = new DevExpress.XtraNavBar.NavBarItem();
            this.iStockOpname = new DevExpress.XtraNavBar.NavBarItem();
            this.iRecapPurchasingBySupplier = new DevExpress.XtraNavBar.NavBarItem();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navbarReportingData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // navbarReportingData
            // 
            this.navbarReportingData.ActiveGroup = this.navbarGroupReportingData;
            this.navbarReportingData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navbarReportingData.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navbarReportingData.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navbarGroupReportingData});
            this.navbarReportingData.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.iSPKHistory,
            this.iRecapInvoiceBySPK,
            this.iRecapInvoiceByVehicleGroup,
            this.iRecapInvoiceByCustomer,
            this.iHistorySparepart,
            this.iStockOpname,
            this.iRecapPurchasingBySupplier});
            this.navbarReportingData.Location = new System.Drawing.Point(0, 0);
            this.navbarReportingData.Name = "navbarReportingData";
            this.navbarReportingData.OptionsNavPane.ExpandedWidth = 195;
            this.navbarReportingData.Size = new System.Drawing.Size(195, 288);
            this.navbarReportingData.SmallImages = this.imageCollection;
            this.navbarReportingData.TabIndex = 0;
            this.navbarReportingData.Text = "navBarControl1";
            // 
            // navbarGroupReportingData
            // 
            this.navbarGroupReportingData.Caption = "Reporting";
            this.navbarGroupReportingData.Expanded = true;
            this.navbarGroupReportingData.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.iSPKHistory),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iRecapInvoiceBySPK),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iRecapInvoiceByVehicleGroup),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iRecapInvoiceByCustomer),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iHistorySparepart),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iStockOpname),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iRecapPurchasingBySupplier)});
            this.navbarGroupReportingData.Name = "navbarGroupReportingData";
            // 
            // iSPKHistory
            // 
            this.iSPKHistory.Caption = "Report History Pelayanan";
            this.iSPKHistory.LargeImageIndex = 0;
            this.iSPKHistory.Name = "iSPKHistory";
            this.iSPKHistory.SmallImageIndex = 0;
            // 
            // iRecapInvoiceBySPK
            // 
            this.iRecapInvoiceBySPK.Caption = "Rekap Tagihan Nopol";
            this.iRecapInvoiceBySPK.Name = "iRecapInvoiceBySPK";
            this.iRecapInvoiceBySPK.SmallImageIndex = 1;
            // 
            // iRecapInvoiceByVehicleGroup
            // 
            this.iRecapInvoiceByVehicleGroup.Caption = "Rekap Tagihan Kelompok";
            this.iRecapInvoiceByVehicleGroup.Name = "iRecapInvoiceByVehicleGroup";
            this.iRecapInvoiceByVehicleGroup.SmallImageIndex = 2;
            // 
            // iRecapInvoiceByCustomer
            // 
            this.iRecapInvoiceByCustomer.Caption = "Rekap Tagihan Customer";
            this.iRecapInvoiceByCustomer.Name = "iRecapInvoiceByCustomer";
            this.iRecapInvoiceByCustomer.SmallImageIndex = 3;
            // 
            // iHistorySparepart
            // 
            this.iHistorySparepart.Caption = "History Sparepart";
            this.iHistorySparepart.Name = "iHistorySparepart";
            this.iHistorySparepart.SmallImageIndex = 0;
            // 
            // iStockOpname
            // 
            this.iStockOpname.Caption = "Stock Opname";
            this.iStockOpname.Name = "iStockOpname";
            this.iStockOpname.SmallImageIndex = 0;
            // 
            // iRecapPurchasingBySupplier
            // 
            this.iRecapPurchasingBySupplier.Caption = "Rekap Pembelian";
            this.iRecapPurchasingBySupplier.Name = "iRecapPurchasingBySupplier";
            this.iRecapPurchasingBySupplier.SmallImageIndex = 2;
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "reporting 16x16.png");
            this.imageCollection.Images.SetKeyName(1, "invoice1_16x16.png");
            this.imageCollection.Images.SetKeyName(2, "invoice2_16x16.png");
            this.imageCollection.Images.SetKeyName(3, "invoice3_16x16.png");
            // 
            // ReportingDataNavigationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navbarReportingData);
            this.Name = "ReportingDataNavigationControl";
            this.Size = new System.Drawing.Size(195, 288);
            ((System.ComponentModel.ISupportInitialize)(this.navbarReportingData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navbarReportingData;
        private DevExpress.XtraNavBar.NavBarGroup navbarGroupReportingData;
        public DevExpress.XtraNavBar.NavBarItem iSPKHistory;
        private DevExpress.Utils.ImageCollection imageCollection;
        public DevExpress.XtraNavBar.NavBarItem iRecapInvoiceBySPK;
        public DevExpress.XtraNavBar.NavBarItem iRecapInvoiceByVehicleGroup;
        public DevExpress.XtraNavBar.NavBarItem iRecapInvoiceByCustomer;
        public DevExpress.XtraNavBar.NavBarItem iHistorySparepart;
        public DevExpress.XtraNavBar.NavBarItem iStockOpname;
        public DevExpress.XtraNavBar.NavBarItem iRecapPurchasingBySupplier;
    }
}
