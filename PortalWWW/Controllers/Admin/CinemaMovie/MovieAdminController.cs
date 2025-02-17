using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Models.CinemaMovie.DictionaryModels;
using DatabaseAPI.Models.DictionaryModels;
using DatabaseAPI.Models.People;
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
        private string IMAGE_PATH = @"http://localhost/images/";
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
            ViewBag.Actor = new SelectList(await repository.GetDbSet<Actor>().ToListAsync(), "Id", "Name");
            ViewBag.MovieKeywords = new SelectList(await repository.GetDbSet<MovieKeywords>().ToListAsync(), "Id", "Name");
            ViewBag.Director = new SelectList(await repository.GetDbSet<Director>().ToListAsync(), "Id", "Name");
            ViewBag.Subtitles = new SelectList(await repository.GetDbSet<Subtitles>().ToListAsync(), "Id", "Name");
            ViewBag.Languages = new SelectList(await repository.GetDbSet<Languages>().ToListAsync(), "Id", "Name");
            ViewBag.Award = new SelectList(await repository.GetDbSet<Award>().ToListAsync(), "Id", "Name");
            ViewData["type"] = typeof(Movie);
            ViewData["PartialViewName"] = "MovieCreate";
            return View();
        }

        [HttpGet("Edit")]
        public async Task<IActionResult> Edit(int id)
        {
            var entity = await repository.GetDbSet<Movie>()
                .Include(movie => movie.Actors)
                .Include(movie => movie.Awards)
                .Include(movie => movie.Directors)
                .Include(movie => movie.Languages)
                .Include(movie => movie.MovieKeywords)
                .Include(movie => movie.Subtitles)
                .FirstAsync(x => x.Id == id);
            if (entity == null)
            {
                return NotFound();
            }
            ViewBag.AgeRating = new SelectList(await repository.GetDbSet<AgeRating>().ToListAsync(), "Id", "Name");
            ViewBag.Country = new SelectList(await repository.GetDbSet<Country>().ToListAsync(), "Id", "Name");
            ViewBag.Genre = new SelectList(await repository.GetDbSet<Genre>().ToListAsync(), "Id", "Name");
            ViewBag.MovieFormat = new SelectList(await repository.GetDbSet<MovieFormat>().ToListAsync(), "Id", "Name");
            ViewBag.MovieProductionCompany = new SelectList(await repository.GetDbSet<MovieProductionCompany>().ToListAsync(), "Id", "Name");
            ViewBag.Actor = new SelectList(await repository.GetDbSet<Actor>().ToListAsync(), "Id", "Name");
            ViewBag.MovieKeywords = new SelectList(await repository.GetDbSet<MovieKeywords>().ToListAsync(), "Id", "Name");
            ViewBag.Director = new SelectList(await repository.GetDbSet<Director>().ToListAsync(), "Id", "Name");
            ViewBag.Subtitles = new SelectList(await repository.GetDbSet<Subtitles>().ToListAsync(), "Id", "Name");
            ViewBag.Languages = new SelectList(await repository.GetDbSet<Languages>().ToListAsync(), "Id", "Name");
            ViewBag.Award = new SelectList(await repository.GetDbSet<Award>().ToListAsync(), "Id", "Name");
            entity.SelectedActors = entity.Actors.Select(a => a.Id)?.ToList();
            entity.SelectedAwards = entity.Awards.Select(a => a.Id)?.ToList();
            entity.SelectedDirectors = entity.Directors.Select(a => a.Id)?.ToList();
            entity.SelectedLanguages = entity.Languages.Select(a => a.Id)?.ToList();
            entity.SelectedMovieKeywords = entity.MovieKeywords.Select(a => a.Id)?.ToList();
            entity.SelectedSubtitles = entity.Subtitles.Select(a => a.Id)?.ToList();
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
                .Include(movie => movie.Actors)
                .Include(movie => movie.Awards)
                .Include(movie => movie.Directors)
                .Include(movie => movie.Languages)
                .Include(movie => movie.MovieKeywords)
                .Include(movie => movie.Subtitles)
                .FirstAsync(movie => movie.Id == id);
            if (entity == null)
            {
                return NotFound();
            }
            ViewData["type"] = typeof(Movie);
            ViewData["PartialViewName"] = "MovieDetails";
            return View(entity);
        }


        [HttpPost("EditConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditConfirmed(Movie entity, IFormFile? file)
        {
            if (file != null)
            {
                string xamppPath = @"C:\xampp\htdocs\images\";
                string folderPath = @"C:\xampp\htdocs\images\photos\";
                var finalPath = Path.Combine(folderPath, file.FileName);
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                if (!string.IsNullOrEmpty(entity.imageUrl))
                {
                    var oldImagePath = Path.Combine(xamppPath, entity.imageUrl.TrimStart('\\'));
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
            var movie = await repository.GetDbSet<Movie>()
                .Include(movie => movie.Actors)
                .Include(movie => movie.Awards)
                .Include(movie => movie.Directors)
                .Include(movie => movie.Languages)
                .Include(movie => movie.MovieKeywords)
                .Include(movie => movie.Subtitles)
            .FirstOrDefaultAsync(m => m.Id == entity.Id);
            var selectedActors = await repository.GetDbSet<Actor>().Where(x => entity.SelectedActors.Contains(x.Id)).ToListAsync();
            var selectedAwards = await repository.GetDbSet<Award>().Where(x => entity.SelectedAwards.Contains(x.Id)).ToListAsync();
            var selectedDirectors = await repository.GetDbSet<Director>().Where(x => entity.SelectedDirectors.Contains(x.Id)).ToListAsync();
            var selectedLanguages = await repository.GetDbSet<Languages>().Where(x => entity.SelectedLanguages.Contains(x.Id)).ToListAsync();
            var selectedMovieKeywords = await repository.GetDbSet<MovieKeywords>().Where(x => entity.SelectedMovieKeywords.Contains(x.Id)).ToListAsync();
            var selectedSubtitles = await repository.GetDbSet<Subtitles>().Where(x => entity.SelectedSubtitles.Contains(x.Id)).ToListAsync();

            movie.Actors = selectedActors;
            movie.Awards = selectedAwards;
            movie.Directors = selectedDirectors;
            movie.Languages = selectedLanguages;
            movie.MovieKeywords = selectedMovieKeywords;
            movie.Subtitles = selectedSubtitles;
            movie.ModifiedAt = DateTime.Now;
            await repository.UpdateEntityAsync(movie);
            TempData["SuccessMessage"] = "Record updated successfully!";
            return RedirectToAction(nameof(Index));
        }


        [HttpGet("DeleteImage")]
        public async Task<IActionResult> DeleteImage(int id)
        {
            var entity = await repository.FindEntityAsync(id);
            string xamppPath = @"C:\xampp\htdocs\images";
            if (string.IsNullOrEmpty(entity.imageUrl))
            {
                TempData["SuccessMessage"] = "Image is empty!";
                return RedirectToAction(nameof(Index));
            }
            var imagePath = xamppPath + entity.imageUrl;
            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
            }
            entity.imageUrl = null;
            entity.ModifiedAt = DateTime.Now;
            await repository.UpdateEntityAsync(entity);
            TempData["SuccessMessage"] = "Image delete successfully!";
            return RedirectToAction(nameof(Index));
        }


        [HttpPost("CreateConfirmed")]
        virtual public async Task<IActionResult> CreateConfirmed(Movie entity, IFormFile? file)
        {
            if (file != null)
            {
                string folderPath = @"C:\xampp\htdocs\images\photos\";
                var finalPath = Path.Combine(folderPath, file.FileName);
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
            var selectedActors = await repository.GetDbSet<Actor>().Where(x => entity.SelectedActors.Contains(x.Id)).ToListAsync();
            var selectedAwards = await repository.GetDbSet<Award>().Where(x => entity.SelectedAwards.Contains(x.Id)).ToListAsync();
            var selectedDirectors = await repository.GetDbSet<Director>().Where(x => entity.SelectedDirectors.Contains(x.Id)).ToListAsync();
            var selectedLanguages = await repository.GetDbSet<Languages>().Where(x => entity.SelectedLanguages.Contains(x.Id)).ToListAsync();
            var selectedMovieKeywords = await repository.GetDbSet<MovieKeywords>().Where(x => entity.SelectedMovieKeywords.Contains(x.Id)).ToListAsync();
            var selectedSubtitles = await repository.GetDbSet<Subtitles>().Where(x => entity.SelectedSubtitles.Contains(x.Id)).ToListAsync();

            entity.Actors = selectedActors;
            entity.Awards = selectedAwards;
            entity.Directors = selectedDirectors;
            entity.Languages = selectedLanguages;
            entity.MovieKeywords = selectedMovieKeywords;
            entity.Subtitles = selectedSubtitles;
            entity.CreatedAt = DateTime.Now;
            entity.ModifiedAt = DateTime.Now;
            await repository.AddEntityAsync(entity);
            TempData["SuccessMessage"] = "Record created successfully!";
            return RedirectToAction("Index");
        }


        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<Movie> entities = repository.GetEntityList().ToList();
            return Json(new { data = entities });
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var entity = await repository.FindEntityAsync(id);
            if (entity == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            else
            {
                await repository.DeleteEntityAsync(id);

                return Json(new { success = true, message = "Delete Successful" });
            }
        }
    }
}
