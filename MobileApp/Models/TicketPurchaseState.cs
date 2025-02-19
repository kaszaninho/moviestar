namespace MobileApp.Models
{
    public class TicketPurchaseState
    {
        public int? ScreeningId { get; set; }
        public List<int> SelectedSeatIds { get; set; } = new();
        public string? CouponCode { get; set; }
        public int? CouponId { get; set; }
        public string? PaymentMethod { get; set; }
        public int? PaymentMethodId { get; set; }
        public decimal? TicketsPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? DiscountedPrice { get; set; }
    }
}