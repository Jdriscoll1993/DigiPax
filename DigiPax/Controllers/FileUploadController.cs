using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DigiPax.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DigiPax.Data;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace DigiPax.Controllers
{
    public class FileUploadController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public FileUploadController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        private object Details()
        {
            throw new NotImplementedException();
        }

        [Authorize]
        // GET: FileUpload/Create
        public IActionResult Create()
        {
            ViewData["SampleTypeId"] = new SelectList(_context.SampleType, "TypeId", "Label");
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
        [RequestSizeLimit(5 * 1024 * 1024)]
        public async Task<IActionResult> Create([Bind("Username,SampleName,SampleId,ApplicationUserId,TypeId,GenreId,KeyId,SamplePath")] Sample sample, IFormFile file)
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
            ModelState.Remove("UserId");
            if (ModelState.IsValid)
            {
                _context.Add(sample);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Details), new { id = sample.Id });
            }
            ViewData["ProductTypeId"] = new SelectList(_context.SampleType, "TypeId", "Label", sample.TypeId);
            ViewData["ProductTypeId"] = new SelectList(_context.Key, "KeyId", "Label", sample.KeyId);
            ViewData["ProductTypeId"] = new SelectList(_context.Genre, "GenreId", "Label", sample.GenreId);
            ViewData["UserId"] = new SelectList(_context.ApplicationUser, "Id", "Id", sample.ApplicationUserId);
            return View(sample);
        }

    }
}
