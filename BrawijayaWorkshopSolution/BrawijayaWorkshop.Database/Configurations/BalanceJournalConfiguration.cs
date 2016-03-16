using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class BalanceJournalConfiguration : EntityTypeConfiguration<BalanceJournal>
    {
        public BalanceJournalConfiguration()
        {
            HasRequired(lb => lb.CreateUser).WithMany().HasForeignKey(lb => lb.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(lb => lb.ModifyUser).WithMany().HasForeignKey(lb => lb.ModifyUserId).WillCascadeOnDelete(true);
        }
    }
}
