namespace BrawijayaWorkshop.Win32App.NavigationControls
{
    partial class MasterDataNavigationControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterDataNavigationControl));
            this.navbarMasterData = new DevExpress.XtraNavBar.NavBarControl();
            this.navbarGroupMasterData = new DevExpress.XtraNavBar.NavBarGroup();
            this.iCustomer = new DevExpress.XtraNavBar.NavBarItem();
            this.iSupplier = new DevExpress.XtraNavBar.NavBarItem();
            this.iSparepart = new DevExpress.XtraNavBar.NavBarItem();
            this.iMechanic = new DevExpress.XtraNavBar.NavBarItem();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.iVehicle = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navbarMasterData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // navbarMasterData
            // 
            this.navbarMasterData.ActiveGroup = this.navbarGroupMasterData;
            this.navbarMasterData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navbarMasterData.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navbarGroupMasterData});
            this.navbarMasterData.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.iSupplier,
            this.iCustomer,
            this.iSparepart,
            this.iMechanic,
            this.iVehicle});
            this.navbarMasterData.Location = new System.Drawing.Point(0, 0);
            this.navbarMasterData.Name = "navbarMasterData";
            this.navbarMasterData.OptionsNavPane.ExpandedWidth = 254;
            this.navbarMasterData.Size = new System.Drawing.Size(254, 358);
            this.navbarMasterData.SmallImages = this.imageCollection;
            this.navbarMasterData.TabIndex = 0;
            this.navbarMasterData.Text = "navBarControl1";
            // 
            // navbarGroupMasterData
            // 
            this.navbarGroupMasterData.Caption = "Master Data";
            this.navbarGroupMasterData.Expanded = true;
            this.navbarGroupMasterData.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.iCustomer),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iSupplier),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iSparepart),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iMechanic),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iVehicle)});
            this.navbarGroupMasterData.Name = "navbarGroupMasterData";
            // 
            // iCustomer
            // 
            this.iCustomer.Caption = "Customer";
            this.iCustomer.Name = "iCustomer";
            this.iCustomer.SmallImageIndex = 1;
            // 
            // iSupplier
            // 
            this.iSupplier.Caption = "Supplier";
            this.iSupplier.Name = "iSupplier";
            this.iSupplier.SmallImageIndex = 0;
            // 
            // iSparepart
            // 
            this.iSparepart.Caption = "Sparepart";
            this.iSparepart.Name = "iSparepart";
            this.iSparepart.SmallImageIndex = 2;
            // 
            // iMechanic
            // 
            this.iMechanic.Caption = "Mekanik";
            this.iMechanic.Name = "iMechanic";
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "supplier_16x16.png");
            this.imageCollection.Images.SetKeyName(1, "customer.png");
            this.imageCollection.Images.SetKeyName(2, "sparepart.png");
            this.imageCollection.Images.SetKeyName(3, "Truck-Left-Green-icon-16x16.png");
            // 
            // iVehicle
            // 
            this.iVehicle.Caption = "Vehicle";
            this.iVehicle.Name = "iVehicle";
            this.iVehicle.SmallImageIndex = 3;
            // 
            // MasterDataNavigationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navbarMasterData);
            this.Name = "MasterDataNavigationControl";
            this.Size = new System.Drawing.Size(254, 358);
            ((System.ComponentModel.ISupportInitialize)(this.navbarMasterData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navbarMasterData;
        private DevExpress.XtraNavBar.NavBarGroup navbarGroupMasterData;
        private DevExpress.Utils.ImageCollection imageCollection;
        public DevExpress.XtraNavBar.NavBarItem iSupplier;
        public DevExpress.XtraNavBar.NavBarItem iCustomer;
        public DevExpress.XtraNavBar.NavBarItem iSparepart;
        public DevExpress.XtraNavBar.NavBarItem iMechanic;
        public DevExpress.XtraNavBar.NavBarItem iVehicle;
    }
}
