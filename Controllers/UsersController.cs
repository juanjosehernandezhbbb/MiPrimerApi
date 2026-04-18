namespace MiPrimerAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MiPrimerAPI.ExternalServices;

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UserApiService _service;

        public UsersController(UserApiService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _service.GetUsers();
            return Ok(users);
        }
    }
}
