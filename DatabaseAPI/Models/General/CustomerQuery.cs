using DatabaseAPI.Models.Abstract;

namespace DatabaseAPI.Models.General
{
    public class CustomerQuery : DictionaryTable
    {
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public bool IsAnswered { get; set; }
    }
}