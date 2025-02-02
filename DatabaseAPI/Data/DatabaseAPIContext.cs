using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Models.CinemaMovie.DictionaryModels;
using DatabaseAPI.Models.CMS;
using DatabaseAPI.Models.CoffeeShop;
using DatabaseAPI.Models.CoffeeShop.DictionaryModels;
using DatabaseAPI.Models.DictionaryModels;
using DatabaseAPI.Models.General;
using DatabaseAPI.Models.General.DictionaryModels;
using DatabaseAPI.Models.People;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

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
        public DbSet<ScreeningSeat>? ScreeningSeat { get; set; }
        public DbSet<CartElement>? CartElement { get; set; }
        public DbSet<Website>? Website { get; set; }
        public DbSet<ContactInformation>? ContactInformation { get; set; }
        public DbSet<Navbar>? Navbar { get; set; }
        public DbSet<Newsletter>? Newsletter { get; set; }
        public DbSet<Topbar>? Topbar { get; set; }
        public DbSet<UsefulLink>? UsefulLink { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AgeRating>().HasData(
                new AgeRating { Id = 1, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "+12", Name = "+12" },
                new AgeRating { Id = 2, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "+15", Name = "+15" },
                new AgeRating { Id = 3, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "+18", Name = "+18" }
                );
            builder.Entity<Award>().HasData(
                new Award { Id = 1, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "Grammy", Name = "Grammy" },
                new Award { Id = 2, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "Oscar", Name = "Oscar" }
                );
            builder.Entity<Country>().HasData(
                new Country { Id = 1, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "Poland", Name = "Poland" },
                new Country { Id = 2, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "USA", Name = "USA" },
                new Country { Id = 3, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "Germany", Name = "Germany" }
                );
            builder.Entity<Genre>().HasData(
                new Genre { Id = 1, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "Action", Name = "Action" },
                new Genre { Id = 2, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "Romance", Name = "Romance" },
                new Genre { Id = 3, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "Drama", Name = "Drama" }
                );
            builder.Entity<Languages>().HasData(
                new Languages { Id = 1, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "Polish", Name = "Polish" },
                new Languages { Id = 2, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "English", Name = "English" },
                new Languages { Id = 3, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "Danish", Name = "Danish" }
                );
            builder.Entity<MovieFormat>().HasData(
                new MovieFormat { Id = 1, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "4:3", Name = "4:3" },
                new MovieFormat { Id = 2, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "16:9", Name = "16:9" }
                );
            builder.Entity<MovieKeywords>().HasData(
                new MovieKeywords { Id = 1, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "Superb", Name = "Superb" },
                new MovieKeywords { Id = 2, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "Extra", Name = "Extra" },
                new MovieKeywords { Id = 3, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "Magic", Name = "Magic" }
                );
            builder.Entity<MovieProductionCompany>().HasData(
                new MovieProductionCompany { Id = 1, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "Warner Bros", Name = "Warner Bros" },
                new MovieProductionCompany { Id = 2, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "KOJAK", Name = "KOJAK" },
                new MovieProductionCompany { Id = 3, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "Netflix", Name = "Netflix" }
                );
            builder.Entity<Subtitles>().HasData(
                new Subtitles { Id = 1, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "Polish", Name = "Polish" },
                new Subtitles { Id = 2, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "English", Name = "English" },
                new Subtitles { Id = 3, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "Danish", Name = "Danish" }
                );
            builder.Entity<PaymentMethod>().HasData(
                new PaymentMethod { Id = 1, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "Cash", Name = "Cash" },
                new PaymentMethod { Id = 2, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "Credit Card", Name = "Credit Card" }
                );
            builder.Entity<WorkPosition>().HasData(
                new WorkPosition { Id = 1, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "General Assistant", Name = "General Assistant" },
                new WorkPosition { Id = 2, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "Floor Manager", Name = "Floor Manager" },
                new WorkPosition { Id = 3, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "Cleaner", Name = "Cleaner" }
                );

            builder.Entity<UserLevel>().HasData(
                new UserLevel { Id = 1, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "Level 1", Name = "1", PointsToNextLevel = 10},
                new UserLevel { Id = 2, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "Level 2", Name = "2", PointsToNextLevel = 50 }
                );


            // More complex models now

            builder.Entity<Actor>().HasData(
                new Actor
                {
                    Id = 1,
                    CreatedAt = DateTime.Now,
                    ModifiedAt = DateTime.Now,
                    IsActive = true,
                    Description = "Jerzy Puławski",
                    Name = "Jerzy Puławski",
                    FirstName = "Jerzy",
                    LastName = "Puławski",
                    CountryId = 1,
                    DateOfBirth = DateTime.Now.AddYears(-30).AddMonths(-3)
                },
                new Actor
                {
                    Id = 2,
                    CreatedAt = DateTime.Now,
                    ModifiedAt = DateTime.Now,
                    IsActive = true,
                    Description = "John Longue",
                    Name = "John Longue",
                    FirstName = "John",
                    LastName = "Longue",
                    CountryId = 2,
                    DateOfBirth = DateTime.Now.AddYears(-30).AddMonths(-3)
                },
                new Actor
                {
                    Id = 3,
                    CreatedAt = DateTime.Now,
                    ModifiedAt = DateTime.Now,
                    IsActive = true,
                    Description = "Anna Kobiela",
                    Name = "Anna Kobiela",
                    FirstName = "Anna",
                    LastName = "Kobiela",
                    CountryId = 1,
                    DateOfBirth = DateTime.Now.AddYears(-20).AddMonths(-5)
                }
                );
            builder.Entity<Director>().HasData(
                new Director
                {
                    Id = 1,
                    CreatedAt = DateTime.Now,
                    ModifiedAt = DateTime.Now,
                    IsActive = true,
                    Description = "Mariusz Puławski",
                    Name = "Mariusz Puławski",
                    FirstName = "Mariusz",
                    LastName = "Puławski",
                    CountryId = 1,
                    DateOfBirth = DateTime.Now.AddYears(-50).AddMonths(-3).AddDays(23)
                },
                new Director
                {
                    Id = 2,
                    CreatedAt = DateTime.Now,
                    ModifiedAt = DateTime.Now,
                    IsActive = true,
                    Description = "John Mingue",
                    Name = "John Mingue",
                    FirstName = "John",
                    LastName = "Mingue",
                    CountryId = 2,
                    DateOfBirth = DateTime.Now.AddYears(-60).AddMonths(1)
                }
                );


            builder.Entity<Screen>().HasData(
                new Screen { Id = 1, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "ŻABA", Name = "ŻABA", RoomNumber = 12 },
                new Screen { Id = 2, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "KROWA", Name = "KROWA", RoomNumber = 23 },
                new Screen { Id = 3, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "MILKY WAY", Name = "MILKY WAY", RoomNumber = 34 }
                );

            builder.Entity<Seat>().HasData(
                new Seat { Id = 1, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "1/1", Name = "1/1", NumberInRow = 1, Row = 1, ScreenId = 1 },
                new Seat { Id = 2, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "1/2", Name = "1/2", NumberInRow = 2, Row = 1, ScreenId = 1 },
                new Seat { Id = 3, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "1/3", Name = "1/3", NumberInRow = 3, Row = 1, ScreenId = 1 },
                new Seat { Id = 4, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "2/1", Name = "2/1", NumberInRow = 1, Row = 2, ScreenId = 1 },
                new Seat { Id = 5, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "2/2", Name = "2/2", NumberInRow = 2, Row = 2, ScreenId = 1 },
                new Seat { Id = 6, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "2/3", Name = "2/3", NumberInRow = 3, Row = 2, ScreenId = 1 },
                new Seat { Id = 7, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "3/1", Name = "3/1", NumberInRow = 1, Row = 3, ScreenId = 1 },
                new Seat { Id = 8, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "3/2", Name = "3/2", NumberInRow = 2, Row = 3, ScreenId = 1 },
                new Seat { Id = 9, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "3/3", Name = "3/3", NumberInRow = 3, Row = 3, ScreenId = 1 },
                new Seat { Id = 10, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "1/1", Name = "1/1", NumberInRow = 1, Row = 1, ScreenId = 2 },
                new Seat { Id = 11, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "1/2", Name = "1/2", NumberInRow = 2, Row = 1, ScreenId = 2 },
                new Seat { Id = 12, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "1/3", Name = "1/3", NumberInRow = 3, Row = 1, ScreenId = 2 },
                new Seat { Id = 13, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "2/1", Name = "2/1", NumberInRow = 1, Row = 2, ScreenId = 2 },
                new Seat { Id = 14, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "2/2", Name = "2/2", NumberInRow = 2, Row = 2, ScreenId = 2 },
                new Seat { Id = 15, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "2/3", Name = "2/3", NumberInRow = 3, Row = 2, ScreenId = 2 },
                new Seat { Id = 16, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "3/1", Name = "3/1", NumberInRow = 1, Row = 3, ScreenId = 2 },
                new Seat { Id = 17, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "3/2", Name = "3/2", NumberInRow = 2, Row = 3, ScreenId = 2 },
                new Seat { Id = 18, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "3/3", Name = "3/3", NumberInRow = 3, Row = 3, ScreenId = 2 },
                new Seat { Id = 19, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "1/1", Name = "1/1", NumberInRow = 1, Row = 1, ScreenId = 3 },
                new Seat { Id = 20, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "1/2", Name = "1/2", NumberInRow = 2, Row = 1, ScreenId = 3 },
                new Seat { Id = 21, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "1/3", Name = "1/3", NumberInRow = 3, Row = 1, ScreenId = 3 },
                new Seat { Id = 22, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "2/1", Name = "2/1", NumberInRow = 1, Row = 2, ScreenId = 3 },
                new Seat { Id = 23, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "2/2", Name = "2/2", NumberInRow = 2, Row = 2, ScreenId = 3 },
                new Seat { Id = 24, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "2/3", Name = "2/3", NumberInRow = 3, Row = 2, ScreenId = 3 },
                new Seat { Id = 25, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "3/1", Name = "3/1", NumberInRow = 1, Row = 3, ScreenId = 3 },
                new Seat { Id = 26, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "3/2", Name = "3/2", NumberInRow = 2, Row = 3, ScreenId = 3 },
                new Seat { Id = 27, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, IsActive = true, Description = "3/3", Name = "3/3", NumberInRow = 3, Row = 3, ScreenId = 3 }
                );



            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

    }
}
