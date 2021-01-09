using System;
using System.Collections.Generic;

#nullable disable

namespace CoreArsaOfisi.DataLayer.Models.db
{
    public partial class Province
    {
        public Province()
        {
            Districts = new HashSet<District>();
        }

        public int Id { get; set; }
        public int? ProvinceCode { get; set; }
        public string ProvinceName { get; set; }

        public virtual ICollection<District> Districts { get; set; }
    }
}
