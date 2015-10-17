using BrawijayaWorkshop.Database;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using Ninject.Modules;

namespace BrawijayaWorkshop.Win32App
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDatabaseFactory<BrawijayaWorkshopDbContext>>().To<AppDatabaseFactory>();
            Bind<IUnitOfWork>().To<AppUnitOfWork>();

            Bind<ISettingRepository>().To<SettingRepository>();
            Bind<IRoleRepository>().To<RoleRepository>();
        }
    }
}
