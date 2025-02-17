using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DatabaseAPI.Migrations
{
    /// <inheritdoc />
    public partial class addSeedOpeningHour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OpeningHour",
                columns: new[] { "Id", "CreatedAt", "Description", "EndHour", "IsActive", "ModifiedAt", "Name", "StartHour" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monday", 10 },
                    { 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tuesday", 10 },
                    { 3, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wednesday", 10 },
                    { 4, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thursday", 10 },
                    { 5, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Friday", 10 },
                    { 6, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saturday", 11 },
                    { 7, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", 10 },
                    { 8, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christmas' Eve", 9 },
                    { 9, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christmas' Day", null },
                    { 10, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stephen's Day", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OpeningHour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OpeningHour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OpeningHour",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OpeningHour",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OpeningHour",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OpeningHour",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OpeningHour",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OpeningHour",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OpeningHour",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OpeningHour",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
