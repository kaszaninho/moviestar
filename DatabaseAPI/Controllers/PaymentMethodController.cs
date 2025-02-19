using DatabaseAPI.Data;
using DatabaseAPI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentMethodController : ControllerBase
    {
        private readonly DatabaseAPIContext _context;

        public PaymentMethodController(DatabaseAPIContext context)
        {
            _context = context;
        }

        // GET: api/paymentmethod
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaymentMethodViewModel>>> GetPaymentMethods()
        {
            var paymentMethods = await _context.PaymentMethod.Where(x => !x.Name.ToLower().Equals("stripe")).ToListAsync();

            if (paymentMethods == null || paymentMethods.Count() == 0)
            {
                return NotFound();
            }

            return paymentMethods.Select(x => new PaymentMethodViewModel
            {
                MethodId = x.Id,
                MethodName = x.Name
            }).ToList();
        }
    }
}
