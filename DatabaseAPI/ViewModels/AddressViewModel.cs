using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Models.General;

namespace DatabaseAPI.ViewModels
{
    public class AddressViewModel
    {
        public string? Street { get; set; }
        public string? Eircode { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
    }
}
