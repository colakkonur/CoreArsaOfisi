using CoreArsaOfisi.DataLayer.Models.db;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreArsaOfisi.BusinessLayer.Repositories.Abstract
{
    public interface IAdvertisementRepository:IRepository<Advertisement>
    {
        Task<IEnumerable<Advertisement>> GetAdvertisements();
    }
}
