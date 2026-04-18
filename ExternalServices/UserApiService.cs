namespace MiPrimerAPI.ExternalServices
{
    using System.Net.Http;
    using System.Text.Json;
    using MiPrimerAPI.Models;

    public class UserApiService
    {
        private readonly HttpClient _http;

        public UserApiService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<UserData>> GetUsers()
        {
            var response = await _http.GetAsync("https://reqres.in/api/users");

            if (!response.IsSuccessStatusCode)
                return new List<UserData>();

            var json = await response.Content.ReadAsStringAsync();

            var data = JsonSerializer.Deserialize<UserApiResponse>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return data?.Data ?? new List<UserData>();
        }
    }
}
