namespace BrawijayaWorkshop.Win32App.PrintItems
{
    partial class SalesReturn
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
            this.components = new System.ComponentModel.Container();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.DataSourceSalesReturnViewModel = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.title = new DevExpress.XtraReports.UI.XRLabel();
            this.lblSpkDate = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblSpkNumber = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DataSourceSalesReturnViewModel)).BeginInit();
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
            this.TopMargin.HeightF = 18F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 25F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // DataSourceSalesReturnViewModel
            // 
            this.DataSourceSalesReturnViewModel.DataSource = typeof(BrawijayaWorkshop.SharedObject.ViewModels.SalesReturnViewModel);
            this.DataSourceSalesReturnViewModel.Name = "DataSourceSalesReturnViewModel";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblSpkNumber,
            this.xrLabel7,
            this.xrLabel6,
            this.lblSpkDate,
            this.xrLabel4,
            this.xrLabel2,
            this.title});
            this.ReportHeader.HeightF = 100F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // ReportFooter
            // 
            this.ReportFooter.HeightF = 103.125F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Segoe UI Light", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.title.LocationFloat = new DevExpress.Utils.PointFloat(0F, 3.60419F);
            this.title.Name = "title";
            this.title.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.title.SizeF = new System.Drawing.SizeF(123.1354F, 23F);
            this.title.StylePriority.UseFont = false;
            this.title.StylePriority.UseTextAlignment = false;
            this.title.Text = "Sales Return";
            this.title.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblSpkDate
            // 
            this.lblSpkDate.CanShrink = true;
            this.lblSpkDate.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CreateDate", "{0:dd MMM yyyy}")});
            this.lblSpkDate.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblSpkDate.LocationFloat = new DevExpress.Utils.PointFloat(108.7708F, 26.60418F);
            this.lblSpkDate.Name = "lblSpkDate";
            this.lblSpkDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.lblSpkDate.SizeF = new System.Drawing.SizeF(79.16666F, 23F);
            this.lblSpkDate.StylePriority.UseFont = false;
            this.lblSpkDate.StylePriority.UsePadding = false;
            this.lblSpkDate.StylePriority.UseTextAlignment = false;
            this.lblSpkDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblSpkDate.WordWrap = false;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(95.22913F, 26.60418F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(13.54164F, 23F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UsePadding = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = ":";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 26.60419F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(95.22913F, 22.99999F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UsePadding = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Tanggal";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblSpkNumber
            // 
            this.lblSpkNumber.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Invoice.SPK.Code")});
            this.lblSpkNumber.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblSpkNumber.LocationFloat = new DevExpress.Utils.PointFloat(108.7708F, 66.99999F);
            this.lblSpkNumber.Name = "lblSpkNumber";
            this.lblSpkNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.lblSpkNumber.SizeF = new System.Drawing.SizeF(277.0833F, 23F);
            this.lblSpkNumber.StylePriority.UseFont = false;
            this.lblSpkNumber.StylePriority.UsePadding = false;
            this.lblSpkNumber.StylePriority.UseTextAlignment = false;
            this.lblSpkNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(95.22912F, 66.99999F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(13.54166F, 23F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UsePadding = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = ":";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 66.99999F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(95.22913F, 23.00001F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Nomor";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // SalesReturn
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.ReportFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.DataSourceSalesReturnViewModel});
            this.DataSource = this.DataSourceSalesReturnViewModel;
            this.Margins = new System.Drawing.Printing.Margins(16, 18, 18, 25);
            this.Version = "15.1";
            ((System.ComponentModel.ISupportInitialize)(this.DataSourceSalesReturnViewModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource DataSourceSalesReturnViewModel;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel title;
        private DevExpress.XtraReports.UI.XRLabel lblSpkDate;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel lblSpkNumber;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
    }
}
