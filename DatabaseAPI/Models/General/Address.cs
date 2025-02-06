using DatabaseAPI.Models.Abstract;
using DatabaseAPI.Models.DictionaryModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace DatabaseAPI.Models.General
{
    public class Address : DictionaryTable
    {
        [Display(Name = "Street Name")]
        public string StreetName { get; set; }
        [Display(Name = "House Number")]
        public int HouseNumber { get; set; }
        [Display(Name = "Apartment Number")]
        public int? ApartmentNumber { get; set; }
        public string EirCode { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public Country? Country { get; set; }
        public int CountryId { get; set; }
        public ICollection<OpeningHour> OpeningHour { get; set; }

    }
}
