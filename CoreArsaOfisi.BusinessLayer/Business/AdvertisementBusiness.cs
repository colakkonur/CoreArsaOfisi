using CoreArsaOfisi.BusinessLayer.Repository.Abstract;
using CoreArsaOfisi.BusinessLayer.Repository.Concrete;
using CoreArsaOfisi.DataLayer.Models.db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
            _advertisementUnitOfWork = new EFUnitOfWork(_dbContext);
            _advertisementRepository = _advertisementUnitOfWork.GetRepository<Advertisement>();
        }

        public async Task<IEnumerable<Advertisement>> Find(int Id)
        {
            return await _advertisementRepository.FindAsync(x => x.AdvertiserId == Id);
        }

        public async Task<IEnumerable<Advertisement>> GetAllAsync()
        {
            return await _advertisementRepository.GetAllAsync();
        }

        public async void AddAdvertisement(Advertisement advertisement)
        {
            await _advertisementRepository.AddAsync(advertisement);
        }

        public void RemoveAdvertisement(Advertisement advertisement)
        {
            _advertisementRepository.Remove(advertisement);
        }

        public void RemoveAdvertisement(int Id)
        {
            _advertisementRepository.Remove(Id);
        }

        public void RemoveAdvertisements(IEnumerable<Advertisement> advertisements)
        {
            _advertisementRepository.RemoveRange(advertisements);
        }

        public Task<Advertisement> AdvertisementSingleOrDefaultAsync(Expression<Func<Advertisement, bool>> predicate)
        {
            return _advertisementRepository.SingleOrDefaultAsync(predicate);
        }

    }
}
