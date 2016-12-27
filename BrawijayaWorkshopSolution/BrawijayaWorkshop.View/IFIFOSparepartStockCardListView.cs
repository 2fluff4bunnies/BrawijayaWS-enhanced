using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IFIFOSparepartStockCardListView : IView
    {
        DateTime DateFromFilter { get; set; }
        DateTime DateToFilter { get; set; }

        SparepartViewModel SelectedSparepart { get; set; }

        List<GroupSparepartStockCardViewModel> ListStockCard { get; set; }
    }
}
