
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class SpecialSparepartViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public int SparepartId { get; set; }
        public SparepartViewModel Sparepart { get; set; }
    }
}
