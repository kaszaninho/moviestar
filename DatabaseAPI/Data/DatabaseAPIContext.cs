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
        public DbSet<Bottombar>? Bottombar { get; set; }
        public DbSet<UsefulLink>? UsefulLink { get; set; }
        public DbSet<FooterIcon>? FooterIcon { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AgeRating>().HasData(
                new AgeRating { Id = 1, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "+12", Name = "+12" },
                new AgeRating { Id = 2, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "+15", Name = "+15" },
                new AgeRating { Id = 3, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "+18", Name = "+18" }
                );
            builder.Entity<Award>().HasData(
                new Award { Id = 1, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Grammy", Name = "Grammy" },
                new Award { Id = 2, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Oscar", Name = "Oscar" }
                );
            builder.Entity<Country>().HasData(
                new Country { Id = 1, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Poland", Name = "Poland" },
                new Country { Id = 2, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "USA", Name = "USA" },
                new Country { Id = 3, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Germany", Name = "Germany" }
                );
            builder.Entity<Genre>().HasData(
                new Genre { Id = 1, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Action", Name = "Action" },
                new Genre { Id = 2, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Romance", Name = "Romance" },
                new Genre { Id = 3, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Drama", Name = "Drama" },
                new Genre { Id = 4, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Fantasy", Name = "Fantasy" },
                new Genre { Id = 5, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Horror", Name = "Horror" }
                );
            builder.Entity<Languages>().HasData(
                new Languages { Id = 1, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Polish", Name = "Polish" },
                new Languages { Id = 2, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "English", Name = "English" },
                new Languages { Id = 3, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Danish", Name = "Danish" }
                );
            builder.Entity<MovieFormat>().HasData(
                new MovieFormat { Id = 1, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "4:3", Name = "4:3" },
                new MovieFormat { Id = 2, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "16:9", Name = "16:9" }
                );
            builder.Entity<MovieKeywords>().HasData(
                new MovieKeywords { Id = 1, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Superb", Name = "Superb" },
                new MovieKeywords { Id = 2, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Extra", Name = "Extra" },
                new MovieKeywords { Id = 3, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Magic", Name = "Magic" }
                );
            builder.Entity<MovieProductionCompany>().HasData(
                new MovieProductionCompany { Id = 1, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Warner Bros", Name = "Warner Bros" },
                new MovieProductionCompany { Id = 2, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "KOJAK", Name = "KOJAK" },
                new MovieProductionCompany { Id = 3, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Netflix", Name = "Netflix" }
                );
            builder.Entity<Subtitles>().HasData(
                new Subtitles { Id = 1, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Polish", Name = "Polish" },
                new Subtitles { Id = 2, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "English", Name = "English" },
                new Subtitles { Id = 3, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Danish", Name = "Danish" }
                );
            builder.Entity<PaymentMethod>().HasData(
                new PaymentMethod { Id = 1, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Cash", Name = "Cash" },
                new PaymentMethod { Id = 2, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Credit Card", Name = "Credit Card" },
                new PaymentMethod { Id = 3, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Stripe", Name = "Stripe" }
                );
            builder.Entity<WorkPosition>().HasData(
                new WorkPosition { Id = 1, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "General Assistant", Name = "General Assistant" },
                new WorkPosition { Id = 2, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Floor Manager", Name = "Floor Manager" },
                new WorkPosition { Id = 3, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Cleaner", Name = "Cleaner" }
                );

            builder.Entity<UserLevel>().HasData(
                new UserLevel { Id = 1, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Level 1", Name = "1", PointsToNextLevel = 10 },
                new UserLevel { Id = 2, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Level 2", Name = "2", PointsToNextLevel = 50 }
                );


            // More complex models now

            builder.Entity<Actor>().HasData(
                new Actor
                {
                    Id = 1,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "Jerzy Puławski",
                    Name = "Jerzy Puławski",
                    FirstName = "Jerzy",
                    LastName = "Puławski",
                    CountryId = 1,
                    DateOfBirth = new DateTime(2025, 2, 2).AddYears(-30).AddMonths(-3)
                },
                new Actor
                {
                    Id = 2,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "John Longue",
                    Name = "John Longue",
                    FirstName = "John",
                    LastName = "Longue",
                    CountryId = 2,
                    DateOfBirth = new DateTime(2025, 2, 2).AddYears(-30).AddMonths(-3)
                },
                new Actor
                {
                    Id = 3,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "Anna Kobiela",
                    Name = "Anna Kobiela",
                    FirstName = "Anna",
                    LastName = "Kobiela",
                    CountryId = 1,
                    DateOfBirth = new DateTime(2025, 2, 2).AddYears(-20).AddMonths(-5)
                }
                );
            builder.Entity<Director>().HasData(
                new Director
                {
                    Id = 1,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "Mariusz Puławski",
                    Name = "Mariusz Puławski",
                    FirstName = "Mariusz",
                    LastName = "Puławski",
                    CountryId = 1,
                    DateOfBirth = new DateTime(2025, 2, 2).AddYears(-50).AddMonths(-3).AddDays(23)
                },
                new Director
                {
                    Id = 2,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "John Mingue",
                    Name = "John Mingue",
                    FirstName = "John",
                    LastName = "Mingue",
                    CountryId = 2,
                    DateOfBirth = new DateTime(2025, 2, 2).AddYears(-60).AddMonths(1)
                }
                );


            builder.Entity<Screen>().HasData(
                new Screen { Id = 1, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "ŻABA", Name = "ŻABA", RoomNumber = 12 },
                new Screen { Id = 2, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "KROWA", Name = "KROWA", RoomNumber = 23 },
                new Screen { Id = 3, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "MILKY WAY", Name = "MILKY WAY", RoomNumber = 34 }
                );

            builder.Entity<Seat>().HasData(
                new Seat { Id = 1, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "1/1", Name = "A1", NumberInRow = 1, Row = 1, ScreenId = 1 },
                new Seat { Id = 2, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "1/2", Name = "A2", NumberInRow = 2, Row = 1, ScreenId = 1 },
                new Seat { Id = 3, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "1/3", Name = "A3", NumberInRow = 3, Row = 1, ScreenId = 1 },
                new Seat { Id = 4, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "2/1", Name = "B1", NumberInRow = 1, Row = 2, ScreenId = 1 },
                new Seat { Id = 5, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "2/2", Name = "B2", NumberInRow = 2, Row = 2, ScreenId = 1 },
                new Seat { Id = 6, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "2/3", Name = "B3", NumberInRow = 3, Row = 2, ScreenId = 1 },
                new Seat { Id = 7, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "3/1", Name = "C1", NumberInRow = 1, Row = 3, ScreenId = 1 },
                new Seat { Id = 8, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "3/2", Name = "C2", NumberInRow = 2, Row = 3, ScreenId = 1 },
                new Seat { Id = 9, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "3/3", Name = "C3", NumberInRow = 3, Row = 3, ScreenId = 1 },
                new Seat { Id = 10, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "1/1", Name = "A1", NumberInRow = 1, Row = 1, ScreenId = 2 },
                new Seat { Id = 11, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "1/2", Name = "A2", NumberInRow = 2, Row = 1, ScreenId = 2 },
                new Seat { Id = 12, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "1/3", Name = "A3", NumberInRow = 3, Row = 1, ScreenId = 2 },
                new Seat { Id = 13, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "2/1", Name = "B1", NumberInRow = 1, Row = 2, ScreenId = 2 },
                new Seat { Id = 14, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "2/2", Name = "B2", NumberInRow = 2, Row = 2, ScreenId = 2 },
                new Seat { Id = 15, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "2/3", Name = "B3", NumberInRow = 3, Row = 2, ScreenId = 2 },
                new Seat { Id = 16, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "3/1", Name = "C1", NumberInRow = 1, Row = 3, ScreenId = 2 },
                new Seat { Id = 17, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "3/2", Name = "C2", NumberInRow = 2, Row = 3, ScreenId = 2 },
                new Seat { Id = 18, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "3/3", Name = "C3", NumberInRow = 3, Row = 3, ScreenId = 2 },
                new Seat { Id = 19, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "1/1", Name = "A1", NumberInRow = 1, Row = 1, ScreenId = 3 },
                new Seat { Id = 20, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "1/2", Name = "A2", NumberInRow = 2, Row = 1, ScreenId = 3 },
                new Seat { Id = 21, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "1/3", Name = "A3", NumberInRow = 3, Row = 1, ScreenId = 3 },
                new Seat { Id = 22, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "2/1", Name = "B1", NumberInRow = 1, Row = 2, ScreenId = 3 },
                new Seat { Id = 23, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "2/2", Name = "B2", NumberInRow = 2, Row = 2, ScreenId = 3 },
                new Seat { Id = 24, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "2/3", Name = "B3", NumberInRow = 3, Row = 2, ScreenId = 3 },
                new Seat { Id = 25, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "3/1", Name = "C1", NumberInRow = 1, Row = 3, ScreenId = 3 },
                new Seat { Id = 26, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "3/2", Name = "C2", NumberInRow = 2, Row = 3, ScreenId = 3 },
                new Seat { Id = 27, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "3/3", Name = "C3", NumberInRow = 3, Row = 3, ScreenId = 3 }
                );


            // CMS

            builder.Entity<Navbar>().HasData(
                new Navbar
                {
                    Id = 1,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Home",
                    Action = "Index",
                    Controller = "Home",
                    Content = "Home",
                    Position = 1
                },
                new Navbar
                {
                    Id = 2,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Invoices",
                    Action = "InvoiceReportForUser",
                    Controller = "Home",
                    Content = "Invoices",
                    Position = 2
                },
                new Navbar
                {
                    Id = 3,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Movies",
                    Action = "Index",
                    Controller = "Movie",
                    Content = "Movies",
                    Position = 3
                },
                new Navbar
                {
                    Id = 4,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Cart",
                    Action = "Index",
                    Controller = "Cart",
                    Content = "Cart",
                    Position = 4
                },
                new Navbar
                {
                    Id = 5,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Contact",
                    Action = "Contact",
                    Controller = "Home",
                    Content = "Contact",
                    Position = 5
                });


            builder.Entity<ContactInformation>().HasData(
                new ContactInformation
                {
                    Id = 1,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Title",
                    Content = "\r\n<h3><a class=\"text-white\" href=\"index.html\"><i class=\"fa fa-video-camera col_red me-1\"></i> MovieStar</a></h3>",
                    Position = 1
                },
                new ContactInformation
                {
                    Id = 2,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Expression",
                    Content = "\r\n<p class=\"mt-3\">Any question? Send a mail, e-mail or call us</p>",
                    Position = 2
                },
                new ContactInformation
                {
                    Id = 3,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Address",
                    Content = "<h6 class=\"fw-normal\">\r\n    <i class=\"fa fa-map-marker fs-5 align-middle col_red me-1\"></i> Nowy Sącz, Lwowska 2532, Małpolskie, Polska\r\n</h6>",
                    Position = 3
                },
                new ContactInformation
                {
                    Id = 4,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Email",
                    Content = "<h6 class=\"fw-normal mt-3\"><i class=\"fa fa-envelope fs-5 align-middle col_red me-1\"></i> info@gmail.com</h6>",
                    Position = 4
                },
                new ContactInformation
                {
                    Id = 5,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Phone Number",
                    Content = "<h6 class=\"fw-normal mt-3 mb-0\"><i class=\"fa fa-phone fs-5 align-middle col_red me-1\"></i>  +123 123 456</h6>",
                    Position = 5
                });

            builder.Entity<Newsletter>().HasData(
                new Newsletter
                {
                    Id = 1,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Title",
                    Content = "<h4>Sign  <span class=\"col_red\">Newsletter</span></h4>",
                    Position = 1
                },
                new Newsletter
                {
                    Id = 2,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Expression",
                    Content = "\r\n<p class=\"mt-3\">Subscribe to our newsletter list to get latest news and updates from us</p>",
                    Position = 2
                },
                new Newsletter
                {
                    Id = 3,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Mail with button",
                    Content = "\r\n<div class=\"input-group\">\r\n    <input type=\"text\" class=\"form-control bg-black\" placeholder=\"Email\">\r\n    <span class=\"input-group-btn\">\r\n        <button class=\"btn btn text-white bg_red rounded-0 border-0\" type=\"button\">\r\n            Subscribe\r\n        </button>\r\n    </span>\r\n</div>",
                    Position = 3
                });



            builder.Entity<FooterIcon>().HasData(
                new FooterIcon
                {
                    Id = 1,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Instagram",
                    Content = "\r\n        <a href=\"#\" class=\"icoInstagram\" title=\"Instagram\" style=\"display: flex; align-items: center; justify-content: center; width: 40px; height: 40px; border-radius: 50%; background-color: #E4405F; color: white; text-decoration: none;\">\r\n            <i class=\"bi bi-instagram\" style=\"font-size: 20px;\"></i>\r\n        </a>",
                    Position = 1
                },
                new FooterIcon
                {
                    Id = 2,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Facebook",
                    Content = "<a href=\"#\" class=\"icoFacebook\" title=\"Facebook\" style=\"display: flex; align-items: center; justify-content: center; width: 40px; height: 40px; border-radius: 50%; background-color: #3b5998; color: white; text-decoration: none;\">\r\n            <i class=\"bi bi-facebook\" style=\"font-size: 20px;\"></i>\r\n        </a>",
                    Position = 2
                },
                new FooterIcon
                {
                    Id = 3,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Twitter",
                    Content = "<a href=\"#\" class=\"icoTwitter\" title=\"Twitter\" style=\"display: flex; align-items: center; justify-content: center; width: 40px; height: 40px; border-radius: 50%; background-color: #1DA1F2; color: white; text-decoration: none;\">\r\n            <i class=\"bi bi-twitter\" style=\"font-size: 20px;\"></i>\r\n        </a>",
                    Position = 3
                },
                new FooterIcon
                {
                    Id = 4,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Youtube",
                    Content = "<a href=\"#\" class=\"icoYouTube\" title=\"YouTube\" style=\"display: flex; align-items: center; justify-content: center; width: 40px; height: 40px; border-radius: 50%; background-color: #FF0000; color: white; text-decoration: none;\">\r\n            <i class=\"bi bi-youtube\" style=\"font-size: 20px;\"></i>\r\n        </a>",
                    Position = 4
                },
                new FooterIcon
                {
                    Id = 5,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "LinkedIn",
                    Content = "<a href=\"#\" class=\"icoLinkedin\" title=\"LinkedIn\" style=\"display: flex; align-items: center; justify-content: center; width: 40px; height: 40px; border-radius: 50%; background-color: #0077B5; color: white; text-decoration: none;\">\r\n            <i class=\"bi bi-linkedin\" style=\"font-size: 20px;\"></i>\r\n        </a",
                    Position = 5
                });


            builder.Entity<UsefulLink>().HasData(
                new UsefulLink
                {
                    Id = 1,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Home",
                    Content = "<a href=\"#\">Home</a>",
                    Position = 1
                },
                new UsefulLink
                {
                    Id = 2,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Movies",
                    Content = "<a href=\"Movie\">Movies</a>",
                    Position = 2
                },
                new UsefulLink
                {
                    Id = 3,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Cart",
                    Content = "<a href=\"Cart\">Cart</a>",
                    Position = 3
                },
                new UsefulLink
                {
                    Id = 4,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Home",
                    Content = "<a href=\"Identity/Account/Manage\">Profile</a>",
                    Position = 4
                },
                new UsefulLink
                {
                    Id = 5,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Contact",
                    Content = "<a href=\"Contact\">Contact</a>",
                    Position = 5
                });

            builder.Entity<Bottombar>().HasData(
                new Bottombar
                {
                    Id = 1,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Copyright",
                    Content = "<p class=\"mb-0 footer-text\" style=\"color: white;\">© 2024 MovieStar Cinema. All rights reserved. Design by <a class=\"col_red\" href=\"https://www.google.com\">Bartosz Waśko</a></p>",
                    Position = 1
                });

            builder.Entity<Website>().HasData(
                new Website
                {
                    Id = 1,
                    Description = "",
                    Name = "Privacy",
                    TitleName = "Privacy",
                    Content = "<h2 style=\"text-align: center; \"><strong><font color=\"#ffffff\">Privacy Policy</font></strong></h2><p style=\"text-align: center; \"><strong>Effective Date:</strong> [02.05.2025]</p><p style=\"text-align: center; \">MovieStar (\"we,\" \"us,\" or \"our\") values your privacy. This Privacy Policy describes how we collect, use, and protect your personal data when you use our website.</p><p style=\"text-align: center; \"><strong>1. Information We Collect</strong></p><ul data-spread=\"false\"><li><p style=\"text-align: center;\">Personal data: Name, email address, payment details (if applicable), and other account information.</p></li><li><p style=\"text-align: center;\">Non-personal data: IP address, browser type, and website usage statistics.</p></li></ul><p style=\"text-align: center;\"><strong>2. How We Use Your Information</strong></p><ul data-spread=\"false\"><ul><li><ul><li style=\"text-align: center;\">To provide and improve our services.</li></ul></li><li><ul><li style=\"text-align: center;\">To process transactions and payments.</li></ul></li><li><ul><li style=\"text-align: center;\">To personalize user experience and deliver relevant content.</li></ul></li><li><ul><li style=\"text-align: center;\">To comply with legal obligations.</li></ul></li></ul></ul><p style=\"text-align: center;\"><strong>3. Data Security</strong>\r\nWe implement industry-standard security measures to protect your personal data. However, no online transmission is 100% secure, and we cannot guarantee absolute security.</p><p style=\"text-align: center;\"><strong>4. Third-Party Sharing</strong>\r\nWe do not sell your personal data. We may share data with third parties for processing transactions, legal compliance, or service improvements.</p><p style=\"text-align: center;\"><strong>5. Your Rights</strong>\r\nYou have the right to access, update, or delete your personal data. Contact us at [Insert Contact Info] to exercise these rights.</p><p style=\"text-align: center;\"><strong>6. Changes to This Policy</strong>\r\nWe may update this Privacy Policy from time to time. Please review it periodically.</p><p style=\"text-align: center;\"><br></p><p style=\"text-align: right;\">MovieStar team</p>"
                },
                new Website
                {
                    Id = 2,
                    Description = "",
                    Name = "TermsAndConditions",
                    TitleName = "Terms and Conditions",
                    Content = "<h2 style=\"text-align: center; \"><strong><font color=\"#ffffff\">Terms and Conditions</font></strong></h2><p style=\"text-align: center;\"><font color=\"#ffffff\"><strong>Effective Date:</strong> 02.05.2025</font></p><p style=\"text-align: center;\"><font color=\"#ffffff\">Welcome to MovieStar! By accessing or using our website, you agree to these Terms and Conditions.</font></p><p style=\"text-align: center;\"><strong><font color=\"#ffffff\">1. Use of the Website</font></strong></p><ul data-spread=\"false\"><li><p style=\"text-align: center;\"><font color=\"#ffffff\">You must be at least 18 years old or have parental consent to use our services.</font></p></li><li><p style=\"text-align: center;\"><font color=\"#ffffff\">You agree not to use the website for any unlawful or prohibited activities.</font></p></li></ul><p style=\"text-align: center;\"><strong><font color=\"#ffffff\">2. Account Registration</font></strong></p><ul data-spread=\"false\"><li><p style=\"text-align: center;\"><font color=\"#ffffff\">You are responsible for maintaining the confidentiality of your account credentials.</font></p></li><li><p style=\"text-align: center;\"><font color=\"#ffffff\">We reserve the right to suspend or terminate accounts that violate our policies.</font></p></li></ul><p style=\"text-align: center;\"><strong><font color=\"#ffffff\">3. Content and Intellectual Property</font></strong></p><ul data-spread=\"false\"><li><p style=\"text-align: center;\"><font color=\"#ffffff\">All content on MovieStar, including logos, text, and media, is owned by us or our licensors.</font></p></li><li><p style=\"text-align: center;\"><font color=\"#ffffff\">You may not copy, distribute, or modify any content without permission.</font></p></li></ul><p style=\"text-align: center;\"><strong><font color=\"#ffffff\">4. Limitation of Liability</font></strong></p><ul data-spread=\"false\"><li><p style=\"text-align: center;\"><font color=\"#ffffff\">We are not liable for any damages resulting from the use of our website.</font></p></li><li><p style=\"text-align: center;\"><font color=\"#ffffff\">We do not guarantee uninterrupted or error-free service.</font></p></li></ul><p style=\"text-align: center;\"><font color=\"#ffffff\"><strong>5. Changes to Terms</strong>\r\nWe may update these Terms and Conditions. Continued use of the website means acceptance of the updated terms.</font></p><p style=\"text-align: center; \"><font color=\"#ffffff\">For any questions, contact us at info@gmail.com.</font></p><p style=\"text-align: center; \"><font color=\"#ffffff\"><br></font></p><p style=\"text-align: right;\"><font color=\"#ffffff\">MovieStar Team</font></p>"
                },
                new Website
                {
                    Id = 3,
                    Description = "",
                    Name = "AboutUs",
                    TitleName = "About Us",
                    Content = "<h4 style=\"text-align: center; \"><strong><font color=\"#ffffff\">Welcome to MovieStar Cinema!</font></strong></h4><p style=\"text-align: center; \"><font color=\"#ffffff\">At MovieStar Cinema, we bring the magic of movies to life. From the latest blockbusters to timeless classics, our state-of-the-art theaters provide an unmatched cinematic experience.</font></p><p style=\"text-align: center;\"><font color=\"#ffffff\">With premium sound systems, ultra-HD screens, and comfortable seating, we ensure every visit is special. Whether you're here for action, drama, comedy, or family entertainment, we have something for everyone.</font></p><p style=\"text-align: center; \"><font color=\"#ffffff\">Thank you for choosing MovieStar Cinema—where every story comes to life on the big screen!</font></p>"
                },
                new Website
                {
                    Id = 4,
                    Description = "",
                    Name = "FAQ",
                    TitleName = "FAQ",
                    Content = "<p></p><h3 style=\"text-align: center; \"><strong><font color=\"#ffffff\">Frequently asked questions</font></strong></h3><h4 style=\"text-align: center; \"><strong><font color=\"#ffffff\"><br></font></strong></h4><p style=\"text-align: center; \"><font color=\"#ffffff\">This is the list of the most asked questions. We will be updating this page periodically.</font></p><h4 style=\"text-align: center; \"><strong><font color=\"#ffffff\"><br></font></strong></h4><h4 style=\"text-align: center; \"><strong><font color=\"#ffffff\">General Questions</font></strong></h4><p></p><div style=\"text-align: center;\"><strong style=\"text-align: var(--bs-body-text-align);\"><font color=\"#ffffff\">Q: What are your operating hours?</font></strong></div><div style=\"text-align: center;\"><span style=\"font-weight: var(--bs-body-font-weight); text-align: var(--bs-body-text-align);\"><font color=\"#ffffff\">A: We are open from 10 am - 10 pm daily.</font></span></div><p></p><p></p><div style=\"text-align: center;\"><strong style=\"text-align: var(--bs-body-text-align);\"><font color=\"#ffffff\">Q: How can I buy tickets?</font></strong></div><div style=\"text-align: center;\"><font color=\"#ffffff\"><span style=\"font-weight: var(--bs-body-font-weight); text-align: var(--bs-body-text-align);\">A: You can&nbsp;</span><span style=\"text-align: var(--bs-body-text-align); font-weight: bolder;\">buy&nbsp;</span><span style=\"font-weight: var(--bs-body-font-weight); text-align: var(--bs-body-text-align);\">online through our website or purchase them at the cinema.</span></font></div><p></p><h4 style=\"text-align: center;\"><strong><font color=\"#ffffff\">Ticketing &amp; Refunds</font></strong></h4><p></p><div style=\"text-align: center;\"><strong style=\"text-align: var(--bs-body-text-align);\"><font color=\"#ffffff\">Q: Can I cancel or refund my ticket?</font></strong></div><div style=\"text-align: center;\"><font color=\"#ffffff\"><span style=\"font-weight: var(--bs-body-font-weight); text-align: var(--bs-body-text-align);\">A: Please refer to our </span><strong style=\"text-align: var(--bs-body-text-align);\">[Refund &amp; Cancellation Policy]</strong><span style=\"font-weight: var(--bs-body-font-weight); text-align: var(--bs-body-text-align);\"> for details.</span></font></div><p></p><p></p><font color=\"#ffffff\"><span style=\"font-weight: bolder; font-size: 18px;\"><div style=\"text-align: center;\"><span style=\"font-weight: bolder; text-align: var(--bs-body-text-align);\">Q: Do you offer discounts?</span></div></span><span style=\"font-size: 18px;\"><div style=\"text-align: center;\"><span style=\"font-weight: var(--bs-body-font-weight); text-align: var(--bs-body-text-align);\">A: Yes! Contact us for booking details.</span></div></span></font><p></p><p></p><div><div style=\"text-align: center;\"><span style=\"font-weight: bolder; text-align: var(--bs-body-text-align);\"><font color=\"#ffffff\">Q: Can you make a seat reservation?</font></span></div><span style=\"font-size: 18px;\"><div style=\"text-align: center;\"><span style=\"font-weight: var(--bs-body-font-weight); text-align: var(--bs-body-text-align);\"><font color=\"#ffffff\">A: Currently no. You need to pay up front for a tickets.</font></span></div></span></div><div style=\"text-align: center; \"><font color=\"#ffffff\"><span style=\"font-size: 18px;\"><br></span><span style=\"font-size: 18px;\"></span></font></div><div><font color=\"#ffffff\"><span style=\"font-size: 18px;\"></span></font></div><span style=\"font-weight: bolder;\"><div style=\"text-align: center;\"><span style=\"font-weight: bolder; text-align: var(--bs-body-text-align);\"><font color=\"#ffffff\">Q: How can I pay for a tickets?</font></span></div></span><div style=\"text-align: center;\"><span style=\"font-weight: var(--bs-body-font-weight); text-align: var(--bs-body-text-align);\"><font color=\"#ffffff\">A: At the moment, it is possible to pay for a ticket using cash, credit card or Stripe.</font></span></div><p></p><p style=\"text-align: center; \"><font color=\"#ffffff\"><br></font></p><p style=\"text-align: center; \"><font color=\"#ffffff\">If you have other questions, please ask via <b>Contact Us </b>page!</font></p>"
                },
                new Website
                {
                    Id = 5,
                    Description = "",
                    Name = "Refund",
                    TitleName = "Refund and Cancellation Policy",
                    Content = "<h3 style=\"text-align: center; \"><strong><font color=\"#ffffff\">&nbsp;Refund &amp; Cancellation Policy</font></strong></h3><h3 style=\"text-align: center; \"><strong><font color=\"#ffffff\"><br></font></strong></h3><p style=\"text-align: center;\"><font color=\"#ffffff\">At MovieStar Cinema, we strive to provide the best experience. However, we understand that plans may change.</font></p><p style=\"text-align: center;\"><font color=\"#ffffff\"><br></font></p><ul><li><p style=\"text-align: center;\"><font color=\"#ffffff\">🎟 <strong>Ticket Refunds:</strong></font></p><ul><li style=\"text-align: center;\"><font color=\"#ffffff\">Tickets are refundable if canceled at least 24 hours before the showtime.</font></li><li style=\"text-align: center;\"><font color=\"#ffffff\">Refunds are processed within 3-5 business days.</font></li></ul></li></ul><p><ul></ul></p><p style=\"text-align: center;\"><font color=\"#ffffff\"><br></font></p><ul><li></li><li><p style=\"text-align: center;\"><font color=\"#ffffff\">🎬 <strong>Cancellations Due to Technical Issues:</strong></font></p><ul><li style=\"text-align: center;\"><font color=\"#ffffff\">If a show is canceled due to technical problems, a full refund or free rebooking will be provided.</font></li></ul></li></ul><p><ul></ul></p><p style=\"text-align: center;\"><font color=\"#ffffff\"><br></font></p><ul><li></li><li><p style=\"text-align: center;\"><font color=\"#ffffff\">🚫 <strong>No-Show Policy:</strong></font></p><ul><li style=\"text-align: center;\"><font color=\"#ffffff\">If you fail to attend without prior cancellation, no refund will be issued.</font></li></ul></li></ul><p><ul></ul></p><p style=\"text-align: center;\"><font color=\"#ffffff\"><br></font></p><ul><li></li></ul><p style=\"text-align: center; \"><font color=\"#ffffff\">For refund requests, please contact us at info@gmail.com.</font></p>"
                },
                new Website
                {
                    Id = 6,
                    Description = "",
                    Name = "CookiePolicy",
                    TitleName = "Cookie Policy",
                    Content = "<h3 style=\"text-align: center;\"><span style=\"font-weight: bolder;\"><font color=\"#ffffff\">Cookie Policy</font></span></h3><h3 style=\"text-align: center;\"><span style=\"font-weight: bolder;\"><font color=\"#ffffff\"><br></font></span></h3><p style=\"text-align: center;\"><font color=\"#ffffff\">MovieStar Cinema uses cookies to enhance your browsing experience.</font></p><p style=\"text-align: center;\"><font color=\"#ffffff\"><br></font></p><h4 style=\"text-align: center;\"><span style=\"font-weight: bolder;\"><font color=\"#ffffff\">What Are Cookies?</font></span></h4><p style=\"text-align: center;\"><font color=\"#ffffff\">Cookies are small text files stored on your device when you visit our website.</font></p><p style=\"text-align: center;\"><font color=\"#ffffff\"><br></font></p><h4 style=\"text-align: center;\"><span style=\"font-weight: bolder;\"><font color=\"#ffffff\">How We Use Cookies</font></span></h4><ul><li style=\"text-align: center;\"><font color=\"#ffffff\">To improve website functionality</font></li><li style=\"text-align: center;\"><font color=\"#ffffff\">To remember your preferences</font></li><li style=\"text-align: center;\"><font color=\"#ffffff\">For analytics and marketing purposes</font></li><li style=\"text-align: center;\"><font color=\"#ffffff\"><br></font></li></ul><p style=\"text-align: center;\"><font color=\"#ffffff\">By using our website, you consent to our use of cookies. You can adjust your settings anytime in your browser.</font></p><p style=\"text-align: center;\"><font color=\"#ffffff\"><br></font></p><p style=\"text-align: center;\"><font color=\"#ffffff\">For more details, visit our&nbsp;<span style=\"font-weight: bolder;\">[Privacy Policy]</span>.</font></p>"
                },
                new Website
                {
                    Id = 7,
                    Description = "",
                    Name = "Career",
                    TitleName = "Career",
                    Content = "<h3 style=\"text-align: center;\"><span style=\"font-weight: bolder;\"><font color=\"#ffffff\">Careers</font></span></h3><h3 style=\"text-align: center;\"><span style=\"font-weight: bolder;\"><font color=\"#ffffff\"><br></font></span></h3><h4 style=\"text-align: center;\"><span style=\"font-weight: bolder;\"><font color=\"#ffffff\">Join Our Team at MovieStar Cinema!</font></span></h4><h4 style=\"text-align: center;\"><span style=\"font-weight: bolder;\"><font color=\"#ffffff\"><br></font></span></h4><p style=\"text-align: center;\"><font color=\"#ffffff\">Are you passionate about movies and customer service? We’re always looking for enthusiastic individuals to join our team.</font></p><p style=\"text-align: center;\"><font color=\"#ffffff\"><br></font></p><p style=\"text-align: center;\"><font color=\"#ffffff\">🚀&nbsp;<span style=\"font-weight: bolder;\">Current Openings:</span></font></p><ul><li style=\"text-align: center;\"><font color=\"#ffffff\">Ticket Sales Associate</font></li><li style=\"text-align: center;\"><font color=\"#ffffff\">Concessions &amp; Food Service</font></li><li style=\"text-align: center;\"><font color=\"#ffffff\">Cinema Manager</font></li><li style=\"text-align: center;\"><font color=\"#ffffff\">Projection &amp; Technical Team</font></li><li style=\"text-align: center;\"><font color=\"#ffffff\"><br></font></li></ul><p style=\"text-align: center;\"><font color=\"#ffffff\">If you’d like to work in an exciting, fast-paced environment, apply today! Send your resume to info@gmail.com.</font></p>"
                },
                new Website
                {
                    Id = 8,
                    Description = "",
                    Name = "Partnership",
                    TitleName = "Partnership",
                    Content = "<h3 style=\"text-align: center; \"><strong><font color=\"#ffffff\">Partnerships &amp; Advertising</font></strong></h3><h3 style=\"text-align: center; \"><strong><font color=\"#ffffff\"><br></font></strong></h3><h4 style=\"text-align: center; \"><strong><font color=\"#ffffff\">Partner with MovieStar Cinema</font></strong></h4><h4 style=\"text-align: center; \"><strong><font color=\"#ffffff\"><br></font></strong></h4><p style=\"text-align: center; \"><font color=\"#ffffff\">Looking for an opportunity to showcase your brand to thousands of moviegoers? We offer premium advertising slots before and during screenings.</font></p><p style=\"text-align: center; \"><font color=\"#ffffff\"><br></font></p><p style=\"text-align: center;\"><font color=\"#ffffff\">📢 <strong>Advertising Options:</strong></font></p><ul><li style=\"text-align: center;\"><font color=\"#ffffff\">On-screen ads before movies</font></li><li style=\"text-align: center;\"><font color=\"#ffffff\">Digital banners on our website</font></li><li style=\"text-align: center; \"><font color=\"#ffffff\">Promotional events at our cinemas</font></li><li style=\"text-align: center; \"><font color=\"#ffffff\"><br></font></li></ul><p style=\"text-align: center; \"><font color=\"#ffffff\">Interested?</font></p><p style=\"text-align: center; \"><font color=\"#ffffff\"> Contact our marketing team at info@gmail.com to discuss collaboration opportunities.</font></p>"
                });


            // MOVIES - BIG ONE
            builder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Name = "Killing Dead Man",
                    AgeRatingId = 3,
                    CountryId = 2,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Duration = 103,
                    MovieFormatId = 1,
                    MovieProductionCompanyId = 1,
                    TicketPrice = (decimal)(15.99),
                    GenreId = 1,
                    Description = "\"Killing Dead Man\" is a pulse-pounding action thriller that takes audiences on a relentless ride through a world where morality is a luxury and survival is the only rule.\r\n\r\nSet against the gritty backdrop of a crime-ridden American metropolis, the film follows ex-hitman Jack Mercer—a man who left behind a violent past only to find that the past isn’t done with him. When a mysterious contract is put out on his life, Mercer is forced back into the deadly underworld he once escaped. Hunted by elite assassins and betrayed by those he trusted, he soon discovers that the one pulling the strings is none other than a man he killed years ago… or so he thought.\r\n\r\nAs the lines between reality and deception blur, Mercer must unravel the truth before he becomes just another forgotten name on a hit list. Fueled by explosive action sequences, intense hand-to-hand combat, and a gripping narrative of revenge and redemption, Killing Dead Man is a high-stakes adrenaline rush from start to finish.\r\n\r\nBrought to life by Warner Bros., this 18+ action spectacle delivers breathtaking cinematography in a classic 4:3 format, immersing viewers in its raw, uncompromising aesthetic. With a runtime of 103 minutes, it’s a relentless, edge-of-your-seat experience that will leave audiences questioning whether the dead ever truly stay buried.",
                    imageUrl = "\\photos\\1.png"
                },
                new Movie
                {
                    Id = 2,
                    Name = "Shadow Strike",
                    AgeRatingId = 3, // 18+
                    CountryId = 2, // USA
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Duration = 120, // Estimated action movie length
                    MovieFormatId = 2, // 16/9 for a cinematic experience
                    MovieProductionCompanyId = 1, // WarnerBros
                    TicketPrice = (decimal)(17.99),
                    GenreId = 1, // Action
                    Description = "In a dystopian future where technology and warfare have merged, elite soldier Captain Ryan Drake is tasked with a mission that could alter the fate of the world. With cyber-enhanced mercenaries, lethal drones, and corrupt corporations standing in his way, Drake must navigate a battlefield of deception and destruction. Explosive action, high-tech combat, and an adrenaline-fueled storyline make 'Shadow Strike' an unmissable cinematic spectacle.",
                    imageUrl = "\\photos\\2.png"
                },
                new Movie
                {
                    Id = 3,
                    Name = "Whispers in the Dark",
                    AgeRatingId = 3, // 18+
                    CountryId = 1, // Poland
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Duration = 112, // Typical horror movie length
                    MovieFormatId = 2, // 16/9 for immersive experience
                    MovieProductionCompanyId = 3, // Netflix
                    TicketPrice = (decimal)(14.99),
                    GenreId = 5, // Horror
                    Description = "Deep within the haunted forests of Poland, an abandoned village holds a terrifying secret. When journalist Anna Kowalski investigates the eerie whispers that plague the nearby town, she uncovers a horrifying legend of lost souls trapped between worlds. As night falls, shadows move, whispers turn to screams, and Anna realizes she’s not alone. With no escape and sanity slipping away, she must face the dark truth before she becomes part of the legend herself. *Whispers in the Dark* is a chilling horror masterpiece from Netflix, blending psychological terror with supernatural horror in a spine-tingling tale you won't forget.",
                    imageUrl = "\\photos\\3.png"
                },
                new Movie
                {
                    Id = 4,
                    Name = "Niefllerissing",
                    AgeRatingId = 3, // 18+
                    CountryId = 3, // Germany
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Duration = 118, // Futuristic action movies tend to be around 2 hours
                    MovieFormatId = 2, // 16/9 for a cinematic experience
                    MovieProductionCompanyId = 2, // KOJAK
                    TicketPrice = (decimal)(16.99),
                    GenreId = 1, // Action
                    Description = "In a neon-lit future where corporations rule and cybernetic enhancements are the norm, rogue enforcer Kai Renegade is the last hope for a crumbling society. When a powerful AI goes rogue, launching a drone war over the towering metropolis of Neo-Berlin, Kai must wield his twin plasma blades and fight his way through an army of cybernetic mercenaries. With the city on the brink of collapse and time running out, he faces the ultimate choice: submit to the machine or rewrite the future. *Niefllerissing* is a visually stunning, adrenaline-charged action thriller that pushes the boundaries of sci-fi cinema.",
                    imageUrl = "\\photos\\4.png"
                },
                new Movie
                {
                    Id = 5,  
                    Name = "The Last Goodbye",
                    AgeRatingId = 2, // 15+
                    CountryId = 2, // USA
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Duration = 95, // A typical romantic drama length
                    MovieFormatId = 2, // 16/9 for a cinematic experience
                    MovieProductionCompanyId = 2, // KOJAK
                    TicketPrice = (decimal)(12.99),
                    GenreId = 2, // Romance
                    Description = "On a misty evening at a quiet train station, two women, once inseparable, stand facing each other for the final time. As the sun sets in the distance, casting an orange glow over the platform, the weight of their past begins to resurface. *The Last Goodbye* tells a poignant story of love, loss, and the bittersweet moments that define our lives. As the trains come and go, they are forced to confront their emotions and say goodbye—forever.",
                    imageUrl = "\\photos\\5.png"
                },
                new Movie
                {
                    Id = 6,  // Corrected ID based on previous instance
                    Name = "Ooops! Wrong Wedding",
                    AgeRatingId = 1, // 12+
                    CountryId = 2, // USA
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Duration = 90, // A typical romantic comedy length
                    MovieFormatId = 2, // 16/9 for a cinematic experience
                    MovieProductionCompanyId = 1, // WarnerBros
                    TicketPrice = (decimal)(10.99),
                    GenreId = 2, // Romance
                    Description = "At a lavish wedding ceremony, the groom stands in confusion, alone in front of the altar in his tuxedo, waiting for the bride. But as the doors swing open, it's not his bride that enters—it's a different woman, running past him to the man standing at the back. In a whirlwind of mistaken identities and hilarious events, *Ooops! Wrong Wedding* brings to life the chaos of love, misunderstandings, and the consequences of running away from commitment. Prepare for a comedy of errors that will have you laughing from start to finish.",
                    imageUrl = "\\photos\\6.png"
                },
                new Movie
                {
                    Id = 7,  // Corrected ID based on previous instance
                    Name = "Bulletproof Vengeance",
                    AgeRatingId = 3, // 18+
                    CountryId = 2, // USA
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Duration = 105, // A typical action movie length
                    MovieFormatId = 2, // 16/9 for a cinematic experience
                    MovieProductionCompanyId = 1, // WarnerBros
                    TicketPrice = (decimal)(15.99),
                    GenreId = 1, // Action
                    Description = "In a war-torn, desolate town, one man walks through the devastation with unwavering determination. With a burning car in the background, his focus never wavers as he strides forward, prepared to take vengeance on those who destroyed everything he loved. *Bulletproof Vengeance* is an action-packed thriller that follows a soldier's relentless quest for revenge in a world where justice is earned with blood, sweat, and bullets. The stakes are high, and survival is the only option.",
                    imageUrl = "\\photos\\7.png"
                },
                new Movie
                {
                    Id = 8,  // Corrected ID based on previous instance
                    Name = "A Life Unwritten",
                    AgeRatingId = 2, // 15+
                    CountryId = 3, // Germany
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Duration = 100, // A typical drama length
                    MovieFormatId = 2, // 16/9 for cinematic experience
                    MovieProductionCompanyId = 2, // KOJAK
                    TicketPrice = (decimal)(13.99),
                    GenreId = 3, // Drama
                    Description = "In a small, dimly lit room, a man sits on the floor, typing away on a vintage typewriter, the rhythmic sound of the keys echoing in the silence. Outside the window, life continues without him, as people move along, oblivious to his internal struggle. *A Life Unwritten* explores the complexities of a man’s inner world, his dreams, and the stories he longs to tell, all while grappling with the reality of an unfulfilled life. A heartfelt drama about the power of words and the burden of missed opportunities.",
                    imageUrl = "\\photos\\8.png"
                },
                new Movie
                {
                    Id = 9,  // Corrected ID based on previous instance
                    Name = "My Crazy Boss",
                    AgeRatingId = 1, // 12+
                    CountryId = 2, // USA
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Duration = 85, // A typical comedy length
                    MovieFormatId = 2, // 16/9 for cinematic experience
                    MovieProductionCompanyId = 1, // WarnerBros
                    TicketPrice = (decimal)(11.99),
                    GenreId = 1, // Action
                    Description = "In the midst of a chaotic office, one boss is on a rampage. Papers fly, cups crash to the floor, and his office workers are caught in the crossfire, all while the rest of the staff remain glued to their computer screens, oblivious to the storm that’s unfolding. *My Crazy Boss* is a hilarious comedy about the unpredictable, often absurd world of office life, where chaos reigns and no one is safe from the eccentricities of their leader. Prepare for non-stop laughter and ridiculous office antics!",
                    imageUrl = "\\photos\\9.png"
                },
                new Movie
                {
                    Id = 10,  // Corrected ID based on previous instance
                    Name = "Silent Screams",
                    AgeRatingId = 3, // 18+
                    CountryId = 1, // Poland
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Duration = 110, // A typical horror movie length
                    MovieFormatId = 2, // 16/9 for immersive experience
                    MovieProductionCompanyId = 3, // Netflix
                    TicketPrice = (decimal)(14.99),
                    GenreId = 5, // Horror
                    Description = "Under the eerie glow of a blood-red moon, a sinister figure, resembling a villain from the darkest of nightmares, prowls the streets of an abandoned town. The air is thick with fear as the old church looms in the background, its doors creaking open to welcome the horrors that await. *Silent Screams* is a chilling horror film that takes you on a terrifying journey into the heart of darkness, where every shadow hides a secret and every scream is swallowed by the silence of the night.",
                    imageUrl = "\\photos\\10.png"
                },
                new Movie
                {
                    Id = 11,  // Corrected ID based on previous instance
                    Name = "Crossroads of Fate",
                    AgeRatingId = 2, // 15+
                    CountryId = 3, // Germany
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Duration = 105, // A typical drama/adventure length
                    MovieFormatId = 2, // 16/9 for cinematic experience
                    MovieProductionCompanyId = 2, // KOJAK
                    TicketPrice = (decimal)(13.49),
                    GenreId = 4, // Fantasy
                    Description = "Standing at the edge of a cliff, a man faces a breathtaking view of the land below, where the clouds part to let the sunlight beam through. The world feels vast, filled with possibilities, and an old, mysterious clock floats above him in the air—its hands frozen in time. *Crossroads of Fate* is a stunning fantasy adventure that explores the moment when a single choice can change the course of a life forever. As the man stares into the unknown, he must decide if he will step into the future or remain bound by the past.",
                    imageUrl = "\\photos\\11.png"
                },
                new Movie
                {
                    Id = 12,  // Corrected ID based on previous instance
                    Name = "The Clumsy Detective",
                    AgeRatingId = 1, // 12+
                    CountryId = 2, // USA
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Duration = 90, // A typical animated comedy length
                    MovieFormatId = 1, // 4/3 for animated look
                    MovieProductionCompanyId = 1, // WarnerBros
                    TicketPrice = (decimal)(9.99),
                    GenreId = 1, // Action (but can also be comedy depending on the tone)
                    Description = "In an animated world of confusion and chaos, *The Clumsy Detective* tries his best to solve the case, though things rarely go as planned. Surrounded by stacks of documents, a curious cat by his side, and a few sharp-suited gentlemen in the office, the detective is a lovable mess. As he stumbles through clues and mishaps, his true genius shines through, despite the comedic disaster he causes. This hilarious animated feature will have you laughing out loud as the clumsy detective slowly but surely unravels the mystery.",
                    imageUrl = "\\photos\\12.png"
                },
                new Movie
                {
                    Id = 13,  // Corrected ID based on previous instance
                    Name = "Beyond the Rift",
                    AgeRatingId = 2, // 15+
                    CountryId = 2, // USA
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Duration = 120, // A typical sci-fi adventure length
                    MovieFormatId = 2, // 16/9 for cinematic experience
                    MovieProductionCompanyId = 3, // Netflix
                    TicketPrice = (decimal)(16.99),
                    GenreId = 4, // Fantasy (could also be Sci-Fi)
                    Description = "In the vastness of space, where the boundaries of reality bend and twist, a spaceship embarks on a journey beyond the known universe. As the Earth and the Moon drift silently in the background, the crew is drawn toward a mysterious rift, a cosmic tunnel that looks like an Einstein-Rosen bridge. Inside it, a brilliant star, like the Sun, beckons them into the unknown. *Beyond the Rift* is a thrilling sci-fi adventure that explores the deepest mysteries of the cosmos, where space and time converge and the fate of the universe hangs in the balance.",
                    imageUrl = "\\photos\\13.png"
                },
                new Movie
                {
                    Id = 14,  // Corrected ID based on previous instance
                    Name = "Love, Lies, Love and Lattes",
                    AgeRatingId = 1, // 12+
                    CountryId = 2, // USA
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Duration = 90, // A typical romantic comedy length
                    MovieFormatId = 2, // 16/9 for cinematic experience
                    MovieProductionCompanyId = 2, // KOJAK
                    TicketPrice = (decimal)(11.49),
                    GenreId = 2, // Romance
                    Description = "In a cozy, dimly lit restaurant, a man and a woman sit close together, sipping on lattes, their conversations filled with secrets, shared smiles, and the occasional laugh. As their hands touch over the table and their faces lean in, the chemistry between them is undeniable. But beneath their blossoming romance lies a web of lies that threatens to unravel everything. *Love, Lies, Love and Lattes* is a heartwarming romantic comedy about love's unpredictable twists and the sweet moments shared over coffee that may just change everything.",
                    imageUrl = "\\photos\\14.png"
                },
                new Movie
                {
                    Id = 15,  // Corrected ID based on previous instance
                    Name = "Rouge Rouge Assassins",
                    AgeRatingId = 3, // 18+
                    CountryId = 2, // USA
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Duration = 110, // A typical action thriller length
                    MovieFormatId = 2, // 16/9 for cinematic experience
                    MovieProductionCompanyId = 1, // WarnerBros
                    TicketPrice = (decimal)(14.99),
                    GenreId = 1, // Action
                    Description = "In the heart of a dark, rain-soaked city, three hooded assassins in black move swiftly across the rooftops, their silhouettes cutting through the evening sky. Armed and focused, they traverse the heights with deadly precision, preparing to strike. In the background, the city’s skyline looms, a constant reminder of the danger that lurks within its depths. *Rouge Rouge Assassins* is an intense action thriller that follows a group of elite assassins on a high-stakes mission, where loyalty is tested, and the line between right and wrong blurs in the shadows of the city.",
                    imageUrl = "\\photos\\15.png"
                },
                new Movie
                {
                    Id = 16,  // Corrected ID based on previous instance
                    Name = "The Last Colony",
                    AgeRatingId = 2, // 15+
                    CountryId = 2, // USA
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Duration = 125, // A typical sci-fi adventure length
                    MovieFormatId = 2, // 16/9 for cinematic experience
                    MovieProductionCompanyId = 3, // Netflix
                    TicketPrice = (decimal)(17.99),
                    GenreId = 4, // Fantasy (also could fit sci-fi)
                    Description = "On the edge of a barren world, the last surviving humans stand before a sleek, futuristic complex, their last hope for survival. In the distance, a spacecraft hovers near the massive colony, and beyond that, another planet—or perhaps a moon—looms ominously in the sky. *The Last Colony* takes you on a thrilling journey into space where humanity's future depends on a fragile settlement in the farthest reaches of the galaxy. With danger on all sides and secrets lurking within the complex, seven brave souls must decide what kind of future awaits them in the unknown.",
                    imageUrl = "\\photos\\16.png"
                },
                new Movie
                {
                    Id = 17,  // Corrected ID based on previous instance
                    Name = "Falling Stars",
                    AgeRatingId = 1, // 12+
                    CountryId = 3, // Germany
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Duration = 95, // A typical drama length
                    MovieFormatId = 2, // 16/9 for cinematic experience
                    MovieProductionCompanyId = 2, // KOJAK
                    TicketPrice = (decimal)(12.49),
                    GenreId = 3, // Drama
                    Description = "A man stands alone on the shore, gazing out at the calm sea beneath a sky filled with the breathtaking glow of constellations. The night is still, the only sound being the gentle lapping of waves. As he stares into the vast expanse of stars, the weight of his dreams, his losses, and his longing fill the silence. *Falling Stars* is a poignant drama that explores the fragility of hope, the impact of dreams lost and regained, and the eternal search for meaning beneath the stars.",
                    imageUrl = "\\photos\\17.png"
                },
                new Movie
                {
                    Id = 18,  // Corrected ID based on previous instance
                    Name = "The Cursed Hollow",
                    AgeRatingId = 3, // 18+
                    CountryId = 1, // Poland
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Duration = 115, // A typical horror/thriller length
                    MovieFormatId = 2, // 16/9 for immersive experience
                    MovieProductionCompanyId = 3, // Netflix
                    TicketPrice = (decimal)(14.99),
                    GenreId = 5, // Horror
                    Description = "On a moonlit night, beneath the eerie glow of a full moon, a small wooden bridge stretches over a misty chasm, flanked by old, dead trees. The air is thick with a chilling fog as a man, dressed in dark clerical robes, stands at the end of the bridge, accompanied by a child. The silence is oppressive, broken only by the whispers of the past. *The Cursed Hollow* is a supernatural horror that delves into the heart of an ancient curse, where the line between the living and the dead blurs, and the truth must be uncovered before the darkness consumes them all.",
                    imageUrl = "\\photos\\18.png"
                },
                new Movie
                {
                    Id = 19,  // Corrected ID based on previous instance
                    Name = "Tormbreakers",
                    AgeRatingId = 2, // 15+
                    CountryId = 3, // Germany
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Duration = 130, // A typical fantasy/adventure length
                    MovieFormatId = 2, // 16/9 for cinematic experience
                    MovieProductionCompanyId = 2, // KOJAK
                    TicketPrice = (decimal)(16.49),
                    GenreId = 4, // Fantasy
                    Description = "In the heart of a ferocious storm, five warriors stand tall on a lone stone amidst the restless sea, their magical weapons glowing with power. Flame swords, lightning-infused blades, and mystical artifacts crackle with energy as thunder cracks the sky. The sea rages around them, but these heroes are unyielding, bound by a common fate. *Tormbreakers* is an epic fantasy adventure where magic, courage, and destiny collide in a world on the brink of destruction. As the storm rages, so too does the battle for the future of their realm.",
                    imageUrl = "\\photos\\19.png"
                },
                new Movie
                {
                    Id = 20,  // Corrected ID based on previous instance
                    Name = "ChronoWars",
                    AgeRatingId = 3, // 18+
                    CountryId = 2, // USA
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Duration = 140, // A typical sci-fi action length
                    MovieFormatId = 2, // 16/9 for cinematic experience
                    MovieProductionCompanyId = 1, // WarnerBros
                    TicketPrice = (decimal)(18.99),
                    GenreId = 4, // Fantasy (also could be Sci-Fi)
                    Description = "A portal to another dimension opens, revealing a futuristic world where time itself is at war. Soldiers, dressed in advanced SWAT gear, patrol the perimeter of the rift, weapons at the ready as spacecrafts zoom overhead. In the background, the mighty Pantheon stands as a symbol of ancient power and mystery. *ChronoWars* is a gripping sci-fi action thriller that spans across time and dimensions, where elite soldiers battle to control the flow of history itself. As they fight for dominance, the future of all worlds hangs in the balance.",
                    imageUrl = "\\photos\\20.png"
                });

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

        }
    }
}
