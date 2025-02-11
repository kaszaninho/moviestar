using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseAPI.Migrations
{
    /// <inheritdoc />
    public partial class correctingTableState : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Country_CountryId",
                table: "Actor");

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Actor_ActorId",
                table: "Photo");

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Director_DirectorId",
                table: "Photo");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Photo_ActorId",
                table: "Photo");

            migrationBuilder.DropIndex(
                name: "IX_Photo_DirectorId",
                table: "Photo");

            migrationBuilder.DropColumn(
                name: "ActorId",
                table: "Photo");

            migrationBuilder.DropColumn(
                name: "DirectorId",
                table: "Photo");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Director",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Actor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Actor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Country_CountryId",
                table: "Actor",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Country_CountryId",
                table: "Actor");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Director");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Actor");

            migrationBuilder.AddColumn<int>(
                name: "ActorId",
                table: "Photo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DirectorId",
                table: "Photo",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Actor",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScreeningId = table.Column<int>(type: "int", nullable: true),
                    SeatId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsExpired = table.Column<bool>(type: "bit", nullable: false),
                    IsRealized = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReservationNumber = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservations_Screening_ScreeningId",
                        column: x => x.ScreeningId,
                        principalTable: "Screening",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservations_Seat_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seat",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photo_ActorId",
                table: "Photo",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_DirectorId",
                table: "Photo",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ScreeningId",
                table: "Reservations",
                column: "ScreeningId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_SeatId",
                table: "Reservations",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Country_CountryId",
                table: "Actor",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Actor_ActorId",
                table: "Photo",
                column: "ActorId",
                principalTable: "Actor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Director_DirectorId",
                table: "Photo",
                column: "DirectorId",
                principalTable: "Director",
                principalColumn: "Id");
        }
    }
}
