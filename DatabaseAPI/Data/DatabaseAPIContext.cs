using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Models.CinemaMovie.DictionaryModels;
using DatabaseAPI.Models.CMS;
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
        public DbSet<Movie>? Movie { get; set; }
        public DbSet<MovieReview>? MovieReview { get; set; }
        public DbSet<Screen>? Screen { get; set; }
        public DbSet<Screening>? Screening { get; set; }
        public DbSet<Seat>? Seat { get; set; }
        public DbSet<Ticket>? Ticket { get; set; }
        public DbSet<PaymentMethod>? PaymentMethod { get; set; }
        public DbSet<Address>? Address { get; set; }
        public DbSet<OpeningHour>? OpeningHour { get; set; }
        public DbSet<Actor>? Actor { get; set; }
        public DbSet<User>? User { get; set; }
        public DbSet<UserLevel>? UserLevel { get; set; }
        public DbSet<Director>? Director { get; set; }
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
        public DbSet<CustomerQuery>? CustomerQuery { get; set; }
        public DbSet<Subscriber>? Subscriber { get; set; }
        public DbSet<InvoiceTemplateInformation>? InvoiceTemplateInformation { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ScreeningSeat>()
        .HasOne(ss => ss.Screening)
        .WithMany(s => s.ScreeningSeats)
        .HasForeignKey(ss => ss.ScreeningId)
        .OnDelete(DeleteBehavior.Cascade);

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


            builder.Entity<Seat>().HasData(GenerateSeats());


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
                    Name = "Movies",
                    Action = "Index",
                    Controller = "Movie",
                    Content = "Movies",
                    Position = 2
                },
                new Navbar
                {
                    Id = 3,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Cart",
                    Action = "Index",
                    Controller = "Cart",
                    Content = "Cart",
                    Position = 3
                },
                new Navbar
                {
                    Id = 4,
                    CreatedAt = new DateTime(2025, 2, 2),
                    ModifiedAt = new DateTime(2025, 2, 2),
                    IsActive = true,
                    Description = "",
                    Name = "Contact",
                    Action = "Contact",
                    Controller = "Home",
                    Content = "Contact",
                    Position = 4
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
                    Content = "<div class=\"input-group\">\r\n    <form method=\"post\" action=\"~/AddSubscriber\">\r\n        <input type=\"text\" name=\"email\" class=\"form-control bg-black\" placeholder=\"Email\">\r\n        <span class=\"input-group-btn\">\r\n            <button class=\"btn btn text-white bg_red rounded-0 border-0\" type=\"submit\">\r\n                Subscribe\r\n            </button>\r\n        </span>\r\n    </form>\r\n</div>",
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
                    Content = "<a href=\"/Movie\\Index\">Movies</a>",
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
                    Content = "<a href=\"/Cart\\Index\">Cart</a>",
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
                    Content = "<a href=\"/Identity/Account/Manage\">Profile</a>",
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
                    Content = "<a href=\"/Contact\">Contact</a>",
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
                    Description = "http://localhost/Images/photos/privacy.png",
                    Name = "Privacy",
                    TitleName = "Privacy",
                    Content = " \r\n  \r\n\r\n<div class=\"container\">\r\n    <h2><strong>Privacy Policy</strong></h2>\r\n    <p><strong>Effective Date:</strong> 02.05.2025</p>\r\n\r\n    <p>\r\n        Welcome to MovieStar! We are committed to protecting your personal data and ensuring transparency in how we collect, \r\n        use, and secure your information. This Privacy Policy outlines our data processing practices and your rights.\r\n    </p>\r\n\r\n    <h4><strong>1. Information We Collect</strong></h4>\r\n    <ul>\r\n        <li><strong>Personal Data:</strong> Name, email address, phone number, payment details (if applicable), and account preferences.</li>\r\n        <li><strong>Non-Personal Data:</strong> IP address, device type, browser details, and site usage statistics.</li>\r\n        <li><strong>Cookies & Tracking:</strong> We use cookies to enhance your browsing experience and improve our services.</li>\r\n    </ul>\r\n\r\n    <h4><strong>2. How We Use Your Information</strong></h4>\r\n    <ul>\r\n        <li>To provide, manage, and improve our services.</li>\r\n        <li>To process payments and bookings securely.</li>\r\n        <li>To personalize your experience based on preferences.</li>\r\n        <li>To send updates, promotions, and important notifications.</li>\r\n        <li>To comply with legal and regulatory requirements.</li>\r\n    </ul>\r\n\r\n    <h4><strong>3. Data Security & Protection</strong></h4>\r\n    <p>\r\n        We implement advanced security measures, including encryption, secure servers, and regular security audits, \r\n        to protect your personal data. However, while we strive for maximum security, no system is entirely foolproof. \r\n        We recommend using strong passwords and safeguarding your login credentials.\r\n    </p>\r\n\r\n    <h4><strong>4. Third-Party Sharing</strong></h4>\r\n    <p>\r\n        We do not sell your personal data. However, we may share necessary information with trusted third parties \r\n        for the following reasons:\r\n    </p>\r\n    <ul>\r\n        <li>Processing payments through secure gateways.</li>\r\n        <li>Ensuring compliance with legal and regulatory obligations.</li>\r\n        <li>Improving our services through analytics and feedback tools.</li>\r\n    </ul>\r\n\r\n    <h4><strong>5. Your Rights & Choices</strong></h4>\r\n    <p>\r\n        You have full control over your data. Your rights include:\r\n    </p>\r\n    <ul>\r\n        <li><span class=\"highlight\">Access & Review:</span> Request details about the data we hold on you.</li>\r\n        <li><span class=\"highlight\">Corrections:</span> Update any incorrect or outdated personal information.</li>\r\n        <li><span class=\"highlight\">Deletion:</span> Request removal of your data under applicable laws.</li>\r\n        <li><span class=\"highlight\">Opt-Out:</span> Manage communication preferences and unsubscribe from promotional messages.</li>\r\n    </ul>\r\n    <p>\r\n        To exercise any of these rights, contact us at: <strong>[Insert Contact Info]</strong>.\r\n    </p>\r\n\r\n    <h4><strong>6. Cookies & Tracking Technologies</strong></h4>\r\n    <p>\r\n        We use cookies and similar tracking technologies to enhance functionality, analyze usage trends, and deliver personalized content. \r\n        You can manage cookie preferences in your browser settings.\r\n    </p>\r\n\r\n    <h4><strong>7. Changes to This Policy</strong></h4>\r\n    <p>\r\n        We may update this Privacy Policy from time to time. Any changes will be posted on this page with an updated effective date. \r\n        We encourage you to review this policy periodically to stay informed.\r\n    </p>\r\n\r\n    <p  style = \"color:red\";>MovieStar Team</p>\r\n</div>\r\n\r\n "
                },
                new Website
                {
                    Id = 2,
                    Description = "http://localhost/Images/photos/termsandconditions.png",
                    Name = "TermsAndConditions",
                    TitleName = "Terms and Conditions",
                    Content = " \r\n<div class=\"container\">\r\n    <div class=\"faq-container\">\r\n        <h2>Frequently Asked Questions</h2>\r\n        <p class=\"text-center\" style=\"color: red;\">Here you will find answers to the most common questions. We update this section regularly.</p>\r\n\r\n        <div class=\"faq-section\">\r\n            <h4><i class=\"bi bi-info-circle\"></i> General Questions</h4>\r\n            <div class=\"faq-item\">\r\n                <strong>Q: What are your operating hours?</strong>\r\n                <p>A: We are open from <strong>10 AM - 10 PM</strong> daily, including weekends.</p>\r\n            </div>\r\n            <div class=\"faq-item\">\r\n                <strong>Q: How can I buy tickets?</strong>\r\n                <p>A: You can purchase tickets online through our <strong>official website</strong> or at the cinema.</p>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"faq-section\">\r\n            <h4><i class=\"bi bi-ticket-perforated\"></i> Ticketing & Refunds</h4>\r\n            <div class=\"faq-item\">\r\n                <strong>Q: Can I cancel or refund my ticket?</strong>\r\n                <p>A: Please check our <a href=\"#\">Refund & Cancellation Policy</a> for specific terms.</p>\r\n            </div>\r\n            <div class=\"faq-item\">\r\n                <strong>Q: Do you offer discounts?</strong>\r\n                <p>A: Yes! We offer special discounts for students, seniors, and groups. Check our website for current offers.</p>\r\n            </div>\r\n            <div class=\"faq-item\">\r\n                <strong>Q: Can I reserve a seat?</strong>\r\n                <p>A: Seat selection is available when purchasing a ticket online.</p>\r\n            </div>\r\n            <div class=\"faq-item\">\r\n                <strong>Q: What payment methods do you accept?</strong>\r\n                <p>A: We accept cash, credit/debit cards, and online payments via Stripe.</p>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"faq-section\">\r\n            <h4><i class=\"bi bi-popcorn\"></i> Experience & Services</h4>\r\n            <div class=\"faq-item\">\r\n                <strong>Q: Do you have VIP or premium seats?</strong>\r\n                <p>A: Yes! We offer luxury seating options for a more comfortable experience.</p>\r\n            </div>\r\n            <div class=\"faq-item\">\r\n                <strong>Q: Are food and drinks allowed inside?</strong>\r\n                <p>A: We offer a variety of snacks and beverages at our concession stands. Outside food is not permitted.</p>\r\n            </div>\r\n            <div class=\"faq-item\">\r\n                <strong>Q: Do you provide accessibility options?</strong>\r\n                <p>A: Yes! We have wheelchair-accessible seating and assistive listening devices available upon request.</p>\r\n            </div>\r\n        </div>\r\n\r\n        <p class=\"faq-footer\">Still have questions? Contact us via the <a href=\"#\">Contact Us</a> page!</p>\r\n    </div>\r\n</div>\r\n\r\n "
                },
                new Website
                {
                    Id = 3,
                    Description = "http://localhost/Images/photos/aboutus.png",
                    Name = "AboutUs",
                    TitleName = "About Us",
                    Content = " \r\n<div class=\"container\">\r\n    <div class=\"cinema-intro\">\r\n        <i class=\"fas fa-film\"></i>\r\n        <h4>Welcome to <span class=\"highlight\">MovieStar Cinema!</span></h4>\r\n        \r\n        <p>\r\n            At <span class=\"highlight\">MovieStar Cinema</span>, we bring the **magic of movies** to life! Whether you're a fan of \r\n            the **latest blockbusters**, **critically acclaimed dramas**, or **timeless classics**, our theaters provide a truly **immersive experience**.\r\n        </p>\r\n\r\n        <p>\r\n            Our state-of-the-art theaters feature **ultra-HD screens**, **Dolby Atmos surround sound**, and **luxurious seating**, ensuring maximum comfort.  \r\n            Enjoy the **vibrant colors**, **crystal-clear visuals**, and **rich, deep sound** that put you right at the heart of every scene.\r\n        </p>\r\n\r\n        <p>\r\n            Whether you're looking for an **action-packed adventure**, a **heartwarming family film**, or a **thrilling horror experience**,  \r\n            our diverse selection of movies offers **something for everyone**. Plus, we host **exclusive premieres**, **sneak previews**, and **special screenings**  \r\n            to bring you even closer to the world of cinema.\r\n        </p>\r\n\r\n        <p>\r\n            Make your visit even more enjoyable with our **gourmet snack bar**, featuring everything from **classic popcorn and nachos**  \r\n            to **premium chocolates, freshly baked pastries, and barista-style coffee**. Want to make it extra special?  \r\n            Try our **VIP lounge**, where you can relax with a selection of fine wines and cocktails before your movie starts.\r\n        </p>\r\n\r\n        <p>\r\n            We also offer **private screenings, birthday parties, and corporate events**, providing a unique and personalized movie experience  \r\n            tailored just for you and your guests.\r\n        </p>\r\n\r\n        <p style=\"color:red\";> \r\n            <strong>Thank you for choosing MovieStar Cinema—where every story comes to life on the big screen!</strong>\r\n        </p>\r\n    </div>\r\n</div>\r\n \r\n"
                },
                new Website
                {
                    Id = 4,
                    Description = "http://localhost/Images/photos/faq.png",
                    Name = "FAQ",
                    TitleName = "FAQ",
                    Content = " \r\n\r\n<div class=\"container\">\r\n    <div class=\"faq-container\">\r\n        <h3><i class=\"fas fa-question-circle\"></i> Frequently Asked Questions</h3>\r\n        <p class=\"faq-intro\">Find answers to our most common questions. We update this section regularly.</p>\r\n\r\n        <div class=\"accordion\" id=\"faqAccordion\">\r\n            <!-- General Questions -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-info-circle\"></i> General Questions</h4>\r\n\r\n            <div class=\"accordion-item\" >\r\n                <h2 class=\"accordion-header\" id=\"headingOne\">\r\n                    <button class=\"accordion-button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseOne\">\r\n                        Q: What are your operating hours?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseOne\" class=\"accordion-collapse collapse show\" data-bs-parent=\"#faqAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: We are open daily from <strong>10 AM - 10 PM</strong>, including weekends and holidays.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingTwo\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseTwo\">\r\n                        Q: How can I buy tickets?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseTwo\" class=\"accordion-collapse collapse\" data-bs-parent=\"#faqAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: You can purchase tickets online via our website or buy them directly at the cinema counter.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Ticketing & Refunds -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-ticket-alt\"></i> Ticketing & Refunds</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingThree\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseThree\">\r\n                        Q: Can I cancel or refund my ticket?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseThree\" class=\"accordion-collapse collapse\" data-bs-parent=\"#faqAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: Please refer to our <a href=\"#\">Refund & Cancellation Policy</a> for specific terms.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingFour\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseFour\">\r\n                        Q: Do you offer discounts?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseFour\" class=\"accordion-collapse collapse\" data-bs-parent=\"#faqAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: Yes! We offer student, senior, and group discounts. Check our website for current offers.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingFive\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseFive\">\r\n                        Q: Can I reserve a seat in advance?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseFive\" class=\"accordion-collapse collapse\" data-bs-parent=\"#faqAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: Yes! Seat selection is available when purchasing tickets online.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingSix\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseSix\">\r\n                        Q: What payment methods do you accept?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseSix\" class=\"accordion-collapse collapse\" data-bs-parent=\"#faqAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: We accept cash, credit/debit cards, and online payments via Stripe.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Additional Information -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-concierge-bell\"></i> Services & Experience</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingSeven\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseSeven\">\r\n                        Q: Do you offer VIP or premium seating?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseSeven\" class=\"accordion-collapse collapse\" data-bs-parent=\"#faqAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: Yes! We have luxury seating options and VIP lounges for a premium experience.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <p class=\"text-center mt-4\">Still have questions? Contact us via the <a href=\"#\">Contact Us</a> page!</p>\r\n    </div>\r\n</div>\r\n \r\n"
                },
                new Website
                {
                    Id = 5,
                    Description = "http://localhost/Images/photos/refund.png",
                    Name = "Refund",
                    TitleName = "Refund and Cancellation Policy",
                    Content = " \r\n\r\n<div class=\"container\">\r\n    <div class=\"refund-container\">\r\n        <h3><i class=\"fas fa-undo-alt\"></i> Refund & Cancellation Policy</h3>\r\n        <p class=\"refund-intro\">At MovieStar Cinema, we strive to provide the best experience. However, we understand that plans may change.</p>\r\n\r\n        <div class=\"accordion\" id=\"refundAccordion\">\r\n            <!-- Ticket Refunds -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-ticket-alt\"></i> Ticket Refunds</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingOne\">\r\n                    <button class=\"accordion-button\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseOne\">\r\n                        Q: Can I get a refund for my ticket?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseOne\" class=\"accordion-collapse collapse show\" data-bs-parent=\"#refundAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: Yes, tickets are refundable if canceled at least **24 hours before the showtime**.  \r\n                        Refunds are processed within **3-5 business days**.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Cancellations Due to Technical Issues -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-exclamation-circle\"></i> Cancellations Due to Technical Issues</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingTwo\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseTwo\">\r\n                        Q: What happens if the movie is canceled?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseTwo\" class=\"accordion-collapse collapse\" data-bs-parent=\"#refundAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: If a movie is **canceled due to technical issues**, we offer a **full refund**  \r\n                        or the option to **rebook for another date at no additional cost**.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- No-Show Policy -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-ban\"></i> No-Show Policy</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingThree\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseThree\">\r\n                        Q: What if I miss my show?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseThree\" class=\"accordion-collapse collapse\" data-bs-parent=\"#refundAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: If you **fail to attend your movie** without canceling at least 24 hours in advance,  \r\n                        **no refund will be issued**. We recommend managing your bookings carefully.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Payment and Refund Requests -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-credit-card\"></i> Payment & Refund Requests</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingFour\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseFour\">\r\n                        Q: How do I request a refund?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseFour\" class=\"accordion-collapse collapse\" data-bs-parent=\"#refundAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: To request a refund, please contact our support team at **info@gmail.com**  \r\n                        with your **booking details and reason for refund**.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingFive\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseFive\">\r\n                        Q: What payment methods are accepted?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseFive\" class=\"accordion-collapse collapse\" data-bs-parent=\"#refundAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: We accept payments via **credit/debit cards, PayPal, and Stripe**.  \r\n                        Refunds are processed back to the **original payment method**.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingSix\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseSix\">\r\n                        Q: Are gift cards refundable?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseSix\" class=\"accordion-collapse collapse\" data-bs-parent=\"#refundAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: Unfortunately, **gift cards are non-refundable** and cannot be exchanged for cash.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <p class=\"text-center mt-4\">For further assistance, contact us via <a href=\"#\">Customer Support</a>!</p>\r\n    </div>\r\n</div>\r\n \r\n"
                },
                new Website
                {
                    Id = 6,
                    Description = "http://localhost/Images/photos/cookies.png",
                    Name = "CookiePolicy",
                    TitleName = "Cookie Policy",
                    Content = " \r\n\r\n<div class=\"container\">\r\n    <div class=\"cookie-container\">\r\n        <h3><i class=\"fas fa-cookie-bite\"></i> Cookie Policy</h3>\r\n        <p class=\"cookie-intro\">MovieStar Cinema uses cookies to enhance your browsing experience. Learn more below.</p>\r\n\r\n        <div class=\"accordion\" id=\"cookieAccordion\">\r\n            <!-- What Are Cookies? -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-info-circle\"></i> What Are Cookies?</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingOne\">\r\n                    <button class=\"accordion-button\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseOne\">\r\n                        Q: What are cookies and why do we use them?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseOne\" class=\"accordion-collapse collapse show\" data-bs-parent=\"#cookieAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: Cookies are **small text files** stored on your device when you visit our website.  \r\n                        They help improve website functionality, **remember user preferences**, and **enable analytics**.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- How We Use Cookies -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-cogs\"></i> How We Use Cookies</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingTwo\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseTwo\">\r\n                        Q: How does MovieStar Cinema use cookies?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseTwo\" class=\"accordion-collapse collapse\" data-bs-parent=\"#cookieAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: We use cookies for the following purposes:\r\n                        <ul>\r\n                            <li>To **enhance website performance** and user experience.</li>\r\n                            <li>To **remember your settings and preferences**.</li>\r\n                            <li>To analyze website traffic using **Google Analytics and similar tools**.</li>\r\n                            <li>For **marketing and targeted advertising**.</li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Types of Cookies -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-list\"></i> Types of Cookies</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingThree\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseThree\">\r\n                        Q: What types of cookies do we use?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseThree\" class=\"accordion-collapse collapse\" data-bs-parent=\"#cookieAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: We use the following types of cookies:\r\n                        <ul>\r\n                            <li><strong>Essential Cookies:</strong> Required for basic site functionality.</li>\r\n                            <li><strong>Performance Cookies:</strong> Help us analyze website usage and improve performance.</li>\r\n                            <li><strong>Functional Cookies:</strong> Remember user preferences and settings.</li>\r\n                            <li><strong>Marketing Cookies:</strong> Used for targeted ads and promotions.</li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Managing Cookies -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-user-cog\"></i> Managing Your Cookie Preferences</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingFour\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseFour\">\r\n                        Q: How can I manage or disable cookies?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseFour\" class=\"accordion-collapse collapse\" data-bs-parent=\"#cookieAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: You can **adjust your cookie settings anytime** in your browser:\r\n                        <ul>\r\n                            <li>For Chrome: <a href=\"https://support.google.com/chrome/answer/95647\">Manage Cookies</a></li>\r\n                            <li>For Firefox: <a href=\"https://support.mozilla.org/en-US/kb/enable-and-disable-cookies-website-preferences\">Manage Cookies</a></li>\r\n                            <li>For Safari: <a href=\"https://support.apple.com/en-us/HT201265\">Manage Cookies</a></li>\r\n                            <li>For Edge: <a href=\"https://support.microsoft.com/en-us/help/4027947/microsoft-edge-delete-cookies\">Manage Cookies</a></li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Privacy Policy -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-shield-alt\"></i> Privacy & Data Protection</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingFive\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseFive\">\r\n                        Q: Where can I read more about data privacy?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseFive\" class=\"accordion-collapse collapse\" data-bs-parent=\"#cookieAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: For more details on how we handle personal data, visit our <a href=\"#\">Privacy Policy</a>.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <p class=\"text-center mt-4\">For further assistance, contact us via <a href=\"#\">Customer Support</a>!</p>\r\n    </div>\r\n</div>\r\n "
                },
                new Website
                {
                    Id = 7,
                    Description = "http://localhost/Images/photos/career.png",
                    Name = "Career",
                    TitleName = "Career",
                    Content = " \r\n\r\n<div class=\"container\">\r\n    <div class=\"careers-container\">\r\n        <h3><i class=\"fas fa-briefcase\"></i> Careers at MovieStar Cinema</h3>\r\n        <p class=\"careers-intro\">Are you passionate about movies and customer service? Join our team and make every cinema experience special!</p>\r\n\r\n        <div class=\"accordion\" id=\"careersAccordion\">\r\n            <!-- Job Openings -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-bullhorn\"></i> Current Openings</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingOne\">\r\n                    <button class=\"accordion-button\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseOne\">\r\n                        Q: What positions are available?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseOne\" class=\"accordion-collapse collapse show\" data-bs-parent=\"#careersAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        We are currently hiring for the following positions:\r\n                        <ul>\r\n                            <li><strong>🎟 Ticket Sales Associate:</strong> Assisting customers with ticket purchases.</li>\r\n                            <li><strong>🍿 Concessions & Food Service:</strong> Preparing and serving snacks.</li>\r\n                            <li><strong>🎬 Cinema Manager:</strong> Overseeing daily operations and staff.</li>\r\n                            <li><strong>🎥 Projection & Technical Team:</strong> Managing cinema equipment and screenings.</li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Benefits -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-gift\"></i> Employee Benefits</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingTwo\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseTwo\">\r\n                        Q: What benefits do MovieStar Cinema employees receive?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseTwo\" class=\"accordion-collapse collapse\" data-bs-parent=\"#careersAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        Working with us comes with exciting perks:\r\n                        <ul>\r\n                            <li>🎟 **Free & discounted movie tickets**</li>\r\n                            <li>🍿 **Discounts on food and drinks**</li>\r\n                            <li>📅 **Flexible work schedules**</li>\r\n                            <li>🎉 **Fun and friendly work environment**</li>\r\n                            <li>📈 **Career growth opportunities**</li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Requirements -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-user-check\"></i> Job Requirements</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingThree\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseThree\">\r\n                        Q: What are the job requirements?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseThree\" class=\"accordion-collapse collapse\" data-bs-parent=\"#careersAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        Ideal candidates should have:\r\n                        <ul>\r\n                            <li>🌟 A **positive attitude** and customer service skills.</li>\r\n                            <li>⌚ **Availability to work evenings and weekends**.</li>\r\n                            <li>🏃‍♂️ Ability to work in a **fast-paced environment**.</li>\r\n                            <li>📢 **Good communication skills**.</li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Application Process -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-file-alt\"></i> How to Apply</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingFour\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseFour\">\r\n                        Q: How do I apply for a job?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseFour\" class=\"accordion-collapse collapse\" data-bs-parent=\"#careersAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        To apply, send your **resume and cover letter** to:  \r\n                        📧 <strong>info@gmail.com</strong>  \r\n                        Please include the **position you're applying for** in the subject line.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Interview Process -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-comments\"></i> Interview Process</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingFive\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseFive\">\r\n                        Q: What is the hiring process like?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseFive\" class=\"accordion-collapse collapse\" data-bs-parent=\"#careersAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        Our hiring process includes:\r\n                        <ul>\r\n                            <li>📩 **Application review**</li>\r\n                            <li>📞 **Phone interview** (for selected candidates)</li>\r\n                            <li>👥 **In-person interview** at our cinema</li>\r\n                            <li>✅ **Final selection & job offer**</li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <p class=\"text-center mt-4\">Want to be part of our team? Apply now at <strong style =\"color: red;\">info@gmail.com</strong>!</p>\r\n    </div>\r\n</div>\r\n \r\n"
                },
                new Website
                {
                    Id = 8,
                    Description = "http://localhost/Images/photos/partnership.png",
                    Name = "Partnership",
                    TitleName = "Partnership",
                    Content = " \r\n<div class=\"container\">\r\n    <div class=\"partnership-container\">\r\n        <h3><i class=\"fas fa-handshake\"></i> Partnerships & Advertising</h3>\r\n        <p class=\"partnership-intro\">Want to showcase your brand to thousands of moviegoers? Explore premium advertising and sponsorship opportunities with MovieStar Cinema!</p>\r\n\r\n        <div class=\"accordion\" id=\"partnershipAccordion\">\r\n            <!-- Advertising Options -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-bullhorn\"></i> Advertising Opportunities</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingOne\">\r\n                    <button class=\"accordion-button\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseOne\">\r\n                        Q: What advertising options are available?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseOne\" class=\"accordion-collapse collapse show\" data-bs-parent=\"#partnershipAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        We offer multiple **advertising formats** to promote your brand:\r\n                        <ul>\r\n                            <li>🎬 **On-screen ads** before movies (30-60 seconds spots).</li>\r\n                            <li>🌐 **Digital banners** on our website & mobile app.</li>\r\n                            <li>🎭 **Promotional events** and **brand activations** in our cinemas.</li>\r\n                            <li>📢 **In-theater posters, standees, and flyers**.</li>\r\n                            <li>🎁 **Branded giveaways and sponsorship packages**.</li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Partnership Benefits -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-chart-line\"></i> Why Partner with Us?</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingTwo\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseTwo\">\r\n                        Q: What are the benefits of advertising with MovieStar Cinema?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseTwo\" class=\"accordion-collapse collapse\" data-bs-parent=\"#partnershipAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        Partnering with us provides:\r\n                        <ul>\r\n                            <li>🎯 **Targeted exposure** to engaged audiences.</li>\r\n                            <li>📊 **High recall rates** with cinema advertising.</li>\r\n                            <li>💼 **Premium placement** in a high-traffic entertainment venue.</li>\r\n                            <li>📢 **Direct engagement** through promotional events.</li>\r\n                            <li>🌍 **Nationwide reach** with multiple cinema locations.</li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Event Sponsorships -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-star\"></i> Event Sponsorships</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingThree\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseThree\">\r\n                        Q: Can I sponsor an event at MovieStar Cinema?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseThree\" class=\"accordion-collapse collapse\" data-bs-parent=\"#partnershipAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        Yes! We offer **event sponsorship** for:\r\n                        <ul>\r\n                            <li>🎉 **Movie premieres & special screenings**.</li>\r\n                            <li>🍿 **Exclusive fan events & meet-and-greets**.</li>\r\n                            <li>🏆 **Film festivals & charity screenings**.</li>\r\n                            <li>🎁 **Branded giveaways & product launches**.</li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Partnership Options -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-handshake\"></i> Partnership Opportunities</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingFour\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseFour\">\r\n                        Q: What kind of partnerships do you offer?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseFour\" class=\"accordion-collapse collapse\" data-bs-parent=\"#partnershipAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        We welcome **long-term partnerships** with:\r\n                        <ul>\r\n                            <li>🎬 **Film distributors & studios**.</li>\r\n                            <li>🏪 **Brands & corporate sponsors**.</li>\r\n                            <li>🎟 **Loyalty program partners**.</li>\r\n                            <li>📢 **Local businesses for community promotions**.</li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Contact Information -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-envelope\"></i> Get in Touch</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingFive\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseFive\">\r\n                        Q: How do I start a partnership or book an ad?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseFive\" class=\"accordion-collapse collapse\" data-bs-parent=\"#partnershipAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        Contact our **marketing team** at:  \r\n                        📧 <strong>info@gmail.com</strong>  \r\n                        Let’s create something amazing together!\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <p class=\"text-center mt-4\">Interested? Contact us today at <strong>info@gmail.com</strong> to discuss collaboration opportunities!</p>\r\n    </div>\r\n</div>\r\n\r\n \r\n"
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


            builder.Entity<OpeningHour>().HasData(
                new OpeningHour
                {
                    Id = 1,
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Name = "Monday",
                    StartHour = 10,
                    EndHour = 22,
                },
                new OpeningHour
                {
                    Id = 2,
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Name = "Tuesday",
                    StartHour = 10,
                    EndHour = 22,
                },
                new OpeningHour
                {
                    Id = 3,
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Name = "Wednesday",
                    StartHour = 10,
                    EndHour = 22,
                },
                new OpeningHour
                {
                    Id = 4,
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Name = "Thursday",
                    StartHour = 10,
                    EndHour = 22,
                },
                new OpeningHour
                {
                    Id = 5,
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Name = "Friday",
                    StartHour = 10,
                    EndHour = 22,
                },
                new OpeningHour
                {
                    Id = 6,
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Name = "Saturday",
                    StartHour = 11,
                    EndHour = 23,
                },
                new OpeningHour
                {
                    Id = 7,
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Name = "Sunday",
                    StartHour = 10,
                    EndHour = 19,
                },
                new OpeningHour
                {
                    Id = 8,
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Name = "Christmas' Eve",
                    StartHour = 9,
                    EndHour = 14,
                },
                new OpeningHour
                {
                    Id = 9,
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Name = "Christmas' Day"
                },
                new OpeningHour
                {
                    Id = 10,
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Name = "Stephen's Day"
                });

            builder.Entity<Coupon>().HasData(
                new Coupon
                {
                    Id = 1,
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Discount = 5,
                    Name = "MOVIE5",
                    Description = "Coupon for 5%"
                },
                new Coupon
                {
                    Id = 2,
                    CreatedAt = new DateTime(2025, 2, 7),
                    ModifiedAt = new DateTime(2025, 2, 7),
                    IsActive = true,
                    Discount = 20,
                    Name = "MOVIE20",
                    Description = "Coupon for 20%"
                });

            builder.Entity<InvoiceTemplateInformation>().HasData(
                new InvoiceTemplateInformation
                {
                    Id = 1,
                    AddressStreet = "Biała 34",
                    AddressCountry = "Polska",
                    AddressCity = "Nowy Sącz",
                    AddressZipCode = "33-300",
                    AddressPhone = "+48 553432354",
                    AddressCompanyName = "MovieStar",
                    AddressState = "Małopolskie",
                    AddressEmail = "info@gmail.com",
                    Font = "Arial",
                    HexHeaderColor = "#FFF544",
                    SellerHeader = "Beneficiary",
                    BuyerHeader = "Recipent",
                    ItemHeader = "Tickets",
                    AlertWithoutItems = "There is no added tickets!",
                    AlertItemsHeader = "No tickets!",
                    AlertWithoutPayments = "There are no made payments!",
                    AlertPaymentHeader = "No payments!",
                    PaymentHeader = "Payments",
                    FinalText = "Thank you and come back soon!"
                });

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

        }

        private Seat BuildSeat(int id, DateTime createdAt, DateTime modifiedAt, Boolean isActive, string description, string name, int numberInRow, int row, int screenId)
        {
            return new Seat
            {
                Id = id,
                CreatedAt = createdAt,
                ModifiedAt = modifiedAt,
                IsActive = isActive,
                Description = description,
                Name = name,
                NumberInRow = numberInRow,
                Row = row,
                ScreenId = screenId
            };
        }

        private List<Seat> GenerateSeats()
        {
            var predefinedTime = new DateTime(2025, 2, 2);
            List<Seat> seats = new List<Seat>();
            int currentId = 1;
            for (int i = 1; i < 4; i++) // screenId
            {
                for (int j = 1; j < 6; j++) // row number
                {
                    for (int k = 1; k < 11; k++) // seat in a row number
                    {
                        string rowLetter = ((char)('A' + j - 1)).ToString(); // Convert row number to letter (A-E)
                        string seatName = $"{rowLetter}{k}";
                        seats.Add(BuildSeat(currentId++, predefinedTime, predefinedTime, true, seatName, seatName, k, j, i));
                    }
                }
            }
            return seats;
        }
    }
}
