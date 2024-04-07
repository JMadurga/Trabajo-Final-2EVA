using Microsoft.AspNetCore.Mvc;
using Teatro_dos_facetas.Business;
using Teatro_dos_facetas.Data;
using Teatro_dos_facetas.Model;
using System.Collections.Generic;

namespace Teatro_dos_facetas.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class AsientoController :ControllerBase
    {

        private readonly AsientoService _asientoService;

        public AsientoController(AsientoService asientoService)
        {
            _asientoService = asientoService;
        }

        [HttpGet]
        public ActionResult<List<Asientos>> GetAll() => _asientoService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<AsientosDTO> Get(int id)
        {
            var asiento = _asientoService.Get(id);
            if (asiento == null)
                return NotFound();

             var asientosDTO = _asientoService.AsientoToDTO(asiento);
        

            return asientosDTO;
        } 
        [HttpPost]
        public IActionResult Create(AsientosDTO asientodto)
        {
            var asiento = _asientoService.AsientoDtoToAsiento(asientodto);
            _asientoService.Add(asiento);
            return CreatedAtAction(nameof(Get), new { id = asiento.id }, asiento);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, AsientosDTO asientosDTO)
        {

            var asiento = _asientoService.AsientoDtoToAsiento(asientosDTO);
            if (id != asiento.id)
                return BadRequest();

            var existingAsiento = _asientoService.Get(id);
            if (existingAsiento == null)
                return NotFound();

            _asientoService.Update(asiento);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var asiento = _asientoService.Get(id);

            if (asiento == null)
                return NotFound();

            _asientoService.Delete(id);

            return NoContent();
        }   
    }
}
    