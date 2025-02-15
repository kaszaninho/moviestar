using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.Invoice
{
    public class InvoiceResponse
    {
        [JsonPropertyName("invoiceId")]
        public string InvoiceId { get; set; }

        [JsonPropertyName("orderStatus")]
        public string OrderStatus { get; set; }

        [JsonPropertyName("paymentStatus")]
        public string PaymentStatus { get; set; }

        [JsonPropertyName("ticketSum")]
        public double TicketSum { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("coupon")]
        public string Coupon { get; set; }

        [JsonPropertyName("couponDiscount")]
        public object CouponDiscount { get; set; }

        [JsonPropertyName("totalSum")]
        public double TotalSum { get; set; }

        [JsonPropertyName("buyerAddress")]
        public AddressResponse Address { get; set; }

        [JsonPropertyName("tickets")]
        public List<TicketResponse> Tickets { get; set; }
    }
}
