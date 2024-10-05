using DatabaseAPI.Models.Abstract;
using DatabaseAPI.Models.People;

namespace DatabaseAPI.Models.CinemaMovie.DictionaryModels
{
    public class Award : DictionaryTable
    {
        public ICollection<Movie>? Movies { get; set; }
        public ICollection<Actor>? Actors { get; set; }
        public ICollection<Director>? Directors { get; set; }
    }
}
