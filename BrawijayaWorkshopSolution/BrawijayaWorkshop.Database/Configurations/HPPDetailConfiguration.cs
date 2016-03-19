using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class HPPDetailConfiguration : EntityTypeConfiguration<HPPDetail>
    {
        public HPPDetailConfiguration()
        {
            HasRequired(hpp => hpp.Header).WithMany().HasForeignKey(hpp => hpp.HeaderId).WillCascadeOnDelete(true);
            HasRequired(hpp => hpp.Journal).WithMany().HasForeignKey(hpp => hpp.JournalId).WillCascadeOnDelete(true);
        }
    }
}
