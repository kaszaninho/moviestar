using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedInvoiceInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "InvoiceTemplateInformation",
                columns: new[] { "Id", "AddressCity", "AddressCompanyName", "AddressCountry", "AddressEmail", "AddressPhone", "AddressState", "AddressStreet", "AddressZipCode", "AlertItemsHeader", "AlertPaymentHeader", "AlertWithoutItems", "AlertWithoutPayments", "BuyerHeader", "FinalText", "Font", "HexHeaderColor", "ItemHeader", "PaymentHeader", "SellerHeader" },
                values: new object[] { 1, "Nowy Sącz", "MovieStar", "Polska", "info@gmail.com", "+48 553432354", "Małopolskie", "Biała 34", "33-300", "Brak biletów!", "Brak płatności!", "Nie ma żadnych dodanych biletów!", "Nie ma żadnych dokonanych płatności!", "Kupujący", "Dziękujemy i zapraszamy ponownie!", "Arial", "#FFF544", "Bilety", "Płatności", "Sprzedający" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InvoiceTemplateInformation",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
