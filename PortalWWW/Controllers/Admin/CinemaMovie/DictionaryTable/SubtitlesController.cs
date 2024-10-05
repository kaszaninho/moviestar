using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie.DictionaryModels;
using DatabaseAPI.Models.DictionaryModels;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PortalWWW.Controllers.Admin.CinemaMovie.DictionaryTable
{
    public class SubtitlesController : BaseDictionaryController<Subtitles>
    {
        public SubtitlesController(IRepository<Subtitles> repository) : base(repository)
        {
        }
    }
}
