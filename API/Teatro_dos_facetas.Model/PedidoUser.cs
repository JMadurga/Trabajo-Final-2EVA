
namespace Teatro_dos_facetas.Model
{
    
    public class PedidoUser
    {
        public int pedidoId { get; set; }
        public Pedidos pedido { get; set; }

        public int userId { get; set; }
        public Users user { get; set; }

    }
}