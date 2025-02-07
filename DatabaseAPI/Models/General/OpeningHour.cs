using DatabaseAPI.Models.Abstract;

namespace DatabaseAPI.Models.General
{
    public class OpeningHour : DictionaryTable
    {
        public int StartHour { get; set; }
        public int EndHour { get; set; }
        public int WeekDay { get; set; }
        // Foreign key to the Store
        public int AddressId { get; set; }
        public Address Store { get; set; }
    }
}
