namespace DatabaseAPI.ViewModels
{

    public class InvoiceViewModel
    {
        public Guid InvoiceId { get; set; }
        public string? OrderStatus { get; set; }
        public string? PaymentStatus { get; set; }
        public decimal? TicketSum { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? Coupon { get; set; }
        public decimal? CouponDiscount { get; set; }
        public decimal? TotalSum { get; set; }
        public AddressViewModel? BuyerAddress { get; set; }
        public IEnumerable<TicketViewModel> Tickets { get; set; }
    }
}
