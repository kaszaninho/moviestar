using DatabaseAPI.Models.Abstract;
using DatabaseAPI.Models.CinemaMovie.DictionaryModels;
using DatabaseAPI.Models.DictionaryModels;
using DatabaseAPI.Models.People;
using System.Collections.Generic;

namespace DatabaseAPI.Models.CinemaMovie
{
    public class Movie : DictionaryTable
    {
        public ICollection<Actor>? Actors { get; set; }
        public ICollection<Director>? Directors { get; set; }
        public AgeRating? AgeRating { get; set; }
        public int? AgeRatingId { get; set; }
        public ICollection<Award>? Awards { get; set; }
        public Country? Country { get; set; }
        public int? CountryId { get; set; }
        public Genre? Genre { get; set; }
        public int? GenreId { get; set;}
        public ICollection<Languages>? Languages { get; set; }
        public MovieFormat? MovieFormat { get; set; }
        public int? MovieFormatId { get;set; }
        public ICollection<MovieKeywords>? MovieKeywords { get; set; }
        public MovieProductionCompany? MovieProductionCompany { get; set; }
        public int? MovieProductionCompanyId { get; set; }
        public ICollection<Subtitles>? Subtitles { get; set; }
        public ICollection<MovieReview>? MovieReviews { get; set; }
        public ICollection<Screening>? Screenings { get; set; }
        public int? Duration { get; set; }
        public decimal? TicketPrice { get; set; }
    }
}
