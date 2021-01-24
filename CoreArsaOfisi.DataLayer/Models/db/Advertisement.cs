using System;
using System.Collections.Generic;

#nullable disable

namespace CoreArsaOfisi.DataLayer.Models.db
{
    public partial class Advertisement
    {
        public Advertisement()
        {
            AdvertisementDetails = new HashSet<AdvertisementDetail>();
            Photos = new HashSet<Photo>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Explanation { get; set; }
        public int? AdvertiserId { get; set; }
        public int? AdvertisementTypeId { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsForSale { get; set; }
        public bool? SwapStatus { get; set; }
        public bool? AvailableForLoan { get; set; }
        public decimal? Price { get; set; }
        public int? DistrictId { get; set; }
        public string Adress { get; set; }
        public DateTime? AdvertisementDate { get; set; }

        public virtual AdvertisementType AdvertisementType { get; set; }
        public virtual Advertiser Advertiser { get; set; }
        public virtual District District { get; set; }
        public virtual ICollection<AdvertisementDetail> AdvertisementDetails { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}
