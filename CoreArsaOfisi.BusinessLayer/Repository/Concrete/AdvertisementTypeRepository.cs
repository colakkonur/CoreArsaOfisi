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
    public class AdvertisementTypeRepository:IAdvertisementTypeRepository
    {
        protected readonly DbContext context;
        public AdvertisementTypeRepository(DbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(AdvertisementType entity)
        {
            await context.Set<AdvertisementType>().AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<AdvertisementType> entities)
        {
            await context.Set<AdvertisementType>().AddRangeAsync(entities);
        }

        public IEnumerable<AdvertisementType> Find(Expression<Func<AdvertisementType, bool>> predicate)
        {
            return context.Set<AdvertisementType>().Where(predicate);
        }

        public async Task<IEnumerable<AdvertisementType>> GetAllAsync()
        {
            return await context.Set<AdvertisementType>().ToListAsync();
        }

        public ValueTask<AdvertisementType> GetByIdAsync(int Id)
        {
            return context.Set<AdvertisementType>().FindAsync(Id);
        }

        public void Remove(AdvertisementType entity)
        {
            context.Set<AdvertisementType>().Remove(entity);
        }

        public async void Remove(int Id)
        {
            var model = await context.Set<AdvertisementType>().Where(x => x.Id == Id).FirstOrDefaultAsync();
            context.Remove(model);
        }

        public void RemoveRange(IEnumerable<AdvertisementType> entites)
        {
            context.Set<AdvertisementType>().RemoveRange(entites);
        }

        public Task<AdvertisementType> SingleOrDefaultAsync(Expression<Func<AdvertisementType, bool>> predicate)
        {
            return context.Set<AdvertisementType>().SingleOrDefaultAsync(predicate);
        }

    }
}
