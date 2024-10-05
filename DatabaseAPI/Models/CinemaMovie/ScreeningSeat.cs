using DatabaseAPI.Models.Abstract;

namespace DatabaseAPI.Models.CinemaMovie
{
    public class ScreeningSeat : DictionaryTable
    {
        // taken from seat - row letter / number in row - it'll be Name for a ScreeningSeat
        public int? ScreeningId { get; set; }
        public Screening? Screening { get; set; }
        public bool? IsTaken { get; set; }
    }
}
