using System;
using System.Collections.Generic;

#nullable disable

namespace CoreArsaOfisi.Models.db
{
    public partial class Advertiser
    {
        public Advertiser()
        {
            Advertisements = new HashSet<Advertisement>();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public DateTime? DateOfRegistration { get; set; }
        public string OfficalName { get; set; }
        public string PhoneNumber { get; set; }
        public string LandPhone { get; set; }
        public string WhatsappNumber { get; set; }
        public int? AuthorityId { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }

        public virtual Authority Authority { get; set; }
        public virtual SocialMedium SocialMedium { get; set; }
        public virtual ICollection<Advertisement> Advertisements { get; set; }
    }
}
