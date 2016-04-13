
namespace BrawijayaWorkshop.Win32App.PrintItems
{
    public partial class ProfitLossPrintItem : DevExpress.XtraReports.UI.XtraReport
    {
        public ProfitLossPrintItem() : this(0, 0) { }
        
        public ProfitLossPrintItem(int year, int month)
        {
            InitializeComponent();

            lblYearMonth.Text = month + " / " + year;
        }
    }
}
