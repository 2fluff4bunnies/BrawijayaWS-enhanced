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
            Mapper.CreateMap<JournalMaster, JournalMasterViewModel>();
            Mapper.CreateMap<Role, RoleViewModel>();
            Mapper.CreateMap<User, UserViewModel>();
            Mapper.CreateMap<UserRole, UserRoleViewModel>();
            Mapper.CreateMap<RoleAccess, RoleAccessViewModel>();
            Mapper.CreateMap<Setting, SettingViewModel>();
            Mapper.CreateMap<ApplicationModul, ApplicationModulViewModel>();
        }
    }
}
