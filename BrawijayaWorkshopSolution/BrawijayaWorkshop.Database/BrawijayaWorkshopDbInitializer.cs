using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MySqlEntityFramework;
using BrawijayaWorkshop.Utils;

namespace BrawijayaWorkshop.Database
{
    public class BrawijayaWorkshopDbInitializer : CreateMySqlDatabaseIfNotExists<BrawijayaWorkshopDbContext>
    {
        protected override void Seed(BrawijayaWorkshopDbContext context)
        {
            Role superAdminRole = context.Roles.Add(new Role
            {
                Name = DbConstant.ROLE_SUPERADMIN
            });
            Role adminRole = context.Roles.Add(new Role
            {
                Name = DbConstant.ROLE_ADMIN
            });
            Role managerRole = context.Roles.Add(new Role
            {
                Name = DbConstant.ROLE_MANAGER
            });
            Role financeRole = context.Roles.Add(new Role
            {
                Name = DbConstant.ROLE_FINANCE
            });

            User superAdminUser = context.Users.Add(new User
            {
                FirstName = "Super",
                LastName = "Admin",
                IsActive = true,
                UserName = "superadmin",
                Password = "!0sp123".Encrypt()
            });

            User adminUser = context.Users.Add(new User
            {
                FirstName = "Admin",
                LastName = "-",
                IsActive = true,
                UserName = "admin",
                Password = "!0ad123".Encrypt()
            });

            User managerUser = context.Users.Add(new User
            {
                FirstName = "Manager",
                LastName = "-",
                IsActive = true,
                UserName = "manager",
                Password = "!0mg123".Encrypt()
            });

            User financeUser = context.Users.Add(new User
            {
                FirstName = "Finance",
                LastName = "-",
                IsActive = true,
                UserName = "finance",
                Password = "!0fn123".Encrypt()
            });
            context.SaveChanges();

            context.UserRoles.Add(new UserRole
            {
                RoleId = superAdminRole.Id,
                UserId = superAdminUser.Id
            });

            context.UserRoles.Add(new UserRole
            {
                RoleId = adminRole.Id,
                UserId = adminUser.Id
            });

            context.UserRoles.Add(new UserRole
            {
                RoleId = managerRole.Id,
                UserId = managerUser.Id
            });

            context.UserRoles.Add(new UserRole
            {
                RoleId = financeRole.Id,
                UserId = financeUser.Id
            });
            context.SaveChanges();

            ApplicationModul accMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_ACCESSIBILITY,
                ModulDescription = "Accessibility Modul"
            });
            ApplicationModul userControlMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_USERCONTROL,
                ModulDescription = "User Control Modul"
            });
            ApplicationModul dbConfigMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_DBCONFIG,
                ModulDescription = "Db Config Modul"
            });

            ApplicationModul customerMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_CUSTOMER,
                ModulDescription = "Customer Modul"
            });
            ApplicationModul journalMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_JOURNAL,
                ModulDescription = "Journal Modul"
            });
            ApplicationModul vehicleMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_VEHICLE,
                ModulDescription = "Vehicle Modul"
            });
            ApplicationModul vehicleDetailMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_VEHICLE_DETAIL,
                ModulDescription = "Vehicle Detail Modul"
            });
            ApplicationModul sparepartMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_SPAREPART,
                ModulDescription = "Sparepart Modul"
            });
            ApplicationModul sparepartDetailMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_SPAREPART_DETAIL,
                ModulDescription = "Sparepart Detail Modul"
            });
            ApplicationModul supplierMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_SUPPLIER,
                ModulDescription = "Supplier Modul"
            });
            ApplicationModul mechanicMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_MECHANIC,
                ModulDescription = "Mechanic Modul"
            });
            ApplicationModul brandMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_BRAND,
                ModulDescription = "Brand Modul"
            });
            ApplicationModul typeMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_TYPE,
                ModulDescription = "Type Modul"
            });
            ApplicationModul purchasingMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_PURCHASING,
                ModulDescription = "Purchasing Modul"
            });
            ApplicationModul serviceMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_SERVICE,
                ModulDescription = "Service Modul"
            });
            ApplicationModul approvalMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_APPROVAL,
                ModulDescription = "Approval Modul"
            });
            ApplicationModul spkMod = context.ApplicationModuls.Add(new ApplicationModul { 
                ModulName = DbConstant.MODUL_SPK,
                ModulDescription = "SPK Modul"
            });
            ApplicationModul spkSchedule = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_SPK_SCHEDULE,
                ModulDescription = "SPK Schedule Modul"
            });
            ApplicationModul spkSales = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_SPK_SALES,
                ModulDescription = "SPK Sales Modul"
            });
            ApplicationModul guestBook = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_GUESTBOOK,
                ModulDescription = "Guestbook Modul"
            });
            ApplicationModul manageAppUserMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_MANAGE_APP_USER,
                ModulDescription = "Manage Application User"
            });
            ApplicationModul accountingMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_ACCOUNTING,
                ModulDescription = "Manual Accounting"
            });
            ApplicationModul usedGoodMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_USEDGOOD,
                ModulDescription = "Modul Barang Bekas"
            });
            ApplicationModul usedGoodTransMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_USEDGOOD_TRANSACTION,
                ModulDescription = "Modul Transaksi Barang Bekas"
            });
            ApplicationModul creditMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_CREDIT,
                ModulDescription = "Modul Transaksi Pembayaran Piutang"
            });
            ApplicationModul debtMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_DEBT,
                ModulDescription = "Modul Transaksi Pembayaran Piutang"
            });
            ApplicationModul invoiceMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_INVOICE,
                ModulDescription = "Modul Invoice"
            });
            ApplicationModul purchaseReturnMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_PURCHASE_RETURN,
                ModulDescription = "Modul Transaksi Retur Pembelian"
            });
            ApplicationModul salesReturnMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_SALES_RETURN,
                ModulDescription = "Modul Transaksi Retur Penjualan"
            });
            ApplicationModul vehicleGroupMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_VEHICLEGROUP,
                ModulDescription = "Modul Vehicle Group"
            });
            ApplicationModul recapInvoiceMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_RECAP_INVOICE,
                ModulDescription = "Rekap Tagihan"
            });
            ApplicationModul historySparepartMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_HISTORY_SPAREPART,
                ModulDescription = "History Sparepart"
            });
            context.SaveChanges();

            // superadmin
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = recapInvoiceMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = accMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = vehicleGroupMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = userControlMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = dbConfigMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = customerMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = journalMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = supplierMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = mechanicMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = vehicleMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = vehicleDetailMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = sparepartMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = sparepartDetailMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = serviceMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = approvalMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = purchasingMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess { 
                ApplicationModulId = spkMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = spkSchedule.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = spkSales.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = guestBook.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = manageAppUserMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = accountingMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = usedGoodMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = usedGoodTransMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = debtMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = creditMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = invoiceMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = purchaseReturnMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = salesReturnMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = brandMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = typeMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = historySparepartMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });

            // admin
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = recapInvoiceMod.Id,
                RoleId = adminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = vehicleGroupMod.Id,
                RoleId = adminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = customerMod.Id,
                RoleId = adminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = supplierMod.Id,
                RoleId = adminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = mechanicMod.Id,
                RoleId = adminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = vehicleMod.Id,
                RoleId = adminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = vehicleDetailMod.Id,
                RoleId = adminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = sparepartMod.Id,
                RoleId = adminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = sparepartDetailMod.Id,
                RoleId = adminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = serviceMod.Id,
                RoleId = adminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = purchasingMod.Id,
                RoleId = adminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = spkMod.Id,
                RoleId = adminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = spkSchedule.Id,
                RoleId = adminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = spkSales.Id,
                RoleId = adminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = guestBook.Id,
                RoleId = adminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = usedGoodMod.Id,
                RoleId = adminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = usedGoodTransMod.Id,
                RoleId = adminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = purchaseReturnMod.Id,
                RoleId = adminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = salesReturnMod.Id,
                RoleId = adminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = brandMod.Id,
                RoleId = adminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = typeMod.Id,
                RoleId = adminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = historySparepartMod.Id,
                RoleId = adminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = invoiceMod.Id,
                RoleId = adminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });

            // manager
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = recapInvoiceMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = accMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = vehicleGroupMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = userControlMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = dbConfigMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = customerMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = journalMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = supplierMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = mechanicMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = vehicleMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = vehicleDetailMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = sparepartMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = sparepartDetailMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = serviceMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = approvalMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = purchasingMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = spkMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = spkSchedule.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = spkSales.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = guestBook.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = manageAppUserMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = accountingMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = usedGoodMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = usedGoodTransMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = debtMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = creditMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = invoiceMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = purchaseReturnMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = salesReturnMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = brandMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = typeMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = historySparepartMod.Id,
                RoleId = managerRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });

            // finance
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = recapInvoiceMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = vehicleGroupMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = customerMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = journalMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = supplierMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = mechanicMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = vehicleMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = vehicleDetailMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = sparepartMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = sparepartDetailMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = serviceMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = approvalMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = purchasingMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = spkMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = spkSchedule.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = spkSales.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = guestBook.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = accountingMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = usedGoodMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = usedGoodTransMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = debtMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = creditMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = invoiceMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = purchaseReturnMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = salesReturnMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = brandMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = typeMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = historySparepartMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.SaveChanges();

            // references
            // Journal Category
            Reference refCatJournal = context.References.Add(new Reference
            {
                Code = "REF_CAT_JOURNAL",
                Name = "Journal Category",
                Description = "Kategori akun jurnal",
                Value = "REF_CAT_JOURNAL"
            });
            context.SaveChanges();

            // children journal category
            // neraca saldo
            context.References.Add(new Reference
            {
                ParentId = refCatJournal.Id,
                Code = "REF_CAT_JOURNAL_BALANCESHEET",
                Name = "Balance Sheet Journal Category",
                Description = "Kategori akun jurnal Neraca Saldo",
                Value = "REF_CAT_JOURNAL_BALANCESHEET"
            });

            // neraca
            context.References.Add(new Reference
            {
                ParentId = refCatJournal.Id,
                Code = "REF_CAT_JOURNAL_CURRENTASSET",
                Name = "Current Asset Journal Category",
                Description = "Kategori akun jurnal Aktiva Lancar",
                Value = "REF_CAT_JOURNAL_CURRENTASSET"
            });
            context.References.Add(new Reference
            {
                ParentId = refCatJournal.Id,
                Code = "REF_CAT_JOURNAL_FIXEDASSET",
                Name = "Fixed Asset Journal Category",
                Description = "Kategori akun jurnal Aktiva Tetap",
                Value = "REF_CAT_JOURNAL_FIXEDASSET"
            });
            context.References.Add(new Reference
            {
                ParentId = refCatJournal.Id,
                Code = "REF_CAT_JOURNAL_OBLIGATION",
                Name = "Obligation Journal Category",
                Description = "Kategori akun jurnal Kewajiban",
                Value = "REF_CAT_JOURNAL_OBLIGATION"
            });
            context.References.Add(new Reference
            {
                ParentId = refCatJournal.Id,
                Code = "REF_CAT_JOURNAL_FUND",
                Name = "Fund Journal Category",
                Description = "Kategori akun jurnal Modal",
                Value = "REF_CAT_JOURNAL_FUND"
            });

            // rugi laba
            context.References.Add(new Reference
            {
                ParentId = refCatJournal.Id,
                Code = "REF_CAT_JOURNAL_SERVICE",
                Name = "Service Journal Category",
                Description = "Kategori akun jurnal Jasa",
                Value = "REF_CAT_JOURNAL_SERVICE"
            });
            context.References.Add(new Reference
            {
                ParentId = refCatJournal.Id,
                Code = "REF_CAT_JOURNAL_COST",
                Name = "Cost Journal Category",
                Description = "Kategori akun jurnal Biaya",
                Value = "REF_CAT_JOURNAL_COST"
            });
            context.References.Add(new Reference
            {
                ParentId = refCatJournal.Id,
                Code = "REF_CAT_JOURNAL_INCOME",
                Name = "Income Journal Category",
                Description = "Kategori akun jurnal Pendapatan",
                Value = "REF_CAT_JOURNAL_INCOME"
            });
            context.SaveChanges();

            // -- Sparepart Category
            Reference refSparepartCategory = context.References.Add(new Reference
            {
                Code = "REF_SPAREPARTCATEGORY",
                Name = "Category",
                Description = "Sparepart Category",
                Value = "REF_SPAREPARTCATEGORY"
            });

            // -- Sparepart Unit
            Reference refSparepartUnit = context.References.Add(new Reference
            {
                Code = "REF_SPAREPARTUNIT",
                Name = "Unit",
                Description = "Sparepart Unit",
                Value = "REF_SPAREPARTUNIT"
            });

            // SPK Category
            Reference refSPKCategory = context.References.Add(new Reference
            {
                Code = "REF_SPKCATEGORY",
                Name = "SPKCategory",
                Description = "SPK Category",
                Value = "REF_SPKCATEGORY"
            });

            context.SaveChanges();

            // - Sparepart Category Child
            context.References.Add(new Reference
            {
                Code = "S",
                Name = "Service",
                Description = "Service",
                Value = "S",
                ParentId = refSparepartCategory.Id
            });
            context.References.Add(new Reference
            {
                Code = "R",
                Name = "Rusak",
                Description = "Rusak",
                Value = "R",
                ParentId = refSparepartCategory.Id
            });
            context.References.Add(new Reference
            {
                Code = "TLGS",
                Name = "-- Should Be Update",
                Description = "-- Should Be Update",
                Value = "TLGS",
                ParentId = refSparepartCategory.Id
            });
            context.References.Add(new Reference
            {
                Code = "TLGPS",
                Name = "-- Should Be Update",
                Description = "-- Should Be Update",
                Value = "TLGPS",
                ParentId = refSparepartCategory.Id
            });
            context.References.Add(new Reference
            {
                Code = "TLGR",
                Name = "-- Should Be Update",
                Description = "-- Should Be Update",
                Value = "TLGR",
                ParentId = refSparepartCategory.Id
            });
            context.References.Add(new Reference
            {
                Code = "TLGPR",
                Name = "-- Should Be Update",
                Description = "-- Should Be Update",
                Value = "TLGPR",
                ParentId = refSparepartCategory.Id
            });
            context.References.Add(new Reference
            {
                Code = "-",
                Name = "None",
                Description = "Uncategorized",
                Value = "-",
                ParentId = refSparepartCategory.Id
            });

            // -- Sparepart Unit Child
            context.References.Add(new Reference
            {
                Code = "BTL",
                Name = "Botol",
                Description = "Botol",
                Value = "BTL",
                ParentId = refSparepartUnit.Id
            });
            context.References.Add(new Reference
            {
                Code = "PC",
                Name = "Piece",
                Description = "Piece",
                Value = "PC",
                ParentId = refSparepartUnit.Id
            });
            context.References.Add(new Reference
            {
                Code = "KLG",
                Name = "Kaleng",
                Description = "Kaleng",
                Value = "KLG",
                ParentId = refSparepartUnit.Id
            });
            context.References.Add(new Reference
            {
                Code = "MTR",
                Name = "Meter",
                Description = "Meter",
                Value = "MTR",
                ParentId = refSparepartUnit.Id
            });
            context.References.Add(new Reference
            {
                Code = "LTR",
                Name = "Liter",
                Description = "Liter",
                Value = "LTR",
                ParentId = refSparepartUnit.Id
            });
            context.References.Add(new Reference
            {
                Code = "LBR",
                Name = "-- Should Be Update",
                Description = "-- Should Be Update",
                Value = "LBR",
                ParentId = refSparepartUnit.Id
            });
            context.References.Add(new Reference
            {
                Code = "ST",
                Name = "-- Should Be Update",
                Description = "-- Should Be Update",
                Value = "ST",
                ParentId = refSparepartUnit.Id
            });
            context.References.Add(new Reference
            {
                Code = "KG",
                Name = "-- Should Be Update",
                Description = "-- Should Be Update",
                Value = "KG",
                ParentId = refSparepartUnit.Id
            });
            context.References.Add(new Reference
            {
                Code = "-",
                Name = "None",
                Description = "Tidak ada satuan",
                Value = "-",
                ParentId = refSparepartUnit.Id
            });

            // SPK Category child
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_SPK_CATEGORY_SERVICE,
                Name = "Service",
                Description = "SPK untuk Service",
                Value = "S",
                ParentId = refSPKCategory.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_SPK_CATEGORY_REPAIR,
                Name = "Perbaikan",
                Description = "SPK untuk Perbaikan",
                Value = "R",
                ParentId = refSPKCategory.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_SPK_CATEGORY_SALE,
                Name = "Langsung",
                Description = "SPK untuk Onderdil Langsung",
                Value = "L",
                ParentId = refSPKCategory.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_SPK_CATEGORY_INVENTORY,
                Name = "Inventaris",
                Description = "SPK untuk Inventaris",
                Value = "I",
                ParentId = refSPKCategory.Id
            });

            // Transaction Table
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_TRANSTBL_PURCHASING,
                Name = "Purchasing Table",
                Description = "Tabel Transaksi Purchasing",
                Value = DbConstant.REF_TRANSTBL_PURCHASING
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_TRANSTBL_INVOICE,
                Name = "Invoice Table",
                Description = "Tabel Transaksi Invoice",
                Value = DbConstant.REF_TRANSTBL_INVOICE
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_TRANSTBL_MANUAL,
                Name = "Manual Transaction Table",
                Description = "Tabel Manual Transaksi",
                Value = DbConstant.REF_TRANSTBL_MANUAL
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_TRANSTBL_HPP,
                Name = "HPP Transaction Table",
                Description = "Tabel Transaksi HPP",
                Value = DbConstant.REF_TRANSTBL_HPP
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_TRANSTBL_PURCHASERETURN,
                Name = "Purchase Return Table",
                Description = "Tabel Transaksi Purchase Return",
                Value = DbConstant.REF_TRANSTBL_PURCHASERETURN
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_TRANSTBL_SALESRETURN,
                Name = "Sales Return Table",
                Description = "Tabel Transaksi Sales Return",
                Value = DbConstant.REF_TRANSTBL_SALESRETURN
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_TRANSTBL_SPAREPARTMANUAL,
                Name = "Sparepart Manual Table",
                Description = "Tabel Transaksi Sparepart Manual",
                Value = DbConstant.REF_TRANSTBL_SPAREPARTMANUAL
            }); context.SaveChanges();

            // Purchasing Payment Method
            Reference purchasePaymentMethodRef = context.References.Add(new Reference
            {
                Code = DbConstant.REF_PURCHASE_PAYMENTMETHOD,
                Name = "Purchase Payment Method",
                Description = "Jenis pembayaran untuk pembelian sparepart",
                Value = DbConstant.REF_PURCHASE_PAYMENTMETHOD
            });
            context.SaveChanges();

            // Purchasing Payment Method Children
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_KAS,
                Name = "Uang Muka dari Kas",
                Description = "Jenis pembayaran untuk pembelian sparepart menggunakan uang muka dari kas",
                Value = "1.01.01.01",
                ParentId = purchasePaymentMethodRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK_EKONOMI,
                Name = "Uang Muka dari Bank Ekonomi",
                Description = "Jenis pembayaran untuk pembelian sparepart menggunakan uang muka dari bank ekonomi",
                Value = "1.01.02.01",
                ParentId = purchasePaymentMethodRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK_BCA1,
                Name = "Uang Muka dari Bank BCA 1",
                Description = "Jenis pembayaran untuk pembelian sparepart menggunakan uang muka dari bank bca 1",
                Value = "1.01.02.02",
                ParentId = purchasePaymentMethodRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK_BCA2,
                Name = "Uang Muka dari Bank BCA 2",
                Description = "Jenis pembayaran untuk pembelian sparepart menggunakan uang muka dari bank bca 2",
                Value = "1.01.02.03",
                ParentId = purchasePaymentMethodRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_PURCHASE_PAYMENTMETHOD_KAS,
                Name = "Kas",
                Description = "Jenis pembayaran untuk pembelian sparepart menggunakan uang kas",
                Value = "1.01.01.01",
                ParentId = purchasePaymentMethodRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_PURCHASE_PAYMENTMETHOD_BANK_EKONOMI,
                Name = "Bank Ekonomi",
                Description = "Jenis pembayaran untuk pembelian sparepart menggunakan transfer bank ekonomi",
                Value = "1.01.02.01",
                ParentId = purchasePaymentMethodRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_PURCHASE_PAYMENTMETHOD_BANK_BCA1,
                Name = "Bank BCA 1",
                Description = "Jenis pembayaran untuk pembelian sparepart menggunakan transfer bank bca 1",
                Value = "1.01.02.02",
                ParentId = purchasePaymentMethodRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_PURCHASE_PAYMENTMETHOD_BANK_BCA2,
                Name = "Bank BCA 2",
                Description = "Jenis pembayaran untuk pembelian sparepart menggunakan transfer bank bca 2",
                Value = "1.01.02.03",
                ParentId = purchasePaymentMethodRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_PURCHASE_PAYMENTMETHOD_UTANG,
                Name = "Utang",
                Description = "Jenis pembayaran untuk pembelian sparepart dengan cara utang",
                Value = "2.01.01.01",
                ParentId = purchasePaymentMethodRef.Id
            });
            context.SaveChanges();

            // Invoice Payment Method
            Reference invoicePaymentMethodRef = context.References.Add(new Reference
            {
                Code = DbConstant.REF_INVOICE_PAYMENTMETHOD,
                Name = "Invoice Payment Method",
                Description = "Jenis pembayaran untuk invoice",
                Value = DbConstant.REF_INVOICE_PAYMENTMETHOD
            });
            context.SaveChanges();

            // Invoice Payment Method Children
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_INVOICE_PAYMENTMETHOD_UANGMUKA_KAS,
                Name = "Uang Muka dari Kas",
                Description = "Jenis pembayaran untuk invoice menggunakan uang muka dari kas",
                Value = "1.01.01.01",
                ParentId = invoicePaymentMethodRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_INVOICE_PAYMENTMETHOD_UANGMUKA_BANK_EKONOMI,
                Name = "Uang Muka dari Bank Ekonomi",
                Description = "Jenis pembayaran untuk invoice menggunakan uang muka dari bank ekonomi",
                Value = "1.01.02.01",
                ParentId = invoicePaymentMethodRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_INVOICE_PAYMENTMETHOD_UANGMUKA_BANK_BCA1,
                Name = "Uang Muka dari Bank BCA 1",
                Description = "Jenis pembayaran untuk invoice menggunakan uang muka dari bank bca 1",
                Value = "1.01.02.02",
                ParentId = invoicePaymentMethodRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_INVOICE_PAYMENTMETHOD_UANGMUKA_BANK_BCA2,
                Name = "Uang Muka dari Bank BCA 2",
                Description = "Jenis pembayaran untuk invoice menggunakan uang muka dari bank bca 2",
                Value = "1.01.02.03",
                ParentId = invoicePaymentMethodRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_INVOICE_PAYMENTMETHOD_KAS,
                Name = "Kas",
                Description = "Jenis pembayaran untuk invoice menggunakan uang kas",
                Value = "1.01.01.01",
                ParentId = invoicePaymentMethodRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_INVOICE_PAYMENTMETHOD_BANK_EKONOMI,
                Name = "Bank Ekonomi",
                Description = "Jenis pembayaran untuk invoice menggunakan transfer bank ekonomi",
                Value = "1.01.02.01",
                ParentId = invoicePaymentMethodRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_INVOICE_PAYMENTMETHOD_BANK_BCA1,
                Name = "Bank BCA 1",
                Description = "Jenis pembayaran untuk invoice menggunakan transfer bank bca 1",
                Value = "1.01.02.02",
                ParentId = invoicePaymentMethodRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_INVOICE_PAYMENTMETHOD_BANK_BCA2,
                Name = "Bank BCA 2",
                Description = "Jenis pembayaran untuk invoice menggunakan transfer bank bca 2",
                Value = "1.01.02.03",
                ParentId = invoicePaymentMethodRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_INVOICE_PAYMENTMETHOD_PIUTANG,
                Name = "Piutang",
                Description = "Jenis pembayaran untuk invoice dengan cara piutang",
                Value = "2.01.01.01",
                ParentId = invoicePaymentMethodRef.Id
            });
            context.SaveChanges();

            // Debt Payment Method
            Reference debtPaymentMethodRef = context.References.Add(new Reference
            {
                Code = DbConstant.REF_DEBT_PAYMENTMETHOD,
                Name = "Debt Payment Method",
                Description = "Jenis pembayaran untuk hutang",
                Value = DbConstant.REF_DEBT_PAYMENTMETHOD
            });
            context.SaveChanges();

            context.References.Add(new Reference
            {
                Code = DbConstant.REF_DEBT_PAYMENTMETHOD_KAS,
                Name = "Kas",
                Description = "Jenis pembayaran untuk hutang menggunakan uang kas",
                Value = "1.01.01.01",
                ParentId = debtPaymentMethodRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_DEBT_PAYMENTMETHOD_BANK_EKONOMI,
                Name = "Bank Ekonomi",
                Description = "Jenis pembayaran untuk hutang menggunakan transfer bank ekonomi",
                Value = "1.01.02.01",
                ParentId = debtPaymentMethodRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_DEBT_PAYMENTMETHOD_BANK_BCA1,
                Name = "Bank BCA 1",
                Description = "Jenis pembayaran untuk hutang menggunakan transfer bank bca 1",
                Value = "1.01.02.02",
                ParentId = debtPaymentMethodRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_DEBT_PAYMENTMETHOD_BANK_BCA2,
                Name = "Bank BCA 2",
                Description = "Jenis pembayaran untuk hutang menggunakan transfer bank bca 2",
                Value = "1.01.02.03",
                ParentId = debtPaymentMethodRef.Id
            });
            context.SaveChanges();

            // Sparepart Manual Transaction Type
            Reference sparepartManualTransactionRef = context.References.Add(new Reference
            {
                Code = DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE,
                Name = "Sparepart Manual Transaction Type",
                Description = "Jenis tipe transaksi manual sparepart",
                Value = DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE
            });
            context.SaveChanges();

            // Sparepart Manual Transaction Type Children
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_PLUS,
                Name = "Tipe Penambahan Sparepart Manual",
                Description = "Tipe Penambahan Sparepart Manual",
                Value = DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_PLUS,
                ParentId = sparepartManualTransactionRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_MINUS,
                Name = "Tipe Pengurangan Sparepart Manual",
                Description = "Tipe Pengurangan Sparepart Manual",
                Value = DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_MINUS,
                ParentId = sparepartManualTransactionRef.Id
            });
            context.SaveChanges();

            // Used Good Transaction Manual Type
            Reference usedGoodManualTransactionRef = context.References.Add(new Reference
            {
                Code = DbConstant.REF_USEDGOOD_TRANSACTION_MANUAL_TYPE,
                Name = "Barang Bekas Manual Transaction Type",
                Description = "Jenis tipe transaksi manual barang bekas",
                Value = DbConstant.REF_USEDGOOD_TRANSACTION_MANUAL_TYPE
            });
            context.SaveChanges();

            // Used Good Manual Transaction Type Children
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_USEDGOOD_TRANSACTION_MANUAL_TYPE_PLUS,
                Name = "Tipe Penambahan Barang Bekas Manual",
                Description = "Tipe Penambahan Barang Bekas Manual",
                Value = DbConstant.REF_USEDGOOD_TRANSACTION_MANUAL_TYPE_PLUS,
                ParentId = usedGoodManualTransactionRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_USEDGOOD_TRANSACTION_MANUAL_TYPE_MINUS,
                Name = "Tipe Pengurangan Barang Bekas Manual",
                Description = "Tipe Pengurangan Barang Bekas Manual",
                Value = DbConstant.REF_USEDGOOD_TRANSACTION_MANUAL_TYPE_MINUS,
                ParentId = usedGoodManualTransactionRef.Id
            });
            context.SaveChanges();

            // Used Good Transaction Type
            Reference usedGoodTransactionRef = context.References.Add(new Reference
            {
                Code = DbConstant.REF_USEDGOOD_TRANSACTION_TYPE,
                Name = "Barang Bekas Transaction Type",
                Description = "Jenis tipe transaksi barang bekas",
                Value = DbConstant.REF_USEDGOOD_TRANSACTION_TYPE
            });
            context.SaveChanges();

            // Used Good Transaction Type Children
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_USEDGOOD_TRANSACTION_TYPE_SPK,
                Name = "Tipe Barang Bekas Masuk Melalui SPK",
                Description = "Tipe Barang Bekas Masuk Melalui SPK",
                Value = DbConstant.REF_USEDGOOD_TRANSACTION_TYPE_SPK,
                ParentId = usedGoodTransactionRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_USEDGOOD_TRANSACTION_TYPE_RECYCLE,
                Name = "Tipe Recycle Barang Bekas",
                Description = "Tipe Recycle Barang Bekas",
                Value = DbConstant.REF_USEDGOOD_TRANSACTION_TYPE_RECYCLE,
                ParentId = usedGoodTransactionRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_USEDGOOD_TRANSACTION_TYPE_SOLD,
                Name = "Tipe Penjualan Barang Bekas",
                Description = "Tipe Penjualan Barang Bekas",
                Value = DbConstant.REF_USEDGOOD_TRANSACTION_TYPE_SOLD,
                ParentId = usedGoodTransactionRef.Id
            });
            context.SaveChanges();

            // Special Sparepart Type
            Reference specialSparepartRef = context.References.Add(new Reference
            {
                Code = DbConstant.REF_SPECIAL_SPAREPART_TYPE,
                Name = "Tipe Sparepart",
                Description = "Jenis tipe sparepart (eg: ban, biasa)",
                Value = DbConstant.REF_SPECIAL_SPAREPART_TYPE
            });
            context.SaveChanges();

            // Special Sparepart Type Children
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_SPECIAL_SPAREPART_TYPE_WHEEL,
                Name = "Tipe Sparepart Ban",
                Description = "Tipe Sparepart Ban",
                Value = DbConstant.REF_SPECIAL_SPAREPART_TYPE_WHEEL,
                ParentId = specialSparepartRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_SPECIAL_SPAREPART_TYPE_REGULAR,
                Name = "Tipe Sparepart Biasa",
                Description = "Tipe Sparepart Biasa",
                Value = DbConstant.REF_SPECIAL_SPAREPART_TYPE_REGULAR,
                ParentId = specialSparepartRef.Id
            });
            context.SaveChanges();

            // Settings
            context.Settings.Add(new Setting
            {
                Key = DbConstant.SETTING_MINTSTOCK,
                Value = "50"
            });
            context.Settings.Add(new Setting
            {
                Key = DbConstant.SETTING_FINGERPRINT_IPADDRESS,
                Value = "192.168.1.201"
            });
            context.Settings.Add(new Setting
            {
                Key = DbConstant.SETTING_FINGERPRINT_PORT,
                Value = "4370"
            });

            // SPK Threshold Setting
            context.Settings.Add(new Setting
            {
                Key = DbConstant.SETTING_SPK_THRESHOLD_S,
                Value = "15000000"
            });

            context.Settings.Add(new Setting
            {
                Key = DbConstant.SETTING_SPK_THRESHOLD_P,
                Value = "5000000"
            });
            context.SaveChanges();

            context.Database.ExecuteSqlCommand(@"SET GLOBAL log_bin_trust_function_creators = 1;");
            context.Database.ExecuteSqlCommand(@"CREATE FUNCTION `TruncateTime`(dateValue DATETIME) RETURNS DATE
                                                 BEGIN
                                                 RETURN DATE(dateValue);
                                                 END");
            context.Database.ExecuteSqlCommand(@"CREATE OR REPLACE VIEW `vw_guestbook` AS
                                                 SELECT
                                                 b.Code `Kode`, b.ActiveLicenseNumber `Nopol`, a.Description `Keterangan`
                                                 FROM guestbooks a, vehicles b, spks c
                                                 WHERE a.vehicleId = b.Id AND b.Id = c.VehicleId
                                                 AND c.StatusCompletedId = 0;");
            context.Database.ExecuteSqlCommand(@"CREATE OR REPLACE VIEW `vw_servicestatus` AS
                                                 SELECT
                                                 b.Code `Kode`, b.ActiveLicenseNumber `Nopol`, c.CreateDate `Tgl. Masuk`,
                                                 c.DueDate `Perkiraan Selesai`, 'In Progress' `Status`
                                                 FROM vehicles b, spks c
                                                 WHERE b.Id = c.VehicleId AND c.StatusCompletedId = 0;");
            context.Database.ExecuteSqlCommand(@"CREATE PROCEDURE `sp_updatevehicle_km`(
	                                                 IN p_code LONGTEXT,
                                                     IN p_km INT
                                                 )
                                                 BEGIN
	                                                 UPDATE vehicle
                                                     SET kilometers = p_km
                                                     WHERE `code`=p_code;
                                                 END");
            context.Database.ExecuteSqlCommand(@"CREATE PROCEDURE `sp_updatevehicle_wheel_km` (
	                                                 IN p_serialnumber VARCHAR(100),
                                                     IN p_km INT
                                                 )
                                                 BEGIN
	                                                 UPDATE specialsparepartdetails
                                                     SET kilometers = p_km
                                                     WHERE serialnumber = p_serialnumber;
                                                 END");
        }
    }
}
