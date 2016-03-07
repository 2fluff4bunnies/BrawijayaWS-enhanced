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

        List<ReferenceViewModel> ListTransactionTypeReference { get; set; }

        SparepartViewModel Sparepart { get; set; }
    }
}
