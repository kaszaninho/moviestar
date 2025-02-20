using DatabaseAPI.Models.DictionaryModels;
using DatabaseAPI.Repository;

namespace PortalWWW.Controllers.Admin.CinemaMovie.DictionaryTable
{
    public class GenreController : BaseDictionaryController<Genre>
    {
        public GenreController(IRepository<Genre> repository) : base(repository)
        {
        }
    }
}
