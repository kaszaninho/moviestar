using DatabaseAPI.Models.CinemaMovie.DictionaryModels;
using DatabaseAPI.Repository;

namespace PortalWWW.Controllers.Admin.CinemaMovie.DictionaryTable
{
    public class SubtitlesController : BaseDictionaryController<Subtitles>
    {
        public SubtitlesController(IRepository<Subtitles> repository) : base(repository)
        {
        }
    }
}
