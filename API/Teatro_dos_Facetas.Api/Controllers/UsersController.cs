using Microsoft.AspNetCore.Mvc;
using Teatro_dos_facetas.Business;
using Teatro_dos_facetas.Data;
using Teatro_dos_facetas.Model;
using System.Collections.Generic;

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
        
        [HttpGet]
        public ActionResult<List<Users>> GetAll() => _userService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Users> Get(int id)
        {
            try
            {
                var user = _userService.Get(id);
                return user;
            }
            catch (System.Exception)
            {
                                
                return NotFound();
                throw;
            }

        } 
        [HttpPost]
        public IActionResult Create(Users user)
        {
            _userService.Add(user);
            return CreatedAtAction(nameof(Get), new { id = user.id }, user);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Users user)
        {
            try
            {
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