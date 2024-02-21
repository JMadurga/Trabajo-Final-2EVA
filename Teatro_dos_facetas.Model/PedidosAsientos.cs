namespace Teatro_dos_facetas.Model
{
    
    public class PedidoAsiento
    {
        public int pedidoId { get; set; }
        public Pedidos pedido { get; set; }

        public int asientoId { get; set; }
        public Asientos asiento { get; set; }

    }
}