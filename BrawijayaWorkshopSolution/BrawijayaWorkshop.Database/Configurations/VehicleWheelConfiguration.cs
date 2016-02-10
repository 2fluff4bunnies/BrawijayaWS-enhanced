using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    public class VehicleWheelConfiguration : EntityTypeConfiguration<VehicleWheel>
    {
        public VehicleWheelConfiguration()
        {
            HasRequired(vwheel => vwheel.Vehicle).WithMany().HasForeignKey(vwheel => vwheel.VehicleId).WillCascadeOnDelete(true);
            HasRequired(vwheel => vwheel.WheelDetail).WithMany().HasForeignKey(vwheel => vwheel.WheelDetailId).WillCascadeOnDelete(true);
            HasRequired(vwheel => vwheel.CreateUser).WithMany().HasForeignKey(vwheel => vwheel.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(vwheel => vwheel.ModifyUser).WithMany().HasForeignKey(vwheel => vwheel.ModifyUserId).WillCascadeOnDelete(true);
        }
    }
}
