
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class SPKDetailSparepartDetailViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }

        public int SparepartDetailId { get; set; }
        public SparepartDetailViewModel SparepartDetail { get; set; }

        public int SPKDetailSparepartId { get; set; }
        public SPKDetailSparepartViewModel SPKDetailSparepart { get; set; }
    }
}
