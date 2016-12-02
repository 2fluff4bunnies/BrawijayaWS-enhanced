using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class SparepartStockCardConfiguration : EntityTypeConfiguration<SparepartStockCard>
    {
        public SparepartStockCardConfiguration()
        {
            HasRequired(ssc => ssc.Sparepart).WithMany().HasForeignKey(ssc => ssc.SparepartId).WillCascadeOnDelete(true);
            HasRequired(ssc => ssc.CreateUser).WithMany().HasForeignKey(ssc => ssc.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(ssc => ssc.ReferenceTable).WithMany().HasForeignKey(ssc => ssc.ReferenceTableId).WillCascadeOnDelete(true);
        }
    }
}
