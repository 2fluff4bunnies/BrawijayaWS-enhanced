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
            ApplicationModul sparepartMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_SPAREPART,
                ModulDescription = "Sparepart Modul"
            });
            ApplicationModul supplierMod = context.ApplicationModuls.Add(new ApplicationModul
            {
                ModulName = DbConstant.MODUL_SUPPLIER,
                ModulDescription = "Supplier Modul"
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
            context.SaveChanges();

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
                ApplicationModulId = vehicleMod.Id,
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
            context.SaveChanges();
            
            // todo: insert initial data here
        }
    }
}
