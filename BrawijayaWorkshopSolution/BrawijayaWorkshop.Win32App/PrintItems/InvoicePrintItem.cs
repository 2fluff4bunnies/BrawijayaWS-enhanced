using BrawijayaWorkshop.Utils;
using System;
using System.Data;

namespace BrawijayaWorkshop.Win32App.PrintItems
{
    public partial class InvoicePrintItem : DevExpress.XtraReports.UI.XtraReport
    {
        public InvoicePrintItem()
        {
            InitializeComponent();

            lblInvoiceDate.Text = DateTime.Today.ToString("dd/MM/yyyy");

            ReportFooter.BeforePrint += ReportFooter_BeforePrint;
        }

        private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblTotalInWords.Text = ((DataRowView)GetCurrentRow()).Row["TotalPrice"].AsDecimal().NumberToWordID();
        }
    }
}
