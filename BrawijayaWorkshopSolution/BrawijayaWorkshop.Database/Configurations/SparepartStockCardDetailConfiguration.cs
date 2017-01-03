using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class SparepartStockCardDetailConfiguration : EntityTypeConfiguration<SparepartStockCardDetail>
    {
        public SparepartStockCardDetailConfiguration()
        {
            HasRequired(ssc => ssc.ParentStockCard).WithMany().HasForeignKey(ssc => ssc.ParentStockCardId).WillCascadeOnDelete(true);
        }
    }
}
