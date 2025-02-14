using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace PortalWWW.Controllers.Admin.CinemaMovie
{
    public class TicketController : BaseDictionaryController<Ticket>
    {
        public TicketController(IRepository<Ticket> repository) : base(repository)
        {
        }
        override public async Task<IActionResult> Index()
        {
            var entities = await repository.getDbSet()
                .Include(ticket => ticket.ScreeningSeat)
                    .ThenInclude(screeningSeat => screeningSeat.Seat)
                .Include(ticket => ticket.ScreeningSeat)
                    .ThenInclude(screeningSeat => screeningSeat.Screening)
                    .ThenInclude(screening => screening.Movie)
                .Include(ticket => ticket.Invoice)
                    .ThenInclude(invoice => invoice.User)
                .ToListAsync();
            ViewData["type"] = typeof(Ticket);
            return View(entities);
        }

        override public async Task<IActionResult> CreateConfirmed(Ticket entity)
        {
            return await base.CreateConfirmed(entity);
        }

        override public async Task<IActionResult> Create()
        {
            var listOfScreeningSeats = await repository.GetDbSet<ScreeningSeat>()
                .Include(screeningSeat => screeningSeat.Seat)
                .Include(screeningSeat => screeningSeat.Screening)
                .ThenInclude(screening => screening.Movie)
                .ToListAsync();
            var listForBag = listOfScreeningSeats.Select(seat => new
            {
                seat.Id,
                Name = seat.Screening.Movie.Name + " - " + seat.Seat.Name
            }).ToList();
            ViewBag.ScreeningSeat = new SelectList(listForBag, "Id", "Name");
            ViewData["type"] = typeof(Ticket);
            ViewData["PartialViewName"] = "TicketCreate";
            return View();
        }

        override public async Task<IActionResult> Edit(int id)
        {
            var entity = await repository.FindEntityAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            var listOfScreeningSeats = await repository.GetDbSet<ScreeningSeat>()
                .Include(screeningSeat => screeningSeat.Seat)
                .Include(screeningSeat => screeningSeat.Screening)
                .ThenInclude(screening => screening.Movie)
                .Where(screeningseat => !screeningseat.IsTaken ?? false)
                .ToListAsync();
            var listForBag = listOfScreeningSeats.Select(seat => new
            {
                seat.Id,
                Name = seat.Screening.Movie.Name + " - " + seat.Seat.Name
            }).ToList();
            ViewBag.ScreeningSeat = new SelectList(listForBag, "Id", "Name");
            ViewData["type"] = typeof(Ticket);
            ViewData["PartialViewName"] = "TicketCreate";
            return View(entity);
        }

        override public async Task<IActionResult> Details(int id)
        {
            var entity = await repository.getDbSet()
                .Include(ticket => ticket.ScreeningSeat)
                .Include(ticket => ticket.Invoice)
                .FirstAsync(ticket => ticket.Id == id);
            if (entity == null)
            {
                return NotFound();
            }
            ViewData["type"] = typeof(Ticket);
            ViewData["PartialViewName"] = "TicketDetails";
            return View(entity);
        }
    }
}
