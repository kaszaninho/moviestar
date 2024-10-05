using DatabaseAPI.Models.Abstract;

namespace DatabaseAPI.Models.General.DictionaryModels
{
    public class PaymentMethod : DictionaryTable
    {
        public ICollection<Invoice> Invoices { get; set; }

    }
}
