using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;


namespace BrawijayaWorkshop.Database.Repositories
{
    public class SpecialSparepartRepository : AppBaseRepository<SpecialSparepart>, ISpecialSparepartRepository
    {
        public SpecialSparepartRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }


    public interface ISpecialSparepartRepository : IRepository<SpecialSparepart, BrawijayaWorkshopDbContext>
    {
    }
}
