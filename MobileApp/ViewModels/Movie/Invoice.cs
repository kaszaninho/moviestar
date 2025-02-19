using System.Text.Json.Serialization;

namespace MobileApp.ViewModels.Movie
{
    public class Invoice
    {
        [JsonPropertyName("invoiceId")]
        public Guid InvoiceId { get; set; }
        [JsonPropertyName("orderStatus")]
        public string OrderStatus { get; set; }
        [JsonPropertyName("paymentStatus")]
        public string PaymentStatus { get; set; }
        [JsonPropertyName("totalSum")]
        public double TotalSum { get; set; }
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }
    }
}
