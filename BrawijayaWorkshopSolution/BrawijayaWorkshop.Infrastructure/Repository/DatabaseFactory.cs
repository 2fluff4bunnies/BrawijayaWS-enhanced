using System;
using System.Data.Entity;

namespace BrawijayaWorkshop.Infrastructure.Repository
{
    public class DatabaseFactory<T> : Disposable, IDatabaseFactory<T> where T : DbContext
    {
        private T _dbContext;

        public T Get()
        {
            return _dbContext ?? (_dbContext = Activator.CreateInstance<T>());
        }

        protected override void DisposeCore()
        {
            if (_dbContext != null)
                _dbContext.Dispose();
        }
    }
}
