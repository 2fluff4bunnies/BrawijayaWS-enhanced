﻿using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ICreditListView : IView
    {
        DateTime? DateFromFilter { get; set; }

        DateTime? DateToFilter { get; set; }

        List<InvoiceViewModel> InvoiceListData { get; set; }

        InvoiceViewModel SelectedInvoice { get; set; }
    }
}
