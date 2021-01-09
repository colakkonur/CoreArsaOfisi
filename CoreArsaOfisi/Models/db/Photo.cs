using System;
using System.Collections.Generic;

#nullable disable

namespace CoreArsaOfisi.Models.db
{
    public partial class Photo
    {
        public int PhotoId { get; set; }
        public int? AdvertisementId { get; set; }
        public string PhotoUrl { get; set; }

        public virtual Advertisement Advertisement { get; set; }
    }
}
