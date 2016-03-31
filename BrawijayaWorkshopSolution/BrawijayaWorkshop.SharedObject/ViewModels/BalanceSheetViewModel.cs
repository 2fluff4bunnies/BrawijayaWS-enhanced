using System.Collections.Generic;

namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class BalanceSheetViewModel
    {
        public string GroupName { get; set; }
    }

    public class BalanceSheetDetailViewModel
    {
        public BalanceSheetViewModel Header { get; set; }

        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}
