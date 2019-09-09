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
    public class SampleTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SampleTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SampleTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.SampleType.ToListAsync());
        }

        // GET: SampleTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sampleType = await _context.SampleType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sampleType == null)
            {
                return NotFound();
            }

            return View(sampleType);
        }

        // GET: SampleTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SampleTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] SampleType sampleType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sampleType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sampleType);
        }

        // GET: SampleTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sampleType = await _context.SampleType.FindAsync(id);
            if (sampleType == null)
            {
                return NotFound();
            }
            return View(sampleType);
        }

        // POST: SampleTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] SampleType sampleType)
        {
            if (id != sampleType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sampleType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SampleTypeExists(sampleType.Id))
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
            return View(sampleType);
        }

        // GET: SampleTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sampleType = await _context.SampleType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sampleType == null)
            {
                return NotFound();
            }

            return View(sampleType);
        }

        // POST: SampleTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sampleType = await _context.SampleType.FindAsync(id);
            _context.SampleType.Remove(sampleType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SampleTypeExists(int id)
        {
            return _context.SampleType.Any(e => e.Id == id);
        }
    }
}
