using AutoMapper;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.SharedObject.ViewModels;

namespace BrawijayaWorkshop.Model.Mappers
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            //TODO: Add Mapping ViewModel to Entity
            Mapper.CreateMap<PurchasingViewModel, Purchasing>();
            Mapper.CreateMap<CityViewModel, City>();
            Mapper.CreateMap<CustomerViewModel, Customer>();
            Mapper.CreateMap<SupplierViewModel, Supplier>();
            Mapper.CreateMap<JournalMasterViewModel, JournalMaster>();
            Mapper.CreateMap<RoleViewModel, Role>();
            Mapper.CreateMap<UserViewModel, User>();
            Mapper.CreateMap<UserRoleViewModel, UserRole>();
            Mapper.CreateMap<RoleAccessViewModel, RoleAccess>();
            Mapper.CreateMap<SettingViewModel, Setting>();
            Mapper.CreateMap<ApplicationModulViewModel, ApplicationModul>();
            Mapper.CreateMap<VehicleViewModel, Vehicle>();
            Mapper.CreateMap<VehicleDetailViewModel, VehicleDetail>();
            Mapper.CreateMap<SparepartViewModel, Sparepart>();
            Mapper.CreateMap<SparepartDetailViewModel, SparepartDetail>();
            Mapper.CreateMap<PurchasingViewModel, Purchasing>();
            Mapper.CreateMap<PurchasingDetailViewModel, PurchasingDetail>();
            Mapper.CreateMap<GuestBookViewModel, GuestBook>();
            Mapper.CreateMap<MechanicViewModel, Mechanic>();
            Mapper.CreateMap<SPKViewModel, SPK>();
            Mapper.CreateMap<SPKDetailSparepartViewModel, SPKDetailSparepart>();
            Mapper.CreateMap<SPKDetailSparepartDetailViewModel, SPKDetailSparepartDetail>();
            Mapper.CreateMap<SPKScheduleViewModel, SPKSchedule>();
            Mapper.CreateMap<TransactionViewModel, Transaction>();
            Mapper.CreateMap<TransactionDetailViewModel, TransactionDetail>();
        }
    }
}
