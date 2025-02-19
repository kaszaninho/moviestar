using System.Text.Json.Serialization;

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
