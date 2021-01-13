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
    public class AdvertisementRepository : IAdvertisementRepository
    {
        protected readonly DbContext context;
        public AdvertisementRepository(DbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(Advertisement entity)
        {
            await context.Set<Advertisement>().AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<Advertisement> entities)
        {
            await context.Set<Advertisement>().AddRangeAsync(entities);
        }

        public IEnumerable<Advertisement> Find(Expression<Func<Advertisement, bool>> predicate)
        {
            return context.Set<Advertisement>().Where(predicate);
        }

        public async Task<IEnumerable<Advertisement>> GetAllAsync()
        {
            return await context.Set<Advertisement>().ToListAsync();
        }

        public ValueTask<Advertisement> GetByIdAsync(int Id)
        {
            return context.Set<Advertisement>().FindAsync(Id);
        }

        public void Remove(Advertisement entity)
        {
            context.Set<Advertisement>().Remove(entity);
        }

        public async void Remove(int Id)
        {
            var model = await context.Set<Advertisement>().Where(x => x.Id == Id).FirstOrDefaultAsync();
            context.Remove(model);
        }

        public void RemoveRange(IEnumerable<Advertisement> entites)
        {
            context.Set<Advertisement>().RemoveRange(entites);
        }

        public Task<Advertisement> SingleOrDefaultAsync(Expression<Func<Advertisement, bool>> predicate)
        {
            return context.Set<Advertisement>().SingleOrDefaultAsync(predicate);
        }
    }
}
