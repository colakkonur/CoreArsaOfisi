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
    public class VIlanListesiBusiness
    {
        private IRepository<VIlanListesi> _vIlanListesiRepository;
        private IUnitOfWork _vIlanListesiUnitOfWork;
        private DbContext _dbContext;

        public VIlanListesiBusiness()
        {
            _dbContext = new u9673886_arsdbContext();
            _vIlanListesiUnitOfWork = new EFUnitOfWork(_dbContext);
            _vIlanListesiRepository = _vIlanListesiUnitOfWork.GetRepository<VIlanListesi>();
        }

        public async Task<IEnumerable<VIlanListesi>> Find(int Id)
        {
            return await _vIlanListesiRepository.FindAsync(x => x.AdvertiserId == Id);
        }

        public async Task<IEnumerable<VIlanListesi>> GetAllAsync()
        {
            return await _vIlanListesiRepository.GetAllAsync();
        }
    }
}
