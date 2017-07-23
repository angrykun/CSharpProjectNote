using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XEngine.DAL;
using System.Data.Entity;
using System.Linq.Expressions;

namespace XEngine.Responistories
{
    public class GenericResponsitory<T> : IGenericResponsitory<T>
        where T : class
    {
        internal XEngineContext context;
        internal DbSet<T> dbSet;

        public GenericResponsitory(XEngineContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split(','))
            {
                query = query.Include(includeProperty);
            }
            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public T GetByID(Object id)
        {
            return dbSet.Find(id);
        }

        public void Insert(T entity)
        {
            dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            dbSet.Attach(entity);
            context.Entry<T>(entity).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            var entity = GetByID(id);
            Delete(entity);
        }

        public virtual void Delete(T entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
        }
    }
}