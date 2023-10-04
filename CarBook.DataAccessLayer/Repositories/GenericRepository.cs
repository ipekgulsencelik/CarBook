using CarBook.DataAccessLayer.Abstract;
using CarBook.DataAccessLayer.Concrete;

namespace CarBook.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        CarBookContext context = new CarBookContext();

        public void Delete(int id)
        {
            var values = context.Set<T>().Find(id);
            context.Remove(values);
            context.SaveChanges();
        }

        public T GetByID(int id)
        {
            return context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            return context.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }
    }
}