using CoreArsaOfisi.BusinessLayer.Repositories.Abstract;
using CoreArsaOfisi.DataLayer.Models.db;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreArsaOfisi.BusinessLayer.Repositories.Concrete
{
    class AdvertiserRepository:Repository<Advertiser>, IAdvertiserRepository
    {
        public AdvertiserRepository(u9673886_arsdbContext _ArsdbContext):base(_ArsdbContext)
        {

        }


        public u9673886_arsdbContext _ArsdbContext { get { return _context as u9673886_arsdbContext; } }
    }
}
