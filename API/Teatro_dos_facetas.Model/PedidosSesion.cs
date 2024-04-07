using System.ComponentModel.DataAnnotations.Schema;

namespace Teatro_dos_facetas.Model
{
    public class PedidosSesion
    {
        [ForeignKey("pedido")]
        public int pedidoId { get; set; }
        public Pedidos pedido { get; set; }

        [ForeignKey("sesion")]
        public int sesionId { get; set; }
        public Sesion sesion { get; set; }
      
    }
}
