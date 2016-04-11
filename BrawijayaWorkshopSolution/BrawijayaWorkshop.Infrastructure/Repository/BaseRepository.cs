using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace BrawijayaWorkshop.Infrastructure.Repository
{
    public abstract class BaseRepository<T, U>
        where T : class, new()
        where U : DbContext
    {
        private U _dataContext;
        private readonly IDbSet<T> _dbset;

        protected BaseRepository(IDatabaseFactory<U> databaseFactory)
        {
            DatabaseFactory = databaseFactory;
            _dbset = DataContext.Set<T>();
        }

        public IDatabaseFactory<U> DatabaseFactory { get; private set; }

        protected U DataContext
        {
            get { return _dataContext ?? (_dataContext = DatabaseFactory.Get()); }
        }

        #region Database Transactions
        public virtual DbContextTransaction BeginTransaction()
        {
            return _dataContext.Database.BeginTransaction();
        }

        public virtual T Add(T entity)
        {
            try
            {
                _dbset.Add(entity);
                return entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual void Update(T entity)
        {
            try
            {
                _dbset.Attach(entity);
                _dataContext.Entry(entity).State = EntityState.Modified;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual void Delete(T entity)
        {
            try
            {
                _dbset.Remove(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            try
            {
                IEnumerable<T> objects = _dbset.Where<T>(where).AsEnumerable();
                foreach (T obj in objects)
                    _dbset.Remove(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Database Query
        public virtual T GetById<TID>(TID id)
        {
            try
            {
                return _dbset.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual IEnumerable<T> GetAll()
        {
            try
            {
                return _dbset.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void AttachNavigation<N>(N navigation) where N : class, new()
        {
            if (navigation == null) return;

            try
            {
                IDbSet<N> navigationSet = DataContext.Set<N>();
                navigationSet.Attach(navigation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            try
            {
                return _dbset.Where(where).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual IEnumerable<T> GetByQuery(string query, params object[] parameters)
        {
            try
            {
                return _dataContext.Database.SqlQuery<T>(query, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
