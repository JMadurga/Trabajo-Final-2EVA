using Microsoft.AspNetCore.Mvc;
using Teatro_dos_facetas.Business;
using Teatro_dos_facetas.Data;
using Teatro_dos_facetas.Model;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Teatro_dos_facetas.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController :ControllerBase
    {

        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public UsersController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
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

    }
    
}