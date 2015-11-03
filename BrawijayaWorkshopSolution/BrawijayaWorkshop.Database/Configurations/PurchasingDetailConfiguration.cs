using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class PurchasingDetailConfiguration : EntityTypeConfiguration<PurchasingDetail>
    {
        public PurchasingDetailConfiguration()
        {
            HasRequired(c => c.Purchasing).WithMany().HasForeignKey(c => c.PurchasingId).WillCascadeOnDelete(true);
            HasRequired(c => c.Sparepart).WithMany().HasForeignKey(c => c.SparepartId).WillCascadeOnDelete(true);
        }
    }
}
