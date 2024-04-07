using System.ComponentModel.DataAnnotations.Schema;

namespace Teatro_dos_facetas.Model
{
    
    public class PedidosAsiento
    {
        [ForeignKey("pedido")]
        public int pedidoId { get; set; }
        public Pedidos pedido { get; set; }

        [ForeignKey("asientos")]
        public int asientoId { get; set; }
        public AsientosOcupados asientos { get; set; }

    }
}