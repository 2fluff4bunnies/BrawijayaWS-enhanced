namespace BrawijayaWorkshop.Win32App.PrintItems
{
    partial class FIFOSparepartStockCardPrintItem
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
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblFrom = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblSparepartName = new DevExpress.XtraReports.UI.XRLabel();
            this.dsFIFO = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFIFO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail.HeightF = 26.66667F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 27F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 24F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblSparepartName,
            this.xrLabel2,
            this.xrLabel1,
            this.lblFrom,
            this.xrLabel3,
            this.lblTo});
            this.ReportHeader.HeightF = 52.33334F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.PageHeader.HeightF = 26.66667F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(179.9999F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Laporan FIFO Sparepart";
            // 
            // lblFrom
            // 
            this.lblFrom.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblFrom.LocationFloat = new DevExpress.Utils.PointFloat(179.9999F, 0F);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblFrom.SizeF = new System.Drawing.SizeF(77.49995F, 23F);
            this.lblFrom.StylePriority.UseFont = false;
            this.lblFrom.Text = "dd-MM-yyyy";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(257.5F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(29.16663F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "s/d";
            // 
            // lblTo
            // 
            this.lblTo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblTo.LocationFloat = new DevExpress.Utils.PointFloat(286.6665F, 0F);
            this.lblTo.Name = "lblTo";
            this.lblTo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTo.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lblTo.StylePriority.UseFont = false;
            this.lblTo.Text = "dd-MM-yyyy";
            // 
            // xrTable1
            // 
            this.xrTable1.Font = new System.Drawing.Font("Tahoma", 7F);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(802F, 26.66667F);
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell3,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "Tanggal";
            this.xrTableCell1.Weight = 0.72033848505629761D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Text = "Harga Satuan";
            this.xrTableCell3.Weight = 1.829567901137038D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Text = "Saldo Awal";
            this.xrTableCell5.Weight = 1.5508465203560471D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Text = "Masuk";
            this.xrTableCell6.Weight = 1.2966101896667011D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Text = "Keluar";
            this.xrTableCell7.Weight = 1.3474585084671498D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Text = "Saldo Akhir";
            this.xrTableCell8.Weight = 1.4111122679972339D;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.33334F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(70.83326F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "Sparepart:";
            // 
            // lblSparepartName
            // 
            this.lblSparepartName.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblSparepartName.LocationFloat = new DevExpress.Utils.PointFloat(70.83326F, 29.33334F);
            this.lblSparepartName.Name = "lblSparepartName";
            this.lblSparepartName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblSparepartName.SizeF = new System.Drawing.SizeF(731.1667F, 23F);
            this.lblSparepartName.StylePriority.UseFont = false;
            this.lblSparepartName.Text = "Sparepart:";
            // 
            // dsFIFO
            // 
            this.dsFIFO.DataSource = typeof(BrawijayaWorkshop.SharedObject.ViewModels.GroupSparepartStockCardViewModel);
            this.dsFIFO.Name = "dsFIFO";
            // 
            // xrTable2
            // 
            this.xrTable2.Font = new System.Drawing.Font("Tahoma", 7F);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(802F, 26.66667F);
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2,
            this.xrTableCell4,
            this.xrTableCell9,
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell12});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "LastPurchaseDate", "{0:dd-MM-yyyy}")});
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Weight = 0.72033848505629761D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "PricePerItem", "{0:#,#;(#,#);0}")});
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Weight = 1.829567901137038D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "TotalQtyFirst", "{0:#,#;(#,#);0}")});
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Weight = 1.5508465203560471D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "TotalQtyIn", "{0:#,#;(#,#);0}")});
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Weight = 1.2966101896667011D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "TotalQtyOut", "{0:#,#;(#,#);0}")});
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Weight = 1.3474585084671498D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "TotalQtyLast", "{0:#,#;(#,#);0}")});
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Weight = 1.4111122679972339D;
            // 
            // ReportFooter
            // 
            this.ReportFooter.HeightF = 100F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // FIFOSparepartStockCardPrintItem
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.ReportFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dsFIFO});
            this.DataSource = this.dsFIFO;
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Margins = new System.Drawing.Printing.Margins(25, 23, 27, 24);
            this.Version = "15.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFIFO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel lblFrom;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel lblTo;
        private DevExpress.XtraReports.UI.XRLabel lblSparepartName;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource dsFIFO;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
    }
}
