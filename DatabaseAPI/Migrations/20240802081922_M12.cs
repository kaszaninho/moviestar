using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portal.Data.Migrations
{
    /// <inheritdoc />
    public partial class M12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_AspNetUsers_ClientId",
                table: "Actor");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ClientLevel_ClientLevelId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_AspNetUsers_ClientId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Movie_AspNetUsers_ClientId",
                table: "Movie");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_ClientId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkSchedule_Employee_EmployeeId",
                table: "WorkSchedule");

            migrationBuilder.DropTable(
                name: "ClientLevel");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "EmployeeLevel");

            migrationBuilder.DropIndex(
                name: "IX_WorkSchedule_EmployeeId",
                table: "WorkSchedule");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "WorkSchedule");

            migrationBuilder.RenameColumn(
                name: "ClientName",
                table: "Ticket",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Reservations",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_ClientId",
                table: "Reservations",
                newName: "IX_Reservations_UserId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Movie",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Movie_ClientId",
                table: "Movie",
                newName: "IX_Movie_UserId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Invoice",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_ClientId",
                table: "Invoice",
                newName: "IX_Invoice_UserId");

            migrationBuilder.RenameColumn(
                name: "ClientProgressToNextLevel",
                table: "AspNetUsers",
                newName: "UserProgressToNextLevel");

            migrationBuilder.RenameColumn(
                name: "ClientLevelId",
                table: "AspNetUsers",
                newName: "UserLevelId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_ClientLevelId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_UserLevelId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Actor",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Actor_ClientId",
                table: "Actor",
                newName: "IX_Actor_UserId");

            migrationBuilder.CreateTable(
                name: "UserLevel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PointsToNextLevel = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLevel", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_AspNetUsers_UserId",
                table: "Actor",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UserLevel_UserLevelId",
                table: "AspNetUsers",
                column: "UserLevelId",
                principalTable: "UserLevel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_AspNetUsers_UserId",
                table: "Invoice",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_AspNetUsers_UserId",
                table: "Movie",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_UserId",
                table: "Reservations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_AspNetUsers_UserId",
                table: "Actor");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UserLevel_UserLevelId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_AspNetUsers_UserId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Movie_AspNetUsers_UserId",
                table: "Movie");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_UserId",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "UserLevel");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Ticket",
                newName: "ClientName");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Reservations",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                newName: "IX_Reservations_ClientId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Movie",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Movie_UserId",
                table: "Movie",
                newName: "IX_Movie_ClientId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Invoice",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_UserId",
                table: "Invoice",
                newName: "IX_Invoice_ClientId");

            migrationBuilder.RenameColumn(
                name: "UserProgressToNextLevel",
                table: "AspNetUsers",
                newName: "ClientProgressToNextLevel");

            migrationBuilder.RenameColumn(
                name: "UserLevelId",
                table: "AspNetUsers",
                newName: "ClientLevelId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_UserLevelId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_ClientLevelId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Actor",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Actor_UserId",
                table: "Actor",
                newName: "IX_Actor_ClientId");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "WorkSchedule",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ClientLevel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PointsToNextLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLevel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    BankAccountId = table.Column<int>(type: "int", nullable: false),
                    EmployeeLevelId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wages = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WorkPositionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_BankAccount_BankAccountId",
                        column: x => x.BankAccountId,
                        principalTable: "BankAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_EmployeeLevel_EmployeeLevelId",
                        column: x => x.EmployeeLevelId,
                        principalTable: "EmployeeLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_WorkPosition_WorkPositionId",
                        column: x => x.WorkPositionId,
                        principalTable: "WorkPosition",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkSchedule_EmployeeId",
                table: "WorkSchedule",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_AddressId",
                table: "Employee",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_BankAccountId",
                table: "Employee",
                column: "BankAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmployeeLevelId",
                table: "Employee",
                column: "EmployeeLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_WorkPositionId",
                table: "Employee",
                column: "WorkPositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_AspNetUsers_ClientId",
                table: "Actor",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ClientLevel_ClientLevelId",
                table: "AspNetUsers",
                column: "ClientLevelId",
                principalTable: "ClientLevel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_AspNetUsers_ClientId",
                table: "Invoice",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_AspNetUsers_ClientId",
                table: "Movie",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_ClientId",
                table: "Reservations",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkSchedule_Employee_EmployeeId",
                table: "WorkSchedule",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
