using Microsoft.AspNetCore.Mvc;
using onlineStore.Data;
using onlineStore.Models;
using System.Threading.Tasks;

namespace onlineStore.Controllers
{
    [Route("api/[controller]")]
    public class AuthController: Controller
    {
        private readonly IAuthRepository _repo;

        public AuthController(IAuthRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("register")]

        public async Task<IActionResult> Register(string username, string password)
        {
            //validate requeste

            username = username.ToLower();

            if (await _repo.AdministratorExists(username))
                return BadRequest("Username is already taken");

            var adminToCreate = new Administrator
            {
                Username = username
            };

            var createAdmin = await _repo.Register(adminToCreate, password);

            return StatusCode(201);
        }
    }
}
