using CoreArsaOfisi.BusinessLayer.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreArsaOfisi.BusinessLayer.Repository.Concrete
{
    public class EFCoreRepository<TContext> : IRepository where TContext : DbContext
    {
        protected readonly TContext context;

        public EFCoreRepository(TContext context)
        {
            this.context = context;
        }

        public async Task AddAsync<T>(T entity) where T : class
        {
            await this.context.Set<T>().AddAsync(entity);
            await this.context.SaveChangesAsync();
        }

        public Task AddRangeAsync<T>(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> Find<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return await this.context.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>() where T : class
        {
            return await this.context.Set<T>().ToListAsync();
        }

        public Task<T> GetByIdAsync<T>(int Id) where T : class
        {
            throw new NotImplementedException();
        }

        public void Remove<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Remove<T>(int Id) where T : class
        {
            throw new NotImplementedException();
        }

        public void RemoveRange<T>(IEnumerable<T> entites) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<T> SingleOrDefaultAsync<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            throw new NotImplementedException();
        }

    }
}
