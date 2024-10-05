using DatabaseAPI.Models.Abstract;

namespace DatabaseAPI.Models.CinemaMovie
{
    public class Coupon : DictionaryTable
    {
        public DateTime? UsedAt { get; set; }
        // określenie użtycia - na co to jest
        public string CouponNumber { get; set; }
        public int Discount { get; set; } //discount w procentach
        public string MovieOrCafeUsage { get; set; } //okreslone jako "Movie" lub "Cafe"

    }
}
