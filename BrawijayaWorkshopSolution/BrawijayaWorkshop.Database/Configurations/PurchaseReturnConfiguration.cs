using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class PurchaseReturnConfiguration : EntityTypeConfiguration<PurchaseReturn>
    {
        public PurchaseReturnConfiguration()
        {
            HasRequired(p => p.Purchasing).WithMany().HasForeignKey(p => p.PurchasingId).WillCascadeOnDelete(true);
            HasRequired(p => p.CreateUser).WithMany().HasForeignKey(p => p.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(p => p.ModifyUser).WithMany().HasForeignKey(p => p.ModifyUserId).WillCascadeOnDelete(true);
            HasMany(p => p.PurchasingReturnDetailList).WithRequired().HasForeignKey(p => p.PurchaseReturnId);
        }
    }
}
