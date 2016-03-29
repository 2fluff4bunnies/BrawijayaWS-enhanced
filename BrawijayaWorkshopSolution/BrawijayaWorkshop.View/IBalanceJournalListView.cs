using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IBalanceJournalListView : IBalanceBaseView
    {
        List<BalanceJournalDetailViewModel> BalanceJournalDetailList { get; set; }
    }
}
