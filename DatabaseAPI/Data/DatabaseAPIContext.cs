using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Models.CinemaMovie.DictionaryModels;
using DatabaseAPI.Models.CoffeeShop;
using DatabaseAPI.Models.CoffeeShop.DictionaryModels;
using DatabaseAPI.Models.DictionaryModels;
using DatabaseAPI.Models.General;
using DatabaseAPI.Models.General.DictionaryModels;
using DatabaseAPI.Models.People;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAPI.Data
{
    public class DatabaseAPIContext : IdentityDbContext<IdentityUser>
    {
        public DatabaseAPIContext(DbContextOptions<DatabaseAPIContext> options)
            : base(options)
        {

        }

        public DbSet<AgeRating>? AgeRating { get; set; }
        public DbSet<Award>? Award { get; set; }
        public DbSet<Country>? Country { get; set; }
        public DbSet<Coupon>? Coupon { get; set; }
        public DbSet<Genre>? Genre { get; set; }
        public DbSet<Languages>? Languages { get; set; }
        public DbSet<MovieFormat>? MovieFormat { get; set; }
        public DbSet<MovieKeywords>? MovieKeywords { get; set; }
        public DbSet<MovieProductionCompany>? MovieProductionCompany { get; set; }
        public DbSet<Subtitles>? Subtitles { get; set; }
        //public DbSet<Cinema>? Cinema { get; set; }
        public DbSet<Movie>? Movie { get; set; }
        public DbSet<MovieReview>? MovieReview { get; set; }
        public DbSet<Reservations>? Reservations { get; set; }
        public DbSet<Screen>? Screen { get; set; }
        public DbSet<Screening>? Screening { get; set; }
        public DbSet<Seat>? Seat { get; set; }
        public DbSet<Ticket>? Ticket { get; set; }
        public DbSet<PaymentMethod>? PaymentMethod { get; set; }
        public DbSet<WorkPosition>? WorkPosition { get; set; }
        public DbSet<Address>? Address { get; set; }
        public DbSet<BankAccount>? BankAccount { get; set; }
        public DbSet<OpeningHour>? OpeningHour { get; set; }
        public DbSet<Photo>? Photo { get; set; }
        public DbSet<WorkSchedule>? WorkSchedule { get; set; }
        public DbSet<Actor>? Actor { get; set; }
        public DbSet<User>? User { get; set; }
        public DbSet<UserLevel>? UserLevel { get; set; }
        public DbSet<Director>? Director { get; set; }
        public DbSet<TypeOfElementOfMenu>? TypeOfElementOfMenu { get; set; }
        public DbSet<ELementOfMenu>? ELementOfMenu { get; set; }
        public DbSet<Invoice>? Invoice { get; set; }
        public DbSet<ScreeningSeat>? ScreeningSeat { get; set;}
        public DbSet<CartElement>? CartElement { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

    }
}
