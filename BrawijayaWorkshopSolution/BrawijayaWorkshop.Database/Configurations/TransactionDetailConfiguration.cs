using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class TransactionDetailConfiguration : EntityTypeConfiguration<TransactionDetail>
    {
        public TransactionDetailConfiguration()
        {
            HasRequired(td => td.Parent).WithMany().HasForeignKey(td => td.ParentId).WillCascadeOnDelete(true);
            HasRequired(td => td.Journal).WithMany().HasForeignKey(td => td.JournalId).WillCascadeOnDelete(true);
        }
    }
}
