using DatabaseAPI.Models.DictionaryModels;
using DatabaseAPI.Repository;

namespace PortalWWW.Controllers.Admin.CinemaMovie.DictionaryTable
{
    public class AgeRatingController : BaseDictionaryController<AgeRating>
    {
        public AgeRatingController(IRepository<AgeRating> repository) : base(repository)
        {
        }
    }
}
