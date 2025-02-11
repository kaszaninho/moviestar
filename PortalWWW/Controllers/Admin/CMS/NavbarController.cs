using DatabaseAPI.Data;
using DatabaseAPI.Models.CMS;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers.Admin.CMS
{
    public class BottombarController : BaseCMSController<Bottombar>
    {
        public BottombarController(DatabaseAPIContext context) : base(context)
        {
        }
    }
}
