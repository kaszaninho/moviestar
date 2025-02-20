using System.ComponentModel.DataAnnotations;

namespace PortalWWW.Models
{
    public class UserViewModel
    {
        public string Id { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name (optional)")]
        public string? MiddleName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Display(Name = "StreetName")]
        public string StreetName { get; set; }

        [Required]
        [Display(Name = "House Number")]
        public int HouseNumber { get; set; }

        [Display(Name = "Apartment Number (optional)")]
        public int? ApartmentNumber { get; set; }

        [Required]
        [Display(Name = "EirCode")]
        public string EirCode { get; set; }

        [Required]
        [Display(Name = "City")]
        public string City { get; set; }


        [Display(Name = "Country")]
        public int CountryId { get; set; }
    }
}
