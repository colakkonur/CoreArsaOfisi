using CoreArsaOfisi.BusinessLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreArsaOfisi.BusinessLayer.Repositories
{
    public interface IUnitOfWork:IDisposable
    {
        IAdvertisementRepository AdvertisementRepository { get;}

        Task<int> Complete();
    }
}
