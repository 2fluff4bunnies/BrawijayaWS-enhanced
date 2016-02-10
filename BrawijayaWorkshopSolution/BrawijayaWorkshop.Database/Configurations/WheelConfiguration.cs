using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    public class WheelConfiguration : EntityTypeConfiguration<Wheel>
    {
        public WheelConfiguration()
        {
            HasRequired(wheel => wheel.Sparepart).WithMany().HasForeignKey(wheel => wheel.SparepartId).WillCascadeOnDelete(true);
            HasRequired(wheel => wheel.CreateUser).WithMany().HasForeignKey(wheel => wheel.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(wheel => wheel.ModifyUser).WithMany().HasForeignKey(wheel => wheel.ModifyUserId).WillCascadeOnDelete(true);
        }
    }
}
