﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DigiPax.Data;
using DigiPax.Models;
using DigiPax.Models.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace DigiPax.Controllers
{
    // Inherit from base class for MVC Controller
    public class FavoritesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        //Constructor takes in references to the database and to the user and initializes their values
        public FavoritesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        //Handy reusable method to get the current user
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // CRUD OPERATONS ON FAVORITES


        // GET: Favorites
        public async Task<IActionResult> Index()
        {
            var viewModel = new FavoriteListViewModel();
            var user = await GetCurrentUserAsync();
            viewModel.Favorites = await _context.Favorite.Include(f => f.Sample).ToListAsync();
            viewModel.Samples = await _context.Sample.Where(s => s.ApplicationUserId == user.Id).ToListAsync();
            return View(viewModel);
        }

        // GET: Favorites/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var favorite = await _context.Favorite
                .Include(f => f.Sample)
                .Include(f => f.Sample.MusicKey)
                .Include(f => f.Sample.SampleType)
                .Include(f => f.Sample.Genre)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (favorite == null)
            {
                return NotFound();
            }
            return View(favorite.Sample);
        }


        // GET: Favorites/Create
        public IActionResult Create()
        {
            ViewData["SampleId"] = new SelectList(_context.Sample, "Id", "ApplicationUserId");
            return View();
        }

        // POST: Favorites/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,SampleId")] Favorite favorite)
        {
            if (ModelState.IsValid)
            {
                _context.Add(favorite);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SampleId"] = new SelectList(_context.Sample, "Id", "ApplicationUserId", favorite.SampleId);
            return View(favorite);
        }


        // GET: Favorites/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var favorite = await _context.Favorite.FindAsync(id);
            if (favorite == null)
            {
                return NotFound();
            }
            ViewData["SampleId"] = new SelectList(_context.Sample, "Id", "ApplicationUserId", favorite.SampleId);
            return View(favorite);
        }

        // POST: Favorites/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,SampleId")] Favorite favorite)
        {
            if (id != favorite.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(favorite);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FavoriteExists(favorite.Id))
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
            ViewData["SampleId"] = new SelectList(_context.Sample, "Id", "ApplicationUserId", favorite.SampleId);
            return View(favorite);
        }


        // GET: Favorites/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var favorite = await _context.Favorite
                .Include(f => f.Sample)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (favorite == null)
            {
                return NotFound();
            }
            return View(favorite);
        }

        // POST: Favorites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var favorite = await _context.Favorite.FindAsync(id);
            _context.Favorite.Remove(favorite);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        // ADDITIONAL METHODS


        // private method used in Favorites/Edit to check against already favorited samples
        private bool FavoriteExists(int id)
        {
            return _context.Favorite.Any(e => e.Id == id);
        }
    }
}
