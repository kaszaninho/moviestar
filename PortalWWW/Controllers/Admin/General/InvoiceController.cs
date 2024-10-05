using DatabaseAPI.Models.General;
using DatabaseAPI.Repository;

namespace PortalWWW.Controllers.Admin.General
{
    public class InvoiceController : BaseDictionaryController<Invoice>
    {
        public InvoiceController(IRepository<Invoice> repository) : base(repository)
        {
        }
    }
}
