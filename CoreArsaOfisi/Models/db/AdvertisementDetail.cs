using System;
using System.Collections.Generic;

#nullable disable

namespace CoreArsaOfisi.Models.db
{
    public partial class AdvertisementDetail
    {
        public int Id { get; set; }
        public int? LSquareMeters { get; set; }
        public int? LAdaNo { get; set; }
        public int? LPaftaNo { get; set; }
        public int? LParselNo { get; set; }
        public int? LDeedStatudId { get; set; }
        public bool? LZoningStatus { get; set; }
        public int? HNetSquareMeters { get; set; }
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
        public int? HBuildingTypeId { get; set; }
        public int? HNumberOfRoomsId { get; set; }
        public int? ANumberOfRoomsId { get; set; }
        public int? ABuildingType { get; set; }
        public short? ANumberofFloors { get; set; }
        public int? AFlatsOnTheFloor { get; set; }
        public string AHealtingType { get; set; }
        public int? ASquareMeters { get; set; }
        public short? AApartmentAge { get; set; }
        public int? WBuildingTypeId { get; set; }
        public int? WNetSquareMeters { get; set; }
        public int? WGrossSquareMeters { get; set; }
        public int? WNumberOfRooms { get; set; }
        public int? WApartmentAge { get; set; }
        public short? WFloorLocation { get; set; }
        public string WHealtingType { get; set; }

        public virtual BuildingType ABuildingTypeNavigation { get; set; }
        public virtual NumberOfRoom ANumberOfRooms { get; set; }
        public virtual BuildingType HBuildingType { get; set; }
        public virtual NumberOfRoom HNumberOfRooms { get; set; }
        public virtual Advertisement IdNavigation { get; set; }
        public virtual DeedStatus LDeedStatud { get; set; }
        public virtual BuildingType WBuildingType { get; set; }
    }
}
