using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class SparepartDetailConfiguration : EntityTypeConfiguration<SparepartDetail>
    {
        public SparepartDetailConfiguration()
        {
            HasRequired(spd => spd.Reference).WithMany().HasForeignKey(spd => spd.ReferenceId).WillCascadeOnDelete(true);
            HasRequired(spd => spd.PurchasingDetail).WithMany().HasForeignKey(spd => spd.PurchasingDetailId).WillCascadeOnDelete(true);
        }
    }
}
