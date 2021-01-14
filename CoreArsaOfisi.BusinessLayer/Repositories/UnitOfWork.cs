using CoreArsaOfisi.BusinessLayer.Repositories.Abstract;
using CoreArsaOfisi.BusinessLayer.Repositories.Concrete;
using CoreArsaOfisi.DataLayer.Models.db;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreArsaOfisi.BusinessLayer.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        private u9673886_arsdbContext context;
        public UnitOfWork(u9673886_arsdbContext context)
        {
            this.context = context;
            AdvertisementRepository = new AdvertisementRepository(context);
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

        public async Task<int> Complete()
        {
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.DisposeAsync();
        }
    }
}
