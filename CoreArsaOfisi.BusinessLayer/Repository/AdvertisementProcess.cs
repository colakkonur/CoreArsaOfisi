using CoreArsaOfisi.DataLayer.Models.db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreArsaOfisi.BusinessLayer.Repository
{
    public static class AdvertisementProcess
    {
        public static readonly u9673886_arsdbContext db = new u9673886_arsdbContext();
        public static async Task<List<Advertisement>> GetAllAsync()
        {
            return await db.Advertisements
                .Include(w => w.AdvertisementType)
                .Include(w=>w.District).ThenInclude(w=>w.Province)
                .Include(w=>w.Advertiser)
                .ToListAsync();
        }

        public static async Task<List<Photo>> Photos()
        {
            return await db.Photos.ToListAsync();

        }
        public static async void DeleteAsync(int? id)
        {
            var model = await db.Advertisements.Where(w => w.Id == id).FirstOrDefaultAsync();
            db.Remove(model);
        }

        public static async void DeleteAsync(Advertisement T)
        {
            var model = await db.Advertisements.FindAsync(T);
            db.Remove(model);
        }
    }

}
