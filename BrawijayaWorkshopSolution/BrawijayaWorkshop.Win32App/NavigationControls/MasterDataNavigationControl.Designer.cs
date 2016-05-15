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
            this.iManageRole = new DevExpress.XtraNavBar.NavBarItem();
            this.iManageRoleAccess = new DevExpress.XtraNavBar.NavBarItem();
            this.iManageUser = new DevExpress.XtraNavBar.NavBarItem();
            this.iManageUserRole = new DevExpress.XtraNavBar.NavBarItem();
            this.iUserList = new DevExpress.XtraNavBar.NavBarItem();
            this.iJournal = new DevExpress.XtraNavBar.NavBarItem();
            this.iJournalCategory = new DevExpress.XtraNavBar.NavBarItem();
            this.iCustomer = new DevExpress.XtraNavBar.NavBarItem();
            this.iSupplier = new DevExpress.XtraNavBar.NavBarItem();
            this.iSparepart = new DevExpress.XtraNavBar.NavBarItem();
            this.iMechanic = new DevExpress.XtraNavBar.NavBarItem();
            this.iBrand = new DevExpress.XtraNavBar.NavBarItem();
            this.iType = new DevExpress.XtraNavBar.NavBarItem();
            this.iVehicle = new DevExpress.XtraNavBar.NavBarItem();
            this.iSpecialSparepart = new DevExpress.XtraNavBar.NavBarItem();
            this.iUsedGood = new DevExpress.XtraNavBar.NavBarItem();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.iVehicleGroup = new DevExpress.XtraNavBar.NavBarItem();
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
            this.iVehicle,
            this.iJournal,
            this.iManageRole,
            this.iManageUser,
            this.iManageRoleAccess,
            this.iUserList,
            this.iManageUserRole,
            this.iSpecialSparepart,
            this.iUsedGood,
            this.iJournalCategory,
            this.iBrand,
            this.iType,
            this.iVehicleGroup});
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
            new DevExpress.XtraNavBar.NavBarItemLink(this.iManageRole),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iManageRoleAccess),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iManageUser),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iManageUserRole),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iUserList),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iJournal),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iJournalCategory),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iCustomer),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iVehicleGroup),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iSupplier),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iSparepart),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iMechanic),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iBrand),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iType),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iVehicle),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iSpecialSparepart),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iUsedGood)});
            this.navbarGroupMasterData.Name = "navbarGroupMasterData";
            // 
            // iManageRole
            // 
            this.iManageRole.Caption = "Role Manager";
            this.iManageRole.Name = "iManageRole";
            this.iManageRole.SmallImageIndex = 7;
            // 
            // iManageRoleAccess
            // 
            this.iManageRoleAccess.Caption = "Role Accessibility";
            this.iManageRoleAccess.Name = "iManageRoleAccess";
            this.iManageRoleAccess.SmallImageIndex = 8;
            // 
            // iManageUser
            // 
            this.iManageUser.Caption = "User Manager";
            this.iManageUser.Name = "iManageUser";
            this.iManageUser.SmallImageIndex = 6;
            // 
            // iManageUserRole
            // 
            this.iManageUserRole.Caption = "User Role Manager";
            this.iManageUserRole.Name = "iManageUserRole";
            this.iManageUserRole.SmallImageIndex = 9;
            // 
            // iUserList
            // 
            this.iUserList.Caption = "Daftar User";
            this.iUserList.Name = "iUserList";
            this.iUserList.SmallImageIndex = 6;
            // 
            // iJournal
            // 
            this.iJournal.Caption = "Daftar Akun Jurnal";
            this.iJournal.Name = "iJournal";
            this.iJournal.SmallImageIndex = 5;
            // 
            // iJournalCategory
            // 
            this.iJournalCategory.Caption = "Daftar Kategori Jurnal";
            this.iJournalCategory.Name = "iJournalCategory";
            this.iJournalCategory.SmallImageIndex = 13;
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
            this.iMechanic.SmallImageIndex = 4;
            // 
            // iBrand
            // 
            this.iBrand.Caption = "Brand";
            this.iBrand.Name = "iBrand";
            this.iBrand.SmallImageIndex = 14;
            // 
            // iType
            // 
            this.iType.Caption = "Tipe";
            this.iType.Name = "iType";
            this.iType.SmallImageIndex = 15;
            // 
            // iVehicle
            // 
            this.iVehicle.Caption = "Kendaraan";
            this.iVehicle.Name = "iVehicle";
            this.iVehicle.SmallImageIndex = 3;
            // 
            // iSpecialSparepart
            // 
            this.iSpecialSparepart.Caption = "Special Sparepart";
            this.iSpecialSparepart.Name = "iSpecialSparepart";
            this.iSpecialSparepart.SmallImageIndex = 12;
            // 
            // iUsedGood
            // 
            this.iUsedGood.Caption = "Barang Bekas";
            this.iUsedGood.Name = "iUsedGood";
            this.iUsedGood.SmallImageIndex = 11;
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "supplier_16x16.png");
            this.imageCollection.Images.SetKeyName(1, "customer.png");
            this.imageCollection.Images.SetKeyName(2, "sparepart.png");
            this.imageCollection.Images.SetKeyName(3, "Truck-Left-Green-icon-16x16.png");
            this.imageCollection.Images.SetKeyName(4, "mechanic 16x16.png");
            this.imageCollection.Images.SetKeyName(5, "journal-icon.png");
            this.imageCollection.Images.SetKeyName(6, "users_32x32.png");
            this.imageCollection.Images.SetKeyName(7, "role_32x32.png");
            this.imageCollection.Images.SetKeyName(8, "role_access_16x16.png");
            this.imageCollection.Images.SetKeyName(9, "user_role_16x16.png");
            this.imageCollection.Images.SetKeyName(10, "Tire_16x16.png");
            this.imageCollection.Images.SetKeyName(11, "usedgood_16x16.png");
            this.imageCollection.Images.SetKeyName(12, "barcode_16x16.png");
            this.imageCollection.Images.SetKeyName(13, "category_16x16.png");
            this.imageCollection.Images.SetKeyName(14, "brand-icon_16x16.png");
            this.imageCollection.Images.SetKeyName(15, "type_16x16.png");
            this.imageCollection.Images.SetKeyName(16, "group_16x16.png");
            // 
            // iVehicleGroup
            // 
            this.iVehicleGroup.Caption = "Kelompok";
            this.iVehicleGroup.Name = "iVehicleGroup";
            this.iVehicleGroup.SmallImageIndex = 16;
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
        public DevExpress.XtraNavBar.NavBarItem iJournal;
        public DevExpress.XtraNavBar.NavBarItem iManageRole;
        public DevExpress.XtraNavBar.NavBarItem iManageUser;
        public DevExpress.XtraNavBar.NavBarItem iManageRoleAccess;
        public DevExpress.XtraNavBar.NavBarItem iUserList;
        public DevExpress.XtraNavBar.NavBarItem iManageUserRole;
        public DevExpress.XtraNavBar.NavBarItem iSpecialSparepart;
        public DevExpress.XtraNavBar.NavBarItem iUsedGood;
        public DevExpress.XtraNavBar.NavBarItem iJournalCategory;
        public DevExpress.XtraNavBar.NavBarItem iBrand;
        public DevExpress.XtraNavBar.NavBarItem iType;
        public DevExpress.XtraNavBar.NavBarItem iVehicleGroup;
    }
}
