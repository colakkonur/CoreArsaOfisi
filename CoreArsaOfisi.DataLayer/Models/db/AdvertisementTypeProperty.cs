using System;
using System.Collections.Generic;

#nullable disable

namespace CoreArsaOfisi.DataLayer.Models.db
{
    public partial class AdvertisementTypeProperty
    {
        public int Id { get; set; }
        public int? AdvertisementTypeId { get; set; }
        public int? PropertiesId { get; set; }

        public virtual AdvertisementType AdvertisementType { get; set; }
        public virtual Property Properties { get; set; }
    }
}
