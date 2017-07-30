using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace BrawijayaWorkshop.Win32App.PrintItems
{
    public partial class RecapPurchasingBySupplierPrintItem : DevExpress.XtraReports.UI.XtraReport
    {
        public RecapPurchasingBySupplierPrintItem(string supplier, DateTime from, DateTime to)
        {
            InitializeComponent();
            lblSupplierName.Text = supplier;
            lblReportTitle.Text = string.Format("Rekapan Pembelian {0}", supplier);
            lblPeriode.Text = string.Format("Periode: {0} s/d {1}", from.ToString("dd MMMM yyyy"), to.ToString("dd MMMM yyyy"));
        }

    }
}
