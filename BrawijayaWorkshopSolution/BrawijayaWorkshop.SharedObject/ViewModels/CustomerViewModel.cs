
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class CustomerViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string CompanyName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string ContactPerson { get; set; }

        public int CityId { get; set; }
        public CityViewModel City { get; set; }
    }
}
