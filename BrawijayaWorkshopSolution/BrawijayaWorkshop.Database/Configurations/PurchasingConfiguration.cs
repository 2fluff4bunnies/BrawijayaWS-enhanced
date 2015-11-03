using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class PurchasingConfiguration : EntityTypeConfiguration<Purchasing>
    {
        public PurchasingConfiguration()
        {
            HasRequired(c => c.Supplier).WithMany().HasForeignKey(c => c.SupplierId).WillCascadeOnDelete(true);
        }
    }
}
