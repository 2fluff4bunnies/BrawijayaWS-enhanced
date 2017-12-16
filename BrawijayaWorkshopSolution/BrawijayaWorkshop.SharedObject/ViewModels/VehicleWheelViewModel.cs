
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class VehicleWheelViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public string Notes { get; set; }
        public int VehicleId { get; set; }
        public VehicleViewModel Vehicle { get; set; }
        public int WheelDetailId { get; set; }
        public SpecialSparepartDetailViewModel WheelDetail { get; set; }
        public int SparepartId { get; set; }
        public bool IsUsedWheelRetrieved { get; set; }
        public decimal Price { get; set; }
        public int ReplaceWithWheelDetailId { get; set; }
        public string ReplaceWithWheelDetailName { get; set; }
        public string ReplaceWithWheelDetailSerialNumber { get; set; }
        public string DisplayName { get; set; }
    }
}
