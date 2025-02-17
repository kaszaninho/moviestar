using DatabaseAPI.Models.Abstract;

namespace DatabaseAPI.Models.General
{
    public class OpeningHour : DictionaryTable
    {
        public int? StartHour { get; set; }
        public int? EndHour { get; set; }
    }
}
