using DatabaseAPI.Models.Abstract;

namespace DatabaseAPI.Models.People
{
    public class UserLevel : DictionaryTable
    {
        public int PointsToNextLevel { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
