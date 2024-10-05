using DatabaseAPI.Models.CinemaMovie;

namespace PortalWWW.Models
{
    public class CartInformation
    {
        public List<CartElement>? CartElements { get; set; }
        public decimal? PriceTotal { get; set; }
    }
}
