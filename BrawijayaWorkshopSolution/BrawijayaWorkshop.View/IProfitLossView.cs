using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IProfitLossView : IBalanceBaseView
    {
        List<BalanceSheetDetailViewModel> ProfitLossList { get; set; }
    }
}
