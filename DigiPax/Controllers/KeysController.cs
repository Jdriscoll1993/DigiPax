using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DigiPax.Data;
using DigiPax.Models;

namespace DigiPax.Controllers
{
    public class MusicKeysController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MusicKeysController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MusicKeys
        public async Task<IActionResult> Index()
        {
            return View(await _context.MusicKey.ToListAsync());
        }

        // GET: Keys/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musicKey = await _context.MusicKey
                .FirstOrDefaultAsync(m => m.Id == id);
            if (musicKey == null)
            {
                return NotFound();
            }

            return View(musicKey);
        }

        // GET: Keys/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Keys/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] MusicKey musicKey)
        {
            if (ModelState.IsValid)
            {
                _context.Add(musicKey);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(musicKey);
        }

        // GET: MusicKeys/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musicKey = await _context.MusicKey.FindAsync(id);
            if (musicKey == null)
            {
                return NotFound();
            }
            return View(musicKey);
        }

        // POST: MusicKeys/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] MusicKey key)
        {
            if (id != key.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(key);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MusicKeyExists(key.Id))
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
            return View(key);
        }

        // GET: MusicKeys/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var key = await _context.MusicKey
                .FirstOrDefaultAsync(m => m.Id == id);
            if (key == null)
            {
                return NotFound();
            }

            return View(key);
        }

        // POST: MusicKeys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var key = await _context.MusicKey.FindAsync(id);
            _context.MusicKey.Remove(key);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MusicKeyExists(int id)
        {
            return _context.MusicKey.Any(e => e.Id == id);
        }
    }
}
