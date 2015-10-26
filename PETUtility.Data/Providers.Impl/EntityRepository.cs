using PETUtility.Data.Context;
using PETUtility.Data.Fundamentals;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Data.Providers.Impl
{
    public abstract class EntityRepository<T> : IEntityRepository<T> where T : BaseEntity
    {
        protected IContext _Context;
        protected IDbSet<T> _Dbset;

        public EntityRepository(IContext context)
        {
            _Context = context;
            _Dbset = _Context.Set<T>();
        }

        public virtual void Create(T entity)
        {
            try
            {
                _Dbset.Add(entity);
                _Context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public virtual void Update(T entity)
        {
            try
            {
                var local = _Context.Set<T>()
                             .Local
                             .FirstOrDefault(f => f.Id == entity.Id);

                if (local != null)
                    _Context.Entry(local).State = System.Data.Entity.EntityState.Detached;

                _Context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                _Context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public virtual void Delete(T entity)
        {
            try
            {
                _Dbset.Attach(entity);
                _Dbset.Remove(entity);
                _Context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Dispose()
        {
            if (_Context != null)
                _Context = null;
        }
    }
}
