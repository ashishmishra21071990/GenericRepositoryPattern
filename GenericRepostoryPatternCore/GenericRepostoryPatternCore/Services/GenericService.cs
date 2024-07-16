using GenericRepostoryPatternCore.Contract;
using Microsoft.EntityFrameworkCore;

namespace GenericRepostoryPatternCore.Services
{
    public class GenericService<T> : IGeneric<T> where T : class
    {
        private GenericDbContext _dbContext;
        private DbSet<T> _entities;
        public GenericService(GenericDbContext dbContext)
        {
            _dbContext = dbContext;
            _entities = _dbContext.Set<T>();
        }
        public List<T> GetAll()
        {
            return _entities.ToList();
        }

        public bool Add(T obj)
        {
            _entities.Add(obj);
            int n=_dbContext.SaveChanges();
            if (n != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public T GetByID(int id)
        {
           T t= _entities.Find(id);
           return t;
        }
        public bool Update(T obj)
        {
            _entities.Update(obj);
            int n=_dbContext.SaveChanges();
            if (n != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public T Delete(int id)
        {
            T t = _entities.Find(id);
            _entities.Remove(t);
            _dbContext.SaveChanges();
            return t;
        }
    }
}
