using DatabaseAPI.Data;
using DatabaseAPI.Models.CMS;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers.Admin.CMS
{
    public class NavbarController : BaseCMSController<Navbar>
    {
        public NavbarController(DatabaseAPIContext context) : base(context)
        {
        }
    }
}
