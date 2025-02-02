using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DatabaseAPI.Migrations
{
    /// <inheritdoc />
    public partial class initialCreateWithSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgeRating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeRating", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Award",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Award", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankAccount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coupon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CouponNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    MovieOrCafeUsage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieFormat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieFormat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieKeywords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieKeywords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieProductionCompany",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieProductionCompany", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Navbar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Navbar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Newsletter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpeningHour",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartHour = table.Column<int>(type: "int", nullable: false),
                    EndHour = table.Column<int>(type: "int", nullable: false),
                    WeekDay = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpeningHour", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Screen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNumber = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subtitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subtitles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topbar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topbar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfElementOfMenu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfElementOfMenu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsefulLink",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsefulLink", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLevel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PointsToNextLevel = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Website",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Website", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkPosition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPosition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkSchedule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearDate = table.Column<int>(type: "int", nullable: false),
                    DayNumber = table.Column<int>(type: "int", nullable: false),
                    StartHour = table.Column<int>(type: "int", nullable: false),
                    StartMinute = table.Column<int>(type: "int", nullable: false),
                    EndHour = table.Column<int>(type: "int", nullable: false),
                    EndMinute = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkSchedule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseNumber = table.Column<int>(type: "int", nullable: false),
                    ApartmentNumber = table.Column<int>(type: "int", nullable: true),
                    EirCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Row = table.Column<int>(type: "int", nullable: true),
                    NumberInRow = table.Column<int>(type: "int", nullable: true),
                    ScreenId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seat_Screen_ScreenId",
                        column: x => x.ScreenId,
                        principalTable: "Screen",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ELementOfMenu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfElementOfMenuId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ELementOfMenu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ELementOfMenu_TypeOfElementOfMenu_TypeOfElementOfMenuId",
                        column: x => x.TypeOfElementOfMenuId,
                        principalTable: "TypeOfElementOfMenu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    UserLevelId = table.Column<int>(type: "int", nullable: true),
                    UserProgressToNextLevel = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_UserLevel_UserLevelId",
                        column: x => x.UserLevelId,
                        principalTable: "UserLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Sum = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoice_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Invoice_PaymentMethod_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethod",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgeRatingId = table.Column<int>(type: "int", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    GenreId = table.Column<int>(type: "int", nullable: true),
                    MovieFormatId = table.Column<int>(type: "int", nullable: true),
                    MovieProductionCompanyId = table.Column<int>(type: "int", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    TicketPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movie_AgeRating_AgeRatingId",
                        column: x => x.AgeRatingId,
                        principalTable: "AgeRating",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Movie_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Movie_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Movie_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Movie_MovieFormat_MovieFormatId",
                        column: x => x.MovieFormatId,
                        principalTable: "MovieFormat",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Movie_MovieProductionCompany_MovieProductionCompanyId",
                        column: x => x.MovieProductionCompanyId,
                        principalTable: "MovieProductionCompany",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Actor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    AwardId = table.Column<int>(type: "int", nullable: true),
                    MovieId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Actor_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Actor_Award_AwardId",
                        column: x => x.AwardId,
                        principalTable: "Award",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Actor_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Actor_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AwardMovie",
                columns: table => new
                {
                    AwardsId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwardMovie", x => new { x.AwardsId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_AwardMovie_Award_AwardsId",
                        column: x => x.AwardsId,
                        principalTable: "Award",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AwardMovie_Movie_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Director",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    AwardId = table.Column<int>(type: "int", nullable: true),
                    MovieId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Director", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Director_Award_AwardId",
                        column: x => x.AwardId,
                        principalTable: "Award",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Director_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Director_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LanguagesMovie",
                columns: table => new
                {
                    LanguagesId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguagesMovie", x => new { x.LanguagesId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_LanguagesMovie_Languages_LanguagesId",
                        column: x => x.LanguagesId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguagesMovie_Movie_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieMovieKeywords",
                columns: table => new
                {
                    MovieKeywordsId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieMovieKeywords", x => new { x.MovieKeywordsId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_MovieMovieKeywords_MovieKeywords_MovieKeywordsId",
                        column: x => x.MovieKeywordsId,
                        principalTable: "MovieKeywords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieMovieKeywords_Movie_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieReview_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MovieSubtitles",
                columns: table => new
                {
                    MoviesId = table.Column<int>(type: "int", nullable: false),
                    SubtitlesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieSubtitles", x => new { x.MoviesId, x.SubtitlesId });
                    table.ForeignKey(
                        name: "FK_MovieSubtitles_Movie_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieSubtitles_Subtitles_SubtitlesId",
                        column: x => x.SubtitlesId,
                        principalTable: "Subtitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Screening",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScreenId = table.Column<int>(type: "int", nullable: true),
                    MovieId = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screening", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Screening_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Screening_Screen_ScreenId",
                        column: x => x.ScreenId,
                        principalTable: "Screen",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PathToPhoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: true),
                    DirectorId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photo_Actor_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Photo_Director_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Director",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScreeningId = table.Column<int>(type: "int", nullable: true),
                    SeatId = table.Column<int>(type: "int", nullable: true),
                    ReservationNumber = table.Column<long>(type: "bigint", nullable: true),
                    IsRealized = table.Column<bool>(type: "bit", nullable: false),
                    IsExpired = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservations_Screening_ScreeningId",
                        column: x => x.ScreeningId,
                        principalTable: "Screening",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservations_Seat_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seat",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ScreeningSeat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeatId = table.Column<int>(type: "int", nullable: true),
                    ScreeningId = table.Column<int>(type: "int", nullable: true),
                    IsTaken = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScreeningSeat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScreeningSeat_Screening_ScreeningId",
                        column: x => x.ScreeningId,
                        principalTable: "Screening",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ScreeningSeat_Seat_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seat",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CartElement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScreeningSeatId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartElement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartElement_ScreeningSeat_ScreeningSeatId",
                        column: x => x.ScreeningSeatId,
                        principalTable: "ScreeningSeat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InvoiceId1 = table.Column<int>(type: "int", nullable: true),
                    ScreeningSeatId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_Invoice_InvoiceId1",
                        column: x => x.InvoiceId1,
                        principalTable: "Invoice",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ticket_ScreeningSeat_ScreeningSeatId",
                        column: x => x.ScreeningSeatId,
                        principalTable: "ScreeningSeat",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AgeRating",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1157), "+12", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1210), "+12" },
                    { 2, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1214), "+15", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1216), "+15" },
                    { 3, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1219), "+18", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1221), "+18" }
                });

            migrationBuilder.InsertData(
                table: "Award",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1402), "Grammy", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1406), "Grammy" },
                    { 2, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1409), "Oscar", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1411), "Oscar" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1445), "Poland", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1447), "Poland" },
                    { 2, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1450), "USA", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1452), "USA" },
                    { 3, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1455), "Germany", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1457), "Germany" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1485), "Action", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1488), "Action" },
                    { 2, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1491), "Romance", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1492), "Romance" },
                    { 3, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1495), "Drama", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1497), "Drama" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1525), "Polish", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1527), "Polish" },
                    { 2, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1530), "English", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1531), "English" },
                    { 3, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1535), "Danish", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1537), "Danish" }
                });

            migrationBuilder.InsertData(
                table: "MovieFormat",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1562), "4:3", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1564), "4:3" },
                    { 2, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1567), "16:9", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1569), "16:9" }
                });

            migrationBuilder.InsertData(
                table: "MovieKeywords",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1604), "Superb", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1607), "Superb" },
                    { 2, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1609), "Extra", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1611), "Extra" },
                    { 3, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1614), "Magic", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1616), "Magic" }
                });

            migrationBuilder.InsertData(
                table: "MovieProductionCompany",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1642), "Warner Bros", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1644), "Warner Bros" },
                    { 2, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1647), "KOJAK", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1649), "KOJAK" },
                    { 3, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1651), "Netflix", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1653), "Netflix" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1727), "Cash", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1729), "Cash" },
                    { 2, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1732), "Credit Card", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1733), "Credit Card" }
                });

            migrationBuilder.InsertData(
                table: "Screen",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name", "RoomNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1914), "ŻABA", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1916), "ŻABA", 12 },
                    { 2, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1920), "KROWA", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1922), "KROWA", 23 },
                    { 3, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1924), "MILKY WAY", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1926), "MILKY WAY", 34 }
                });

            migrationBuilder.InsertData(
                table: "Subtitles",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1681), "Polish", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1683), "Polish" },
                    { 2, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1686), "English", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1688), "English" },
                    { 3, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1690), "Danish", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1692), "Danish" }
                });

            migrationBuilder.InsertData(
                table: "WorkPosition",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1761), "General Assistant", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1763), "General Assistant" },
                    { 2, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1766), "Floor Manager", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1768), "Floor Manager" },
                    { 3, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1771), "Cleaner", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1772), "Cleaner" }
                });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "AwardId", "CountryId", "CreatedAt", "DateOfBirth", "Description", "FirstName", "IsActive", "LastName", "MiddleName", "ModifiedAt", "MovieId", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, null, 1, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1803), new DateTime(1994, 11, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1811), "Jerzy Puławski", "Jerzy", true, "Puławski", null, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1805), null, "Jerzy Puławski", null },
                    { 2, null, 2, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1816), new DateTime(1994, 11, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1821), "John Longue", "John", true, "Longue", null, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1818), null, "John Longue", null },
                    { 3, null, 1, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1823), new DateTime(2004, 9, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1828), "Anna Kobiela", "Anna", true, "Kobiela", null, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1825), null, "Anna Kobiela", null }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "Id", "AwardId", "CountryId", "CreatedAt", "DateOfBirth", "Description", "FirstName", "IsActive", "LastName", "MiddleName", "ModifiedAt", "MovieId", "Name" },
                values: new object[,]
                {
                    { 1, null, 1, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1867), new DateTime(1974, 11, 25, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1874), "Mariusz Puławski", "Mariusz", true, "Puławski", null, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1869), null, "Mariusz Puławski" },
                    { 2, null, 2, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1879), new DateTime(1965, 3, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1883), "John Mingue", "John", true, "Mingue", null, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1880), null, "John Mingue" }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name", "NumberInRow", "Row", "ScreenId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1953), "1/1", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1956), "1/1", 1, 1, 1 },
                    { 2, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1960), "1/2", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1962), "1/2", 2, 1, 1 },
                    { 3, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1965), "1/3", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1967), "1/3", 3, 1, 1 },
                    { 4, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1970), "2/1", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1972), "2/1", 1, 2, 1 },
                    { 5, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1975), "2/2", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1977), "2/2", 2, 2, 1 },
                    { 6, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1980), "2/3", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1982), "2/3", 3, 2, 1 },
                    { 7, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1985), "3/1", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1987), "3/1", 1, 3, 1 },
                    { 8, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1990), "3/2", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1992), "3/2", 2, 3, 1 },
                    { 9, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1996), "3/3", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1998), "3/3", 3, 3, 1 },
                    { 10, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2001), "1/1", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2002), "1/1", 1, 1, 2 },
                    { 11, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2006), "1/2", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2007), "1/2", 2, 1, 2 },
                    { 12, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2010), "1/3", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2012), "1/3", 3, 1, 2 },
                    { 13, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2015), "2/1", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2017), "2/1", 1, 2, 2 },
                    { 14, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2020), "2/2", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2022), "2/2", 2, 2, 2 },
                    { 15, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2025), "2/3", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2026), "2/3", 3, 2, 2 },
                    { 16, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2029), "3/1", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2031), "3/1", 1, 3, 2 },
                    { 17, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2035), "3/2", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2037), "3/2", 2, 3, 2 },
                    { 18, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2040), "3/3", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2042), "3/3", 3, 3, 2 },
                    { 19, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2045), "1/1", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2047), "1/1", 1, 1, 3 },
                    { 20, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2050), "1/2", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2052), "1/2", 2, 1, 3 },
                    { 21, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2055), "1/3", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2056), "1/3", 3, 1, 3 },
                    { 22, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2060), "2/1", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2061), "2/1", 1, 2, 3 },
                    { 23, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2064), "2/2", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2066), "2/2", 2, 2, 3 },
                    { 24, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2069), "2/3", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2071), "2/3", 3, 2, 3 },
                    { 25, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2074), "3/1", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2076), "3/1", 1, 3, 3 },
                    { 26, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2079), "3/2", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2081), "3/2", 2, 3, 3 },
                    { 27, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2084), "3/3", true, new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2086), "3/3", 3, 3, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actor_AwardId",
                table: "Actor",
                column: "AwardId");

            migrationBuilder.CreateIndex(
                name: "IX_Actor_CountryId",
                table: "Actor",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Actor_MovieId",
                table: "Actor",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Actor_UserId",
                table: "Actor",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_CountryId",
                table: "Address",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AddressId",
                table: "AspNetUsers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserLevelId",
                table: "AspNetUsers",
                column: "UserLevelId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AwardMovie_MoviesId",
                table: "AwardMovie",
                column: "MoviesId");

            migrationBuilder.CreateIndex(
                name: "IX_CartElement_ScreeningSeatId",
                table: "CartElement",
                column: "ScreeningSeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Director_AwardId",
                table: "Director",
                column: "AwardId");

            migrationBuilder.CreateIndex(
                name: "IX_Director_CountryId",
                table: "Director",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Director_MovieId",
                table: "Director",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_ELementOfMenu_TypeOfElementOfMenuId",
                table: "ELementOfMenu",
                column: "TypeOfElementOfMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_PaymentMethodId",
                table: "Invoice",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_UserId",
                table: "Invoice",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguagesMovie_MoviesId",
                table: "LanguagesMovie",
                column: "MoviesId");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_AgeRatingId",
                table: "Movie",
                column: "AgeRatingId");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_CountryId",
                table: "Movie",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_GenreId",
                table: "Movie",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_MovieFormatId",
                table: "Movie",
                column: "MovieFormatId");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_MovieProductionCompanyId",
                table: "Movie",
                column: "MovieProductionCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_UserId",
                table: "Movie",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieMovieKeywords_MoviesId",
                table: "MovieMovieKeywords",
                column: "MoviesId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieReview_MovieId",
                table: "MovieReview",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieSubtitles_SubtitlesId",
                table: "MovieSubtitles",
                column: "SubtitlesId");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_ActorId",
                table: "Photo",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_DirectorId",
                table: "Photo",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ScreeningId",
                table: "Reservations",
                column: "ScreeningId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_SeatId",
                table: "Reservations",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Screening_MovieId",
                table: "Screening",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Screening_ScreenId",
                table: "Screening",
                column: "ScreenId");

            migrationBuilder.CreateIndex(
                name: "IX_ScreeningSeat_ScreeningId",
                table: "ScreeningSeat",
                column: "ScreeningId");

            migrationBuilder.CreateIndex(
                name: "IX_ScreeningSeat_SeatId",
                table: "ScreeningSeat",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Seat_ScreenId",
                table: "Seat",
                column: "ScreenId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_InvoiceId1",
                table: "Ticket",
                column: "InvoiceId1");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_ScreeningSeatId",
                table: "Ticket",
                column: "ScreeningSeatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AwardMovie");

            migrationBuilder.DropTable(
                name: "BankAccount");

            migrationBuilder.DropTable(
                name: "CartElement");

            migrationBuilder.DropTable(
                name: "ContactInformation");

            migrationBuilder.DropTable(
                name: "Coupon");

            migrationBuilder.DropTable(
                name: "ELementOfMenu");

            migrationBuilder.DropTable(
                name: "LanguagesMovie");

            migrationBuilder.DropTable(
                name: "MovieMovieKeywords");

            migrationBuilder.DropTable(
                name: "MovieReview");

            migrationBuilder.DropTable(
                name: "MovieSubtitles");

            migrationBuilder.DropTable(
                name: "Navbar");

            migrationBuilder.DropTable(
                name: "Newsletter");

            migrationBuilder.DropTable(
                name: "OpeningHour");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Topbar");

            migrationBuilder.DropTable(
                name: "UsefulLink");

            migrationBuilder.DropTable(
                name: "Website");

            migrationBuilder.DropTable(
                name: "WorkPosition");

            migrationBuilder.DropTable(
                name: "WorkSchedule");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "TypeOfElementOfMenu");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "MovieKeywords");

            migrationBuilder.DropTable(
                name: "Subtitles");

            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropTable(
                name: "Director");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "ScreeningSeat");

            migrationBuilder.DropTable(
                name: "Award");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "Screening");

            migrationBuilder.DropTable(
                name: "Seat");

            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Screen");

            migrationBuilder.DropTable(
                name: "AgeRating");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "MovieFormat");

            migrationBuilder.DropTable(
                name: "MovieProductionCompany");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "UserLevel");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
