using CoreArsaOfisi.BusinessLayer.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreArsaOfisi.BusinessLayer.Repositories.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbContext _context;
        private DbSet<T> _dbset;
        public Repository(DbContext context)
        {
            _context= context;
            _dbset = context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _dbset.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbset.AddRangeAsync(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbset.Where(predicate);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbset.ToListAsync();
        }

        public async ValueTask<T> GetByIdAsync(int Id)
        {
            return await _dbset.FindAsync(Id);
        }

        public void Remove(T entity)
        {
            _dbset.Remove(entity);
        }

        public void Remove(int Id)
        {
            var model=_dbset.Find(Id);
            _dbset.Remove(model);
        }

        public void RemoveRange(IEnumerable<T> entites)
        {
            _dbset.RemoveRange(entites);
        }

        public Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return _dbset.SingleOrDefaultAsync(predicate);
        }
    }
}
