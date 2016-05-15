
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class VehicleGroupViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CustomerId { get; set; }
        public CustomerViewModel Customer { get; set; }
    }
}
