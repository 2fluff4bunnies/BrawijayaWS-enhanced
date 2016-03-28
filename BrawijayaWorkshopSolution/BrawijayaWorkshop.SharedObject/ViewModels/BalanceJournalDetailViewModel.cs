
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

        public decimal FirstBalance
        {
            get
            {
                return (FirstDebit ?? 0) - (FirstCredit ?? 0);
            }
        }

        public decimal? MutationDebit { get; set; }
        public decimal? MutationCredit { get; set; }

        public decimal? BalanceAfterMutationDebit { get; set; }
        public decimal? BalanceAfterMutationCredit { get; set; }

        public decimal? ReconciliationDebit { get; set; }
        public decimal? ReconciliationCredit { get; set; }

        public decimal? BalanceAfterReconciliationDebit { get; set; }
        public decimal? BalanceAfterReconciliationCredit { get; set; }

        public decimal? ProfitLossDebit { get; set; }
        public decimal? ProfitLossCredit { get; set; }

        public decimal? LastDebit { get; set; }
        public decimal? LastCredit { get; set; }

        public decimal LastBalance
        {
            get
            {
                return (LastDebit ?? 0) - (LastCredit ?? 0);
            }
        }

        public bool IsChecked { get; set; }
    }
}
