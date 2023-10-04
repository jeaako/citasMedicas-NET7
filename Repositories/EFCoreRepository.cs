using citas_medicas.Entities;
using Microsoft.EntityFrameworkCore;

namespace citas_medicas.Repositories
{
    public abstract class EFCoreRepository<T, TContext> : IEFCoreRepository<T> 
        where T : class, IEntity
        where TContext: DbContext
    {
        private readonly CMContext Context;
        private readonly DbSet<T> dbSet;

        public EFCoreRepository(CMContext context)
        {
            this.Context = context;
            dbSet = Context.Set<T>();
        }

        public  List<T> GetAll() => dbSet.ToList();
        public  T GetById(long id) => dbSet.Find(id);

        public  T Add(T entity)
        {
            dbSet.Add(entity);
            Context.SaveChanges();
            return entity;
        }
        public  T Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
            return entity;
        }

        public  T Delete(long id)
        {
            var entity =  dbSet.Find(id);
            
            if (entity == null)
            {
                return entity;
            }

            dbSet.Remove(entity);
            Context.SaveChanges();

            return entity;
        }
    }
}

