using DatabaseAPI.Data;
using DatabaseAPI.Models.Abstract;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace PortalWWW.Controllers
{
    public abstract class BaseDictionaryController<T> : Controller where T : BaseDatatable
    {
        protected readonly IRepository<T> repository;

        protected BaseDictionaryController(IRepository<T> repository)
        {
            this.repository = repository;
        }

        virtual public async Task<IActionResult> Index()
        {
            var entities = await repository.GetEntityListAsync();
            ViewData["type"] = typeof(T);

            return View(entities.ToList());
        }

        virtual public async Task<IActionResult> Details(int id)
        {
            var entity = await repository.FindEntityAsync(id);
            ViewData["type"] = typeof(T);

            return View(entity);
        }


        [HttpPost]
        virtual public async Task<IActionResult> Create(T entity)
        {
            await repository.AddEntityAsync(entity);
            return RedirectToAction("Index");
        }

        virtual public async Task<IActionResult> Create()
        {
            ViewData["type"] = typeof(T);
            return View();
        }

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(T entity)
        {
            if (!ModelState.IsValid)
            {
                ViewData["type"] = typeof(T);
                return View(entity);
            }
            await repository.UpdateEntityAsync(entity);
            return RedirectToAction(nameof(Index));
        }

        virtual public async Task<IActionResult> Delete(int id)
        {
            var entity = await repository.FindEntityAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            ViewData["type"] = typeof(T);
            return View(entity);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await repository.DeleteEntityAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }

}
