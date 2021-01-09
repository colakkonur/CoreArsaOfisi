using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreArsaOfisi.BusinessLayer.Repository.Abstract
{
    public interface IUnitOfWork:IDisposable
    {
        
        Task<int> CompleteAsync();
    }
}
