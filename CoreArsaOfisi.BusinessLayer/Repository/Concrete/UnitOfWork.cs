using CoreArsaOfisi.BusinessLayer.Repository.Abstract;
using CoreArsaOfisi.DataLayer.Models.db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreArsaOfisi.BusinessLayer.Repository.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly u9673886_arsdbContext _dbContext;
        private AdvertiserRepository _advertiserRepository;
        private AdvertisementRepository _advertisementRepository;
        
        public UnitOfWork(u9673886_arsdbContext context)
        {
            this._dbContext = context;
        }


        public IAdvertisementRepository AdvertisementRepository => _advertisementRepository = _advertisementRepository ?? new AdvertisementRepository(_dbContext);

        public IAdvertiserRepository AdvertiserRepository => _advertiserRepository = _advertiserRepository ?? new AdvertiserRepository(_dbContext);

        public async Task<int> CompleteAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
