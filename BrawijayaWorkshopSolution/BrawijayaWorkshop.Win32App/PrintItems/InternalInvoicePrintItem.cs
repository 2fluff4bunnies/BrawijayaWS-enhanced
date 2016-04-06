using System;

namespace BrawijayaWorkshop.Win32App.PrintItems
{
    public partial class InternalInvoicePrintItem : DevExpress.XtraReports.UI.XtraReport
    {
        public InternalInvoicePrintItem()
        {
            InitializeComponent();

            lblDate.Text = DateTime.Today.ToString("Surabaya, dd MMMM yyyy");
        }
    }
}
