using CoreArsaOfisi.BusinessLayer.Repositories.Abstract;
using CoreArsaOfisi.DataLayer.Models.db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreArsaOfisi.BusinessLayer.Repositories.Concrete
{
    class AdvertisementRepository : Repository<Advertisement>, IAdvertisementRepository
    {
        public AdvertisementRepository(u9673886_arsdbContext context) : base(context)
        {

        }

        public async Task<List<Advertisement>> GetAdvertisements()
        {
            return await _ArsdbContext.Advertisements
               .Include(x => x.AdvertisementType)
               .Include(x => x.District)
               .ToListAsync();
        }

        public u9673886_arsdbContext _ArsdbContext { get { return _context as u9673886_arsdbContext; } }
    }
}
