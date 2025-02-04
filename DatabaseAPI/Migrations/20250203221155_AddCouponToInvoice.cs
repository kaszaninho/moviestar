using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCouponToInvoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartElement_ScreeningSeat_ScreeningSeatId",
                table: "CartElement");

            migrationBuilder.DropColumn(
                name: "CouponNumber",
                table: "Coupon");

            migrationBuilder.DropColumn(
                name: "MovieOrCafeUsage",
                table: "Coupon");

            migrationBuilder.DropColumn(
                name: "UsedAt",
                table: "Coupon");

            migrationBuilder.RenameColumn(
                name: "Sum",
                table: "Invoice",
                newName: "TotalSum");

            migrationBuilder.AddColumn<decimal>(
                name: "CouponDiscount",
                table: "Invoice",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CouponId",
                table: "Invoice",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TicketSum",
                table: "Invoice",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ScreeningSeatId",
                table: "CartElement",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CouponId",
                table: "CartElement",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AgeRating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AgeRating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AgeRating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Award",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Award",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1974, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfBirth", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieFormat",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieFormat",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieKeywords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieKeywords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieKeywords",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieProductionCompany",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieProductionCompany",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieProductionCompany",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screen",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screen",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screen",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Subtitles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserLevel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserLevel",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkPosition",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkPosition",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkPosition",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_CouponId",
                table: "Invoice",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_CartElement_CouponId",
                table: "CartElement",
                column: "CouponId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartElement_Coupon_CouponId",
                table: "CartElement",
                column: "CouponId",
                principalTable: "Coupon",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartElement_ScreeningSeat_ScreeningSeatId",
                table: "CartElement",
                column: "ScreeningSeatId",
                principalTable: "ScreeningSeat",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Coupon_CouponId",
                table: "Invoice",
                column: "CouponId",
                principalTable: "Coupon",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartElement_Coupon_CouponId",
                table: "CartElement");

            migrationBuilder.DropForeignKey(
                name: "FK_CartElement_ScreeningSeat_ScreeningSeatId",
                table: "CartElement");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Coupon_CouponId",
                table: "Invoice");

            migrationBuilder.DropIndex(
                name: "IX_Invoice_CouponId",
                table: "Invoice");

            migrationBuilder.DropIndex(
                name: "IX_CartElement_CouponId",
                table: "CartElement");

            migrationBuilder.DropColumn(
                name: "CouponDiscount",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "CouponId",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "TicketSum",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "CouponId",
                table: "CartElement");

            migrationBuilder.RenameColumn(
                name: "TotalSum",
                table: "Invoice",
                newName: "Sum");

            migrationBuilder.AddColumn<string>(
                name: "CouponNumber",
                table: "Coupon",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MovieOrCafeUsage",
                table: "Coupon",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UsedAt",
                table: "Coupon",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ScreeningSeatId",
                table: "CartElement",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9899), new DateTime(2025, 2, 2, 14, 53, 38, 415, DateTimeKind.Local).AddTicks(9900) });

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

            migrationBuilder.AddForeignKey(
                name: "FK_CartElement_ScreeningSeat_ScreeningSeatId",
                table: "CartElement",
                column: "ScreeningSeatId",
                principalTable: "ScreeningSeat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
