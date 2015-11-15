using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class ReferenceConfiguration : EntityTypeConfiguration<Reference>
    {
        public ReferenceConfiguration()
        {
            HasRequired(r => r.Parent).WithMany().HasForeignKey(r => r.ParentId).WillCascadeOnDelete(true);
        }
    }
}
