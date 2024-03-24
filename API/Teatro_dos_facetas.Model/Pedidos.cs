using System.ComponentModel.DataAnnotations;

namespace Teatro_dos_facetas.Model
{
    public class Pedidos{

        [Key]
        public int id {get; set;}

        public PedidoUser pedidoUser{get; set;}

        public PedidoSesion pedidoSesion{get; set;} 

        public List<Asientos> pedidoAsientos {get; set;}

    }
}