using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Models.CinemaMovie.DictionaryModels;
using DatabaseAPI.Models.DictionaryModels;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ServiceStack;

namespace PortalWWW.Controllers.Admin.CinemaMovie
{
    [Route("[controller]")]
    public class MovieAdminController : Controller
    {

        protected readonly IRepository<Movie> repository;
        protected readonly IWebHostEnvironment webHostEnvironment;
        public MovieAdminController(IRepository<Movie> repository, IWebHostEnvironment webHostEnvironment)
        {
            this.repository = repository;
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpGet("Index")]
        public async Task<IActionResult> Index()
        {
            ViewData["type"] = typeof(Movie);
            ViewData["entityEndpoint"] = "movieadmin";
            return View();
        }


        [HttpGet("Create")]
        public async Task<IActionResult> Create()
        {
            ViewBag.AgeRating = new SelectList(await repository.GetDbSet<AgeRating>().ToListAsync(), "Id", "Name");
            ViewBag.Country = new SelectList(await repository.GetDbSet<Country>().ToListAsync(), "Id", "Name");
            ViewBag.Genre = new SelectList(await repository.GetDbSet<Genre>().ToListAsync(), "Id", "Name");
            ViewBag.MovieFormat = new SelectList(await repository.GetDbSet<MovieFormat>().ToListAsync(), "Id", "Name");
            ViewBag.MovieProductionCompany = new SelectList(await repository.GetDbSet<MovieProductionCompany>().ToListAsync(), "Id", "Name");
            ViewData["type"] = typeof(Movie);
            ViewData["PartialViewName"] = "MovieCreate";
            return View();
        }

        [HttpGet("Edit")]
        public async Task<IActionResult> Edit(int id)
        {
            var entity = await repository.FindEntityAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            ViewBag.AgeRating = new SelectList(await repository.GetDbSet<AgeRating>().ToListAsync(), "Id", "Name");
            ViewBag.Country = new SelectList(await repository.GetDbSet<Country>().ToListAsync(), "Id", "Name");
            ViewBag.Genre = new SelectList(await repository.GetDbSet<Genre>().ToListAsync(), "Id", "Name");
            ViewBag.MovieFormat = new SelectList(await repository.GetDbSet<MovieFormat>().ToListAsync(), "Id", "Name");
            ViewBag.MovieProductionCompany = new SelectList(await repository.GetDbSet<MovieProductionCompany>().ToListAsync(), "Id", "Name");
            ViewData["type"] = typeof(Movie);
            ViewData["PartialViewName"] = "MovieCreate";
            return View(entity);
        }

        [HttpGet("Details")]
        public async Task<IActionResult> Details(int id)
        {
            var entity = await repository.getDbSet()
                .Include(movie => movie.AgeRating)
                .Include(movie => movie.Country)
                .Include(movie => movie.Genre)
                .Include(movie => movie.MovieFormat)
                .Include(movie => movie.MovieProductionCompany)
                .FirstAsync(movie => movie.Id == id);
            if (entity == null)
            {
                return NotFound();
            }
            ViewData["type"] = typeof(Movie);
            ViewData["PartialViewName"] = "MovieDetails";
            return View(entity);
        }

        [HttpGet("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var entity = await repository.getDbSet()
                .Include(movie => movie.AgeRating)
                .Include(movie => movie.Country)
                .Include(movie => movie.Genre)
                .Include(movie => movie.MovieFormat)
                .Include(movie => movie.MovieProductionCompany)
                .FirstAsync(movie => movie.Id == id);
            if (entity == null)
            {
                return NotFound();
            }
            ViewData["type"] = typeof(Movie);
            ViewData["PartialViewName"] = "MovieDetails";
            return View(entity);
        }


        [HttpPost("DeleteConfirmed")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await repository.DeleteEntityAsync(id);
            return RedirectToAction(nameof(Index));
        }



        [HttpPost("EditConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditConfirmed(Movie entity, IFormFile? file)
        {
            if (file != null)
            {
                string wwwRootPath = webHostEnvironment.WebRootPath;
                string folderPath = Path.Combine(wwwRootPath, @"photos");
                string finalPath = Path.Combine(folderPath, file.FileName);
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                if (!string.IsNullOrEmpty(entity.imageUrl))
                {
                    var oldImagePath = Path.Combine(wwwRootPath, entity.imageUrl.TrimStart('\\'));
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }
                if (System.IO.File.Exists(finalPath))
                {
                    System.IO.File.Delete(finalPath);
                }
                using (var fileStream = new FileStream(finalPath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                entity.imageUrl = @"\photos\" + file.FileName;
            }
            if (!ModelState.IsValid)
            {
                ViewData["type"] = typeof(Movie);
                return View(entity);
            }
            entity.ModifiedAt = DateTime.Now;
            await repository.UpdateEntityAsync(entity);
            return RedirectToAction(nameof(Index));
        }


        [HttpPost("CreateConfirmed")]
        virtual public async Task<IActionResult> CreateConfirmed(Movie entity, IFormFile? file)
        {
            if (file != null)
            {
                string wwwRootPath = webHostEnvironment.WebRootPath;
                string folderPath = Path.Combine(wwwRootPath, @"photos");
                string finalPath = Path.Combine(folderPath, file.FileName);
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using (var fileStream = new FileStream(finalPath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                entity.imageUrl = @"\photos\" + file.FileName;
            }
            entity.CreatedAt = DateTime.Now;
            entity.ModifiedAt = DateTime.Now;
            await repository.AddEntityAsync(entity);
            return RedirectToAction("Index");
        }

        
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<Movie> entities = repository.GetEntityList().ToList();
            return Json(new { data = entities });
        }
    }
}
