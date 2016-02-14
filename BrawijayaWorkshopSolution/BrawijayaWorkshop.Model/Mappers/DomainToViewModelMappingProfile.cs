using AutoMapper;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.SharedObject.ViewModels;

namespace BrawijayaWorkshop.Model.Mappers
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<ApplicationModul, ApplicationModulViewModel>();
            Mapper.CreateMap<City, CityViewModel>();
            Mapper.CreateMap<Customer, CustomerViewModel>();
            Mapper.CreateMap<GuestBook, GuestBookViewModel>();
            Mapper.CreateMap<Invoice, InvoiceViewModel>();
            Mapper.CreateMap<InvoiceDetail, InvoiceDetailViewModel>();
            Mapper.CreateMap<JournalMaster, JournalMasterViewModel>();
            Mapper.CreateMap<Mechanic, MechanicViewModel>();
            Mapper.CreateMap<Purchasing, PurchasingViewModel>();
            Mapper.CreateMap<PurchasingDetail, PurchasingDetailViewModel>();
            Mapper.CreateMap<Reference, ReferenceViewModel>();
            Mapper.CreateMap<Role, RoleViewModel>();
            Mapper.CreateMap<RoleAccess, RoleAccessViewModel>();
            Mapper.CreateMap<Setting, SettingViewModel>();
            Mapper.CreateMap<Sparepart, SparepartViewModel>();
            Mapper.CreateMap<SparepartDetail, SparepartDetailViewModel>();
            Mapper.CreateMap<SparepartManualTransaction, SparepartManualTransactionViewModel>();
            Mapper.CreateMap<SPK, SPKViewModel>();
            Mapper.CreateMap<SPKDetailSparepart, SPKDetailSparepartViewModel>();
            Mapper.CreateMap<SPKDetailSparepartDetail, SPKDetailSparepartDetailViewModel>();
            Mapper.CreateMap<SPKSchedule, SPKScheduleViewModel>();
            Mapper.CreateMap<Supplier, SupplierViewModel>();
            Mapper.CreateMap<Transaction, TransactionViewModel>();
            Mapper.CreateMap<TransactionDetail, TransactionDetailViewModel>();
            Mapper.CreateMap<UsedGood, UsedGoodViewModel>();
            Mapper.CreateMap<UsedGoodTransaction, UsedGoodTransactionViewModel>();
            Mapper.CreateMap<User, UserViewModel>();
            Mapper.CreateMap<UserRole, UserRoleViewModel>();
            Mapper.CreateMap<Vehicle, VehicleViewModel>();
            Mapper.CreateMap<VehicleDetail, VehicleDetailViewModel>();
            Mapper.CreateMap<VehicleWheel, VehicleWheelViewModel>();
            Mapper.CreateMap<Wheel, WheelViewModel>();
            Mapper.CreateMap<WheelDetail, WheelDetailViewModel>();
        }
    }
}
