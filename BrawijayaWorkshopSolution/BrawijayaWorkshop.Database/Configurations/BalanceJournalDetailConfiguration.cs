using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class BalanceJournalDetailConfiguration : EntityTypeConfiguration<BalanceJournalDetail>
    {
        public BalanceJournalDetailConfiguration()
        {
            HasRequired(lbd => lbd.Parent).WithMany().HasForeignKey(lbd => lbd.ParentId).WillCascadeOnDelete(true);
            HasRequired(lbd => lbd.Journal).WithMany().HasForeignKey(lbd => lbd.JournalId).WillCascadeOnDelete(true);
        }
    }
}
