using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MySqlEntityFramework;

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
            context.Roles.Add(new Role
            {
                Name = DbConstant.ROLE_ADMIN
            });
            context.Roles.Add(new Role
            {
                Name = DbConstant.ROLE_MANAGER
            });

            User superAdminUser = context.Users.Add(new User
            {
                FirstName = "Super",
                LastName = "Admin",
                IsActive = true,
                UserName = "superadmin",
                Password = "!0admin123"
            });
            context.SaveChanges();

            context.UserRoles.Add(new UserRole
            {
                RoleId = superAdminRole.Id,
                UserId = superAdminUser.Id
            });
            context.SaveChanges();

            
            // todo: insert initial data here
        }
    }
}
