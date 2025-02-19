using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.Coupon
{
    public class CouponResponse
    {
        [JsonPropertyName("couponName")]
        public string? CouponName { get; set; }
        [JsonPropertyName("couponId")]
        public int? CouponId {  get; set; } 
        [JsonPropertyName("discount")]
        public int? Discount { get; set; }
    }
}
