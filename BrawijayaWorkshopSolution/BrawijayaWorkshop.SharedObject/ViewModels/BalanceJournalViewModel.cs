
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class BalanceJournalViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public bool IsFirst { get; set; }
    }
}
