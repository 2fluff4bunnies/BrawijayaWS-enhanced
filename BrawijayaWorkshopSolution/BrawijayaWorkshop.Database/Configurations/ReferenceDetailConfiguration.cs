using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class ReferenceDetailConfiguration : EntityTypeConfiguration<ReferenceDetail>
    {
        public ReferenceDetailConfiguration()
        {
            HasRequired(c => c.Reference).WithMany().HasForeignKey(c => c.ReferenceId).WillCascadeOnDelete(true);
        }
    }
}
