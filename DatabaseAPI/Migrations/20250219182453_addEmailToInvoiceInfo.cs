using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseAPI.Migrations
{
    /// <inheritdoc />
    public partial class addEmailToInvoiceInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "sellerHeader",
                table: "InvoiceTemplateInformation",
                newName: "SellerHeader");

            migrationBuilder.RenameColumn(
                name: "paymentHeader",
                table: "InvoiceTemplateInformation",
                newName: "PaymentHeader");

            migrationBuilder.RenameColumn(
                name: "itemHeader",
                table: "InvoiceTemplateInformation",
                newName: "ItemHeader");

            migrationBuilder.RenameColumn(
                name: "hexHeaderColor",
                table: "InvoiceTemplateInformation",
                newName: "HexHeaderColor");

            migrationBuilder.RenameColumn(
                name: "font",
                table: "InvoiceTemplateInformation",
                newName: "Font");

            migrationBuilder.RenameColumn(
                name: "finalText",
                table: "InvoiceTemplateInformation",
                newName: "FinalText");

            migrationBuilder.RenameColumn(
                name: "buyerHeader",
                table: "InvoiceTemplateInformation",
                newName: "BuyerHeader");

            migrationBuilder.RenameColumn(
                name: "alertWithoutPayments",
                table: "InvoiceTemplateInformation",
                newName: "AlertWithoutPayments");

            migrationBuilder.RenameColumn(
                name: "alertWithoutItems",
                table: "InvoiceTemplateInformation",
                newName: "AlertWithoutItems");

            migrationBuilder.RenameColumn(
                name: "alertPaymentHeader",
                table: "InvoiceTemplateInformation",
                newName: "AlertPaymentHeader");

            migrationBuilder.RenameColumn(
                name: "alertItemsHeader",
                table: "InvoiceTemplateInformation",
                newName: "AlertItemsHeader");

            migrationBuilder.AddColumn<string>(
                name: "AddressEmail",
                table: "InvoiceTemplateInformation",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressEmail",
                table: "InvoiceTemplateInformation");

            migrationBuilder.RenameColumn(
                name: "SellerHeader",
                table: "InvoiceTemplateInformation",
                newName: "sellerHeader");

            migrationBuilder.RenameColumn(
                name: "PaymentHeader",
                table: "InvoiceTemplateInformation",
                newName: "paymentHeader");

            migrationBuilder.RenameColumn(
                name: "ItemHeader",
                table: "InvoiceTemplateInformation",
                newName: "itemHeader");

            migrationBuilder.RenameColumn(
                name: "HexHeaderColor",
                table: "InvoiceTemplateInformation",
                newName: "hexHeaderColor");

            migrationBuilder.RenameColumn(
                name: "Font",
                table: "InvoiceTemplateInformation",
                newName: "font");

            migrationBuilder.RenameColumn(
                name: "FinalText",
                table: "InvoiceTemplateInformation",
                newName: "finalText");

            migrationBuilder.RenameColumn(
                name: "BuyerHeader",
                table: "InvoiceTemplateInformation",
                newName: "buyerHeader");

            migrationBuilder.RenameColumn(
                name: "AlertWithoutPayments",
                table: "InvoiceTemplateInformation",
                newName: "alertWithoutPayments");

            migrationBuilder.RenameColumn(
                name: "AlertWithoutItems",
                table: "InvoiceTemplateInformation",
                newName: "alertWithoutItems");

            migrationBuilder.RenameColumn(
                name: "AlertPaymentHeader",
                table: "InvoiceTemplateInformation",
                newName: "alertPaymentHeader");

            migrationBuilder.RenameColumn(
                name: "AlertItemsHeader",
                table: "InvoiceTemplateInformation",
                newName: "alertItemsHeader");
        }
    }
}
