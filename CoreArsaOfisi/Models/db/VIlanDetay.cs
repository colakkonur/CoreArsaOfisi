using System;
using System.Collections.Generic;

#nullable disable

namespace CoreArsaOfisi.Models.db
{
    public partial class VIlanDetay
    {
        public string Title { get; set; }
        public string Explanation { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsForSale { get; set; }
        public bool? SwapStatus { get; set; }
        public bool? AvailableForLoan { get; set; }
        public decimal? Price { get; set; }
        public string Adress { get; set; }
        public DateTime? AdvertisementDate { get; set; }
        public string CompanyName { get; set; }
        public string OfficalName { get; set; }
        public string PhoneNumber { get; set; }
        public string LandPhone { get; set; }
        public string WhatsappNumber { get; set; }
        public string Mail { get; set; }
        public string Avatar { get; set; }
        public int Id { get; set; }
        public string RoomName { get; set; }
        public string DeedStatusName { get; set; }
        public string AdvertisementTypeName { get; set; }
        public int? Expr1 { get; set; }
        public int? Expr2 { get; set; }
        public int? Expr3 { get; set; }
        public int? Expr4 { get; set; }
        public bool? Expr6 { get; set; }
        public int? Expr7 { get; set; }
        public int? HGrossSquareMeters { get; set; }
        public short? HBuildingAge { get; set; }
        public short? HFloorLocation { get; set; }
        public short? HNumberofFloorsoftheBuilding { get; set; }
        public string HHealtingType { get; set; }
        public decimal? HDues { get; set; }
        public decimal? HRentalIncome { get; set; }
        public short? HNumberofBathrooms { get; set; }
        public short? HNumberofWc { get; set; }
        public bool? HInsidetheSite { get; set; }
        public short? ANumberofFloors { get; set; }
        public int? AFlatsOnTheFloor { get; set; }
        public string AHealtingType { get; set; }
        public int? ASquareMeters { get; set; }
        public short? AApartmentAge { get; set; }
        public int? WNetSquareMeters { get; set; }
        public int? WGrossSquareMeters { get; set; }
        public int? WApartmentAge { get; set; }
        public short? WFloorLocation { get; set; }
        public string WHealtingType { get; set; }
        public string TypeName { get; set; }
        public string DistrictName { get; set; }
        public string ProvinceName { get; set; }
    }
}
