using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class ReferenceDetailConfiguration : EntityTypeConfiguration<ReferenceDetail>
    {
        public ReferenceDetailConfiguration()
        {
            HasRequired(rd => rd.Reference).WithMany().HasForeignKey(rd => rd.ReferenceId).WillCascadeOnDelete(true);
        }
    }
}
