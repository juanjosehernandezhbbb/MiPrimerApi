using MiPrimerAPI.Models;
using MiPrimerAPI.Models.MiPrimerAPI.Models;
using System.Net.Http;
using System.Text.Json;

namespace MiPrimerAPI.Services
{
    public class ExternalApiService
    {
        private readonly HttpClient _httpClient;

        public ExternalApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            if (!_httpClient.DefaultRequestHeaders.Contains("x-api-key"))
            {
                _httpClient.DefaultRequestHeaders.Add("x-api-key", "TU_API_KEY");
            }

            var response = await _httpClient.GetAsync("https://reqres.in/api/users?page=1");

        https://localhost:7011/swaggerresponse.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            var users = JsonSerializer.Deserialize<UserResponse>(
                content,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return users?.Data ?? new List<User>();
        }
    }
}