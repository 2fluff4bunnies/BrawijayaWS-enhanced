using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISPKSaleListView : IView
    {
        DateTime? DateFilterFrom { get; set; }
        DateTime? DateFilterTo { get; set; }

        List<SPKViewModel> SPKListData { get; set; }

        SPKViewModel SelectedSPK { get; set; }

        InvoiceViewModel SelectedInvoice { get; set; }

        string ExportFileName { get; }
    }
}
