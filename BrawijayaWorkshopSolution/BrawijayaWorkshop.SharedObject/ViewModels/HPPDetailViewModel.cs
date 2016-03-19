
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class HPPDetailViewModel
    {
        public int Id { get; set; }

        public int HeaderId { get; set; }
        public HPPHeaderViewModel Header { get; set; }

        public int JournalId { get; set; }
        public JournalMasterViewModel Journal { get; set; }

        public decimal? BaseAmount { get; set; }
        public int? BaseAmountModifierPercentage { get; set; }
        public decimal? BaseAmountWithModifierPercentageResult { get; set; }
        public int? ServicePercentage { get; set; }
        public decimal? ServiceAmount { get; set; }
        public decimal? TotalAmount { get; set; }
    }
}
