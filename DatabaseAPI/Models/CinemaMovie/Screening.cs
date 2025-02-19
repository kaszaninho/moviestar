using DatabaseAPI.Models.Abstract;

namespace DatabaseAPI.Models.CinemaMovie
{
    // seans
    public class Screening : DictionaryTable
    {
        public int? ScreenId { get; set; }
        public Screen? Screen { get; set; }
        public int? MovieId { get; set; }
        public Movie? Movie { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public ICollection<ScreeningSeat> ScreeningSeats { get; set; }
    }
}
