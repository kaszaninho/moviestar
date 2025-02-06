using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DatabaseAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedNavbar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Navbar",
                columns: new[] { "Id", "Action", "Content", "Controller", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name", "Position" },
                values: new object[,]
                {
                    { 1, "Index", "Home", "Home", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Home", 1 },
                    { 2, "InvoiceReportForUser", "Invoices", "Home", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Invoices", 2 },
                    { 3, "Index", "Movies", "Movie", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movies", 3 },
                    { 4, "ShowScreeningsForMovie", "Screenings", "Movie", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Screenings", 4 },
                    { 5, "Index", "Cart", "Cart", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cart", 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Navbar",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Navbar",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Navbar",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Navbar",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Navbar",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
