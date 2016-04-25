
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class SpecialSparepartDetailViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public int SparepartDetailId { get; set; }
        public SparepartDetailViewModel SparepartDetail { get; set; }
        public int WheelId { get; set; }
        public SpecialSparepartViewModel SpecialSparepart { get; set; }
        public string SerialNumber { get; set; }
        public int Kilometers { get; set; }
    }
}
