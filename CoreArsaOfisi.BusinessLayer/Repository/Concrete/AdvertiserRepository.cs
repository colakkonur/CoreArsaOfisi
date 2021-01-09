using CoreArsaOfisi.BusinessLayer.Repository.Abstract;
using CoreArsaOfisi.DataLayer.Models.db;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreArsaOfisi.BusinessLayer.Repository.Concrete
{
    public class AdvertiserRepository : Repository<Advertiser>, IAdvertiserRepository
    {
        public AdvertiserRepository(u9673886_arsdbContext context) : base(context)
        {

        }

        public Task<Advertiser> GetAllWithAdvertisementAsync()
        {
            throw new NotImplementedException();
        }

        private u9673886_arsdbContext ArsaOfisiDbContext
        {
            get { return Context as u9673886_arsdbContext; }
        }
    }
}
