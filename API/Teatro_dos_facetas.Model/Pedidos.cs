using System.ComponentModel.DataAnnotations;

namespace Teatro_dos_facetas.Model
{
    public class Pedidos{

        [Key]
        public int id {get; set;}

        public double total {get; set;}

        public DateTime date {get; set;}

        public List<PedidoUser> pedidoUser{get; set;}

        public List<PedidoSesion> pedidoSesion{get; set;} 

        public List<PedidosAsiento> pedidoAsientos {get; set;}

    }
}