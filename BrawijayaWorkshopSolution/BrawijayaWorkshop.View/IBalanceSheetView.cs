using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IBalanceSheetView : IBalanceBaseView
    {
        List<BalanceSheetDetailViewModel> ActivaList { get; set; }
        List<BalanceSheetDetailViewModel> PassivaList { get; set; }
    }
}
