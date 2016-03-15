using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class LastBalanceDetailConfiguration : EntityTypeConfiguration<LastBalanceDetail>
    {
        public LastBalanceDetailConfiguration()
        {
            HasRequired(lbd => lbd.Parent).WithMany().HasForeignKey(lbd => lbd.ParentId).WillCascadeOnDelete(true);
            HasRequired(lbd => lbd.Journal).WithMany().HasForeignKey(lbd => lbd.JournalId).WillCascadeOnDelete(true);
        }
    }
}
