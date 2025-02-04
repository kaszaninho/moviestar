using DatabaseAPI.Models.Abstract;
using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Models.General.DictionaryModels;
using DatabaseAPI.Models.People;

namespace DatabaseAPI.Models.General
{
    public class Invoice : DictionaryTable
    {
        public Guid InvoiceId { get; set; }
        public ICollection<Ticket>? Tickets { get; set; }
        public PaymentMethod? PaymentMethod { get; set; }
        public int? PaymentMethodId { get; set; }
        public User? User { get; set; }
        public string? UserId { get; set; }
        public decimal? TicketSum { get; set; }
        public string? OrderStatus { get; set; }
        public string? PaymentStatus { get; set; }
        public string? StripeSessionId { get; set; }
        public string? StripePaymentIntentId { get; set; }
        public int? CouponId { get; set; }
        public Coupon? Coupon { get; set; }
        public decimal? CouponDiscount { get; set; }
        public decimal? TotalSum { get; set; }
    }
}
