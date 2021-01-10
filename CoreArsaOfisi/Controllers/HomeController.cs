using CoreArsaOfisi.BusinessLayer.Repository.Concrete;
using CoreArsaOfisi.DataLayer.Models.db;
using CoreArsaOfisi.Models;
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

        public HomeController(ILogger<HomeController> logger, u9673886_arsdbContext _db)
        {
            _logger = logger;
            db = _db;
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
            UnitOfWork _unitOfWork = new UnitOfWork(db);
            var model = await _unitOfWork.AdvertiserRepository.GetAllAsync();
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
