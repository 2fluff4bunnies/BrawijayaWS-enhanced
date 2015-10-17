using System;
using System.Data.Entity;

namespace BrawijayaWorkshop.Infrastructure.Repository
{
    public interface IDatabaseFactory<T> : IDisposable where T : DbContext
    {
        T Get();
    }
}
