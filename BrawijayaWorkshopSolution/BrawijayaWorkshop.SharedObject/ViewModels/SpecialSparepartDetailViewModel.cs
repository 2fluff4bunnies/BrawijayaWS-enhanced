
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class SpecialSparepartDetailViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public int WheelId { get; set; }
        public int SparepartId { get; set; }
        public SparepartViewModel Sparepart { get; set; }

        public int? PurchasingDetailId { get; set; }
        public virtual PurchasingDetailViewModel PurchasingDetail { get; set; }

        public int? SparepartManualTransactionId { get; set; }
        public virtual SparepartManualTransactionViewModel SparepartManualTransaction { get; set; }
        public string SerialNumber { get; set; }
        public int Kilometers { get; set; }
    }
}
