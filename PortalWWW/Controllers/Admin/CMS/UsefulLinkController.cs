using DatabaseAPI.Data;
using DatabaseAPI.Models.CMS;

namespace PortalWWW.Controllers.Admin.CMS
{
    public class UsefulLinkController : BaseCMSController<UsefulLink>
    {
        public UsefulLinkController(DatabaseAPIContext context) : base(context)
        {
        }
    }
}
