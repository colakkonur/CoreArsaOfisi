using CoreArsaOfisi.BusinessLayer.Repository.Abstract;
using CoreArsaOfisi.BusinessLayer.Repository.Concrete;
using CoreArsaOfisi.DataLayer.Models.db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreArsaOfisi.BusinessLayer.Business
{
    public class AdvertiserBusiness
    {
        private IRepository<Advertiser> _advertiserRepository;
        private IUnitOfWork _advertiserUnitOfWork;
        private DbContext _dbContext;

        public AdvertiserBusiness()
        {
            _dbContext = new u9673886_arsdbContext();
            _advertiserUnitOfWork = new EFUnitOfWork(_dbContext);
            _advertiserRepository = _advertiserUnitOfWork.GetRepository<Advertiser>();
        }


        public async ValueTask<Advertiser> GetAdvertiserAsync(int Id)
        {
            return await _advertiserRepository.GetByIdAsync(Id);
        }


    }
}
