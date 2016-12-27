using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IFIFOSparepartStockCardListView : IView
    {
        SparepartViewModel SelectedSparepart { get; set; }

        List<GroupSparepartStockCardViewModel> ListStockCard { get; set; }
    }
}
