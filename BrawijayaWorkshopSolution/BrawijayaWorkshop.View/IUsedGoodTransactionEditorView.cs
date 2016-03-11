using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IUsedGoodTransactionEditorView : IView
    {
        UsedGoodTransactionViewModel SelectedUsedGoodTransaction { get; set; }
        bool IsManual { get; set; }
        int UsedGoodId { get; set; }
        List<UsedGoodViewModel> UsedGoodListCombo { get; set; }
        int Stock { get; set; }
        int StockUpdate { get; set; }
        string Remark { get; set; }
        int TransactionTypeId { get; set; }
        double ItemPrice { get; set; }
        List<ReferenceViewModel> ListTransactionTypeReference { get; set; }
        UsedGoodViewModel UsedGood { get; set; }
    }
}
