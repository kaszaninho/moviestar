using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portal.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateCMSModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TitleName",
                table: "UsefulLink",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TitleName",
                table: "Topbar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TitleName",
                table: "Newsletter",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TitleName",
                table: "Navbar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TitleName",
                table: "ContactInformation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TitleName",
                table: "UsefulLink");

            migrationBuilder.DropColumn(
                name: "TitleName",
                table: "Topbar");

            migrationBuilder.DropColumn(
                name: "TitleName",
                table: "Newsletter");

            migrationBuilder.DropColumn(
                name: "TitleName",
                table: "Navbar");

            migrationBuilder.DropColumn(
                name: "TitleName",
                table: "ContactInformation");
        }
    }
}
