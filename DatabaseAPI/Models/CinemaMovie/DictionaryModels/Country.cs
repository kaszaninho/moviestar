using DatabaseAPI.Models.Abstract;
using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Models.People;

namespace DatabaseAPI.Models.DictionaryModels
{
    public class Country : DictionaryTable
    {
        public ICollection<Actor>? Actors { get; set; }
        public ICollection<Director>? Directors { get; set; }
        public ICollection<Movie>? Movies { get; set; }
    }
}
