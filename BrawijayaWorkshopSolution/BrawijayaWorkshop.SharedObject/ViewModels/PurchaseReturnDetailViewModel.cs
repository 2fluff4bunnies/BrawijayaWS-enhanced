using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class PurchaseReturnDetailViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public int SparepartDetailId { get; set; }
        public virtual SparepartDetailViewModel SparepartDetaill { get; set; }

        public int PurchasingDetailId { get; set; }
        public virtual PurchasingDetailViewModel PurchasingDetail { get; set; }

        public int PurchaseReturnId { get; set; }
        public virtual PurchaseReturnViewModel PurchaseReturn { get; set; }
    }
}
