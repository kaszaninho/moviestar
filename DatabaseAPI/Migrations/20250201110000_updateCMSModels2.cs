using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portal.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateCMSModels2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "TitleName",
                table: "UsefulLink",
                newName: "Link");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "UsefulLink",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "UsefulLink",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "UsefulLink",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "UsefulLink",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UsefulLink",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Topbar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Topbar",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Topbar",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "Topbar",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Topbar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Newsletter",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Newsletter",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Newsletter",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "Newsletter",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Newsletter",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Navbar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Navbar",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Navbar",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "Navbar",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Navbar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ContactInformation",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInformation",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ContactInformation",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "ContactInformation",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ContactInformation",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "UsefulLink");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "UsefulLink");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "UsefulLink");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "UsefulLink");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Topbar");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Topbar");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "Topbar");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Topbar");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Newsletter");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Newsletter");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "Newsletter");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Newsletter");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Navbar");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Navbar");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "Navbar");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Navbar");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ContactInformation");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ContactInformation");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "ContactInformation");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ContactInformation");

            migrationBuilder.RenameColumn(
                name: "Link",
                table: "UsefulLink",
                newName: "TitleName");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "UsefulLink",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Topbar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleName",
                table: "Topbar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Newsletter",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleName",
                table: "Newsletter",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Navbar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleName",
                table: "Navbar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ContactInformation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleName",
                table: "ContactInformation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
