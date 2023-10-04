using citas_medicas.Entities;

namespace citas_medicas.Repositories
{
    public interface IEFCoreRepository<T> where T : class, IEntity
    {
        public List<T> GetAll();
        public T GetById(long id);
        public T Add(T entity);
        public T Update(T entity);
        public T Delete(long id);
    }
}
