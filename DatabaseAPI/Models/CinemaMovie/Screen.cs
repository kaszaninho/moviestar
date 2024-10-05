using DatabaseAPI.Models.Abstract;

namespace DatabaseAPI.Models.CinemaMovie
{
    // sala kinowa
    public class Screen : DictionaryTable
    {
        public ICollection<Seat>? Seats { get; set; }
        public int? RoomNumber { get; set; }
    }
}
