using DatabaseAPI.Data;
using DatabaseAPI.Models.DictionaryModels;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PortalWWW.Controllers.Admin.CinemaMovie.DictionaryTable
{
    public class AgeRatingController : BaseDictionaryController<AgeRating>
    {
        public AgeRatingController(IRepository<AgeRating> repository) : base(repository)
        {
        }
    }
}
