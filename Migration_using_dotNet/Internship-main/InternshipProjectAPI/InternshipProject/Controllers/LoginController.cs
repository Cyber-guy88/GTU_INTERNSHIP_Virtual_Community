using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InternshipProject.Data.Repositories;
using DAL.Models;

namespace InternshipProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UserRepository _userRepository;

        public LoginController(UserRepository userRepository) {
            _userRepository = userRepository;
        }

        [HttpPost]
        public IActionResult Authenticate([FromBody] LoginRequest model)

        {
            var user = _userRepository.GetUserByUsername(model.Username);

            if (user == null || user.PasswordHash == model.Password) 
                return Unauthorized();

            return Ok("verified successfully");
        }
    }
}
