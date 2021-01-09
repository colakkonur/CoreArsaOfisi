using CoreArsaOfisi.DataLayer.Models.db;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreArsaOfisi.BusinessLayer.Repository.Abstract
{
    public interface IAdvertiserRepository:Repository<Advertiser>
    {
        Task<Advertiser> GetAllWithAdvertisementAsync();
    }
}
