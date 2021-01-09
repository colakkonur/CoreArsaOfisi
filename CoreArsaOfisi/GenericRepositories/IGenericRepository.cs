using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreArsaOfisi.GenericRepositories
{
    interface IGenericRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(string deger);
        IEnumerable<T> GetAll(string[] deger);
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);

    }
}
