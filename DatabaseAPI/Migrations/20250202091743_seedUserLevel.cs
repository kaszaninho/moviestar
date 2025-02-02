using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DatabaseAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedUserLevel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5342), new DateTime(1994, 11, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5348), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5357), new DateTime(1994, 11, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5362), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5364), new DateTime(2004, 9, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5369), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "AgeRating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(4640), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "AgeRating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(4696), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "AgeRating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(4702), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "Award",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(4898), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "Award",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(4905), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(4941), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(4946), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(4948) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(4951), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5400), new DateTime(1974, 11, 25, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5406), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5411), new DateTime(1965, 3, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5416), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(4983), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(4989), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(4993), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5035), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5038) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5040), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5042) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5046), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "MovieFormat",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5074), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5076) });

            migrationBuilder.UpdateData(
                table: "MovieFormat",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5079), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5081) });

            migrationBuilder.UpdateData(
                table: "MovieKeywords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5113), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "MovieKeywords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5118), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "MovieKeywords",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5123), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5124) });

            migrationBuilder.UpdateData(
                table: "MovieProductionCompany",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5151), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "MovieProductionCompany",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5156), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "MovieProductionCompany",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5160), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5230), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5237), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Screen",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5445), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "Screen",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5452), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "Screen",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5458), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5459) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5487), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5494), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5496) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5499), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5501) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5504), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5506) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5509), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5514), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5516) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5521), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5526), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5531), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5536), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5538) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5541), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5543) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5546), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5551), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5556), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5562), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5564) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5567), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5572), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5588), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5594), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5599), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5604), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5610), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5614), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5619), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5624), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5629), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5634), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5189), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5195), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5200), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.InsertData(
                table: "UserLevel",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name", "PointsToNextLevel" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5306), "Lvl1", true, new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5308), "Lvl1", 10 },
                    { 2, new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5312), "Lvl2", true, new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5315), "Lvl2", 50 }
                });

            migrationBuilder.UpdateData(
                table: "WorkPosition",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5266), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "WorkPosition",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5271), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "WorkPosition",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5276), new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5278) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserLevel",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserLevel",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1803), new DateTime(1994, 11, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1811), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1816), new DateTime(1994, 11, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1821), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1823), new DateTime(2004, 9, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1828), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "AgeRating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1157), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1210) });

            migrationBuilder.UpdateData(
                table: "AgeRating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1214), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "AgeRating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1219), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1221) });

            migrationBuilder.UpdateData(
                table: "Award",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1402), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1406) });

            migrationBuilder.UpdateData(
                table: "Award",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1409), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1411) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1445), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1447) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1450), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1452) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1455), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1457) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1867), new DateTime(1974, 11, 25, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1874), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1879), new DateTime(1965, 3, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1883), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1485), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1491), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1495), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1497) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1525), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1530), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1535), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "MovieFormat",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1562), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "MovieFormat",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1567), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "MovieKeywords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1604), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "MovieKeywords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1609), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "MovieKeywords",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1614), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "MovieProductionCompany",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1642), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "MovieProductionCompany",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1647), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "MovieProductionCompany",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1651), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1727), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1732), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Screen",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1914), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "Screen",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1920), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "Screen",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1924), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1953), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1960), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1965), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1970), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1975), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1980), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1985), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1990), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1996), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2001), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2006), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2010), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2012) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2015), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2017) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2020), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2025), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2026) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2029), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2031) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2035), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2040), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2042) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2045), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2047) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2050), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2055), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2060), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2064), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2069), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2074), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2079), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2084), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(2086) });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1681), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1686), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1690), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "WorkPosition",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1761), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "WorkPosition",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1766), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "WorkPosition",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1771), new DateTime(2025, 2, 2, 10, 9, 35, 521, DateTimeKind.Local).AddTicks(1772) });
        }
    }
}
