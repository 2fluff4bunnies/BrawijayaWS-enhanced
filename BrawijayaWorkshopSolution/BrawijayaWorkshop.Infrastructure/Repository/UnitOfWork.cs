using System;
using System.Data.Entity;

namespace BrawijayaWorkshop.Infrastructure.Repository
{
    public class UnitOfWork<T> : IUnitOfWork where T : DbContext
    {
        private readonly IDatabaseFactory<T> _dbFactory;

        protected T DbContext
        {
            get
            {
                return _dbFactory.Get();
            }
        }

        public UnitOfWork(IDatabaseFactory<T> dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public void SaveChanges()
        {
            try
            {
                DbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DbContextTransaction BeginTransaction()
        {
            return DbContext.Database.BeginTransaction();
        }
    }
}
