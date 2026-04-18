using Microsoft.AspNetCore.Mvc;
using MiPrimerAPI.Services;

namespace MiPrimerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExternalController : ControllerBase
    {
        private readonly ExternalApiService _apiService;

        public ExternalController(ExternalApiService apiService)
        {
            _apiService = apiService;
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _apiService.GetUsersAsync();
            return Ok(users); // 👈 ahora sí devuelve JSON limpio
        }
    }
}