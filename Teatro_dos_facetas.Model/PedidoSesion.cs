namespace Teatro_dos_facetas.Model
{
    
    public class PedidoSesion
    {
        public int pedidoId { get; set; }
        public Pedidos pedido { get; set; }

        public int sesionId { get; set; }
        public Sesion sesion { get; set; }

    }
}