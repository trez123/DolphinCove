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
    public class ParkController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ParkController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Park
        public async Task<IActionResult> Index()
        {
            //necessary to push list to details page so foreach loop can iterate thru without error
            List<Park> parks = _context.Parks.ToList();
            ViewData["ParksList"] = parks;

            return _context.Parks != null ? 
                          View(await _context.Parks.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Parks'  is null.");
        }


        // GET: Park/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            List<Park> parksList = GetParksFromDb();
            ViewData["ParksList"] = parksList;

            if (id == null || _context.Parks == null)
            {
                return NotFound();
            }

            ViewData["ParkId"] = id;

            var park = await _context.Parks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (park == null)
            {
                return NotFound();
            }

            return View(park);
        }

        // GET: Park/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Park/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ParkName")] Park park)
        {
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                string WebRoot = _webHostEnvironment.WebRootPath;
                string uploadPath = WebRoot + AppConst.UploadPathExperiences;
                for (int i = 0; i < files.Count; i++)
                {
                    string filename = Guid.NewGuid().ToString();
                    string ext = Path.GetExtension(files[i].FileName);
                    using (var fs = new FileStream(Path.Combine(uploadPath, filename + ext), FileMode.Create))
                    {
                        files[i].CopyTo(fs);
                    }
                    if (i == 0)
                        park.DropdownImage = filename + ext;
                }

                _context.Add(park);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(park);
        }

        // GET: Park/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Parks == null)
            {
                return NotFound();
            }

            var park = await _context.Parks.FindAsync(id);
            if (park == null)
            {
                return NotFound();
            }
            return View(park);
        }

        // POST: Park/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ParkName")] Park park)
        {
            if (id != park.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(park);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParkExists(park.Id))
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
            return View(park);
        }

        // GET: Park/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Parks == null)
            {
                return NotFound();
            }

            var park = await _context.Parks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (park == null)
            {
                return NotFound();
            }

            return View(park);
        }

        // POST: Park/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Parks == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Parks'  is null.");
            }
            var park = await _context.Parks.FindAsync(id);
            if (park != null)
            {
                _context.Parks.Remove(park);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParkExists(int id)
        {
          return (_context.Parks?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        public List<Park> GetParksFromDb()
        {
            return _context.Parks.ToList();
        }

        public Park GetParkById(int id)
        {
            return _context.Parks.FirstOrDefault(p => p.Id == id);
        }
    }
}
