using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;


namespace BrawijayaWorkshop.Database.Repositories
{
    public class GuestBookRepositories : AppBaseRepository<GuestBook>, IGuestBookRepository
    {
        public GuestBookRepositories(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }


    public interface IGuestBookRepository : IRepository<GuestBook, BrawijayaWorkshopDbContext>
    {
    }
}
