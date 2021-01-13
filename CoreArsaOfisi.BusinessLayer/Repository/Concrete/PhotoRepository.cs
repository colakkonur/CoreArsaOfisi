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
    public class PhotoRepository: IPhotoRepository
    {
        protected readonly DbContext context;
        public PhotoRepository(DbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(Photo entity)
        {
            await context.Set<Photo>().AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<Photo> entities)
        {
            await context.Set<Photo>().AddRangeAsync(entities);
        }

        public IEnumerable<Photo> Find(Expression<Func<Photo, bool>> predicate)
        {
            return context.Set<Photo>().Where(predicate);
        }

        public async Task<IEnumerable<Photo>> GetAllAsync()
        {
            return await context.Set<Photo>().ToListAsync();
        }

        public ValueTask<Photo> GetByIdAsync(int Id)
        {
            return context.Set<Photo>().FindAsync(Id);
        }

        public void Remove(Photo entity)
        {
            context.Set<Photo>().Remove(entity);
        }

        public void Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Photo> entites)
        {
            context.Set<Photo>().RemoveRange(entites);
        }

        public Task<Photo> SingleOrDefaultAsync(Expression<Func<Photo, bool>> predicate)
        {
            return context.Set<Photo>().SingleOrDefaultAsync(predicate);
        }

    }
}
