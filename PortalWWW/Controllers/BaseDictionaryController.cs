﻿using DatabaseAPI.Data;
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

        [HttpGet]
        public IActionResult GetAll()
        {
            List<T> entities = repository.GetEntityList().ToList();
            return Json(new { data = entities });
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
            entity.CreatedAt = DateTime.Now;
            entity.ModifiedAt = DateTime.Now;
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
            entity.ModifiedAt = DateTime.Now;
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
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await repository.DeleteEntityAsync(id);
            return RedirectToAction(nameof(Index));
        }

        //[HttpDelete]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var entity = repository.FindEntityAsync(id);
        //    if (entity == null)
        //    {
        //        return Json(new { success = false, message = "Error while deleting" });
        //    }

        //    await repository.DeleteEntityAsync(id);

        //    return Json(new { success = true, message = "Delete Successful" });
        //}
    }
}
