using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class RoleAccessConfiguration : EntityTypeConfiguration<RoleAccess>
    {
        public RoleAccessConfiguration()
        {
            HasRequired(ra => ra.ApplicationModul).WithMany().HasForeignKey(ra => ra.ApplicationModulId).WillCascadeOnDelete(true);
            HasRequired(ra => ra.Role).WithMany().HasForeignKey(ra => ra.RoleId).WillCascadeOnDelete(true);
        }
    }
}
