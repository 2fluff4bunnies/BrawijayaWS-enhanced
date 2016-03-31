
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class PurchasingDetailViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public bool IsSpecialSparepart { get; set; }
        public string SerialNumber { get; set; }

        public int PurchasingId { get; set; }
        public PurchasingViewModel Purchasing { get; set; }

        public int SparepartId { get; set; }
        public SparepartViewModel Sparepart { get; set; }
    }
}
