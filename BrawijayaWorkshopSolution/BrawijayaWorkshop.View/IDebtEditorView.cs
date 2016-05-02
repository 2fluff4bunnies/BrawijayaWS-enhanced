using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IDebtEditorView : IView
    {
        TransactionViewModel SelectedDebt { get; set; }

        PurchasingViewModel SelectedPurchasing { get; set; }

        DateTime Date { get; set; }
        string SuppierName { get; set; }
        decimal TotalTransaction { get; set; }
        decimal TotalPaid { get; set; }
        decimal TotalNotPaid { get; set; }
        decimal TotalPayment { get; set; }
        int PaymentMethodId { get; set; }

        List<ReferenceViewModel> ListPaymentMethod { get; set; }

        decimal OldTotalPayment { get; set; }
        decimal OldTotalPaid { get; set; }
        decimal OldTotalNotPaid { get; set; }
        
    }
}
