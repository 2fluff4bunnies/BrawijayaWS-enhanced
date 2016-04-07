using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISalesReturnTransactionListView : IView
    {
        DateTime? DateFilterFrom { get; set; }
        DateTime? DateFilterTo { get; set; }

        InvoiceViewModel SelectedInvoice { get; set; }
        List<SalesReturnViewModel> SalesReturnListData { get; set; }

        SalesReturnViewModel SelectedSalesReturn { get; set; }
    }
}
