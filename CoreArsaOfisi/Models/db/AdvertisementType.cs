using System;
using System.Collections.Generic;

#nullable disable

namespace CoreArsaOfisi.Models.db
{
    public partial class AdvertisementType
    {
        public AdvertisementType()
        {
            AdvertisementTypeProperties = new HashSet<AdvertisementTypeProperty>();
            Advertisements = new HashSet<Advertisement>();
        }

        public int Id { get; set; }
        public string AdvertisementTypeName { get; set; }

        public virtual ICollection<AdvertisementTypeProperty> AdvertisementTypeProperties { get; set; }
        public virtual ICollection<Advertisement> Advertisements { get; set; }
    }
}
