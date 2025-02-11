using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DatabaseAPI.Migrations
{
    /// <inheritdoc />
    public partial class newInit : Migration
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
                name: "Bottombar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bottombar", x => x.Id);
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
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Discount = table.Column<int>(type: "int", nullable: false),
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
                name: "FooterIcon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FooterIcon", x => x.Id);
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
                    Controller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    InvoiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TicketSum = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StripeSessionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StripePaymentIntentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CouponId = table.Column<int>(type: "int", nullable: true),
                    CouponDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalSum = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
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
                        name: "FK_Invoice_Coupon_CouponId",
                        column: x => x.CouponId,
                        principalTable: "Coupon",
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
                    ScreeningSeatId = table.Column<int>(type: "int", nullable: true),
                    CouponId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartElement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartElement_Coupon_CouponId",
                        column: x => x.CouponId,
                        principalTable: "Coupon",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CartElement_ScreeningSeat_ScreeningSeatId",
                        column: x => x.ScreeningSeatId,
                        principalTable: "ScreeningSeat",
                        principalColumn: "Id");
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
                    { 1, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "+12", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "+12" },
                    { 2, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "+15", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "+15" },
                    { 3, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "+18", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "+18" }
                });

            migrationBuilder.InsertData(
                table: "Award",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grammy", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grammy" },
                    { 2, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oscar", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oscar" }
                });

            migrationBuilder.InsertData(
                table: "Bottombar",
                columns: new[] { "Id", "Content", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name", "Position" },
                values: new object[] { 1, "<p class=\"mb-0 footer-text\" style=\"color: white;\">© 2024 MovieStar Cinema. All rights reserved. Design by <a class=\"col_red\" href=\"https://www.google.com\">Bartosz Waśko</a></p>", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Copyright", 1 });

            migrationBuilder.InsertData(
                table: "ContactInformation",
                columns: new[] { "Id", "Content", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name", "Position" },
                values: new object[,]
                {
                    { 1, "\r\n<h3><a class=\"text-white\" href=\"index.html\"><i class=\"fa fa-video-camera col_red me-1\"></i> MovieStar</a></h3>", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Title", 1 },
                    { 2, "\r\n<p class=\"mt-3\">Any question? Send a mail, e-mail or call us</p>", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expression", 2 },
                    { 3, "<h6 class=\"fw-normal\">\r\n    <i class=\"fa fa-map-marker fs-5 align-middle col_red me-1\"></i> Nowy Sącz, Lwowska 2532, Małpolskie, Polska\r\n</h6>", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Address", 3 },
                    { 4, "<h6 class=\"fw-normal mt-3\"><i class=\"fa fa-envelope fs-5 align-middle col_red me-1\"></i> info@gmail.com</h6>", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Email", 4 },
                    { 5, "<h6 class=\"fw-normal mt-3 mb-0\"><i class=\"fa fa-phone fs-5 align-middle col_red me-1\"></i>  +123 123 456</h6>", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone Number", 5 }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Poland", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Poland" },
                    { 2, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA" },
                    { 3, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Germany", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Germany" }
                });

            migrationBuilder.InsertData(
                table: "FooterIcon",
                columns: new[] { "Id", "Content", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name", "Position" },
                values: new object[,]
                {
                    { 1, "\r\n        <a href=\"#\" class=\"icoInstagram\" title=\"Instagram\" style=\"display: flex; align-items: center; justify-content: center; width: 40px; height: 40px; border-radius: 50%; background-color: #E4405F; color: white; text-decoration: none;\">\r\n            <i class=\"bi bi-instagram\" style=\"font-size: 20px;\"></i>\r\n        </a>", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instagram", 1 },
                    { 2, "<a href=\"#\" class=\"icoFacebook\" title=\"Facebook\" style=\"display: flex; align-items: center; justify-content: center; width: 40px; height: 40px; border-radius: 50%; background-color: #3b5998; color: white; text-decoration: none;\">\r\n            <i class=\"bi bi-facebook\" style=\"font-size: 20px;\"></i>\r\n        </a>", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Facebook", 2 },
                    { 3, "<a href=\"#\" class=\"icoTwitter\" title=\"Twitter\" style=\"display: flex; align-items: center; justify-content: center; width: 40px; height: 40px; border-radius: 50%; background-color: #1DA1F2; color: white; text-decoration: none;\">\r\n            <i class=\"bi bi-twitter\" style=\"font-size: 20px;\"></i>\r\n        </a>", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Twitter", 3 },
                    { 4, "<a href=\"#\" class=\"icoYouTube\" title=\"YouTube\" style=\"display: flex; align-items: center; justify-content: center; width: 40px; height: 40px; border-radius: 50%; background-color: #FF0000; color: white; text-decoration: none;\">\r\n            <i class=\"bi bi-youtube\" style=\"font-size: 20px;\"></i>\r\n        </a>", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Youtube", 4 },
                    { 5, "<a href=\"#\" class=\"icoLinkedin\" title=\"LinkedIn\" style=\"display: flex; align-items: center; justify-content: center; width: 40px; height: 40px; border-radius: 50%; background-color: #0077B5; color: white; text-decoration: none;\">\r\n            <i class=\"bi bi-linkedin\" style=\"font-size: 20px;\"></i>\r\n        </a", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "LinkedIn", 5 }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Action", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Action" },
                    { 2, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Romance", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Romance" },
                    { 3, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Drama", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Drama" },
                    { 4, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantasy", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantasy" },
                    { 5, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Horror", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Horror" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Polish", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Polish" },
                    { 2, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "English", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "English" },
                    { 3, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danish", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danish" }
                });

            migrationBuilder.InsertData(
                table: "MovieFormat",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "4:3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "4:3" },
                    { 2, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "16:9", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "16:9" }
                });

            migrationBuilder.InsertData(
                table: "MovieKeywords",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Superb", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Superb" },
                    { 2, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extra", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extra" },
                    { 3, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magic", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magic" }
                });

            migrationBuilder.InsertData(
                table: "MovieProductionCompany",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Warner Bros", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Warner Bros" },
                    { 2, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "KOJAK", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "KOJAK" },
                    { 3, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Netflix", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Netflix" }
                });

            migrationBuilder.InsertData(
                table: "Navbar",
                columns: new[] { "Id", "Action", "Content", "Controller", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name", "Position" },
                values: new object[,]
                {
                    { 1, "Index", "Home", "Home", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Home", 1 },
                    { 2, "InvoiceReportForUser", "Invoices", "Home", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Invoices", 2 },
                    { 3, "Index", "Movies", "Movie", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movies", 3 },
                    { 4, "ShowScreeningsForMovie", "Screenings", "Movie", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Screenings", 4 },
                    { 5, "Index", "Cart", "Cart", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cart", 5 },
                    { 6, "Contact", "Contact", "Home", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contact", 6 }
                });

            migrationBuilder.InsertData(
                table: "Newsletter",
                columns: new[] { "Id", "Content", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name", "Position" },
                values: new object[,]
                {
                    { 1, "<h4>Sign  <span class=\"col_red\">Newsletter</span></h4>", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Title", 1 },
                    { 2, "\r\n<p class=\"mt-3\">Subscribe to our newsletter list to get latest news and updates from us</p>", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expression", 2 },
                    { 3, "\r\n<div class=\"input-group\">\r\n    <input type=\"text\" class=\"form-control bg-black\" placeholder=\"Email\">\r\n    <span class=\"input-group-btn\">\r\n        <button class=\"btn btn text-white bg_red rounded-0 border-0\" type=\"button\">\r\n            Subscribe\r\n        </button>\r\n    </span>\r\n</div>", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mail with button", 3 }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cash", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cash" },
                    { 2, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Credit Card", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Credit Card" },
                    { 3, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stripe", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stripe" }
                });

            migrationBuilder.InsertData(
                table: "Screen",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name", "RoomNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "ŻABA", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "ŻABA", 12 },
                    { 2, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "KROWA", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "KROWA", 23 },
                    { 3, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "MILKY WAY", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "MILKY WAY", 34 }
                });

            migrationBuilder.InsertData(
                table: "Subtitles",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Polish", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Polish" },
                    { 2, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "English", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "English" },
                    { 3, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danish", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danish" }
                });

            migrationBuilder.InsertData(
                table: "UsefulLink",
                columns: new[] { "Id", "Content", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name", "Position" },
                values: new object[,]
                {
                    { 1, "<a href=\"#\">Home</a>", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Home", 1 },
                    { 2, "<a href=\"Movie\">Movies</a>", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movies", 2 },
                    { 3, "<a href=\"Cart\">Cart</a>", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cart", 3 },
                    { 4, "<a href=\"Identity/Account/Manage\">Profile</a>", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Home", 4 },
                    { 5, "<a href=\"Contact\">Contact</a>", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contact", 5 }
                });

            migrationBuilder.InsertData(
                table: "UserLevel",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name", "PointsToNextLevel" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Level 1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 10 },
                    { 2, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Level 2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", 50 }
                });

            migrationBuilder.InsertData(
                table: "Website",
                columns: new[] { "Id", "Content", "Description", "Name", "TitleName" },
                values: new object[,]
                {
                    { 1, "<h2 style=\"text-align: center; \"><strong><font color=\"#ffffff\">Privacy Policy</font></strong></h2><p style=\"text-align: center; \"><strong>Effective Date:</strong> [02.05.2025]</p><p style=\"text-align: center; \">MovieStar (\"we,\" \"us,\" or \"our\") values your privacy. This Privacy Policy describes how we collect, use, and protect your personal data when you use our website.</p><p style=\"text-align: center; \"><strong>1. Information We Collect</strong></p><ul data-spread=\"false\"><li><p style=\"text-align: center;\">Personal data: Name, email address, payment details (if applicable), and other account information.</p></li><li><p style=\"text-align: center;\">Non-personal data: IP address, browser type, and website usage statistics.</p></li></ul><p style=\"text-align: center;\"><strong>2. How We Use Your Information</strong></p><ul data-spread=\"false\"><ul><li><ul><li style=\"text-align: center;\">To provide and improve our services.</li></ul></li><li><ul><li style=\"text-align: center;\">To process transactions and payments.</li></ul></li><li><ul><li style=\"text-align: center;\">To personalize user experience and deliver relevant content.</li></ul></li><li><ul><li style=\"text-align: center;\">To comply with legal obligations.</li></ul></li></ul></ul><p style=\"text-align: center;\"><strong>3. Data Security</strong>\r\nWe implement industry-standard security measures to protect your personal data. However, no online transmission is 100% secure, and we cannot guarantee absolute security.</p><p style=\"text-align: center;\"><strong>4. Third-Party Sharing</strong>\r\nWe do not sell your personal data. We may share data with third parties for processing transactions, legal compliance, or service improvements.</p><p style=\"text-align: center;\"><strong>5. Your Rights</strong>\r\nYou have the right to access, update, or delete your personal data. Contact us at [Insert Contact Info] to exercise these rights.</p><p style=\"text-align: center;\"><strong>6. Changes to This Policy</strong>\r\nWe may update this Privacy Policy from time to time. Please review it periodically.</p><p style=\"text-align: center;\"><br></p><p style=\"text-align: right;\">MovieStar team</p>", "", "Privacy", "Privacy" },
                    { 2, "<h2 style=\"text-align: center; \"><strong><font color=\"#ffffff\">Terms and Conditions</font></strong></h2><p style=\"text-align: center;\"><font color=\"#ffffff\"><strong>Effective Date:</strong> 02.05.2025</font></p><p style=\"text-align: center;\"><font color=\"#ffffff\">Welcome to MovieStar! By accessing or using our website, you agree to these Terms and Conditions.</font></p><p style=\"text-align: center;\"><strong><font color=\"#ffffff\">1. Use of the Website</font></strong></p><ul data-spread=\"false\"><li><p style=\"text-align: center;\"><font color=\"#ffffff\">You must be at least 18 years old or have parental consent to use our services.</font></p></li><li><p style=\"text-align: center;\"><font color=\"#ffffff\">You agree not to use the website for any unlawful or prohibited activities.</font></p></li></ul><p style=\"text-align: center;\"><strong><font color=\"#ffffff\">2. Account Registration</font></strong></p><ul data-spread=\"false\"><li><p style=\"text-align: center;\"><font color=\"#ffffff\">You are responsible for maintaining the confidentiality of your account credentials.</font></p></li><li><p style=\"text-align: center;\"><font color=\"#ffffff\">We reserve the right to suspend or terminate accounts that violate our policies.</font></p></li></ul><p style=\"text-align: center;\"><strong><font color=\"#ffffff\">3. Content and Intellectual Property</font></strong></p><ul data-spread=\"false\"><li><p style=\"text-align: center;\"><font color=\"#ffffff\">All content on MovieStar, including logos, text, and media, is owned by us or our licensors.</font></p></li><li><p style=\"text-align: center;\"><font color=\"#ffffff\">You may not copy, distribute, or modify any content without permission.</font></p></li></ul><p style=\"text-align: center;\"><strong><font color=\"#ffffff\">4. Limitation of Liability</font></strong></p><ul data-spread=\"false\"><li><p style=\"text-align: center;\"><font color=\"#ffffff\">We are not liable for any damages resulting from the use of our website.</font></p></li><li><p style=\"text-align: center;\"><font color=\"#ffffff\">We do not guarantee uninterrupted or error-free service.</font></p></li></ul><p style=\"text-align: center;\"><font color=\"#ffffff\"><strong>5. Changes to Terms</strong>\r\nWe may update these Terms and Conditions. Continued use of the website means acceptance of the updated terms.</font></p><p style=\"text-align: center; \"><font color=\"#ffffff\">For any questions, contact us at info@gmail.com.</font></p><p style=\"text-align: center; \"><font color=\"#ffffff\"><br></font></p><p style=\"text-align: right;\"><font color=\"#ffffff\">MovieStar Team</font></p>", "", "TermsAndConditions", "Terms and Conditions" },
                    { 3, "<h4 style=\"text-align: center; \"><strong><font color=\"#ffffff\">Welcome to MovieStar Cinema!</font></strong></h4><p style=\"text-align: center; \"><font color=\"#ffffff\">At MovieStar Cinema, we bring the magic of movies to life. From the latest blockbusters to timeless classics, our state-of-the-art theaters provide an unmatched cinematic experience.</font></p><p style=\"text-align: center;\"><font color=\"#ffffff\">With premium sound systems, ultra-HD screens, and comfortable seating, we ensure every visit is special. Whether you're here for action, drama, comedy, or family entertainment, we have something for everyone.</font></p><p style=\"text-align: center; \"><font color=\"#ffffff\">Thank you for choosing MovieStar Cinema—where every story comes to life on the big screen!</font></p>", "", "AboutUs", "About Us" },
                    { 4, "<p></p><h3 style=\"text-align: center; \"><strong><font color=\"#ffffff\">Frequently asked questions</font></strong></h3><h4 style=\"text-align: center; \"><strong><font color=\"#ffffff\"><br></font></strong></h4><p style=\"text-align: center; \"><font color=\"#ffffff\">This is the list of the most asked questions. We will be updating this page periodically.</font></p><h4 style=\"text-align: center; \"><strong><font color=\"#ffffff\"><br></font></strong></h4><h4 style=\"text-align: center; \"><strong><font color=\"#ffffff\">General Questions</font></strong></h4><p></p><div style=\"text-align: center;\"><strong style=\"text-align: var(--bs-body-text-align);\"><font color=\"#ffffff\">Q: What are your operating hours?</font></strong></div><div style=\"text-align: center;\"><span style=\"font-weight: var(--bs-body-font-weight); text-align: var(--bs-body-text-align);\"><font color=\"#ffffff\">A: We are open from 10 am - 10 pm daily.</font></span></div><p></p><p></p><div style=\"text-align: center;\"><strong style=\"text-align: var(--bs-body-text-align);\"><font color=\"#ffffff\">Q: How can I buy tickets?</font></strong></div><div style=\"text-align: center;\"><font color=\"#ffffff\"><span style=\"font-weight: var(--bs-body-font-weight); text-align: var(--bs-body-text-align);\">A: You can&nbsp;</span><span style=\"text-align: var(--bs-body-text-align); font-weight: bolder;\">buy&nbsp;</span><span style=\"font-weight: var(--bs-body-font-weight); text-align: var(--bs-body-text-align);\">online through our website or purchase them at the cinema.</span></font></div><p></p><h4 style=\"text-align: center;\"><strong><font color=\"#ffffff\">Ticketing &amp; Refunds</font></strong></h4><p></p><div style=\"text-align: center;\"><strong style=\"text-align: var(--bs-body-text-align);\"><font color=\"#ffffff\">Q: Can I cancel or refund my ticket?</font></strong></div><div style=\"text-align: center;\"><font color=\"#ffffff\"><span style=\"font-weight: var(--bs-body-font-weight); text-align: var(--bs-body-text-align);\">A: Please refer to our </span><strong style=\"text-align: var(--bs-body-text-align);\">[Refund &amp; Cancellation Policy]</strong><span style=\"font-weight: var(--bs-body-font-weight); text-align: var(--bs-body-text-align);\"> for details.</span></font></div><p></p><p></p><font color=\"#ffffff\"><span style=\"font-weight: bolder; font-size: 18px;\"><div style=\"text-align: center;\"><span style=\"font-weight: bolder; text-align: var(--bs-body-text-align);\">Q: Do you offer discounts?</span></div></span><span style=\"font-size: 18px;\"><div style=\"text-align: center;\"><span style=\"font-weight: var(--bs-body-font-weight); text-align: var(--bs-body-text-align);\">A: Yes! Contact us for booking details.</span></div></span></font><p></p><p></p><div><div style=\"text-align: center;\"><span style=\"font-weight: bolder; text-align: var(--bs-body-text-align);\"><font color=\"#ffffff\">Q: Can you make a seat reservation?</font></span></div><span style=\"font-size: 18px;\"><div style=\"text-align: center;\"><span style=\"font-weight: var(--bs-body-font-weight); text-align: var(--bs-body-text-align);\"><font color=\"#ffffff\">A: Currently no. You need to pay up front for a tickets.</font></span></div></span></div><div style=\"text-align: center; \"><font color=\"#ffffff\"><span style=\"font-size: 18px;\"><br></span><span style=\"font-size: 18px;\"></span></font></div><div><font color=\"#ffffff\"><span style=\"font-size: 18px;\"></span></font></div><span style=\"font-weight: bolder;\"><div style=\"text-align: center;\"><span style=\"font-weight: bolder; text-align: var(--bs-body-text-align);\"><font color=\"#ffffff\">Q: How can I pay for a tickets?</font></span></div></span><div style=\"text-align: center;\"><span style=\"font-weight: var(--bs-body-font-weight); text-align: var(--bs-body-text-align);\"><font color=\"#ffffff\">A: At the moment, it is possible to pay for a ticket using cash, credit card or Stripe.</font></span></div><p></p><p style=\"text-align: center; \"><font color=\"#ffffff\"><br></font></p><p style=\"text-align: center; \"><font color=\"#ffffff\">If you have other questions, please ask via <b>Contact Us </b>page!</font></p>", "", "FAQ", "FAQ" },
                    { 5, "<h3 style=\"text-align: center; \"><strong><font color=\"#ffffff\">&nbsp;Refund &amp; Cancellation Policy</font></strong></h3><h3 style=\"text-align: center; \"><strong><font color=\"#ffffff\"><br></font></strong></h3><p style=\"text-align: center;\"><font color=\"#ffffff\">At MovieStar Cinema, we strive to provide the best experience. However, we understand that plans may change.</font></p><p style=\"text-align: center;\"><font color=\"#ffffff\"><br></font></p><ul><li><p style=\"text-align: center;\"><font color=\"#ffffff\">🎟 <strong>Ticket Refunds:</strong></font></p><ul><li style=\"text-align: center;\"><font color=\"#ffffff\">Tickets are refundable if canceled at least 24 hours before the showtime.</font></li><li style=\"text-align: center;\"><font color=\"#ffffff\">Refunds are processed within 3-5 business days.</font></li></ul></li></ul><p><ul></ul></p><p style=\"text-align: center;\"><font color=\"#ffffff\"><br></font></p><ul><li></li><li><p style=\"text-align: center;\"><font color=\"#ffffff\">🎬 <strong>Cancellations Due to Technical Issues:</strong></font></p><ul><li style=\"text-align: center;\"><font color=\"#ffffff\">If a show is canceled due to technical problems, a full refund or free rebooking will be provided.</font></li></ul></li></ul><p><ul></ul></p><p style=\"text-align: center;\"><font color=\"#ffffff\"><br></font></p><ul><li></li><li><p style=\"text-align: center;\"><font color=\"#ffffff\">🚫 <strong>No-Show Policy:</strong></font></p><ul><li style=\"text-align: center;\"><font color=\"#ffffff\">If you fail to attend without prior cancellation, no refund will be issued.</font></li></ul></li></ul><p><ul></ul></p><p style=\"text-align: center;\"><font color=\"#ffffff\"><br></font></p><ul><li></li></ul><p style=\"text-align: center; \"><font color=\"#ffffff\">For refund requests, please contact us at info@gmail.com.</font></p>", "", "Refund", "Refund and Cancellation Policy" },
                    { 6, "<h3 style=\"text-align: center;\"><span style=\"font-weight: bolder;\"><font color=\"#ffffff\">Cookie Policy</font></span></h3><h3 style=\"text-align: center;\"><span style=\"font-weight: bolder;\"><font color=\"#ffffff\"><br></font></span></h3><p style=\"text-align: center;\"><font color=\"#ffffff\">MovieStar Cinema uses cookies to enhance your browsing experience.</font></p><p style=\"text-align: center;\"><font color=\"#ffffff\"><br></font></p><h4 style=\"text-align: center;\"><span style=\"font-weight: bolder;\"><font color=\"#ffffff\">What Are Cookies?</font></span></h4><p style=\"text-align: center;\"><font color=\"#ffffff\">Cookies are small text files stored on your device when you visit our website.</font></p><p style=\"text-align: center;\"><font color=\"#ffffff\"><br></font></p><h4 style=\"text-align: center;\"><span style=\"font-weight: bolder;\"><font color=\"#ffffff\">How We Use Cookies</font></span></h4><ul><li style=\"text-align: center;\"><font color=\"#ffffff\">To improve website functionality</font></li><li style=\"text-align: center;\"><font color=\"#ffffff\">To remember your preferences</font></li><li style=\"text-align: center;\"><font color=\"#ffffff\">For analytics and marketing purposes</font></li><li style=\"text-align: center;\"><font color=\"#ffffff\"><br></font></li></ul><p style=\"text-align: center;\"><font color=\"#ffffff\">By using our website, you consent to our use of cookies. You can adjust your settings anytime in your browser.</font></p><p style=\"text-align: center;\"><font color=\"#ffffff\"><br></font></p><p style=\"text-align: center;\"><font color=\"#ffffff\">For more details, visit our&nbsp;<span style=\"font-weight: bolder;\">[Privacy Policy]</span>.</font></p>", "", "CookiePolicy", "Cookie Policy" },
                    { 7, "<h3 style=\"text-align: center;\"><span style=\"font-weight: bolder;\"><font color=\"#ffffff\">Careers</font></span></h3><h3 style=\"text-align: center;\"><span style=\"font-weight: bolder;\"><font color=\"#ffffff\"><br></font></span></h3><h4 style=\"text-align: center;\"><span style=\"font-weight: bolder;\"><font color=\"#ffffff\">Join Our Team at MovieStar Cinema!</font></span></h4><h4 style=\"text-align: center;\"><span style=\"font-weight: bolder;\"><font color=\"#ffffff\"><br></font></span></h4><p style=\"text-align: center;\"><font color=\"#ffffff\">Are you passionate about movies and customer service? We’re always looking for enthusiastic individuals to join our team.</font></p><p style=\"text-align: center;\"><font color=\"#ffffff\"><br></font></p><p style=\"text-align: center;\"><font color=\"#ffffff\">🚀&nbsp;<span style=\"font-weight: bolder;\">Current Openings:</span></font></p><ul><li style=\"text-align: center;\"><font color=\"#ffffff\">Ticket Sales Associate</font></li><li style=\"text-align: center;\"><font color=\"#ffffff\">Concessions &amp; Food Service</font></li><li style=\"text-align: center;\"><font color=\"#ffffff\">Cinema Manager</font></li><li style=\"text-align: center;\"><font color=\"#ffffff\">Projection &amp; Technical Team</font></li><li style=\"text-align: center;\"><font color=\"#ffffff\"><br></font></li></ul><p style=\"text-align: center;\"><font color=\"#ffffff\">If you’d like to work in an exciting, fast-paced environment, apply today! Send your resume to info@gmail.com.</font></p>", "", "Career", "Career" },
                    { 8, "<h3 style=\"text-align: center; \"><strong><font color=\"#ffffff\">Partnerships &amp; Advertising</font></strong></h3><h3 style=\"text-align: center; \"><strong><font color=\"#ffffff\"><br></font></strong></h3><h4 style=\"text-align: center; \"><strong><font color=\"#ffffff\">Partner with MovieStar Cinema</font></strong></h4><h4 style=\"text-align: center; \"><strong><font color=\"#ffffff\"><br></font></strong></h4><p style=\"text-align: center; \"><font color=\"#ffffff\">Looking for an opportunity to showcase your brand to thousands of moviegoers? We offer premium advertising slots before and during screenings.</font></p><p style=\"text-align: center; \"><font color=\"#ffffff\"><br></font></p><p style=\"text-align: center;\"><font color=\"#ffffff\">📢 <strong>Advertising Options:</strong></font></p><ul><li style=\"text-align: center;\"><font color=\"#ffffff\">On-screen ads before movies</font></li><li style=\"text-align: center;\"><font color=\"#ffffff\">Digital banners on our website</font></li><li style=\"text-align: center; \"><font color=\"#ffffff\">Promotional events at our cinemas</font></li><li style=\"text-align: center; \"><font color=\"#ffffff\"><br></font></li></ul><p style=\"text-align: center; \"><font color=\"#ffffff\">Interested?</font></p><p style=\"text-align: center; \"><font color=\"#ffffff\"> Contact our marketing team at info@gmail.com to discuss collaboration opportunities.</font></p>", "", "Partnership", "Partnership" }
                });

            migrationBuilder.InsertData(
                table: "WorkPosition",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "General Assistant", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "General Assistant" },
                    { 2, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Floor Manager", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Floor Manager" },
                    { 3, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cleaner", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cleaner" }
                });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "AwardId", "CountryId", "CreatedAt", "DateOfBirth", "Description", "FirstName", "IsActive", "LastName", "MiddleName", "ModifiedAt", "MovieId", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, null, 1, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jerzy Puławski", "Jerzy", true, "Puławski", null, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jerzy Puławski", null },
                    { 2, null, 2, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Longue", "John", true, "Longue", null, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John Longue", null },
                    { 3, null, 1, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna Kobiela", "Anna", true, "Kobiela", null, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Anna Kobiela", null }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "Id", "AwardId", "CountryId", "CreatedAt", "DateOfBirth", "Description", "FirstName", "IsActive", "LastName", "MiddleName", "ModifiedAt", "MovieId", "Name" },
                values: new object[,]
                {
                    { 1, null, 1, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1974, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariusz Puławski", "Mariusz", true, "Puławski", null, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mariusz Puławski" },
                    { 2, null, 2, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Mingue", "John", true, "Mingue", null, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John Mingue" }
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "AgeRatingId", "CountryId", "CreatedAt", "Description", "Duration", "GenreId", "IsActive", "ModifiedAt", "MovieFormatId", "MovieProductionCompanyId", "Name", "TicketPrice", "UserId" },
                values: new object[,]
                {
                    { 1, 3, 2, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "\"Killing Dead Man\" is a pulse-pounding action thriller that takes audiences on a relentless ride through a world where morality is a luxury and survival is the only rule.\r\n\r\nSet against the gritty backdrop of a crime-ridden American metropolis, the film follows ex-hitman Jack Mercer—a man who left behind a violent past only to find that the past isn’t done with him. When a mysterious contract is put out on his life, Mercer is forced back into the deadly underworld he once escaped. Hunted by elite assassins and betrayed by those he trusted, he soon discovers that the one pulling the strings is none other than a man he killed years ago… or so he thought.\r\n\r\nAs the lines between reality and deception blur, Mercer must unravel the truth before he becomes just another forgotten name on a hit list. Fueled by explosive action sequences, intense hand-to-hand combat, and a gripping narrative of revenge and redemption, Killing Dead Man is a high-stakes adrenaline rush from start to finish.\r\n\r\nBrought to life by Warner Bros., this 18+ action spectacle delivers breathtaking cinematography in a classic 4:3 format, immersing viewers in its raw, uncompromising aesthetic. With a runtime of 103 minutes, it’s a relentless, edge-of-your-seat experience that will leave audiences questioning whether the dead ever truly stay buried.", 103, 1, true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Killing Dead Man", 15.99m, null },
                    { 2, 3, 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "In a dystopian future where technology and warfare have merged, elite soldier Captain Ryan Drake is tasked with a mission that could alter the fate of the world. With cyber-enhanced mercenaries, lethal drones, and corrupt corporations standing in his way, Drake must navigate a battlefield of deception and destruction. Explosive action, high-tech combat, and an adrenaline-fueled storyline make 'Shadow Strike' an unmissable cinematic spectacle.", 120, 1, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "Shadow Strike", 17.99m, null },
                    { 3, 3, 1, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deep within the haunted forests of Poland, an abandoned village holds a terrifying secret. When journalist Anna Kowalski investigates the eerie whispers that plague the nearby town, she uncovers a horrifying legend of lost souls trapped between worlds. As night falls, shadows move, whispers turn to screams, and Anna realizes she’s not alone. With no escape and sanity slipping away, she must face the dark truth before she becomes part of the legend herself. *Whispers in the Dark* is a chilling horror masterpiece from Netflix, blending psychological terror with supernatural horror in a spine-tingling tale you won't forget.", 112, 5, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "Whispers in the Dark", 14.99m, null },
                    { 4, 3, 3, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "In a neon-lit future where corporations rule and cybernetic enhancements are the norm, rogue enforcer Kai Renegade is the last hope for a crumbling society. When a powerful AI goes rogue, launching a drone war over the towering metropolis of Neo-Berlin, Kai must wield his twin plasma blades and fight his way through an army of cybernetic mercenaries. With the city on the brink of collapse and time running out, he faces the ultimate choice: submit to the machine or rewrite the future. *Niefllerissing* is a visually stunning, adrenaline-charged action thriller that pushes the boundaries of sci-fi cinema.", 118, 1, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "Niefllerissing", 16.99m, null },
                    { 5, 2, 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "On a misty evening at a quiet train station, two women, once inseparable, stand facing each other for the final time. As the sun sets in the distance, casting an orange glow over the platform, the weight of their past begins to resurface. *The Last Goodbye* tells a poignant story of love, loss, and the bittersweet moments that define our lives. As the trains come and go, they are forced to confront their emotions and say goodbye—forever.", 95, 2, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "The Last Goodbye", 12.99m, null },
                    { 6, 1, 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "At a lavish wedding ceremony, the groom stands in confusion, alone in front of the altar in his tuxedo, waiting for the bride. But as the doors swing open, it's not his bride that enters—it's a different woman, running past him to the man standing at the back. In a whirlwind of mistaken identities and hilarious events, *Ooops! Wrong Wedding* brings to life the chaos of love, misunderstandings, and the consequences of running away from commitment. Prepare for a comedy of errors that will have you laughing from start to finish.", 90, 2, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "Ooops! Wrong Wedding", 10.99m, null },
                    { 7, 3, 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "In a war-torn, desolate town, one man walks through the devastation with unwavering determination. With a burning car in the background, his focus never wavers as he strides forward, prepared to take vengeance on those who destroyed everything he loved. *Bulletproof Vengeance* is an action-packed thriller that follows a soldier's relentless quest for revenge in a world where justice is earned with blood, sweat, and bullets. The stakes are high, and survival is the only option.", 105, 1, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "Bulletproof Vengeance", 15.99m, null },
                    { 8, 2, 3, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "In a small, dimly lit room, a man sits on the floor, typing away on a vintage typewriter, the rhythmic sound of the keys echoing in the silence. Outside the window, life continues without him, as people move along, oblivious to his internal struggle. *A Life Unwritten* explores the complexities of a man’s inner world, his dreams, and the stories he longs to tell, all while grappling with the reality of an unfulfilled life. A heartfelt drama about the power of words and the burden of missed opportunities.", 100, 3, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "A Life Unwritten", 13.99m, null },
                    { 9, 1, 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "In the midst of a chaotic office, one boss is on a rampage. Papers fly, cups crash to the floor, and his office workers are caught in the crossfire, all while the rest of the staff remain glued to their computer screens, oblivious to the storm that’s unfolding. *My Crazy Boss* is a hilarious comedy about the unpredictable, often absurd world of office life, where chaos reigns and no one is safe from the eccentricities of their leader. Prepare for non-stop laughter and ridiculous office antics!", 85, 1, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "My Crazy Boss", 11.99m, null },
                    { 10, 3, 1, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Under the eerie glow of a blood-red moon, a sinister figure, resembling a villain from the darkest of nightmares, prowls the streets of an abandoned town. The air is thick with fear as the old church looms in the background, its doors creaking open to welcome the horrors that await. *Silent Screams* is a chilling horror film that takes you on a terrifying journey into the heart of darkness, where every shadow hides a secret and every scream is swallowed by the silence of the night.", 110, 5, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "Silent Screams", 14.99m, null },
                    { 11, 2, 3, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Standing at the edge of a cliff, a man faces a breathtaking view of the land below, where the clouds part to let the sunlight beam through. The world feels vast, filled with possibilities, and an old, mysterious clock floats above him in the air—its hands frozen in time. *Crossroads of Fate* is a stunning fantasy adventure that explores the moment when a single choice can change the course of a life forever. As the man stares into the unknown, he must decide if he will step into the future or remain bound by the past.", 105, 4, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "Crossroads of Fate", 13.49m, null },
                    { 12, 1, 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "In an animated world of confusion and chaos, *The Clumsy Detective* tries his best to solve the case, though things rarely go as planned. Surrounded by stacks of documents, a curious cat by his side, and a few sharp-suited gentlemen in the office, the detective is a lovable mess. As he stumbles through clues and mishaps, his true genius shines through, despite the comedic disaster he causes. This hilarious animated feature will have you laughing out loud as the clumsy detective slowly but surely unravels the mystery.", 90, 1, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "The Clumsy Detective", 9.99m, null },
                    { 13, 2, 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "In the vastness of space, where the boundaries of reality bend and twist, a spaceship embarks on a journey beyond the known universe. As the Earth and the Moon drift silently in the background, the crew is drawn toward a mysterious rift, a cosmic tunnel that looks like an Einstein-Rosen bridge. Inside it, a brilliant star, like the Sun, beckons them into the unknown. *Beyond the Rift* is a thrilling sci-fi adventure that explores the deepest mysteries of the cosmos, where space and time converge and the fate of the universe hangs in the balance.", 120, 4, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "Beyond the Rift", 16.99m, null },
                    { 14, 1, 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "In a cozy, dimly lit restaurant, a man and a woman sit close together, sipping on lattes, their conversations filled with secrets, shared smiles, and the occasional laugh. As their hands touch over the table and their faces lean in, the chemistry between them is undeniable. But beneath their blossoming romance lies a web of lies that threatens to unravel everything. *Love, Lies, Love and Lattes* is a heartwarming romantic comedy about love's unpredictable twists and the sweet moments shared over coffee that may just change everything.", 90, 2, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "Love, Lies, Love and Lattes", 11.49m, null },
                    { 15, 3, 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "In the heart of a dark, rain-soaked city, three hooded assassins in black move swiftly across the rooftops, their silhouettes cutting through the evening sky. Armed and focused, they traverse the heights with deadly precision, preparing to strike. In the background, the city’s skyline looms, a constant reminder of the danger that lurks within its depths. *Rouge Rouge Assassins* is an intense action thriller that follows a group of elite assassins on a high-stakes mission, where loyalty is tested, and the line between right and wrong blurs in the shadows of the city.", 110, 1, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "Rouge Rouge Assassins", 14.99m, null },
                    { 16, 2, 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "On the edge of a barren world, the last surviving humans stand before a sleek, futuristic complex, their last hope for survival. In the distance, a spacecraft hovers near the massive colony, and beyond that, another planet—or perhaps a moon—looms ominously in the sky. *The Last Colony* takes you on a thrilling journey into space where humanity's future depends on a fragile settlement in the farthest reaches of the galaxy. With danger on all sides and secrets lurking within the complex, seven brave souls must decide what kind of future awaits them in the unknown.", 125, 4, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "The Last Colony", 17.99m, null },
                    { 17, 1, 3, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "A man stands alone on the shore, gazing out at the calm sea beneath a sky filled with the breathtaking glow of constellations. The night is still, the only sound being the gentle lapping of waves. As he stares into the vast expanse of stars, the weight of his dreams, his losses, and his longing fill the silence. *Falling Stars* is a poignant drama that explores the fragility of hope, the impact of dreams lost and regained, and the eternal search for meaning beneath the stars.", 95, 3, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "Falling Stars", 12.49m, null },
                    { 18, 3, 1, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "On a moonlit night, beneath the eerie glow of a full moon, a small wooden bridge stretches over a misty chasm, flanked by old, dead trees. The air is thick with a chilling fog as a man, dressed in dark clerical robes, stands at the end of the bridge, accompanied by a child. The silence is oppressive, broken only by the whispers of the past. *The Cursed Hollow* is a supernatural horror that delves into the heart of an ancient curse, where the line between the living and the dead blurs, and the truth must be uncovered before the darkness consumes them all.", 115, 5, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "The Cursed Hollow", 14.99m, null },
                    { 19, 2, 3, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "In the heart of a ferocious storm, five warriors stand tall on a lone stone amidst the restless sea, their magical weapons glowing with power. Flame swords, lightning-infused blades, and mystical artifacts crackle with energy as thunder cracks the sky. The sea rages around them, but these heroes are unyielding, bound by a common fate. *Tormbreakers* is an epic fantasy adventure where magic, courage, and destiny collide in a world on the brink of destruction. As the storm rages, so too does the battle for the future of their realm.", 130, 4, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "Tormbreakers", 16.49m, null },
                    { 20, 3, 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portal to another dimension opens, revealing a futuristic world where time itself is at war. Soldiers, dressed in advanced SWAT gear, patrol the perimeter of the rift, weapons at the ready as spacecrafts zoom overhead. In the background, the mighty Pantheon stands as a symbol of ancient power and mystery. *ChronoWars* is a gripping sci-fi action thriller that spans across time and dimensions, where elite soldiers battle to control the flow of history itself. As they fight for dominance, the future of all worlds hangs in the balance.", 140, 4, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "ChronoWars", 18.99m, null }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name", "NumberInRow", "Row", "ScreenId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "1/1", 1, 1, 1 },
                    { 2, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "1/2", 2, 1, 1 },
                    { 3, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "1/3", 3, 1, 1 },
                    { 4, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "2/1", 1, 2, 1 },
                    { 5, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "2/2", 2, 2, 1 },
                    { 6, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "2/3", 3, 2, 1 },
                    { 7, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "3/1", 1, 3, 1 },
                    { 8, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "3/2", 2, 3, 1 },
                    { 9, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "3/3", 3, 3, 1 },
                    { 10, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "1/1", 1, 1, 2 },
                    { 11, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "1/2", 2, 1, 2 },
                    { 12, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "1/3", 3, 1, 2 },
                    { 13, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "2/1", 1, 2, 2 },
                    { 14, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "2/2", 2, 2, 2 },
                    { 15, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "2/3", 3, 2, 2 },
                    { 16, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "3/1", 1, 3, 2 },
                    { 17, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "3/2", 2, 3, 2 },
                    { 18, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "3/3", 3, 3, 2 },
                    { 19, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "1/1", 1, 1, 3 },
                    { 20, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "1/2", 2, 1, 3 },
                    { 21, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "1/3", 3, 1, 3 },
                    { 22, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "2/1", 1, 2, 3 },
                    { 23, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "2/2", 2, 2, 3 },
                    { 24, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "2/3", 3, 2, 3 },
                    { 25, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "3/1", 1, 3, 3 },
                    { 26, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "3/2", 2, 3, 3 },
                    { 27, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "3/3", 3, 3, 3 }
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
                name: "IX_CartElement_CouponId",
                table: "CartElement",
                column: "CouponId");

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
                name: "IX_Invoice_CouponId",
                table: "Invoice",
                column: "CouponId");

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
                name: "Bottombar");

            migrationBuilder.DropTable(
                name: "CartElement");

            migrationBuilder.DropTable(
                name: "ContactInformation");

            migrationBuilder.DropTable(
                name: "ELementOfMenu");

            migrationBuilder.DropTable(
                name: "FooterIcon");

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
                name: "Coupon");

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
