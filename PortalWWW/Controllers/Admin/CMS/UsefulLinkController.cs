using DatabaseAPI.Data;
using DatabaseAPI.Models.CMS;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers.Admin.CMS
{
    public class UsefulLinkController : BaseCMSController<UsefulLink>
    {
        public UsefulLinkController(DatabaseAPIContext context) : base(context)
        {
        }
    }
}
