using System;
using System.Collections.Generic;

#nullable disable

namespace CoreArsaOfisi.DataLayer.Models.db
{
    public partial class Authority
    {
        public Authority()
        {
            Advertisers = new HashSet<Advertiser>();
        }

        public int Id { get; set; }
        public string AuthorityName { get; set; }

        public virtual ICollection<Advertiser> Advertisers { get; set; }
    }
}
