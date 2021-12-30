using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDbDal<T> where T:class
    {
        ICollection<T> GetListAll();

        void Insert(T obj);

        void Delete(T obj);
         
        void Update(T obj);

        T GetById(int id);
    }
}
