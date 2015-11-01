using BrawijayaWorkshop.Database;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using Ninject.Modules;

namespace BrawijayaWorkshop.Win32App
{
    public class DependencyInjectionModul : NinjectModule
    {
        public override void Load()
        {
            Bind<IDatabaseFactory<BrawijayaWorkshopDbContext>>().To<AppDatabaseFactory>();
            Bind<IUnitOfWork>().To<AppUnitOfWork>();

            Bind<ISettingRepository>().To<SettingRepository>();
            Bind<IRoleRepository>().To<RoleRepository>();
            Bind<IUserRepository>().To<UserRepository>();
            Bind<IUserRoleRepository>().To<UserRoleRepository>();
            Bind<IApplicationModulRepository>().To<ApplicationModulRepository>();
            Bind<IRoleAccessRepository>().To<RoleAccessRepository>();
            Bind<ICityRepository>().To<CityRepository>();
            Bind<ICustomerRepository>().To<CustomerRepository>();
        }
    }
}
