using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreArsaOfisi.BusinessLayer.Repository.Abstract
{

    //Base Interfacemiz bu generic olarak istediğimiz methodu tanımlayabiliriz.
    public interface Repository<T> where T:class
    {
        ValueTask<T> GetByIdAsync(int Id);
        Task<IEnumerable<T>> GetAllAsync();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Remove(T entity);
        void Remove(int Id);
        void RemoveRange(IEnumerable<T> entites);
    }
}
