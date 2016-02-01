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
            Mapper.CreateMap<JournalMasterViewModel, JournalMaster>();
            Mapper.CreateMap<RoleViewModel, Role>();
            Mapper.CreateMap<UserViewModel, User>();
            Mapper.CreateMap<UserRoleViewModel, UserRole>();
            Mapper.CreateMap<RoleAccessViewModel, RoleAccess>();
            Mapper.CreateMap<SettingViewModel, Setting>();
            Mapper.CreateMap<ApplicationModulViewModel, ApplicationModul>();
        }
    }
}
