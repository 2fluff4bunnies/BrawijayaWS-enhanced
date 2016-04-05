using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class PurchaseReturnDetailConfiguration : EntityTypeConfiguration<PurchaseReturnDetail>
    {
        public PurchaseReturnDetailConfiguration()
        {
            HasRequired(p => p.PurchaseReturn).WithMany().HasForeignKey(p => p.PurchaseReturnId).WillCascadeOnDelete(true);
            HasRequired(p => p.PurchasingDetail).WithMany().HasForeignKey(p => p.PurchasingDetailId).WillCascadeOnDelete(true);
            HasRequired(p => p.SparepartDetail).WithMany().HasForeignKey(p => p.SparepartDetailId).WillCascadeOnDelete(true);
            HasRequired(p => p.CreateUser).WithMany().HasForeignKey(p => p.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(p => p.ModifyUser).WithMany().HasForeignKey(p => p.ModifyUserId).WillCascadeOnDelete(true);
        }
    }
}
