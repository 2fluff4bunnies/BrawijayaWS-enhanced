using System;

namespace BrawijayaWorkshop.Win32App.PrintItems
{
    public partial class InvoicePrintItem : DevExpress.XtraReports.UI.XtraReport
    {
        public InvoicePrintItem()
        {
            InitializeComponent();

            lblInvoiceDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }
    }
}
