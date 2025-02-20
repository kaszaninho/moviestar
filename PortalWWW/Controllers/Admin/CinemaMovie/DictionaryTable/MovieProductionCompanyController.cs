using DatabaseAPI.Models.CinemaMovie.DictionaryModels;
using DatabaseAPI.Repository;

namespace PortalWWW.Controllers.Admin.CinemaMovie.DictionaryTable
{
    public class MovieProductionCompanyController : BaseDictionaryController<MovieProductionCompany>
    {
        public MovieProductionCompanyController(IRepository<MovieProductionCompany> repository) : base(repository)
        {
        }
    }
}
