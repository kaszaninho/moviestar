using DatabaseAPI.Models.CinemaMovie;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalWWW.Models
{
    public class CartInformation
    {
        public List<CartElement>? CartElements { get; set; }
        public decimal? PriceTotal { get; set; }
        [NotMapped]
        public string? PaymentMethod { get; set; }
    }
}
