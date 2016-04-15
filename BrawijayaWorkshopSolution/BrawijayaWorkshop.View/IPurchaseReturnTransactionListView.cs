using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IPurchaseReturnTransactionListView : IView
    {
        DateTime? DateFilterFrom { get; set; }
        DateTime? DateFilterTo { get; set; }

        PurchasingViewModel SelectedPurchasing { get; set; }
        List<PurchaseReturnViewModel> PurchaseReturnListData { get; set; }

        PurchaseReturnViewModel SelectedPurchaseReturn { get; set; }

        List<ReturnViewModel> ListReturnDetail { get; set; }
    }
}
