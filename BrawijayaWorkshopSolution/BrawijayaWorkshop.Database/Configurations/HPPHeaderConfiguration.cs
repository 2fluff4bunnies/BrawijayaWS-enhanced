using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class HPPHeaderConfiguration : EntityTypeConfiguration<HPPHeader>
    {
        public HPPHeaderConfiguration()
        {
            HasRequired(hpp => hpp.CreateUser).WithMany().HasForeignKey(hpp => hpp.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(hpp => hpp.ModifyUser).WithMany().HasForeignKey(hpp => hpp.ModifyUserId).WillCascadeOnDelete(true);
        }
    }
}
