using System;
using System.Collections.Generic;

#nullable disable

namespace CoreArsaOfisi.Models.db
{
    public partial class District
    {
        public District()
        {
            Advertisements = new HashSet<Advertisement>();
        }

        public int Id { get; set; }
        public string DistrictName { get; set; }
        public int? ProvinceId { get; set; }

        public virtual Province Province { get; set; }
        public virtual ICollection<Advertisement> Advertisements { get; set; }
    }
}
