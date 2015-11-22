using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;

namespace BrawijayaWorkshop.Infrastructure.Repository
{
    public interface IRepository<T, U>
        where T : class, new()
        where U : DbContext
    {
        IDatabaseFactory<U> DatabaseFactory { get; }

        T GetById<TID>(TID id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);

        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
