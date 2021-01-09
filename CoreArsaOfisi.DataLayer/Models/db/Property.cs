using System;
using System.Collections.Generic;

#nullable disable

namespace CoreArsaOfisi.DataLayer.Models.db
{
    public partial class Property
    {
        public Property()
        {
            AdvertisementTypeProperties = new HashSet<AdvertisementTypeProperty>();
        }

        public int Id { get; set; }
        public string PropertiesName { get; set; }
        public bool? PropertyValue { get; set; }

        public virtual ICollection<AdvertisementTypeProperty> AdvertisementTypeProperties { get; set; }
    }
}
