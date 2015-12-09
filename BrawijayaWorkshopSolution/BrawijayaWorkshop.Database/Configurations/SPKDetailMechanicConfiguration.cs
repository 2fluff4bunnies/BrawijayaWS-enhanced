using BrawijayaWorkshop.Database.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.Database.Configurations
{
    public class SPKDetailMechanicConfiguration : EntityTypeConfiguration<SPKDetailMechanic>
    {
        public SPKDetailMechanicConfiguration()
        {
            HasRequired(sp => sp.Mechanic).WithMany().HasForeignKey(sp => sp.MechanicId).WillCascadeOnDelete(true);
            HasRequired(sp => sp.SPK).WithMany().HasForeignKey(sp => sp.SPKId).WillCascadeOnDelete(true);
            HasRequired(sp => sp.CreateUser).WithMany().HasForeignKey(sp => sp.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(sp => sp.ModifyUser).WithMany().HasForeignKey(sp => sp.ModifyUserId).WillCascadeOnDelete(true);
        }
    }
}
