namespace BrawijayaWorkshop.Win32App.NavigationControls
{
    partial class TransactionDataNavigationControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionDataNavigationControl));
            this.navbarTransactionData = new DevExpress.XtraNavBar.NavBarControl();
            this.navbarGroupTransactionData = new DevExpress.XtraNavBar.NavBarGroup();
            this.iPurchasing = new DevExpress.XtraNavBar.NavBarItem();
            this.iGuestBook = new DevExpress.XtraNavBar.NavBarItem();
            this.iSPK = new DevExpress.XtraNavBar.NavBarItem();
            this.iSPKSchedule = new DevExpress.XtraNavBar.NavBarItem();
            this.iSPKSales = new DevExpress.XtraNavBar.NavBarItem();
            this.iInvoice = new DevExpress.XtraNavBar.NavBarItem();
            this.iDebt = new DevExpress.XtraNavBar.NavBarItem();
            this.iCredit = new DevExpress.XtraNavBar.NavBarItem();
            this.iPurchaseReturn = new DevExpress.XtraNavBar.NavBarItem();
            this.iSalesReturn = new DevExpress.XtraNavBar.NavBarItem();
            this.iUsedGoodTrans = new DevExpress.XtraNavBar.NavBarItem();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navbarTransactionData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // navbarTransactionData
            // 
            this.navbarTransactionData.ActiveGroup = this.navbarGroupTransactionData;
            this.navbarTransactionData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navbarTransactionData.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navbarTransactionData.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navbarGroupTransactionData});
            this.navbarTransactionData.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.iPurchasing,
            this.iSPK,
            this.iUsedGoodTrans,
            this.iGuestBook,
            this.iDebt,
            this.iCredit,
            this.iInvoice,
            this.iPurchaseReturn,
            this.iSalesReturn,
            this.iSPKSales,
            this.iSPKSchedule});
            this.navbarTransactionData.Location = new System.Drawing.Point(0, 0);
            this.navbarTransactionData.Name = "navbarTransactionData";
            this.navbarTransactionData.OptionsNavPane.ExpandedWidth = 249;
            this.navbarTransactionData.Size = new System.Drawing.Size(249, 315);
            this.navbarTransactionData.SmallImages = this.imageCollection;
            this.navbarTransactionData.TabIndex = 0;
            this.navbarTransactionData.Text = "navBarControl1";
            // 
            // navbarGroupTransactionData
            // 
            this.navbarGroupTransactionData.Caption = "Transaction Data";
            this.navbarGroupTransactionData.Expanded = true;
            this.navbarGroupTransactionData.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.iPurchasing),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iGuestBook),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iSPK),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iSPKSchedule),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iSPKSales),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iInvoice),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iDebt),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iCredit),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iPurchaseReturn),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iSalesReturn),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iUsedGoodTrans)});
            this.navbarGroupTransactionData.Name = "navbarGroupTransactionData";
            // 
            // iPurchasing
            // 
            this.iPurchasing.Caption = "Pembelian";
            this.iPurchasing.Name = "iPurchasing";
            this.iPurchasing.SmallImageIndex = 0;
            // 
            // iGuestBook
            // 
            this.iGuestBook.Caption = "Daftar Kendaraan Masuk";
            this.iGuestBook.Name = "iGuestBook";
            this.iGuestBook.SmallImageIndex = 4;
            // 
            // iSPK
            // 
            this.iSPK.Caption = "SPK";
            this.iSPK.LargeImageIndex = 1;
            this.iSPK.Name = "iSPK";
            this.iSPK.SmallImageIndex = 1;
            // 
            // iSPKSchedule
            // 
            this.iSPKSchedule.Caption = "Update Harian SPK";
            this.iSPKSchedule.Name = "iSPKSchedule";
            this.iSPKSchedule.SmallImageIndex = 1;
            // 
            // iSPKSales
            // 
            this.iSPKSales.Caption = "Penjualan Sparepart";
            this.iSPKSales.Name = "iSPKSales";
            this.iSPKSales.SmallImageIndex = 6;
            // 
            // iInvoice
            // 
            this.iInvoice.Caption = "Invoice";
            this.iInvoice.Name = "iInvoice";
            this.iInvoice.SmallImageIndex = 5;
            // 
            // iDebt
            // 
            this.iDebt.Caption = "Pembayaran Utang";
            this.iDebt.Name = "iDebt";
            this.iDebt.SmallImageIndex = 5;
            // 
            // iCredit
            // 
            this.iCredit.Caption = "Pembayaran Piutang";
            this.iCredit.Name = "iCredit";
            this.iCredit.SmallImageIndex = 5;
            // 
            // iPurchaseReturn
            // 
            this.iPurchaseReturn.Caption = "Retur Pembelian";
            this.iPurchaseReturn.Name = "iPurchaseReturn";
            this.iPurchaseReturn.SmallImageIndex = 2;
            // 
            // iSalesReturn
            // 
            this.iSalesReturn.Caption = "Retur Penjualan";
            this.iSalesReturn.Name = "iSalesReturn";
            this.iSalesReturn.SmallImageIndex = 2;
            // 
            // iUsedGoodTrans
            // 
            this.iUsedGoodTrans.Caption = "Barang Bekas";
            this.iUsedGoodTrans.Name = "iUsedGoodTrans";
            this.iUsedGoodTrans.SmallImageIndex = 2;
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "purchasing 16x16.png");
            this.imageCollection.Images.SetKeyName(1, "SPK_16x16.png");
            this.imageCollection.Images.SetKeyName(2, "usedgood_16x16.png");
            this.imageCollection.Images.SetKeyName(3, "manual_trans_16x16.png");
            this.imageCollection.Images.SetKeyName(4, "Truck-Left-Green-icon-16x16.png");
            this.imageCollection.Images.SetKeyName(5, "payment 16x16.png");
            this.imageCollection.Images.SetKeyName(6, "1459804460_Shopping_Cart.png");
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "navBarItem1";
            this.navBarItem1.Name = "navBarItem1";
            // 
            // TransactionDataNavigationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navbarTransactionData);
            this.Name = "TransactionDataNavigationControl";
            this.Size = new System.Drawing.Size(249, 315);
            ((System.ComponentModel.ISupportInitialize)(this.navbarTransactionData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navbarTransactionData;
        private DevExpress.XtraNavBar.NavBarGroup navbarGroupTransactionData;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        public DevExpress.XtraNavBar.NavBarItem iPurchasing;
        public DevExpress.XtraNavBar.NavBarItem iSPK;
        public DevExpress.XtraNavBar.NavBarItem iUsedGoodTrans;
        public DevExpress.XtraNavBar.NavBarItem iGuestBook;
        public DevExpress.XtraNavBar.NavBarItem iDebt;
        public DevExpress.XtraNavBar.NavBarItem iCredit;
        public DevExpress.XtraNavBar.NavBarItem iInvoice;
        public DevExpress.XtraNavBar.NavBarItem iPurchaseReturn;
        public DevExpress.XtraNavBar.NavBarItem iSalesReturn;
        public DevExpress.XtraNavBar.NavBarItem iSPKSales;
        public DevExpress.XtraNavBar.NavBarItem iSPKSchedule;
    }
}
