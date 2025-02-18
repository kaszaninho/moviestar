using DatabaseAPI.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers.Admin.CMS
{
    [Route("[controller]")]
    public class WebsiteController : Controller
    {
        private readonly DatabaseAPIContext context;

        public WebsiteController(DatabaseAPIContext context)
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
        public IActionResult Create(DatabaseAPI.Models.CMS.Website page)
        {
            context.Website.Add(page);
            context.SaveChanges();
            TempData["SuccessMessage"] = "Record created successfully!";
            return RedirectToAction("Index");
        }

        [HttpPost("Edit")]
        public IActionResult Edit(DatabaseAPI.Models.CMS.Website page)
        {
            context.Website.Update(page);
            context.SaveChanges();
            TempData["SuccessMessage"] = "Record updated successfully!";
            return RedirectToAction("Index");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var entity = context.Website.Find(id);
            if (entity == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            else
            {
                context.Website.Remove(entity);
                context.SaveChanges();

                return Json(new { success = true, message = "Delete Successful" });
            }
        }
        [HttpGet("Edit")]
        public IActionResult Edit(int id)
        {
            var entity = context.Website.FirstOrDefault(w => w.Id == id);
            return View(entity);
        }

        [HttpGet("Details")]
        public IActionResult Details(int id)
        {
            var entity = context.Website.FirstOrDefault(w => w.Id == id);
            return View(entity);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var entities = context.Website.ToList();
            return Json(new { data = entities });
        }
        [HttpGet("More")]
        public IActionResult More(int id)
        {
            var entity = context.Website.FirstOrDefault(w => w.Id == id);
            if (entity == null)
            {
                return NotFound();
            }

            ViewBag.WebsiteList = context.Website.ToList(); // Przekazanie listy do ViewBag
            return View(entity); // Przekazanie modelu do widoku
        }

    }
}
