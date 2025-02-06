using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseAPI.Migrations
{
    /// <inheritdoc />
    public partial class addStripeToProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "InvoiceId",
                table: "Invoice",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderStatus",
                table: "Invoice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentStatus",
                table: "Invoice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StripePaymentIntentId",
                table: "Invoice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StripeSessionId",
                table: "Invoice",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderStatus",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "StripePaymentIntentId",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "StripeSessionId",
                table: "Invoice");

            migrationBuilder.AlterColumn<Guid>(
                name: "InvoiceId",
                table: "Invoice",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2813), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2815) });

            migrationBuilder.UpdateData(
                table: "UserLevel",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2818), new DateTime(2025, 2, 2, 10, 21, 25, 154, DateTimeKind.Local).AddTicks(2820) });

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
    }
}
