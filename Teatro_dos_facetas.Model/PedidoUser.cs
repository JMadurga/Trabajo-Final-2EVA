
namespace Teatro_dos_facetas.Model
{
    
    public class PedidoUser
    {
        public int PedidoId { get; set; }
        public Pedidos pedido { get; set; }

        public int UserId { get; set; }
        public Users user { get; set; }

    }
}