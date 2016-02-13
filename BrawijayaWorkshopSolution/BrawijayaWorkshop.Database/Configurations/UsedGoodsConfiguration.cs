using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class UsedGoodsConfiguration : EntityTypeConfiguration<UsedGood>
    {
        public UsedGoodsConfiguration()
        {
            HasRequired(p => p.Sparepart).WithMany().HasForeignKey(p => p.SparepartId).WillCascadeOnDelete(true);
        }
    }
}
