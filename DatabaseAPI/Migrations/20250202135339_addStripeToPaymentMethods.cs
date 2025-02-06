using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseAPI.Migrations
{
    /// <inheritdoc />
    public partial class addStripeToPaymentMethods : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9998), new DateTime(1994, 11, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(3), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(10), new DateTime(1994, 11, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(15), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(17), new DateTime(2004, 9, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(21), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "AgeRating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9108), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "AgeRating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9167), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "AgeRating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9171), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Award",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9567), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "Award",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9574), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9610), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9616), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9629), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(49), new DateTime(1974, 11, 25, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(57), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(51) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(61), new DateTime(1965, 3, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(65), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9662), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9667), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9670), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9703), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9707), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9713), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9715) });

            migrationBuilder.UpdateData(
                table: "MovieFormat",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9738), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "MovieFormat",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9745), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "MovieKeywords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9781), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "MovieKeywords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9786), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9787) });

            migrationBuilder.UpdateData(
                table: "MovieKeywords",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9790), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "MovieProductionCompany",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9815), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "MovieProductionCompany",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9820), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9822) });

            migrationBuilder.UpdateData(
                table: "MovieProductionCompany",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9824), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9890), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9895), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9897) });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "ModifiedAt", "Name" },
                values: new object[] { 3, new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9899), "Stripe", true, new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9900), "Stripe" });

            migrationBuilder.UpdateData(
                table: "Screen",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(92), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "Screen",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(97), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "Screen",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(101), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(128), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(135), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(140), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(144), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(148), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(152), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(155) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(158), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(169), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(173), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(175) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(177), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(179) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(182), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(183) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(186), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(188) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(191), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(196), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(200), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(205), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(209), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(213), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(218), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(222), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(227), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(232), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(236), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(241), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(242) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(245), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(249), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(254), new DateTime(2025, 2, 2, 14, 53, 38, 416, DateTimeKind.Local).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9855), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9859), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9863), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "UserLevel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9965), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "UserLevel",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9971), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "WorkPosition",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9926), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "WorkPosition",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9930), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "WorkPosition",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9934), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9936) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8834), new DateTime(1994, 11, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8844), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8852), new DateTime(1994, 11, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8860), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8863), new DateTime(2004, 9, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8869), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "AgeRating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(7482), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "AgeRating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(7580), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "AgeRating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(7587), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "Award",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(7967), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Award",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(7995), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8063), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8071), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8078), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8916), new DateTime(1974, 11, 25, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8926), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8932), new DateTime(1965, 3, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8937), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8193), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8205), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8211), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8272), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8282), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8289), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "MovieFormat",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8333), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "MovieFormat",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8400), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "MovieKeywords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8463), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "MovieKeywords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8471), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8473) });

            migrationBuilder.UpdateData(
                table: "MovieKeywords",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8477), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8479) });

            migrationBuilder.UpdateData(
                table: "MovieProductionCompany",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8524), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "MovieProductionCompany",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8532), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8535) });

            migrationBuilder.UpdateData(
                table: "MovieProductionCompany",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8538), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8653), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8661), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "Screen",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8989), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8993) });

            migrationBuilder.UpdateData(
                table: "Screen",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8998), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "Screen",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9006), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9083), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9092), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9096), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9101), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9105), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9109), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9114), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9119), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9123), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9127), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9132), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9136), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9140), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9145), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9150), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9151) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9154), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9158), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9163), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9167), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9171), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9175), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9180), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9185), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9189), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9193), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9198), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9202), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8589), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8596), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8599) });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8603), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "UserLevel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8779), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "UserLevel",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8790), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "WorkPosition",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8709), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "WorkPosition",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8717), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "WorkPosition",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8724), new DateTime(2025, 2, 2, 14, 28, 10, 597, DateTimeKind.Local).AddTicks(8726) });
        }
    }
}
