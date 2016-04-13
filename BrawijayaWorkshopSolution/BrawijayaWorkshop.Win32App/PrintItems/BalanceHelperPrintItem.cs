
namespace BrawijayaWorkshop.Win32App.PrintItems
{
    public partial class BalanceHelperPrintItem : DevExpress.XtraReports.UI.XtraReport
    {
        public BalanceHelperPrintItem() : this(0, 0, string.Empty) { }

        public BalanceHelperPrintItem(int year, int month, string bookName)
        {
            InitializeComponent();

            lblBookName.Text = "Buku Pembantu " + bookName;
            lblYearMonth.Text = month + " / " + year;
        }
    }
}
