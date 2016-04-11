using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class PurchaseReturnViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }

        public int PurchasingId { get; set; }
        public virtual PurchasingViewModel Purchasing { get; set; }
    }
}
