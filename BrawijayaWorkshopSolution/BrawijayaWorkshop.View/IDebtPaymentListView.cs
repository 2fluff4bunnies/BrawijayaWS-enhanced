using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IDebtPaymentListView : IView
    {
        DateTime TransactionDate { get; set; }
        string SupplierName { get; set; }
        decimal TotalPrice { get; set; }
        decimal TotalHasPaid { get; set; }
        decimal TotalNotPaid { get; set; }

        PurchasingViewModel SelectedPurchasing { get; set; }
        List<TransactionViewModel> TransactionListData { get; set; }
        TransactionViewModel SelectedTransaction { get; set; }
    }
}
