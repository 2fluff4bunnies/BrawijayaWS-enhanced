using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IManualTransactionEditorView : IView
    {
        TransactionViewModel SelectedTransaction { get; set; }
        TransactionDetailViewModel SelectedTransactionDetail { get; set; }
        List<TransactionDetailViewModel> TransactionDetailList { get; set; }

        List<TransactionDetailViewModel> DeletedDetailList { get; set; }

        List<JournalMasterViewModel> JournalList { get; set; }

        DateTime TransactionDate { get; set; }
        string TransactionDescription { get; set; }

        double TotalTransaction { get; set; }
    }
}
