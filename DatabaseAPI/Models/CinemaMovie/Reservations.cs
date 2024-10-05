using DatabaseAPI.Models.Abstract;
using DatabaseAPI.Models.People;

namespace DatabaseAPI.Models.CinemaMovie
{
    public class Reservations : DictionaryTable
    {
        public Screening? Screening { get; set; }
        public int? ScreeningId { get; set; }
        public Seat? Seat { get; set; }
        public int? SeatId { get; set; }
        public long? ReservationNumber { get; set; }
        public bool IsRealized { get; set; } = false;
        public bool IsExpired { get; set; } = false;
        public User? User { get; set; }
        public string? UserId { get; set; }
    }
}
