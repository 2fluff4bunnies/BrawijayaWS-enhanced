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
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<Mechanic> Mechanics { get; set; }
        public DbSet<Sparepart> Spareparts { get; set; }
        public DbSet<SparepartStockCard> SparepartStockCards { get; set; }
        public DbSet<SparepartStockCardDetail> SparepartStockCardDetails { get; set; }
        public DbSet<SparepartManualTransaction> SparepartManualTransactions { get; set; }
        public DbSet<Sparepart> Wheels { get; set; }
        public DbSet<SpecialSparepartDetail> WheelDetails { get; set; }
        public DbSet<Purchasing> Purchasings { get; set; }
        public DbSet<PurchasingDetail> PurchasingDetails { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleDetail> VehicleDetails { get; set; }
        public DbSet<VehicleWheel> VehicleWheels { get; set; }
        public DbSet<GuestBook> GuestBooks { get; set; }
        public DbSet<SPK> SPKs { get; set; }
        public DbSet<SPKSchedule> SPKSchedules { get; set; }
        public DbSet<SPKDetailSparepart> SPKDetailSpareparts { get; set; }
        public DbSet<SPKDetailSparepartDetail> SPKDetailSparepartDetails { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionDetail> TransactionDetails { get; set; }
        public DbSet<BalanceJournal> BalanceJournals { get; set; }
        public DbSet<BalanceJournalDetail> BalanceJournalDetails { get; set; }
        public DbSet<UsedGood> UsedGoods { get; set; }
        public DbSet<UsedGoodTransaction> UsedGoodsTransactions { get; set; }
        public DbSet<PurchaseReturn> PurchaseReturns { get; set; }
        public DbSet<PurchaseReturnDetail> PurchaseReturnDetails { get; set; }
        public DbSet<SalesReturn> SalesReturns { get; set; }
        public DbSet<SalesReturnDetail> SalesReturnDetails { get; set; }
        public DbSet<WheelExchangeHistory> WheelExchangeHistories { get; set; }
        public DbSet<VehicleGroup> VehicleGroups { get; set; }
        
        public BrawijayaWorkshopDbContext()
            : base(DatabaseConfigurationHelper.DefaultConnectionString)
        {
            //System.Data.Entity.Database.SetInitializer<BrawijayaWorkshopDbContext>(null);
        }

        public BrawijayaWorkshopDbContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
            //System.Data.Entity.Database.SetInitializer<BrawijayaWorkshopDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // add entity configuration here
            modelBuilder.Configurations.Add(new UserRoleConfiguration());
            modelBuilder.Configurations.Add(new RoleAccessConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new SupplierConfiguration());
            modelBuilder.Configurations.Add(new GuestBookConfiguration());
            modelBuilder.Configurations.Add(new VehicleConfiguration());
            modelBuilder.Configurations.Add(new VehicleDetailConfiguration());
            modelBuilder.Configurations.Add(new SpecialSparepartDetailConfiguration());
            modelBuilder.Configurations.Add(new PurchasingConfiguration());
            modelBuilder.Configurations.Add(new PurchasingDetailConfiguration());
            modelBuilder.Configurations.Add(new ReferenceConfiguration());
            modelBuilder.Configurations.Add(new SparepartConfiguration());
            modelBuilder.Configurations.Add(new SparepartStockCardConfiguration());
            modelBuilder.Configurations.Add(new SparepartStockCardDetailConfiguration());
            modelBuilder.Configurations.Add(new SparepartManualTransactionConfiguration());
            modelBuilder.Configurations.Add(new JournalMasterConfiguration());
            modelBuilder.Configurations.Add(new SPKConfiguration());
            modelBuilder.Configurations.Add(new SPKDetailSparepartConfiguration());
            modelBuilder.Configurations.Add(new SPKDetailSparepartDetailConfiguration());
            modelBuilder.Configurations.Add(new SPKScheduleConfiguration());
            modelBuilder.Configurations.Add(new InvoiceConfiguration());
            modelBuilder.Configurations.Add(new InvoiceDetailConfiguration());
            modelBuilder.Configurations.Add(new TransactionConfiguration());
            modelBuilder.Configurations.Add(new TransactionDetailConfiguration());
            modelBuilder.Configurations.Add(new BalanceJournalConfiguration());
            modelBuilder.Configurations.Add(new BalanceJournalDetailConfiguration());
            modelBuilder.Configurations.Add(new UsedGoodsConfiguration());
            modelBuilder.Configurations.Add(new UsedGoodsTransactionConfiguration());
            modelBuilder.Configurations.Add(new PurchaseReturnConfiguration());
            modelBuilder.Configurations.Add(new PurchaseReturnDetailConfiguration());
            modelBuilder.Configurations.Add(new SalesReturnConfiguration());
            modelBuilder.Configurations.Add(new SalesReturnDetailConfiguration());
            modelBuilder.Configurations.Add(new VehicleWheelConfiguration());
            modelBuilder.Configurations.Add(new WheelExchangeHistoryConfiguration());
        }
    }
}
