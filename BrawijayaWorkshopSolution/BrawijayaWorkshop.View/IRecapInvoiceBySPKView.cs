using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IRecapInvoiceBySPKView : IView
    {
        DateTime DateFrom { get; set; }
        DateTime DateTo { get; set; }

        int SelectedCustomer { get; set; }
        List<CustomerViewModel> ListCustomer { get; set; }

        List<InvoiceViewModel> ListInvoices { get; set; }
    }
}
