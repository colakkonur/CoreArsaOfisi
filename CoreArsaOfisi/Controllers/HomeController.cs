using CoreArsaOfisi.BusinessLayer.Repositories;
using CoreArsaOfisi.DataLayer.Models.db;
using CoreArsaOfisi.Models;
using CoreArsaOfisi.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreArsaOfisi.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly u9673886_arsdbContext db;
        private readonly IUnitOfWork unitOfWork;
        public HomeController(ILogger<HomeController> logger, u9673886_arsdbContext _db, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            db = _db;
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;
            var vGirisYapanKullanici = claimsIdentity.FindFirst("kullanici_mail").Value.ToString();
            return View();
        }

        [Route("hakkimizda")]
        public IActionResult About()
        {
            return View();
        }

        [Route("iletisim")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("iletisim")]
        [HttpPost]
        public async Task<IActionResult> Contact(Message message)
        {
            await db.Messages.AddAsync(message);
            return View();
        }

        [Route("ilanlar")]
        public async Task<IActionResult> Advertisements()
        {
            //var model = await unitOfWork.AdvertisementRepository.GetAdvertisements();
            var model = await db.VIlanListesis.ToListAsync();
            return View(model);
        }

        [Route("detay")]
        public async Task<IActionResult> AdvertisementDetail(int? id)
        {
            var model = new AdvertisementDetailViewModel()
            {
                Advertisement_items = await db.VIlanDetays.Where(w => w.Id == id).FirstOrDefaultAsync(),
                Photos = await db.Photos.Where(w=>w.AdvertisementId == id).ToListAsync()
            };
            return View(model);
        }

        [Route("Deneme")]
        public async Task<IActionResult> Privacy()
        {
            var model = await unitOfWork.AdvertisementRepository.GetAdvertisements();
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
