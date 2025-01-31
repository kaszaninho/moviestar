using DatabaseAPI.Models.People;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PortalWWW.Models
{
    public class RoleManagementVM
    {
        public User User { get; set; }
        public IEnumerable<SelectListItem> RoleList { get; set; }
    }
}
