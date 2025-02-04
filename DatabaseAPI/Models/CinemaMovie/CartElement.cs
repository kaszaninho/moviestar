using DatabaseAPI.Models.Abstract;

namespace DatabaseAPI.Models.CinemaMovie
{
    public class CartElement : BaseDatatable
    {
        public string SessionId { get; set; }
        public int? ScreeningSeatId { get; set; }
        public ScreeningSeat? ScreeningSeat { get; set; }
        public int? CouponId { get; set; }
        public Coupon? Coupon { get; set; }
    }
}
