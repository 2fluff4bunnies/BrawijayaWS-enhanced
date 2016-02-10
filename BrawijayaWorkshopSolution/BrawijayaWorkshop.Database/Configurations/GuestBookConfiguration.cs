using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    public class GuestBookConfiguration : EntityTypeConfiguration<GuestBook>
    {
        public GuestBookConfiguration()
        {
            HasRequired(gb => gb.Vehicle).WithMany().HasForeignKey(gb => gb.VehicleId).WillCascadeOnDelete(true);
            HasRequired(gb => gb.CreateUser).WithMany().HasForeignKey(gb => gb.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(gb => gb.ModifyUser).WithMany().HasForeignKey(gb => gb.ModifyUserId).WillCascadeOnDelete(true);
        }
    }
}
