using DatabaseAPI.Models.Abstract;
using DatabaseAPI.Models.General;

namespace DatabaseAPI.Models.CinemaMovie
{
    public class Ticket : DictionaryTable
    {
        public Guid? InvoiceId { get; set; }
        public Invoice? Invoice { get; set; }
        public ScreeningSeat? ScreeningSeat { get; set; }
        public int? ScreeningSeatId { get; set; }
    }
}
