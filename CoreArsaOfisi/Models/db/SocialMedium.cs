using System;
using System.Collections.Generic;

#nullable disable

namespace CoreArsaOfisi.Models.db
{
    public partial class SocialMedium
    {
        public int Id { get; set; }
        public string Skype { get; set; }
        public string WebSite { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Linkedin { get; set; }
        public string Instagram { get; set; }
        public string GooglePlus { get; set; }
        public string Youtube { get; set; }
        public string Pinterest { get; set; }
        public string Vimeo { get; set; }

        public virtual Advertiser IdNavigation { get; set; }
    }
}
