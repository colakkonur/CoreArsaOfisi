using CoreArsaOfisi.DataLayer.Models.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreArsaOfisi.Models.ViewModels
{
    public class AdvertisementsListViewModel
    {
        public IEnumerable<Advertisement> Advertisements { get; set; }
        public IEnumerable<Photo> Photos { get; set; }

    }
}
