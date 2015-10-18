using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class UserRoleConfiguration : EntityTypeConfiguration<UserRole>
    {
        public UserRoleConfiguration()
        {
            HasRequired(ur => ur.Role).WithMany().HasForeignKey(ur => ur.RoleId).WillCascadeOnDelete(true);
            HasRequired(ur => ur.User).WithMany().HasForeignKey(ur => ur.UserId).WillCascadeOnDelete(true);
        }
    }
}
