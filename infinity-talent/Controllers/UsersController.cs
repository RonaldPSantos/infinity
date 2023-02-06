using infinity_talent.Data.Services;
using infinity_talent.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace infinity_talent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public UsersService _userService;
        public UsersController(UsersService userService)
        {
            _userService = userService;
        }

        [HttpPost("add-user")]
        public IActionResult AddUser([FromBody] UserVM user)
        {
            _userService.AddUser(user);
            return Ok();
        }

        [HttpPut("update-user")]
        public IActionResult UpdateUser(int id, [FromBody] UserVM user)
        {
            var updateUser = _userService.UpdateUser(id, user);
            return Ok(updateUser);
        }

        [HttpGet("get-all-users")]
        public IActionResult GetAllUsers()
        {
            var allUsers = _userService.GetAllUsers();
            return Ok(allUsers);
        }

        [HttpGet("get-user-login")]
        public IActionResult GetUserLogin(string userName, string pass)
        {
            var userByName = _userService.GetUserLogin(userName, pass);
            return Ok(userByName);
        }

        [HttpGet("get-user-by-id")]
        public IActionResult GetUserById(int userId)
        {
            var userByID = _userService.GetUserByID(userId);
            return Ok(userByID);
        }
    }
}
