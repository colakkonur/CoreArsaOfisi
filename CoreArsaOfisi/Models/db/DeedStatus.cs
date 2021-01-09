using System;
using System.Collections.Generic;

#nullable disable

namespace CoreArsaOfisi.Models.db
{
    public partial class DeedStatus
    {
        public DeedStatus()
        {
            AdvertisementDetails = new HashSet<AdvertisementDetail>();
        }

        public int Id { get; set; }
        public string DeedStatusName { get; set; }

        public virtual ICollection<AdvertisementDetail> AdvertisementDetails { get; set; }
    }
}
