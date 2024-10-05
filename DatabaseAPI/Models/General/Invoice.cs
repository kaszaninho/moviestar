using DatabaseAPI.Models.Abstract;
using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Models.General.DictionaryModels;
using DatabaseAPI.Models.People;

namespace DatabaseAPI.Models.General
{
    public class Invoice : DictionaryTable
    {
        public Guid? InvoiceId { get; set; }
        public ICollection<Ticket>? Tickets { get; set; }
        public PaymentMethod? PaymentMethod { get; set; }
        public int? PaymentMethodId { get; set; }
        public User? User { get; set; }
        public string? UserId { get; set; }
        public decimal? Sum { get; set; }

    }
}
