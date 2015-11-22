using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class VehicleConfiguration : EntityTypeConfiguration<Vehicle>
    {
        public VehicleConfiguration()
        {
            HasRequired(v => v.Customer).WithMany().HasForeignKey(v => v.CustomerId).WillCascadeOnDelete(true);
        }
    }
}
