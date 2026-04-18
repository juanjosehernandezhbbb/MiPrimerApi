
using MiPrimerAPI.Services; 
using Microsoft.AspNetCore.Mvc;
    using MiPrimerAPI.Services;

    namespace MiPrimerAPI.Controllers
    {
        [ApiController]
        [Route("api/[controller]")]
        public class ExternalUsersController : ControllerBase
        {
            private readonly ExternalApiService _service;

            public ExternalUsersController(ExternalApiService service)
            {
                _service = service;
            }

            [HttpGet]
            public async Task<IActionResult> GetUsers()
            {
                var result = await _service.GetUsersAsync();
                return Ok(result);
            }
        }
    }

