
namespace BrawijayaWorkshop.Win32App.PrintItems
{
    public partial class BalanceJournalPrintItem : DevExpress.XtraReports.UI.XtraReport
    {
        public BalanceJournalPrintItem() : this(0, 0) { }

        public BalanceJournalPrintItem(int year, int month)
        {
            InitializeComponent();

            lblYearMonth.Text = month + " / " + year;
        }
    }
}
