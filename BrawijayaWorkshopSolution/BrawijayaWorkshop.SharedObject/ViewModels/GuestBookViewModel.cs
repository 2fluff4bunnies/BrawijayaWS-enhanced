
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class GuestBookViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public VehicleViewModel Vehicle { get; set; }
        public string Description { get; set; }
        public string ArrivalTime { get; set; }
    }
}
