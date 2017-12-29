using Microsoft.AspNetCore.Mvc;
using onlineStore.Data;
using onlineStore.Dtos;
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
        public async Task<IActionResult> Register([FromBody]UserToRegisterDto adminForRegistration)
        {
            //validate requeste

            adminForRegistration.Username = adminForRegistration.Username.ToLower();

            if (await _repo.AdministratorExists(adminForRegistration.Username))
                ModelState.AddModelError("Username", "Username already exists");

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var adminToCreate = new Administrator
            {
                Username = adminForRegistration.Username
            };

            var createAdmin = await _repo.Register(adminToCreate, adminForRegistration.Password);

            return StatusCode(201);
        }
    }
}
