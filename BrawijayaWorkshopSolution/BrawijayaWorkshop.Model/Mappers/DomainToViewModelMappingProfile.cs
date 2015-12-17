using AutoMapper;

namespace BrawijayaWorkshop.Model.Mappers
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMappingProfile";
            }
        }

        protected override void Configure()
        {
            //TODO: Add Mapping Entity to ViewModel
            //Mapper.CreateMap<ApplicationModul, ApplicationModulViewModel>();
        }
    }
}
