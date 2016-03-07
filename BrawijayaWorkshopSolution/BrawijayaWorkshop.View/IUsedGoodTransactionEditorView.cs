using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IUsedGoodTransactionEditorView : IView
    {
        UsedGoodTransactionViewModel SelectedUsedGoodTransaction { get; set; }

        int UsedGoodId { get; set; }

        bool IsManual { get; set; }

        List<ReferenceViewModel> ListTransactionTypeReference { get; set; }

        UsedGoodViewModel UsedGood { get; set; }
    }
}
