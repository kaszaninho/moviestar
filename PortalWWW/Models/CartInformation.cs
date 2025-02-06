using DatabaseAPI.Models.CinemaMovie;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalWWW.Models
{
    public class CartInformation
    {
        public List<CartElement>? CartElements { get; set; }
        public decimal? PriceTotal { get; set; }
        public int? CouponId { get; set; }
        public Coupon? Coupon { get; set; }
        [NotMapped]
        public string? PaymentMethod { get; set; }
        [NotMapped]
        public decimal? CouponDiscount { get; set; }

    }
}
