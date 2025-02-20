using DatabaseAPI.Models.DictionaryModels;
using DatabaseAPI.Repository;

namespace PortalWWW.Controllers.Admin.CinemaMovie.DictionaryTable
{
    public class CountryController : BaseDictionaryController<Country>
    {
        public CountryController(IRepository<Country> repository) : base(repository)
        {
        }
    }
}
