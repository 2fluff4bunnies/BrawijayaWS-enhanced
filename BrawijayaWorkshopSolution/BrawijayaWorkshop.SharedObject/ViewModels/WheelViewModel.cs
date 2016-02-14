
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class WheelViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public int SparepartId { get; set; }
        public SparepartViewModel Sparepart { get; set; }
    }
}
