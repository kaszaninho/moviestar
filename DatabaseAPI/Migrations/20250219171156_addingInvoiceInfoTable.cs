using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseAPI.Migrations
{
    /// <inheritdoc />
    public partial class addingInvoiceInfoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InvoiceTemplateInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressStreet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    font = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hexHeaderColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sellerHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyerHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    itemHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    alertWithoutItems = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    alertItemsHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    alertWithoutPayments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    alertPaymentHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paymentHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    finalText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceTemplateInformation", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceTemplateInformation");
        }
    }
}
