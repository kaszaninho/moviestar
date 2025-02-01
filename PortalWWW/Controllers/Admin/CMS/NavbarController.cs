using DatabaseAPI.Data;
using DatabaseAPI.Models.CMS;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers.Admin.CMS
{
    public class TopbarController : BaseCMSController<Topbar>
    {
        public TopbarController(DatabaseAPIContext context) : base(context)
        {
        }
    }
}
