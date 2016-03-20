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
            this.iManualTransaction = new DevExpress.XtraNavBar.NavBarItem();
            this.iJournalTransaction = new DevExpress.XtraNavBar.NavBarItem();
            this.iHPPList = new DevExpress.XtraNavBar.NavBarItem();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.iProfitLoss = new DevExpress.XtraNavBar.NavBarItem();
            this.iBalanceTotal = new DevExpress.XtraNavBar.NavBarItem();
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
            this.iManualTransaction,
            this.iJournalTransaction,
            this.iHPPList,
            this.iProfitLoss,
            this.iBalanceTotal});
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
            new DevExpress.XtraNavBar.NavBarItemLink(this.iManualTransaction),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iJournalTransaction),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iHPPList),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iProfitLoss),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iBalanceTotal)});
            this.navbarGroupAccounting.Name = "navbarGroupAccounting";
            // 
            // iFirstBalance
            // 
            this.iFirstBalance.Caption = "Saldo Awal";
            this.iFirstBalance.Name = "iFirstBalance";
            this.iFirstBalance.SmallImageIndex = 2;
            // 
            // iManualTransaction
            // 
            this.iManualTransaction.Caption = "Transaksi Manual";
            this.iManualTransaction.Name = "iManualTransaction";
            this.iManualTransaction.SmallImageIndex = 5;
            // 
            // iJournalTransaction
            // 
            this.iJournalTransaction.Caption = "Lihat Semua Transaksi Jurnal";
            this.iJournalTransaction.Name = "iJournalTransaction";
            this.iJournalTransaction.SmallImageIndex = 4;
            // 
            // iHPPList
            // 
            this.iHPPList.Caption = "HPP";
            this.iHPPList.Name = "iHPPList";
            this.iHPPList.SmallImageIndex = 6;
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
            this.imageCollection.Images.SetKeyName(6, "hpp_16x16.png");
            this.imageCollection.Images.SetKeyName(7, "profitloss_16x16.png");
            // 
            // iProfitLoss
            // 
            this.iProfitLoss.Caption = "Laba / Rugi";
            this.iProfitLoss.Name = "iProfitLoss";
            this.iProfitLoss.SmallImageIndex = 7;
            // 
            // iBalanceTotal
            // 
            this.iBalanceTotal.Caption = "Neraca";
            this.iBalanceTotal.Name = "iBalanceTotal";
            this.iBalanceTotal.SmallImageIndex = 1;
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
        private DevExpress.Utils.ImageCollection imageCollection;
        public DevExpress.XtraNavBar.NavBarItem iFirstBalance;
        public DevExpress.XtraNavBar.NavBarItem iManualTransaction;
        public DevExpress.XtraNavBar.NavBarGroup navbarGroupAccounting;
        public DevExpress.XtraNavBar.NavBarItem iJournalTransaction;
        public DevExpress.XtraNavBar.NavBarItem iHPPList;
        public DevExpress.XtraNavBar.NavBarItem iProfitLoss;
        public DevExpress.XtraNavBar.NavBarItem iBalanceTotal;
    }
}
