using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IDebtListView : IView
    {
        DateTime? DateFromFilter { get; set; }

        DateTime? DateToFilter { get; set; }

        List<PurchasingViewModel> PurchasingListData { get; set; }

        PurchasingViewModel SelectedPurchasing { get; set; }

        string DebtStatusPayment { get; }

        string ExportFileName { get; }
    }
}
