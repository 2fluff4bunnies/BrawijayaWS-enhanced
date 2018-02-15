using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    public class SpecialSparepartDetailConfiguration : EntityTypeConfiguration<SpecialSparepartDetail>
    {
        public SpecialSparepartDetailConfiguration()
        {
            HasRequired(wd => wd.Sparepart).WithMany().HasForeignKey(wd => wd.SparepartId).WillCascadeOnDelete(true);
            HasRequired(wd => wd.PurchasingDetail).WithMany().HasForeignKey(wd => wd.PurchasingDetailId).WillCascadeOnDelete(true);
            HasRequired(wd => wd.SparepartManualTransaction).WithMany().HasForeignKey(wd => wd.SparepartManualTransactionId).WillCascadeOnDelete(true);
            HasRequired(wd => wd.CreateUser).WithMany().HasForeignKey(wd => wd.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(wd => wd.ModifyUser).WithMany().HasForeignKey(wd => wd.ModifyUserId).WillCascadeOnDelete(true);
        }
    }
}
