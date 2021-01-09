using System;
using System.Collections.Generic;

#nullable disable

namespace CoreArsaOfisi.Models.db
{
    public partial class BuildingType
    {
        public BuildingType()
        {
            AdvertisementDetailABuildingTypeNavigations = new HashSet<AdvertisementDetail>();
            AdvertisementDetailHBuildingTypes = new HashSet<AdvertisementDetail>();
            AdvertisementDetailWBuildingTypes = new HashSet<AdvertisementDetail>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<AdvertisementDetail> AdvertisementDetailABuildingTypeNavigations { get; set; }
        public virtual ICollection<AdvertisementDetail> AdvertisementDetailHBuildingTypes { get; set; }
        public virtual ICollection<AdvertisementDetail> AdvertisementDetailWBuildingTypes { get; set; }
    }
}
