using System;
using System.Collections.Generic;

#nullable disable

namespace CoreArsaOfisi.DataLayer.Models.db
{
    public partial class VIlanListesi
    {
        public int Id { get; set; }
        public bool? IsApproved { get; set; }
        public string Title { get; set; }
        public bool? IsForSale { get; set; }
        public decimal? Price { get; set; }
        public string DistrictName { get; set; }
        public string ProvinceName { get; set; }
        public string Adress { get; set; }
        public string AdvertisementTypeName { get; set; }
        public string CompanyName { get; set; }
        public DateTime? AdvertisementDate { get; set; }
        public bool? SwapStatus { get; set; }
        public bool? AvailableForLoan { get; set; }
        public string Avatar { get; set; }
        public short Expr1 { get; set; }
        public string PhotoUrl { get; set; }
    }
}
