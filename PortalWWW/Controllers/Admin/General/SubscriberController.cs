using DatabaseAPI.Models.General;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers.Admin.General
{
    public class SubscriberController : BaseDictionaryController<Subscriber>
    {
        public SubscriberController(IRepository<Subscriber> repository) : base(repository)
        {
        }
    }
}
