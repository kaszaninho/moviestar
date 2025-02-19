using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DatabaseAPI.Models.CMS
{
    public class InvoiceTemplateInformation
    {
        [Key]
        public int Id { get; set; }
        public string? AddressStreet { get; set; }
        public string? AddressCountry { get; set; }
        public string? AddressCity { get; set; }
        public string? AddressZipCode { get; set; }
        public string? AddressPhone { get; set; }
        public string? AddressCompanyName { get; set; }
        public string? AddressState { get; set; }
        public string? AddressEmail { get; set; }
        public string? Font { get; set; }
        public string? HexHeaderColor { get; set; }
        public string? SellerHeader { get; set; }
        public string? BuyerHeader { get; set; }
        public string? ItemHeader { get; set; }
        public string? AlertWithoutItems { get; set; }
        public string? AlertItemsHeader { get; set; }
        public string? AlertWithoutPayments { get; set; }
        public string? AlertPaymentHeader { get; set; }
        public string? PaymentHeader { get; set; }
        public string? FinalText { get; set; }
    }
}
