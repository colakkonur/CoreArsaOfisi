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
    public class DistrictRepository: IDistrictRepository
    {
        protected readonly DbContext context;
        public DistrictRepository(DbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(District entity)
        {
            await context.Set<District>().AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<District> entities)
        {
            await context.Set<District>().AddRangeAsync(entities);
        }

        public IEnumerable<District> Find(Expression<Func<District, bool>> predicate)
        {
            return context.Set<District>().Where(predicate);
        }

        public async Task<IEnumerable<District>> GetAllAsync()
        {
            return await context.Set<District>().ToListAsync();
        }

        public ValueTask<District> GetByIdAsync(int Id)
        {
            return context.Set<District>().FindAsync(Id);
        }

        public void Remove(District entity)
        {
            context.Set<District>().Remove(entity);
        }

        public async void Remove(int Id)
        {
            var model = await context.Set<District>().Where(x => x.Id == Id).FirstOrDefaultAsync();
            context.Remove(model);
        }

        public void RemoveRange(IEnumerable<District> entites)
        {
            context.Set<District>().RemoveRange(entites);
        }

        public Task<District> SingleOrDefaultAsync(Expression<Func<District, bool>> predicate)
        {
            return context.Set<District>().SingleOrDefaultAsync(predicate);
        }
    }
}
