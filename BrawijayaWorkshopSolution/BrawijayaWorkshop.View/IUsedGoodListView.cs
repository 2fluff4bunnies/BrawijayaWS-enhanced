using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IUsedGoodListView : IView
    {
        string SparepartNameFilter { get; set; }

        List<UsedGoodViewModel> UsedGoodListData { get; set; }

        UsedGoodViewModel SelectedUsedGood { get; set; }
    }
}
