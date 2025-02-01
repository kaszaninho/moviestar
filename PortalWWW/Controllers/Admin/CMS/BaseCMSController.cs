using DatabaseAPI.Data;
using DatabaseAPI.Models.Abstract;
using DatabaseAPI.Models.CMS;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers.Admin.CMS
{
    public class BaseCMSController<T> : Controller  where T : AbstractCMSDatatable
    {

        private readonly DatabaseAPIContext context;

        public BaseCMSController(DatabaseAPIContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(T entity)
        {
            entity.Position = context.Set<T>().ToList().Count + 1;
            context.Set<T>().Add(entity);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(T entity)
        {
            int newPosition = entity.Position;
            context.Set<T>().Update(entity);
            context.SaveChanges(); 
            var entitiesToUpdate = context.Set<T>()
                .Where(e => e.Position >= newPosition && e.Id != entity.Id)
                .OrderBy(e => e.Position)
                .ToList();
            foreach (var e in entitiesToUpdate)
            {
                e.Position++; // Shift position down
            }
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var entity = context.Set<T>().Find(id);
            if (entity != null)
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

            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var entity = context.Set<T>().FirstOrDefault(w => w.Id == id);
            return View(entity);
        }

        public IActionResult Details(int id)
        {
            var entity = context.Set<T>().FirstOrDefault(w => w.Id == id);
            return View(entity);
        }

        public IActionResult Delete(int id)
        {
            var entity = context.Set<T>().FirstOrDefault(w => w.Id == id);
            return View(entity);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var entities = context.Set<T>().ToList();
            return Json(new { data = entities });
        }
    }
}
