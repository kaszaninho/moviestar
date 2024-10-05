using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers.Admin.CinemaMovie
{
    public class ScreenController : BaseDictionaryController<Screen>
    {
        public ScreenController(IRepository<Screen> repository) : base(repository)
        {
        }
    }
}
