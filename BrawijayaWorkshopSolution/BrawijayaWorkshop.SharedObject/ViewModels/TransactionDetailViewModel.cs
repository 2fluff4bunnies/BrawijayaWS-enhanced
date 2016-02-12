
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class TransactionDetailViewModel
    {
        public int Id { get; set; }

        public int ParentId { get; set; }
        public TransactionViewModel Parent { get; set; }

        public int JournalId { get; set; }
        public JournalMasterViewModel Journal { get; set; }

        public decimal? Debit { get; set; }

        public decimal? Credit { get; set; }
    }
}
