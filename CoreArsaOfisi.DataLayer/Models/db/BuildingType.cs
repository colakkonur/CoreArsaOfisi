using System;
using System.Collections.Generic;

#nullable disable

namespace CoreArsaOfisi.DataLayer.Models.db
{
    public partial class BuildingType
    {
        public BuildingType()
        {
            AdvertisementDetails = new HashSet<AdvertisementDetail>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<AdvertisementDetail> AdvertisementDetails { get; set; }
    }
}
