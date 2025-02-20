using DatabaseAPI.Data;
using DatabaseAPI.Models.CMS;

namespace PortalWWW.Controllers.Admin.CMS
{
    public class ContactInformationController : BaseCMSController<ContactInformation>
    {
        public ContactInformationController(DatabaseAPIContext context) : base(context)
        {
        }
    }
}
