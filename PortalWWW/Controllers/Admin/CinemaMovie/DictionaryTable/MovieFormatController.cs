using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie.DictionaryModels;
using DatabaseAPI.Models.DictionaryModels;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PortalWWW.Controllers.Admin.CinemaMovie.DictionaryTable
{
    public class MovieFormatController : BaseDictionaryController<MovieFormat>
    {
        public MovieFormatController(IRepository<MovieFormat> repository) : base(repository)
        {
        }
    }
}
