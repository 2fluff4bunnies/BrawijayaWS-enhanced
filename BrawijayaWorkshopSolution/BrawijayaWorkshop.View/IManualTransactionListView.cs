using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IManualTransactionListView : IView
    {
        DateTime From { get; set; }
        DateTime To { get; set; }
        List<TransactionViewModel> TransactionListData { get; set; }
        TransactionViewModel SelectedTransaction { get; set; }

        string ExportFileName { get; }
    }
}
