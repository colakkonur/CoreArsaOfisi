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
    public class DeedStatusRepository: IDeedStatusRepository
    {
        protected readonly DbContext context;
        public DeedStatusRepository(DbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(DeedStatus entity)
        {
            await context.Set<DeedStatus>().AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<DeedStatus> entities)
        {
            await context.Set<DeedStatus>().AddRangeAsync(entities);
        }

        public IEnumerable<DeedStatus> Find(Expression<Func<DeedStatus, bool>> predicate)
        {
            return context.Set<DeedStatus>().Where(predicate);
        }

        public async Task<IEnumerable<DeedStatus>> GetAllAsync()
        {
            return await context.Set<DeedStatus>().ToListAsync();
        }

        public ValueTask<DeedStatus> GetByIdAsync(int Id)
        {
            return context.Set<DeedStatus>().FindAsync(Id);
        }

        public void Remove(DeedStatus entity)
        {
            context.Set<DeedStatus>().Remove(entity);
        }

        public async void Remove(int Id)
        {
            var model = await context.Set<DeedStatus>().Where(x => x.Id == Id).FirstOrDefaultAsync();
            context.Remove(model);
        }

        public void RemoveRange(IEnumerable<DeedStatus> entites)
        {
            context.Set<DeedStatus>().RemoveRange(entites);
        }

        public Task<DeedStatus> SingleOrDefaultAsync(Expression<Func<DeedStatus, bool>> predicate)
        {
            return context.Set<DeedStatus>().SingleOrDefaultAsync(predicate);
        }
    }
}
