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
using DigiPax.Models.ViewModels;
using X.PagedList;

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
        public async Task<IActionResult> Index(string searchString, string sortOrder, string currentFilter, int? page)
        {
            ViewBag.CurrentSort = sortOrder;

            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            // Grabs samples from contexts, if search string exists samples are filtered by search
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var samples = from s in _context.Sample
                          .Include(s => s.Genre)
                          .Include(s => s.SampleType)
                          .Include(s => s.MusicKey)
                          .Include(s => s.ApplicationUser)
                          select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                samples = samples.Where(s => s.SampleName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "sampleName_desc":
                    samples = samples.OrderByDescending(s => s.SampleName);
                    break;
                case "genre_desc":
                    samples = samples.OrderByDescending(s => s.Genre);
                    break;
                case "sampleType_desc":
                    samples = samples.OrderByDescending(s => s.SampleType);
                    break;
                case "musicKey":
                    samples = samples.OrderBy(s => s.MusicKey);
                    break;
            }
            var applicationDbContext = samples;

            if (!String.IsNullOrEmpty(searchString))
            {
                samples = samples.Where(s => s.SampleName.Contains(searchString));
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(samples.ToPagedList(pageNumber, pageSize));

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
                .Include(s => s.SampleType)
                .Include(s => s.MusicKey)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sample == null)
            {
                return NotFound();
            }

            return View(sample);
        }


        [Authorize]
        // GET: Samples/Create
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var viewModel = new SampleCreateViewModel();
            viewModel.MusicKeys = new SelectList(await _context.MusicKey.ToListAsync(), "Id", "Name");
            viewModel.Genres = new SelectList(await _context.Genre.ToListAsync(), "Id", "Name");
            viewModel.SampleTypes = new SelectList(await _context.SampleType.ToListAsync(), "Id", "Name");


            return View(viewModel);
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SampleName,SampleTypeId,GenreId,MusicKeyId,SamplePath")] Sample sample, IFormFile file)
        {
            if (file != null)
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
                ModelState.Remove("sample.ApplicationUserId");
                if (ModelState.IsValid)
                {
                    _context.Add(sample);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Details), new { id = sample.Id });
                }
                var viewModel = new SampleCreateViewModel();
                viewModel.MusicKeys = new SelectList(await _context.MusicKey.ToListAsync(), "Id", "Name");
                //new SelectListItem { Text = "Keys", Value = "True", Selected = true });
                viewModel.Genres = new SelectList(await _context.Genre.ToListAsync(), "Id", "Name");
                viewModel.SampleTypes = new SelectList(await _context.SampleType.ToListAsync(), "Id", "Name");
                return View(viewModel);
            }
            else
            {
                var viewModel = new SampleCreateViewModel();
                viewModel.MusicKeys = new SelectList(await _context.MusicKey.ToListAsync(), "Id", "Name");
                viewModel.Genres = new SelectList(await _context.Genre.ToListAsync(), "Id", "Name");
                viewModel.SampleTypes = new SelectList(await _context.SampleType.ToListAsync(), "Id", "Name");
                return View(viewModel);
            }
        }


        //[HttpGet("{applicationUserId}/{sampleId}")]
        public async Task<IActionResult> AddToFavorite(int sampleId)
        {
            // create a new record of favorite
            var favorite = new Favorite();
            // grab the current user and assign it to a variable
            ApplicationUser user = await GetCurrentUserAsync();
            // initiate the value of properties
            favorite.SampleId = sampleId;
            favorite.ApplicationUser = user;
            // saving the record to the database asynchronosly 
            await _context.Favorite.AddAsync(favorite);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
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
            ViewData["KeyId"] = new SelectList(_context.MusicKey, "Id", "Id", sample.MusicKeyId);
            return View(sample);
        }

        // POST: Samples/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SampleName,SamplePath,ApplicationUserId,TypeId,GenreId,MusicKeyId")] Sample sample)
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
            ViewData["KeyId"] = new SelectList(_context.MusicKey, "Id", "Id", sample.MusicKeyId);
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
                .Include(s => s.MusicKey)
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

        public async Task<IActionResult> SearchSamples(string searchString)
        {
            //Grabs samples from contexts, if search string exists samples are filtered by search

            var samples = from s in _context.Sample
                          .Include(s => s.Genre)
                          .Include(s => s.SampleType)
                          .Include(s => s.MusicKey)
                          .Include(s => s.ApplicationUser)
                          select s;
            var applicationDbContext = samples;

            if (!String.IsNullOrEmpty(searchString))
            {
                samples = samples.Where(s => s.SampleName.Contains(searchString));
            }
            return View(await applicationDbContext.ToListAsync());
        }

        //// GET: UserSamples
        //public async Task<IActionResult> MySamples()
        //{
        //    var samples = await _context.Sample
        //        .Where(s => s.ApplicationUserId == _userManager.GetUserId(User))
        //        .Include(s => s.Key)
        //        .Include(s => s.SampleType)
        //        .Include(s => s.Genre)
        //        .ToListAsync();

        //    var mySamples = samples.Select(sample => new SampleCreateViewModel()
        //    {
        //        Sample = sample,
        //    }).ToList();


        //    return View();
        //}
    }
}
