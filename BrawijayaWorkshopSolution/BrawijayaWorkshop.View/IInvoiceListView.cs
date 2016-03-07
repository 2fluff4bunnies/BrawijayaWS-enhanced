using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IInvoiceListView : IView
    {
        DateTime? DateFromFilter { get; set; }

        DateTime? DateToFilter { get; set; }

        int InvoiceStatusFilter { get; set; }

        List<InvoiceViewModel> InvoiceListData { get; set; }

        InvoiceViewModel SelectedInvoice { get; set; }

        List<InvoiceStatusItem> InvoiceStatusList { get; set; }
    }

    public class InvoiceStatusItem
    {
        public int Status { get; set; }
        public string Description { get; set; }
    }
}
