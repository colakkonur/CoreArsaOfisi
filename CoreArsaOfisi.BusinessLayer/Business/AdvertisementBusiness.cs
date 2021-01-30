using CoreArsaOfisi.BusinessLayer.Repository.Abstract;
using CoreArsaOfisi.BusinessLayer.Repository.Concrete;
using CoreArsaOfisi.DataLayer.Models.db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreArsaOfisi.BusinessLayer.Business
{
    public class AdvertisementBusiness
    {
        private IRepository<Advertisement> _advertisementRepository;
        private IUnitOfWork _advertisementUnitOfWork;
        private DbContext _dbContext;

        public AdvertisementBusiness()
        {
            _dbContext = new u9673886_arsdbContext();
            _advertisementUnitOfWork= new EFUnitOfWork(_dbContext);
            _advertisementRepository = _advertisementUnitOfWork.GetRepository<Advertisement>();
        }


    }
}
