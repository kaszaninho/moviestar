using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers.Admin.CinemaMovie
{
    public class TicketController : BaseDictionaryController<Ticket>
    {
        public TicketController(IRepository<Ticket> repository) : base(repository)
        {
        }
    }
}
