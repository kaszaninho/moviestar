using DatabaseAPI.Models.Abstract;
using DatabaseAPI.Models.DictionaryModels;
using DatabaseAPI.Models.General;

namespace DatabaseAPI.Models.People
{
    public class Director : DictionaryTable
    {
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
        public string? ImageUrl { get; set; }

    }
}
