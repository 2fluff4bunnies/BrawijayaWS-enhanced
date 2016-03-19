using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISparepartManualTransactionEditorView : IView
    {
        SparepartManualTransactionViewModel SelectedSparepartManualTransaction { get; set; }

        int SparepartId { get; set; }
        string SparepartName { get; set; }
        int Stock { get; set; }
        int StockUpdate { get; set; }
        string Remark { get; set; }
        int TransactionTypeId { get; set; }

        string SerialNumber { get; set; }
        bool IsWheel { get; set; }
        decimal Price { get; set; }

        List<ReferenceViewModel> ListTransactionTypeReference { get; set; }
        SparepartViewModel Sparepart { get; set; }
    }
}
