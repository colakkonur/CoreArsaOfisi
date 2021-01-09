using CoreArsaOfisi.BusinessLayer.Repository.Concrete;
using CoreArsaOfisi.Models;
using Microsoft.AspNetCore.Authorization;
using CoreArsaOfisi.DataLayer.Models.db;
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

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;
            var vGirisYapanKullanici = claimsIdentity.FindFirst("kullanici_mail").Value.ToString();
            return View();
        }

        [Route("Deneme")]
        public IActionResult Privacy()
        {
            UnitOfWork unitOfWork = new UnitOfWork(new u9673886_arsdbContext());
            return View(unitOfWork.AdvertiserRepository.GetAllAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
