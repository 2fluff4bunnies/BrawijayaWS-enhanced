﻿using BrawijayaWorkshop.Database.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrawijayaWorkshop.Database.Configurations
{
    internal class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            HasRequired(c => c.City).WithMany().HasForeignKey(c => c.CityId).WillCascadeOnDelete(true);
            HasRequired(c => c.CreateUser).WithMany().HasForeignKey(c => c.CreateUserId).WillCascadeOnDelete(true);
            HasRequired(c => c.ModifyUser).WithMany().HasForeignKey(c => c.ModifyUserId).WillCascadeOnDelete(true);
        }
    }
}
