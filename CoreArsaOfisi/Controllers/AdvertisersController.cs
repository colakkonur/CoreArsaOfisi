using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoreArsaOfisi.Models.db;

namespace CoreArsaOfisi.Controllers
{
    public class AdvertisersController : Controller
    {
        private readonly u9673886_arsdbContext _context;

        public AdvertisersController(u9673886_arsdbContext context)
        {
            _context = context;
        }

        // GET: Advertisers
        public async Task<IActionResult> Index()
        {
            var u9673886_arsdbContext = _context.Advertisers.Include(a => a.Authority);
            return View(await u9673886_arsdbContext.ToListAsync());
        }

        // GET: Advertisers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advertiser = await _context.Advertisers
                .Include(a => a.Authority)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (advertiser == null)
            {
                return NotFound();
            }

            return View(advertiser);
        }

        // GET: Advertisers/Create
        public IActionResult Create()
        {
            ViewData["AuthorityId"] = new SelectList(_context.Authorities, "Id", "Id");
            return View();
        }

        // POST: Advertisers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CompanyName,DateOfRegistration,OfficalName,PhoneNumber,LandPhone,WhatsappNumber,AuthorityId,Mail,Password,Avatar")] Advertiser advertiser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(advertiser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AuthorityId"] = new SelectList(_context.Authorities, "Id", "Id", advertiser.AuthorityId);
            return View(advertiser);
        }

        // GET: Advertisers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advertiser = await _context.Advertisers.FindAsync(id);
            if (advertiser == null)
            {
                return NotFound();
            }
            ViewData["AuthorityId"] = new SelectList(_context.Authorities, "Id", "Id", advertiser.AuthorityId);
            return View(advertiser);
        }

        // POST: Advertisers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CompanyName,DateOfRegistration,OfficalName,PhoneNumber,LandPhone,WhatsappNumber,AuthorityId,Mail,Password,Avatar")] Advertiser advertiser)
        {
            if (id != advertiser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(advertiser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdvertiserExists(advertiser.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AuthorityId"] = new SelectList(_context.Authorities, "Id", "Id", advertiser.AuthorityId);
            return View(advertiser);
        }

        // GET: Advertisers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advertiser = await _context.Advertisers
                .Include(a => a.Authority)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (advertiser == null)
            {
                return NotFound();
            }

            return View(advertiser);
        }

        // POST: Advertisers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var advertiser = await _context.Advertisers.FindAsync(id);
            _context.Advertisers.Remove(advertiser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdvertiserExists(int id)
        {
            return _context.Advertisers.Any(e => e.Id == id);
        }
    }
}
