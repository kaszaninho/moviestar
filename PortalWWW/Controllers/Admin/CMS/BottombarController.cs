using DatabaseAPI.Data;
using DatabaseAPI.Models.CMS;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers.Admin.CMS
{
    public class BottomBarontroller : BaseCMSController<Bottombar>
    {
        public BottomBarontroller(DatabaseAPIContext context) : base(context)
        {
        }
    }
}
