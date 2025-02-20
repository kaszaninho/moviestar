using DatabaseAPI.Data;
using DatabaseAPI.Models.CMS;

namespace PortalWWW.Controllers.Admin.CMS
{
    public class NewsletterController : BaseCMSController<Newsletter>
    {
        public NewsletterController(DatabaseAPIContext context) : base(context)
        {
        }
    }
}
