using DatabaseAPI.Models.Abstract;

namespace DatabaseAPI.Models.CinemaMovie
{
    public class Seat : DictionaryTable
    {
        public int? Row { get; set; }
        public int? NumberInRow { get; set; }
        public int? ScreenId { get; set; }
        public Screen? Screen { get; set; }
    }
}
