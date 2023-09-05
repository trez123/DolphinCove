using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DolphinCove.Data;
using DolphinCove.Models;
using Microsoft.AspNetCore.Hosting;

namespace DolphinCove.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ExperienceController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Experience
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Experiences.Include(e => e.ExperienceAddons).Include(e => e.Park);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Experience/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Experiences == null)
            {
                return NotFound();
            }

            var experience = await _context.Experiences
                .Include(e => e.ExperienceAddons)
                .Include(e => e.Park)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (experience == null)
            {
                return NotFound();
            }

            return View(experience);
        }

        // GET: Experience/Create
        public IActionResult Create()
        {
            ViewData["ExperienceAddonsId"] = new SelectList(_context.ExperienceAddons, "Id", "Id");
            ViewData["ParkId"] = new SelectList(_context.Parks, "Id", "ParkName");
            return View();
        }

        // POST: Experience/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ParkId,ExperienceName,AdultPrice,ChildPrice,ExperienceImage1,ExperienceImage2,ExperienceImage3,ExperienceImage4,ExperienceAddonsId")] Experience experience)
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

                        experience.ExperienceImage1 = filename + ext;
                    if (i == 1)
                        experience.ExperienceImage2 = filename + ext;
                    if (i == 2)
                        experience.ExperienceImage3 = filename + ext;
                    if (i == 3)
                        experience.ExperienceImage4 = filename + ext;

                }

                _context.Add(experience);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ExperienceAddonsId"] = new SelectList(_context.ExperienceAddons, "Id", "Id", experience.ExperienceAddonsId);
            ViewData["ParkId"] = new SelectList(_context.Parks, "Id", "ParkName", experience.ParkId);
            return View(experience);
        }

        // GET: Experience/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Experiences == null)
            {
                return NotFound();
            }

            var experience = await _context.Experiences.FindAsync(id);
            if (experience == null)
            {
                return NotFound();
            }
            ViewData["ExperienceAddonsId"] = new SelectList(_context.ExperienceAddons, "Id", "Id", experience.ExperienceAddonsId);
            ViewData["ParkId"] = new SelectList(_context.Parks, "Id", "ParkName", experience.ParkId);
            return View(experience);
        }

        // POST: Experience/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ParkId,ExperienceName,AdultPrice,ChildPrice,ExperienceImage1,ExperienceImage2,ExperienceImage3,ExperienceImage4,ExperienceAddonsId")] Experience experience)
        {
            if (id != experience.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(experience);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExperienceExists(experience.Id))
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
            ViewData["ExperienceAddonsId"] = new SelectList(_context.ExperienceAddons, "Id", "Id", experience.ExperienceAddonsId);
            ViewData["ParkId"] = new SelectList(_context.Parks, "Id", "ParkName", experience.ParkId);
            return View(experience);
        }

        // GET: Experience/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Experiences == null)
            {
                return NotFound();
            }

            var experience = await _context.Experiences
                .Include(e => e.ExperienceAddons)
                .Include(e => e.Park)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (experience == null)
            {
                return NotFound();
            }

            return View(experience);
        }

        // POST: Experience/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Experiences == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Experiences'  is null.");
            }
            var experience = await _context.Experiences.FindAsync(id);
            if (experience != null)
            {
                _context.Experiences.Remove(experience);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExperienceExists(int id)
        {
          return (_context.Experiences?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
