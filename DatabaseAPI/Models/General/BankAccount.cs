using DatabaseAPI.Models.Abstract;

namespace DatabaseAPI.Models.General
{
    public class BankAccount : DictionaryTable
    {
        public string AccountNumber { get; set; }
        public string OwnerName { get; set; }
        public string? Bank { get; set; }

    }
}
