
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class MechanicViewModel : BaseStatusEntityViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BaseFee { get; set; }
    }
}
