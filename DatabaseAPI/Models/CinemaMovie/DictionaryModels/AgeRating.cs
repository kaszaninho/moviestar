using DatabaseAPI.Models.Abstract;
using DatabaseAPI.Models.CinemaMovie;

namespace DatabaseAPI.Models.DictionaryModels
{
    public class AgeRating : DictionaryTable
    {
        public ICollection<Movie>? Movies { get; set; }
    }
}
