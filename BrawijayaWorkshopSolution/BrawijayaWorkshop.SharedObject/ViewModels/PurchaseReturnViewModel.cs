using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class PurchaseReturnViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }

        public int PurchasingId { get; set; }
        public PurchasingViewModel Purchasing { get; set; }

        public List<PurchaseReturnDetailViewModel> PurchasingReturnDetailList { get; set; }

        public List<ReturnViewModel> ReturnList { get; set; }
    }
}
