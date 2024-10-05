using DatabaseAPI.Models.Abstract;

namespace DatabaseAPI.Models.CinemaMovie.DictionaryModels
{
    public class MovieKeywords : DictionaryTable
    {
        public ICollection<Movie>? Movies { get; set; }

    }
}
