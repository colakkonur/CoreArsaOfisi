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
    public class AdvertiserRepository:IAdvertiserRepository
    {
        protected readonly DbContext context;
        public AdvertiserRepository(DbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(Advertiser entity)
        {
            await context.Set<Advertiser>().AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<Advertiser> entities)
        {
            await context.Set<Advertiser>().AddRangeAsync(entities);
        }

        public IEnumerable<Advertiser> Find(Expression<Func<Advertiser, bool>> predicate)
        {
            return context.Set<Advertiser>().Where(predicate);
        }

        public async Task<IEnumerable<Advertiser>> GetAllAsync()
        {
            return await context.Set<Advertiser>().ToListAsync();
        }

        public ValueTask<Advertiser> GetByIdAsync(int Id)
        {
            return context.Set<Advertiser>().FindAsync(Id);
        }

        public void Remove(Advertiser entity)
        {
            context.Set<Advertiser>().Remove(entity);
        }

        public async void Remove(int Id)
        {
            var model = await context.Set<Advertiser>().Where(x => x.Id == Id).FirstOrDefaultAsync();
            context.Remove(model);
        }

        public void RemoveRange(IEnumerable<Advertiser> entites)
        {
            context.Set<Advertiser>().RemoveRange(entites);
        }

        public Task<Advertiser> SingleOrDefaultAsync(Expression<Func<Advertiser, bool>> predicate)
        {
            return context.Set<Advertiser>().SingleOrDefaultAsync(predicate);
        }
    }
}
