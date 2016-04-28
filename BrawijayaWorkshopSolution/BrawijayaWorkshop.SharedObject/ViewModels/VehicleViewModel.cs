
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class VehicleViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public BrandViewModel Brand { get; set; }
        public int TypeId { get; set; }
        public TypeViewModel Type { get; set; }
        public string ActiveLicenseNumber { get; set; }
        public int YearOfPurchase { get; set; }
        public int CustomerId { get; set; }
        public CustomerViewModel Customer { get; set; }
        public int Kilometers { get; set; }
        public string Code { get; set; }
    }
}
