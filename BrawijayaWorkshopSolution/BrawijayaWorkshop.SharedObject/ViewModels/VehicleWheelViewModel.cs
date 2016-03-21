
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class VehicleWheelViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public VehicleViewModel Vehicle { get; set; }
        public int WheelDetailId { get; set; }
        public SpecialSparepartDetailViewModel WheelDetail { get; set; }
        public bool IsUsedWheelRetrieved { get; set; }
        public decimal Price { get; set; }
    }
}
