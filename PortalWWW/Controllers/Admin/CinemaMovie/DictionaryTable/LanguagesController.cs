using DatabaseAPI.Models.CinemaMovie.DictionaryModels;
using DatabaseAPI.Repository;

namespace PortalWWW.Controllers.Admin.CinemaMovie.DictionaryTable
{
    public class LanguagesController : BaseDictionaryController<Languages>
    {
        public LanguagesController(IRepository<Languages> repository) : base(repository)
        {
        }
    }
}
