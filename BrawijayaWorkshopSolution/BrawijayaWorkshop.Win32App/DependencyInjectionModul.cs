﻿using BrawijayaWorkshop.Database;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using Ninject.Modules;

namespace BrawijayaWorkshop.Win32App
{
    public class DependencyInjectionModul : NinjectModule
    {
        public override void Load()
        {
            Bind<IDatabaseFactory<BrawijayaWorkshopDbContext>>().To<AppDatabaseFactory>().InSingletonScope();
            Bind<IUnitOfWork>().To<AppUnitOfWork>().InSingletonScope();

            Bind<ISettingRepository>().To<SettingRepository>();
            Bind<IRoleRepository>().To<RoleRepository>();
            Bind<IUserRepository>().To<UserRepository>();
            Bind<IUserRoleRepository>().To<UserRoleRepository>();
            Bind<IApplicationModulRepository>().To<ApplicationModulRepository>();
            Bind<IRoleAccessRepository>().To<RoleAccessRepository>();
            Bind<ICityRepository>().To<CityRepository>();
            Bind<ICustomerRepository>().To<CustomerRepository>();
            Bind<IPurchasingRepository>().To<PurchasingRepository>();
            Bind<IPurchasingDetailRepository>().To<PurchasingDetailRepository>();
            Bind<IReferenceRepository>().To<ReferenceRepository>();
            Bind<ISparepartRepository>().To<SparepartRepository>();
            Bind<ISparepartDetailRepository>().To<SparepartDetailRepository>();
            Bind<ISupplierRepository>().To<SupplierRepository>();
            Bind<IVehicleRepository>().To<VehicleRepository>();
            Bind<IVehicleDetailRepository>().To<VehicleDetailRepository>();
            Bind<IJournalMasterRepository>().To<JournalMasterRepository>();
            Bind<IMechanicRepository>().To<MechanicRepository>();
            Bind<ISPKRepository>().To<SPKRepository>();
            Bind<ISPKDetailMechanicRepository>().To<SPKDetailMechanicRepository>();
            Bind<ISPKDetailSparepartRepository>().To<SPKDetailSparepartRepository>();
            Bind<ISPKDetailSparepartDetailRepository>().To<SPKDetailSparepartDetailRepository>();

            // todo: add binding
        }
    }
}