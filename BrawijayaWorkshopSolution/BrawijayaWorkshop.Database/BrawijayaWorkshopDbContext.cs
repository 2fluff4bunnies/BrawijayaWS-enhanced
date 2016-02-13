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

        public DbSet<JournalMaster> JournalMasters { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<Mechanic> Mechanics { get; set; }
        public DbSet<Sparepart> Spareparts { get; set; }
        public DbSet<SparepartDetail> SparepartDetails { get; set; }
        public DbSet<Wheel> Wheels { get; set; }
        public DbSet<WheelDetail> WheelDetails { get; set; }
        public DbSet<Purchasing> Purchasings { get; set; }
        public DbSet<PurchasingDetail> PurchasingDetails { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleDetail> VehicleDetails { get; set; }
        public DbSet<VehicleWheel> VehicleWheels { get; set; }
        public DbSet<GuestBook> GuestBooks { get; set; }
        public DbSet<SPK> SPKs { get; set; }
        public DbSet<SPKDetailMechanic> SPKDetailMechanics { get; set; } // must be deleted
        public DbSet<SPKSchedule> SPKSchedules { get; set; }
        public DbSet<SPKDetailSparepart> SPKDetailSpareparts { get; set; }
        public DbSet<SPKDetailSparepartDetail> SPKDetailSparepartDetails { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionDetail> TransactionDetails { get; set; }
        public DbSet<UsedGood> UsedGoods { get; set; }
        public DbSet<UsedGoodTransaction> UsedGoodsTransactions { get; set; }

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
            modelBuilder.Configurations.Add(new VehicleDetailConfiguration());
            modelBuilder.Configurations.Add(new PurchasingConfiguration());
            modelBuilder.Configurations.Add(new PurchasingDetailConfiguration());
            modelBuilder.Configurations.Add(new ReferenceConfiguration());
            modelBuilder.Configurations.Add(new SparepartConfiguration());
            modelBuilder.Configurations.Add(new SparepartDetailConfiguration());
            modelBuilder.Configurations.Add(new JournalMasterConfiguration());
            modelBuilder.Configurations.Add(new SPKConfiguration());
            modelBuilder.Configurations.Add(new SPKDetailMechanicConfiguration());
            modelBuilder.Configurations.Add(new SPKDetailSparepartConfiguration());
            modelBuilder.Configurations.Add(new SPKDetailSparepartDetailConfiguration());
            modelBuilder.Configurations.Add(new TransactionConfiguration());
            modelBuilder.Configurations.Add(new TransactionDetailConfiguration());
        }
    }
}
