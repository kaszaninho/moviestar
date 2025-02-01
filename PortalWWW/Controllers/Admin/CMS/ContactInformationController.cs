using DatabaseAPI.Data;
using DatabaseAPI.Models.CMS;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers.Admin.CMS
{
    public class ContactInformationController : BaseCMSController<ContactInformation>
    {
        public ContactInformationController(DatabaseAPIContext context) : base(context)
        {
        }
    }
}
