using car_rent_system.Contracts;
using car_rent_system.Models;
using Microsoft.AspNetCore.Mvc;

namespace car_rent_system.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userService.GetAllUsers();
            return Ok(users);
        }

        [HttpGet]
        [Route("/users/{Id}")]
        public async Task<IActionResult> GetUserById(int Id)
        {
            var user = await _userService.GetUser(Id);
            if (user == null)
            {
                return NotFound();
            }
            
            return Ok(user);
        }

        [HttpPost]
        [Route("/users")]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            var newUser = await _userService.CreateUser(user);
            return Created("/users", newUser);
        }

        [HttpPut]
        [Route("/users/{Id}")]
        public async Task<IActionResult> ModifyUser([FromRoute]int Id, User user)
        {
            var existingUser = await _userService.GetUser(Id);
            if (existingUser == null)
            {
                return NotFound();
            }
            await _userService.UpdateUser(user);
            return NoContent();
        }

        [HttpDelete]
        [Route("/users/{Id}")]
        public async Task<IActionResult> DeleteUser(int Id)
        {
            var userToRemove = await _userService.GetUser(Id);
            if (userToRemove == null)
            {
                return NotFound();
            }

            await _userService.RemoveUser(Id);
            return NoContent();
        }
    }
}