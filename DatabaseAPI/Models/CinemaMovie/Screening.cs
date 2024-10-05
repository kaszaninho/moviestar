using DatabaseAPI.Models.Abstract;

namespace DatabaseAPI.Models.CinemaMovie
{
    public class Screening : DictionaryTable
    {
        public Screen? Screen { get; set; }
        public int? ScreenId { get; set; }
        public Movie? Movie { get; set; }
        public int? MovieId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public ICollection<ScreeningSeat> ScreeningSeats { get; set; }
    }
}
