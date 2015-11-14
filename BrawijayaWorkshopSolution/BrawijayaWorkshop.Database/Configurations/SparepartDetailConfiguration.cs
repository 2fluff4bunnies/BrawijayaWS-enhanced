using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class SparepartDetailConfiguration : EntityTypeConfiguration<SparepartDetail>
    {
        public SparepartDetailConfiguration()
        {
            HasRequired(spd => spd.Sparepart).WithMany().HasForeignKey(spd => spd.SparepartId).WillCascadeOnDelete(true);
            HasRequired(spd => spd.PurchasingDetail).WithMany().HasForeignKey(spd => spd.PurchasingDetailId).WillCascadeOnDelete(true);
            HasRequired(spd => spd.CreateUser).WithMany().HasForeignKey(spd => spd.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(spd => spd.ModifyUser).WithMany().HasForeignKey(spd => spd.ModifyUserId).WillCascadeOnDelete(true);
        }
    }
}
