using DatabaseAPI.Models.Abstract;

namespace DatabaseAPI.Models.CinemaMovie
{
    public class Coupon : DictionaryTable
    {
        public int Discount { get; set; }
    }
}
