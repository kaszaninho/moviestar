using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseAPI.Migrations
{
    /// <inheritdoc />
    public partial class correctSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Navbar",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                column: "imageUrl",
                value: "\\photos\\1.png");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                column: "imageUrl",
                value: "\\photos\\2.png");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                column: "imageUrl",
                value: "\\photos\\3.png");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                column: "imageUrl",
                value: "\\photos\\4.png");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                column: "imageUrl",
                value: "\\photos\\5.png");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6,
                column: "imageUrl",
                value: "\\photos\\6.png");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                column: "imageUrl",
                value: "\\photos\\7.png");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 8,
                column: "imageUrl",
                value: "\\photos\\8.png");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 9,
                column: "imageUrl",
                value: "\\photos\\9.png");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 10,
                column: "imageUrl",
                value: "\\photos\\10.png");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 11,
                column: "imageUrl",
                value: "\\photos\\11.png");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 12,
                column: "imageUrl",
                value: "\\photos\\12.png");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 13,
                column: "imageUrl",
                value: "\\photos\\13.png");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 14,
                column: "imageUrl",
                value: "\\photos\\14.png");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 15,
                column: "imageUrl",
                value: "\\photos\\15.png");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 16,
                column: "imageUrl",
                value: "\\photos\\16.png");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 17,
                column: "imageUrl",
                value: "\\photos\\17.png");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 18,
                column: "imageUrl",
                value: "\\photos\\18.png");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 19,
                column: "imageUrl",
                value: "\\photos\\19.png");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 20,
                column: "imageUrl",
                value: "\\photos\\20.png");

            migrationBuilder.UpdateData(
                table: "Navbar",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Action", "Content", "Controller", "Name" },
                values: new object[] { "Index", "Cart", "Cart", "Cart" });

            migrationBuilder.UpdateData(
                table: "Navbar",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Action", "Content", "Controller", "Name" },
                values: new object[] { "Contact", "Contact", "Home", "Contact" });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "A1");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "A2");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "A3");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "B1");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "B2");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "B3");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "C1");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "C2");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "C3");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "A1");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "A2");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "A3");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "B1");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "B2");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "B3");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "C1");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "C2");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "C3");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "A1");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "A2");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "A3");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "B1");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 23,
                column: "Name",
                value: "B2");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 24,
                column: "Name",
                value: "B3");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "C1");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "C2");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 27,
                column: "Name",
                value: "C3");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                column: "imageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                column: "imageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                column: "imageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                column: "imageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                column: "imageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6,
                column: "imageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                column: "imageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 8,
                column: "imageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 9,
                column: "imageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 10,
                column: "imageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 11,
                column: "imageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 12,
                column: "imageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 13,
                column: "imageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 14,
                column: "imageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 15,
                column: "imageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 16,
                column: "imageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 17,
                column: "imageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 18,
                column: "imageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 19,
                column: "imageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 20,
                column: "imageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Navbar",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Action", "Content", "Controller", "Name" },
                values: new object[] { "ShowScreeningsForMovie", "Screenings", "Movie", "Screenings" });

            migrationBuilder.UpdateData(
                table: "Navbar",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Action", "Content", "Controller", "Name" },
                values: new object[] { "Index", "Cart", "Cart", "Cart" });

            migrationBuilder.InsertData(
                table: "Navbar",
                columns: new[] { "Id", "Action", "Content", "Controller", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name", "Position" },
                values: new object[] { 6, "Contact", "Contact", "Home", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contact", 6 });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "1/1");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "1/2");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "1/3");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "2/1");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "2/2");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "2/3");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "3/1");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "3/2");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "3/3");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "1/1");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "1/2");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "1/3");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "2/1");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "2/2");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "2/3");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "3/1");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "3/2");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "3/3");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "1/1");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "1/2");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "1/3");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "2/1");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 23,
                column: "Name",
                value: "2/2");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 24,
                column: "Name",
                value: "2/3");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "3/1");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "3/2");

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 27,
                column: "Name",
                value: "3/3");
        }
    }
}
