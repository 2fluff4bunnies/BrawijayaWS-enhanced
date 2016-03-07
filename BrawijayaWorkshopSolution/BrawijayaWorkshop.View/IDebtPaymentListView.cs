using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IDebtPaymentListView : IView
    {
        PurchasingViewModel SelectedPurchasing { get; set; }
        List<TransactionViewModel> TransactionListData { get; set; }
        TransactionViewModel SelectedTransaction { get; set; }
    }
}
