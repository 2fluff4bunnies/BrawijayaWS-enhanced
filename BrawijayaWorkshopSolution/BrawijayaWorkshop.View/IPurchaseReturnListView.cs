using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IPurchaseReturnListView : IView
    {
        DateTime? DateFilterFrom { get; set; }
        DateTime? DateFilterTo { get; set; }

        List<PurchasingViewModel> PurchasingListData { get; set; }

        PurchasingViewModel SelectedPurchasing { get; set; }

        PurchaseReturnViewModel SelectedPurchaseReturn { get; set; }
    }
}
