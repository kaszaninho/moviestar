using DatabaseAPI.Models.Abstract;

namespace DatabaseAPI.Models.CinemaMovie.DictionaryModels
{
    public class Subtitles : DictionaryTable
    {
        public ICollection<Movie>? Movies { get; set; }
    }
}
