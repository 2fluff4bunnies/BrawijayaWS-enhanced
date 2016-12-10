using System;

namespace BrawijayaWorkshop.Win32App.PrintItems
{
    public partial class SparepartStockCardPrintItem : DevExpress.XtraReports.UI.XtraReport
    {
        public SparepartStockCardPrintItem(DateTime from, DateTime to)
        {
            InitializeComponent();

            lblFrom.Text = from.ToString("dd-MM-yyyy");
            lblTo.Text = to.ToString("dd-MM-yyyy");
        }

    }
}
