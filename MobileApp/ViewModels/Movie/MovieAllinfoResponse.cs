using MobileApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.Movie
{
    public class MovieAllinfoResponse
    {
        [JsonPropertyName("earliestScreeningsWithMovies")]
        public IEnumerable<Screening> EarliestScreeningsWithMovies { get; set; }

        [JsonPropertyName("latestInvoiceWithTickets")]
        public Invoice LatestInvoiceWithTickets { get; set; }
    }

    public class Screening
    {
        [JsonPropertyName("startDate")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("endDate")]
        public DateTime EndDate { get; set; }

        [JsonPropertyName("movieTitle")]
        public string MovieTitle { get; set; }

        [JsonPropertyName("movieId")]
        public int MovieId { get; set; }

        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }
        public string FullImageUrl => AppSettings.IMAGE_BASE_URL + ImageUrl.Replace('\\','/');
    }




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
