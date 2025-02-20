using DatabaseAPI.Models.General;
using DatabaseAPI.Repository;

namespace PortalWWW.Controllers.Admin.General
{
    public class OpeningHourController : BaseDictionaryController<OpeningHour>
    {
        public OpeningHourController(IRepository<OpeningHour> repository) : base(repository)
        {
        }
    }
}
