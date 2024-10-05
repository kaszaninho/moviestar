using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie.DictionaryModels;
using DatabaseAPI.Models.DictionaryModels;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PortalWWW.Controllers.Admin.CinemaMovie.DictionaryTable
{
    public class GenreController : BaseDictionaryController<Genre>
    {
        public GenreController(IRepository<Genre> repository) : base(repository)
        {
        }
    }
}
