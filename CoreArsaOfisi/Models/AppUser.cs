using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreArsaOfisi.Models
{
    public class AppUser : ClaimsPrincipal
    {
        public AppUser(ClaimsPrincipal principal)
           : base(principal)
        {
        }

        public string KullaniciId
        {
            get
            {
                return this.FindFirst("kullanici_id").Value;
            }
        }
        public string KullaniciMail
        {
            get
            {
                return this.FindFirst("kullanici_mail").Value;
            }
        }
        public string KullaniciAvatar
        {
            get
            {
                return this.FindFirst("kullanici_avatar").Value;
            }
        }
    }
    public abstract class AppController : Controller
    {
        public AppUser CurrentUser
        {
            get
            {
                return new AppUser(this.User as ClaimsPrincipal);
            }
        }
    }
}
