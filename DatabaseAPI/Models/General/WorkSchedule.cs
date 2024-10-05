using DatabaseAPI.Models.Abstract;
using DatabaseAPI.Models.People;

namespace DatabaseAPI.Models.General
{
    public class WorkSchedule : DictionaryTable
    {
        public int YearDate { get; set; }
        public int DayNumber { get; set; }
        public int StartHour { get; set; }
        public int StartMinute { get; set; }
        public int EndHour { get; set; }
        public int EndMinute { get; set; }
        //public Employee Employee { get; set; }
        //public int EmployeeId { get; set; }
    }
}
