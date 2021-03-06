﻿using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class VehicleConfiguration : EntityTypeConfiguration<Vehicle>
    {
        public VehicleConfiguration()
        {
            HasRequired(v => v.Customer).WithMany().HasForeignKey(v => v.CustomerId).WillCascadeOnDelete(true);
            HasRequired(v => v.VehicleGroup).WithMany().HasForeignKey(v => v.VehicleGroupId).WillCascadeOnDelete(true);
            HasRequired(v => v.Type).WithMany().HasForeignKey(v => v.TypeId).WillCascadeOnDelete(true);
            HasRequired(v => v.Brand).WithMany().HasForeignKey(v => v.BrandId).WillCascadeOnDelete(true);
            HasRequired(v => v.CreateUser).WithMany().HasForeignKey(v => v.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(v => v.ModifyUser).WithMany().HasForeignKey(v => v.ModifyUserId).WillCascadeOnDelete(true);
        }
    }
}
