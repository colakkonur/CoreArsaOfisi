using CoreArsaOfisi.BusinessLayer.Repositories.Abstract;
using CoreArsaOfisi.BusinessLayer.Repositories.Concrete;
using CoreArsaOfisi.DataLayer.Models.db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreArsaOfisi.BusinessLayer.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        private DbContext context;
        private bool disposed = false;

        public UnitOfWork(u9673886_arsdbContext context)
        {
            this.context = context;
            AdvertisementRepository = new AdvertisementRepository(context);
        }

        public async Task<int> Complete()
        {
            try
            {
                return await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.InnerException.Message);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
                if (disposing)
                    context.Dispose();
            disposed = true;
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        public IAdvertisementRepository AdvertisementRepository { get; private set; }

        public IAdvertisementDetailRepository AdvertisementDetailRepository { get; private set; }

        public IAdvertisementTypePropertyRepository AdvertisementTypePropertyRepository { get; private set; }

        public IAdvertisementTypeRepository AdvertisementTypeRepository { get; private set; }

        public IAdvertiserRepository AdvertiserRepository { get; private set; }

        public IAuthorityRepository AuthorityRepository { get; private set; }

        public IBuildingTypeRepository BuildingTypeRepository { get; private set; }

        public IDeedStatusRepository DeedStatusRepository { get; private set; }

        public IDistrictRepository DistrictRepository { get; private set; }

        public INumberOfRoomRepository NumberOfRoomRepository { get; private set; }

        public IPhotoRepository PhotoRepository { get; private set; }

        public IPropertyRepository PropertyRepository { get; private set; }

        public IProvinceRepository ProvinceRepository { get; private set; }
    }
}
