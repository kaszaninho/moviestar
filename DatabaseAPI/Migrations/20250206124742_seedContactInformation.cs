using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DatabaseAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedContactInformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactInformation",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ContactInformation",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ContactInformation",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ContactInformation",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ContactInformation",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
