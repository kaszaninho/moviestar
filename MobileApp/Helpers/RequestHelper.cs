using System.Text.Json;
using static MobileApp.Services.AppSettings;

namespace MobileApp.Helpers
{
    public class RequestHelper
    {
        public static async Task<ResponseType> SendRequestAsync<RequestType, ResponseType>(string url, HttpMethod method, RequestType? request, string? token)
        {
            HttpClient client = new()
            {
                BaseAddress = new(API_URL)
            };

            HttpResponseMessage response;
            HttpRequestMessage message = new(method, url);

            if (token != null)
            {
                message.Headers.Authorization = new("Bearer", token);
            }
            if (method != HttpMethod.Get && request != null)
            {
                message.Content = new StringContent(JsonSerializer.Serialize(request), System.Text.Encoding.UTF8, "application/json");
            }

            response = await client.SendAsync(message);
            string responseString = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                return JsonSerializer.Deserialize<ResponseType>(responseString) ?? throw new ArgumentException(responseString);
            }

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                throw new UnauthorizedAccessException(responseString);
            }
            if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
            {
                throw new UnauthorizedAccessException(responseString);
            }
            throw new Exception(responseString);
        }

        public static async Task<bool> SendRequestAsync<RequestType>(string url, HttpMethod method, RequestType? request, string? token)
        {
            HttpClient client = new()
            {
                BaseAddress = new(API_URL)
            };

            HttpResponseMessage response;
            HttpRequestMessage message = new(method, url);

            if (token != null)
            {
                message.Headers.Authorization = new("Bearer", token);
            }
            if (method != HttpMethod.Get)
            {
                message.Content = new StringContent(JsonSerializer.Serialize(request), System.Text.Encoding.UTF8, "application/json");
            }

            response = await client.SendAsync(message);

            if (!response.IsSuccessStatusCode)
            {
                string responseString = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    throw new UnauthorizedAccessException(responseString);
                }
                if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
                {
                    throw new UnauthorizedAccessException(responseString);
                }
                throw new Exception(responseString);
            }
            return true;
        }

        public static async Task<ResponseType> SendRequestAsync<ResponseType>(string url, HttpMethod method, string? token)
        {
            HttpClient client = new()
            {
                BaseAddress = new(API_URL)
            };

            HttpResponseMessage response;
            HttpRequestMessage message = new(method, url);

            if (token != null)
            {
                message.Headers.Authorization = new("Bearer", token);
            }

            response = await client.SendAsync(message);
            string responseString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {

                if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    throw new UnauthorizedAccessException(responseString);
                }
                if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
                {
                    throw new UnauthorizedAccessException(responseString);
                }
                throw new Exception(responseString);
            }

            return JsonSerializer.Deserialize<ResponseType>(responseString) ?? throw new ArgumentException(responseString);
        }
    }
}
