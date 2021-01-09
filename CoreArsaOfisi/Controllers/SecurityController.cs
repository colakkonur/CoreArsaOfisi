using CoreArsaOfisi.Models.db;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreArsaOfisi.Controllers
{
    public class SecurityController : Controller
    {
        private readonly ILogger<SecurityController> _logger;
        private readonly u9673886_arsdbContext _db;

        public SecurityController(ILogger<SecurityController> logger, u9673886_arsdbContext db)
        {
            _logger = logger;
            _db = db;
        }

        [Route("giris")]
        [HttpGet]
        public IActionResult Login()
        {
            u9673886_arsdbContext db = new u9673886_arsdbContext();
            var vIlanlar = db.Advertisements.ToList();
            return View();
        }

        [Route("giris")]
        [HttpPost]
        public async Task<IActionResult> Login(Advertiser _advertiser)
        {
            var vHangiKullanici = _db.Advertisers.FirstOrDefault(w => w.Mail == _advertiser.Mail && w.Password == _advertiser.Password);
            if (vHangiKullanici != null)
            {
                var claims = new List<Claim>
                {
                    new Claim("kullanici_id",vHangiKullanici.Id.ToString()),
                    new Claim("kullanici_adi",vHangiKullanici.OfficalName),
                    new Claim("kullanici_mail",vHangiKullanici.Mail),
                    new Claim("kullanici_avatar",vHangiKullanici.Avatar),
                };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(claimsIdentity);
                var authProperties = new AuthenticationProperties
                {
                    //AllowRefresh = <bool>,
                    // Refreshing the authentication session should be allowed.

                    ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(20),
                    // The time at which the authentication ticket expires. A 
                    // value set here overrides the ExpireTimeSpan option of 
                    // CookieAuthenticationOptions set with AddCookie.

                    IsPersistent = true,
                    // Whether the authentication session is persisted across 
                    // multiple requests. When used with cookies, controls
                    // whether the cookie's lifetime is absolute (matching the
                    // lifetime of the authentication ticket) or session-based.

                    //IssuedUtc = <DateTimeOffset>,
                    // The time at which the authentication ticket was issued.

                    //RedirectUri = <string>
                    // The full path or absolute URI to be used as an http 
                    // redirect response value.
                };
                await HttpContext.SignInAsync(principal, authProperties);

                //var vGirisYapanKullanici = claimsIdentity.FindFirst("kullanici_mail").Value.ToString(); Claim Okuma İşlemi
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["rejection"] = "Kullanıcı Adı veya Parolanız Yanlış.";
                return View();//Giriş Başarısız ise Yönlendir.
            }
        }

        [Route("cikis")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(
            CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
    }
}
