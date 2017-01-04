using System;

namespace BrawijayaWorkshop.Win32App.PrintItems
{
    public partial class FIFOSparepartStockCardPrintItem : DevExpress.XtraReports.UI.XtraReport
    {
        public FIFOSparepartStockCardPrintItem(DateTime from, DateTime to, string sparepartName)
        {
            InitializeComponent();
            lblFrom.Text = from.ToString("dd-MM-yyyy");
            lblTo.Text = to.ToString("dd-MM-yyyy");
            lblSparepartName.Text = sparepartName;
        }

    }
}
