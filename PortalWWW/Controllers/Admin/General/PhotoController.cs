using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Models.DictionaryModels;
using DatabaseAPI.Models.General;
using DatabaseAPI.Models.General.DictionaryModels;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace PortalWWW.Controllers.Admin.General
{
    public class PhotoController : Controller
    {

        protected readonly IRepository<Photo> repository;
        protected readonly IWebHostEnvironment webHostEnvironment;

        public PhotoController(IRepository<Photo> repository, IWebHostEnvironment webHostEnvironment)
        {
            this.repository = repository;
            this.webHostEnvironment = webHostEnvironment;
        }


        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        public async Task<IActionResult> Edit(int id)
        {
            var entity = await repository.FindEntityAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            return View(entity);
        }

        public async Task<IActionResult> Details(int id)
        {
            var entity = await repository.getDbSet()
                .FirstAsync(Photo => Photo.Id == id);
            if (entity == null)
            {
                return NotFound();
            }
            return View(entity);
        }


        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var entity = await repository.FindEntityAsync(id);
            if (entity == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            else
            {
                await repository.DeleteEntityAsync(entity.Id);
                return Json(new { success = true, message = "Delete Successful" });
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var entities = repository.GetEntityList();
            return Json(new { data = entities });
        }

        [HttpPost]
        public IActionResult Create(Photo entity, IFormFile? file)
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
                using ( var fileStream = new FileStream(finalPath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                entity.PathToPhoto = @"\photos\" + file.FileName; 
            }
            entity.CreatedAt = DateTime.Now;
            entity.ModifiedAt = DateTime.Now;
            entity.IsActive = true;
            repository.AddEntityAsync(entity);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Photo entity, IFormFile? file)
        {
            if (file != null)
            {
                string wwwRootPath = webHostEnvironment.WebRootPath;
                string folderPath = Path.Combine(wwwRootPath, @"photos");
                string finalPath = Path.Combine(folderPath, file.FileName);
                if (!Directory.Exists(finalPath))
                {
                    Directory.CreateDirectory(finalPath);
                }

                if (!string.IsNullOrEmpty(entity.PathToPhoto))
                {
                    var oldImagePath = Path.Combine(wwwRootPath, entity.PathToPhoto.TrimStart('\\'));
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }
                using (var fileStream = new FileStream(finalPath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                entity.PathToPhoto = @"\photos\" + file.FileName;
            }
            entity.ModifiedAt = DateTime.Now;
            entity.IsActive = true;
            await repository.UpdateEntityAsync(entity);
            return RedirectToAction("Index");
        }
    }
}
