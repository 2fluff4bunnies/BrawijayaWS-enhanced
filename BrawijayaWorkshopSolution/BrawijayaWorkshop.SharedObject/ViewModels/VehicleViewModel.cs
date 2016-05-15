
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class VehicleViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public virtual TypeViewModel Type { get; set; }
        public int BrandId { get; set; }
        public virtual BrandViewModel Brand { get; set; }
        public string ActiveLicenseNumber { get; set; }
        public int YearOfPurchase { get; set; }
        public int CustomerId { get; set; }
        public CustomerViewModel Customer { get; set; }
        public int VehicleGroupId { get; set; }
        public VehicleGroupViewModel VehicleGroup { get; set; }
        public int Kilometers { get; set; }
        public string Code { get; set; }
    }
}
