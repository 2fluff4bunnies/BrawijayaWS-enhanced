using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class VehicleDetailConfiguration : EntityTypeConfiguration<VehicleDetail>
    {
        public VehicleDetailConfiguration()
        {
            HasRequired(vd => vd.Vehicle).WithMany().HasForeignKey(vd => vd.VehicleId).WillCascadeOnDelete(true);
            HasRequired(vd => vd.CreateUser).WithMany().HasForeignKey(vd => vd.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(vd => vd.ModifyUser).WithMany().HasForeignKey(vd => vd.ModifyUserId).WillCascadeOnDelete(true);
        }
    }
}
