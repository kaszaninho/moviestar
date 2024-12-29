using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portal.Data.Migrations
{
    /// <inheritdoc />
    public partial class ModifySeats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ScreeningSeatId",
                table: "Ticket",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeatId",
                table: "ScreeningSeat",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_ScreeningSeatId",
                table: "Ticket",
                column: "ScreeningSeatId");

            migrationBuilder.CreateIndex(
                name: "IX_ScreeningSeat_SeatId",
                table: "ScreeningSeat",
                column: "SeatId");

            migrationBuilder.AddForeignKey(
                name: "FK_ScreeningSeat_Seat_SeatId",
                table: "ScreeningSeat",
                column: "SeatId",
                principalTable: "Seat",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_ScreeningSeat_ScreeningSeatId",
                table: "Ticket",
                column: "ScreeningSeatId",
                principalTable: "ScreeningSeat",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScreeningSeat_Seat_SeatId",
                table: "ScreeningSeat");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_ScreeningSeat_ScreeningSeatId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_ScreeningSeatId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_ScreeningSeat_SeatId",
                table: "ScreeningSeat");

            migrationBuilder.DropColumn(
                name: "ScreeningSeatId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "SeatId",
                table: "ScreeningSeat");
        }
    }
}
