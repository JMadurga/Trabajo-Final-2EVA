using System.ComponentModel.DataAnnotations;

namespace Teatro_dos_facetas.Model
{
    public class AsientosOcupados{

        [Key]
        public int id {get; set;}
        
        public Sesion sesion {get; set;}

        public List<Asientos> asientosOcupados {get; set;}

        public List<PedidosAsiento> pedidoAsientos { get; set; }

    }
}