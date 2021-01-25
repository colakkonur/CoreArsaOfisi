using CoreArsaOfisi.DataLayer.Models.db;
using CoreArsaOfisi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreArsaOfisi.Controllers
{
    public class UserController : AppController
    {
        private readonly u9673886_arsdbContext _db;
        private readonly IWebHostEnvironment _hostingEnvironment;

        

        public UserController(u9673886_arsdbContext db, IWebHostEnvironment hostingEnvironment)
        {
            _db = db;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        [Route("ilanlarim")]
        [HttpGet]
        public async Task<IActionResult> MyAds()
        {
            var model = await _db.VIlanListesis.Where(w => w.AdvertiserId == Convert.ToInt32(CurrentUser.KullaniciId)).ToListAsync();
            return View(model);
        }


        [Route("profilim")]
        [HttpGet]
        public async Task<IActionResult> MyProfile()
        {
            var model = await _db.Advertisers.Include("SocialMedium").Where(w => w.Id == Convert.ToInt32(CurrentUser.KullaniciId)).FirstOrDefaultAsync();
            return View(model);
        }

        [Route("profilim")]
        [HttpPost]
        public async Task<IActionResult> MyProfile(Advertiser _advertiser, bool? ProfilTetikleyici, bool? SosyalMedyaTetikleyici, bool? ParolaTetikleyici, List<IFormFile> avatar)
        {
            var vHangiKullanici = await _db.Advertisers.Include("SocialMedium").Where(w => w.Id == Convert.ToInt32(CurrentUser.KullaniciId)).FirstOrDefaultAsync();
            if (ProfilTetikleyici != null && ProfilTetikleyici != false)
            {
                if (avatar != null)
                {
                    var vSilinecekDosya = Path.Combine(_hostingEnvironment.WebRootPath, "userimage", vHangiKullanici.Avatar.ToString());
                    var vDosyaBilgisi = new System.IO.FileInfo(vSilinecekDosya.ToString());

                    if (vDosyaBilgisi.Exists)
                    {
                        vDosyaBilgisi.Delete();
                    }

                    foreach (var item in avatar)
                    {
                        var InputFileName = Path.GetFileName(item.FileName);
                        string sBenzersizIsim = Guid.NewGuid().ToString("N") + Path.GetExtension(item.FileName);
                        string stream = Path.Combine(_hostingEnvironment.WebRootPath, "userimage", sBenzersizIsim);
                        FileStream ky = new FileStream(stream, FileMode.Create);
                        await item.CopyToAsync(ky);
                        ky.Close();
                        vHangiKullanici.Avatar = sBenzersizIsim;
                    }
                }
                vHangiKullanici.CompanyName = _advertiser.CompanyName;
                vHangiKullanici.OfficalName = _advertiser.OfficalName;
                vHangiKullanici.PhoneNumber = _advertiser.PhoneNumber;
                vHangiKullanici.LandPhone = _advertiser.LandPhone;
                vHangiKullanici.WhatsappNumber = _advertiser.WhatsappNumber;
                vHangiKullanici.Mail = _advertiser.Mail;
                await _db.SaveChangesAsync();
            }
            else if (SosyalMedyaTetikleyici != null && SosyalMedyaTetikleyici != false)
            {
                vHangiKullanici.SocialMedium.Skype = _advertiser.SocialMedium.Skype;
                vHangiKullanici.SocialMedium.WebSite = _advertiser.SocialMedium.WebSite;
                vHangiKullanici.SocialMedium.Facebook = _advertiser.SocialMedium.Facebook;
                vHangiKullanici.SocialMedium.Twitter = _advertiser.SocialMedium.Twitter;
                vHangiKullanici.SocialMedium.Linkedin = _advertiser.SocialMedium.Linkedin;
                vHangiKullanici.SocialMedium.Instagram = _advertiser.SocialMedium.Instagram;
                vHangiKullanici.SocialMedium.GooglePlus = _advertiser.SocialMedium.GooglePlus;
                vHangiKullanici.SocialMedium.Youtube = _advertiser.SocialMedium.Youtube;
                vHangiKullanici.SocialMedium.Pinterest = _advertiser.SocialMedium.Pinterest;
                vHangiKullanici.SocialMedium.Vimeo = _advertiser.SocialMedium.Vimeo;
                await _db.SaveChangesAsync();
            }
            else if (ParolaTetikleyici != null && ParolaTetikleyici != false)
            {
                vHangiKullanici.Password = _advertiser.Password;
                await _db.SaveChangesAsync();
            }
            return RedirectToAction("MyProfile");
        }
    }
}
