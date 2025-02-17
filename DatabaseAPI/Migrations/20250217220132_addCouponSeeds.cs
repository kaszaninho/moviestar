using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DatabaseAPI.Migrations
{
    /// <inheritdoc />
    public partial class addCouponSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Coupon",
                columns: new[] { "Id", "CreatedAt", "Description", "Discount", "IsActive", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coupon for 5%", 5, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "MOVIE5" },
                    { 2, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coupon for 20%", 5, true, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "MOVIE20" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
