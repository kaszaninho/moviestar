namespace DatabaseAPI.ViewModels
{
    public class MiniInvoiceViewModel
    {
        public Guid InvoiceId { get; set; }
        public string? OrderStatus { get; set; }
        public string? PaymentStatus { get; set; }
        public decimal? TotalSum { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
