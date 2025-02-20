using DatabaseAPI.Models.CinemaMovie.DictionaryModels;
using DatabaseAPI.Repository;

namespace PortalWWW.Controllers.Admin.CinemaMovie.DictionaryTable
{
    public class MovieFormatController : BaseDictionaryController<MovieFormat>
    {
        public MovieFormatController(IRepository<MovieFormat> repository) : base(repository)
        {
        }
    }
}
