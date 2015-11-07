using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class PurchasingConfiguration : EntityTypeConfiguration<Purchasing>
    {
        public PurchasingConfiguration()
        {
            HasRequired(p => p.Supplier).WithMany().HasForeignKey(p => p.SupplierId).WillCascadeOnDelete(true);
        }
    }
}
