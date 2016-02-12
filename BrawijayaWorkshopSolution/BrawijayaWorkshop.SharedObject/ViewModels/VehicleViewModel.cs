
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class VehicleViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string ActiveLicenseNumber { get; set; }
        public int YearOfPurchase { get; set; }
        public int CustomerId { get; set; }
        public CustomerViewModel Customer { get; set; }
    }
}
