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
        }
    }
}
