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
                new Genre { Id = 3, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "Drama", Name = "Drama" }
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
                new Seat { Id = 1, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "1/1", Name = "1/1", NumberInRow = 1, Row = 1, ScreenId = 1 },
                new Seat { Id = 2, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "1/2", Name = "1/2", NumberInRow = 2, Row = 1, ScreenId = 1 },
                new Seat { Id = 3, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "1/3", Name = "1/3", NumberInRow = 3, Row = 1, ScreenId = 1 },
                new Seat { Id = 4, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "2/1", Name = "2/1", NumberInRow = 1, Row = 2, ScreenId = 1 },
                new Seat { Id = 5, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "2/2", Name = "2/2", NumberInRow = 2, Row = 2, ScreenId = 1 },
                new Seat { Id = 6, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "2/3", Name = "2/3", NumberInRow = 3, Row = 2, ScreenId = 1 },
                new Seat { Id = 7, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "3/1", Name = "3/1", NumberInRow = 1, Row = 3, ScreenId = 1 },
                new Seat { Id = 8, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "3/2", Name = "3/2", NumberInRow = 2, Row = 3, ScreenId = 1 },
                new Seat { Id = 9, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "3/3", Name = "3/3", NumberInRow = 3, Row = 3, ScreenId = 1 },
                new Seat { Id = 10, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "1/1", Name = "1/1", NumberInRow = 1, Row = 1, ScreenId = 2 },
                new Seat { Id = 11, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "1/2", Name = "1/2", NumberInRow = 2, Row = 1, ScreenId = 2 },
                new Seat { Id = 12, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "1/3", Name = "1/3", NumberInRow = 3, Row = 1, ScreenId = 2 },
                new Seat { Id = 13, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "2/1", Name = "2/1", NumberInRow = 1, Row = 2, ScreenId = 2 },
                new Seat { Id = 14, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "2/2", Name = "2/2", NumberInRow = 2, Row = 2, ScreenId = 2 },
                new Seat { Id = 15, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "2/3", Name = "2/3", NumberInRow = 3, Row = 2, ScreenId = 2 },
                new Seat { Id = 16, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "3/1", Name = "3/1", NumberInRow = 1, Row = 3, ScreenId = 2 },
                new Seat { Id = 17, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "3/2", Name = "3/2", NumberInRow = 2, Row = 3, ScreenId = 2 },
                new Seat { Id = 18, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "3/3", Name = "3/3", NumberInRow = 3, Row = 3, ScreenId = 2 },
                new Seat { Id = 19, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "1/1", Name = "1/1", NumberInRow = 1, Row = 1, ScreenId = 3 },
                new Seat { Id = 20, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "1/2", Name = "1/2", NumberInRow = 2, Row = 1, ScreenId = 3 },
                new Seat { Id = 21, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "1/3", Name = "1/3", NumberInRow = 3, Row = 1, ScreenId = 3 },
                new Seat { Id = 22, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "2/1", Name = "2/1", NumberInRow = 1, Row = 2, ScreenId = 3 },
                new Seat { Id = 23, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "2/2", Name = "2/2", NumberInRow = 2, Row = 2, ScreenId = 3 },
                new Seat { Id = 24, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "2/3", Name = "2/3", NumberInRow = 3, Row = 2, ScreenId = 3 },
                new Seat { Id = 25, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "3/1", Name = "3/1", NumberInRow = 1, Row = 3, ScreenId = 3 },
                new Seat { Id = 26, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "3/2", Name = "3/2", NumberInRow = 2, Row = 3, ScreenId = 3 },
                new Seat { Id = 27, CreatedAt = new DateTime(2025, 2, 2), ModifiedAt = new DateTime(2025, 2, 2), IsActive = true, Description = "3/3", Name = "3/3", NumberInRow = 3, Row = 3, ScreenId = 3 }
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
                    Name = "Screenings",
                    Action = "ShowScreeningsForMovie",
                    Controller = "Movie",
                    Content = "Screenings",
                    Position = 4
                },
                new Navbar
                {
                    Id = 5,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Cart",
                    Action = "Index",
                    Controller = "Cart",
                    Content = "Cart",
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
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

    }
}
