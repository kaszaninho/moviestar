using DatabaseAPI.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers.Admin.CMS
{
    public class WebsiteController : Controller
    {
        private readonly DatabaseAPIContext context;

        public WebsiteController(DatabaseAPIContext context)
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
        public IActionResult Create(DatabaseAPI.Models.CMS.Website page)
        {
            context.Website.Add(page);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(DatabaseAPI.Models.CMS.Website page)
        {
            context.Website.Update(page);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var website = context.Website.Find(id);
            if (website != null)
            {
                context.Website.Remove(website);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var entity = context.Website.FirstOrDefault(w => w.Id == id);
            return View(entity);
        }

        public IActionResult Details(int id)
        {
            var entity = context.Website.FirstOrDefault(w => w.Id == id);
            return View(entity);
        }

        public IActionResult Delete(int id)
        {
            var entity = context.Website.FirstOrDefault(w => w.Id == id);
            return View(entity);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var entities = context.Website.ToList();
            return Json(new { data = entities });
        }
    }
}
