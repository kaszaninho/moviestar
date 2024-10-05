using DatabaseAPI.Models.General;
using DatabaseAPI.Repository;

namespace PortalWWW.Controllers.Admin.General
{
    public class BankAccountController : BaseDictionaryController<BankAccount>
    {
        public BankAccountController(IRepository<BankAccount> repository) : base(repository)
        {
        }
    }
}
