using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BrawijayaWorkshop.Infrastructure.Repository
{
    public interface IRepository<T> where T : class, new()
    {
        T GetById<TID>(TID id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);

        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
