using BrawijayaWorkshop.Database.Configurations;
using BrawijayaWorkshop.Database.Entities;
using MySql.Data.Entity;
using System.Data.Common;
using System.Data.Entity;

namespace BrawijayaWorkshop.Database
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BrawijayaWorkshopDbContext : DbContext
    {
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        public BrawijayaWorkshopDbContext()
            : base(DatabaseConfigurationHelper.DefaultConnectionString) { }

        public BrawijayaWorkshopDbContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // add entity configuration here
            modelBuilder.Configurations.Add(new UserRoleConfiguration());
        }
    }
}
