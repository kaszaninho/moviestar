using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseAPI.Migrations
{
    /// <inheritdoc />
    public partial class changeNavbar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Link",
                table: "Navbar");

            migrationBuilder.AddColumn<string>(
                name: "Action",
                table: "Navbar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Controller",
                table: "Navbar",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Action",
                table: "Navbar");

            migrationBuilder.DropColumn(
                name: "Controller",
                table: "Navbar");

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Navbar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
