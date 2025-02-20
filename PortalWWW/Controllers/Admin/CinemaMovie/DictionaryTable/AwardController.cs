using DatabaseAPI.Models.CinemaMovie.DictionaryModels;
using DatabaseAPI.Repository;

namespace PortalWWW.Controllers.Admin.CinemaMovie.DictionaryTable
{
    public class AwardController : BaseDictionaryController<Award>
    {
        public AwardController(IRepository<Award> repository) : base(repository)
        {
        }
    }
}
