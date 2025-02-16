using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DatabaseAPI.Migrations
{
    /// <inheritdoc />
    public partial class newInitialCreateDatabase : Migration
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
                name: "Photo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PathToPhoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Id);
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
                    imageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    CountryId = table.Column<int>(type: "int", nullable: true),
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
                        principalColumn: "Id");
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
                    CountryId = table.Column<int>(type: "int", nullable: true),
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
                        principalColumn: "Id");
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { 2, "Index", "Movies", "Movie", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movies", 2 },
                    { 3, "Index", "Cart", "Cart", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cart", 3 },
                    { 4, "Contact", "Contact", "Home", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contact", 4 }
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
                    { 2, "<a href=\"/Movie\\Index\">Movies</a>", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movies", 2 },
                    { 3, "<a href=\"/Cart\\Index\">Cart</a>", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cart", 3 },
                    { 4, "<a href=\"/Identity/Account/Manage\">Profile</a>", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Home", 4 },
                    { 5, "<a href=\"/Contact\">Contact</a>", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contact", 5 }
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
                    { 1, " \r\n  \r\n\r\n<div class=\"container\">\r\n    <h2><strong>Privacy Policy</strong></h2>\r\n    <p><strong>Effective Date:</strong> 02.05.2025</p>\r\n\r\n    <p>\r\n        Welcome to MovieStar! We are committed to protecting your personal data and ensuring transparency in how we collect, \r\n        use, and secure your information. This Privacy Policy outlines our data processing practices and your rights.\r\n    </p>\r\n\r\n    <h4><strong>1. Information We Collect</strong></h4>\r\n    <ul>\r\n        <li><strong>Personal Data:</strong> Name, email address, phone number, payment details (if applicable), and account preferences.</li>\r\n        <li><strong>Non-Personal Data:</strong> IP address, device type, browser details, and site usage statistics.</li>\r\n        <li><strong>Cookies & Tracking:</strong> We use cookies to enhance your browsing experience and improve our services.</li>\r\n    </ul>\r\n\r\n    <h4><strong>2. How We Use Your Information</strong></h4>\r\n    <ul>\r\n        <li>To provide, manage, and improve our services.</li>\r\n        <li>To process payments and bookings securely.</li>\r\n        <li>To personalize your experience based on preferences.</li>\r\n        <li>To send updates, promotions, and important notifications.</li>\r\n        <li>To comply with legal and regulatory requirements.</li>\r\n    </ul>\r\n\r\n    <h4><strong>3. Data Security & Protection</strong></h4>\r\n    <p>\r\n        We implement advanced security measures, including encryption, secure servers, and regular security audits, \r\n        to protect your personal data. However, while we strive for maximum security, no system is entirely foolproof. \r\n        We recommend using strong passwords and safeguarding your login credentials.\r\n    </p>\r\n\r\n    <h4><strong>4. Third-Party Sharing</strong></h4>\r\n    <p>\r\n        We do not sell your personal data. However, we may share necessary information with trusted third parties \r\n        for the following reasons:\r\n    </p>\r\n    <ul>\r\n        <li>Processing payments through secure gateways.</li>\r\n        <li>Ensuring compliance with legal and regulatory obligations.</li>\r\n        <li>Improving our services through analytics and feedback tools.</li>\r\n    </ul>\r\n\r\n    <h4><strong>5. Your Rights & Choices</strong></h4>\r\n    <p>\r\n        You have full control over your data. Your rights include:\r\n    </p>\r\n    <ul>\r\n        <li><span class=\"highlight\">Access & Review:</span> Request details about the data we hold on you.</li>\r\n        <li><span class=\"highlight\">Corrections:</span> Update any incorrect or outdated personal information.</li>\r\n        <li><span class=\"highlight\">Deletion:</span> Request removal of your data under applicable laws.</li>\r\n        <li><span class=\"highlight\">Opt-Out:</span> Manage communication preferences and unsubscribe from promotional messages.</li>\r\n    </ul>\r\n    <p>\r\n        To exercise any of these rights, contact us at: <strong>[Insert Contact Info]</strong>.\r\n    </p>\r\n\r\n    <h4><strong>6. Cookies & Tracking Technologies</strong></h4>\r\n    <p>\r\n        We use cookies and similar tracking technologies to enhance functionality, analyze usage trends, and deliver personalized content. \r\n        You can manage cookie preferences in your browser settings.\r\n    </p>\r\n\r\n    <h4><strong>7. Changes to This Policy</strong></h4>\r\n    <p>\r\n        We may update this Privacy Policy from time to time. Any changes will be posted on this page with an updated effective date. \r\n        We encourage you to review this policy periodically to stay informed.\r\n    </p>\r\n\r\n    <p  style = \"color:red\";>MovieStar Team</p>\r\n</div>\r\n\r\n ", "http://localhost/Images/photos/privacy.png", "Privacy", "Privacy" },
                    { 2, " \r\n<div class=\"container\">\r\n    <div class=\"faq-container\">\r\n        <h2>Frequently Asked Questions</h2>\r\n        <p class=\"text-center\" style=\"color: red;\">Here you will find answers to the most common questions. We update this section regularly.</p>\r\n\r\n        <div class=\"faq-section\">\r\n            <h4><i class=\"bi bi-info-circle\"></i> General Questions</h4>\r\n            <div class=\"faq-item\">\r\n                <strong>Q: What are your operating hours?</strong>\r\n                <p>A: We are open from <strong>10 AM - 10 PM</strong> daily, including weekends.</p>\r\n            </div>\r\n            <div class=\"faq-item\">\r\n                <strong>Q: How can I buy tickets?</strong>\r\n                <p>A: You can purchase tickets online through our <strong>official website</strong> or at the cinema.</p>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"faq-section\">\r\n            <h4><i class=\"bi bi-ticket-perforated\"></i> Ticketing & Refunds</h4>\r\n            <div class=\"faq-item\">\r\n                <strong>Q: Can I cancel or refund my ticket?</strong>\r\n                <p>A: Please check our <a href=\"#\">Refund & Cancellation Policy</a> for specific terms.</p>\r\n            </div>\r\n            <div class=\"faq-item\">\r\n                <strong>Q: Do you offer discounts?</strong>\r\n                <p>A: Yes! We offer special discounts for students, seniors, and groups. Check our website for current offers.</p>\r\n            </div>\r\n            <div class=\"faq-item\">\r\n                <strong>Q: Can I reserve a seat?</strong>\r\n                <p>A: Seat selection is available when purchasing a ticket online.</p>\r\n            </div>\r\n            <div class=\"faq-item\">\r\n                <strong>Q: What payment methods do you accept?</strong>\r\n                <p>A: We accept cash, credit/debit cards, and online payments via Stripe.</p>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"faq-section\">\r\n            <h4><i class=\"bi bi-popcorn\"></i> Experience & Services</h4>\r\n            <div class=\"faq-item\">\r\n                <strong>Q: Do you have VIP or premium seats?</strong>\r\n                <p>A: Yes! We offer luxury seating options for a more comfortable experience.</p>\r\n            </div>\r\n            <div class=\"faq-item\">\r\n                <strong>Q: Are food and drinks allowed inside?</strong>\r\n                <p>A: We offer a variety of snacks and beverages at our concession stands. Outside food is not permitted.</p>\r\n            </div>\r\n            <div class=\"faq-item\">\r\n                <strong>Q: Do you provide accessibility options?</strong>\r\n                <p>A: Yes! We have wheelchair-accessible seating and assistive listening devices available upon request.</p>\r\n            </div>\r\n        </div>\r\n\r\n        <p class=\"faq-footer\">Still have questions? Contact us via the <a href=\"#\">Contact Us</a> page!</p>\r\n    </div>\r\n</div>\r\n\r\n ", "http://localhost/Images/photos/termsandconditions.png", "TermsAndConditions", "Terms and Conditions" },
                    { 3, " \r\n<div class=\"container\">\r\n    <div class=\"cinema-intro\">\r\n        <i class=\"fas fa-film\"></i>\r\n        <h4>Welcome to <span class=\"highlight\">MovieStar Cinema!</span></h4>\r\n        \r\n        <p>\r\n            At <span class=\"highlight\">MovieStar Cinema</span>, we bring the **magic of movies** to life! Whether you're a fan of \r\n            the **latest blockbusters**, **critically acclaimed dramas**, or **timeless classics**, our theaters provide a truly **immersive experience**.\r\n        </p>\r\n\r\n        <p>\r\n            Our state-of-the-art theaters feature **ultra-HD screens**, **Dolby Atmos surround sound**, and **luxurious seating**, ensuring maximum comfort.  \r\n            Enjoy the **vibrant colors**, **crystal-clear visuals**, and **rich, deep sound** that put you right at the heart of every scene.\r\n        </p>\r\n\r\n        <p>\r\n            Whether you're looking for an **action-packed adventure**, a **heartwarming family film**, or a **thrilling horror experience**,  \r\n            our diverse selection of movies offers **something for everyone**. Plus, we host **exclusive premieres**, **sneak previews**, and **special screenings**  \r\n            to bring you even closer to the world of cinema.\r\n        </p>\r\n\r\n        <p>\r\n            Make your visit even more enjoyable with our **gourmet snack bar**, featuring everything from **classic popcorn and nachos**  \r\n            to **premium chocolates, freshly baked pastries, and barista-style coffee**. Want to make it extra special?  \r\n            Try our **VIP lounge**, where you can relax with a selection of fine wines and cocktails before your movie starts.\r\n        </p>\r\n\r\n        <p>\r\n            We also offer **private screenings, birthday parties, and corporate events**, providing a unique and personalized movie experience  \r\n            tailored just for you and your guests.\r\n        </p>\r\n\r\n        <p style=\"color:red\";> \r\n            <strong>Thank you for choosing MovieStar Cinema—where every story comes to life on the big screen!</strong>\r\n        </p>\r\n    </div>\r\n</div>\r\n \r\n", "http://localhost/Images/photos/aboutus.png", "AboutUs", "About Us" },
                    { 4, " \r\n\r\n<div class=\"container\">\r\n    <div class=\"faq-container\">\r\n        <h3><i class=\"fas fa-question-circle\"></i> Frequently Asked Questions</h3>\r\n        <p class=\"faq-intro\">Find answers to our most common questions. We update this section regularly.</p>\r\n\r\n        <div class=\"accordion\" id=\"faqAccordion\">\r\n            <!-- General Questions -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-info-circle\"></i> General Questions</h4>\r\n\r\n            <div class=\"accordion-item\" >\r\n                <h2 class=\"accordion-header\" id=\"headingOne\">\r\n                    <button class=\"accordion-button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseOne\">\r\n                        Q: What are your operating hours?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseOne\" class=\"accordion-collapse collapse show\" data-bs-parent=\"#faqAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: We are open daily from <strong>10 AM - 10 PM</strong>, including weekends and holidays.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingTwo\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseTwo\">\r\n                        Q: How can I buy tickets?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseTwo\" class=\"accordion-collapse collapse\" data-bs-parent=\"#faqAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: You can purchase tickets online via our website or buy them directly at the cinema counter.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Ticketing & Refunds -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-ticket-alt\"></i> Ticketing & Refunds</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingThree\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseThree\">\r\n                        Q: Can I cancel or refund my ticket?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseThree\" class=\"accordion-collapse collapse\" data-bs-parent=\"#faqAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: Please refer to our <a href=\"#\">Refund & Cancellation Policy</a> for specific terms.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingFour\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseFour\">\r\n                        Q: Do you offer discounts?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseFour\" class=\"accordion-collapse collapse\" data-bs-parent=\"#faqAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: Yes! We offer student, senior, and group discounts. Check our website for current offers.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingFive\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseFive\">\r\n                        Q: Can I reserve a seat in advance?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseFive\" class=\"accordion-collapse collapse\" data-bs-parent=\"#faqAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: Yes! Seat selection is available when purchasing tickets online.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingSix\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseSix\">\r\n                        Q: What payment methods do you accept?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseSix\" class=\"accordion-collapse collapse\" data-bs-parent=\"#faqAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: We accept cash, credit/debit cards, and online payments via Stripe.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Additional Information -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-concierge-bell\"></i> Services & Experience</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingSeven\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseSeven\">\r\n                        Q: Do you offer VIP or premium seating?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseSeven\" class=\"accordion-collapse collapse\" data-bs-parent=\"#faqAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: Yes! We have luxury seating options and VIP lounges for a premium experience.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <p class=\"text-center mt-4\">Still have questions? Contact us via the <a href=\"#\">Contact Us</a> page!</p>\r\n    </div>\r\n</div>\r\n \r\n", "http://localhost/Images/photos/faq.png", "FAQ", "FAQ" },
                    { 5, " \r\n\r\n<div class=\"container\">\r\n    <div class=\"refund-container\">\r\n        <h3><i class=\"fas fa-undo-alt\"></i> Refund & Cancellation Policy</h3>\r\n        <p class=\"refund-intro\">At MovieStar Cinema, we strive to provide the best experience. However, we understand that plans may change.</p>\r\n\r\n        <div class=\"accordion\" id=\"refundAccordion\">\r\n            <!-- Ticket Refunds -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-ticket-alt\"></i> Ticket Refunds</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingOne\">\r\n                    <button class=\"accordion-button\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseOne\">\r\n                        Q: Can I get a refund for my ticket?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseOne\" class=\"accordion-collapse collapse show\" data-bs-parent=\"#refundAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: Yes, tickets are refundable if canceled at least **24 hours before the showtime**.  \r\n                        Refunds are processed within **3-5 business days**.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Cancellations Due to Technical Issues -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-exclamation-circle\"></i> Cancellations Due to Technical Issues</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingTwo\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseTwo\">\r\n                        Q: What happens if the movie is canceled?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseTwo\" class=\"accordion-collapse collapse\" data-bs-parent=\"#refundAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: If a movie is **canceled due to technical issues**, we offer a **full refund**  \r\n                        or the option to **rebook for another date at no additional cost**.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- No-Show Policy -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-ban\"></i> No-Show Policy</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingThree\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseThree\">\r\n                        Q: What if I miss my show?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseThree\" class=\"accordion-collapse collapse\" data-bs-parent=\"#refundAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: If you **fail to attend your movie** without canceling at least 24 hours in advance,  \r\n                        **no refund will be issued**. We recommend managing your bookings carefully.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Payment and Refund Requests -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-credit-card\"></i> Payment & Refund Requests</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingFour\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseFour\">\r\n                        Q: How do I request a refund?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseFour\" class=\"accordion-collapse collapse\" data-bs-parent=\"#refundAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: To request a refund, please contact our support team at **info@gmail.com**  \r\n                        with your **booking details and reason for refund**.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingFive\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseFive\">\r\n                        Q: What payment methods are accepted?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseFive\" class=\"accordion-collapse collapse\" data-bs-parent=\"#refundAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: We accept payments via **credit/debit cards, PayPal, and Stripe**.  \r\n                        Refunds are processed back to the **original payment method**.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingSix\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseSix\">\r\n                        Q: Are gift cards refundable?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseSix\" class=\"accordion-collapse collapse\" data-bs-parent=\"#refundAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: Unfortunately, **gift cards are non-refundable** and cannot be exchanged for cash.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <p class=\"text-center mt-4\">For further assistance, contact us via <a href=\"#\">Customer Support</a>!</p>\r\n    </div>\r\n</div>\r\n \r\n", "http://localhost/Images/photos/refund.png", "Refund", "Refund and Cancellation Policy" },
                    { 6, " \r\n\r\n<div class=\"container\">\r\n    <div class=\"cookie-container\">\r\n        <h3><i class=\"fas fa-cookie-bite\"></i> Cookie Policy</h3>\r\n        <p class=\"cookie-intro\">MovieStar Cinema uses cookies to enhance your browsing experience. Learn more below.</p>\r\n\r\n        <div class=\"accordion\" id=\"cookieAccordion\">\r\n            <!-- What Are Cookies? -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-info-circle\"></i> What Are Cookies?</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingOne\">\r\n                    <button class=\"accordion-button\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseOne\">\r\n                        Q: What are cookies and why do we use them?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseOne\" class=\"accordion-collapse collapse show\" data-bs-parent=\"#cookieAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: Cookies are **small text files** stored on your device when you visit our website.  \r\n                        They help improve website functionality, **remember user preferences**, and **enable analytics**.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- How We Use Cookies -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-cogs\"></i> How We Use Cookies</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingTwo\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseTwo\">\r\n                        Q: How does MovieStar Cinema use cookies?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseTwo\" class=\"accordion-collapse collapse\" data-bs-parent=\"#cookieAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: We use cookies for the following purposes:\r\n                        <ul>\r\n                            <li>To **enhance website performance** and user experience.</li>\r\n                            <li>To **remember your settings and preferences**.</li>\r\n                            <li>To analyze website traffic using **Google Analytics and similar tools**.</li>\r\n                            <li>For **marketing and targeted advertising**.</li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Types of Cookies -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-list\"></i> Types of Cookies</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingThree\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseThree\">\r\n                        Q: What types of cookies do we use?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseThree\" class=\"accordion-collapse collapse\" data-bs-parent=\"#cookieAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: We use the following types of cookies:\r\n                        <ul>\r\n                            <li><strong>Essential Cookies:</strong> Required for basic site functionality.</li>\r\n                            <li><strong>Performance Cookies:</strong> Help us analyze website usage and improve performance.</li>\r\n                            <li><strong>Functional Cookies:</strong> Remember user preferences and settings.</li>\r\n                            <li><strong>Marketing Cookies:</strong> Used for targeted ads and promotions.</li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Managing Cookies -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-user-cog\"></i> Managing Your Cookie Preferences</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingFour\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseFour\">\r\n                        Q: How can I manage or disable cookies?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseFour\" class=\"accordion-collapse collapse\" data-bs-parent=\"#cookieAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: You can **adjust your cookie settings anytime** in your browser:\r\n                        <ul>\r\n                            <li>For Chrome: <a href=\"https://support.google.com/chrome/answer/95647\">Manage Cookies</a></li>\r\n                            <li>For Firefox: <a href=\"https://support.mozilla.org/en-US/kb/enable-and-disable-cookies-website-preferences\">Manage Cookies</a></li>\r\n                            <li>For Safari: <a href=\"https://support.apple.com/en-us/HT201265\">Manage Cookies</a></li>\r\n                            <li>For Edge: <a href=\"https://support.microsoft.com/en-us/help/4027947/microsoft-edge-delete-cookies\">Manage Cookies</a></li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Privacy Policy -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-shield-alt\"></i> Privacy & Data Protection</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingFive\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseFive\">\r\n                        Q: Where can I read more about data privacy?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseFive\" class=\"accordion-collapse collapse\" data-bs-parent=\"#cookieAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        A: For more details on how we handle personal data, visit our <a href=\"#\">Privacy Policy</a>.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <p class=\"text-center mt-4\">For further assistance, contact us via <a href=\"#\">Customer Support</a>!</p>\r\n    </div>\r\n</div>\r\n ", "http://localhost/Images/photos/cookies.png", "CookiePolicy", "Cookie Policy" },
                    { 7, " \r\n\r\n<div class=\"container\">\r\n    <div class=\"careers-container\">\r\n        <h3><i class=\"fas fa-briefcase\"></i> Careers at MovieStar Cinema</h3>\r\n        <p class=\"careers-intro\">Are you passionate about movies and customer service? Join our team and make every cinema experience special!</p>\r\n\r\n        <div class=\"accordion\" id=\"careersAccordion\">\r\n            <!-- Job Openings -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-bullhorn\"></i> Current Openings</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingOne\">\r\n                    <button class=\"accordion-button\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseOne\">\r\n                        Q: What positions are available?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseOne\" class=\"accordion-collapse collapse show\" data-bs-parent=\"#careersAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        We are currently hiring for the following positions:\r\n                        <ul>\r\n                            <li><strong>🎟 Ticket Sales Associate:</strong> Assisting customers with ticket purchases.</li>\r\n                            <li><strong>🍿 Concessions & Food Service:</strong> Preparing and serving snacks.</li>\r\n                            <li><strong>🎬 Cinema Manager:</strong> Overseeing daily operations and staff.</li>\r\n                            <li><strong>🎥 Projection & Technical Team:</strong> Managing cinema equipment and screenings.</li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Benefits -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-gift\"></i> Employee Benefits</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingTwo\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseTwo\">\r\n                        Q: What benefits do MovieStar Cinema employees receive?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseTwo\" class=\"accordion-collapse collapse\" data-bs-parent=\"#careersAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        Working with us comes with exciting perks:\r\n                        <ul>\r\n                            <li>🎟 **Free & discounted movie tickets**</li>\r\n                            <li>🍿 **Discounts on food and drinks**</li>\r\n                            <li>📅 **Flexible work schedules**</li>\r\n                            <li>🎉 **Fun and friendly work environment**</li>\r\n                            <li>📈 **Career growth opportunities**</li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Requirements -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-user-check\"></i> Job Requirements</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingThree\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseThree\">\r\n                        Q: What are the job requirements?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseThree\" class=\"accordion-collapse collapse\" data-bs-parent=\"#careersAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        Ideal candidates should have:\r\n                        <ul>\r\n                            <li>🌟 A **positive attitude** and customer service skills.</li>\r\n                            <li>⌚ **Availability to work evenings and weekends**.</li>\r\n                            <li>🏃‍♂️ Ability to work in a **fast-paced environment**.</li>\r\n                            <li>📢 **Good communication skills**.</li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Application Process -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-file-alt\"></i> How to Apply</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingFour\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseFour\">\r\n                        Q: How do I apply for a job?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseFour\" class=\"accordion-collapse collapse\" data-bs-parent=\"#careersAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        To apply, send your **resume and cover letter** to:  \r\n                        📧 <strong>info@gmail.com</strong>  \r\n                        Please include the **position you're applying for** in the subject line.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Interview Process -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-comments\"></i> Interview Process</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingFive\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseFive\">\r\n                        Q: What is the hiring process like?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseFive\" class=\"accordion-collapse collapse\" data-bs-parent=\"#careersAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        Our hiring process includes:\r\n                        <ul>\r\n                            <li>📩 **Application review**</li>\r\n                            <li>📞 **Phone interview** (for selected candidates)</li>\r\n                            <li>👥 **In-person interview** at our cinema</li>\r\n                            <li>✅ **Final selection & job offer**</li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <p class=\"text-center mt-4\">Want to be part of our team? Apply now at <strong style =\"color: red;\">info@gmail.com</strong>!</p>\r\n    </div>\r\n</div>\r\n \r\n", "http://localhost/Images/photos/career.png", "Career", "Career" },
                    { 8, " \r\n<div class=\"container\">\r\n    <div class=\"partnership-container\">\r\n        <h3><i class=\"fas fa-handshake\"></i> Partnerships & Advertising</h3>\r\n        <p class=\"partnership-intro\">Want to showcase your brand to thousands of moviegoers? Explore premium advertising and sponsorship opportunities with MovieStar Cinema!</p>\r\n\r\n        <div class=\"accordion\" id=\"partnershipAccordion\">\r\n            <!-- Advertising Options -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-bullhorn\"></i> Advertising Opportunities</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingOne\">\r\n                    <button class=\"accordion-button\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseOne\">\r\n                        Q: What advertising options are available?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseOne\" class=\"accordion-collapse collapse show\" data-bs-parent=\"#partnershipAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        We offer multiple **advertising formats** to promote your brand:\r\n                        <ul>\r\n                            <li>🎬 **On-screen ads** before movies (30-60 seconds spots).</li>\r\n                            <li>🌐 **Digital banners** on our website & mobile app.</li>\r\n                            <li>🎭 **Promotional events** and **brand activations** in our cinemas.</li>\r\n                            <li>📢 **In-theater posters, standees, and flyers**.</li>\r\n                            <li>🎁 **Branded giveaways and sponsorship packages**.</li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Partnership Benefits -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-chart-line\"></i> Why Partner with Us?</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingTwo\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseTwo\">\r\n                        Q: What are the benefits of advertising with MovieStar Cinema?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseTwo\" class=\"accordion-collapse collapse\" data-bs-parent=\"#partnershipAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        Partnering with us provides:\r\n                        <ul>\r\n                            <li>🎯 **Targeted exposure** to engaged audiences.</li>\r\n                            <li>📊 **High recall rates** with cinema advertising.</li>\r\n                            <li>💼 **Premium placement** in a high-traffic entertainment venue.</li>\r\n                            <li>📢 **Direct engagement** through promotional events.</li>\r\n                            <li>🌍 **Nationwide reach** with multiple cinema locations.</li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Event Sponsorships -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-star\"></i> Event Sponsorships</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingThree\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseThree\">\r\n                        Q: Can I sponsor an event at MovieStar Cinema?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseThree\" class=\"accordion-collapse collapse\" data-bs-parent=\"#partnershipAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        Yes! We offer **event sponsorship** for:\r\n                        <ul>\r\n                            <li>🎉 **Movie premieres & special screenings**.</li>\r\n                            <li>🍿 **Exclusive fan events & meet-and-greets**.</li>\r\n                            <li>🏆 **Film festivals & charity screenings**.</li>\r\n                            <li>🎁 **Branded giveaways & product launches**.</li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Partnership Options -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-handshake\"></i> Partnership Opportunities</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingFour\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseFour\">\r\n                        Q: What kind of partnerships do you offer?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseFour\" class=\"accordion-collapse collapse\" data-bs-parent=\"#partnershipAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        We welcome **long-term partnerships** with:\r\n                        <ul>\r\n                            <li>🎬 **Film distributors & studios**.</li>\r\n                            <li>🏪 **Brands & corporate sponsors**.</li>\r\n                            <li>🎟 **Loyalty program partners**.</li>\r\n                            <li>📢 **Local businesses for community promotions**.</li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <!-- Contact Information -->\r\n            <h4 class=\"mt-3\"><i class=\"fas fa-envelope\"></i> Get in Touch</h4>\r\n\r\n            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\" id=\"headingFive\">\r\n                    <button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseFive\">\r\n                        Q: How do I start a partnership or book an ad?\r\n                    </button>\r\n                </h2>\r\n                <div id=\"collapseFive\" class=\"accordion-collapse collapse\" data-bs-parent=\"#partnershipAccordion\">\r\n                    <div class=\"accordion-body\">\r\n                        Contact our **marketing team** at:  \r\n                        📧 <strong>info@gmail.com</strong>  \r\n                        Let’s create something amazing together!\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <p class=\"text-center mt-4\">Interested? Contact us today at <strong>info@gmail.com</strong> to discuss collaboration opportunities!</p>\r\n    </div>\r\n</div>\r\n\r\n \r\n", "http://localhost/Images/photos/partnership.png", "Partnership", "Partnership" }
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
                columns: new[] { "Id", "AgeRatingId", "CountryId", "CreatedAt", "Description", "Duration", "GenreId", "IsActive", "ModifiedAt", "MovieFormatId", "MovieProductionCompanyId", "Name", "TicketPrice", "UserId", "imageUrl" },
                values: new object[,]
                {
                    { 1, 3, 2, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "\"Killing Dead Man\" is a pulse-pounding action thriller that takes audiences on a relentless ride through a world where morality is a luxury and survival is the only rule.\r\n\r\nSet against the gritty backdrop of a crime-ridden American metropolis, the film follows ex-hitman Jack Mercer—a man who left behind a violent past only to find that the past isn’t done with him. When a mysterious contract is put out on his life, Mercer is forced back into the deadly underworld he once escaped. Hunted by elite assassins and betrayed by those he trusted, he soon discovers that the one pulling the strings is none other than a man he killed years ago… or so he thought.\r\n\r\nAs the lines between reality and deception blur, Mercer must unravel the truth before he becomes just another forgotten name on a hit list. Fueled by explosive action sequences, intense hand-to-hand combat, and a gripping narrative of revenge and redemption, Killing Dead Man is a high-stakes adrenaline rush from start to finish.\r\n\r\nBrought to life by Warner Bros., this 18+ action spectacle delivers breathtaking cinematography in a classic 4:3 format, immersing viewers in its raw, uncompromising aesthetic. With a runtime of 103 minutes, it’s a relentless, edge-of-your-seat experience that will leave audiences questioning whether the dead ever truly stay buried.", 103, 1, true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Killing Dead Man", 15.99m, null, "\\photos\\1.png" },
                    { 2, 3, 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "In a dystopian future where technology and warfare have merged, elite soldier Captain Ryan Drake is tasked with a mission that could alter the fate of the world. With cyber-enhanced mercenaries, lethal drones, and corrupt corporations standing in his way, Drake must navigate a battlefield of deception and destruction. Explosive action, high-tech combat, and an adrenaline-fueled storyline make 'Shadow Strike' an unmissable cinematic spectacle.", 120, 1, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "Shadow Strike", 17.99m, null, "\\photos\\2.png" },
                    { 3, 3, 1, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deep within the haunted forests of Poland, an abandoned village holds a terrifying secret. When journalist Anna Kowalski investigates the eerie whispers that plague the nearby town, she uncovers a horrifying legend of lost souls trapped between worlds. As night falls, shadows move, whispers turn to screams, and Anna realizes she’s not alone. With no escape and sanity slipping away, she must face the dark truth before she becomes part of the legend herself. *Whispers in the Dark* is a chilling horror masterpiece from Netflix, blending psychological terror with supernatural horror in a spine-tingling tale you won't forget.", 112, 5, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "Whispers in the Dark", 14.99m, null, "\\photos\\3.png" },
                    { 4, 3, 3, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "In a neon-lit future where corporations rule and cybernetic enhancements are the norm, rogue enforcer Kai Renegade is the last hope for a crumbling society. When a powerful AI goes rogue, launching a drone war over the towering metropolis of Neo-Berlin, Kai must wield his twin plasma blades and fight his way through an army of cybernetic mercenaries. With the city on the brink of collapse and time running out, he faces the ultimate choice: submit to the machine or rewrite the future. *Niefllerissing* is a visually stunning, adrenaline-charged action thriller that pushes the boundaries of sci-fi cinema.", 118, 1, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "Niefllerissing", 16.99m, null, "\\photos\\4.png" },
                    { 5, 2, 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "On a misty evening at a quiet train station, two women, once inseparable, stand facing each other for the final time. As the sun sets in the distance, casting an orange glow over the platform, the weight of their past begins to resurface. *The Last Goodbye* tells a poignant story of love, loss, and the bittersweet moments that define our lives. As the trains come and go, they are forced to confront their emotions and say goodbye—forever.", 95, 2, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "The Last Goodbye", 12.99m, null, "\\photos\\5.png" },
                    { 6, 1, 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "At a lavish wedding ceremony, the groom stands in confusion, alone in front of the altar in his tuxedo, waiting for the bride. But as the doors swing open, it's not his bride that enters—it's a different woman, running past him to the man standing at the back. In a whirlwind of mistaken identities and hilarious events, *Ooops! Wrong Wedding* brings to life the chaos of love, misunderstandings, and the consequences of running away from commitment. Prepare for a comedy of errors that will have you laughing from start to finish.", 90, 2, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "Ooops! Wrong Wedding", 10.99m, null, "\\photos\\6.png" },
                    { 7, 3, 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "In a war-torn, desolate town, one man walks through the devastation with unwavering determination. With a burning car in the background, his focus never wavers as he strides forward, prepared to take vengeance on those who destroyed everything he loved. *Bulletproof Vengeance* is an action-packed thriller that follows a soldier's relentless quest for revenge in a world where justice is earned with blood, sweat, and bullets. The stakes are high, and survival is the only option.", 105, 1, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "Bulletproof Vengeance", 15.99m, null, "\\photos\\7.png" },
                    { 8, 2, 3, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "In a small, dimly lit room, a man sits on the floor, typing away on a vintage typewriter, the rhythmic sound of the keys echoing in the silence. Outside the window, life continues without him, as people move along, oblivious to his internal struggle. *A Life Unwritten* explores the complexities of a man’s inner world, his dreams, and the stories he longs to tell, all while grappling with the reality of an unfulfilled life. A heartfelt drama about the power of words and the burden of missed opportunities.", 100, 3, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "A Life Unwritten", 13.99m, null, "\\photos\\8.png" },
                    { 9, 1, 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "In the midst of a chaotic office, one boss is on a rampage. Papers fly, cups crash to the floor, and his office workers are caught in the crossfire, all while the rest of the staff remain glued to their computer screens, oblivious to the storm that’s unfolding. *My Crazy Boss* is a hilarious comedy about the unpredictable, often absurd world of office life, where chaos reigns and no one is safe from the eccentricities of their leader. Prepare for non-stop laughter and ridiculous office antics!", 85, 1, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "My Crazy Boss", 11.99m, null, "\\photos\\9.png" },
                    { 10, 3, 1, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Under the eerie glow of a blood-red moon, a sinister figure, resembling a villain from the darkest of nightmares, prowls the streets of an abandoned town. The air is thick with fear as the old church looms in the background, its doors creaking open to welcome the horrors that await. *Silent Screams* is a chilling horror film that takes you on a terrifying journey into the heart of darkness, where every shadow hides a secret and every scream is swallowed by the silence of the night.", 110, 5, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "Silent Screams", 14.99m, null, "\\photos\\10.png" },
                    { 11, 2, 3, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Standing at the edge of a cliff, a man faces a breathtaking view of the land below, where the clouds part to let the sunlight beam through. The world feels vast, filled with possibilities, and an old, mysterious clock floats above him in the air—its hands frozen in time. *Crossroads of Fate* is a stunning fantasy adventure that explores the moment when a single choice can change the course of a life forever. As the man stares into the unknown, he must decide if he will step into the future or remain bound by the past.", 105, 4, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "Crossroads of Fate", 13.49m, null, "\\photos\\11.png" },
                    { 12, 1, 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "In an animated world of confusion and chaos, *The Clumsy Detective* tries his best to solve the case, though things rarely go as planned. Surrounded by stacks of documents, a curious cat by his side, and a few sharp-suited gentlemen in the office, the detective is a lovable mess. As he stumbles through clues and mishaps, his true genius shines through, despite the comedic disaster he causes. This hilarious animated feature will have you laughing out loud as the clumsy detective slowly but surely unravels the mystery.", 90, 1, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "The Clumsy Detective", 9.99m, null, "\\photos\\12.png" },
                    { 13, 2, 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "In the vastness of space, where the boundaries of reality bend and twist, a spaceship embarks on a journey beyond the known universe. As the Earth and the Moon drift silently in the background, the crew is drawn toward a mysterious rift, a cosmic tunnel that looks like an Einstein-Rosen bridge. Inside it, a brilliant star, like the Sun, beckons them into the unknown. *Beyond the Rift* is a thrilling sci-fi adventure that explores the deepest mysteries of the cosmos, where space and time converge and the fate of the universe hangs in the balance.", 120, 4, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "Beyond the Rift", 16.99m, null, "\\photos\\13.png" },
                    { 14, 1, 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "In a cozy, dimly lit restaurant, a man and a woman sit close together, sipping on lattes, their conversations filled with secrets, shared smiles, and the occasional laugh. As their hands touch over the table and their faces lean in, the chemistry between them is undeniable. But beneath their blossoming romance lies a web of lies that threatens to unravel everything. *Love, Lies, Love and Lattes* is a heartwarming romantic comedy about love's unpredictable twists and the sweet moments shared over coffee that may just change everything.", 90, 2, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "Love, Lies, Love and Lattes", 11.49m, null, "\\photos\\14.png" },
                    { 15, 3, 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "In the heart of a dark, rain-soaked city, three hooded assassins in black move swiftly across the rooftops, their silhouettes cutting through the evening sky. Armed and focused, they traverse the heights with deadly precision, preparing to strike. In the background, the city’s skyline looms, a constant reminder of the danger that lurks within its depths. *Rouge Rouge Assassins* is an intense action thriller that follows a group of elite assassins on a high-stakes mission, where loyalty is tested, and the line between right and wrong blurs in the shadows of the city.", 110, 1, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "Rouge Rouge Assassins", 14.99m, null, "\\photos\\15.png" },
                    { 16, 2, 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "On the edge of a barren world, the last surviving humans stand before a sleek, futuristic complex, their last hope for survival. In the distance, a spacecraft hovers near the massive colony, and beyond that, another planet—or perhaps a moon—looms ominously in the sky. *The Last Colony* takes you on a thrilling journey into space where humanity's future depends on a fragile settlement in the farthest reaches of the galaxy. With danger on all sides and secrets lurking within the complex, seven brave souls must decide what kind of future awaits them in the unknown.", 125, 4, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "The Last Colony", 17.99m, null, "\\photos\\16.png" },
                    { 17, 1, 3, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "A man stands alone on the shore, gazing out at the calm sea beneath a sky filled with the breathtaking glow of constellations. The night is still, the only sound being the gentle lapping of waves. As he stares into the vast expanse of stars, the weight of his dreams, his losses, and his longing fill the silence. *Falling Stars* is a poignant drama that explores the fragility of hope, the impact of dreams lost and regained, and the eternal search for meaning beneath the stars.", 95, 3, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "Falling Stars", 12.49m, null, "\\photos\\17.png" },
                    { 18, 3, 1, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "On a moonlit night, beneath the eerie glow of a full moon, a small wooden bridge stretches over a misty chasm, flanked by old, dead trees. The air is thick with a chilling fog as a man, dressed in dark clerical robes, stands at the end of the bridge, accompanied by a child. The silence is oppressive, broken only by the whispers of the past. *The Cursed Hollow* is a supernatural horror that delves into the heart of an ancient curse, where the line between the living and the dead blurs, and the truth must be uncovered before the darkness consumes them all.", 115, 5, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "The Cursed Hollow", 14.99m, null, "\\photos\\18.png" },
                    { 19, 2, 3, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "In the heart of a ferocious storm, five warriors stand tall on a lone stone amidst the restless sea, their magical weapons glowing with power. Flame swords, lightning-infused blades, and mystical artifacts crackle with energy as thunder cracks the sky. The sea rages around them, but these heroes are unyielding, bound by a common fate. *Tormbreakers* is an epic fantasy adventure where magic, courage, and destiny collide in a world on the brink of destruction. As the storm rages, so too does the battle for the future of their realm.", 130, 4, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "Tormbreakers", 16.49m, null, "\\photos\\19.png" },
                    { 20, 3, 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "A portal to another dimension opens, revealing a futuristic world where time itself is at war. Soldiers, dressed in advanced SWAT gear, patrol the perimeter of the rift, weapons at the ready as spacecrafts zoom overhead. In the background, the mighty Pantheon stands as a symbol of ancient power and mystery. *ChronoWars* is a gripping sci-fi action thriller that spans across time and dimensions, where elite soldiers battle to control the flow of history itself. As they fight for dominance, the future of all worlds hangs in the balance.", 140, 4, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "ChronoWars", 18.99m, null, "\\photos\\20.png" }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name", "NumberInRow", "Row", "ScreenId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A1", 1, 1, 1 },
                    { 2, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A2", 2, 1, 1 },
                    { 3, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A3", 3, 1, 1 },
                    { 4, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A4", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A4", 4, 1, 1 },
                    { 5, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A5", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A5", 5, 1, 1 },
                    { 6, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A6", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A6", 6, 1, 1 },
                    { 7, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A7", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A7", 7, 1, 1 },
                    { 8, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A8", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A8", 8, 1, 1 },
                    { 9, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A9", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A9", 9, 1, 1 },
                    { 10, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A10", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A10", 10, 1, 1 },
                    { 11, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B1", 1, 2, 1 },
                    { 12, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B2", 2, 2, 1 },
                    { 13, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B3", 3, 2, 1 },
                    { 14, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B4", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B4", 4, 2, 1 },
                    { 15, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B5", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B5", 5, 2, 1 },
                    { 16, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B6", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B6", 6, 2, 1 },
                    { 17, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B7", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B7", 7, 2, 1 },
                    { 18, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B8", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B8", 8, 2, 1 },
                    { 19, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B9", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B9", 9, 2, 1 },
                    { 20, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B10", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B10", 10, 2, 1 },
                    { 21, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C1", 1, 3, 1 },
                    { 22, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C2", 2, 3, 1 },
                    { 23, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C3", 3, 3, 1 },
                    { 24, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C4", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C4", 4, 3, 1 },
                    { 25, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C5", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C5", 5, 3, 1 },
                    { 26, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C6", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C6", 6, 3, 1 },
                    { 27, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C7", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C7", 7, 3, 1 },
                    { 28, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C8", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C8", 8, 3, 1 },
                    { 29, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C9", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C9", 9, 3, 1 },
                    { 30, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C10", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C10", 10, 3, 1 },
                    { 31, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D1", 1, 4, 1 },
                    { 32, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D2", 2, 4, 1 },
                    { 33, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D3", 3, 4, 1 },
                    { 34, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D4", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D4", 4, 4, 1 },
                    { 35, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D5", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D5", 5, 4, 1 },
                    { 36, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D6", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D6", 6, 4, 1 },
                    { 37, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D7", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D7", 7, 4, 1 },
                    { 38, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D8", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D8", 8, 4, 1 },
                    { 39, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D9", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D9", 9, 4, 1 },
                    { 40, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D10", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D10", 10, 4, 1 },
                    { 41, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E1", 1, 5, 1 },
                    { 42, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E2", 2, 5, 1 },
                    { 43, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E3", 3, 5, 1 },
                    { 44, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E4", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E4", 4, 5, 1 },
                    { 45, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E5", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E5", 5, 5, 1 },
                    { 46, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E6", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E6", 6, 5, 1 },
                    { 47, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E7", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E7", 7, 5, 1 },
                    { 48, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E8", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E8", 8, 5, 1 },
                    { 49, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E9", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E9", 9, 5, 1 },
                    { 50, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E10", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E10", 10, 5, 1 },
                    { 51, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A1", 1, 1, 2 },
                    { 52, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A2", 2, 1, 2 },
                    { 53, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A3", 3, 1, 2 },
                    { 54, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A4", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A4", 4, 1, 2 },
                    { 55, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A5", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A5", 5, 1, 2 },
                    { 56, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A6", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A6", 6, 1, 2 },
                    { 57, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A7", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A7", 7, 1, 2 },
                    { 58, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A8", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A8", 8, 1, 2 },
                    { 59, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A9", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A9", 9, 1, 2 },
                    { 60, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A10", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A10", 10, 1, 2 },
                    { 61, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B1", 1, 2, 2 },
                    { 62, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B2", 2, 2, 2 },
                    { 63, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B3", 3, 2, 2 },
                    { 64, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B4", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B4", 4, 2, 2 },
                    { 65, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B5", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B5", 5, 2, 2 },
                    { 66, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B6", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B6", 6, 2, 2 },
                    { 67, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B7", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B7", 7, 2, 2 },
                    { 68, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B8", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B8", 8, 2, 2 },
                    { 69, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B9", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B9", 9, 2, 2 },
                    { 70, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B10", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B10", 10, 2, 2 },
                    { 71, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C1", 1, 3, 2 },
                    { 72, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C2", 2, 3, 2 },
                    { 73, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C3", 3, 3, 2 },
                    { 74, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C4", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C4", 4, 3, 2 },
                    { 75, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C5", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C5", 5, 3, 2 },
                    { 76, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C6", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C6", 6, 3, 2 },
                    { 77, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C7", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C7", 7, 3, 2 },
                    { 78, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C8", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C8", 8, 3, 2 },
                    { 79, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C9", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C9", 9, 3, 2 },
                    { 80, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C10", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C10", 10, 3, 2 },
                    { 81, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D1", 1, 4, 2 },
                    { 82, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D2", 2, 4, 2 },
                    { 83, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D3", 3, 4, 2 },
                    { 84, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D4", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D4", 4, 4, 2 },
                    { 85, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D5", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D5", 5, 4, 2 },
                    { 86, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D6", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D6", 6, 4, 2 },
                    { 87, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D7", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D7", 7, 4, 2 },
                    { 88, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D8", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D8", 8, 4, 2 },
                    { 89, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D9", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D9", 9, 4, 2 },
                    { 90, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D10", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D10", 10, 4, 2 },
                    { 91, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E1", 1, 5, 2 },
                    { 92, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E2", 2, 5, 2 },
                    { 93, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E3", 3, 5, 2 },
                    { 94, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E4", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E4", 4, 5, 2 },
                    { 95, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E5", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E5", 5, 5, 2 },
                    { 96, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E6", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E6", 6, 5, 2 },
                    { 97, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E7", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E7", 7, 5, 2 },
                    { 98, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E8", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E8", 8, 5, 2 },
                    { 99, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E9", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E9", 9, 5, 2 },
                    { 100, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E10", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E10", 10, 5, 2 },
                    { 101, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A1", 1, 1, 3 },
                    { 102, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A2", 2, 1, 3 },
                    { 103, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A3", 3, 1, 3 },
                    { 104, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A4", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A4", 4, 1, 3 },
                    { 105, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A5", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A5", 5, 1, 3 },
                    { 106, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A6", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A6", 6, 1, 3 },
                    { 107, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A7", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A7", 7, 1, 3 },
                    { 108, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A8", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A8", 8, 1, 3 },
                    { 109, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A9", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A9", 9, 1, 3 },
                    { 110, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A10", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A10", 10, 1, 3 },
                    { 111, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B1", 1, 2, 3 },
                    { 112, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B2", 2, 2, 3 },
                    { 113, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B3", 3, 2, 3 },
                    { 114, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B4", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B4", 4, 2, 3 },
                    { 115, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B5", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B5", 5, 2, 3 },
                    { 116, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B6", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B6", 6, 2, 3 },
                    { 117, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B7", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B7", 7, 2, 3 },
                    { 118, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B8", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B8", 8, 2, 3 },
                    { 119, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B9", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B9", 9, 2, 3 },
                    { 120, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B10", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "B10", 10, 2, 3 },
                    { 121, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C1", 1, 3, 3 },
                    { 122, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C2", 2, 3, 3 },
                    { 123, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C3", 3, 3, 3 },
                    { 124, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C4", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C4", 4, 3, 3 },
                    { 125, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C5", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C5", 5, 3, 3 },
                    { 126, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C6", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C6", 6, 3, 3 },
                    { 127, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C7", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C7", 7, 3, 3 },
                    { 128, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C8", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C8", 8, 3, 3 },
                    { 129, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C9", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C9", 9, 3, 3 },
                    { 130, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C10", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "C10", 10, 3, 3 },
                    { 131, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D1", 1, 4, 3 },
                    { 132, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D2", 2, 4, 3 },
                    { 133, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D3", 3, 4, 3 },
                    { 134, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D4", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D4", 4, 4, 3 },
                    { 135, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D5", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D5", 5, 4, 3 },
                    { 136, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D6", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D6", 6, 4, 3 },
                    { 137, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D7", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D7", 7, 4, 3 },
                    { 138, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D8", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D8", 8, 4, 3 },
                    { 139, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D9", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D9", 9, 4, 3 },
                    { 140, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D10", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "D10", 10, 4, 3 },
                    { 141, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E1", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E1", 1, 5, 3 },
                    { 142, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E2", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E2", 2, 5, 3 },
                    { 143, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E3", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E3", 3, 5, 3 },
                    { 144, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E4", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E4", 4, 5, 3 },
                    { 145, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E5", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E5", 5, 5, 3 },
                    { 146, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E6", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E6", 6, 5, 3 },
                    { 147, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E7", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E7", 7, 5, 3 },
                    { 148, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E8", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E8", 8, 5, 3 },
                    { 149, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E9", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E9", 9, 5, 3 },
                    { 150, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E10", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "E10", 10, 5, 3 }
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
                name: "Actor");

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
                name: "Director");

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
                name: "Award");

            migrationBuilder.DropTable(
                name: "TypeOfElementOfMenu");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "MovieKeywords");

            migrationBuilder.DropTable(
                name: "Subtitles");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "ScreeningSeat");

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
