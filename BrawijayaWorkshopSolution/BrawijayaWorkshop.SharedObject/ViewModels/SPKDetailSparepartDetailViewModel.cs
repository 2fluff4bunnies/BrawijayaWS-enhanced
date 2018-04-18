
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class SPKDetailSparepartDetailViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }

        public int? PurchasingDetailId { get; set; }
        public virtual PurchasingDetailViewModel PurchasingDetail { get; set; }

        public int? SparepartManualTransactionId { get; set; }
        public virtual SparepartManualTransactionViewModel SparepartManualTransaction { get; set; }

        public int? SpecialSparepartDetailId { get; set; }
        public virtual SpecialSparepartDetailViewModel SpecialSparepartDetail { get; set; }


        public int Qty { get; set; }

        public int SPKDetailSparepartId { get; set; }
        public SPKDetailSparepartViewModel SPKDetailSparepart { get; set; }
    }
}
