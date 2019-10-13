using System.Collections.Generic;
using System.Linq;
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
    public class PacksController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public PacksController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
        
        // CRUD Functionality

        // GET: Packs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pack.ToListAsync());
        }

        // GET: Packs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var viewModel = new PackDetailsViewModel();
            if (id == null)
            {
                return NotFound();
            }
            var pack = await _context.Pack
                .Include(m => m.PackSamples)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pack == null)
            {
                return NotFound();
            }
            viewModel.Pack = pack;
            var packSampleList = pack.PackSamples.ToList<PackSample>();
            var idList = new List<int?>();
            packSampleList.ForEach(ps =>
            {
                idList.Add(ps.SampleId);
            });
            viewModel.PackSamples = _context.Sample.Where(s => idList.Contains(s.Id)).ToList();
            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var viewModel = new PackCreateViewModel();
            viewModel.SampleIds = new List<int>()
            {
                0
            };
            ViewData["Samples"] = new SelectList(await _context.Sample.ToListAsync(), "Id", "SampleName");
            return View(viewModel);
        }

        // POST: Packs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PackCreateViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await GetCurrentUserAsync();
                var newPack = new Pack()
                {
                    Title = viewModel.Pack.Title,
                    ApplicationUserId = user.Id
                };
                _context.Add(newPack);
                await _context.SaveChangesAsync();
                var samplePacks = viewModel.SampleIds.Select(id => new PackSample()
                {
                    PackId = newPack.Id,
                    SampleId = id,
                });
                _context.PackSample.AddRange(samplePacks);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
        }

        // GET: Packs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var pack = await _context.Pack.FindAsync(id);
            if (pack == null)
            {
                return NotFound();
            }
            return View(pack);
        }

        // POST: Packs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,UserId")] Pack pack)
        {
            if (id != pack.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pack);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PackExists(pack.Id))
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
            return View(pack);
        }

        // GET: Packs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var pack = await _context.Pack
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pack == null)
            {
                return NotFound();
            }

            return View(pack);
        }

        // POST: Packs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pack = await _context.Pack.FindAsync(id);
            _context.Pack.Remove(pack);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        //ADDITIONAL METHODS


        private bool PackExists(int id)
        {
            return _context.Pack.Any(e => e.Id == id);
        }
    }
}
