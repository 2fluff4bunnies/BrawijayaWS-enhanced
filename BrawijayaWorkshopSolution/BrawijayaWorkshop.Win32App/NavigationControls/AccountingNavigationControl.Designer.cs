namespace BrawijayaWorkshop.Win32App.NavigationControls
{
    partial class AccountingNavigationControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountingNavigationControl));
            this.navbarAccounting = new DevExpress.XtraNavBar.NavBarControl();
            this.navbarGroupAccounting = new DevExpress.XtraNavBar.NavBarGroup();
            this.iFirstBalance = new DevExpress.XtraNavBar.NavBarItem();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.iManualTransaction = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navbarAccounting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // navbarAccounting
            // 
            this.navbarAccounting.ActiveGroup = this.navbarGroupAccounting;
            this.navbarAccounting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navbarAccounting.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navbarGroupAccounting});
            this.navbarAccounting.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.iFirstBalance,
            this.iManualTransaction});
            this.navbarAccounting.Location = new System.Drawing.Point(0, 0);
            this.navbarAccounting.Name = "navbarAccounting";
            this.navbarAccounting.OptionsNavPane.ExpandedWidth = 275;
            this.navbarAccounting.Size = new System.Drawing.Size(275, 425);
            this.navbarAccounting.SmallImages = this.imageCollection;
            this.navbarAccounting.TabIndex = 0;
            this.navbarAccounting.Text = "navBarControl1";
            // 
            // navbarGroupAccounting
            // 
            this.navbarGroupAccounting.Caption = "Accounting";
            this.navbarGroupAccounting.Expanded = true;
            this.navbarGroupAccounting.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.iFirstBalance),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iManualTransaction)});
            this.navbarGroupAccounting.Name = "navbarGroupAccounting";
            // 
            // iFirstBalance
            // 
            this.iFirstBalance.Caption = "Saldo Awal";
            this.iFirstBalance.Name = "iFirstBalance";
            this.iFirstBalance.SmallImageIndex = 2;
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "accounting_16x16.png");
            this.imageCollection.Images.SetKeyName(1, "balance_16x16.png");
            this.imageCollection.Images.SetKeyName(2, "firstbalance_16x16.png");
            this.imageCollection.Images.SetKeyName(3, "sheet_16x16.png");
            this.imageCollection.Images.SetKeyName(4, "Sheet2_16x16.png");
            this.imageCollection.Images.SetKeyName(5, "manual_trans_16x16.png");
            // 
            // iManualTransaction
            // 
            this.iManualTransaction.Caption = "Transaksi Manual";
            this.iManualTransaction.Name = "iManualTransaction";
            this.iManualTransaction.SmallImageIndex = 5;
            // 
            // AccountingNavigationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navbarAccounting);
            this.Name = "AccountingNavigationControl";
            this.Size = new System.Drawing.Size(275, 425);
            ((System.ComponentModel.ISupportInitialize)(this.navbarAccounting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navbarAccounting;
        private DevExpress.XtraNavBar.NavBarGroup navbarGroupAccounting;
        private DevExpress.Utils.ImageCollection imageCollection;
        public DevExpress.XtraNavBar.NavBarItem iFirstBalance;
        public DevExpress.XtraNavBar.NavBarItem iManualTransaction;
    }
}
