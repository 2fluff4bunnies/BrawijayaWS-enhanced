using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Data.Objects;
using System.Data.Entity.Infrastructure;
using System.Text;

namespace BrawijayaWorkshop.Infrastructure.Repository
{
    public abstract class BaseRepository<T, U>
        where T : class, new()
        where U : DbContext
    {
        private U _dataContext;
        private IDbSet<T> _dbset;

        protected BaseRepository(IDatabaseFactory<U> databaseFactory)
        {
            DatabaseFactory = databaseFactory;
            _dbset = DataContext.Set<T>();
            //PropertyInfo[] properties = typeof(T).GetProperties()
            //    .Where(p => (p.CanRead ? p.GetMethod : p.SetMethod).IsVirtual).ToArray();
            //foreach (var item in properties)
            //{
            //    _dbset.Include(item.Name);
            //    IncludeRecursive(item.PropertyType, item.Name);
            //}
        }

        //private void IncludeRecursive(Type childrenType, string prevParentName)
        //{
        //    PropertyInfo[] properties = childrenType.GetProperties()
        //        .Where(p => (p.CanRead ? p.GetMethod : p.SetMethod).IsVirtual).ToArray();
        //    foreach (var item in properties)
        //    {
        //        if (prevParentName.Contains(item.Name)) continue;
        //        string includePath = prevParentName + "." + item.Name;
        //        _dbset.Include(includePath);
        //        IncludeRecursive(item.PropertyType, includePath);
        //    }
        //}

        public IDatabaseFactory<U> DatabaseFactory { get; private set; }

        protected U DataContext
        {
            get { return _dataContext ?? (_dataContext = DatabaseFactory.Get()); }
        }

        #region Database Transactions
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
        #endregion

        #region Database Query
        public virtual T GetById<TID>(TID id)
        {
            try
            {
                T result = _dbset.Find(id);
                if (result != null)
                {
                    var context = ((IObjectContextAdapter)DataContext).ObjectContext;
                    context.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, result);

                    return result;
                }
                return null;
            }
            catch (Exception ex)
            {
                //The underlying provider failed on Open
                if (GenerateFullError(ex).Contains("There is already an open DataReader associated with this Connection which must be closed first") ||
                    GenerateFullError(ex).Contains("Unexpected connection state. When using a wrapping provider ensure that the StateChange event is implemented on the wrapped DbConnection") ||
                    GenerateFullError(ex).Contains("Cannot access a disposed object") ||
                    GenerateFullError(ex).Contains("Connection must be valid and open") ||
                    GenerateFullError(ex).Contains("The underlying provider failed on Open"))
                {
                    _dataContext = null;
                    DatabaseFactory.ReCreateContext();
                    _dbset = DataContext.Set<T>();
                    return GetById(id);
                }
                else
                {
                    throw ex;
                }
            }
        }
        public virtual IEnumerable<T> GetAll()
        {
            try
            {
                IEnumerable<T> result = _dbset.ToList();
                var context = ((IObjectContextAdapter)DataContext).ObjectContext;
                context.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, result);

                return result.ToList();
            }
            catch (Exception ex)
            {
                if (GenerateFullError(ex).Contains("There is already an open DataReader associated with this Connection which must be closed first") ||
                    GenerateFullError(ex).Contains("Unexpected connection state. When using a wrapping provider ensure that the StateChange event is implemented on the wrapped DbConnection") ||
                    GenerateFullError(ex).Contains("Cannot access a disposed object") ||
                    GenerateFullError(ex).Contains("Connection must be valid and open") ||
                    GenerateFullError(ex).Contains("The underlying provider failed on Open"))
                {
                    _dataContext = null;
                    DatabaseFactory.ReCreateContext();
                    _dbset = DataContext.Set<T>();
                    return GetAll();
                }
                else
                {
                    throw ex;
                }
            }
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            try
            {
                IEnumerable<T> result = _dbset.Where(where).ToList();
                var context = ((IObjectContextAdapter)DataContext).ObjectContext;
                context.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, result);

                return result.ToList();
            }
            catch (Exception ex)
            {
                if (GenerateFullError(ex).Contains("There is already an open DataReader associated with this Connection which must be closed first") ||
                    GenerateFullError(ex).Contains("Unexpected connection state. When using a wrapping provider ensure that the StateChange event is implemented on the wrapped DbConnection") ||
                    GenerateFullError(ex).Contains("Cannot access a disposed object") ||
                    GenerateFullError(ex).Contains("Connection must be valid and open") ||
                    GenerateFullError(ex).Contains("The underlying provider failed on Open"))
                {
                    _dataContext = null;
                    DatabaseFactory.ReCreateContext();
                    _dbset = DataContext.Set<T>();
                    return GetMany(where);
                }
                else
                {
                    throw ex;
                }
            }
        }

        public virtual IEnumerable<T> GetByQuery(string query, params object[] parameters)
        {
            try
            {
                return DataContext.Database.SqlQuery<T>(query, parameters);
            }
            catch (Exception ex)
            {
                if (GenerateFullError(ex).Contains("There is already an open DataReader associated with this Connection which must be closed first") ||
                    GenerateFullError(ex).Contains("Unexpected connection state. When using a wrapping provider ensure that the StateChange event is implemented on the wrapped DbConnection") ||
                    GenerateFullError(ex).Contains("Cannot access a disposed object") ||
                    GenerateFullError(ex).Contains("Connection must be valid and open") ||
                    GenerateFullError(ex).Contains("The underlying provider failed on Open"))
                {
                    _dataContext = null;
                    DatabaseFactory.ReCreateContext();
                    _dbset = DataContext.Set<T>();
                    return GetByQuery(query, parameters);
                }
                else
                {
                    throw ex;
                }
            }
        }

        public void RefreshObject<TObject>(TObject entity) where TObject : class, new()
        {
            var context = ((IObjectContextAdapter)_dataContext).ObjectContext;
            context.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, entity);
        }

        private string GenerateFullError(Exception exception)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(exception.Message);
            if (exception.InnerException != null)
            {
                sb.AppendLine(GenerateFullError(exception.InnerException));
            }

            return sb.ToString();
        }

        //private void RefreshProperty(System.Data.Entity.Core.Objects.ObjectContext context, T entity)
        //{
        //    PropertyInfo[] properties = typeof(T).GetProperties()
        //                .Where(p => (p.CanRead ? p.GetMethod : p.SetMethod).IsVirtual).ToArray();
        //    foreach (var p in properties)
        //    {
        //        object pValue = p.GetValue(entity);
        //        if (pValue == null) continue;

        //        context.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, pValue);
        //    }
        //}
        #endregion
    }
}
