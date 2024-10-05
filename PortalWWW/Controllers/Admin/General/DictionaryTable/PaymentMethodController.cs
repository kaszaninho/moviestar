using DatabaseAPI.Models.DictionaryModels;
using DatabaseAPI.Models.General.DictionaryModels;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers.Admin.General.DictionaryTable
{
    public class PaymentMethodController : BaseDictionaryController<PaymentMethod>
    {
        public PaymentMethodController(IRepository<PaymentMethod> repository) : base(repository)
        {
        }
    }
}
