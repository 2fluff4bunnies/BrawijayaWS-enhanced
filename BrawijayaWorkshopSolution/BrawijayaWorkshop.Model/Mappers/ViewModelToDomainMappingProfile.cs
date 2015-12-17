using AutoMapper;

namespace BrawijayaWorkshop.Model.Mappers
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "ViewModelToDomainMappingProfile";
            }
        }

        protected override void Configure()
        {
            //TODO: Add Mapping ViewModel to Entity
            //Mapper.CreateMap<ApplicationModulViewModel, ApplicationModul>();
        }
    }
}
