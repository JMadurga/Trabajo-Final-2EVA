using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Teatro_dos_facetas.Model;
using Teatro_dos_Facetas.Business;

namespace Teatro_dos_Facetas.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidosController : ControllerBase
    {
        private readonly PedidosService _pedidosService;

        public PedidosController(PedidosService pedidosService)
        {
            _pedidosService = pedidosService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Pedidos>> GetPedidos()
        {
            var pedidos = _pedidosService.GetAll();
            return Ok(pedidos);
        }

        [HttpGet("{id}")]
        public ActionResult<Pedidos> GetPedido(int id)
        {
            var pedido = _pedidosService.GetPedidoById(id);
            if (pedido == null)
            {
                return NotFound();
            }
            return Ok(pedido);
        }

        [HttpPost]
        public ActionResult<Pedidos> CreatePedido(Pedidos pedido)
        {
            _pedidosService.CreatePedido(pedido);
            return CreatedAtAction(nameof(GetPedido), new { id = pedido.id }, pedido);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePedido(int id, Pedidos pedido)
        {
            if (id != pedido.id)
            {
                return BadRequest();
            }
            _pedidosService.UpdatePedido(pedido);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePedido(int id)
        {
            var pedido = _pedidosService.GetPedidoById(id);
            if (pedido == null)
            {
                return NotFound();
            }
            _pedidosService.DeletePedido(id);
            return NoContent();
        }
    }
}