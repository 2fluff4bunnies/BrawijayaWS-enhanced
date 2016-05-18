using AutoMapper;

namespace BrawijayaWorkshop.Model.Mappers
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            try
            {
                Mapper.Initialize(mapper =>
                {
                    mapper.AddProfile<ViewModelToDomainMappingProfile>();
                    mapper.AddProfile<DomainToViewModelMappingProfile>();
                });
            }
            catch { }
        }
    }
}
