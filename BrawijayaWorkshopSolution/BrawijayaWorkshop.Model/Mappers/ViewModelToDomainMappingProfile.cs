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
            
        }
    }
}
