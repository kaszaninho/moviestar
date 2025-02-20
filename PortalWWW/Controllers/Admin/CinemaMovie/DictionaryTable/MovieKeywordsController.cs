using DatabaseAPI.Models.CinemaMovie.DictionaryModels;
using DatabaseAPI.Repository;

namespace PortalWWW.Controllers.Admin.CinemaMovie.DictionaryTable
{
    public class MovieKeywordsController : BaseDictionaryController<MovieKeywords>
    {
        public MovieKeywordsController(IRepository<MovieKeywords> repository) : base(repository)
        {
        }
    }
}
