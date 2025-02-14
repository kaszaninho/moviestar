using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Repository;
using DatabaseAPI.Models.CinemaMovie.DictionaryModels;
using DatabaseAPI.Models.DictionaryModels;

namespace PortalWWW.Controllers.Admin.CinemaMovie
{
    public class MovieReviewController : BaseDictionaryController<MovieReview>
    {
        public MovieReviewController(IRepository<MovieReview> repository) : base(repository)
        {
        }


        override public async Task<IActionResult> Index()
        {
            var entities = await repository.getDbSet()
                .Include(movieReview => movieReview.Movie)
                .ToListAsync();
            ViewData["type"] = typeof(MovieReview);
            return View(entities);
        }

        override public async Task<IActionResult> Create()
        {
            ViewBag.Movie = new SelectList(await repository.GetDbSet<Movie>().ToListAsync(), "Id", "Name");
            ViewData["type"] = typeof(MovieReview);
            ViewData["PartialViewName"] = "MovieReviewCreate";
            return View();
        }

        override public async Task<IActionResult> Edit(int id)
        {
            var entity = await repository.FindEntityAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            ViewBag.Movie = new SelectList(await repository.GetDbSet<Movie>().ToListAsync(), "Id", "Name");
            ViewData["type"] = typeof(MovieReview);
            ViewData["PartialViewName"] = "MovieReviewCreate";
            return View(entity);
        }

        override public async Task<IActionResult> Details(int id)
        {
            var entity = await repository.getDbSet()
                .Include(movieReview => movieReview.Movie)
                .FirstAsync(movieReview => movieReview.Id == id);
            if (entity == null)
            {
                return NotFound();
            }
            ViewData["type"] = typeof(MovieReview);
            ViewData["PartialViewName"] = "MovieReviewDetails";
            return View(entity);
        }
    }
}
