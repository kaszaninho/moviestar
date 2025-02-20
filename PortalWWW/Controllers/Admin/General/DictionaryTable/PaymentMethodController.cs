using DatabaseAPI.Models.General.DictionaryModels;
using DatabaseAPI.Repository;

namespace PortalWWW.Controllers.Admin.General.DictionaryTable
{
    public class PaymentMethodController : BaseDictionaryController<PaymentMethod>
    {
        public PaymentMethodController(IRepository<PaymentMethod> repository) : base(repository)
        {
        }
    }
}
