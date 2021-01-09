using CoreArsaOfisi.BusinessLayer.Repository.Abstract;
using CoreArsaOfisi.DataLayer.Models.db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreArsaOfisi.BusinessLayer.Repository.Concrete
{
    public class AdvertisementRepository : Repository<Advertisement>, IAdvertisementRepository
    {
        
        public AdvertisementRepository(u9673886_arsdbContext context):base(context)
        {

        }
        public Task<IEnumerable<Advertisement>> GetAllWithAdvertiserByAdvertiserIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        private u9673886_arsdbContext ArsaOfisiDbContext
        {
            get { return Context as u9673886_arsdbContext; }
        }
    }
}
