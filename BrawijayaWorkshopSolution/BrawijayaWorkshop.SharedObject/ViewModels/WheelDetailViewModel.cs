
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class WheelDetailViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public int SparepartDetailId { get; set; }
        public SparepartDetailViewModel SparepartDetail { get; set; }
        public int WheelId { get; set; }
        public WheelViewModel Wheel { get; set; }
        public string SerialNumber { get; set; }
    }
}
