using DatabaseAPI.Models.Abstract;
using DatabaseAPI.Models.General;
using DatabaseAPI.Models.People;

namespace DatabaseAPI.Models.CinemaMovie
{
    public class Ticket : BaseDatatable
    {
        public string? MovieName { get; set; }
        public DateTime? StartDate { get; set; }
        public int? RoomNumber { get; set; }
        public string? seatCode { get; set; }
        public string? UserName { get; set; }
        public Guid? InvoiceId { get; set; }
        public Invoice? Invoice { get; set; }
    }
}
