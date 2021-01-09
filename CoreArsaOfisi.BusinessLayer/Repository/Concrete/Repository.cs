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
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext Context;
        private readonly DbSet<T> _DBSet;
        public Repository(DbContext context)
        {
            this.Context = context;
            _DBSet = context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await Context.Set<T>().AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await Context.Set<T>().AddRangeAsync(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().Where(predicate);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Context.Set<T>().ToListAsync();
        }

        public ValueTask<T> GetByIdAsync(int Id)
        {
            return Context.Set<T>().FindAsync(Id);
        }

        public void Remove(T entity)
        {
            Context.Set<T>().Remove(entity);
        }

        public async void Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<T> entites)
        {
            Context.Set<T>().RemoveRange(entites);
        }

        public Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().SingleOrDefaultAsync(predicate);
        }
    }
}
