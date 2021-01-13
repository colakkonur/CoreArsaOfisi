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
    public class AdvertisementDetailRepository: IAdvertisementDetailRepository
    {
        protected readonly DbContext context;
        public AdvertisementDetailRepository(DbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(AdvertisementDetail entity)
        {
            await context.Set<AdvertisementDetail>().AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<AdvertisementDetail> entities)
        {
            await context.Set<AdvertisementDetail>().AddRangeAsync(entities);
        }

        public IEnumerable<AdvertisementDetail> Find(Expression<Func<AdvertisementDetail, bool>> predicate)
        {
            return context.Set<AdvertisementDetail>().Where(predicate);
        }

        public async Task<IEnumerable<AdvertisementDetail>> GetAllAsync()
        {
            return await context.Set<AdvertisementDetail>().ToListAsync();
        }

        public ValueTask<AdvertisementDetail> GetByIdAsync(int Id)
        {
            return context.Set<AdvertisementDetail>().FindAsync(Id);
        }

        public void Remove(AdvertisementDetail entity)
        {
            context.Set<AdvertisementDetail>().Remove(entity);
        }

        public async void Remove(int Id)
        {
            var model = await context.Set<AdvertisementDetail>().Where(x => x.Id == Id).FirstOrDefaultAsync();
            context.Remove(model);
        }

        public void RemoveRange(IEnumerable<AdvertisementDetail> entites)
        {
            context.Set<AdvertisementDetail>().RemoveRange(entites);
        }

        public Task<AdvertisementDetail> SingleOrDefaultAsync(Expression<Func<AdvertisementDetail, bool>> predicate)
        {
            return context.Set<AdvertisementDetail>().SingleOrDefaultAsync(predicate);
        }
    }
}
