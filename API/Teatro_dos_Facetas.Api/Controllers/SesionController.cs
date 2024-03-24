using Microsoft.AspNetCore.Mvc;
using Teatro_dos_facetas.Model;
using Teatro_dos_Facetas.Business;

namespace Teatro_dos_facetas.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SesionController : ControllerBase
    {
        private readonly SesionService _sesionService;

        public SesionController(SesionService sesionService)
        {
            _sesionService = sesionService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var sesiones = _sesionService.GetAll();
            return Ok(sesiones);
        }

        [HttpGet("{id}")]
        public IActionResult GetSesionById(int id)
        {
            var sesion = _sesionService.GetSesionById(id);
            if (sesion == null)
            {
                return NotFound();
            }
            return Ok(sesion);
        }


        [HttpPost]
        public IActionResult CreateSesion([FromBody] Sesion sesion)
        {
            _sesionService.CreateSesion(sesion);
            return CreatedAtAction(nameof(GetSesionById), new { id = sesion.id }, sesion);
        }

        [HttpPut]
        public IActionResult UpdateSesion([FromBody] Sesion sesion)
        {
            _sesionService.UpdateSesion(sesion);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSesion(int id)
        {
            _sesionService.DeleteSesion(id);
            return NoContent();
        }
    }
}