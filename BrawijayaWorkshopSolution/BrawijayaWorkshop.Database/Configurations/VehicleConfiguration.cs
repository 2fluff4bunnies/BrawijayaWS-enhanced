using BrawijayaWorkshop.Database.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class VehicleConfiguration : EntityTypeConfiguration<Vehicle>
    {
        public VehicleConfiguration()
        {
            HasRequired(c => c.Customer).WithMany().HasForeignKey(c => c.CustomerId).WillCascadeOnDelete(true);
        }
    }
}
