using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class BalanceJournalDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ParentId { get; set; }
        public virtual BalanceJournal Parent { get; set; }

        public int JournalId { get; set; }
        public virtual JournalMaster Journal { get; set; }

        public decimal? FirstDebit { get; set; }
        public decimal? FirstCredit { get; set; }

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
    }
}
