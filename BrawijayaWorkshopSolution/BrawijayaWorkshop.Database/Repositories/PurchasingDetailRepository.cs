using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class PurchasingDetailRepository : AppBaseRepository<PurchasingDetail>, IPurchasingDetailRepository
    {
        public PurchasingDetailRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IPurchasingDetailRepository : IRepository<PurchasingDetail, BrawijayaWorkshopDbContext>
    {
    }
}
