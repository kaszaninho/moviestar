using System.Text.Json.Serialization;

namespace MobileApp.ViewModels.Coupon
{
    public class CouponResponse
    {
        [JsonPropertyName("couponName")]
        public string? CouponName { get; set; }
        [JsonPropertyName("couponId")]
        public int? CouponId { get; set; }
        [JsonPropertyName("discount")]
        public int? Discount { get; set; }
    }
}
