using CoreArsaOfisi.BusinessLayer.Business;
using CoreArsaOfisi.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreArsaOfisi.Controllers
{
    public class AdvertiserController : Controller
    {
        [Route("Emlakcidetay")]
        public async Task<IActionResult> AdvertiserDetail(int Id)
        {
            AdvertiserBusiness advertiserBusiness = new AdvertiserBusiness();

            var model= new AdvertiserDetailViewModel()
            {
                Advertiser= await advertiserBusiness.GetAdvertiserAsync(Id),
            };

            return View(model);
        }
    }
}
