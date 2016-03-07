using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ICreditPaymentListView : IView
    {
        InvoiceViewModel SelectedInvoice { get; set; }
        List<TransactionViewModel> TransactionListData { get; set; }
        TransactionViewModel SelectedTransaction { get; set; }
    }
}
