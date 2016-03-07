using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class PurchasingConfiguration : EntityTypeConfiguration<Purchasing>
    {
        public PurchasingConfiguration()
        {
            HasRequired(p => p.Supplier).WithMany().HasForeignKey(p => p.SupplierId).WillCascadeOnDelete(true);
            HasRequired(p => p.CreateUser).WithMany().HasForeignKey(p => p.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(p => p.ModifyUser).WithMany().HasForeignKey(p => p.ModifyUserId).WillCascadeOnDelete(true);
            HasRequired(p => p.PaymentMethod).WithMany().HasForeignKey(p => p.PaymentMethodId).WillCascadeOnDelete(true);
        }
    }
}
