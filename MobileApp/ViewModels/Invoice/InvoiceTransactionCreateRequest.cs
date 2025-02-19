namespace MobileApp.ViewModels.Invoice
{
    public class InvoiceTransactionCreateRequest
    {
        public Guid InvoiceId { get; set; }
        public ICollection<int>? ScreeningSeatIds { get; set; }
        public int? PaymentMethodId { get; set; }
        public string? UserId { get; set; }
        public decimal? TicketSum { get; set; }
        public int? CouponId { get; set; }
        public decimal? CouponDiscount { get; set; }
        public decimal? TotalSum { get; set; }
    }

}
