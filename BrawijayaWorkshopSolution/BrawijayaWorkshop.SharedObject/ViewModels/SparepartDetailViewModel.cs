using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class SparepartDetailViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }

        public int SparepartId { get; set; }
        public SparepartViewModel Sparepart { get; set; }

        public int? PurchasingDetailId { get; set; }
        public PurchasingDetailViewModel PurchasingDetail { get; set; }

        public int? SparepartManualTransactionId { get; set; }
        public SparepartManualTransactionViewModel SparepartManualTransaction { get; set; }
    }
}
