using DatabaseAPI.Models.Abstract;

namespace DatabaseAPI.Models.CinemaMovie.DictionaryModels
{
    public class Languages : DictionaryTable
    {
        public ICollection<Movie>? Movies { get; set; }

    }
}
