using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.PaymentMethod
{
    public class PaymentMethodResponse
    {
        [JsonPropertyName("methodId")]
        public int? MethodId { get; set; }
        [JsonPropertyName("methodName")]
        public string? MethodName { get; set; }
    }
}
