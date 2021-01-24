using CoreArsaOfisi.DataLayer.Models.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreArsaOfisi.Models.ViewModels
{
    public class AdvertisementDetailViewModel
    {
        public VIlanDetay Advertisement_items { get; set; }
        public List<Photo> Photos { get; set; }
    }
}
