using DatabaseAPI.Data;
using DatabaseAPI.Models.DictionaryModels;
using DatabaseAPI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponController : ControllerBase
    {
        private readonly DatabaseAPIContext _context;

        public CouponController(DatabaseAPIContext context)
        {
            _context = context;
        }


        // GET: api/Coupon/MOVIE5
        [HttpGet("{name}")]
        public async Task<ActionResult<CouponViewModel>> GetCoupon(string name)
        {
            var coupon = _context.Coupon.First(x => x.Name == name);

            if (coupon == null)
            {
                return NotFound();
            }

            return new CouponViewModel
            {
                CouponId = coupon.Id,
                CouponName = coupon.Name,
                Discount = coupon.Discount,
            };
        }
    }
}
