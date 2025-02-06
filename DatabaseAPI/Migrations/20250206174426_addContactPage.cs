using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseAPI.Migrations
{
    /// <inheritdoc />
    public partial class addContactPage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Navbar",
                columns: new[] { "Id", "Action", "Content", "Controller", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name", "Position" },
                values: new object[] { 6, "Contact", "Contact", "Home", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", true, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contact", 6 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Navbar",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
