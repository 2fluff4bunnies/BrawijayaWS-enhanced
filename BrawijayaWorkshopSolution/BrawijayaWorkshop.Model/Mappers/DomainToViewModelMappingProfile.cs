using AutoMapper;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.SharedObject.ViewModels;

namespace BrawijayaWorkshop.Model.Mappers
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            //TODO: Add Mapping Entity to ViewModel
            Mapper.CreateMap<Purchasing, PurchasingViewModel>();
            Mapper.CreateMap<City, CityViewModel>();
            Mapper.CreateMap<Customer, CustomerViewModel>();
            Mapper.CreateMap<Supplier, SupplierViewModel>();
            Mapper.CreateMap<JournalMaster, JournalMasterViewModel>();
            Mapper.CreateMap<Role, RoleViewModel>();
            Mapper.CreateMap<User, UserViewModel>();
            Mapper.CreateMap<UserRole, UserRoleViewModel>();
            Mapper.CreateMap<RoleAccess, RoleAccessViewModel>();
            Mapper.CreateMap<Setting, SettingViewModel>();
            Mapper.CreateMap<ApplicationModul, ApplicationModulViewModel>();
            Mapper.CreateMap<Vehicle, VehicleViewModel>();
            Mapper.CreateMap<VehicleDetail, VehicleDetailViewModel>();
            Mapper.CreateMap<Sparepart, SparepartViewModel>();
            Mapper.CreateMap<SparepartDetail, SparepartDetailViewModel>();
            Mapper.CreateMap<Purchasing, PurchasingViewModel>();
            Mapper.CreateMap<PurchasingDetail, PurchasingDetailViewModel>();
            Mapper.CreateMap<GuestBook, GuestBookViewModel>();
            Mapper.CreateMap<Mechanic, MechanicViewModel>();
            Mapper.CreateMap<SPK, SPKViewModel>();
            Mapper.CreateMap<SPKDetailSparepart, SPKDetailSparepartViewModel>();
            Mapper.CreateMap<SPKDetailSparepartDetail, SPKDetailSparepartDetailViewModel>();
            Mapper.CreateMap<SPKSchedule, SPKScheduleViewModel>();
            Mapper.CreateMap<Transaction, TransactionViewModel>();
            Mapper.CreateMap<TransactionDetail, TransactionDetailViewModel>();
        }
    }
}
