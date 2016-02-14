
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class UsedGoodViewModel : BaseStatusEntityViewModel
    {
        public int Id { get; set; }
        public int Stock { get; set; }

        public int SparepartId { get; set; }
        public SparepartViewModel Sparepart { get; set; }
    }
}
