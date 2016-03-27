using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MySqlEntityFramework;
using BrawijayaWorkshop.Utils;

namespace BrawijayaWorkshop.Database
{
    public class BrawijayaWorkshopDbInitializer : DropCreateMySqlDatabaseIfModelChanges<BrawijayaWorkshopDbContext>
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
            ApplicationModul spkDetailMechanicMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_SPK_DETAIL_MECHANIC,
                ModulDescription = "SPK Detail Mechanic Modul"
            });
            ApplicationModul spkDetailSparepartMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_SPK_DETAIL_SPAREPART,
                ModulDescription = "SPK Detail Sparepart Modul"
            });
            ApplicationModul spkDetailSparepartDetailMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_SPK_DETAIL_SPAREPART_DETAIL,
                ModulDescription = "SPK Detail Sparepart Detail Modul"
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
            context.SaveChanges();

            // superadmin
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = accMod.Id,
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
                ApplicationModulId = spkDetailMechanicMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = spkDetailSparepartMod.Id,
                RoleId = superAdminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = spkDetailSparepartDetailMod.Id,
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

            // admin
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = customerMod.Id,
                RoleId = adminRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = journalMod.Id,
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
                ApplicationModulId = sparepartMod.Id,
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

            // manager
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = approvalMod.Id,
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

            // finance
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = accountingMod.Id,
                RoleId = financeRole.Id,
                AccessCode = (int)DbConstant.AccessTypeEnum.All
            });
            context.SaveChanges();

            // references
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
                Code = DbConstant.REF_TRANSTBL_SPK,
                Name = "SPK Table",
                Description = "Tabel Transaksi SPK",
                Value = DbConstant.REF_TRANSTBL_SPK
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_TRANSTBL_MANUAL,
                Name = "Manual Transaction Table",
                Description = "Tabel Manual Transaksi",
                Value = DbConstant.REF_TRANSTBL_MANUAL
            });
            context.SaveChanges();

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
                Value = "2.01",
                ParentId = purchasePaymentMethodRef.Id
            });
            context.SaveChanges();

            // Purchasing Payment Method
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

            // HPP Journal Collection
            Reference hppJournalRef = context.References.Add(new Reference
            {
                Code = DbConstant.REF_HPP_JOURNAL,
                Name = "Tipe HPP",
                Description = "Journal HPP",
                Value = DbConstant.REF_HPP_JOURNAL
            });
            context.SaveChanges();

            // HPP Journal Children Collection
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_HPP_JOURNAL_SPAREPART,
                Name = "Tipe HPP Sparepart",
                Description = "Kode Akun HPP Sparepart",
                Value = "3.04.01",
                ParentId = hppJournalRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_HPP_JOURNAL_DAILYMECHANIC,
                Name = "Tipe HPP Tukang Harian",
                Description = "Kode Akun HPP Tukang Harian",
                Value = "3.04.04",
                ParentId = hppJournalRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_HPP_JOURNAL_OUTSOURCEMECHANIC,
                Name = "Tipe HPP Tukang Borongan",
                Description = "Kode Akun HPP Tukang Borongan",
                Value = "3.04.05",
                ParentId = hppJournalRef.Id
            });
            context.SaveChanges();

            // HPP Journal Collection
            Reference stockJournalRef = context.References.Add(new Reference
            {
                Code = DbConstant.REF_STOCK_JOURNAL,
                Name = "Tipe Stok",
                Description = "Journal Stok",
                Value = DbConstant.REF_STOCK_JOURNAL
            });
            context.SaveChanges();

            // Stock Journal Children Collection
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_STOCK_JOURNAL_SPAREPART,
                Name = "Tipe Stok Sparepart",
                Description = "Kode Akun Stok Sparepart",
                Value = DbConstant.REF_STOCK_JOURNAL_SPAREPART,
                ParentId = stockJournalRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_STOCK_JOURNAL_DAILYMECHANIC,
                Name = "Tipe Stok Tukang Harian",
                Description = "Kode Akun Stok Tukang Harian",
                Value = DbConstant.REF_STOCK_JOURNAL_DAILYMECHANIC,
                ParentId = stockJournalRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_STOCK_JOURNAL_OUTSOURCEMECHANIC,
                Name = "Tipe Stok Tukang Borongan",
                Description = "Kode Akun Stok Tukang Borongan",
                Value = DbConstant.REF_STOCK_JOURNAL_OUTSOURCEMECHANIC,
                ParentId = stockJournalRef.Id
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
            
            // todo: insert initial data here
        }
    }
}
