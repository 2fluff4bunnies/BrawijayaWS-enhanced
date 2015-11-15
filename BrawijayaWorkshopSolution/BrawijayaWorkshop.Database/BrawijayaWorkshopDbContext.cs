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

        public DbSet<ApplicationModul> ApplicationModuls { get; set; }
        public DbSet<RoleAccess> RoleAccesses { get; set; }

        public DbSet<City> Cities { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Purchasing> Purchasings { get; set; }
        public DbSet<PurchasingDetail> PurchasingDetails { get; set; }
        public DbSet<Reference> References { get; set; }

        public BrawijayaWorkshopDbContext()
            : base(DatabaseConfigurationHelper.DefaultConnectionString) { }

        public BrawijayaWorkshopDbContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // add entity configuration here
            modelBuilder.Configurations.Add(new UserRoleConfiguration());
            modelBuilder.Configurations.Add(new RoleAccessConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new VehicleConfiguration());
            modelBuilder.Configurations.Add(new PurchasingConfiguration());
            modelBuilder.Configurations.Add(new PurchasingDetailConfiguration());
            modelBuilder.Configurations.Add(new ReferenceConfiguration());
            modelBuilder.Configurations.Add(new SparepartConfiguration());
            modelBuilder.Configurations.Add(new SparepartDetailConfiguration());
        }
    }
}
