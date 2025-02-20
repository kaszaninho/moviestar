using DatabaseAPI.Models.Abstract;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers
{
    [Route("[controller]")]
    public abstract class BaseDictionaryController<T> : Controller where T : BaseDatatable
    {
        protected readonly IRepository<T> repository;

        protected BaseDictionaryController(IRepository<T> repository)
        {
            this.repository = repository;
        }

        [HttpGet("Index")]
        virtual public async Task<IActionResult> Index()
        {
            var entities = await repository.GetEntityListAsync();
            ViewData["type"] = typeof(T);

            return View(entities.ToList());
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<T> entities = repository.GetEntityList().ToList();
            return Json(new { data = entities });
        }

        [HttpGet("Details")]
        virtual public async Task<IActionResult> Details(int id)
        {
            var entity = await repository.FindEntityAsync(id);
            ViewData["type"] = typeof(T);

            return View(entity);
        }



        [HttpGet("Create")]
        virtual public async Task<IActionResult> Create()
        {
            ViewData["type"] = typeof(T);
            return View();
        }

        [HttpGet("Edit")]
        virtual public async Task<IActionResult> Edit(int id)
        {
            var entity = await repository.FindEntityAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            ViewData["type"] = typeof(T);
            return View(entity);
        }

        [HttpPost("DeleteConfirmed")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await repository.DeleteEntityAsync(id);
            TempData["SuccessMessage"] = "Record deleted successfully!";
            return RedirectToAction(nameof(Index));
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



        [HttpPost("EditConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditConfirmed(T entity)
        {
            if (!ModelState.IsValid)
            {
                ViewData["type"] = typeof(T);
                return RedirectToAction(nameof(Edit), entity);
            }
            entity.ModifiedAt = DateTime.Now;
            await repository.UpdateEntityAsync(entity);
            TempData["SuccessMessage"] = "Record updated successfully!";
            return RedirectToAction(nameof(Index));
        }

        [HttpPost("CreateConfirmed")]
        virtual public async Task<IActionResult> CreateConfirmed(T entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.ModifiedAt = DateTime.Now;
            await repository.AddEntityAsync(entity);
            TempData["SuccessMessage"] = "Record created successfully!";
            return RedirectToAction("Index");
        }
    }
}
