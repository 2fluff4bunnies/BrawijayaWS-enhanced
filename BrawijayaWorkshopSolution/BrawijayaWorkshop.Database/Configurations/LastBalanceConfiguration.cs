using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class LastBalanceConfiguration : EntityTypeConfiguration<LastBalance>
    {
        public LastBalanceConfiguration()
        {
            HasRequired(lb => lb.CreateUser).WithMany().HasForeignKey(lb => lb.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(lb => lb.ModifyUser).WithMany().HasForeignKey(lb => lb.ModifyUserId).WillCascadeOnDelete(true);
        }
    }
}
