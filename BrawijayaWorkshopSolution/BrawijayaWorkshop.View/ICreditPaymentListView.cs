using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ICreditPaymentListView : IView
    {
        DateTime TransactionDate { get; set; }
        string CustomerName { get; set; }
        decimal TotalPrice { get; set; }
        decimal TotalHasPaid { get; set; }
        decimal TotalNotPaid { get; set; }

        InvoiceViewModel SelectedInvoice { get; set; }
        List<TransactionViewModel> TransactionListData { get; set; }
        TransactionViewModel SelectedTransaction { get; set; }
    }
}
