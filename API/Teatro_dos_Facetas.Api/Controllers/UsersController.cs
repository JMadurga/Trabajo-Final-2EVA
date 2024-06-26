using Microsoft.AspNetCore.Mvc;
using Teatro_dos_facetas.Business;
using Teatro_dos_facetas.Data;
using Teatro_dos_facetas.Model;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Teatro_dos_Facetas.Business;

namespace Teatro_dos_facetas.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController :ControllerBase
    {

        private readonly UserService _userService;
        private readonly AuthService _authService;

        public UsersController(UserService userService, AuthService authService)
        {
            _userService = userService;
            _authService = authService;
        }
            

        [HttpGet]
        public ActionResult<List<Users>> GetAll() => _userService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<UserCreateDTO> Get(int id)
        {

            try
            {
                return _userService.UserToDTO(_userService.Get(id));
            }
            catch (System.Exception)
            {
                                
                return NotFound();
                throw;
            }

        } 
        [HttpPost]
        public IActionResult Create(UserCreateDTO userdto)
        {
            var user = _userService.UserDtoToUser(userdto);

            _userService.Add(user);
            return CreatedAtAction(nameof(Get), new { id = user.id }, user);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, UserCreateDTO userdto)
        {
            try
            {
                var user = _userService.UserDtoToUser(userdto);
                if (id != user.id)
                    return BadRequest();

                var existingUser = _userService.Get(id);

                if (existingUser == null)
                    return NotFound();

                _userService.Update(user);

                return NoContent();
            }
            catch (System.Exception)
            {
                // Handle the exception here
                return StatusCode(500, "An error occurred while updating the user.");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var user = _userService.Get(id);

                if (user == null)
                    return NotFound();

                _userService.Delete(id);

                return NoContent();
            }
            catch (System.Exception)
            {
                // Handle the exception here
                return StatusCode(500, "An error occurred while deleting the user.");
            }
        } 

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDtoIn loginDtoIn)
        {
            try
            {
                var user = _authService.Login(loginDtoIn);

                if (user == null)
                    return NotFound();

                return Ok(user);
            }
            catch (System.Exception e)
            {
                // Handle the exception here
                Console.WriteLine(e);
                return StatusCode(500, "An error occurred while logging in.");
            }
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] UserCreateDTO userDtoIn)
        {
            try
            {
                var user = _authService.Register(userDtoIn);

                if (user == null)
                    return BadRequest();

                return Ok();
            }
            catch (System.Exception)
            {
                // Handle the exception here
                return StatusCode(500, "An error occurred while registering the user.");
            }
        }

    }
    
}