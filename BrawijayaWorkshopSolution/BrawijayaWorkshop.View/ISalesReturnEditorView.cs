using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISalesReturnEditorView : IView
    {
        InvoiceViewModel SelectedInvoice { get; set; }
        SalesReturnViewModel SelectedSalesReturn { get; set; }
        DateTime Date { get; set; }
        string CustomerName { get; set; }

        List<ReturnViewModel> ListReturn { get; set; }
    }
}
