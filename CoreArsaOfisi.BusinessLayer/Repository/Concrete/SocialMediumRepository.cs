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
    public class SocialMediumRepository: ISocialMediumRepository
    {
        protected readonly DbContext context;
        public SocialMediumRepository(DbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(SocialMedium entity)
        {
            await context.Set<SocialMedium>().AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<SocialMedium> entities)
        {
            await context.Set<SocialMedium>().AddRangeAsync(entities);
        }

        public IEnumerable<SocialMedium> Find(Expression<Func<SocialMedium, bool>> predicate)
        {
            return context.Set<SocialMedium>().Where(predicate);
        }

        public async Task<IEnumerable<SocialMedium>> GetAllAsync()
        {
            return await context.Set<SocialMedium>().ToListAsync();
        }

        public ValueTask<SocialMedium> GetByIdAsync(int Id)
        {
            return context.Set<SocialMedium>().FindAsync(Id);
        }

        public void Remove(SocialMedium entity)
        {
            context.Set<SocialMedium>().Remove(entity);
        }

        public async void Remove(int Id)
        {
            var model = await context.Set<SocialMedium>().Where(x => x.Id == Id).FirstOrDefaultAsync();
            context.Remove(model);
        }

        public void RemoveRange(IEnumerable<SocialMedium> entites)
        {
            context.Set<SocialMedium>().RemoveRange(entites);
        }

        public Task<SocialMedium> SingleOrDefaultAsync(Expression<Func<SocialMedium, bool>> predicate)
        {
            return context.Set<SocialMedium>().SingleOrDefaultAsync(predicate);
        }
    }
}
