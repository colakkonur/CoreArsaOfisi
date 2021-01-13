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
    public class PropertyRepository: IPropertyRepository
    {
        protected readonly DbContext context;
        public PropertyRepository(DbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(Property entity)
        {
            await context.Set<Property>().AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<Property> entities)
        {
            await context.Set<Property>().AddRangeAsync(entities);
        }

        public IEnumerable<Property> Find(Expression<Func<Property, bool>> predicate)
        {
            return context.Set<Property>().Where(predicate);
        }

        public async Task<IEnumerable<Property>> GetAllAsync()
        {
            return await context.Set<Property>().ToListAsync();
        }

        public ValueTask<Property> GetByIdAsync(int Id)
        {
            return context.Set<Property>().FindAsync(Id);
        }

        public void Remove(Property entity)
        {
            context.Set<Property>().Remove(entity);
        }

        public async void Remove(int Id)
        {
            var model = await context.Set<Property>().Where(x => x.Id == Id).FirstOrDefaultAsync();
            context.Remove(model);
        }

        public void RemoveRange(IEnumerable<Property> entites)
        {
            context.Set<Property>().RemoveRange(entites);
        }

        public Task<Property> SingleOrDefaultAsync(Expression<Func<Property, bool>> predicate)
        {
            return context.Set<Property>().SingleOrDefaultAsync(predicate);
        }

    }
}
