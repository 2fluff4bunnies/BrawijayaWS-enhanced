using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BrawijayaWorkshop.Utils;

namespace BrawijayaWorkshop.Win32App.PrintItems
{
    public partial class InvoicePrintItem : DevExpress.XtraReports.UI.XtraReport
    {
        public InvoicePrintItem()
        {
            InitializeComponent();

            lblInvoiceDate.Text = DateTime.Today.ToString("dd/MM/yyyy");

            lblTotalInWords.BeforePrint += lblTotalInWords_BeforePrint;
        }

        private void lblTotalInWords_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((XRLabel)sender).Text = DetailReport.GetCurrentColumnValue("TotalPrice").AsDecimal().NumberToWordID();
        }

    }
}
