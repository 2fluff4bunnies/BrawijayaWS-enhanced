using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISparepartStockCardListView : IView
    {
        DateTime DateFromFilter { get; set; }
        DateTime DateToFilter { get; set; }

        List<SparepartViewModel> ListSparepart { get; set; }
        int SelectedSparepartId { get; set; }

        List<GroupSparepartStockCardViewModel> ListStockCard { get; set; }
    }
}
