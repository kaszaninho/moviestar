using DatabaseAPI.Models.Abstract;
using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Models.DictionaryModels;

namespace DatabaseAPI.Models.People
{
    public class Actor : DictionaryTable
    {
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Country? Country { get; set; }
        public int? CountryId { get; set; }
        public ICollection<Movie>? Movies { get; set; }
    }
}
