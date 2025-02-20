using DatabaseAPI.Models.General;
using DatabaseAPI.Repository;

namespace PortalWWW.Controllers.Admin.General
{
    public class SubscriberController : BaseDictionaryController<Subscriber>
    {
        public SubscriberController(IRepository<Subscriber> repository) : base(repository)
        {
        }
    }
}
