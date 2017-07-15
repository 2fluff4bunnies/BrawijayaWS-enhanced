using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IUsedGoodTransactionListView : IView
    {
        string SparepartNameFilter { get; set; }

        List<UsedGoodTransactionViewModel> UsedGoodTransactionListData { get; set; }

        UsedGoodTransactionViewModel SelectedUsedGoodTransaction { get; set; }

        string ExportFileName { get; }
    }
}
