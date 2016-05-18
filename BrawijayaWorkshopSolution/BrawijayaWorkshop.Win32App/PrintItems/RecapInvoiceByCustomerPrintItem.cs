using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace BrawijayaWorkshop.Win32App.PrintItems
{
    public partial class RecapInvoiceByCustomerPrintItem : DevExpress.XtraReports.UI.XtraReport
    {
        public RecapInvoiceByCustomerPrintItem(string customer, string category, DateTime from, DateTime to)
        {
            InitializeComponent();
            lblCustomerName.Text = customer;
            lblReportTitle.Text = string.Format("Rekapan Tagihan {0} Bengkel", category);
            lblPeriode.Text = string.Format("Periode: {0} s/d {1}", from.ToString("dd MMMM yyyy"), to.ToString("dd MMMM yyyy"));
        }

    }
}
