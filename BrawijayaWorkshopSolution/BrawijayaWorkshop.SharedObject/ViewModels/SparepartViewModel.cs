
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class SparepartViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int StockQty { get; set; }

        public int UnitReferenceId { get; set; }
        public ReferenceViewModel UnitReference { get; set; }

        public int CategoryReferenceId { get; set; }
        public ReferenceViewModel CategoryReference { get; set; }

        public bool IsSpecialSparepart { get; set; }
    }
}
