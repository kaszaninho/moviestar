using DatabaseAPI.Models.Abstract;

namespace DatabaseAPI.Models.General
{
    public class Subscriber : DictionaryTable
    {
        public string? Email { get; set; }
    }
}
