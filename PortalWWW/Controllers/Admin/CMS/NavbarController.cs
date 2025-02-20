using DatabaseAPI.Data;
using DatabaseAPI.Models.CMS;

namespace PortalWWW.Controllers.Admin.CMS
{
    public class NavbarController : BaseCMSController<Navbar>
    {
        public NavbarController(DatabaseAPIContext context) : base(context)
        {
        }
    }
}
