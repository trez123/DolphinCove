using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DolphinCove.Data;
using DolphinCove.Models;

namespace DolphinCove.Controllers
{
    public class AddonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AddonController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Addons
        public async Task<IActionResult> Index()
        {
              return _context.Addons != null ? 
                          View(await _context.Addons.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Addons'  is null.");
        }

        // GET: Addons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Addons == null)
            {
                return NotFound();
            }

            var addon = await _context.Addons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (addon == null)
            {
                return NotFound();
            }

            return View(addon);
        }

        // GET: Addons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Addons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AddonName,AddonPrice,AddonImage1")] Addon addon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(addon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(addon);
        }

        // GET: Addons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Addons == null)
            {
                return NotFound();
            }

            var addon = await _context.Addons.FindAsync(id);
            if (addon == null)
            {
                return NotFound();
            }
            return View(addon);
        }

        // POST: Addons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AddonName,AddonPrice,AddonImage1")] Addon addon)
        {
            if (id != addon.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(addon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AddonExists(addon.Id))
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
            return View(addon);
        }

        // GET: Addons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Addons == null)
            {
                return NotFound();
            }

            var addon = await _context.Addons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (addon == null)
            {
                return NotFound();
            }

            return View(addon);
        }

        // POST: Addons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Addons == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Addons'  is null.");
            }
            var addon = await _context.Addons.FindAsync(id);
            if (addon != null)
            {
                _context.Addons.Remove(addon);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AddonExists(int id)
        {
          return (_context.Addons?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
