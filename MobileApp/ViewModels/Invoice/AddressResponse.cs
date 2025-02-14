using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.Invoice
{
    public class AddressResponse
    {
        [JsonPropertyName("street")]
        public string Street { get; set; }

        [JsonPropertyName("eirCode")]
        public string Eircode { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }
    }

}
