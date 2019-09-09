using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DigiPax.Data;
using DigiPax.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace DigiPax.Controllers
{
    public class SamplesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public SamplesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: Samples
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Sample.Include(s => s.Genre).Include(s => s.Key);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Samples/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sample = await _context.Sample
                .Include(s => s.Genre)
                .Include(s => s.Key)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sample == null)
            {
                return NotFound();
            }

            return View(sample);
        }

        [Authorize]
        // GET: Samples/Create
        public IActionResult Create()
        {
            ViewData["TypeId"] = new SelectList(_context.SampleType, "TypeId", "Label");
            ViewData["GenreId"] = new SelectList(_context.Genre, "GenreId", "Label");
            ViewData["KeyId"] = new SelectList(_context.Key, "KeyId", "Label");
            ViewData["UserId"] = new SelectList(_context.ApplicationUser, "Id", "Id");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SampleName,TypeId,GenreId,KeyId,SamplePath")] Sample sample, IFormFile file)
        {
            var path = Path.Combine(
                  Directory.GetCurrentDirectory(), "wwwroot",
                  "AudioFiles", file.FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            ApplicationUser user = await GetCurrentUserAsync();
            sample.ApplicationUserId = user.Id;
            sample.SamplePath = "AudioFiles/" + file.FileName;
            ModelState.Remove("ApplicationUserId");
            if (ModelState.IsValid)
            {
                _context.Add(sample);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Details), new { id = sample.Id });
            }
            ViewData["TypeId"] = new SelectList(_context.SampleType, "TypeId", "Label", sample.TypeId);
            ViewData["GenreId"] = new SelectList(_context.Key, "KeyId", "Label", sample.KeyId);
            ViewData["KeyId"] = new SelectList(_context.Genre, "GenreId", "Label", sample.GenreId);
            ViewData["UserId"] = new SelectList(_context.ApplicationUser, "Id", "Id", sample.ApplicationUserId);
            return View(sample);
        }

        // GET: Samples/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sample = await _context.Sample.FindAsync(id);
            if (sample == null)
            {
                return NotFound();
            }
            ViewData["GenreId"] = new SelectList(_context.Genre, "Id", "Id", sample.GenreId);
            ViewData["KeyId"] = new SelectList(_context.Key, "Id", "Id", sample.KeyId);
            return View(sample);
        }

        // POST: Samples/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SampleName,SamplePath,ApplicationUserId,TypeId,GenreId,KeyId")] Sample sample)
        {
            if (id != sample.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sample);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SampleExists(sample.Id))
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
            ViewData["GenreId"] = new SelectList(_context.Genre, "Id", "Id", sample.GenreId);
            ViewData["KeyId"] = new SelectList(_context.Key, "Id", "Id", sample.KeyId);
            return View(sample);
        }

        // GET: Samples/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sample = await _context.Sample
                .Include(s => s.Genre)
                .Include(s => s.Key)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sample == null)
            {
                return NotFound();
            }

            return View(sample);
        }

        // POST: Samples/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sample = await _context.Sample.FindAsync(id);
            _context.Sample.Remove(sample);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SampleExists(int? id)
        {
            return _context.Sample.Any(e => e.Id == id);
        }
    }
}
