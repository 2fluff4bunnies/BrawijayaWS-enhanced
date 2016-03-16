
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class BalanceJournalDetailViewModel
    {
        public int Id { get; set; }

        public int ParentId { get; set; }
        public BalanceJournalViewModel Parent { get; set; }

        public int JournalId { get; set; }
        public JournalMasterViewModel Journal { get; set; }

        public decimal? FirstDebit { get; set; }
        public decimal? FirstCredit { get; set; }

        public decimal? MutationDebit { get; set; }
        public decimal? MutationCredit { get; set; }

        public decimal? ReconciliationDebit { get; set; }
        public decimal? ReconciliationCredit { get; set; }

        public decimal? ProfitLossDebit { get; set; }
        public decimal? ProfitLossCredit { get; set; }

        public decimal? LastDebit { get; set; }
        public decimal? LastCredit { get; set; }
    }
}
