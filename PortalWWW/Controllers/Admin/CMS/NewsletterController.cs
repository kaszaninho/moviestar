using DatabaseAPI.Data;
using DatabaseAPI.Models.CMS;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers.Admin.CMS
{
    public class NewsletterController : BaseCMSController<Newsletter>
    {
        public NewsletterController(DatabaseAPIContext context) : base(context)
        {
        }
    }
}
