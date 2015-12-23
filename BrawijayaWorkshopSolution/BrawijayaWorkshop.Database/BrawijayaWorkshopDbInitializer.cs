﻿using BrawijayaWorkshop.Constant;
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

            User superAdminUser = context.Users.Add(new User
            {
                FirstName = "Super",
                LastName = "Admin",
                IsActive = true,
                UserName = "superadmin",
                Password = "!0superadmin123".Encrypt()
            });

            User adminUser = context.Users.Add(new User
            {
                FirstName = "Admin",
                LastName = "-",
                IsActive = true,
                UserName = "admin",
                Password = "!0admin123".Encrypt()
            });

            User managerUser = context.Users.Add(new User
            {
                FirstName = "Manager",
                LastName = "-",
                IsActive = true,
                UserName = "manager",
                Password = "!0manager123".Encrypt()
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
            context.SaveChanges();

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

            context.SaveChanges();

            // superadmin
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

            // manager
            context.RoleAccesses.Add(new RoleAccess
            {
                ApplicationModulId = approvalMod.Id,
                RoleId = managerRole.Id,
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
                Code = "S",
                Name = "Service",
                Description = "SPK untuk Service",
                Value = "S",
                ParentId = refSPKCategory.Id
            });
            context.References.Add(new Reference
            {
                Code = "P",
                Name = "Perbaikan",
                Description = "SPK untuk Perbaikan",
                Value = "R",
                ParentId = refSPKCategory.Id
            });
            context.References.Add(new Reference
            {
                Code = "L",
                Name = "Langsung",
                Description = "SPK untuk Onderdil Langsung",
                Value = "L",
                ParentId = refSPKCategory.Id
            });
            context.References.Add(new Reference
            {
                Code = "I",
                Name = "Inventaris",
                Description = "SPK untuk Inventaris",
                Value = "L",
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
                Value = "1.01.05",
                ParentId = purchasePaymentMethodRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK,
                Name = "Uang Muka dari Bank",
                Description = "Jenis pembayaran untuk pembelian sparepart menggunakan uang muka dari bank",
                Value = "1.01.05",
                ParentId = purchasePaymentMethodRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_PURCHASE_PAYMENTMETHOD_KAS,
                Name = "Kas",
                Description = "Jenis pembayaran untuk pembelian sparepart menggunakan uang kas",
                Value = "1.01.01",
                ParentId = purchasePaymentMethodRef.Id
            });
            context.References.Add(new Reference
            {
                Code = DbConstant.REF_PURCHASE_PAYMENTMETHOD_BANK,
                Name = "Bank",
                Description = "Jenis pembayaran untuk pembelian sparepart menggunakan transfer bank",
                Value = "1.01.02",
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
