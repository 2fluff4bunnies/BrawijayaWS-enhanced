using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.Database
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BrawijayaWorkshopDbContext : DbContext
    {
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Role> Roles { get; set; }

        public BrawijayaWorkshopDbContext()
            : base(DatabaseConfigurationHelper.DefaultConnectionString) { }

        public BrawijayaWorkshopDbContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // add entity configuration here
        }
    }
}
