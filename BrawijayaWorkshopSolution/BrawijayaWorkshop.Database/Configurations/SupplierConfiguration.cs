using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    class SupplierConfiguration: EntityTypeConfiguration<Supplier>
    {
        public SupplierConfiguration()
        {
            HasRequired(c => c.City).WithMany().HasForeignKey(c => c.CityId).WillCascadeOnDelete(true);
        }
    }
}
