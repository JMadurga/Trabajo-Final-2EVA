using Microsoft.AspNetCore.Mvc;
using Teatro_dos_facetas.Business;
using Teatro_dos_facetas.Data;
using Teatro_dos_facetas.Model;
using System.Collections.Generic;

namespace Teatro_dos_facetas.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class ObraController :ControllerBase
    {

        private readonly ObraService _obraService;

        public ObraController(ObraService obraService)
        {
            _obraService = obraService;
        }
        
        [HttpGet]
        public ActionResult<List<Obras>> GetAll() => _obraService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Obras> Get(int id)
        {
            var obra = _obraService.Get(id);

            if (obra == null)
                return NotFound();

            return obra;
        } 
        [HttpPost]
        public IActionResult Create([FromBody] Obras obra)
        {
            _obraService.Add(obra);
            return CreatedAtAction(nameof(Get), new { id = obra.id }, obra);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Obras obra)
        {
            if (id != obra.id)
                return BadRequest();

            var existingObra = _obraService.Get(id);
            if (existingObra == null)
                return NotFound();

            _obraService.Update(obra);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var obra = _obraService.Get(id);

            if (obra == null)
                return NotFound();

            _obraService.Delete(id);

            return NoContent();
        }   
    }
    
}