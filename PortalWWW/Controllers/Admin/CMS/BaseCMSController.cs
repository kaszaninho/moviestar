using DatabaseAPI.Data;
using DatabaseAPI.Models.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PortalWWW.Controllers.Admin.CMS
{
    [Route("[controller]")]
    public class BaseCMSController<T> : Controller  where T : AbstractCMSDatatable
    {

        private readonly DatabaseAPIContext context;

        public BaseCMSController(DatabaseAPIContext context)
        {
            this.context = context;
        }
        [HttpGet("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("Create")]
        public IActionResult Create(T entity)
        {
            entity.Position = context.Set<T>().ToList().Count + 1;
            entity.CreatedAt = DateTime.Now;
            entity.ModifiedAt = DateTime.Now;
            entity.IsActive = true;
            context.Set<T>().Add(entity);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost("Edit")]
        public async Task<IActionResult> Edit(T entity)
        {
            int newPosition = entity.Position;
            entity.ModifiedAt = DateTime.Now;
            entity.IsActive = true;
            context.Set<T>().Update(entity);
            var entityFromDb = await context.Set<T>().AsNoTracking().FirstAsync(e => e.Id == entity.Id);
            if (entityFromDb != null)
            {
                if (entity.Position > entityFromDb.Position)
                {
                    var entitiesToUpdate = context.Set<T>()
                        .Where(e => e.Position <= newPosition && e.Position > entityFromDb.Position && e.Id != entity.Id)
                        .OrderBy(e => e.Position)
                        .ToList();
                    foreach (var e in entitiesToUpdate)
                    {
                        e.Position--; // Shift position down
                    }
                }
                else
                {
                    var entitiesToUpdate = context.Set<T>()
                        .Where(e => e.Position >= newPosition && e.Position < entityFromDb.Position && e.Id != entity.Id)
                        .OrderBy(e => e.Position)
                        .ToList();
                    foreach (var e in entitiesToUpdate)
                    {
                        e.Position++; // Shift position down
                    }
                }
            }
            context.Set<T>().Update(entity);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            var entity = context.Set<T>().Find(id);
            if (entity == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            else
            {
                int deletedPosition = entity.Position;
                context.Set<T>().Remove(entity);
                context.SaveChanges();
                var entitiesToUpdate = context.Set<T>()
                .Where(e => e.Position > deletedPosition)
                .OrderBy(e => e.Position)
                .ToList();
                foreach (var e in entitiesToUpdate)
                {
                    e.Position--; // Shift position up
                }
                context.SaveChanges();

                return Json(new { success = true, message = "Delete Successful" });
            }
        }

        [HttpGet("Edit")]
        public IActionResult Edit(int id)
        {
            var entity = context.Set<T>().FirstOrDefault(w => w.Id == id);
            return View(entity);
        }

        [HttpGet("Details")]
        public IActionResult Details(int id)
        {
            var entity = context.Set<T>().FirstOrDefault(w => w.Id == id);
            return View(entity);
        }

        //public IActionResult Delete(int id)
        //{
        //    var entity = context.Set<T>().FirstOrDefault(w => w.Id == id);
        //    return View(entity);
        //}

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var entities = context.Set<T>().ToList();
            return Json(new { data = entities });
        }
    }
}
