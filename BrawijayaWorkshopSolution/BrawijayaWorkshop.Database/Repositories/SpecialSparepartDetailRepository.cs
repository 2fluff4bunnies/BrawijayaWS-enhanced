using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;


namespace BrawijayaWorkshop.Database.Repositories
{
    public class SpecialSparepartDetailRepository : AppBaseRepository<SpecialSparepartDetail>, ISpecialSparepartDetailRepository
    {
        public SpecialSparepartDetailRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }


    public interface ISpecialSparepartDetailRepository : IRepository<SpecialSparepartDetail, BrawijayaWorkshopDbContext>
    {
    }
}
