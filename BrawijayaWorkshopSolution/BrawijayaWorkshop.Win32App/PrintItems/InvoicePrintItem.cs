using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

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
