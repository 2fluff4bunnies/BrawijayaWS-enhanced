
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class SupplierViewModel : BaseStatusEntityViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int CityId { get; set; }
        public virtual CityViewModel City { get; set; }
    }
}
