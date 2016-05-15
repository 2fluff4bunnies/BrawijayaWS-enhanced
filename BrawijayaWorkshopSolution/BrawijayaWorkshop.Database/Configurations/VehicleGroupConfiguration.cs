using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class VehicleGroupConfiguration : EntityTypeConfiguration<VehicleGroup>
    {
        public VehicleGroupConfiguration()
        {
            HasRequired(vg => vg.Customer).WithMany().HasForeignKey(vg => vg.CustomerId).WillCascadeOnDelete(true);
            HasRequired(vg => vg.CreateUser).WithMany().HasForeignKey(vg => vg.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(vg => vg.ModifyUser).WithMany().HasForeignKey(vg => vg.ModifyUserId).WillCascadeOnDelete(true);
        }
    }
}
