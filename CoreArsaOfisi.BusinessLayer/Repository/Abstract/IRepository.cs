using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreArsaOfisi.BusinessLayer.Repository.Abstract
{
    public interface IRepository
    {
        Task<T> GetByIdAsync<T>(int Id) where T:class;
        Task<IEnumerable<T>> GetAllAsync<T>() where T : class;
        Task<IEnumerable<T>> Find<T>(Expression<Func<T, bool>> predicate) where T : class;
        Task<T> SingleOrDefaultAsync<T>(Expression<Func<T, bool>> predicate) where T : class;
        Task AddAsync<T>(T entity) where T : class;
        Task AddRangeAsync<T>(IEnumerable<T> entities);
        void Remove<T>(T entity) where T : class;
        void Remove<T>(int Id) where T : class;
        void RemoveRange<T>(IEnumerable<T> entites) where T : class;
    }
}
