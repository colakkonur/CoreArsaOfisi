using CoreArsaOfisi.BusinessLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreArsaOfisi.BusinessLayer.Repositories
{
    public interface IUnitOfWork:IDisposable
    {
        IAdvertisementDetailRepository AdvertisementDetailRepository { get; }
        IAdvertisementRepository AdvertisementRepository { get;}
        IAdvertisementTypePropertyRepository AdvertisementTypePropertyRepository { get; }
        IAdvertisementTypeRepository AdvertisementTypeRepository { get; }
        IAdvertiserRepository AdvertiserRepository { get; }
        IAuthorityRepository AuthorityRepository { get; }
        IBuildingTypeRepository BuildingTypeRepository { get; }
        IDeedStatusRepository DeedStatusRepository { get; }
        IDistrictRepository DistrictRepository { get; }
        INumberOfRoomRepository NumberOfRoomRepository { get; }
        IPhotoRepository PhotoRepository { get; }
        IPropertyRepository PropertyRepository { get; }
        IProvinceRepository ProvinceRepository { get; }

        Task<int> Complete();
    }
}
