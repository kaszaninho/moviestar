using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers.Admin.CinemaMovie
{
    public class CouponController : BaseDictionaryController<Coupon>
    {
        public CouponController(IRepository<Coupon> repository) : base(repository)
        { }

        public override Task<IActionResult> Create(Coupon entity)
        {
            return base.Create(entity);
        }
    }
}
