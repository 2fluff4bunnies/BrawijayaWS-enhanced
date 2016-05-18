using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model.Mappers;

namespace BrawijayaWorkshop.Model
{
    public class AppBaseModel : BaseModel
    {
        public AppBaseModel()
        {
            AutoMapperConfiguration.Configure();
        }

        protected TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            return AutoMapper.Mapper.Map(source, destination);
        }
    }
}
