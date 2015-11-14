using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class PurchasingDetailConfiguration : EntityTypeConfiguration<PurchasingDetail>
    {
        public PurchasingDetailConfiguration()
        {
            HasRequired(pd => pd.Purchasing).WithMany().HasForeignKey(pd => pd.PurchasingId).WillCascadeOnDelete(true);
            HasRequired(pd => pd.Sparepart).WithMany().HasForeignKey(pd => pd.SparepartId).WillCascadeOnDelete(true);
            HasRequired(pd => pd.CreateUser).WithMany().HasForeignKey(pd => pd.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(pd => pd.ModifyUser).WithMany().HasForeignKey(pd => pd.ModifyUserId).WillCascadeOnDelete(true);
        }
    }
}
