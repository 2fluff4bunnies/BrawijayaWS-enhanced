namespace BrawijayaWorkshop.Win32App.PrintItems
{
    partial class RecapInvoiceByVehicleGroupPrintItem
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecapInvoiceByVehicleGroupPrintItem));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.RecapInvoiceGroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.lblReportTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPeriode = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.RecapInvoiceGroupFooter = new DevExpress.XtraReports.UI.GroupFooterBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 100F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 1.041667F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 5.208333F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // RecapInvoiceGroupHeader
            // 
            this.RecapInvoiceGroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblReportTitle,
            this.lblPeriode,
            this.xrPictureBox1});
            this.RecapInvoiceGroupHeader.HeightF = 100F;
            this.RecapInvoiceGroupHeader.Name = "RecapInvoiceGroupHeader";
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Underline);
            this.lblReportTitle.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblReportTitle.SizeF = new System.Drawing.SizeF(673.7899F, 31.33334F);
            this.lblReportTitle.StylePriority.UseFont = false;
            this.lblReportTitle.StylePriority.UseTextAlignment = false;
            this.lblReportTitle.Text = "Rekapan Tagihan {0} Bengkel";
            this.lblReportTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblPeriode
            // 
            this.lblPeriode.LocationFloat = new DevExpress.Utils.PointFloat(0F, 31.33334F);
            this.lblPeriode.Name = "lblPeriode";
            this.lblPeriode.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPeriode.SizeF = new System.Drawing.SizeF(673.79F, 23F);
            this.lblPeriode.Text = "Periode: {0} s/d {1}";
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(673.79F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(77.21F, 76.04F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // RecapInvoiceGroupFooter
            // 
            this.RecapInvoiceGroupFooter.HeightF = 100F;
            this.RecapInvoiceGroupFooter.Name = "RecapInvoiceGroupFooter";
            // 
            // RecapInvoiceByVehicleGroupPrintItem
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.RecapInvoiceGroupHeader,
            this.RecapInvoiceGroupFooter});
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Margins = new System.Drawing.Printing.Margins(34, 33, 1, 5);
            this.PageHeight = 600;
            this.PageWidth = 818;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.Version = "15.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.GroupHeaderBand RecapInvoiceGroupHeader;
        private DevExpress.XtraReports.UI.XRLabel lblReportTitle;
        private DevExpress.XtraReports.UI.XRLabel lblPeriode;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.GroupFooterBand RecapInvoiceGroupFooter;
    }
}
