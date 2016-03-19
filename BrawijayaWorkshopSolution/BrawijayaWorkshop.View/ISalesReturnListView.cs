using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISalesReturnListView : IView
    {
        DateTime? DateFilterFrom { get; set; }
        DateTime? DateFilterTo { get; set; }

        List<SalesReturnViewModel> SalesReturnListData { get; set; }

        SalesReturnViewModel SelectedSalesReturn { get; set; }
    }
}
