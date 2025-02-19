using DatabaseAPI.Models.Abstract;
using DatabaseAPI.Models.CinemaMovie;

namespace DatabaseAPI.Models.DictionaryModels
{
    public class Genre : DictionaryTable
    {
        public ICollection<Movie>? Movies { get; set; }
    }
}
