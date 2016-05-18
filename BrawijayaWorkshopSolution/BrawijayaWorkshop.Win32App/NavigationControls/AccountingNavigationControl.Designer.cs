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
            this.iBalanceTotal = new DevExpress.XtraNavBar.NavBarItem();
            this.iBalanceSheet = new DevExpress.XtraNavBar.NavBarItem();
            this.iProfitLoss = new DevExpress.XtraNavBar.NavBarItem();
            this.iBalanceHelper = new DevExpress.XtraNavBar.NavBarItem();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navbarAccounting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // navbarAccounting
            // 
            this.navbarAccounting.ActiveGroup = this.navbarGroupAccounting;
            this.navbarAccounting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navbarAccounting.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navbarAccounting.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navbarGroupAccounting});
            this.navbarAccounting.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.iFirstBalance,
            this.iManualTransaction,
            this.iJournalTransaction,
            this.iProfitLoss,
            this.iBalanceTotal,
            this.iBalanceSheet,
            this.iBalanceHelper});
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
            new DevExpress.XtraNavBar.NavBarItemLink(this.iBalanceTotal),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iBalanceSheet),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iProfitLoss),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iBalanceHelper)});
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
            this.iJournalTransaction.Caption = "Daftar Transaksi Jurnal";
            this.iJournalTransaction.Name = "iJournalTransaction";
            this.iJournalTransaction.SmallImageIndex = 4;
            // 
            // iBalanceTotal
            // 
            this.iBalanceTotal.Caption = "Neraca Saldo";
            this.iBalanceTotal.Name = "iBalanceTotal";
            this.iBalanceTotal.SmallImageIndex = 1;
            // 
            // iBalanceSheet
            // 
            this.iBalanceSheet.Caption = "Neraca";
            this.iBalanceSheet.Name = "iBalanceSheet";
            this.iBalanceSheet.SmallImageIndex = 1;
            // 
            // iProfitLoss
            // 
            this.iProfitLoss.Caption = "Laba / Rugi";
            this.iProfitLoss.Name = "iProfitLoss";
            this.iProfitLoss.SmallImageIndex = 7;
            // 
            // iBalanceHelper
            // 
            this.iBalanceHelper.Caption = "Buku Pembantu";
            this.iBalanceHelper.Name = "iBalanceHelper";
            this.iBalanceHelper.SmallImageIndex = 8;
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
            this.imageCollection.Images.SetKeyName(8, "balancehelper_16x16.png");
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
        public DevExpress.XtraNavBar.NavBarItem iProfitLoss;
        public DevExpress.XtraNavBar.NavBarItem iBalanceTotal;
        public DevExpress.XtraNavBar.NavBarItem iBalanceSheet;
        public DevExpress.XtraNavBar.NavBarItem iBalanceHelper;
    }
}
