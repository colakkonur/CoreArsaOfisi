using CoreArsaOfisi.BusinessLayer.Repository.Abstract;
using CoreArsaOfisi.DataLayer.Models.db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreArsaOfisi.BusinessLayer.Repository.Concrete
{
    public class AuthorityRepository: IAuthorityRepository
    {
        protected readonly DbContext context;
        public AuthorityRepository(DbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(Authority entity)
        {
            await context.Set<Authority>().AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<Authority> entities)
        {
            await context.Set<Authority>().AddRangeAsync(entities);
        }

        public IEnumerable<Authority> Find(Expression<Func<Authority, bool>> predicate)
        {
            return context.Set<Authority>().Where(predicate);
        }

        public async Task<IEnumerable<Authority>> GetAllAsync()
        {
            return await context.Set<Authority>().ToListAsync();
        }

        public ValueTask<Authority> GetByIdAsync(int Id)
        {
            return context.Set<Authority>().FindAsync(Id);
        }

        public void Remove(Authority entity)
        {
            context.Set<Authority>().Remove(entity);
        }

        public async void Remove(int Id)
        {
            var model = await context.Set<Authority>().Where(x => x.Id == Id).FirstOrDefaultAsync();
            context.Remove(model);
        }

        public void RemoveRange(IEnumerable<Authority> entites)
        {
            context.Set<Authority>().RemoveRange(entites);
        }

        public Task<Authority> SingleOrDefaultAsync(Expression<Func<Authority, bool>> predicate)
        {
            return context.Set<Authority>().SingleOrDefaultAsync(predicate);
        }
    }
}
