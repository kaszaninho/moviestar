using DatabaseAPI.Models.Abstract;

namespace DatabaseAPI.Models.CinemaMovie.DictionaryModels
{
    public class MovieProductionCompany : DictionaryTable
    {
        public ICollection<Movie>? Movies { get; set; }
    }
}
