using CoreArsaOfisi.DataLayer.Models.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreArsaOfisi.Models.ViewModels
{
    public class AdvertiserDetailViewModel
    {
        public Advertiser Advertiser { get; set; }
        public IEnumerable<VIlanListesi> IlanListesi { get; set; }
    }
}
