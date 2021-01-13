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
    public class ProvinceRepository: IProvinceRepository
    {
        protected readonly DbContext context;
        public ProvinceRepository(DbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(Province entity)
        {
            await context.Set<Province>().AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<Province> entities)
        {
            await context.Set<Province>().AddRangeAsync(entities);
        }

        public IEnumerable<Province> Find(Expression<Func<Province, bool>> predicate)
        {
            return context.Set<Province>().Where(predicate);
        }

        public async Task<IEnumerable<Province>> GetAllAsync()
        {
            return await context.Set<Province>().ToListAsync();
        }

        public ValueTask<Province> GetByIdAsync(int Id)
        {
            return context.Set<Province>().FindAsync(Id);
        }

        public void Remove(Province entity)
        {
            context.Set<Province>().Remove(entity);
        }

        public async void Remove(int Id)
        {
            var model = await context.Set<Province>().Where(x => x.Id == Id).FirstOrDefaultAsync();
            context.Remove(model);
        }

        public void RemoveRange(IEnumerable<Province> entites)
        {
            context.Set<Province>().RemoveRange(entites);
        }

        public Task<Province> SingleOrDefaultAsync(Expression<Func<Province, bool>> predicate)
        {
            return context.Set<Province>().SingleOrDefaultAsync(predicate);
        }

    }
}
