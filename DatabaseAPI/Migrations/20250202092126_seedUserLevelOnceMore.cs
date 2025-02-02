using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedUserLevelOnceMore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2848), new DateTime(1994, 11, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2854), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2863), new DateTime(1994, 11, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2868), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2871), new DateTime(2004, 9, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2876), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "AgeRating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2052), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "AgeRating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2117), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "AgeRating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2122), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "Award",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2347), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "Award",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2355), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2395), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2400), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2405), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2905), new DateTime(1974, 11, 25, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2912), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2917), new DateTime(1965, 3, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2921), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2436), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2441), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2445), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2478), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2484), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2489), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "MovieFormat",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2516), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "MovieFormat",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2521), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "MovieKeywords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2565), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "MovieKeywords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2574), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "MovieKeywords",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2580), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "MovieProductionCompany",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2627), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2631) });

            migrationBuilder.UpdateData(
                table: "MovieProductionCompany",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2636), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "MovieProductionCompany",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2643), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2735), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2740), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "Screen",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2950), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Screen",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2956), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Screen",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2962), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3000), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3007), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3012), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3017), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3022), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3027), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3032), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3037), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3042), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3047), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3052), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3057), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3062), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3067), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3069) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3073), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3078), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3083), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3088), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3093), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3099), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3103), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3108), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3114), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3119), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3123), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3128), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3133), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2691), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2698), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2703), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "UserLevel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2813), "Level 1", new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2815), "1" });

            migrationBuilder.UpdateData(
                table: "UserLevel",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2818), "Level 2", new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2820), "2" });

            migrationBuilder.UpdateData(
                table: "WorkPosition",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2771), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "WorkPosition",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2776), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2778) });

            migrationBuilder.UpdateData(
                table: "WorkPosition",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2781), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2783) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "UserLevel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5306), "Lvl1", new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5308), "Lvl1" });

            migrationBuilder.UpdateData(
                table: "UserLevel",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5312), "Lvl2", new DateTime(2025, 2, 2, 10, 17, 42, 115, DateTimeKind.Local).AddTicks(5315), "Lvl2" });

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
    }
}
