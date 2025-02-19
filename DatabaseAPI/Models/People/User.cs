using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Models.General;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseAPI.Models.People
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address Address { get; set; }
        public int AddressId { get; set; }
        public UserLevel UserLevel { get; set; }
        public int UserLevelId { get; set; }
        public int UserProgressToNextLevel { get; set; }
        public List<Movie> FavouriteMovies { get; set; }
        public List<Actor> FavouriteActors { get; set; }
        [NotMapped]
        public string? Role { get; set; }
    }
}
