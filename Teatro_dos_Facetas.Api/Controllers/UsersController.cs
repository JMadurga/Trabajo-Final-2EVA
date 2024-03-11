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
            var user = _userService.Get(id);

            if (user == null)
                return NotFound();

            return user;
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
            if (id != user.id)
                return BadRequest();

            var existingUser = _userService.Get(id);
            if (existingUser == null)
                return NotFound();

            _userService.Update(user);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = _userService.Get(id);

            if (user == null)
                return NotFound();

            _userService.Delete(id);

            return NoContent();
        }   
    }
    
}