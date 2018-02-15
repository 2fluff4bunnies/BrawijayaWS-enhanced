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

        public int? PurchasingDetailId { get; set; }
        public virtual PurchasingDetailViewModel PurchasingDetail { get; set; }

        public int? SparepartManualTransactionId { get; set; }
        public virtual SparepartManualTransactionViewModel SparepartManualTransaction { get; set; }

        public int Qty { get; set; }

        public int PurchaseReturnId { get; set; }
        public virtual PurchaseReturnViewModel PurchaseReturn { get; set; }
    }
}
