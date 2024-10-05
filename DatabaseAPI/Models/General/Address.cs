using DatabaseAPI.Models.Abstract;
using DatabaseAPI.Models.DictionaryModels;

namespace DatabaseAPI.Models.General
{
    public class Address : DictionaryTable
    {
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }
        public int? ApartmentNumber { get; set; }
        public string EirCode { get; set; }
        public string City { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }

    }
}
