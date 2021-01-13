using CoreArsaOfisi.BusinessLayer.Repository;
using CoreArsaOfisi.BusinessLayer.Repository.Abstract;
using CoreArsaOfisi.BusinessLayer.Repository.Concrete;
using CoreArsaOfisi.DataLayer.Models.db;
using CoreArsaOfisi.Models;
using CoreArsaOfisi.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        private readonly IRepository repository;

        public HomeController(ILogger<HomeController> logger, u9673886_arsdbContext _db, IRepository _repository)
        {
            _logger = logger;
            db = _db;
            repository = _repository;
        }

        public IActionResult Index()
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;
            var vGirisYapanKullanici = claimsIdentity.FindFirst("kullanici_mail").Value.ToString();
            return View();
        }

        [Route("Deneme")]
        public async Task<IActionResult> Privacy()
        {
            await AdvertisementProcess.GetAllAsync();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Advertisements()
        {
            AdvertisementsListViewModel model = new AdvertisementsListViewModel
            {
                Advertisements = await AdvertisementProcess.GetAllAsync(),
                Photos = await AdvertisementProcess.Photos()
            };
            return View(model);
        }
    }
}
