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
    public class BuildingTypeRepository: IBuildingTypeRepository
    {
        protected readonly DbContext context;
        public BuildingTypeRepository(DbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(BuildingType entity)
        {
            await context.Set<BuildingType>().AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<BuildingType> entities)
        {
            await context.Set<BuildingType>().AddRangeAsync(entities);
        }

        public IEnumerable<BuildingType> Find(Expression<Func<BuildingType, bool>> predicate)
        {
            return context.Set<BuildingType>().Where(predicate);
        }

        public async Task<IEnumerable<BuildingType>> GetAllAsync()
        {
            return await context.Set<BuildingType>().ToListAsync();
        }

        public ValueTask<BuildingType> GetByIdAsync(int Id)
        {
            return context.Set<BuildingType>().FindAsync(Id);
        }

        public void Remove(BuildingType entity)
        {
            context.Set<BuildingType>().Remove(entity);
        }

        public async void Remove(int Id)
        {
            var model = await context.Set<BuildingType>().Where(x => x.Id == Id).FirstOrDefaultAsync();
            context.Remove(model);
        }

        public void RemoveRange(IEnumerable<BuildingType> entites)
        {
            context.Set<BuildingType>().RemoveRange(entites);
        }

        public Task<BuildingType> SingleOrDefaultAsync(Expression<Func<BuildingType, bool>> predicate)
        {
            return context.Set<BuildingType>().SingleOrDefaultAsync(predicate);
        }
    }
}
