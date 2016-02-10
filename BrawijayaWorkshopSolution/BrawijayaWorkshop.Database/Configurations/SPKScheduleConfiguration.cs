using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    public class SPKScheduleConfiguration : EntityTypeConfiguration<SPKSchedule>
    {
        public SPKScheduleConfiguration()
        {
            HasRequired(sched => sched.SPK).WithMany().HasForeignKey(sched => sched.SPKId).WillCascadeOnDelete(true);
            HasRequired(sched => sched.Mechanic).WithMany().HasForeignKey(sched => sched.MechanicId).WillCascadeOnDelete(true);
            HasRequired(sched => sched.CreateUser).WithMany().HasForeignKey(sched => sched.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(sched => sched.ModifyUser).WithMany().HasForeignKey(sched => sched.ModifyUserId).WillCascadeOnDelete(true);
        }
    }
}
