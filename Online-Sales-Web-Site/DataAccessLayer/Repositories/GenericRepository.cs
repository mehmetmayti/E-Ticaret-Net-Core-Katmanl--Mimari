using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDbDal<T> where T : class
    {
        Context context = new Context();


        public void Delete(T obj)
        {
            context.Remove(obj);
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);       
        }

        public ICollection<T> GetListAll()
        {
            return context.Set<T>().ToList();
        }

        public void Insert(T obj)
        {
            context.Add(obj);
            context.SaveChanges();
        }

        public void Update(T obj)
        {
            context.Update(obj);
            context.SaveChanges();
        }
    }
}
