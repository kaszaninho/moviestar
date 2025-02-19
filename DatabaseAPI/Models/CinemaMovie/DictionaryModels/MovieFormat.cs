using DatabaseAPI.Models.Abstract;

namespace DatabaseAPI.Models.CinemaMovie.DictionaryModels
{
    public class MovieFormat : DictionaryTable
    {
        public ICollection<Movie>? Movies { get; set; }
    }
}
