using AutoMapper;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.SharedObject.ViewModels;

namespace BrawijayaWorkshop.Model.Mappers
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<ApplicationModulViewModel, ApplicationModul>();
            Mapper.CreateMap<CityViewModel, City>();
            Mapper.CreateMap<CustomerViewModel, Customer>();
            Mapper.CreateMap<GuestBookViewModel, GuestBook>();
            Mapper.CreateMap<InvoiceViewModel, Invoice>();
            Mapper.CreateMap<InvoiceDetailViewModel, InvoiceDetail>();
            Mapper.CreateMap<JournalMasterViewModel, JournalMaster>();
            Mapper.CreateMap<MechanicViewModel, Mechanic>();
            Mapper.CreateMap<PurchasingViewModel, Purchasing>();
            Mapper.CreateMap<PurchasingDetailViewModel, PurchasingDetail>();
            Mapper.CreateMap<ReferenceViewModel, Reference>();
            Mapper.CreateMap<RoleViewModel, Role>();
            Mapper.CreateMap<RoleAccessViewModel, RoleAccess>();
            Mapper.CreateMap<SettingViewModel, Setting>();
            Mapper.CreateMap<SparepartViewModel, Sparepart>();
            Mapper.CreateMap<SparepartDetailViewModel, SparepartDetail>();
            Mapper.CreateMap<SparepartManualTransactionViewModel, SparepartManualTransaction>();
            Mapper.CreateMap<SPKViewModel, SPK>();
            Mapper.CreateMap<SPKDetailSparepartViewModel, SPKDetailSparepart>();
            Mapper.CreateMap<SPKDetailSparepartDetailViewModel, SPKDetailSparepartDetail>();
            Mapper.CreateMap<SPKScheduleViewModel, SPKSchedule>();
            Mapper.CreateMap<SupplierViewModel, Supplier>();
            Mapper.CreateMap<TransactionViewModel, Transaction>();
            Mapper.CreateMap<TransactionDetailViewModel, TransactionDetail>();
            Mapper.CreateMap<UsedGoodViewModel, UsedGood>();
            Mapper.CreateMap<UsedGoodTransactionViewModel, UsedGoodTransaction>();
            Mapper.CreateMap<UserViewModel, User>();
            Mapper.CreateMap<UserRoleViewModel, UserRole>();
            Mapper.CreateMap<VehicleViewModel, Vehicle>();
            Mapper.CreateMap<VehicleDetailViewModel, VehicleDetail>();
            Mapper.CreateMap<VehicleWheelViewModel, VehicleWheel>();
            Mapper.CreateMap<WheelViewModel, Wheel>();
            Mapper.CreateMap<WheelDetailViewModel, WheelDetail>();
        }
    }
}
