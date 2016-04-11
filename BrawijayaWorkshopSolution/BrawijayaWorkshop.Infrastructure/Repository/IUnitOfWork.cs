
using System.Data.Entity;

namespace BrawijayaWorkshop.Infrastructure.Repository
{
    public interface IUnitOfWork
    {
        DbContextTransaction BeginTransaction();
        void SaveChanges();
    }
}
