using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    public class WheelExchangeHistoryConfiguration : EntityTypeConfiguration<WheelExchangeHistory>
    {
        public WheelExchangeHistoryConfiguration()
        {
            HasRequired(vwheelh => vwheelh.SPK).WithMany().HasForeignKey(vwheel => vwheel.SPKId).WillCascadeOnDelete(true);
            HasRequired(vwheelh => vwheelh.OrignialWheel).WithMany().HasForeignKey(vwheel => vwheel.OriginalWheelId).WillCascadeOnDelete(true);
            HasRequired(vwheelh => vwheelh.ReplaceWheel).WithMany().HasForeignKey(vwheel => vwheel.ReplaceWheelId).WillCascadeOnDelete(true);
            HasRequired(vwheelh => vwheelh.CreateUser).WithMany().HasForeignKey(vwheel => vwheel.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(vwheelh => vwheelh.ModifyUser).WithMany().HasForeignKey(vwheel => vwheel.ModifyUserId).WillCascadeOnDelete(true);
        }
    }
}
